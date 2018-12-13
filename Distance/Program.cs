using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                    Console.WriteLine("Eingabe a: ");
                    string entry1 = Console.ReadLine();
                    Console.WriteLine("Eingabe b: ");
                    string entry2 = Console.ReadLine();
                    int a = Convert.ToInt32(entry1);
                    int b = Convert.ToInt32(entry2);
                    Console.WriteLine(Distance.distance(a, b));
                    Console.ReadLine(); 
            }
            catch(Exception)
            {
                Console.WriteLine("Fehlerhafte Eingabe.");
            }
            Console.ReadLine();
        }
    }
}
