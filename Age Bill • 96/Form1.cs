using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_Bill___96
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            TimeSpan fark;
            int yas;
            DateTime dogumtarihi;
            dogumtarihi = Convert.ToDateTime(dtTarih.Text);
            fark = DateTime.Now.Date.Subtract(dogumtarihi);
            yas = Convert.ToInt32(fark.TotalDays);
            lblSonuc.Text = "Şuan " + yas / 365 + " yaşındasınız.";
        }
    }
}
