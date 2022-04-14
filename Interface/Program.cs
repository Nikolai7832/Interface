namespace Interface
{
    public class Programm
    {
        static Logger Logger { get; set; }
        static void Main()
        {
            Logger = new Logger();
            Calculator calculator = new Calculator();
            calculator.Calc(Logger);

        }
    }
    public interface ILogger
    {
        static public void Error(string message)
        { }
        static public void Event(string message)
        { }
    }
    public class Logger : ILogger
    {
        static public void Error(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }

        static public void Event(string message)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
        }
    }
    public interface ICalc
    {
        public void Calc(Logger Logger);
    }

}
