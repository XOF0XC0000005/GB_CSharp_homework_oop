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
            bool flag = false;

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
                                flag = true;
                                Console.WriteLine($"Файл с расширением {exten} и текстом {text}, \n находится в {path}");
                            }
                        }
                    }
                }

                if (flag) break;
            }

            foreach (var dir in dirs)
            {
                if (flag) break;

                FindExtensionAndText(dir, exten, text);
            }
        }
    }
}
