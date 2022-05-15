using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_KrediKartBuilder
{
    public class VisaKartConcrete : KrediKartiBuilder
    {
        public VisaKartConcrete()
        {
            kart=new KrediKarti();
        }
        public override void BankaAdi(string bankaAdi)
        {
            kart.BankaAdi = bankaAdi;
        }

        public override void KartLimit(decimal kartLimit)
        {
            kart.KartLimit = kartLimit;
        }

        public override void KartTip(string kartTip)
        {
            kart.KartTip = kartTip;
        }

        public override void Taksit(bool taksit)
        {
            kart.Taksit = taksit;
        }
    }
}
