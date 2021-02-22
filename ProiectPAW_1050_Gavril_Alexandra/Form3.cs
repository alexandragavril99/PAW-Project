using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW_1050_Gavril_Alexandra
{
    public partial class Form3 : Form
    {
        Carte carte;
        public Form3(Carte carte = null)
        {
            InitializeComponent();


            this.carte = carte;

            if (carte == null)
            {
                Text = "Adăugare carte";
            }
            else
            {
                Text = "Modificare carte";
                textBox1.Text = carte.NumeCarte;
                textBox2.Text = carte.Autor;
                textBox3.Text = carte.Editura;
                textBox4.Text = carte.NrPagini.ToString();
                textBox5.Text = carte.AnFabricatie.ToString();
                textBox6.Text = carte.Status;
            }
        }

        public Carte Carte { get { return carte; } }



        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == ""
                    || textBox5.Text == "")
            {
                errorProvider1.SetError(button1, "Unul sau mai multe campuri goale!");
            }
            else
            {
                if (carte == null)
                {
                    // Adăugare
                    carte = new Carte(
                        textBox1.Text, textBox2.Text, textBox3.Text,
                        int.Parse(textBox4.Text),
                        int.Parse(textBox5.Text),
                        textBox6.Text);
                }
                else
                {
                    // Modificare
                    carte.NumeCarte = textBox1.Text;
                    carte.Autor = textBox2.Text;
                    carte.Editura = textBox3.Text;
                    carte.NrPagini = int.Parse(textBox4.Text);
                    carte.AnFabricatie = int.Parse(textBox5.Text);
                    carte.Status = textBox6.Text;

                }

                DialogResult = DialogResult.OK;
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Campul este gol");
                textBox1.Focus();
            }
            else errorProvider1.SetError(textBox1,"");
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text == "")
            {
                errorProvider1.SetError(textBox2, "Campul este gol");
                textBox2.Focus();
            }
            else errorProvider1.SetError(textBox2, "");
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (textBox3.Text == "")
            {
                errorProvider1.SetError(textBox3, "Campul este gol");
                textBox3.Focus();
            }
            else errorProvider1.SetError(textBox3, "");
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (textBox4.Text == "")
            {
                errorProvider1.SetError(textBox4, "Campul este gol");
                textBox4.Focus();
            }
            else errorProvider1.SetError(textBox4, "");
        }

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            if (textBox5.Text == "")
            {
                errorProvider1.SetError(textBox5, "Campul este gol");
                textBox5.Focus();
            }
            else errorProvider1.SetError(textBox5, "");
        }

        private void textBox6_Validating(object sender, CancelEventArgs e)
        {
            if (textBox6.Text == "")
            {
                errorProvider1.SetError(textBox6, "Campul este gol");
                textBox6.Focus();
            }
            else errorProvider1.SetError(textBox6, "");
        }
    }
}
