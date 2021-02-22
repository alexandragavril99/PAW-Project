namespace ProiectPAW_1050_Gavril_Alexandra
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutBttn = new System.Windows.Forms.Button();
            this.abonatiBttn = new System.Windows.Forms.Button();
            this.cartiBttn = new System.Windows.Forms.Button();
            this.listaCititori1 = new ProiectPAW_1050_Gavril_Alexandra.ListaCititori();
            this.listaCarti1 = new ProiectPAW_1050_Gavril_Alexandra.ListaCarti();
            this.time1 = new ProiectPAW_1050_Gavril_Alexandra.Time();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(43)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.logoutBttn);
            this.panel1.Controls.Add(this.abonatiBttn);
            this.panel1.Controls.Add(this.cartiBttn);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 383);
            this.panel1.TabIndex = 1;
            // 
            // logoutBttn
            // 
            this.logoutBttn.FlatAppearance.BorderSize = 0;
            this.logoutBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBttn.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBttn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.logoutBttn.Image = global::ProiectPAW_1050_Gavril_Alexandra.Properties.Resources.entry;
            this.logoutBttn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.logoutBttn.Location = new System.Drawing.Point(1, 262);
            this.logoutBttn.Name = "logoutBttn";
            this.logoutBttn.Size = new System.Drawing.Size(131, 63);
            this.logoutBttn.TabIndex = 3;
            this.logoutBttn.Text = "Log Out";
            this.logoutBttn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.logoutBttn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.logoutBttn.UseVisualStyleBackColor = true;
            this.logoutBttn.Click += new System.EventHandler(this.logoutBttn_Click);
            // 
            // abonatiBttn
            // 
            this.abonatiBttn.FlatAppearance.BorderSize = 0;
            this.abonatiBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abonatiBttn.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abonatiBttn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.abonatiBttn.Image = global::ProiectPAW_1050_Gavril_Alexandra.Properties.Resources.people;
            this.abonatiBttn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.abonatiBttn.Location = new System.Drawing.Point(2, 151);
            this.abonatiBttn.Name = "abonatiBttn";
            this.abonatiBttn.Size = new System.Drawing.Size(131, 63);
            this.abonatiBttn.TabIndex = 2;
            this.abonatiBttn.Text = "Abonati";
            this.abonatiBttn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.abonatiBttn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.abonatiBttn.UseVisualStyleBackColor = true;
            this.abonatiBttn.Click += new System.EventHandler(this.abonatiBttn_Click);
            // 
            // cartiBttn
            // 
            this.cartiBttn.FlatAppearance.BorderSize = 0;
            this.cartiBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cartiBttn.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartiBttn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cartiBttn.Image = global::ProiectPAW_1050_Gavril_Alexandra.Properties.Resources.adobe_reader__2_;
            this.cartiBttn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cartiBttn.Location = new System.Drawing.Point(1, 47);
            this.cartiBttn.Name = "cartiBttn";
            this.cartiBttn.Size = new System.Drawing.Size(131, 63);
            this.cartiBttn.TabIndex = 1;
            this.cartiBttn.Text = "Carti";
            this.cartiBttn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cartiBttn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cartiBttn.UseVisualStyleBackColor = true;
            this.cartiBttn.Click += new System.EventHandler(this.cartiBttn_Click);
            // 
            // listaCititori1
            // 
            this.listaCititori1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(53)))), ((int)(((byte)(41)))));
            this.listaCititori1.Location = new System.Drawing.Point(132, 0);
            this.listaCititori1.Name = "listaCititori1";
            this.listaCititori1.Size = new System.Drawing.Size(678, 417);
            this.listaCititori1.TabIndex = 3;
            // 
            // listaCarti1
            // 
            this.listaCarti1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(53)))), ((int)(((byte)(41)))));
            this.listaCarti1.Location = new System.Drawing.Point(132, 0);
            this.listaCarti1.Name = "listaCarti1";
            this.listaCarti1.Size = new System.Drawing.Size(678, 417);
            this.listaCarti1.TabIndex = 2;
            // 
            // time1
            // 
            this.time1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(53)))), ((int)(((byte)(41)))));
            this.time1.Location = new System.Drawing.Point(664, 361);
            this.time1.Name = "time1";
            this.time1.Size = new System.Drawing.Size(144, 23);
            this.time1.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(53)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(809, 383);
            this.Controls.Add(this.time1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listaCititori1);
            this.Controls.Add(this.listaCarti1);
            this.Name = "Form2";
            this.Text = "Gestiune carti/abonati";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logoutBttn;
        private System.Windows.Forms.Button abonatiBttn;
        private System.Windows.Forms.Button cartiBttn;
        private ListaCarti listaCarti1;
        private ListaCititori listaCititori1;
        private Time time1;
    }
}