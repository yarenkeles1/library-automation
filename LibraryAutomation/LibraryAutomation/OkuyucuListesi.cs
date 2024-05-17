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
using static LibraryAutomation.YeniÜye;


namespace LibraryAutomation
{
    public partial class OkuyucuListesi : Form
    {
        //public Stack<Node> stack;

        public OkuyucuListesi()
        {
            InitializeComponent();
            
        }
        
        private void OkuyucuListesi_Load(object sender, EventArgs e)
        {
            /*
            Node current = stack.top;
            while (current != null)
            {
                listBox1.Items.Add($"TC: {current.UyeTc}, İsim: {current.UyeIsim}, Bölüm: {current.UyeBolum}, Telefon: {current.UyeTelNo}, E-Posta: {current.UyeEPosta}, Adres: {current.UyeAdres}");
                current = current.Next;
            }*/
        }
        
    }
}
