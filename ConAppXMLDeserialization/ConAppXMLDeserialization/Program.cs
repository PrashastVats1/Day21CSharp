using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using SimpleLib;

namespace ConAppXMLDeserialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Player));
            using(TextReader reader = new StreamReader("D:\\Mphasis\\Live Session\\Day21\\Player.xml"))
            {
                Player deserializedPerson = (Player)serializer.Deserialize(reader);
                Console.WriteLine($"ID: {deserializedPerson.Id}\nName: {deserializedPerson.Name}");
                Console.WriteLine($"Type of Player: {deserializedPerson.playerType}\nPlayer Team: {deserializedPerson.Team}");
            }
            Console.ReadKey();
        }
    }
}
