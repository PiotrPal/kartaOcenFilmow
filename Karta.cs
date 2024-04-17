using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kartaOcenFilmow {
    public class Karta : KartaPodstawowa{

        public Karta()
        {
            oceny = new List<float>();
        }

        protected List<float> oceny;

        

        /// <summary>
        /// Dodanie nowej oceny do listy ocen
        /// </summary>
        /// <param name="ocena">Nowa ocena</param>
        public override void AddOceny (float ocena) {
            oceny.Add (ocena);
        }
        
        /// <summary>
        /// Obliczmy statystyki dla ocen
        /// </summary>
        /// <returns>KartaStatystyki(srednia, minimalna, maksymalna ocena)</returns>
        public override KartaStatystyki ObliczStatystyki() {

            Console.WriteLine("Wchodzimy do klasy karta oblicz statystyki");


            KartaStatystyki stat = new KartaStatystyki();

            float suma = 0;

            foreach (var ocena in oceny) {
                suma += ocena;
            }

            stat.SredniaOcena = suma / oceny.Count();
            stat.MinOcena = oceny.Min();
            stat.MaxOcena = oceny.Max();

            return stat;
        }
    }
}
