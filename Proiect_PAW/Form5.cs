using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Proiect_PAW
{
    public partial class Form5 : Form
    {
        private List<Clienti> clients;
        private Form1 mainform;

        public Form5(List<Clienti> clients, Form1 mainform)
        {
            InitializeComponent();
            this.clients = clients;
            this.mainform = mainform;
            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (Clienti client in clients)
            {
                dataGridView1.Rows.Add(
                    client.IdClient.ToString(),
                    client.Nume,
                    client.Email,
                    client.Telefon
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
                    clients.RemoveAt(index);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                Clienti c = clients[index];
                Form4 dialog = new Form4();
                if (DialogResult.OK == dialog.ShowDialog())
                {
                    int idClient = int.Parse(dialog.textBox1.Text);
                    string nume = dialog.textBox2.Text;
                    string email = dialog.textBox3.Text;
                    string telefon = dialog.textBox4.Text;

                    c.IdClient = idClient;
                    c.Nume = nume;
                    c.Email = email;
                    c.Telefon = telefon;

                    dataGridView1.Rows[index].Cells["Column1"].Value = idClient;
                    dataGridView1.Rows[index].Cells["Column2"].Value = nume;
                    dataGridView1.Rows[index].Cells["Column3"].Value = email;
                    dataGridView1.Rows[index].Cells["Column4"].Value = telefon;
                }
            }
        }
    }
}
