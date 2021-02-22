using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace ProiectPAW_1050_Gavril_Alexandra
{
    public partial class Register : UserControl
    {
        public Register()
        {
            InitializeComponent();
        }

        private void regBttn_Click(object sender, EventArgs e)
        {
            string nume = tbNume.Text;
            string prenume = tbPrenume.Text;
            string email = tbEmail.Text;
            string telefon = tbTelefon.Text;
            string username = tbUsername.Text;
            string parola = tbParola.Text;

            if (tbNume.Text == "" || tbPrenume.Text == "" || tbEmail.Text == "" || tbTelefon.Text == "" || tbUsername.Text == ""
                || tbParola.Text == "")
            {
                error.SetError(regBttn, "Exista campuri necompletate!");
            }
            else
            {
                error.SetError(regBttn, "");

                User u = new User(nume, prenume, email, telefon, username, parola);

                MessageBox.Show(u.ToString());

                TextWriter tw = new StreamWriter("fisier.txt");
                tw.Write(u);
                tw.Close();

                tw = new StreamWriter("users.txt");
                tw.WriteLine(u.Username);
                tw.WriteLine(u.Parola);
                tw.Close();
            }
        }
        

        private void tbNume_Validating(object sender, CancelEventArgs e)
        {
            if (tbNume.Text == "")
            {
                error.SetError(tbNume, "Campul este gol!");
                tbNume.Focus();
            }
            else if (!Regex.IsMatch(tbNume.Text, "([A-ZAÎ??Â])+(?=.{1,40}$)[a-zA-ZAÎ??Âaî??]+(?:[-\\s][a-zA-ZAÎ??Âaî??â]+)*$"))
            {
                error.SetError(tbNume, "Nume invalid! Nu contine cifre si trebuie sa inceapa cu majuscula.");
                tbNume.Focus();
            }
            else error.SetError(tbNume, "");
        }

        private void tbPrenume_Validating(object sender, CancelEventArgs e)
        {
            if (tbPrenume.Text == "")
            {
                error.SetError(tbPrenume, "Campul este gol!");
                tbPrenume.Focus();
            }
            else if (!Regex.IsMatch(tbPrenume.Text, "([A-ZAÎ??Â])+(?=.{1,40}$)[a-zA-ZAÎ??Âaî??]+(?:[-\\s][a-zA-ZAÎ??Âaî??â]+)*$"))
            {
                error.SetError(tbPrenume, "Prenume invalid! Nu contine cifre si trebuie sa inceapa cu majuscula.");
                tbPrenume.Focus();
            }
            else error.SetError(tbPrenume, "");
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (tbEmail.Text == "")
            {
                error.SetError(tbEmail, "Campul este gol!");
                tbEmail.Focus();
            }
            else if (!Regex.IsMatch(tbEmail.Text, @"[a-zA-Z0-9_\.-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9\.]{2,5}$"))
            {
                error.SetError(tbEmail, "Email invalid!");
                tbEmail.Focus();
            }
            else error.SetError(tbEmail, "");
        }

        private void tbTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (tbTelefon.Text == "")
            {
                error.SetError(tbTelefon, "Campul este gol!");
                tbTelefon.Focus();
            }
            else if (!Regex.IsMatch(tbTelefon.Text, @"^(\+4|)?(07[0-8]{1}[0-9]{1}|02[0-9]{2}|03[0-9]{2}){1}?(\s|\.|\-)?([0-9]{3}(\s|\.|\-|)){2}$"))
            {
                error.SetError(tbTelefon, "Telefon invalid!");
                tbTelefon.Focus();
            }
            else error.SetError(tbTelefon, "");
        }

        private void tbUsername_Validating(object sender, CancelEventArgs e)
        {
            if (tbUsername.Text == "")
            {
                error.SetError(tbUsername, "Campul este gol!");
                tbUsername.Focus();
            }
            else error.SetError(tbUsername, "");
        }

        private void tbParola_Validating(object sender, CancelEventArgs e)
        {
            if (tbParola.Text == "")
            {
                error.SetError(tbParola, "Campul este gol!");
                tbParola.Focus();
            }
            else error.SetError(tbParola, "");
        }

        private void tbParola_TextChanged(object sender, EventArgs e)
        {
            tbParola.UseSystemPasswordChar = true;
        }

        private void tbParola_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode.ToString() == "R")
            {
                regBttn_Click(sender, e);
            }
        }
    }
}
