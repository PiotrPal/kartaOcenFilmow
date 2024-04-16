using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kartaOcenFilmow {
    public abstract class KartaPodstawowa : object, IKartaPodstawowa{
        public abstract void AddOceny(float ocena);
        public abstract KartaStatystyki ObliczStatystyki();
        protected string _nazwa;

        //wlasciwosc
        public string Nazwa {
            get {
                return _nazwa.ToUpper();
            }
            set {
                if (!string.IsNullOrWhiteSpace(value)) {
                    if (_nazwa != value) {
                        ZmianaNazwyEventArgs args = new ZmianaNazwyEventArgs();
                        args.IstniejacaNazwa = _nazwa;
                        args.NowaNazwa = value;

                        ZmianaNazwy(this, args);
                    }
                    _nazwa = value;
                }
            }
        }

        //Event(zdarzeznie)
        public event ZmianaNazwyDelegatDelegate ZmianaNazwy;

      

    }
}
