using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_KrediKartBuilder
{
    public class KrediKarti
    {
        public string BankaAdi { get; set; }
        public decimal KartLimit { get; set; }
        public bool Taksit { get; set; }
        public string KartTip { get; set; }

        public override string ToString()
        {
            return "Banka Adı: "+BankaAdi+" Kart Tipi: "+KartTip+" Kart Limiti: "+KartLimit+" Taksit: "+Taksit; 
        }


    }
}
