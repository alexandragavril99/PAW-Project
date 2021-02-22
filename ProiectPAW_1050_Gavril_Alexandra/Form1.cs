using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW_1050_Gavril_Alexandra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel2.Visible = false;
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            home1.Visible = true;
            register1.Visible = false;
            panel2.Visible = false;
            time1.Visible = true;
        }

        private void registerBttn_Click(object sender, EventArgs e)
        {
            home1.Visible = false;
            register1.Visible = true;
            panel2.Visible = false;
            time1.Visible = false;
        }

        private void loginBttn_Click(object sender, EventArgs e)
        {
            home1.Visible = false;
            register1.Visible = false;
            panel2.Visible =true;
            time1.Visible = false;
            
            
        }

        private void logBttn_Click_1(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory() + @"\users.txt";
            string[] userInfo = File.ReadAllLines(path);
            if (userInfo[0] == tbUser.Text && userInfo[1] == tbParola.Text && tbUser.Text != "" && tbParola.Text != "")
            {
                MessageBox.Show("Bun venit, " + userInfo[0] + "!");
                Form2 frm2 = new Form2();
            //    this.Hide();

                frm2.ShowDialog();
                frm2.Focus();
                
            }

            else MessageBox.Show("Utilizator sau parola gresita!");
        }

        private void tbParola_TextChanged(object sender, EventArgs e)
        {
            tbParola.UseSystemPasswordChar = true;
        }

        private void tbParola_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                logBttn_Click_1(sender, e);
            }
        }

        private void tbParola_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
