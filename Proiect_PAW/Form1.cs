using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class Form1 : Form
    {
        //Gestiune vanzari: Produse, Clienti, Tranzactii
        //Form1 - meniu 
        //Form2 - adauga produs
        //Form3 - vizualizeaza produse
        //Form4 - adauga client
        //Form5 - vizualizeaza clienti
        //Form6 - adauga tranzactie si face validarea pentru idprodus, idclient, cantitate(daca nu e valid nu adauga in lista)
        //Form7 - vizualizeaza tranzactii
        //Pentru a incarca informatiile in liste apasam pe butonul deserializare
        List<Produs> produse = new List<Produs>();
        List<Clienti> clients = new List<Clienti>();
        List<Tranzactii> tranz = new List<Tranzactii>();

        public Form1()
        {
            InitializeComponent();
        }

        private void ieșireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void produsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 dialog = new Form2();
            if(DialogResult.OK == dialog.ShowDialog()) 
            {
                int idProdus = int.Parse(dialog.textBox1.Text);
                string denumire = dialog.textBox2.Text;
                float pret = float.Parse(dialog.textBox3.Text);
                int stoc = int.Parse(dialog.textBox4.Text);

                Produs p = new Produs(idProdus, denumire, pret, stoc);
                produse.Add(p);
            }
        }

        private void produseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 dialog3 = new Form3(produse, this);
            dialog3.Show();
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 dialog4 = new Form4();
            if(DialogResult.OK == dialog4.ShowDialog())
            {
                int idClient = int.Parse(dialog4.textBox1.Text);
                string nume = dialog4.textBox2.Text;
                string email = dialog4.textBox3.Text;
                string telefon = dialog4.textBox4.Text;

                Clienti client = new Clienti(idClient, nume, email, telefon);
                clients.Add(client);
            }
        }

        private void cliențiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 dialog5 = new Form5(clients,this);
            dialog5.Show();
        }

        private void tranzactieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 dialog6 = new Form6();
            if(dialog6.ShowDialog() == DialogResult.OK) 
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
                foreach(Clienti c in clients)
                {
                    if(c.IdClient == idClient) 
                    {
                        okClient = 1;
                        break;
                    }
                }
                if (okClient != 1)
                    MessageBox.Show("Id-ul introdus nu exista in lista de clienti!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                int cant = int.Parse(dialog6.textBox4.Text);
                int okCant = 0;
                foreach(Produs p in produse)
                {
                    if(p.IdProdus == idProd)
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
                    Tranzactii t = new Tranzactii(idTranz, idProd, idClient, cant);
                    tranz.Add(t);
                }
            }
        }

        private void tranzacțiiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 dialog7 = new Form7(tranz,produse,clients, this);
            dialog7.Show();
        }

        private void serializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream ps = new FileStream("Produse.dat", FileMode.Create);
            FileStream cs = new FileStream("Clienti.dat", FileMode.Create);
            FileStream tz = new FileStream("Tranzactii.dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ps, produse);
            ps.Close();
            bf.Serialize(cs, clients);
            cs.Close();
            bf.Serialize(tz, tranz);
            tz.Close();
        }

        private void deserializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FileStream ps = new FileStream("Produse.dat", FileMode.Open))
            {
                BinaryFormatter bf = new BinaryFormatter();
                produse = (List<Produs>)bf.Deserialize(ps);
            }

            using (FileStream cs = new FileStream("Clienti.dat", FileMode.Open))
            {
                BinaryFormatter bf = new BinaryFormatter();
                clients = (List<Clienti>)bf.Deserialize(cs);
            }

            using (FileStream tz = new FileStream("Tranzactii.dat", FileMode.Open))
            {
                BinaryFormatter bf = new BinaryFormatter();
                tranz = (List<Tranzactii>)bf.Deserialize(tz);
            }
        }
    }
}
