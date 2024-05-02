using HomeWork5;

namespace HoweWork5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            calc.MyEventHandler += Calc_MyEventHandler;
            calc.Start();
        }

        private static void Calc_MyEventHandler(object? sender, EventArgs e)
        {
            if (sender is Calculator)
                Console.WriteLine($"Текущий результат: {((Calculator)sender).Result}");
        }
    }
}
