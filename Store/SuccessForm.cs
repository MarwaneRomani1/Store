using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class SuccessForm : Form
    {
        public SuccessForm(String operation)
        {
            InitializeComponent();
            button_inserted.Text = operation;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
