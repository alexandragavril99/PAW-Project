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
using System.Data.OleDb;

namespace ProiectPAW_1050_Gavril_Alexandra
{
    public partial class ListaCititori : UserControl
    {
        List<Cititori> cititori;
        public ListaCititori()
        {
            InitializeComponent();

            cititori = new List<Cititori>();
            AfisareCititori();
        }
        
        void AfisareCititori()
        {
            listView1.Items.Clear();

            
            foreach (var cititor in cititori)
            {
                if (cititor.Nume.IndexOf(toolStripTextBox1.Text, StringComparison.OrdinalIgnoreCase) < 0)
                {
                    continue;
                }

                var item = new ListViewItem(new string[] {
                cititor.ID.ToString(), cititor.Nume, cititor.Telefon, cititor.Email,
                cititor.DataImprumut, cititor.DataRetunare, cititor.IdCarte.ToString()});

                item.Tag = cititor;
                item.ForeColor = Color.White;
                listView1.Items.Add(item);
            }

        }

        private void IncarcareDinFisier(string caleFisier)
        {
            try
            {
                cititori.Clear();
                var items = File.ReadAllLines(caleFisier);
                
                for (int i = 0; i < items.Length; i += 6)
                {
                    cititori.Add(new Cititori(nume: items[i],
                        telefon: items[i + 1],
                        email: items[i + 2],
                        dataImprumut: items[i + 3],
                        dataReturnare: items[i + 4],
                        idCarte: int.Parse(items[i+5])));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void incarcareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = "Fișiere text (*.txt)|*.txt|Toate fișierele (*.*)|*.*";
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    IncarcareDinFisier(dialog.FileName);
                    AfisareCititori();
                }
            }

        }

        private void salvareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog())
            {
                dialog.Filter = "Fișiere text (*.txt)|*.txt|Toate fișierele (*.*)|*.*";
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    SalvareInFisier(dialog.FileName);
                }
            }
        }

        private void SalvareInFisier(string caleFisier)
        {
            var continut = new StringBuilder();
            foreach (var cititor in cititori)
            {
                continut.AppendLine(cititor.Nume);
                continut.AppendLine(cititor.Telefon);
                continut.AppendLine(cititor.Email);
                continut.AppendLine(cititor.DataImprumut);
                continut.AppendLine(cititor.DataRetunare);
            }
            File.WriteAllText(caleFisier, continut.ToString());
        }

        private void cititorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            using (Form4 formular = new Form4())
            {
                formular.GetButton.Visible = false;
                if (formular.ShowDialog(this) == DialogResult.OK)
                {
                    cititori.Add(formular.Cititor);
                    AfisareCititori();
                }
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                // nu avem rând selectat
                return;
            }

            // Dacă avem un rând selectat extragem referința la produs
            var cititor = (Cititori)listView1.SelectedItems[0].Tag;

            using (Form4 formular = new Form4(cititor))
            {
                
                if (formular.ShowDialog(this) == DialogResult.OK)
                {   

                    // produsul a fost modificat => trebuie re-afișată lista
                    AfisareCititori();
                }
            }
        }

        private void stergereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }

            var cititor = (Cititori)listView1.SelectedItems[0].Tag;

            var rezultat = MessageBox.Show(this,
                $"Sunteți sigur că doriți să ștergeți cititorul '{cititor.Nume}'?",
                "Ștergere cititor",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (rezultat == DialogResult.Yes)
            {
                cititori.Remove(cititor);
                AfisareCititori();
            }
        }

        private void incarcaDinBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connection = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = cititoriBD.accdb";
            OleDbConnection conex = new OleDbConnection(connection);
            try
            {
                listView1.Items.Clear();
                conex.Open();
                OleDbCommand com = new OleDbCommand("SELECT * FROM Cititori");
                com.Connection = conex;
                OleDbDataReader reader = com.ExecuteReader();
                string nume;
                string telefon;
                string email;
                string dataI;
                string dataR;
                int IDC;
                while(reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader["ID"].ToString());
                    itm.SubItems.Add(reader["Nume"].ToString());
                    nume = reader["Nume"].ToString();
                    itm.SubItems.Add(reader["Telefon"].ToString());
                    telefon = reader["Telefon"].ToString();
                    itm.SubItems.Add(reader["Email"].ToString());
                    email = reader["Email"].ToString();
                    itm.SubItems.Add(reader["Data_Imprumut"].ToString());
                    dataI = reader["Data_Imprumut"].ToString();
                    itm.SubItems.Add(reader["Data_Returnare"].ToString());
                    dataR = reader["Data_Returnare"].ToString();
                    itm.SubItems.Add(reader["IDCarte"].ToString());
                    IDC = int.Parse(reader["IDCarte"].ToString());
                    listView1.Items.Add(itm);
                    Cititori c = new Cititori(nume, telefon, email, dataI, dataR, IDC);
                    cititori.Add(c);
                }
                listView1.Sorting = SortOrder.Ascending;
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conex.Close();
            }
        }

        private void incarcaInBDToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (Form4 formular = new Form4())
            {
                formular.GetBDButton.Visible = false;
                if (formular.ShowDialog(this) == DialogResult.OK)
                {
                    cititori.Add(formular.Cititor);
                    AfisareCititori();
                }
            }
        }

        private void stergeDinBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string connection = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = cititoriBD.accdb";
                OleDbConnection conex = new OleDbConnection(connection);
                conex.Open();
                OleDbCommand com = new OleDbCommand();
                com.Connection = conex;
                ListViewItem itm = listView1.SelectedItems[0];
                com.CommandText = "DELETE FROM Cititori where [ID] = " + itm.SubItems[0].Text;
                com.ExecuteNonQuery();
                conex.Close();
                listView1.Items.Remove(itm);
                MessageBox.Show("Cititor sters! ");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            AfisareCititori();
        }
    }
}
