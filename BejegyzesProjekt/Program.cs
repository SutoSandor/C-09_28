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
            int likeok;
            DateTime letrejott = DateTime.Now;
            DateTime szerkesztve = DateTime.Now;

            public Bejegyzes(string szerzo, string tartalom)
            {
                this.szerzo = szerzo;
                this.tartalom = tartalom;
                this.likeok = 0;
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
            public string Kiir()
            {
                string s = this.szerzo + " - " + this.likeok + " - " + this.letrejott;
                s += "\nSzerkesztve: " + this.szerkesztve;
                s += "\n"+this.tartalom;
                return s;
            }
        }
        static void Main(string[] args)
        {
            Bejegyzes elso = new Bejegyzes("Lakatos Rajmund", "Ej mi a kő! tyúkanyó, kend\nA szobában lakik itt bent ?\nLám, csak jó az isten, jót ád,\nHogy fölvitte a kend dolgát!");
            Console.WriteLine(elso.Kiir());
            List<Bejegyzes> lista = new List<Bejegyzes>();
            lista.Add(new Bejegyzes("Első bejegyzés","1. bejegyz"));
            lista.Add(new Bejegyzes("Második bejegyzés", "2. bejegyz"));
            foreach (var i in lista)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
