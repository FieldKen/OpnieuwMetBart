using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpnieuwMetBart
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal1 = 5;
            int getal2 = 3;
            int getal3 = 8;

                //FALSE
                  //TRUE
                  //TRUE              //FALSE
            if (!(getal1 >= getal2 || getal3 < getal1))
            {
                Console.WriteLine("Wordt uitgevoerd");
            }
            else
            {
                Console.WriteLine("Wordt niet uitgevoerd");
            }

            Console.ReadLine();
        }
    }
}
