using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Rubrica
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();

            //leggi file

            string rubricaPath = Directory.GetCurrentDirectory() + "/rubrica.txt";
            try
            {
                string[] lines = System.IO.File.ReadAllLines(rubricaPath);

                int j = 0;
                foreach (string line in lines)
                {
                    string[] parts = line.Split("|");
                    rubricaDataGridView.Rows.Insert(j, parts);
                    j++;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                MessageBox.Show(
                "File \"rubrica.txt\" non trovato\n" +
                "Il file verrà creato",
                "ATTENZIONE!",
                MessageBoxButtons.OK);

                var myFile = System.IO.File.Create(rubricaPath);

                myFile.Close();
            }
            rubricaDataGridView.FirstDisplayedScrollingRowIndex = rubricaDataGridView.RowCount - 1;

        }


        private void hidingForm(string codice = "", string nome = "", string telefono = "", string note = "", int index = 0)
        {
            HomePage_FormClosing(null,null);
            Form1 form1 = new Form1(codice, nome, telefono, note, index);
            form1.Show();
            this.Hide();
        }

        private void HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void rubricaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            string CODICE = "";
            string NOME = "";
            string TELEFONO = "";
            string NOTE = "";

            int row = e.RowIndex;

            if (row == -1)//head
            {
                //ricerca all'interno della testa
                return;
            }
            else
            {
                for (int col = 0; col < rubricaDataGridView.Rows[row].Cells.Count; col++)
                {
                    if (rubricaDataGridView.Rows[row].Cells[col].Value != null)
                    {
                        switch (col)
                        {
                            case 0://codice
                                {
                                    CODICE = rubricaDataGridView.Rows[row].Cells[col].Value.ToString();
                                }
                                break;
                            case 1://nome
                                {
                                    NOME = rubricaDataGridView.Rows[row].Cells[col].Value.ToString();
                                }
                                break;
                            case 2://telefono
                                {
                                    TELEFONO = rubricaDataGridView.Rows[row].Cells[col].Value.ToString();
                                }
                                break;
                            case 3://note
                                {
                                    NOTE = rubricaDataGridView.Rows[row].Cells[col].Value.ToString();
                                }
                                break;

                            default: break;
                        }
                    }
                }

                hidingForm(CODICE, NOME, TELEFONO, NOTE, e.RowIndex);
            }

        }


        private void ricercaTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                for (int i = 0; i < rubricaDataGridView.Rows.Count; i++)
                {
                    if (rubricaDataGridView.Rows[i].Cells[0].Value.ToString().Contains(ricercaTextBox.Text))
                    {
                        rubricaDataGridView.Rows[i].Visible = true;
                    }
                    else if (rubricaDataGridView.Rows[i].Cells[1].Value.ToString().Contains(ricercaTextBox.Text))
                    {
                        rubricaDataGridView.Rows[i].Visible = true;
                    }
                    else if (rubricaDataGridView.Rows[i].Cells[2].Value.ToString().Contains(ricercaTextBox.Text))
                    {
                        rubricaDataGridView.Rows[i].Visible = true;
                    }
                    else
                    {
                        rubricaDataGridView.Rows[i].Visible = false;
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void newData_Click(object sender, EventArgs e)
        {
            hidingForm();
        }

        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
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
                Properties.Settings.Default.Location = initLocation;
                Properties.Settings.Default.Save();
            }
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            if ((ModifierKeys & Keys.Shift) == 0)
            {
                string initLocation = Properties.Settings.Default.Location;
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
