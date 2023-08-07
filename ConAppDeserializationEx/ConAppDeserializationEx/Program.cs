using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonLib;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Diagnostics;
using static System.Collections.Specialized.BitVector32;

namespace ConAppDeserializationEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person obj = new Person() { Name = "Sam", Contact = "9876543210", Age = 25 };
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("D://Mphasis//Live Session//File Handling Stuff//person.bin", FileMode.Create))
            {
                formatter.Serialize(fs, obj);
            }
            Console.WriteLine("File created object is serialized");
            Console.ReadKey();
        }
    }
}
