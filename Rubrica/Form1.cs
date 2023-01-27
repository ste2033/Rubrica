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

            if(note != "")
            {
                noteTextBox.Text = note;
                noteTextBox.Text = noteTextBox.Text.Replace("§",System.Environment.NewLine); //add a line terminating ;
            }

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
            if (codiceTextBox.Text == "" && nomeTextBox.Text == "" && telefonoTextBox.Text == "" && noteTextBox.Text == "")
            {
                MessageBox.Show(
                "NESSUN DATO INSERITO",
                "ATTENZIONE!",
                MessageBoxButtons.OK);

                return;
            }

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
                            noteTextBox.Text = noteTextBox.Text.Replace(System.Environment.NewLine, "§"); //add a line terminating ;

                            string stringa =
                                codiceTextBox.Text + "|" +
                                nomeTextBox.Text + "|" +
                                telefonoTextBox.Text + "|" +
                                noteTextBox.Text;

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
                noteTextBox.Text = noteTextBox.Text.Replace(System.Environment.NewLine, "§"); //add a line terminating ;

                string value = codiceTextBox.Text + "|" +
                nomeTextBox.Text + "|" +
                telefonoTextBox.Text + "|" +
                noteTextBox.Text;

                List<string> stringa = new List<string> { value };

                System.IO.File.AppendAllLines(RUBRICAPATH, stringa);

            }

            hidingForm();
            return;
        }

        private void annullaButton_Click(object sender, EventArgs e)
        {
            hidingForm();
            return;
        }

        private void eliminaButton_Click(object sender, EventArgs e)
        {
            if (DAMODIFICARE)
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
            else
            {
                annullaButton_Click(sender, e);
            }
        }

        private void hidingForm()
        {
            Form1_FormClosing(null, null);
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Dispose();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            hidingForm();
        }

        private void noteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "|" || e.KeyChar.ToString() == "§") 
            {
                e.Handled = true;
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((ModifierKeys & Keys.Shift) == 0)
            {
                Point location = Location;
                Size size = Size;
                if (WindowState != FormWindowState.Normal)
                {
                    location = RestoreBounds.Location;
                    size = RestoreBounds.Size;
                }
                string initLocation = string.Join(",", location.X, location.Y, size.Width, size.Height);
                Properties.Settings.Default.LocationForm = initLocation;
                Properties.Settings.Default.Save();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if ((ModifierKeys & Keys.Shift) == 0)
            {
                string initLocation = Properties.Settings.Default.LocationForm;
                Point il = new Point(0, 0);
                Size sz = Size;
                if (!string.IsNullOrWhiteSpace(initLocation))
                {
                    string[] parts = initLocation.Split(',');
                    if (parts.Length >= 2)
                    {
                        il = new Point(int.Parse(parts[0]), int.Parse(parts[1]));
                    }
                    if (parts.Length >= 4)
                    {
                        sz = new Size(int.Parse(parts[2]), int.Parse(parts[3]));
                    }
                }
                Size = sz;
                Location = il;
            }

        }
    }
}
