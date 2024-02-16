namespace Advanced_Calculator
{
    class Program
    {

        public static void Main(string[] args)
        {
            Counter counter = new Counter();

            ICalculator Calculator = new Calculator();

            Calculator.Menu();


        }
    }
}