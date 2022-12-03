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
                MessageBox.Show(
                "File \"rubrica.txt\" non trovato\n" +
                "Il file verrà creato",
                "ATTENZIONE!",
                MessageBoxButtons.OK);

                System.IO.File.Create(rubricaPath);
            }
        }

        private void hidingForm(string codice = "", string nome = "", string telefono = "", string note = "", int index = 0)
        {
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

    }
}
