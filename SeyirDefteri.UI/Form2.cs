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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SeyirDefteri.UI
{
    public partial class Form2 : Form
    {
        private List<SeyirKaydi> seyirKaydis;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(List<SeyirKaydi> seyirKaydis) : this()
        {
            this.seyirKaydis = seyirKaydis;

            foreach (SeyirKaydi seyirKaydi in seyirKaydis)
            {
                if (seyirKaydi.Gemi == null)
                {
                    MessageBox.Show("Sefer kayıtlarındaki gemi bilgisi eksik.");
                    return;
                }

                cmbSeferler.Items.Add(seyirKaydi);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "Gemi Sefer Kayıt Ekranı";
            
            FirmaEkle();
        }

        private void FirmaEkle()
        {
            List<Firma> firmalar = new List<Firma>
    {
        new Firma { FirmaId = 1, FirmaAdi = "Bilge Adam" },
        new Firma { FirmaId = 2, FirmaAdi = "Koç Holding" },
        new Firma { FirmaId = 3, FirmaAdi = "Vestel" },
        new Firma { FirmaId = 4, FirmaAdi = "Togg" },
        new Firma { FirmaId = 5, FirmaAdi = "Tesla" },
        new Firma { FirmaId = 6, FirmaAdi = "Arçelik" },
        new Firma { FirmaId = 7, FirmaAdi = "Ford Otosan" },
        new Firma { FirmaId = 8, FirmaAdi = "Turkcell" },
        new Firma { FirmaId = 9, FirmaAdi = "Vodafone" },
        new Firma { FirmaId = 10, FirmaAdi = "Türk Telekom" },
        new Firma { FirmaId = 11, FirmaAdi = "Garanti Bankası" },
        new Firma { FirmaId = 12, FirmaAdi = "Akbank" },
        new Firma { FirmaId = 13, FirmaAdi = "İş Bankası" },
        new Firma { FirmaId = 14, FirmaAdi = "Yapı Kredi" },
        new Firma { FirmaId = 15, FirmaAdi = "Halkbank" },
        new Firma { FirmaId = 16, FirmaAdi = "Ziraat Bankası" },
        new Firma { FirmaId = 17, FirmaAdi = "Bim" },
        new Firma { FirmaId = 18, FirmaAdi = "Migros" },
        new Firma { FirmaId = 19, FirmaAdi = "CarrefourSA" },
        new Firma { FirmaId = 20, FirmaAdi = "A101" },
        new Firma { FirmaId = 21, FirmaAdi = "Şok Marketler" },
        new Firma { FirmaId = 22, FirmaAdi = "LC Waikiki" },
        new Firma { FirmaId = 23, FirmaAdi = "Defacto" },
        new Firma { FirmaId = 24, FirmaAdi = "Boyner" },
        new Firma { FirmaId = 25, FirmaAdi = "Mavi" },
        new Firma { FirmaId = 26, FirmaAdi = "Koton" },
        new Firma { FirmaId = 27, FirmaAdi = "Vakko" },
        new Firma { FirmaId = 28, FirmaAdi = "Colins" },
        new Firma { FirmaId = 29, FirmaAdi = "Altınyıldız" },
        new Firma { FirmaId = 30, FirmaAdi = "Nike" },
        new Firma { FirmaId = 31, FirmaAdi = "Adidas" },
        new Firma { FirmaId = 32, FirmaAdi = "Puma" },
        new Firma { FirmaId = 33, FirmaAdi = "Reebok" },
        new Firma { FirmaId = 34, FirmaAdi = "Under Armour" },
        new Firma { FirmaId = 35, FirmaAdi = "Decathlon" },
        new Firma { FirmaId = 36, FirmaAdi = "H&M" },
        new Firma { FirmaId = 37, FirmaAdi = "Zara" },
        new Firma { FirmaId = 38, FirmaAdi = "Pull&Bear" },
        new Firma { FirmaId = 39, FirmaAdi = "Massimo Dutti" },
        new Firma { FirmaId = 40, FirmaAdi = "Bershka" },
        new Firma { FirmaId = 41, FirmaAdi = "Stradivarius" },
        new Firma { FirmaId = 42, FirmaAdi = "Oysho" },
        new Firma { FirmaId = 43, FirmaAdi = "Mango" },
        new Firma { FirmaId = 44, FirmaAdi = "İpekyol" },
        new Firma { FirmaId = 45, FirmaAdi = "Derimod" },
        new Firma { FirmaId = 46, FirmaAdi = "Kemal Tanca" },
        new Firma { FirmaId = 47, FirmaAdi = "Greyder" },
        new Firma { FirmaId = 48, FirmaAdi = "FLO" },
        new Firma { FirmaId = 49, FirmaAdi = "Hotiç" },
        new Firma { FirmaId = 50, FirmaAdi = "Vakko" }
    };

            foreach (var firma in firmalar)
            {
                cmnFirma.Items.Add(firma);
            }
        }

        int urunId = 1;
        int ilgilenKisiId = 1;
        int id = 0;
        private Gemi selectedGemi;
        /// <summary>
        /// Başlangıçta validasyonlar eklendi 
        /// 1- Gelen Seferler Boş mu değil mi
        /// 2- urun var mı yok mu
        /// 3- Bir adet seyir kaydı oluşturuluyor bunu gelen seferlere cast ediyoruz bunuda nullable olabildiği için as ile cast ettik
        /// 4- gemi tipinde selectedgemi selectedSeyirKaydindaki geminin içine atıyoruz onun içinde tonaj kıyaslaması yapıyoruz
        /// 5-ilgili kişi kontrol edilyor
        /// 6-telefon kontrol ediliyor
        /// 7- gonderim nesnesine atama yapılıyor
        /// 8-listview içersine gönderiliyor
        /// 9- lstGonderim.Tag = gonderim; // gonderim nesnesini Tag olarak ayarla
        /// 10-ekleme yapıldı
        /// 11-temizle metodu eklendi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            Gonderim gonderim = new Gonderim();
            if (cmbSeferler.SelectedItem == null)
            {
                MessageBox.Show("Seferler Olmadan Ekleme Yapılamaz");
                return;
            }
            if (String.IsNullOrWhiteSpace(txtUrun.Text))
            {
                MessageBox.Show("Ürün adı boş olamaz.");
                return;
            }
            if (KelimeKontroluYap(txtIlgilenenKisi.Text) || txtIlgilenenKisi.Text.Length < 6)
            {
                MessageBox.Show("İlgilenilen kişi adı alanına uygun bir isim soyisim giriniz.");
                return;
            }
            if (KelimeKontroluYap(txtUrun.Text) || txtUrun.Text.Length < 2)
            {
                MessageBox.Show("Ürün adı alanına uygun bir ürün adı giriniz.");
                return;
            }
            // Seçili öğeyi doğrudan alın
            SeyirKaydi selectedSeyirKaydi = cmbSeferler.SelectedItem as SeyirKaydi;

            if (selectedSeyirKaydi == null || selectedSeyirKaydi.Gemi == null)
            {
                MessageBox.Show("Geçerli bir sefer seçilmedi veya gemi bilgisi eksik.");
                return;
            }
            if (nmdTonaj.Value <= 0)
            {
                MessageBox.Show("Ürün tonajı sıfıra eşit veya küçük olamaz.");
                return;
            }

            selectedGemi = selectedSeyirKaydi.Gemi;
            // Gemi tonajını kontrol et
            if (selectedGemi.Tonaji < nmdTonaj.Value)
            {
                MessageBox.Show("Geminin tonajından büyük bir değer girilemez.");
                return;
            }
            if (String.IsNullOrWhiteSpace(txtIlgilenenKisi.Text))
            {
                MessageBox.Show("İlgilenen Kişinin adı boş olamaz.");
                return;
            }
            if (!HarfKontroluYap(txtIlgilenenKisi.Text))
            {
                MessageBox.Show("İlgilenen kişi adı girerken sadece harf giriniz.");
                return;
            }
            if (mtxtIlgilenenKisiTelefon.Text.Count() < 14)
            {
                MessageBox.Show("İlgilenen Kişinin Telefon Numarası eksiksiz girilmeli.");
                return;
            }


            decimal mevcutYuk = 0;
            foreach (ListViewItem item in lstVGonderim.Items)
            {
                if (item.SubItems[1].Text == selectedGemi.GemiAdi)
                {
                    mevcutYuk += decimal.Parse(item.SubItems[2].Text);
                }
            }

            mevcutYuk += (decimal)nmdTonaj.Value;

            if (mevcutYuk > selectedGemi.Tonaji)
            {
                MessageBox.Show("Geminin tonajını aşacak şekilde yükleme yapılamaz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            gonderim.SeyirKayitları = (SeyirKaydi)cmbSeferler.SelectedItem; //Sefer kayıtlarını al 
            gonderim.Urunler = new Urun();
            gonderim.Tonaj = nmdTonaj.Value;
            gonderim.Urunler.UrunAdi = txtUrun.Text.Trim();
            gonderim.Urunler.UrunId = urunId++;

            gonderim.IlgilenenKisiler = new IlgilenenKisi();
            gonderim.IlgilenenKisiler.KisininAdi = txtIlgilenenKisi.Text.Trim();
            gonderim.IlgilenenKisiler.KisininTelefonu = mtxtIlgilenenKisiTelefon.Text;
            gonderim.IlgilenenKisiler.IlgilenenKisiId = ilgilenKisiId++;
            gonderim.IlgilenenKisiler.BagliOlduguFirma = (Firma)cmnFirma.SelectedItem;

            ListViewItem lstGonderim = new ListViewItem();
            lstGonderim.Text = (++id).ToString();
            lstGonderim.SubItems.Add(gonderim.SeyirKayitları.Gemi.GemiAdi);
            lstGonderim.SubItems.Add(gonderim.Tonaj.ToString());
            lstGonderim.SubItems.Add(gonderim.Urunler.UrunAdi);
            lstGonderim.SubItems.Add(gonderim.IlgilenenKisiler.BagliOlduguFirma != null ? gonderim.IlgilenenKisiler.BagliOlduguFirma.FirmaAdi : string.Empty); //firma var mı yok mu kontrol et
            lstGonderim.SubItems.Add(gonderim.IlgilenenKisiler.KisininAdi);
            lstGonderim.SubItems.Add(gonderim.IlgilenenKisiler.KisininTelefonu);
            lstGonderim.Tag = gonderim; // gonderim nesnesini Tag olarak ayarla
            lstVGonderim.Items.Add(lstGonderim);
            Temizle();
        }

        private void Temizle()
        {
            cmbSeferler.SelectedItem = null;
            cmnFirma.SelectedItem = null;
            txtUrun.Text = string.Empty;
            txtIlgilenenKisi.Text = string.Empty;
            mtxtIlgilenenKisiTelefon.Text = string.Empty;
            nmdTonaj.Value = 0;
            pbGemiler.Image = null;
        }

        private bool HarfKontroluYap(string metin) 
        {
            return System.Text.RegularExpressions.Regex.IsMatch(metin, @"^[a-zA-ZĞÜŞİÖÇığüşöç\s]+$") ? true : false;
        }

        private bool KelimeKontroluYap(string kelime) 
        {
            bool uygunMu = true;
            List<string> yasakliKelimeler = new List<string>() { "asd", "asdd", "dddd" };
            foreach (string item in yasakliKelimeler)
            {
                
                uygunMu = kelime.Contains(item) ? true : false;
            }
            return uygunMu;
        }

    private void btnZRaporu_Click(object sender, EventArgs e)
        {
            if (lstVGonderim.Items.Count > 0)
            {
                List<Gonderim> gonderims = new List<Gonderim>();
                foreach (ListViewItem item in lstVGonderim.Items)
                {
                    gonderims.Add((Gonderim)item.Tag);
                }
                Form3 form3 = new Form3(gonderims);
                form3.Show();
            }
            else
            {
                MessageBox.Show("Liste Boş Gönderilemez");
            }
        }

        private void cmbSeferler_SelectedIndexChanged(object sender, EventArgs e)
        {
            SeyirKaydi selectedSeyirKaydi = cmbSeferler.SelectedItem as SeyirKaydi;
            if (selectedSeyirKaydi != null) 
            {
                pbGemiler.Image = Image.FromFile(selectedSeyirKaydi.Gemi.FotografYolu);
            }
        }
    }
}
