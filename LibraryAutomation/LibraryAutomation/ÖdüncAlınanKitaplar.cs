using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LibraryAutomation.ÖdüncAlınanKitaplar;


namespace LibraryAutomation
{
    public partial class ÖdüncAlınanKitaplar : Form
    {
        public ÖdüncAlınanKitaplar()
        {
            InitializeComponent();
        }

        public static Kuyruk<Kitap> GetKuyrukVerisi()
        {
            return kitapKuyrugu;
        }
        public class Kuyruk<T>
        {
            private class KuyrukDüğüm
            {
                public T Veri;
                public KuyrukDüğüm Sonraki;

                public KuyrukDüğüm(T veri)
                {
                    Veri = veri;
                    Sonraki = null;
                }
            }

            private KuyrukDüğüm baş;
            private KuyrukDüğüm son;

            public Kuyruk()
            {
                baş = null;
                son = null;
            }

            public void Enqueue(T veri)
            {
                KuyrukDüğüm yeniDüğüm = new KuyrukDüğüm(veri);

                if (son == null)
                {
                    baş = yeniDüğüm;
                    son = yeniDüğüm;
                }
                else
                {
                    son.Sonraki = yeniDüğüm;
                    son = yeniDüğüm;
                }
            }

            public T Dequeue()
            {
                if (baş == null)
                {
                    throw new InvalidOperationException("Kuyruk boş.");
                }

                T çıkarılan = baş.Veri;
                baş = baş.Sonraki;

                if (baş == null)
                {
                    son = null;
                }

                return çıkarılan;
            }

            public bool BoşMu()
            {
                return baş == null;
            }
        }

        public class Kitap
        {
            public string Ad { get; set; }
            public string Yazar { get; set; }
            public string Kategori { get; set; }
            public DateTime VerilmeTarihi { get; set; }
            public DateTime TeslimTarihi { get; set; }
        }

        // Kuyruk oluştur
        public static Kuyruk<Kitap> kitapKuyrugu = new Kuyruk<Kitap>();


        private void ÖdüncAlınanKitaplar_Load(object sender, EventArgs e)
        {

            string ad = "Suç ve Ceza";
            string yazar = "Dostoyevski";
            string kategori = "Roman";

            string ad1 = "Bir idam mahkumunun son günü";
            string yazar1 = "Victor Hugo";
            string kategori1 = "Roman";

            string ad2 = "Romeo ve Juliet";
            string yazar2 = "William Shakespeare";
            string kategori2 = "Tiyatro";

            string ad3 = "Yüzüklerin Efendisi";
            string yazar3 = "J.R.R Tolkien";
            string kategori3 = "Fantastik Kurgu";

            string ad4 = "Harry Potter";
            string yazar4 = "J.K Rowling";
            string kategori4 = "Fantastik Kurgu";

            string ad5 = "Dune";
            string yazar5 = "Frank Herbert";
            string kategori5 = "Bilim Kurgu";

            DateTime verilmeTarihi = new DateTime(2024, 5, 4);
            DateTime verilmeTarihi1 = new DateTime(2024, 5, 8);
            DateTime verilmeTarihi2 = new DateTime(2024, 5, 2);
            DateTime verilmeTarihi3 = new DateTime(2024, 5, 6);
            DateTime verilmeTarihi4 = new DateTime(2024, 5, 3);
            DateTime verilmeTarihi5 = new DateTime(2024, 5, 4);

            DateTime TeslimTarihi = verilmeTarihi.AddDays(10);
            DateTime TeslimTarihi1 = verilmeTarihi1.AddDays(10);
            DateTime TeslimTarihi2 = verilmeTarihi2.AddDays(10);
            DateTime TeslimTarihi3 = verilmeTarihi3.AddDays(10);
            DateTime TeslimTarihi4 = verilmeTarihi4.AddDays(10);
            DateTime TeslimTarihi5 = verilmeTarihi5.AddDays(10);


            // Kitap nesnesi oluştur
            Kitap yeniKitap = new Kitap()
            {
                Ad = ad,
                Yazar = yazar,
                Kategori = kategori,
                VerilmeTarihi = verilmeTarihi,
                TeslimTarihi = TeslimTarihi,
            };

            Kitap yeniKitap1 = new Kitap()
            {
                Ad = ad1,
                Yazar = yazar1,
                Kategori = kategori1,
                VerilmeTarihi = verilmeTarihi1,
                TeslimTarihi = TeslimTarihi1,
            };

            Kitap yeniKitap2 = new Kitap()
            {
                Ad = ad2,
                Yazar = yazar2,
                Kategori = kategori2,
                VerilmeTarihi = verilmeTarihi2,
                TeslimTarihi = TeslimTarihi2,
            };

            Kitap yeniKitap3 = new Kitap()
            {
                Ad = ad3,
                Yazar = yazar3,
                Kategori = kategori3,
                VerilmeTarihi = verilmeTarihi3,
                TeslimTarihi = TeslimTarihi3,
            };

            Kitap yeniKitap4 = new Kitap()
            {
                Ad = ad4,
                Yazar = yazar4,
                Kategori = kategori4,
                VerilmeTarihi = verilmeTarihi4,
                TeslimTarihi = TeslimTarihi4,
            };

            Kitap yeniKitap5 = new Kitap()
            {
                Ad = ad5,
                Yazar = yazar5,
                Kategori = kategori5,
                VerilmeTarihi = verilmeTarihi5,
                TeslimTarihi = TeslimTarihi5,
            };

            // Kuyruğa kitap ekle
            kitapKuyrugu.Enqueue(yeniKitap);
            kitapKuyrugu.Enqueue(yeniKitap1);
            kitapKuyrugu.Enqueue(yeniKitap2);
            kitapKuyrugu.Enqueue(yeniKitap3);
            kitapKuyrugu.Enqueue(yeniKitap4);
            kitapKuyrugu.Enqueue(yeniKitap5);

            // ListBox'a kitap bilgilerini ekle
            listBox1.Items.Add($"{ad} - {yazar} - {kategori} - {verilmeTarihi}");
            listBox1.Items.Add($"{ad1} - {yazar1} - {kategori1} - {verilmeTarihi1}");
            listBox1.Items.Add($"{ad2} - {yazar2} - {kategori2} - {verilmeTarihi2}");
            listBox1.Items.Add($"{ad3} - {yazar3} - {kategori3} - {verilmeTarihi3}");
            listBox1.Items.Add($"{ad4} - {yazar4} - {kategori4} - {verilmeTarihi4}");
            listBox1.Items.Add($"{ad5} - {yazar5} - {kategori5} - {verilmeTarihi5}");
        }

            public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

    }
}
