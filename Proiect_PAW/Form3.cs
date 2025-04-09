using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class Form3 : Form
    {
        private List<Produs> produse;
        private Form1 mainForm;

        public Form3(List<Produs> produse, Form1 mainForm)
        {
            InitializeComponent();
            this.produse = produse;
            this.mainForm = mainForm;
            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (Produs prod in produse)
            {
                dataGridView1.Rows.Add(
                    prod.IdProdus.ToString(),
                    prod.Denumire,
                    prod.Pret.ToString(),
                    prod.Stoc.ToString()
                );
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {   if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                if(index >= 0 && index < dataGridView1.Rows.Count)
                {
                    dataGridView1.Rows.RemoveAt(index);
                    produse.RemoveAt(index);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                Produs p = produse[index];
                Form2 dialog = new Form2();
                if (DialogResult.OK == dialog.ShowDialog())
                {
                    int idProdus = int.Parse(dialog.textBox1.Text);
                    string denumire = dialog.textBox2.Text;
                    float pret = float.Parse(dialog.textBox3.Text);
                    int stoc = int.Parse(dialog.textBox4.Text);

                    p.IdProdus = idProdus;
                    p.Denumire = denumire;
                    p.Pret = pret;
                    p.Stoc = stoc;

                    dataGridView1.Rows[index].Cells["Column1"].Value = idProdus;
                    dataGridView1.Rows[index].Cells["Column2"].Value = denumire;
                    dataGridView1.Rows[index].Cells["Column3"].Value = pret;
                    dataGridView1.Rows[index].Cells["Column4"].Value = stoc;
                }
            }
        }
    }
}
