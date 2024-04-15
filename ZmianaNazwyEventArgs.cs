using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kartaOcenFilmow {
    public class ZmianaNazwyEventArgs : EventArgs {
        public string IstniejacaNazwa { get; set; }
        public string NowaNazwa { get; set; }
    }
}
