using System;

namespace Queues
{
    public static class RadixSortArrayQueue
    {
        // หาจำนวนหลักมากที่สุดในอาร์เรย์
        private static int GetMaxIndexCount(double[] array)
        {
            int maxInt = 0;
            foreach (var num in array)
            {
                int digitCount = (int)Math.Floor(Math.Log10(Math.Abs(num)) + 1);
                maxInt = Math.Max(maxInt, digitCount);
            }
            return maxInt;
        }

        // ฟังก์ชัน Radix Sort หลัก
        private static double[] RadixSort(double[] array)
        {
            int maxIntCount = GetMaxIndexCount(array);
            ArrayQueue[] buckets = CreateBuckets();

            for (int index = 0; index < maxIntCount; index++)
            {
                DistributeToBuckets(array, buckets, index);
                CollectFromBuckets(array, buckets);
            }
            return array;
        }

        // สร้างอาร์เรย์ของถัง (ArrayQueue) 10 ถัง
        private static ArrayQueue[] CreateBuckets()
        {
            Queue[] buckets = new ArrayQueue[10];
            for (int i = 0; i < 10; i++)
            {
                buckets[i] = new ArrayQueue(10);
            }
            return (ArrayQueue[])buckets;
        }

        // แจกจ่ายตัวเลขลงในถังตามหลักที่กำลังจัดการ
        private static void DistributeToBuckets(double[] array, ArrayQueue[] buckets, int index)
        {
            foreach (var num in array)
            {
                int digitValue = (int)(Math.Abs(num) / Math.Pow(10, index)) % 10;
                buckets[digitValue].enqueue(num);
            }
        }

        // ดึงตัวเลขจากถังมาใส่กลับในอาร์เรย์
        private static void CollectFromBuckets(double[] array, ArrayQueue[] buckets)
        {
            int index = 0;
            foreach (var bucket in buckets)
            {
                while (!bucket.isEmpty())
                {
                    array[index++] = (double)bucket.dequeue();
                }
            }
        }

        // ฟังก์ชันเรียกใช้สำหรับการจัดเรียง Radix Sort
        public static double[] Sort(double[] array)
        {
            return RadixSort(array);
        }
    }
}
