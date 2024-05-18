namespace HomeWork8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindExtensionAndText("D:\\C#_repos\\HomeWork8\\HomeWork8\\1\\", ".txt", "New string new Lesson");
        }

        public static void FindExtensionAndText(string path, string exten, string text)
        {
            if (!Directory.Exists(path))
            {
                Console.WriteLine("Данной директории не существует!");
                return;
            }

            DirectoryInfo di = new DirectoryInfo(path);
            string[] dirs = Directory.GetDirectories(path);

            foreach (var file in di.GetFiles())
            {
                if (file.Extension.Equals(exten))
                {
                    using (StreamReader sr = new StreamReader(path + $"\\{file.Name}"))
                    {
                        while (!sr.EndOfStream)
                        {
                            string value = sr.ReadLine();

                            if (value.Contains(text))
                            {
                                Console.WriteLine($"Файл с расширением {exten} и текстом {text}, \n находится в {path}");
                            }
                        }
                    }
                }
            }

            foreach (var dir in dirs)
            {
                FindExtensionAndText(dir, exten, text);
            }
        }
    }
}
