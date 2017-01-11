using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbneK
{

    //Dodaje klasę Abstrakcyjną
    abstract class Zamowienie
    {
        protected DateTime czasDostawy;

        //dodaje virtualna metode
        public virtual bool PoprawnyCzas()
        {
            if (czasDostawy > DateTime.Now)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //ktora ustawia parametr jako pole czasDostawy?!?!----------------------
        public void UstawCzasDostawy(DateTime CzasDostawy)
        {
            this.czasDostawy = CzasDostawy;
        }
    }
}
