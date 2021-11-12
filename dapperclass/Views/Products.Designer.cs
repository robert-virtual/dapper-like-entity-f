
namespace dapperclass.Views
{
    partial class Products
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_prods = new System.Windows.Forms.DataGridView();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.cb_cat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.n_price = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_save_prod = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_price)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_prods
            // 
            this.dgv_prods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_prods.Location = new System.Drawing.Point(28, 84);
            this.dgv_prods.Name = "dgv_prods";
            this.dgv_prods.RowHeadersWidth = 51;
            this.dgv_prods.RowTemplate.Height = 29;
            this.dgv_prods.Size = new System.Drawing.Size(500, 266);
            this.dgv_prods.TabIndex = 0;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(593, 84);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.PlaceholderText = "Name";
            this.txt_Name.Size = new System.Drawing.Size(151, 27);
            this.txt_Name.TabIndex = 1;
            // 
            // cb_cat
            // 
            this.cb_cat.FormattingEnabled = true;
            this.cb_cat.Location = new System.Drawing.Point(593, 143);
            this.cb_cat.Name = "cb_cat";
            this.cb_cat.Size = new System.Drawing.Size(151, 28);
            this.cb_cat.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(593, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Category";
            // 
            // n_price
            // 
            this.n_price.Location = new System.Drawing.Point(593, 194);
            this.n_price.Name = "n_price";
            this.n_price.Size = new System.Drawing.Size(150, 27);
            this.n_price.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(593, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price";
            // 
            // btn_save_prod
            // 
            this.btn_save_prod.Location = new System.Drawing.Point(593, 245);
            this.btn_save_prod.Name = "btn_save_prod";
            this.btn_save_prod.Size = new System.Drawing.Size(149, 29);
            this.btn_save_prod.TabIndex = 5;
            this.btn_save_prod.Text = "Save";
            this.btn_save_prod.UseVisualStyleBackColor = true;
            this.btn_save_prod.Click += new System.EventHandler(this.btn_save_prod_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_save_prod);
            this.Controls.Add(this.n_price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_cat);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.dgv_prods);
            this.Name = "Products";
            this.Text = "Products";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_prods;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.ComboBox cb_cat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown n_price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_save_prod;
    }
}