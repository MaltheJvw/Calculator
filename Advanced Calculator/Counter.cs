using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Calculator
{
    class Counter
    {
        private static int Count;
        public static void Increment()
        {
            Count++;
        }
        public static void Reset()
        {
            Count = 0;
        }

        public static async Task Interaction()
        {
            
            while (true)
            {
                // Asynchronously wait for a key press without blocking the program
                var keyInfo = await Task.Run(() => Console.ReadKey(true));

                if (Count > 0 && keyInfo.Key == ConsoleKey.C)
                {

                    Reset();
                    await Program.Main();
                }
            }
        }
        public static int GetCount()
        {
            return Count;
        }

    }
}
