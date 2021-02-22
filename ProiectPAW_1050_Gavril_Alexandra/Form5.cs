using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW_1050_Gavril_Alexandra
{
    public partial class Form5 : Form
    {
        List<Carte> carti;

        double[] valori = new double[4];
        int[] years = new int[20];
        double distance = 0.0;
        const int margin = 10;
        string[] edituri = new string[4] { "Altceva", "Polirom", "Humanitas", "Litera" };
        bool vb = false;

        Color color = Color.Orange;
        Font font = new Font(FontFamily.GenericSansSerif, 1, FontStyle.Bold);

        public Form5(List<Carte> carti = null)
        {
            InitializeComponent();

            this.carti = carti;

            AfisareCarti();
        }

        void AfisareCarti()
        {
            listViewGrafic.Items.Clear();

            foreach (var carte in carti)
            {

                var item = new ListViewItem(new string[] {
                carte.Editura
                });

                item.Tag = carte;
                listViewGrafic.Items.Add(item);
            }

            for (int i = 0; i < 4; i++)
                valori[i] = 0;
            foreach (var carte in carti)
            {
                if (carte.Editura == "Polirom")
                    valori[1]++;
                else if (carte.Editura == "Humanitas")
                    valori[2]++;
                else if (carte.Editura == "Litera")
                    valori[3]++;
                else valori[0]++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nr = 0;
            foreach(var carte in carti)
            {
                nr++;
            }

            int[] valori = new int[nr];

            int index = 0;
            foreach (var carte in carti)
            {
                valori[index] = carte.NrPagini;
                index++;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(pdPrint);
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = pd;
            dlg.ShowDialog();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            vb = true;
            
            panel1.Invalidate();
            
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (vb == true)
            {
                Graphics g = e.Graphics;
                Rectangle rect = new Rectangle(panel1.ClientRectangle.X + margin, panel1.ClientRectangle.Y + 4 * margin,
                    panel1.ClientRectangle.Width - 2 * margin, panel1.ClientRectangle.Height - 5 * margin);
                Pen pen = new Pen(Color.White, 3);
                g.DrawRectangle(pen, rect);
                double width = rect.Width / 4 / 3;
                distance = (rect.Width - 4 * width) / (4 + 1);
                //MessageBox.Show(distance.ToString());
                int leftControl = 1;
                double vMax = valori.Max();
                //MessageBox.Show(vMax.ToString());
                Brush br = new SolidBrush(color);
                Rectangle[] recs = new Rectangle[4];
                for (int i = 0; i < 4; i++)
                {
                    recs[i] = new Rectangle((int)(rect.Location.X + (i + 1) * distance + i * width),
                        (int)(rect.Location.Y + rect.Height - valori[i] / vMax * rect.Height),
                        (int)width,
                        (int)(valori[i] / vMax * rect.Height));
                    g.DrawString(valori[i].ToString(), this.Font, br, new Point((int)(recs[i].Location.X),
                        (int)(recs[i].Location.Y - this.Font.Height)));
                    
                        g.DrawString(edituri[i].ToString(), this.Font, br, new Point((int)(recs[i].Location.X),
                          recs[i].Location.Y + recs[i].Height));
                    
                    g.FillRectangles(br, recs);


                    leftControl++;

                }
                try
                {
                    for (int i = 0; i < 3 ; i++)
                        g.DrawLine(pen, new Point((int)(recs[i].Location.X + width / 2), (int)(recs[i].Location.Y)),
                             new Point((int)(recs[i + 1].Location.X + width / 2), (int)(recs[i + 1].Location.Y)));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Array is full");
                }

            }
        }

        private void pdPrint(object sender, PrintPageEventArgs e)
        {
            if (vb == true)
            {
                Graphics g = e.Graphics;
                Rectangle rect = new Rectangle(e.PageBounds.X + margin, e.PageBounds.Y + 2 * margin,
                    e.PageBounds.Width - 2 * margin, e.PageBounds.Height - 3 * margin);
                Pen pen = new Pen(Color.Black, 3);
                g.DrawRectangle(pen, rect);
                
                double width = rect.Width / 4 / 3;
                distance = (rect.Width - 4 * width) / (4 + 1);
                //MessageBox.Show(distance.ToString());
                int leftControl = 1;
                double vMax = valori.Max();
                //MessageBox.Show(vMax.ToString());
                Brush br = new SolidBrush(color);
                Rectangle[] recs = new Rectangle[4];
                for (int i = 0; i < 4; i++)
                {
                    recs[i] = new Rectangle((int)(rect.Location.X + (i + 1) * distance + i * width),
                        (int)(rect.Location.Y + rect.Height - valori[i] / vMax * rect.Height),
                        (int)width,
                        (int)(valori[i] / vMax * rect.Height));
                    g.DrawString(valori[i].ToString(), this.Font, br, new Point((int)(recs[i].Location.X),
                        (int)(recs[i].Location.Y - this.Font.Height)));

                    g.DrawString(edituri[i].ToString(), this.Font, br, new Point((int)(recs[i].Location.X),
                      recs[i].Location.Y + recs[i].Height));

                    g.FillRectangles(br, recs);


                    leftControl++;

                }

                try
                {
                    for (int i = 0; i < 4 - 1; i++)
                        g.DrawLine(pen, new Point((int)(recs[i].Location.X + width / 2), (int)(recs[i].Location.Y)),
                             new Point((int)(recs[i + 1].Location.X + width / 2), (int)(recs[i + 1].Location.Y)));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Array is full");
                }


            }
        }

        private void listViewGrafic_MouseDown(object sender, MouseEventArgs e)
        {
            if (listViewGrafic.Items.Count > 0)
                try { listViewGrafic.DoDragDrop(listViewGrafic.SelectedItems, DragDropEffects.Copy | DragDropEffects.Move); }
                catch (Exception ex)
                {
                    MessageBox.Show("No string selected!");
                }
        }

        private void panel2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
            if (((e.KeyState & 8) == 8) && (e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
                e.Effect = DragDropEffects.Copy;
            else
                if ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move)
                e.Effect = DragDropEffects.Move;
        }

        private void panel2_DragDrop(object sender, DragEventArgs e)
        {
            

            if (string.Compare("Polirom", listViewGrafic.SelectedItems[0].SubItems[0].Text) == 0)
                valori[1]--;
            else if (string.Compare(listViewGrafic.SelectedItems[0].SubItems[0].Text,"Humanitas") == 0)
                valori[2]--;
            else if (string.Compare(listViewGrafic.SelectedItems[0].SubItems[0].Text,"Litera") == 0 )
                valori[3]--;
            else valori[0]--;

            listViewGrafic.SelectedItems[0].Remove();
        }
    }
}
