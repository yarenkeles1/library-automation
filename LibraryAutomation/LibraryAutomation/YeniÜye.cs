using Microsoft.VisualBasic.ApplicationServices;
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
using static LibraryAutomation.Form2;

namespace LibraryAutomation
{
    
    public partial class YeniÜye : Form
    {
        public uyeStack uyeler;

        public class uyeStack
        {
            public uyeNode bas;
            public uyeNode son;

            public uyeStack()
            {
                bas = null;
                son = null;
            }
        }
        public class uyeNode
        {
            public long uyeTC;
            public string uyeName;
            public string uyeBolum;
            public long uyeTel;
            public string uyeAdres;
            public string uyeEposta;

            public uyeNode next;

            public uyeNode(long uyeTC, string uyeName, string uyeBolum, long uyeTel, string uyeAdres, string uyeEposta)
            {
                this.uyeTC = uyeTC;
                this.uyeName = uyeName;
                this.uyeBolum = uyeBolum;
                this.uyeTel = uyeTel;
                this.uyeAdres = uyeAdres;
                this.uyeEposta = uyeEposta;

                this.next = null;
            }
        }

        public static void AddToStack(uyeNode node, uyeStack stack)
        {
           
            if (stack.bas == null)
                stack.bas = node;
            else
            {
                node.next = stack.bas;
                stack.bas = node;
            }
        }
        public YeniÜye()
        {
            InitializeComponent();
            uyeler = new uyeStack();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long uyeTC = long.Parse(textBox1.Text);
            string uyeIsim = textBox2.Text;
            string uyeBolum = textBox3.Text;
            long uyeTel = long.Parse(textBox4.Text);
            string uyeAdres = textBox5.Text;
            string uyeEposta = textBox6.Text;

            uyeNode uyeNode = new uyeNode(uyeTC, uyeIsim, uyeBolum, uyeTel, uyeAdres, uyeEposta);

            listBox1.Items.Add(uyeNode.uyeTC + " | " + uyeNode.uyeName + " | " + uyeNode.uyeBolum + " | " + uyeNode.uyeTel + " | " + uyeNode.uyeAdres + " | " + uyeNode.uyeEposta);
            Temizle();
        }

        private void Temizle()
        {
            // TextBox'ların içeriği temizlenir
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
    }
}
        
