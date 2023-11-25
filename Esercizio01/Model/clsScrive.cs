using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio01.Model
{
    class clsScrive
    {
        private int pIdScrive;
        private int pIdAutoScrive;
        private int pIdLibScrive;
        private char pValScrive;

        public int IdScrive { get => pIdScrive; set => pIdScrive = value; }
        public int IdAutoScrive { get => pIdAutoScrive; set => pIdAutoScrive = value;}
        public int IdLibScrive { get => pIdLibScrive; set => pIdLibScrive = value;}
        public char ValScrive { get => pValScrive; set => pValScrive = value; }
    }
}
