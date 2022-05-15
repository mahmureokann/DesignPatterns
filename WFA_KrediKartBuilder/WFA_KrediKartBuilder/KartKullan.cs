using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_KrediKartBuilder
{
    public class KartKullan
    {
        public void KrediKartiKullan(KrediKartiBuilder kart,string bankaAdi,decimal kartLimit,string kartTip, bool taksit)
        {
            kart.BankaAdi(bankaAdi);
            kart.KartLimit(kartLimit);
            
            kart.KartTip(kartTip);
            kart.Taksit(taksit);
        }
    }
}
