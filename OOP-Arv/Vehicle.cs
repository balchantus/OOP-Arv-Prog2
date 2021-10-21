using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Arv
{
    public class Vehicle
    {
        //Fält
        private string märke;   //Märke
        private string model;   //Model
        private int year;       //Årsmodell
        private bool forSale;   //Är fordonet till salu?

        //Konstruktor med 5 inmatade värden
        public Vehicle(string märke, string model, int year, bool forSale)
        {
            this.Märke = märke;
            this.Model = model;
            this.Year = year;
            this.ForSale = forSale;
        }

        //Properties
        public string Märke
        {
            get { return märke; }
            set { märke = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        //Årtalet kan inte vara tidigare än år 1900
        public int Year
        {
            get { return year; }
            set
            {
                if (value < 1900)
                {
                    year = -1;
                }
                else
                {
                    year = value;
                }
            }
        }

        public bool ForSale
        {
            get { return forSale; }
            set { forSale = value; }
        }

        //Metod som converterar year till en string
        //Retunerar den konverterade stringen
        //Felaktigt årtal om årtalet var före år 1900
        public string YearToString()
        {
            if (this.year == -1)
            {
                return "felaktigt årtal!";
            }
            else
            {
                //Coverterar int till string och retunerar det
                return Convert.ToString(year);
            }
        }

        //Metod som skriver ut om bilen är till salu eller inte
        //Retunerar svaret
        public string ForSaleToString()
        {
            if (this.ForSale)
            {
                return "Bilen är till salu";
            }
            else
            {
                return "Bilen är inte till salu";
            }
        }

        public string ToInfo()
        {
            return string.Format("\nFordonsinformation\nReg: {0}, {1}, {2}, {3}",
                this.Märke, this.Model, this.YearToString(), this.ForSaleToString());
        }
    }
}
