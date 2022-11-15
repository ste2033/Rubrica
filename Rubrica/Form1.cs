using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
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

        /// <summary>
        /// Salva sul file le variabili
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void confermaButton_Click(object sender, EventArgs e)
        {

            string curFile = Directory.GetCurrentDirectory() + "/rubrica.txt";

            List<string> stringa = new List<string>
            {
                codiceTextBox.Text + " | " +
                nomeTextBox.Text + " | " +
                telefonoTextBox.Text + " | " +
                noteTextBox.Text +
                Environment.NewLine
            };


            System.IO.File.AppendAllLines(curFile, stringa);

            hidingForm();
            return;
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
                //rimuovi dal file
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
