using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rubrica
{
    public partial class DialogWindow : Form
    {
        public DialogWindow(string conferma = "")
        {
            InitializeComponent();
            confermaLabel.Text = conferma;
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void siButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
