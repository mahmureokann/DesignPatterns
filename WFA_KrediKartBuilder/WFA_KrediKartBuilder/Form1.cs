using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_KrediKartBuilder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbBanka_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        string[] bankaListesi = { "Türkiye İş Bankası","Garanti Bankası","Ziraat Bankası"};
        string[] kartTip = { "Master kart","Visa kart","American Express"};
        public void Form1_Load(object sender, EventArgs e)
        {
            cmbBanka.DataSource=bankaListesi;
            

           cmbKartTip.DataSource=kartTip;
        }

        KrediKartiBuilder builder;

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            switch (cmbKartTip.Text)
            {
                case "Master kart":
                    builder = new MasterKartConcrete();
                    break;
                case "Visa kart":
                    builder = new VisaKartConcrete();
                    break;
            }

            KartKullan kullan = new KartKullan();

            bool taksit = rbEvet.Checked ? true : false; //Taksitler için evet seçili ise true değilse false gönder demek istiyoruz.

            kullan.KrediKartiKullan(builder,cmbBanka.Text,nudKartLimit.Value,cmbKartTip.Text, taksit);

            ListView(); //Metot çağır.
        }

        public void ListView()
        {
            ListViewItem lvi = new ListViewItem();

            lvi.Text = builder.Kart.BankaAdi;
            lvi.SubItems.Add(builder.Kart.KartLimit.ToString());
            //lvi.SubItems.Add(builder.Kart.Taksit.ToString());
            if (builder.Kart.Taksit == true)
            {
                lvi.SubItems.Add(builder.Kart.Taksit.ToString());
            }
            else
            {
                 lvi.SubItems.Add(builder.Kart.Taksit.ToString());
            }

            lvi.SubItems.Add(builder.Kart.KartTip.ToString());

            listView1.Items.Add(lvi);
        }
    }
}
