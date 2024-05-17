using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LibraryAutomation.GecikenKitaplar;
using static LibraryAutomation.ÖdüncAlınanKitaplar;


namespace LibraryAutomation
{
    public partial class GecikenKitaplar : Form
    {
        // Bağlı liste düğümü için sınıf tanımı
        private class BagliListeDugumu
        {
            public Kitap Veri;
            public BagliListeDugumu Sonraki;

            public BagliListeDugumu(Kitap veri)
            {
                Veri = veri;
                Sonraki = null;
            }
        }

        private BagliListeDugumu bas = null;
        private BagliListeDugumu son = null;

        public GecikenKitaplar()
        {
            InitializeComponent();
        }

        private void GecikenKitaplar_Load(object sender, EventArgs e)
        {
            // Şu anki tarihi alır
            DateTime simdikiZaman = DateTime.Now;

            // ÖdüncAlınanKitaplar formundan kitap kuyruğu al

            var kitapKuyrugu = ÖdüncAlınanKitaplar.GetKuyrukVerisi();
            

            // Kuyruktan kitapları çıkar ve bağlı listeye ekle
            while (!kitapKuyrugu.BoşMu())
            {
                Kitap kitap = kitapKuyrugu.Dequeue();
                if (kitap.TeslimTarihi < simdikiZaman)
                {
                    BagliListeDugumu yeniDugum = new BagliListeDugumu(kitap);
                    if (bas == null)
                    {
                        bas = yeniDugum;
                        son = yeniDugum;
                    }
                    else
                    {
                        son.Sonraki = yeniDugum;
                        son = yeniDugum;
                    }
                }
            }

            // Bağlı listeden geciken kitapları ListBox'a ekle
            BagliListeDugumu mevcut = bas;
            while (mevcut != null)
            {
                listBox1.Items.Add($"{mevcut.Veri.Ad}");
                mevcut = mevcut.Sonraki;
            }
        }
    }
}