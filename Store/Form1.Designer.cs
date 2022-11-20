namespace Store
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
            this.panel_product = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.category = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_suprr = new System.Windows.Forms.Button();
            this.button_modifier = new System.Windows.Forms.Button();
            this.button_ajoute = new System.Windows.Forms.Button();
            this.panel_product.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_product
            // 
            this.panel_product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.panel_product.Controls.Add(this.label1);
            this.panel_product.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_product.Location = new System.Drawing.Point(0, 0);
            this.panel_product.Name = "panel_product";
            this.panel_product.Size = new System.Drawing.Size(706, 101);
            this.panel_product.TabIndex = 0;
            this.panel_product.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(52, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Dashbord";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button_suprr);
            this.panel1.Controls.Add(this.button_modifier);
            this.panel1.Controls.Add(this.button_ajoute);
            this.panel1.Location = new System.Drawing.Point(42, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 314);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.category);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Location = new System.Drawing.Point(43, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(534, 195);
            this.panel2.TabIndex = 5;
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.category.ForeColor = System.Drawing.Color.Black;
            this.category.Location = new System.Drawing.Point(89, 34);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(113, 21);
            this.category.TabIndex = 7;
            this.category.Text = "select category";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(208, 34);
            this.comboBox1.MaxDropDownItems = 20;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(190, 23);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button_suprr
            // 
            this.button_suprr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.button_suprr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_suprr.ForeColor = System.Drawing.Color.White;
            this.button_suprr.Location = new System.Drawing.Point(367, 248);
            this.button_suprr.Name = "button_suprr";
            this.button_suprr.Size = new System.Drawing.Size(102, 45);
            this.button_suprr.TabIndex = 2;
            this.button_suprr.Text = "Supr";
            this.button_suprr.UseVisualStyleBackColor = false;
            this.button_suprr.Click += new System.EventHandler(this.button_suprr_Click);
            // 
            // button_modifier
            // 
            this.button_modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.button_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_modifier.ForeColor = System.Drawing.Color.White;
            this.button_modifier.Location = new System.Drawing.Point(250, 248);
            this.button_modifier.Name = "button_modifier";
            this.button_modifier.Size = new System.Drawing.Size(101, 45);
            this.button_modifier.TabIndex = 1;
            this.button_modifier.Text = "Modifier";
            this.button_modifier.UseVisualStyleBackColor = false;
            this.button_modifier.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_ajoute
            // 
            this.button_ajoute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.button_ajoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ajoute.ForeColor = System.Drawing.Color.White;
            this.button_ajoute.Location = new System.Drawing.Point(132, 248);
            this.button_ajoute.Name = "button_ajoute";
            this.button_ajoute.Size = new System.Drawing.Size(103, 45);
            this.button_ajoute.TabIndex = 0;
            this.button_ajoute.Text = "Ajoute";
            this.button_ajoute.UseVisualStyleBackColor = false;
            this.button_ajoute.Click += new System.EventHandler(this.button_ajoute_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 489);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_product);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Product_form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_product.ResumeLayout(false);
            this.panel_product.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_product;
        private Label label1;
        private Panel panel1;
        private Button button_suprr;
        private Button button_modifier;
        private Button button_ajoute;
        private Panel panel2;
        private Label category;
        private ComboBox comboBox1;
    }
}