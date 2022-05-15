using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_KrediKartBuilder
{
    public abstract class KrediKartiBuilder
    {

        //Property
        protected KrediKarti kart; //Erişim belirteci, miras verilen tarafta gelmesini sağlar. İçeri ile iletişimde olan
        public KrediKarti Kart //Dışarıyla iletişimde olan (Kapsülleme) Büyük harf k yaptığımız çağırmak için.
        {
            get { return kart; }

        }
        //Eylemler

        public abstract void BankaAdi(string bankaAdi);
        public abstract void KartTip(string kartTip);
        public abstract void KartLimit(decimal kartLimit);
        public abstract void Taksit(bool taksit);
        
    }
}
