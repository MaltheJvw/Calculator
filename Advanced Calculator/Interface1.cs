using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Calculator
{
    public interface ICalculator
    {
        void Face();
        void Face2(double Solved);

        void Face3();
    }

    public class Calculator : ICalculator
    {
        public void Face()
        {

            if(Counter.GetCount() == 0)
            {
                Console.Clear();
                Console.WriteLine("CALCULATOR");
                Console.WriteLine("Turns: " + Counter.GetCount());
                Console.Write(": ");

                string Problem = Console.ReadLine();
                double Solved = Logic.Operator(Problem);

                Face2(Solved);
            }
            else
            {
                Face3();
            }

            

            
            
            
        }

        public void Face2(double Solved)
        {
            Console.Clear();
            Counter.Increment();
            
            Console.WriteLine("CALCULATOR");
            Console.WriteLine("Turns: " + Counter.GetCount());
            Console.WriteLine(": " + Solved);

            Face();
            
        }

        public void Face3()
        {
            
        }
    }
}
