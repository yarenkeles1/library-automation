using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using static LibraryAutomation.Yeni�ye;

namespace LibraryAutomation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Yeni�ye yeni�ye = new Yeni�ye();
            yeni�ye.Show();
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            �d�ncAl�nanKitaplar oduncKitaplar = new �d�ncAl�nanKitaplar();
            oduncKitaplar.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            GecikenKitaplar gecikenKitaplar = new GecikenKitaplar();
            gecikenKitaplar.Show();
        }
    }
}