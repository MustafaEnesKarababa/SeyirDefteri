using SeyirDefteri.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeyirDefteri.UI
{
    public partial class Form3 : Form
    {
        private List<Gonderim> gonderims;

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(List<Gonderim> gonderims) : this()
        {
            this.gonderims = gonderims;
            ListViewListele();
        }
        decimal kalanTonaj;
        private void ListViewListele()
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.Columns.Clear();  // Önceki sütunları temizle
            listView1.Columns.Add("Gemi Adı", 150);
            listView1.Columns.Add("Limandan Çıkış Tarihi", 150);
            listView1.Columns.Add("Limana Varış Tarihi", 150);
            listView1.Columns.Add("Ürün Adı", 150);
            listView1.Columns.Add("Firma Adı", 150);
            listView1.Columns.Add("Urun Yükü", 100);
            listView1.Columns.Add("Kalan Tonaj", 150);

            listView1.Items.Clear();

            //Gemi tonajını ve toplam kullanılan tonajı saklamak için değişkenler
            //decimal gemiTonaji = 0;
            //decimal toplamKullanilanTonaj = 0;

            //foreach (Gonderim gonderim in gonderims)
            //{
            //    if (gemiTonaji == 0 && gonderim.SeyirKayitları.Gemi != null)
            //    {
            //        gemiTonaji = gonderim.SeyirKayitları.Gemi.Tonaji;
            //    }

            //    toplamKullanilanTonaj += gonderim.Tonaj;
            //    kalanTonaj = gemiTonaji - toplamKullanilanTonaj;
                // Her gemi için kalan tonajı tutmak için bir sözlük (Dictionary)
                Dictionary<string, decimal> gemiKalanTonaj = new Dictionary<string, decimal>();

                foreach (Gonderim gonderim in gonderims)
                {
                    if (gonderim.SeyirKayitları.Gemi == null)
                        continue; // Gemi bilgisi olmayan gönderimleri atla

                    string gemiAdi = gonderim.SeyirKayitları.Gemi.GemiAdi;
                    decimal gemiTonaji = gonderim.SeyirKayitları.Gemi.Tonaji;

                    if (!gemiKalanTonaj.ContainsKey(gemiAdi))
                    {
                        gemiKalanTonaj[gemiAdi] = gemiTonaji; // Gemi için başlangıç tonajını ayarla
                    }

                    decimal kalanTonaj = gemiKalanTonaj[gemiAdi] - gonderim.Tonaj;
                    gemiKalanTonaj[gemiAdi] = kalanTonaj; // Gemi için kalan tonajı güncelle


                    ListViewItem item = new ListViewItem();
                item.Text = gonderim.SeyirKayitları.Gemi != null ? gonderim.SeyirKayitları.Gemi.GemiAdi : "Belirtilmemiş";
                item.SubItems.Add(gonderim.SeyirKayitları.LimandanCikisTarihi.ToString("dd/MM/yyyy"));
                item.SubItems.Add(gonderim.SeyirKayitları.LimanaVarisTarihi.ToString("dd/MM/yyyy"));
                item.SubItems.Add(gonderim.Urunler.UrunAdi);
                item.SubItems.Add(gonderim.IlgilenenKisiler.BagliOlduguFirma != null ? gonderim.IlgilenenKisiler.BagliOlduguFirma.FirmaAdi : "Belirtilmemiş");
                item.SubItems.Add(gonderim.Tonaj.ToString());

                if (kalanTonaj >= 0)
                {
                    item.SubItems.Add(kalanTonaj.ToString());
                }
                else
                {
                    item.SubItems.Add("Gemi tonajından fazla");
                }

                listView1.Items.Add(item);
            }

            if (listView1.Items.Count > 0)
            {
                listView1.Items[0].Selected = true;
            }
        }
    }




    
}
