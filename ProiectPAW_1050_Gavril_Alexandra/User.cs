using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW_1050_Gavril_Alexandra
{
    class User
    {
        private int id=0;
        private string nume;
        private string prenume;
        private string email;
        private string telefon;
        private string username;
        private string parola;

        public User(string nume, string prenume, string email, string telefon, string username, string parola)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.email = email;
            this.telefon = telefon;
            this.username = username;
            this.parola = parola;
        }
        
        public string Nume
        {
            get { return nume; }
            set { if (value != null) nume = value; }
        }

        public string Prenume
        {
            get { return prenume; }
            set { if (value != null) prenume = value; }
        }
        public string Email
        {
            get { return email; }
            set { if (value != null) email = value; }
        }

        public string Telefon
        {
            get { return telefon; }
            set { if (value != null) telefon = value; }
        }

        public string Username
        {
            get { return username; }
            set { if (value != null) username = value; }
        }

        public string Parola
        {
            get { return parola; }
            set { if (value != null) parola = value; }
        }

        public override string ToString()
        {
            return "nume: " + nume + "\nprenume: " + prenume + "\nemail: " + email 
                + "\ntelefon: " + telefon + "\nusername: " + username + "\nparola: " + parola;
          
        }
    }
}
