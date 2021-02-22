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
using System.Globalization;

namespace ProiectPAW_1050_Gavril_Alexandra
{
    public partial class ListaCarti : UserControl
    {
        List<Carte> carti; 
        public ListaCarti()
        {
            InitializeComponent();

            carti = new List<Carte>();

            AfisareCarti();
        }

        void AfisareCarti()
        {
            listView1.Items.Clear();


            foreach(var carte in carti)
            {
                if (carte.Autor.IndexOf(toolStripTextBox1.Text, StringComparison.OrdinalIgnoreCase) < 0)
                {
                    continue;
                }

                var item = new ListViewItem(new string[] {
                carte.ID.ToString(), carte.NumeCarte, carte.Autor, carte.Editura,
                carte.NrPagini.ToString(),carte.AnFabricatie.ToString(), carte.Status});

                item.Tag = carte;
                item.ForeColor = Color.White;
                listView1.Items.Add(item);
            }


        }

        private void incarcareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = "Fișiere text (*.txt)|*.txt|Toate fișierele (*.*)|*.*";
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                     IncarcareDinFisier(dialog.FileName);
                     AfisareCarti();
                }
            }
        }

        private void IncarcareDinFisier(string caleFisier)
        {
            try
            {
                carti.Clear();
                var items = File.ReadAllLines(caleFisier);

                for (int i = 0; i < items.Length; i += 6)
                {
                    carti.Add(new Carte(numeCarte: items[i],
                        autor: items[i + 1],
                        editura: items[i + 2],
                        nrPagini: Int32.Parse(items[i + 3]),
                        anFabricatie: Int32.Parse(items[i + 4]),
                        status: items[i+5]));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
            foreach (var carte in carti)
            {
                continut.AppendLine(carte.NumeCarte);
                continut.AppendLine(carte.Autor);
                continut.AppendLine(carte.Editura);
                continut.Append(carte.NrPagini.ToString(CultureInfo.InvariantCulture));
                continut.AppendLine();
                continut.Append(carte.AnFabricatie.ToString(CultureInfo.InvariantCulture));
                continut.AppendLine();
            }
            File.WriteAllText(caleFisier, continut.ToString());
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            AfisareCarti();
        }

        private void carteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form3 formular = new Form3())
            {
                if (formular.ShowDialog(this) == DialogResult.OK)
                {
                    carti.Add(formular.Carte);
                    AfisareCarti();
                }
            }
        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            var avemCarteSelectata = listView1.SelectedItems.Count > 0;
            stergereToolStripMenuItem.Enabled = avemCarteSelectata;
            editareToolStripMenuItem.Enabled = avemCarteSelectata;

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                // nu avem rând selectat
                return;
            }

            // Dacă avem un rând selectat extragem referința la produs
            var carte = (Carte)listView1.SelectedItems[0].Tag;

            using (Form3 formular = new Form3(carte))
            {
                if (formular.ShowDialog(this) == DialogResult.OK)
                {
                    // produsul a fost modificat => trebuie re-afișată lista
                    AfisareCarti();
                }
            }
        }

        private void stergereToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }

            var carte = (Carte)listView1.SelectedItems[0].Tag;

            var rezultat = MessageBox.Show(this,
                $"Sunteți sigur că doriți să ștergeți cartea '{carte.NumeCarte}'?",
                "Ștergere carte",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (rezultat == DialogResult.Yes)
            {
                carti.Remove(carte);
                AfisareCarti();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
            using (Form5 formular = new Form5(carti))
            {
                if (formular.ShowDialog(this) == DialogResult.OK)
                {
                   
                }
            }
        }
    }
}
