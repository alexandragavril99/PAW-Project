using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW_1050_Gavril_Alexandra
{
    public class Cititori
    {
        private int id;
        private string nume;
        private string telefon;
        private string email;
        private int idCarte;
        private string dataImprumut;
        private string dataReturnare;
        private static int contor = 0;

        public Cititori(string nume, string telefon, string email,string dataImprumut, string dataReturnare, int idCarte)
        {
            this.nume = nume;
            this.telefon = telefon;
            this.email = email;
            this.idCarte = idCarte;
            this.dataImprumut = dataImprumut;
            this.dataReturnare = dataReturnare;
            this.id = ++contor;
        }

        public int ID
        {
            get { return id; }
            set { if (value != null) id = value; }
        }

        public string Nume
        {
            get { return nume; }
            set { if (value != null) nume = value; }
        }
        public string Telefon
        {
            get { return telefon; }
            set { if (value != null) telefon = value; }
        }

        public string Email
        {
            get { return email; }
            set { if (value != null) email = value; }
        }

        public int IdCarte
        {
            get { return idCarte; }
            set { if (value != null) idCarte = value; }
        }

        public string DataImprumut
        {
            get { return dataImprumut; }
            set { if (value != null) dataImprumut = value; }
        }

        public string DataRetunare
        {
            get { return dataReturnare; }
            set { if (value != null) dataReturnare = value; }
        }

        public override string ToString()
        {
            return "nume: " + nume + "\ntelefon: " + telefon + "\nemail" + email + "\nid carte:"
                + idCarte + "\nData imprumut: " + dataImprumut + "\nData returnare: " + dataReturnare;
        }
    }
}
