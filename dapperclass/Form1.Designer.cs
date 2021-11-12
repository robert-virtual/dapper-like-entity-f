
namespace dapperclass
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_category = new System.Windows.Forms.TextBox();
            this.btn_save_category = new System.Windows.Forms.Button();
            this.dgv_categories = new System.Windows.Forms.DataGridView();
            this.btn_products = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categories)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_category
            // 
            this.txt_category.Location = new System.Drawing.Point(605, 90);
            this.txt_category.Name = "txt_category";
            this.txt_category.PlaceholderText = "Category";
            this.txt_category.Size = new System.Drawing.Size(125, 27);
            this.txt_category.TabIndex = 0;
            // 
            // btn_save_category
            // 
            this.btn_save_category.Location = new System.Drawing.Point(636, 132);
            this.btn_save_category.Name = "btn_save_category";
            this.btn_save_category.Size = new System.Drawing.Size(94, 29);
            this.btn_save_category.TabIndex = 1;
            this.btn_save_category.Text = "Save";
            this.btn_save_category.UseVisualStyleBackColor = true;
            this.btn_save_category.Click += new System.EventHandler(this.btn_save_category_Click);
            // 
            // dgv_categories
            // 
            this.dgv_categories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_categories.Location = new System.Drawing.Point(70, 115);
            this.dgv_categories.Name = "dgv_categories";
            this.dgv_categories.RowHeadersWidth = 51;
            this.dgv_categories.RowTemplate.Height = 29;
            this.dgv_categories.Size = new System.Drawing.Size(458, 220);
            this.dgv_categories.TabIndex = 2;
            // 
            // btn_products
            // 
            this.btn_products.Location = new System.Drawing.Point(636, 343);
            this.btn_products.Name = "btn_products";
            this.btn_products.Size = new System.Drawing.Size(94, 29);
            this.btn_products.TabIndex = 1;
            this.btn_products.Text = "Products";
            this.btn_products.UseVisualStyleBackColor = true;
            this.btn_products.Click += new System.EventHandler(this.btn_products_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_categories);
            this.Controls.Add(this.btn_products);
            this.Controls.Add(this.btn_save_category);
            this.Controls.Add(this.txt_category);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_category;
        private System.Windows.Forms.Button btn_save_category;
        private System.Windows.Forms.DataGridView dgv_categories;
        private System.Windows.Forms.Button btn_products;
    }
}

