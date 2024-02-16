using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Calculator
{
    public class Basic
    {
        public static void Input()
        {
            Console.Clear();
            Console.WriteLine("CALCULATOR\n");

            Console.WriteLine("________________________\n");

            string Problem = Console.ReadLine();

            double Solved = Logic.Operator(Problem);
            Console.Clear();
            secondInput(Solved);
        }

        public static void secondInput(double Solved)
        {
            while (true)
            {
                char targetLetter = 'c';
                Console.Clear();
                Console.WriteLine("CALCULATOR");

                Console.WriteLine("________________________\n");

                Console.Write(Solved);


                string str = Solved.ToString();
                string Update = Console.ReadLine().ToLower();

                if (Update.Contains(targetLetter))
                {
                    Input();
                }

                string Problem = str + Update;

                Solved = Logic.Operator(Problem);

                Console.Write(Solved);

            }


        }

    }
}
