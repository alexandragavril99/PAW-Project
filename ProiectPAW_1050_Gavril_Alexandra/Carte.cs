using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW_1050_Gavril_Alexandra
{
    public class Carte
    {
        private int id=0;
        private static int contor=0;
        private string numeCarte;
        private string autor;
        private string editura;
        private int nrPagini;
        private int anFabricatie;
        private string status;

        public Carte(string numeCarte, string autor, string editura, int nrPagini, int anFabricatie, string status)
        {
            this.numeCarte = numeCarte;
            this.autor = autor;
            this.editura = editura;
            this.nrPagini = nrPagini;
            this.anFabricatie = anFabricatie;
            this.status = status;
            id = ++contor;
        }
        public int ID
        {
            get { return id; }
        }
        public string NumeCarte
        {
            get { return numeCarte; }
            set { if (value != null) numeCarte = value; }
        }

        public string Autor
        {
            get { return autor; }
            set { if (value != null) autor = value; }
        }
        public string Editura
        {
            get { return editura; }
            set { if (value != null) editura = value; }
        }
        public int NrPagini
        {
            get { return nrPagini; }
            set { if (value != null) nrPagini = value; }
        }

        public int AnFabricatie
        {
            get { return anFabricatie; }
            set { if (value != null) anFabricatie = value; }
        }

        public string Status
        {
            get { return status; }
            set { if (value != null) status = value; }
        }

        public override string ToString()
        {
            return numeCarte + "\n" + autor + "\n" + editura + "\n"
                + nrPagini + "\n" + anFabricatie + "\n" + status;
    
        }
    }
}
