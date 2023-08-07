using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using SimpleLib;

namespace ConAppXMLSerialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player() { Id = 1, Name = "Raj", playerType = "Bowler", Team = "LLCOne" };
            //Serliaze object to XML
            XmlSerializer serializer = new XmlSerializer(typeof(Player));
            using (TextWriter writer = new StreamWriter("D:\\Mphasis\\Live Session\\Day21\\Player.xml"))
            {
                serializer.Serialize(writer, player);
            }
            Console.WriteLine("*** Done ***");
            Console.ReadKey();
        }
    }
}
