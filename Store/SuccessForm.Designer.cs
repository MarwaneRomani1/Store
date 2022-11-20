namespace Store
{
    partial class SuccessForm
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
            this.button_inserted = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_inserted
            // 
            this.button_inserted.Location = new System.Drawing.Point(112, 63);
            this.button_inserted.Name = "button_inserted";
            this.button_inserted.Size = new System.Drawing.Size(75, 23);
            this.button_inserted.TabIndex = 0;
            this.button_inserted.Text = "inserted";
            this.button_inserted.UseVisualStyleBackColor = true;
            this.button_inserted.Click += new System.EventHandler(this.button1_Click);
            // 
            // success
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 175);
            this.Controls.Add(this.button_inserted);
            this.Name = "success";
            this.Text = "success";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button_inserted;
    }
}