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
using static LibraryAutomation.YeniÜye;

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
            YeniÜye yeniüye = new YeniÜye();
            yeniüye.Show();
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            ÖdüncAlýnanKitaplar oduncKitaplar = new ÖdüncAlýnanKitaplar();
            oduncKitaplar.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            GecikenKitaplar gecikenKitaplar = new GecikenKitaplar();
            gecikenKitaplar.Show();
        }
    }
}