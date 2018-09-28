using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejegyzesProjekt
{
    class Program
    {
        class Bejegyzes
        {
            string szerzo;
            string tartalom;
            int likeok = 0;
            DateTime letrejott = DateTime.Now;
            DateTime szerkesztve = DateTime.Now;

            public Bejegyzes(string szerzo, string tartalom, int likeok, DateTime letrejott, DateTime szerkesztve)
            {
                this.szerzo = szerzo;
                this.tartalom = tartalom;
                this.likeok = likeok;
                this.letrejott = DateTime.Now;
                this.szerkesztve = DateTime.Now;
            }
            public string Szerzo
            {
                get
                {
                    return szerzo;
                }
            }
            public string Tartalom
            {
                get
                {
                    return tartalom;
                }
                set
                {
                    this.tartalom = value;
                    this.szerkesztve = DateTime.Now;
                }
            }
            public int Likeok
            {
                get
                {
                    return likeok;
                }
            }
            public DateTime Letrejott
            {
                get
                {
                    return letrejott;
                }
            }
            public DateTime Szerkesztve
            {
                get
                {
                    return szerkesztve;
                }
            }
            public int Like(int likeok)
            {
                return likeok++;
            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}
