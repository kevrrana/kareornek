using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kareninalanı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int kisakenar, uzunkenar,alan,cevre, hesapla;
            kisakenar = Convert.ToInt32(txtKisaKenar.Text);
            uzunkenar = Convert.ToInt32(txtUzunKenar.Text);
            alan = kisakenar * uzunkenar;
            cevre = (kisakenar + uzunkenar)*2;
            lblAlan.Text="Alan : "+alan.ToString(); 
            lblÇevre.Text="Çevre : "+cevre.ToString();
            

        }
    }
}
