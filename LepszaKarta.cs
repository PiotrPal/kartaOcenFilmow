using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kartaOcenFilmow {
    public class LepszaKarta :Karta{
        
        public override KartaStatystyki ObliczStatystyki() {

            Console.WriteLine("Wchodzimy do klasy lepszakarta oblicz statystyki");

            float najnizsza = float.MaxValue;
            foreach(var ocena in oceny) {
                najnizsza = Math.Min(ocena, najnizsza);
            }
            oceny.Remove(najnizsza);

            return base.ObliczStatystyki();
        }
    }
}
