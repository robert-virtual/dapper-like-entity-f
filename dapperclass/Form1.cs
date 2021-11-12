using dapperclass.Models;
using dapperclass.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dapperclass
{
    public partial class Form1 : Form
    {
        Category Category = new Category();
        List<Category> Categories = new List<Category>();
        public Form1()
        {
            InitializeComponent();
            LoadCategories();
        }
        void LoadCategories()
        {
            Categories = Category.GetAll();
            LoadDGV(Categories);
        }
        void LoadDGV(List<Category> categories)
        {
            dgv_categories.DataSource = categories;
        }
        private void btn_save_category_Click(object sender, EventArgs e)
        {
            var cat = new Category() 
            {
                Name = txt_category.Text.Trim(),
            };
            Category.Save(cat);
            LoadCategories();
        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            var prods = new Products();
            prods.Show();
        }
    }
}
