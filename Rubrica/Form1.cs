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
        string RUBRICAPATH = Directory.GetCurrentDirectory() + "/rubrica.txt";
        int INDEX;
        bool DAMODIFICARE;

        public Form1(string codice = "", string nome = "", string telefono = "", string note = "", int index = -1)
        {
            DAMODIFICARE = false;

            InitializeComponent();
            codiceTextBox.Text = codice;
            nomeTextBox.Text = nome;
            telefonoTextBox.Text = telefono;
            noteTextBox.Text = note;
            INDEX = index;

            if (codice != "" || nome != "" || telefono != "" || note != "")
            {
                DAMODIFICARE = true;
            }
        }

        /// <summary>
        /// Salva sul file le variabili
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void confermaButton_Click(object sender, EventArgs e)
        {
            if (DAMODIFICARE)
            {
                string tempFile = Path.GetTempFileName();

                using (var sr = new StreamReader(RUBRICAPATH))
                using (var sw = new StreamWriter(tempFile))
                {
                    string[] lines = System.IO.File.ReadAllLines(RUBRICAPATH);

                    int j = 0;
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split("|");
                        if (j != INDEX)
                        {
                            sw.WriteLine(line);
                        }
                        else
                        {
                            string stringa =
                codiceTextBox.Text + " | " +
                nomeTextBox.Text + " | " +
                telefonoTextBox.Text + " | " +
                noteTextBox.Text
                ;
                            sw.WriteLine(stringa);
                        }

                        j++;
                    }
                }

                File.Delete(RUBRICAPATH);
                File.Move(tempFile, RUBRICAPATH);
            }
            else
            {

                List<string> stringa = new List<string>{
                codiceTextBox.Text + " | " +
                nomeTextBox.Text + " | " +
                telefonoTextBox.Text + " | " +
                noteTextBox.Text
                };

                System.IO.File.AppendAllLines(RUBRICAPATH, stringa);
            }

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

            if (confirmResult == DialogResult.Yes)
            {
                //rimuovi dal file

                string tempFile = Path.GetTempFileName();

                using (var sr = new StreamReader(RUBRICAPATH))
                using (var sw = new StreamWriter(tempFile))
                {
                    string[] lines = System.IO.File.ReadAllLines(RUBRICAPATH);

                    int j = 0;
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split("|");
                        if (j != INDEX)
                        {
                            sw.WriteLine(line);
                        }
                        j++;
                    }
                }

                File.Delete(RUBRICAPATH);
                File.Move(tempFile, RUBRICAPATH);


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
