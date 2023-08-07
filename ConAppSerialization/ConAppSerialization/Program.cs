using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConAppSerialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                ID = 12,
                Name = "Sam",
                Designation = "Manager"
            };
            //Binary, XML,JSON
            //Binary
            //Writing to the stream
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"D:\Mphasis\Live Session\File Handling Stuff\OurExampleOne.txt", FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, employee);
            stream.Close();

            //Reading from the stream
            stream = new FileStream(@"D:\Mphasis\Live Session\File Handling Stuff\OurExampleOne.txt", FileMode.Open, FileAccess.Read);
            Employee objNew = (Employee)formatter.Deserialize(stream);
            Console.WriteLine(objNew.ID);
            Console.WriteLine(objNew.Name);
            Console.WriteLine(objNew.Designation);
            Console.ReadKey();
        }
    }
}
