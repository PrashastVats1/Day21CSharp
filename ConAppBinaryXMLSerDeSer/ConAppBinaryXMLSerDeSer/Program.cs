using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using EmployeeLib;

namespace ConAppBinaryXMLSerDeSer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string folderPath = @"D:\Mphasis\Live Session\Day21\Assignment 24";
            string binaryFilePath = Path.Combine(folderPath, "employee.bin");
            string xmlFilePath = Path.Combine(folderPath, "employee.xml");
            Employee employee = new Employee();
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee));

            //Binary Serialization
            using(FileStream fs = new FileStream(binaryFilePath, FileMode.Create))
            {
                //Some sample employee data
                employee.Id = 4;
                employee.FirstName = "Sung";
                employee.LastName = "Jinwoo";
                employee.Salary = 80000000.75;

                binaryFormatter.Serialize(fs, employee);
                Console.WriteLine("Employee data has been serialized to Binary format");
            }
            //Binary Deserialization
            using(FileStream fs = new FileStream(binaryFilePath, FileMode.Open))
            {
                Employee deserializedEmployee = (Employee)binaryFormatter.Deserialize(fs);
                Console.WriteLine("\nDesrialized Employee Data (Binary File)");
                Console.WriteLine($"ID: \t{deserializedEmployee.Id}");
                Console.WriteLine($"First Name: \t{deserializedEmployee.FirstName}");
                Console.WriteLine($"Last Name: \t{deserializedEmployee.LastName}");
                Console.WriteLine($"Salary: \t{deserializedEmployee.Salary}");
            }

            //XML Serialization
            using(TextWriter writer = new StreamWriter(xmlFilePath))
            {
                xmlSerializer.Serialize(writer, employee);
                Console.WriteLine("\nEmployee data has been serialized to XML format");
            }
            //XML Deserialization
            using(TextReader reader = new StreamReader(xmlFilePath))
            {
                Employee deserializedEmployee = (Employee)xmlSerializer.Deserialize(reader);
                Console.WriteLine("\nDeserialized Employee Data (XML)");
                Console.WriteLine($"ID: \t{deserializedEmployee.Id}");
                Console.WriteLine($"First Name: \t{deserializedEmployee.FirstName}");
                Console.WriteLine($"Last Name: \t{deserializedEmployee.LastName}");
                Console.WriteLine($"Salary: \t{deserializedEmployee.Salary}");
            }
            Console.ReadKey();
        }
    }
}
