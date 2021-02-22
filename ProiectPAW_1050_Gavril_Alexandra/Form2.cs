using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProiectPAW_1050_Gavril_Alexandra
{
    public partial class Form2 : Form
    {
        //List<Carti> carti;
        public Form2()
        {
            InitializeComponent();

            listaCarti1.Visible = false;
            listaCititori1.Visible = false;
            //Carti[] carti = new Carti[10];
            //carti[0] = new Carti("Crima si pedeapsa", "F. Dostoievsky", "Polirom", 800, 2007);
            //carti[1] = new Carti("Crima si pedeapsa", "F. Dostoievsky", "Polirom", 800, 2007);
            //carti[2] = new Carti("Crima si pedeapsa", "F. Dostoievsky", "Polirom", 800, 2007);
            //carti[3] = new Carti("Crima si pedeapsa", "F. Dostoievsky", "Polirom", 800, 2007);
            //carti[4] = new Carti("Crima si pedeapsa", "F. Dostoievsky", "Polirom", 800, 2007);
            //carti[5] = new Carti("Crima si pedeapsa", "F. Dostoievsky", "Polirom", 800, 2007);
            //carti[6] = new Carti("Crima si pedeapsa", "F. Dostoievsky", "Polirom", 800, 2007);
            //carti[7] = new Carti("Crima si pedeapsa", "F. Dostoievsky", "Polirom", 800, 2007);
            //carti[8] = new Carti("Crima si pedeapsa", "F. Dostoievsky", "Polirom", 800, 2007);
            //carti[9] = new Carti("Crima si pedeapsa", "F. Dostoievsky", "Polirom", 800, 2007);

            //TextWriter sw = new StreamWriter("carti.txt");
            //for (int i = 0; i < 10; i++)
            //{
            //    sw.WriteLine(carti[i] + "\n");
            //}
            //sw.Close();
           
        }

        private void cartiBttn_Click(object sender, EventArgs e)
        {
            listaCarti1.Visible = true;
            listaCititori1.Visible = false;
        }

        private void abonatiBttn_Click(object sender, EventArgs e)
        {
            listaCarti1.Visible = false;
            listaCititori1.Visible = true;
        }

        private void logoutBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
