using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
            dataGridView1.DataSource = db.KHACHHANGs.ToList();

            txtMASP.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "MAKH"));
            txtTENSP.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "HOTEN"));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            demodatabaseEntities db = new demodatabaseEntities();

            //db.NHANVIENs.Add(new NHANVIEN() { MANV = "NV07", HOTEN = "Nguyen Quoc Tuan", SODT = "0825381234", NGVL = new DateTime(2021, 12, 23) });
            // db.SaveChanges();
            //catch (DbEntityValidationException ex)
            //{
            //    foreach (var entityValidationErrors in ex.EntityValidationErrors)
            //    {
            //        foreach (var validationError in entityValidationErrors.ValidationErrors)
            //        {
            //            Console.WriteLine($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
            //        }
            //    }
            //}

            //db.KHACHHANGs.Add(new KHACHHANG() { HOTEN = "Dam Thanh Nam", MAKH = "KH15", DCHI = "99 Nguyen Chi Thanh", DOANHSO = 0, NGDK = new DateTime(2022, 1, 1), NGSINH = new DateTime(2003, 1, 1), SODT = "0825301233" });
            //db.SaveChanges();
        //    dataGridView1.DataSource = db.KHACHHANGs.ToList();
        }
    }
}
