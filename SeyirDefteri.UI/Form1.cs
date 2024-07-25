﻿using SeyirDefteri.Core;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GemileriOlustur();
            LimanOlustur();
            this.Text = "Sefer";
        }

        private void LimanOlustur()
        {
            List<string> limanlar = new List<string>
    {
        "İstanbul Sarıyer Yat Limanı, Türkiye",
        "İstanbul Beşiktaş Limanı, Türkiye",
        "İstanbul Haydarpaşa Limanı, Türkiye",
        "İstanbul Kadıköy Limanı, Türkiye",
        "İstanbul Karaköy Limanı, Türkiye",
        "İstanbul Ambarlı Limanı, Türkiye",
        "İstanbul Bakırköy Limanı, Türkiye",
        "İzmir Alsancak Limanı, Türkiye",
        "İzmir Çeşme Limanı, Türkiye",
        "İzmir Karşıyaka Limanı, Türkiye",
        "İzmir Aliağa Limanı, Türkiye",
        "Mersin Limanı, Türkiye",
        "Antalya Limanı, Türkiye",
        "Bodrum Limanı, Türkiye",
        "Göcek Limanı, Türkiye",
        "Fethiye Limanı, Türkiye",
        "Kuşadası Limanı, Türkiye",
        "Trabzon Limanı, Türkiye",
        "Samsun Limanı, Türkiye",
        "Hopa Limanı, Türkiye",
        "Port of Piraeus, Yunanistan",
        "Port of Thessaloniki, Yunanistan",
        "Port of Heraklion, Yunanistan",
        "Port of Patras, Yunanistan",
        "Port of Volos, Yunanistan",
        "Port of Genoa, İtalya",
        "Port of Naples, İtalya",
        "Port of Livorno, İtalya",
        "Port of Civitavecchia, İtalya",
        "Port of Venice, İtalya",
        "Port of Marseille, Fransa",
        "Port of Le Havre, Fransa"
    };

            foreach (string liman in limanlar)
            {
                cmnCikisLimani.Items.Add(liman);
                cmnUgradigiLimani.Items.Add(liman);
                cmnVarisLimani.Items.Add(liman);
            }
        }


        private void GemileriOlustur()
        {
            List<Gemi> gemiler = new List<Gemi>
    {
        new Gemi { GemiId = 1, GemiAdi = "Titanic", Tonaji = 46000m },
        new Gemi { GemiId = 2, GemiAdi = "Queen Mary 2", Tonaji = 148528m },
        new Gemi { GemiId = 3, GemiAdi = "Oasis of the Seas", Tonaji = 226838m },
        new Gemi { GemiId = 4, GemiAdi = "Harmony of the Seas", Tonaji = 226963m },
        new Gemi { GemiId = 5, GemiAdi = "Symphony of the Seas", Tonaji = 228081m },
        new Gemi { GemiId = 6, GemiAdi = "MSC Meraviglia", Tonaji = 171598m },
        new Gemi { GemiId = 7, GemiAdi = "Norwegian Escape", Tonaji = 165300m },
        new Gemi { GemiId = 8, GemiAdi = "Costa Smeralda", Tonaji = 185010m },
        new Gemi { GemiId = 9, GemiAdi = "AIDAnova", Tonaji = 183900m },
        new Gemi { GemiId = 10, GemiAdi = "Mardi Gras", Tonaji = 180000m },
        new Gemi { GemiId = 11, GemiAdi = "Regal Princess", Tonaji = 142714m },
        new Gemi { GemiId = 12, GemiAdi = "Majestic Princess", Tonaji = 143700m },
        new Gemi { GemiId = 13, GemiAdi = "Celebrity Edge", Tonaji = 130818m },
        new Gemi { GemiId = 14, GemiAdi = "MSC Seaview", Tonaji = 154000m },
        new Gemi { GemiId = 15, GemiAdi = "Carnival Vista", Tonaji = 133500m }
    };

            foreach (var gemi in gemiler)
            {
                cmbGemi.Items.Add(gemi);
            }
        }

        //gemilerin seferde olduğu zaman listeden çıakrılsın
        int id = 0;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if ((dtpLimanCikisTarihi.Value > dtpLimanVarisTarihi.Value))
            {
                MessageBox.Show("Varış Tarihi Çıkış Küçük olamaz");
                return;
            }
            if (cmbGemi.SelectedItem == null)
            {
                MessageBox.Show("Gemi girilmesi zorunludur");
                return;
            }
            if (cmnCikisLimani.SelectedItem == null && cmnUgradigiLimani.SelectedItem == null && cmnVarisLimani.SelectedItem == null)
            {
                MessageBox.Show("Limanlar Boş olamaz");
                return;
            }

            if (cmnCikisLimani.SelectedItem == cmnUgradigiLimani.SelectedItem || cmnUgradigiLimani.SelectedItem == cmnVarisLimani.SelectedItem || cmnCikisLimani.SelectedItem == cmnVarisLimani.SelectedItem)
            {
                MessageBox.Show("Sefer sırasında girilen duraklar farklı olmak zorundadır");
                return;
            }
            SeyirKaydi seyirDefteri = new SeyirKaydi();

            seyirDefteri.LimandanCikisTarihi = dtpLimanCikisTarihi.Value;
            seyirDefteri.LimanaVarisTarihi = dtpLimanVarisTarihi.Value;
            seyirDefteri.CikisLimani = cmnCikisLimani.SelectedItem.ToString();
            seyirDefteri.UgrayacagiLiman = cmnUgradigiLimani.SelectedItem.ToString();
            seyirDefteri.VarisLimani = cmnVarisLimani.SelectedItem.ToString();
            seyirDefteri.Gemi = (Gemi)cmbGemi.SelectedItem;

            ListViewItem lstSyeriDefteri = new ListViewItem();
            lstSyeriDefteri.Text = (++id).ToString();
            lstSyeriDefteri.SubItems.Add(seyirDefteri.LimanaVarisTarihi.ToString());
            lstSyeriDefteri.SubItems.Add(seyirDefteri.LimandanCikisTarihi.ToString());

            lstSyeriDefteri.SubItems.Add(seyirDefteri.CikisLimani.ToString());
            lstSyeriDefteri.SubItems.Add(seyirDefteri.UgrayacagiLiman.ToString());
            lstSyeriDefteri.SubItems.Add(seyirDefteri.VarisLimani.ToString());
            lstSyeriDefteri.SubItems.Add(seyirDefteri.Gemi.ToString());
            lstSyeriDefteri.Tag = seyirDefteri;


            lstSeyirDefteri.Items.Add(lstSyeriDefteri);

            Temizle();
        }

        private void Temizle()
        {
            dtpLimanCikisTarihi.Value = DateTime.Today;
            dtpLimanVarisTarihi.Value = DateTime.Today;
            cmbGemi.SelectedItem = null;
            cmnCikisLimani.SelectedItem = null;
            cmnUgradigiLimani.SelectedItem = null;
            cmnVarisLimani.SelectedItem = null;

        }

        private void btnGec_Click(object sender, EventArgs e)
        {
            if (lstSeyirDefteri.Items.Count > 0)
            {
                List<SeyirKaydi> seyirKaydis = new List<SeyirKaydi>();
                foreach (ListViewItem item in lstSeyirDefteri.Items)
                {
                    seyirKaydis.Add((SeyirKaydi)item.Tag);
                }
                Form2 form2 = new Form2(seyirKaydis);
                form2.Show();
            }
            else
            {
                MessageBox.Show("Lütfen Seyirlerinizi Listeye Ekleyiniz");
            }
        }
    }
}
