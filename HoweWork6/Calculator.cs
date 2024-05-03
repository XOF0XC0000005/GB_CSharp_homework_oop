using HoweWork5;

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
                Console.WriteLine($"{CancelResultCommand}.Отменить действие.");
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
            Console.Write($"{Result} + ");

            if (MyDoubleTryParse(Console.ReadLine(), out double result))
            {
                try
                {
                    if (!IsNegativeNumber(result))
                    {
                        PreviousResult.Push(Result);
                        Result += result;
                    }
                }
                catch (CalculatorNegativeNumberException e)
                {
                    Console.WriteLine(e.ToString());
                    Console.ReadLine();
                }
                catch (CalculatorException e)
                {
                    Console.WriteLine(e.ToString());
                    Console.ReadLine();
                }
                catch { }
            }
        }

        public void Div()
        {
            Console.Clear();
            Console.Write($"{Result} / ");

            if (MyDoubleTryParse(Console.ReadLine(), out double result))
            {
                try
                {
                    if (DivedByZero(result) && !IsNegativeNumber(result))
                    {
                        PreviousResult.Push(Result);
                        Result /= result;
                    }
                }
                catch (CalculatorDividedByZeroException e)
                {
                    Console.WriteLine(e.ToString());
                    Console.ReadLine();
                }
                catch (CalculatorNegativeNumberException e)
                {
                    Console.WriteLine(e.ToString());
                    Console.ReadLine();
                }
                catch (CalculatorException e)
                {
                    Console.WriteLine(e.ToString());
                    Console.ReadLine();
                }
                catch { }
            }
        }

        public void Sub()
        {
            Console.Clear();
            Console.Write($"{Result} - ");

            if (MyDoubleTryParse(Console.ReadLine(), out double result))
            {
                try
                {
                    if (!IsNegativeNumber(result))
                    {
                        PreviousResult.Push(Result);
                        Result -= result;
                    }
                }
                catch (CalculatorNegativeNumberException e)
                {
                    Console.WriteLine(e.ToString());
                    Console.ReadLine();
                }
                catch (CalculatorException e)
                {
                    Console.WriteLine(e.ToString());
                    Console.ReadLine();
                }
                catch { }
            }
        }

        public void Multy()
        {
            Console.Clear();
            Console.Write($"{Result} * ");

            if (MyDoubleTryParse(Console.ReadLine(), out double result))
            {
                try
                {
                    if (!IsNegativeNumber(result))
                    {
                        PreviousResult.Push(Result);
                        Result *= result;
                    }

                }
                catch (CalculatorNegativeNumberException e)
                {
                    Console.WriteLine(e.ToString());
                    Console.ReadLine();
                }
                catch (CalculatorException e)
                {
                    Console.WriteLine(e.ToString());
                    Console.ReadLine();
                }
                catch { }

            }
        }

        public void CancelLast()
        {
            if (PreviousResult.TryPop(out double res))
            {
                Result = res;
            }
        }

        private bool DivedByZero(double num)
        {
            if (num == 0)
                throw new CalculatorDividedByZeroException("Деление на 0 запрещено!");

            return true;
        }

        private bool MyDoubleTryParse(string str, out double num)
        {
            num = 0;

            try
            {
                num = double.Parse(str);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            return true;
        }

        private bool IsNegativeNumber(double num)
        {
            if (num < 0)
                throw new CalculatorNegativeNumberException("Программа не работает с отрицательными числами");

            return false;
        }
    }
}