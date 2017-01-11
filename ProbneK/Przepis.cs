using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbneK
{
    //Tworze klasę Przepis
    class Przepis
    {
        //Dodaje pola prywatne
        private string nazwa;
        private double suma = 0;
        private List<Skladnik> listaSkladnikow = new List<Skladnik>();
        private int czasPrzygotowania;

        //Dodaje metodę
        public void DodajSkladnik(string NazwaSkladnikaa, string Iloscc, double CenaSkladnikaa)
        {
            listaSkladnikow.Add(new Skladnik(NazwaSkladnikaa, Iloscc, CenaSkladnikaa));
            suma += CenaSkladnikaa;
        }

        public void UstawNazweICzas(string Nazwa, int CzasPrzygotowania)
        {
            this.nazwa = Nazwa;
            this.czasPrzygotowania = CzasPrzygotowania;
        }

        //Przesłaniam metode ToString() ----------------------------------------------------
        public override string ToString()
        {
            string text = "";
            if (listaSkladnikow.Any())
            {
                foreach (var e in listaSkladnikow)
                {
                    text += e;
                }
                return text + "\nSuma: " + suma;
            }
            else
            {
                return " ";
            }
        }

        public bool CzyCzas()
        {
            if (czasPrzygotowania >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //zwraca ile skladnikow dodano;
        public int IleSkladnikow()
        {
            int ilosc = 0;
            foreach (var e in listaSkladnikow)
            {
                ilosc++;
            }
            return ilosc;
        }

    }
}
