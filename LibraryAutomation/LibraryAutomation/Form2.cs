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
using System.Xml.Linq;

namespace LibraryAutomation
{
    public partial class Form2 : Form
    {
        public bookTree kitaplar;
        public Form2()
        {
            InitializeComponent();
            kitaplar = new bookTree();

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kitapAd = textBox2.Text;
            string kitapYazar = textBox3.Text;
            string kitapTur = textBox5.Text;
            int kitapKod = int.Parse(maskedTextBox1.Text);

            bookNode kitapNode = new bookNode(kitapAd, kitapYazar, kitapTur, kitapKod);

            AddToTree(kitapNode, kitaplar);

            listBox1.Items.Add(kitapNode.bookCode + " | " + kitapNode.bookName + " | " + kitapNode.bookAuthor + " | " + kitapNode.bookType);
            Temizle();
        }

        public class bookTree
        {
            public bookNode root;

            public bookTree()
            {
                root = null;
            }

        }
        public class bookNode
        {
            public string bookName;
            public string bookAuthor;
            public string bookType;
            public int bookCode;

            public bookNode right;
            public bookNode left;

            public bookNode(string bookName, string bookAuthor, string bookType, int bookCode)
            {
                this.bookName = bookName;
                this.bookAuthor = bookAuthor;
                this.bookType = bookType;
                this.bookCode = bookCode;

                this.right = null;
                this.left = null;
            }
        }

        public static void AddToTree(bookNode node, bookTree tree)
        {
            bookNode temp = null;
            bookNode n = tree.root;

            while (n != null)
            {
                temp = n;

                if (node.bookCode < n.bookCode)
                    n = n.left;
                else
                    n = n.right;
            }

            if (temp == null)
                tree.root = temp;
            else
            {
                if (node.bookCode < temp.bookCode)
                    temp.left = node;
                else
                    temp.right = node;
            }

        }

        private void Temizle()
        {
            // TextBox'ların içeriği temizlenir
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            maskedTextBox1.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

