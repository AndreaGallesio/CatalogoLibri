using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio01.Model
{
    class clsLibri
    {
        private int pIdLibro;
        private string pTitoloLibro;
        private string pImgLibro;
        private int pPrezzoLibro;
        private DateTime pDataLibro;
        private int pNPagineLibro;
        private string pCodRepLibro;
        private int pIdOffLibro;
        private int pIdEdiLibro;
        private char pValLibro;

        public int IdLibro { get => pIdLibro; set => pIdLibro = value; }
        public string TitoloLibro { get => pTitoloLibro; set => pTitoloLibro = value; }
        public string ImgLibro { get => pImgLibro; set => pImgLibro = value; }
        public int PrezzoLibro { get => pPrezzoLibro; set => pPrezzoLibro = value; }
        public DateTime DataLibro { get => pDataLibro; set => pDataLibro = value; }
        public int NPagineLibro { get => pNPagineLibro; set => pNPagineLibro = value; }
        public string CodRepLibro { get => pCodRepLibro; set => pCodRepLibro = value; }
        public int IdOffLibro { get => pIdOffLibro; set => pIdOffLibro = value; }
        public int IdEdiLibro { get => pIdEdiLibro; set => pIdEdiLibro = value; }
        public char ValLibro { get => pValLibro; set => pValLibro = value; }
    }
}
