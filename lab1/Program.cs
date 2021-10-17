using System;

namespace lab1
{
    class Program
    {
        static void Main()
        {
            BJJPracticioner practitioner = new WhiteBelt();
            Console.WriteLine("[New White Belt object has been created.]");

            practitioner.Train();
            practitioner.Eat();

            int gen = GC.GetGeneration(practitioner);
            Console.WriteLine($"[White Belt's generation is {gen}.]");

            practitioner.Dispose();
            Console.WriteLine();

            GC.ReRegisterForFinalize(practitioner);

            long bytesBefore = GC.GetTotalMemory(false);
            Console.WriteLine($"Number of bytes before creating 50 000 objects: {bytesBefore}.");
            
            // For activating garbage collector.
            for(int i = 0; i < 50_000; i++)
            {
                Object obj = new Object();
            }

            long bytesBeforeGC = GC.GetTotalMemory(false);
            Console.WriteLine($"Number of bytes after creating 50 000 objects: {bytesBeforeGC}.");

            GC.Collect();
            GC.WaitForPendingFinalizers();

            long bytesAfter = GC.GetTotalMemory(true);
            Console.WriteLine($"Number of bytes after creating 10 000 objects and activating GC: {bytesAfter}.");
        }
    }
}
