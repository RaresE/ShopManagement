using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class Form7 : Form
    {
        private List<Tranzactii> tranz;
        private List<Produs> produse;
        private List<Clienti> clients;
        private Form1 mainform;
        public Form7(List<Tranzactii> tranz, List<Produs> produse, List<Clienti> clients, Form1 mainform)
        {
            InitializeComponent();
            this.tranz = tranz;
            this.produse = produse;
            this.clients = clients;
            this.mainform = mainform;
            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (Tranzactii tr in tranz)
            {
                dataGridView1.Rows.Add(
                    tr.IdTranzactie.ToString(),
                    tr.ProdusId.ToString(),
                    tr.ClientId.ToString(),
                    tr.Cantitate.ToString()
                );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                if (index >= 0 && index < dataGridView1.Rows.Count)
                {
                    dataGridView1.Rows.RemoveAt(index);
                    tranz.RemoveAt(index);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                Tranzactii t = tranz[index];
                Form6 dialog6 = new Form6();
                if (dialog6.ShowDialog() == DialogResult.OK)
                {
                    int idTranz = int.Parse(dialog6.textBox1.Text);
                    int idProd = int.Parse(dialog6.textBox2.Text);
                    int okProd = 0;
                    foreach (Produs p in produse)
                    {
                        if (idProd == p.IdProdus)
                        {
                            okProd = 1;
                            break;
                        }
                    }
                    if (okProd != 1)
                        MessageBox.Show("Id-ul introdus nu exista in lista de produse!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    int idClient = int.Parse(dialog6.textBox3.Text);
                    int okClient = 0;
                    foreach (Clienti c in clients)
                    {
                        if (c.IdClient == idClient)
                        {
                            okClient = 1;
                            break;
                        }
                    }
                    if (okClient != 1)
                        MessageBox.Show("Id-ul introdus nu exista in lista de clienti!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    int cant = int.Parse(dialog6.textBox4.Text);
                    int okCant = 0;
                    foreach (Produs p in produse)
                    {
                        if (p.IdProdus == idProd)
                        {
                            if (p.Stoc >= cant)
                            {
                                p.Stoc = p.Stoc - cant;
                                okCant = 1;
                            }
                            else
                                MessageBox.Show("Cantiatea introdusa este mai mare decat cantitatea din stoc", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }

                    if (okClient == 1 && okProd == 1 && okCant == 1)
                    {
                        t.IdTranzactie = idTranz;
                        t.ProdusId = idProd;
                        t.ClientId = idClient;
                        t.Cantitate = cant;

                        dataGridView1.Rows[index].Cells["Column1"].Value = idTranz;
                        dataGridView1.Rows[index].Cells["Column2"].Value = idProd;
                        dataGridView1.Rows[index].Cells["Column3"].Value = idClient;
                        dataGridView1.Rows[index].Cells["Column4"].Value = cant;
                    }
                }
            }
        }
    }
}
