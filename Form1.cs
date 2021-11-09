using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientProxyForm_P5_20190140015
{
    public partial class Form1 : Form
    {
        ServiceReference1.MatematikaClient obj = new ServiceReference1.MatematikaClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHasil_Click(object sender, EventArgs e)
        {
            int angka1 = Int32.Parse(angkainput1.Text);
            int angka2 = Int32.Parse(angkainput2.Text);

            double hslTambah = obj.Tambah(angka1,  angka2);
            double hslKurang = obj.Kurang(angka1, angka2);
            double hslKali = obj.Kali(angka1, angka2);
            double hslBagi = obj.Bagi(angka1, angka2);

            jumlah.Text = hslTambah.ToString();
            kurang.Text = hslKurang.ToString();
            kali.Text = hslKali.ToString();
            bagi.Text = hslBagi.ToString();
        }
    }
}
