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
    public partial class HomePage : Form
    {
        private string CODICE = "";
        private string NOME = "";
        private string TELEFONO = "";
        private string NOTE = "";

        public HomePage()
        {
            InitializeComponent();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int rows = 0; rows < dataGridView1.Rows.Count; rows++)
            {
                for (int col = 0; col < dataGridView1.Rows[rows].Cells.Count; col++)
                {
                    if (dataGridView1.Rows[rows].Cells[col].Value != null)
                    {
                        switch (col)
                        {
                            case 0://codice
                                {
                                    CODICE = dataGridView1.Rows[rows].Cells[col].Value.ToString();
                                }
                                break;
                            case 1://nome
                                {
                                    NOME = dataGridView1.Rows[rows].Cells[col].Value.ToString();
                                }
                                break;
                            case 2://telefono
                                {
                                    TELEFONO = dataGridView1.Rows[rows].Cells[col].Value.ToString();
                                }
                                break;
                            case 3://note
                                {
                                    NOTE = dataGridView1.Rows[rows].Cells[col].Value.ToString();
                                }
                                break;

                            default: break;
                        }
                    }


                }
            }

            hidingForm(CODICE,NOME,TELEFONO,NOTE);

        }

        private void hidingForm(string codice = "", string nome = "", string telefono = "", string note = "")
        {
            Form1 form1 = new Form1(codice, nome, telefono, note);
            this.Hide();
            form1.Show();
        }
    }
}
