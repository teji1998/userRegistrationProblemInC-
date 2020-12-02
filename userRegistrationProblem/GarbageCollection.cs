using System;
using System.Collections.Generic;
using System.Text;

namespace userRegistrationProblem
{
    class GarbageCollection
    {
        public void garbageCollection()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Welcome to the world of memory garbage");
            long memory1 = GC.GetTotalMemory(false);
            {
                int[] value = new int[50000];
                value = null;
            }
            long memory2 = GC.GetTotalMemory(false);
            {
                GC.Collect();
            }
            long memory3 = GC.GetTotalMemory(false);
            {
                Console.WriteLine(memory1);
                Console.WriteLine(memory2);
                Console.WriteLine(memory3);
            }
        }
    }
}
