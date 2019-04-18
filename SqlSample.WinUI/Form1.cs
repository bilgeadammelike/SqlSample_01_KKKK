using SqlSample.DAL;
using SqlSample.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlSample.WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShipperDAL dal = new ShipperDAL();

            List<ShipperDAO> listShipper = dal.ShiperSelect();
            if(listShipper == null)
            {
                MessageBox.Show("Veri Boş Geldi.");
            }

            foreach (var item in dal.ShiperSelect())
            {
                lstShippers.Items.Add(item);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShipperDAL dal = new ShipperDAL();
            ShipperDAO dao = new ShipperDAO()
            {
                CompanyName = txtShipperName.Text,
                Phone = txtmskTelNo.Text
            };
            int nResult = dal.SihipperAdd(dao);
            if (nResult == 0)
            {
                MessageBox.Show("Veri Boş Geldi.");
            }

        }
    }
}
