namespace Advanced_Calculator
{
    class Program
    {

        public static async Task Main()
        {
            Counter counter = new Counter();
            Task inputTask = Counter.Interaction();

            ICalculator Calculator = new Calculator();

            Calculator.Face();

            await inputTask;
        }
    }
}