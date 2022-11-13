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
    public partial class Form1 : Form
    {
        public Form1(string codice = "", string nome = "", string telefono = "", string note = "")
        {
            InitializeComponent();
            codiceTextBox.Text = codice;
            nomeTextBox.Text = nome;
            telefonoTextBox.Text = telefono;
            noteTextBox.Text = note;
        }

        private void confermaButton_Click(object sender, EventArgs e)
        {
            hidingForm();
        }

        private void annullaButton_Click(object sender, EventArgs e)
        {
            hidingForm();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hidingForm();
        }

        private void hidingForm()
        {
            HomePage homePage = new HomePage();
            this.Hide();
            homePage.Show();

        }
    }
}
