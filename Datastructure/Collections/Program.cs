using System;
using Collections;

using Sets;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Set x = new ArraySet(3);
            x.add(1);
            x.add(2);
            x.add(3);
            x.remove(1);
            Console.WriteLine(x.isEmpty());
            Console.WriteLine(x.size());
            Console.WriteLine(x.contains(3));
            
        }
    }


}

