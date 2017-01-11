using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbneK
{
    class NaWynos : Zamowienie
    {
        //przesłaniam metode w klasie nadrzędnej  true kiedy czasDostawy jest wiekszy od aktualnego czasu o 2 h------?!
        public override bool PoprawnyCzas()
        {
            //   if (czasDostawy > DateTime.Now)
            return true;
        }
    }
}
