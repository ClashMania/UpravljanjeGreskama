using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpravljanjeGreskama1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int godRod;
            bool kontrola=false;



          

            do
            {  
                Console.WriteLine("Upišite svoju godinu rođenja: ");
                try
                {
                    godRod = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Rođen si " + godRod + ". godine =D");
                }

                catch (Exception greska)
                {
                    Console.WriteLine(greska.Message);
                }

            }
            while (kontrola == false);
           






            Console.ReadKey();


        }
    }
}
