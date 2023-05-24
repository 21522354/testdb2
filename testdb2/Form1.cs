using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testdb2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            demodatabaseEntities db = new demodatabaseEntities();
            dataGridView1.DataSource = db.SANPHAMs.ToList();

            txtMASP.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "MASP"));
            txtTENSP.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "TENSP"));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            demodatabaseEntities db = new demodatabaseEntities();

            var querry1 = from a in db.SANPHAMs
                          join b in db.CTHDs on a.MASP equals b.MASP
                          where a.NUOCSX == "Trung Quoc"
                          select a;

            var querry2 = from a in db.HOADONs
                          join b in db.CTHDs
                          on a.SOHD equals b.SOHD
                          where a.NGHD.Value.Year == 2006
                          select new { MASP = b.MASP , NGHD = a.NGHD};


            var querry3 = db.SANPHAMs.Find("TV02");

            MessageBox.Show(querry3.MASP + " " + querry3.TENSP + " " + querry3.GIA); 

            dataGridView1.DataSource = querry3;
        }
    }
}
