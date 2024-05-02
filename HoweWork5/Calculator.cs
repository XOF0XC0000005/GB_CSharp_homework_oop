namespace HomeWork5
{
    internal class Calculator : ICalculator
    {
        public double Result { get; set; } = 0;
        public Stack<double> PreviousResult { get; set; } = new Stack<double>();


        public event EventHandler<EventArgs> MyEventHandler;

        public void Start()
        {
            const string SumCommand = "1";
            const string SubCommand = "2";
            const string DivCommand = "3";
            const string MultyCommand = "4";
            const string CancelResultCommand = "5";
            const string ExitCommand = "6";

            bool isStarting = true;
            string? userInput;

            while (isStarting)
            {
                Console.Clear();
                Console.WriteLine("Добро пожаловать в калькулятор!\n");
                PrintResult();
                Console.WriteLine("Выберите пункт меню: ");
                Console.WriteLine($"{SumCommand}.Добавить число.");
                Console.WriteLine($"{SubCommand}.Отнять число.");
                Console.WriteLine($"{DivCommand}.Разделить на число.");
                Console.WriteLine($"{MultyCommand}.Умножить на число.");
                Console.WriteLine($"{CancelResultCommand}.Отменить последнее действие.");
                Console.WriteLine($"{ExitCommand}.Выйти из программы.\n");
                Console.Write("Ввод: ");

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case SumCommand:
                        Sum();
                        break;
                    case SubCommand:
                        Sub();
                        break;
                    case DivCommand:
                        Div();
                        break;
                    case MultyCommand:
                        Multy();
                        break;
                    case CancelResultCommand:
                        CancelLast();
                        break;
                    case ExitCommand:
                        isStarting = false;
                        break;
                }
            }
        }
        private void PrintResult()
        {
            MyEventHandler?.Invoke(this, new EventArgs());
        }

        public void Sum()
        {
            Console.Clear();
            Console.WriteLine("Сколько добавить?");
            Console.Write("Ввод: ");

            if (int.TryParse(Console.ReadLine(), out int result))
            {
                PreviousResult.Push(Result);
                Result += result;
            }
        }

        public void Div()
        {
            Console.Clear();
            Console.WriteLine("На сколько разделить?");
            Console.Write("Ввод: ");

            if (int.TryParse(Console.ReadLine(), out int result))
            {
                if (result != 0)
                {
                    PreviousResult.Push(Result);
                    Result /= result;
                }
            }
        }

        public void Sub()
        {
            Console.Clear();
            Console.WriteLine("Сколько вычесть?");
            Console.Write("Ввод: ");

            if (int.TryParse(Console.ReadLine(), out int result))
            {
                PreviousResult.Push(Result);
                Result -= result;
            }
        }

        public void Multy()
        {
            Console.Clear();
            Console.WriteLine("На сколько умножить?");
            Console.Write("Ввод: ");

            if (int.TryParse(Console.ReadLine(), out int result))
            {
                PreviousResult.Push(Result);
                Result *= result;
            }
        }

        public void CancelLast()
        {
            if (PreviousResult.TryPop(out double res))
            {
                Result = res;
            }
        }
    }
}
