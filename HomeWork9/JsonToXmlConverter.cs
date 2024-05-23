using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HomeWork9
{
    internal class JsonToXmlConverter
    {
        public static void Start(string jsonFile)
        {
            var j = JsonSerializer.Deserialize<Person>(jsonFile);

            var xmlFile = new XmlSerializer(typeof(Person));

            xmlFile.Serialize(Console.Out, j);
        }
    }
}
