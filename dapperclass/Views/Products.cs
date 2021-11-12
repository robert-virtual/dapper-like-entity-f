using dapperclass.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dapperclass.Views
{
    public partial class Products : Form
    {
        Category Cat = new Category();
        Product Prod = new Product();
        List<Product> Prods = new List<Product>();

        List<Category> Cats = new List<Category>(); 
        public Products()
        {
            InitializeComponent();
            LoadCategories();
            LoadProds();
        }
        void LoadProds()
        {
            Prods = Prod.GetAll();
            LoadDGV(Prods);
        }
        void LoadDGV(List<Product> prods)
        {
            dgv_prods.DataSource = prods;
        }
        void LoadCategories()
        {
            Cats = Cat.GetAll();
            cb_cat.DataSource = Cats;
            cb_cat.DisplayMember = "Name";
            cb_cat.ValueMember = "Id";
        }

        private void btn_save_prod_Click(object sender, EventArgs e)
        {
            var prod = new Product()
            {
                Name = txt_Name.Text.Trim(),
                Price = n_price.Value,
                CategoryFk = cb_cat.SelectedValue.GetHashCode()
            };
            Product.Save(prod);
            LoadProds();
        }
    }
}
