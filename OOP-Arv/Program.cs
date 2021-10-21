using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Arv
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Skapa ny bil med inmatade värden
            Car bil = new Car("AXG 375", "Koenigsegg", "Regera R", 2015, false);
            //Skriv ut info om bilen
            Console.WriteLine(bil.Info());
            
            //Skapa en till bil med inmatade värden
            Car bil2 = new Car("BXW 78T", "Volvo", "XC90", 2021, true);
            //Skriv ut info om bilen
            Console.WriteLine(" ");
            Console.WriteLine(bil2.Info());

            //Väntar på att en tangent trycks ned
            Console.ReadKey();
        }
    }
}
