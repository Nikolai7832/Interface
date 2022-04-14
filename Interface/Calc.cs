namespace Interface
{
    public class Calculator : ICalc
    {
        int a;
        int b;
        string str;
        Logger Logger { get; }
        public void Calc(Logger Logger)
        {
            Logger.Event("Введите значение");
            str = Console.ReadLine();
            try
            {
                Int32.Parse(str);
            }
            catch (Exception)
            {
                Logger.Error("Возниклала ошибка");
                Calc(Logger);
            }

            a = Int32.Parse(str);
            Logger.Event($"Первое значение:{a}");

            Logger.Event("Введите значение");
            str = Console.ReadLine();
            try
            {
                Int32.Parse(str);
            }
            catch (Exception)
            {
                Logger.Error("Возниклала ошибка");
                Calc(Logger);
            }

            b = Int32.Parse(str);
            Logger.Event($"Второе значение:{b}");
            Logger.Event($"Сумма чисел:{a + b}");
        }
    }
}
