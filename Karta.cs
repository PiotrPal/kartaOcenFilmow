﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kartaOcenFilmow {
    internal class Karta {

        public Karta()
        {
            oceny = new List<float>();
        }

        List<float> oceny;

        /// <summary>
        /// Dodanie nowej oceny do listy ocen
        /// </summary>
        /// <param name="ocena">Nowa ocena</param>
        public void AddOceny (float ocena) {
            oceny.Add (ocena);
        }
        /// <summary>
        /// Obliczanie sredniej z listy ocen
        /// </summary>
        /// <returns>srednia ocena</returns>
        public float ObliczSrednia() {
            //float suma=0, srednia=0;
            //foreach (float ocena in oceny) {
            //    suma+= ocena;
            //}
            //srednia = suma / oceny.Count;
            //return srednia;
            return oceny.Average();
        }
        /// <summary>
        /// Zwraca najmniejsza ocene
        /// </summary>
        /// <returns>najmniejsza ocena</returns>
        public float MinOcena() {
            float min = oceny.Min();
            return min;
        }
        /// <summary>
        /// Zwraca nawieksza ocene
        /// </summary>
        /// <returns>najwieksza ocena</returns>
        public float MaxOcena() {
            float max = oceny.Max();
            return max;
        }
    }
}