using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using SimpleLib;

namespace ConAppBSerialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Console.WriteLine("Enter Player ID");
            player.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Player Name");
            player.Name = Console.ReadLine();
            Console.WriteLine("Enter Player Type");
            player.playerType = Console.ReadLine();
            Console.WriteLine("Enter Player Team");
            player.Team = Console.ReadLine();
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("D:\\Mphasis\\Live Session\\Day21\\Players.bin", FileMode.Create))
            {
                formatter.Serialize(fs, player);
            }
            Console.WriteLine("Created and Serialized");
            Console.ReadKey();
        }
    }
}
