using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Calculator
{
    public interface ICalculator
    {

        void Menu();
        void basic();
        void complex();


    }

    public class Calculator : ICalculator
    {
        public void Menu()
        {
            Console.WriteLine("Calculator");
            Console.WriteLine("1 basic");
            Console.WriteLine("2 complex");
            Console.WriteLine("3 intense");
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            switch (keyInfo.Key)
            {
                case ConsoleKey.D1:
                    basic();
                    break;

                case ConsoleKey.D2:
                    complex();
                    break;
            }
        }

        

        public void basic()
        {
            Basic.Input();
            
        }

        public void complex()
        {

        }

    }
}
