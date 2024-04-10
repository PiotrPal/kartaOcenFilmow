using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kartaOcenFilmow { 
    internal class Program { 
        static void Main(string[] args) {

            Karta karta1 = new Karta();
            Karta karta2 = new Karta();

            karta1.AddOceny(5);
            karta1.AddOceny(6);
            karta1.AddOceny(2);
            karta1.AddOceny(3.5f);
            karta1.AddOceny(5);

            float srednia = karta1.ObliczSrednia();
            float min = karta1.MinOcena();
            float max = karta1.MaxOcena();

            while (true) {
                Console.Write("Podaj ocene filmu z zakresu od 1 do 10: \n");

                float ocena;
                bool input = float.TryParse(Console.ReadLine(),out ocena);
                if (ocena == 11) break;

                if (!input) Console.WriteLine("Wprowadzona wartosc to nie liczba! Podaj poprawną!");

                else if (ocena > 0 && ocena <= 10) karta2.AddOceny(ocena);
                else Console.WriteLine("Liczba z poza zakresu (1-10)! Podaj poprawną!");
            }

            Console.WriteLine("Srednia ocena to: " + karta2.ObliczSrednia());
            Console.WriteLine("Najwyzsza ocena to: " + karta2.MaxOcena());
            Console.WriteLine("Najmniejsza ocena to: " + karta2.MinOcena());
            Console.ReadKey();
        }
    }
}
