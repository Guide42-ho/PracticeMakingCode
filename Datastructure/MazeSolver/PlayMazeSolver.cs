using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeSolver
{
    public class PlayMazeSolver
    {
        static void Main()
        {
            // กำหนดเขาวงกตในรูปแบบ 2D Array
            char[,] maze = {
            {'S', '0', '1', '1'},
            {'1', '0', '1', 'E'},
            {'1', '0', '0', '0'},
            {'1', '1', '1', '1'}
        };

            // เริ่มการแก้ปัญหาเขาวงกต
            SolveMaze(maze);
        }

        static void SolveMaze(char[,] maze)
        {
            // หาตำแหน่งเริ่มต้น (S)
            (int, int) start = FindStart(maze);
            int i = start.Item1, j = start.Item2;

            // แสดงเขาวงกตพร้อมตำแหน่งเริ่มต้น
            Display(maze, i, j);

            // สร้าง stack เพื่อเก็บตำแหน่งที่ต้องสำรวจ
            Stack<(int, int)> stack = new Stack<(int, int)>();

            // สร้าง list เพื่อเก็บเส้นทางที่เดินผ่าน
            List<(int, int)> path = new List<(int, int)>();

            // ทำการวน loop จนกว่าจะเจอจุดสิ้นสุด (E)
            while (maze[i, j] != 'E')
            {
                // ทำเครื่องหมายตำแหน่งที่ผ่านไปแล้วด้วย '.'
                maze[i, j] = '.';
                path.Add((i, j));

                // ตรวจสอบตำแหน่งข้างเคียง (บน, ล่าง, ซ้าย, ขวา)
                foreach (var (m, n) in new List<(int, int)>
                {
                    (i - 1, j), (i + 1, j), (i, j - 1), (i, j + 1)
                })
                {
                    // ถ้าตำแหน่งนั้นสามารถไปได้ (เป็น '0' หรือ 'E') ให้เพิ่มลง stack
                    if (IsValid(maze, m, n) && (maze[m, n] == '0' || maze[m, n] == 'E'))
                    {
                        stack.Push((m, n));
                        if(maze[m, n] == 'E')
                            Console.WriteLine("Can exit!");
                    }
                }

                // ถ้ามีตำแหน่งใน stack ให้ดึงออกมาและเดินไปยังตำแหน่งนั้น
                if (stack.Count > 0)
                {
                    var pos = stack.Pop();
                    i = pos.Item1;
                    j = pos.Item2;
                }
                else
                {
                    // ถ้า stack ว่าง หมายความว่าไม่สามารถออกจากเขาวงกตได้
                    Console.WriteLine("Cannot exit!");
                    break;
                }
            }

            // แสดงเขาวงกตพร้อมตำแหน่งสุดท้ายที่หยุดอยู่
            Display(maze, i, j);
        }

        // Method สำหรับค้นหาตำแหน่งเริ่มต้น (S)
        static (int, int) FindStart(char[,] maze)
        {
            for (int i = 0; i < maze.GetLength(0); i++)
            {
                for (int j = 0; j < maze.GetLength(1); j++)
                {
                    if (maze[i, j] == 'S')
                    {
                        return (i, j);
                    }
                }
            }

            // ถ้าไม่พบตำแหน่งเริ่มต้นให้โยน Exception
            throw new Exception("Start not found!");
        }

        // ตรวจสอบว่าตำแหน่งที่เลือกนั้นอยู่ในขอบเขตของเขาวงกตหรือไม่
        static bool IsValid(char[,] maze, int i, int j)
        {
            return i >= 0 && i < maze.GetLength(0) && j >= 0 && j < maze.GetLength(1);
        }

        // Method สำหรับแสดงเขาวงกตและตำแหน่งปัจจุบัน
        static void Display(char[,] maze, int i, int j)
        {
            Console.WriteLine($"Current Position: ({i}, {j})");
            for (int row = 0; row < maze.GetLength(0); row++)
            {
                for (int col = 0; col < maze.GetLength(1); col++)
                {
                    Console.Write(maze[row, col] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
