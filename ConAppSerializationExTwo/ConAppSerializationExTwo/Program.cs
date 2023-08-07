using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using PersonLib;

namespace ConAppSerializationExTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person obj = new Person() { Name = "Sam", Contact = "8976543210", Age = 25 };
            //BinaryFormatter formatter = new BinaryFormatter();
            //using (FileStream fs = new FileStream("D://Mperson.bin", FileMode.Create))
            //{
            //    formatter.Serialize(fs, obj);
            //}
            //Console.WriteLine("File Created, object is serialized");
            //Console.ReadKey();
            Person obj = new Person() { Name = "Sam", Contact = "8976543210", Age = 25 };
            BinaryFormatter formatter = new BinaryFormatter();

            string directoryPath = "D://Mphasis//Live Session//File Handling Stuff//";
            string filePath = Path.Combine(directoryPath, "person.bin");

            // Create the directory if it doesn't exist
            Directory.CreateDirectory(directoryPath);

            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                formatter.Serialize(fs, obj);
            }
            Console.WriteLine("File Created, object is serialized");
            Console.ReadKey();
        }
    }
}
