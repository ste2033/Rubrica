using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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

        }

        private void annullaButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                "Annullare le modifiche?",
                "ATTENZIONE!",
                MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                hidingForm();
                return;
            }

        }

        private void eliminaButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                "STAI PER ELIMINARE QUESTO DATO\nProcedere?",
                "ATTENZIONE!",
                MessageBoxButtons.YesNo);

            if(confirmResult == DialogResult.Yes)
            {
                hidingForm();
                return;
            }
        }

        private void hidingForm()
        {
            HomePage homePage = new HomePage();
            this.Hide();
            homePage.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            hidingForm();
        }
    }
}
