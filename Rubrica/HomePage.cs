﻿using System;
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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();

            //leggi documento

            for(int i = 0; i <100; i++)
            {
                rubricaDataGridView.Rows.Add(i+" Codice","Nome","Telefono");
            }

        }

        private void hidingForm(string codice = "", string nome = "", string telefono = "", string note = "")
        {
            Form1 form1 = new Form1(codice, nome, telefono, note);
            this.Hide();
            form1.Show();
        }

        private void HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void rubricaDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string CODICE = "";
            string NOME = "";
            string TELEFONO = "";
            string NOTE = "";

            int row = e.RowIndex;

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

            hidingForm(CODICE, NOME, TELEFONO, NOTE);
        }
    }
}