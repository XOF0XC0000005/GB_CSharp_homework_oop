using System.Reflection;
using System.Text;

namespace HomeWork7
{
    public class Program
    {
        static void Main(string[] args)
        {
            TestClass testClass = new TestClass(1, "текст", 23m, "символы".ToCharArray());

            var toString = ObjectToString(testClass);

            Console.WriteLine(toString);
            Console.WriteLine();

            object toObject = StringToObject(toString, typeof(TestClass));

            TestClass parsedFromStringClass = toObject as TestClass;

            Console.WriteLine("I: " + parsedFromStringClass.I);
            Console.WriteLine("S: " + parsedFromStringClass.S);
            Console.WriteLine("D: " + parsedFromStringClass.D);
            Console.WriteLine("C: " + string.Join("", parsedFromStringClass.C));
        }

        public static object? StringToObject(string str, Type type)
        {
            string[] splittedText = str.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            var newObj = Activator.CreateInstance(type) as TestClass;
            object parsedValue;

            foreach (var line in splittedText)
            {
                string[] keyValue = line.Split(':');

                string propName = keyValue[0].Trim();
                string propValue = keyValue[1].Trim();

                foreach (var propInfo in type.GetProperties())
                {
                    CustomNameAttribute attr = propInfo.GetCustomAttribute<CustomNameAttribute>();

                    if (attr?.Name == propName)
                    {
                        Type propType = propInfo.PropertyType;

                        if (propType == typeof(char[]))
                        {
                            parsedValue = Convert.ChangeType(propValue.ToCharArray(), propType);
                        }
                        else
                        {
                            parsedValue = Convert.ChangeType(propValue, propType);
                        }

                        propInfo.SetValue(newObj, parsedValue);
                        break;
                    }
                }
            }

            return newObj;
        }

        public static string ObjectToString(object o)
        {
            StringBuilder sb = new StringBuilder();
            Type type = o.GetType();

            foreach (PropertyInfo propertyInfo in type.GetProperties())
            {
                CustomNameAttribute attr = propertyInfo.GetCustomAttribute<CustomNameAttribute>();

                if (attr != null)
                {
                    string propertyName = attr.Name;
                    object propertyValue = propertyInfo.GetValue(o);

                    sb.Append($"{propertyName}:{propertyValue}");
                    sb.AppendLine();
                }
            }

            return sb.ToString();
        }
    }
}
