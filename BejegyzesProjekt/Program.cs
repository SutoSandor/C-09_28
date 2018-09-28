using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejegyzesProjekt
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
            this.szerkesztve = this.letrejott;
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
        public void Like()
        {
            likeok++;
        }
        public string Kiir()
        {
            string s = this.szerzo + " - " + this.likeok + " - " + this.letrejott;
            s += "\n" + this.tartalom;
            if (this.szerkesztve != this.letrejott)
            {
                s += "\nSzerkesztve: " + this.szerkesztve;
            }
            return s;
        }
    }
    class Program
    {
        public static Random rnd = new Random();
        public static List<Bejegyzes> valami = new List<Bejegyzes>();
        public static void ujbejegyzes()
        {
            Console.WriteLine("Szerző: ");
            string szerzo = Console.ReadLine();
            Console.WriteLine("Tartalom: ");
            string tartalom = Console.ReadLine();
            valami.Add(new Bejegyzes(szerzo, tartalom));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hány bejegyzést szeretne írni?");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                ujbejegyzes();
            }
            for (int i = 0; i < valami.Count * 20; i++)
            {
                valami[rnd.Next(0, valami.Count)].Like();

            }
            foreach (var i in valami)
            {
                Console.WriteLine(i.Kiir());
            }
            Console.WriteLine("A 2. bejegyzés módosítása: ");
            valami[1].Tartalom = Console.ReadLine();
            Console.WriteLine("A módosított tartalom: \t" +valami[1].Kiir());
            Console.ReadKey();
        }
    }
}
