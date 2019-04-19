using SqlSample.DAL;
using SqlSample.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlSample.WinUI
{
    public partial class FormCategory : Form
    {
        private List<CategoryDAO> categories = null;

        public FormCategory()
        {
            InitializeComponent();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            IService<CategoryDAO> category = new CategoryDAL();

            categories = category.Select();

            lstboxData.Items.Clear();

            foreach (var item in categories)
            {
                lstboxData.Items.Add(item.CategoryName);
                cmboxCategories.Items.Add(item.CategoryName);
            }
            cmboxCategories.SelectedIndex = 0;
        }

        private void lstboxData_SelectedValueChanged(object sender, EventArgs e)
        {
            IService<CategoryDAO> category = new CategoryDAL();

            string text = lstboxData.GetItemText(lstboxData.SelectedItem);

            CategoryDAO catDao = category.SelectByName(text);

            MemoryStream fs = new MemoryStream(catDao.Picture, 78, catDao.Picture.Length - 78);

            pictureboxPicture.Image = System.Drawing.Image.FromStream(fs);

            fs.Flush();
            fs.Close();
        }

        private void cmboxCategories_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cmb = sender as ComboBox;

            IService<CategoryDAO> category = new CategoryDAL();

            string text = cmb.GetItemText(cmb.SelectedItem);

            CategoryDAO catDao = category.SelectByName(text);

            MemoryStream fs = new MemoryStream(catDao.Picture, 78, catDao.Picture.Length - 78);

            pictureboxPicture.Image = System.Drawing.Image.FromStream(fs);

            fs.Flush();
            fs.Close();


        }
    }
}
