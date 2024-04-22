namespace HomeWorkOOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] labirint = new int[,]
            {
                {1, 1, 1, 2, 1, 1, 1},
                {1, 0, 0, 0, 0, 0, 1},
                {1, 0, 1, 1, 1, 0, 1},
                {2, 0, 0, 0, 1, 0, 2},
                {1, 1, 0, 0, 1, 1, 1},
                {1, 1, 1, 0, 1, 1, 1},
                {1, 1, 1, 2, 1, 1, 1}
            };

            Console.WriteLine($"Количество выходов из заданной позиции: {HasExit(3, 3, labirint)}");
            Console.ReadLine();
        }

        public static int HasExit(int startI, int startJ, int[,] labirint)
        {
            int counter = 0;

            if (labirint[startI, startJ] == 1) return counter;
            if (labirint[startI, startJ] == 2) counter++;

            var stack = new Stack<Tuple<int, int>>();

            stack.Push(new(startI, startJ));

            while (stack.Count > 0)
            {
                var temp = stack.Pop();

                if (labirint[temp.Item1, temp.Item2] == 2) counter++;

                labirint[temp.Item1, temp.Item2] = 1;

                if (temp.Item2 >= 0 && temp.Item2 - 1 >= 0 && labirint[temp.Item1, temp.Item2 - 1] != 1)
                    stack.Push(new(temp.Item1, temp.Item2 - 1));
                if (temp.Item2 + 1 < labirint.GetLength(1) && labirint[temp.Item1, temp.Item2 + 1] != 1)
                    stack.Push(new(temp.Item1, temp.Item2 + 1));
                if (temp.Item1 >= 0 && temp.Item1 - 1 >= 0 && labirint[temp.Item1 - 1, temp.Item2] != 1)
                    stack.Push(new(temp.Item1 - 1, temp.Item2));
                if (temp.Item1 + 1 < labirint.GetLength(0) && labirint[temp.Item1 + 1, temp.Item2] != 1)
                    stack.Push(new(temp.Item1 + 1, temp.Item2));
            }
            return counter;
        }
    }
}
