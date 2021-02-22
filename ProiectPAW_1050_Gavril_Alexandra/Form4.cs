using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW_1050_Gavril_Alexandra
{
    public partial class Form4 : Form
    {
        Cititori cititor;
        public Button GetButton
        {
            get { return button2; }
        }

        public Button GetBDButton
        {
            get { return button1; }
        }

        public Form4(Cititori cititor = null)
        {
            InitializeComponent();

            this.cititor = cititor;

            if (cititor == null)
            {
                Text = "Adăugare cititor";
            }
            else
            {
                Text = "Modificare cititor";
                textBox1.Text = cititor.Nume;
                textBox2.Text = cititor.Telefon;
                textBox3.Text = cititor.Email;
                textBox4.Text = cititor.DataImprumut;
                textBox5.Text = cititor.DataRetunare;
                textBox6.Text = cititor.IdCarte.ToString();
            }
        }

        public Cititori Cititor { get { return cititor; } }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (cititor == null)
            {
                // Adăugare
                cititor = new Cititori(
                    textBox1.Text, textBox2.Text, textBox3.Text,
                    textBox4.Text, textBox5.Text, int.Parse(textBox6.Text));
            }
            else
            {
                // Modificare
                cititor.Nume = textBox1.Text;
                cititor.Telefon = textBox2.Text;
                cititor.Email = textBox3.Text;
                cititor.DataImprumut = textBox4.Text;
                cititor.DataRetunare = textBox5.Text;
                cititor.IdCarte = int.Parse(textBox6.Text);
            }

            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connection = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = cititoriBD.accdb";
            OleDbConnection conex = new OleDbConnection(connection);

            try
            {
                conex.Open();
                OleDbCommand com = new OleDbCommand();
                com.Connection = conex;
                com.CommandText = "SELECT MAX(ID) FROM Cititori";
                int id = Convert.ToInt32(com.ExecuteScalar());
                DateTime dataImpr = DateTime.ParseExact(textBox4.Text,"dd/MM/yyyy",CultureInfo.InvariantCulture);
                DateTime dataRet = DateTime.ParseExact(textBox5.Text,"dd/MM/yyyy", CultureInfo.InvariantCulture);

                com.CommandText = "INSERT INTO Cititori VALUES(?,?,?,?,?,?,?)";
                com.Parameters.Add("ID", OleDbType.Integer).Value = id + 1;
                com.Parameters.Add("Nume", OleDbType.Char).Value = textBox1.Text;
                com.Parameters.Add("Telefon", OleDbType.Char).Value = textBox2.Text;
                com.Parameters.Add("Email", OleDbType.Char).Value = textBox3.Text;
                com.Parameters.Add("Data_Imprumut", OleDbType.Date).Value = dataImpr;
                com.Parameters.Add("Data_Returnare", OleDbType.Date).Value = dataRet;
                com.Parameters.Add("IDCarte", OleDbType.Integer).Value = textBox6.Text;
                com.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conex.Close();
            }

            if (cititor == null)
            {
                // Adăugare
                cititor = new Cititori(
                    textBox1.Text, textBox2.Text, textBox3.Text,
                    textBox4.Text, textBox5.Text, int.Parse(textBox6.Text));
            }
            else
            {
                // Modificare
                cititor.Nume = textBox1.Text;
                cititor.Telefon = textBox2.Text;
                cititor.Email = textBox3.Text;
                cititor.DataImprumut = textBox4.Text;
                cititor.DataRetunare = textBox5.Text;
                cititor.IdCarte = int.Parse(textBox6.Text);
            }

            DialogResult = DialogResult.OK;
        }
    }
}
