namespace Store
{
    partial class AddProductForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.input_productPrice = new System.Windows.Forms.TextBox();
            this.input_productName = new System.Windows.Forms.TextBox();
            this.button_annuler = new System.Windows.Forms.Button();
            this.button_enregistrer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Product";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.input_productPrice);
            this.panel2.Controls.Add(this.input_productName);
            this.panel2.Controls.Add(this.button_annuler);
            this.panel2.Controls.Add(this.button_enregistrer);
            this.panel2.Location = new System.Drawing.Point(28, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(412, 362);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(74, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(74, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // input_productPrice
            // 
            this.input_productPrice.Location = new System.Drawing.Point(129, 136);
            this.input_productPrice.Name = "input_productPrice";
            this.input_productPrice.Size = new System.Drawing.Size(192, 23);
            this.input_productPrice.TabIndex = 6;
            this.input_productPrice.TextChanged += new System.EventHandler(this.input_productPrice_TextChanged);
            // 
            // input_productName
            // 
            this.input_productName.Location = new System.Drawing.Point(129, 74);
            this.input_productName.Name = "input_productName";
            this.input_productName.Size = new System.Drawing.Size(192, 23);
            this.input_productName.TabIndex = 5;
            this.input_productName.TextChanged += new System.EventHandler(this.input_productName_TextChanged);
            // 
            // button_annuler
            // 
            this.button_annuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.button_annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_annuler.ForeColor = System.Drawing.Color.White;
            this.button_annuler.Location = new System.Drawing.Point(219, 203);
            this.button_annuler.Name = "button_annuler";
            this.button_annuler.Size = new System.Drawing.Size(102, 45);
            this.button_annuler.TabIndex = 4;
            this.button_annuler.Text = "Annuler";
            this.button_annuler.UseVisualStyleBackColor = false;
            this.button_annuler.Click += new System.EventHandler(this.button_annuler_Click);
            // 
            // button_enregistrer
            // 
            this.button_enregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.button_enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_enregistrer.ForeColor = System.Drawing.Color.White;
            this.button_enregistrer.Location = new System.Drawing.Point(102, 203);
            this.button_enregistrer.Name = "button_enregistrer";
            this.button_enregistrer.Size = new System.Drawing.Size(101, 45);
            this.button_enregistrer.TabIndex = 3;
            this.button_enregistrer.Text = "Enregistrer";
            this.button_enregistrer.UseVisualStyleBackColor = false;
            this.button_enregistrer.Click += new System.EventHandler(this.button_enregistrer_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 533);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddProductForm";
            this.Text = "AddProductForm";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button button_annuler;
        private Button button_enregistrer;
        private Label label4;
        private Label label2;
        private TextBox input_productPrice;
        private TextBox input_productName;
    }
}