using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    //Gestiune vanzari: Produse, Clienti, Tranzactii
    [Serializable]
    public class Produs
    {
        int idProdus;
        string denumire;
        float pret;
        int stoc;

        public Produs(int idProdus, string denumire, float pret, int stoc) 
        {
            this.idProdus = idProdus;
            this.denumire = denumire;
            this.pret = pret;
            this.stoc = stoc;
        }

        public int IdProdus
        {
            get { return idProdus; }
            set { idProdus = value; }
        }

        public string Denumire
        {
            get { return denumire; }
            set { denumire = value; }
        }

        public float Pret
        {
            get { return pret; }
            set { pret = value; }
        }

        public int Stoc
        {
            get { return stoc; }
            set { stoc = value; }
        }
    }

    [Serializable]
    public class Clienti 
    {
        int idClient;
        string nume;
        string email;
        string telefon;

        public Clienti(int idClient, string nume, string email, string telefon) 
        {
            this.idClient = idClient;
            this.nume = nume;
            this.email = email;
            this.telefon = telefon;
        }

        public int IdClient
        {
            get { return idClient; }
            set { idClient = value; }
        }

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Telefon
        {
            get { return telefon; }
            set { telefon = value; }
        }
    }

    [Serializable]
    public class Tranzactii
    {
        int idTranzactie;
        int produsId;
        int clientId;
        int cantitate;

        public Tranzactii(int idTranzactie, int produsId, int clientId, int cantitate) 
        {
            this.idTranzactie = idTranzactie;  
            this.produsId = produsId;
            this.clientId = clientId;
            this.cantitate = cantitate;
        }

        public int IdTranzactie
        {
            get { return idTranzactie; }
            set { idTranzactie = value; }
        }

        public int ProdusId
        {
            get { return produsId; }
            set { produsId = value; }
        }

        public int ClientId
        {
            get { return clientId; }
            set { clientId = value; }
        }

        public int Cantitate
        {
            get { return cantitate; }
            set { cantitate = value; }
        }
    }
}
