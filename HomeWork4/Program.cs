namespace HomeWork4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 2, 3, 10, 15, 13, 1, 4 };
            int target = 22;

            for (int i = 0; i < ints.Length; i++)
            {
                for (int j = i + 1; j < ints.Length; j++)
                {
                    for (int k = j + 1; k < ints.Length; k++)
                    {
                        if (ints[i] + ints[j] + ints[k] == target)
                        {
                            Console.WriteLine($"{target} = {ints[i]} + {ints[k]} + {ints[j]}");
                            return;
                        }
                    }
                }
            }
        }
    }
}
