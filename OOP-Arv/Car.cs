using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Arv
{
    public class Car : Vehicle
    {
        //Fält
        private string regNr;    //Registreringsnummer

        //Konstruktor med 5 inmatade värden och skickar dessa till basklassen för bearbetning
        public Car(string regNr, string märke, string model, int year, bool forSale) : base(märke, model, year, forSale)
        {
            this.RegNr = regNr;
        }

        //Properties
        public string RegNr
        {
            get { return regNr; }
            set { regNr = value; }
        }



        //Metod som förbereder utskrivning av information om bilen
        //Retunerar sedan informationen och skriver ut den
        public string Info()
        {
            string carInfo = string.Format("Bilinformation: \n\nRegistreringsnummer  : {0}, \nMärke                : {1}, \nModel                : {2}, \nÅr                   : {3}, \nTill Salu            : {4}",
                this.RegNr, this.Märke, this.Model, this.YearToString(), this.ForSaleToString());

            return carInfo;
        }
    }
}
