using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LibraryAutomation.Form2;

namespace LibraryAutomation
{
    public partial class KitapListesi : Form
    {
        private Form2.bookTree kitaplar;
        public KitapListesi(Form2.bookTree kitaplar)
        {
            InitializeComponent();
            this.kitaplar = kitaplar;
 
        }

        private void KitapListesi_Load(object sender, EventArgs e)
        {/*
            if (kitaplar != null && kitaplar.root != null)
            {
                listBox1.Items.Clear(); // Önce ListBox'ı temizleyin

                // Ağacı dolaşarak ListBox'a ekleyin
                InOrderTraversal(kitaplar.root);
            }*/
            ListBooks(kitaplar.root);
        }

        private void ListBooks(Form2.bookNode node)
        {
            if (node != null)
            {
                // Önce sol alt ağacı gez
                ListBooks(node.left);

                // Şu anki düğümü işle
                listBox1.Items.Add(node.bookCode + ") " + node.bookName + " | " + node.bookAuthor + " | " + node.bookType);

                // Sonra sağ alt ağacı gez
                ListBooks(node.right);
            }
        }


























        /*
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
        
        private void AddTreeNodesToListBox(Node node, ListBox listBox)
        {
            if (node != null)
            {
                // Düğümün verisini listbox'a ekleyin
                listBox.Items.Add(node.kitap_adi); // Örnek olarak kitap_tur eklenmiştir, düğümün içeriğine göre değişebilir.

                // Sol alt ağacı dolaşın
                AddTreeNodesToListBox(node.left, listBox);

                // Sağ alt ağacı dolaşın
                AddTreeNodesToListBox(node.right, listBox);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde Form2'yi çağırıp veri yapısını alıyoruz
            Form2 form2 = new Form2();
            BinaryTree<Node> rootNode = form2.GetMyTree();

            // Ağaç veri yapısını listbox'a ekliyoruz
            AddTreeNodesToListBox(rootNode.Root, listBox1);
        }

        private void BirMetotIcerisinde()
        {
            Form2 form2 = (Form2)Application.OpenForms["Form2"];
            if (form2 != null)
            {
                BinaryTree<Node> treeFromForm2 = form2.GetMyTree();
            }
        }
        */
    }
     
}

