using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ResearchUnicode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("eureka.txt", "Eureka!");
            byte[] eurekaBytes = File.ReadAllBytes("eureka.txt");
            foreach (byte b in eurekaBytes)
                Console.Write("{0}", b);
            Console.WriteLine(Encoding.UTF8.GetString(eurekaBytes));
            char key = Console.ReadKey().KeyChar;
        }
    }
}
