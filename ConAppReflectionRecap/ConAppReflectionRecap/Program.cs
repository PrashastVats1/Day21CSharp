using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ConAppReflectionRecap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string assemblyPath = "D:\\Mphasis\\Live Session\\Day21\\SimpleLib\\SimpleLib\\bin\\Debug\\SimpleLib.dll";
            Assembly assembly = Assembly.LoadFrom(assemblyPath);
            Type type = assembly.GetType("SimpleLib.Player");
            object player = Activator.CreateInstance(type);
            PropertyInfo[] properties = type.GetProperties();
            foreach(PropertyInfo property in properties)
            {
                Console.WriteLine(property.Name);
            }
            Console.ReadKey();
        }
    }
}
