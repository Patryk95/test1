using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbneK
{

    //Tworze klasę Skladnik
    class Skladnik : IComparable<Skladnik>
    {
        //Dodaje prywatne pola
        private string nazwaSkladnika;
        private string ilosc;
        private double cenaSkladnika;

        //Dodaje konstruktor parametryczny
        public Skladnik(string NazwaSkladnika, string Ilosc, double CenaSkladnika)
        {
            this.nazwaSkladnika = NazwaSkladnika;
            this.ilosc = Ilosc;
            this.cenaSkladnika = CenaSkladnika;
        }

        //Przesłaniam metodę ToString()
        public override string ToString()
        {
            return "Nazwa: " + nazwaSkladnika + ", ilość: " + ilosc + ", cena: " + cenaSkladnika + "\n";
        }

        //Metoda zwracajaca cenę składnika
        public double cenaSkladnikaWyswietl(double CenaSkladnika)
        {
            return CenaSkladnika;
        }

        //Implementuje metodę IComparable
        public int CompareTo(Skladnik other)
        {
            if (this.nazwaSkladnika == other.nazwaSkladnika)
            {
                return other.nazwaSkladnika.CompareTo(this.nazwaSkladnika);
            }
            return this.nazwaSkladnika.CompareTo(other.nazwaSkladnika);
        }
    }
}
