using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kartaOcenFilmow {
    internal class Zwierze {
        private string _nazwa;
        private string _nazwa2;
        private readonly string _readonly;

        public Zwierze(string nazwa, string nazwa2, string pole) {
            _nazwa = nazwa;
            _nazwa2 = nazwa2;
            _readonly = pole;
        }

        public string Nazwa {
            get { return _nazwa; }
            set {
                if (!String.IsNullOrWhiteSpace(value)) {
                    _nazwa = value;
                }
            }
        }
        public string Nazwa2 {
            set {
                if (!string.IsNullOrWhiteSpace(value)) {
                    _nazwa2 = value;
                }
            }
        }
        public string Readonly { get { return _readonly; } }

        public int MyProperty { get; set; }
    }
}
