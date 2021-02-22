namespace ProiectPAW_1050_Gavril_Alexandra
{
    partial class Form1
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
            this.loginBttn = new System.Windows.Forms.Button();
            this.registerBttn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbParola = new System.Windows.Forms.MaskedTextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.logBttn = new System.Windows.Forms.Button();
            this.home1 = new ProiectPAW_1050_Gavril_Alexandra.Home();
            this.register1 = new ProiectPAW_1050_Gavril_Alexandra.Register();
            this.time1 = new ProiectPAW_1050_Gavril_Alexandra.Time();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(43)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.loginBttn);
            this.panel1.Controls.Add(this.registerBttn);
            this.panel1.Controls.Add(this.homeBtn);
            this.panel1.Location = new System.Drawing.Point(-5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 383);
            this.panel1.TabIndex = 0;
            // 
            // loginBttn
            // 
            this.loginBttn.FlatAppearance.BorderSize = 0;
            this.loginBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBttn.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBttn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginBttn.Image = global::ProiectPAW_1050_Gavril_Alexandra.Properties.Resources.entry;
            this.loginBttn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.loginBttn.Location = new System.Drawing.Point(4, 262);
            this.loginBttn.Name = "loginBttn";
            this.loginBttn.Size = new System.Drawing.Size(131, 63);
            this.loginBttn.TabIndex = 3;
            this.loginBttn.Text = "Log In";
            this.loginBttn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.loginBttn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.loginBttn.UseVisualStyleBackColor = true;
            this.loginBttn.Click += new System.EventHandler(this.loginBttn_Click);
            // 
            // registerBttn
            // 
            this.registerBttn.FlatAppearance.BorderSize = 0;
            this.registerBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerBttn.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBttn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.registerBttn.Image = global::ProiectPAW_1050_Gavril_Alexandra.Properties.Resources.note;
            this.registerBttn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.registerBttn.Location = new System.Drawing.Point(5, 151);
            this.registerBttn.Name = "registerBttn";
            this.registerBttn.Size = new System.Drawing.Size(131, 63);
            this.registerBttn.TabIndex = 2;
            this.registerBttn.Text = "Register";
            this.registerBttn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.registerBttn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.registerBttn.UseVisualStyleBackColor = true;
            this.registerBttn.Click += new System.EventHandler(this.registerBttn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.homeBtn.Image = global::ProiectPAW_1050_Gavril_Alexandra.Properties.Resources.house;
            this.homeBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.homeBtn.Location = new System.Drawing.Point(5, 47);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(131, 63);
            this.homeBtn.TabIndex = 1;
            this.homeBtn.Text = "Home";
            this.homeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.homeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(43)))), ((int)(((byte)(35)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbParola);
            this.panel2.Controls.Add(this.tbUser);
            this.panel2.Controls.Add(this.logBttn);
            this.panel2.Location = new System.Drawing.Point(211, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 360);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(69, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Parola:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username:";
            // 
            // tbParola
            // 
            this.tbParola.Location = new System.Drawing.Point(72, 181);
            this.tbParola.Name = "tbParola";
            this.tbParola.Size = new System.Drawing.Size(100, 20);
            this.tbParola.TabIndex = 1;
            this.tbParola.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.tbParola_MaskInputRejected);
            this.tbParola.TextChanged += new System.EventHandler(this.tbParola_TextChanged);
            this.tbParola.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbParola_KeyDown);
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(72, 89);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(100, 20);
            this.tbUser.TabIndex = 0;
            // 
            // logBttn
            // 
            this.logBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.logBttn.FlatAppearance.BorderSize = 0;
            this.logBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logBttn.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logBttn.ForeColor = System.Drawing.Color.White;
            this.logBttn.Image = global::ProiectPAW_1050_Gavril_Alexandra.Properties.Resources.log_in;
            this.logBttn.Location = new System.Drawing.Point(72, 263);
            this.logBttn.Name = "logBttn";
            this.logBttn.Size = new System.Drawing.Size(100, 57);
            this.logBttn.TabIndex = 2;
            this.logBttn.Text = "Log In";
            this.logBttn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.logBttn.UseVisualStyleBackColor = false;
            this.logBttn.Click += new System.EventHandler(this.logBttn_Click_1);
            // 
            // home1
            // 
            this.home1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(53)))), ((int)(((byte)(41)))));
            this.home1.Location = new System.Drawing.Point(126, -21);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(396, 422);
            this.home1.TabIndex = 2;
            // 
            // register1
            // 
            this.register1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(53)))), ((int)(((byte)(41)))));
            this.register1.Location = new System.Drawing.Point(126, -21);
            this.register1.Name = "register1";
            this.register1.Size = new System.Drawing.Size(396, 422);
            this.register1.TabIndex = 4;
            // 
            // time1
            // 
            this.time1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(53)))), ((int)(((byte)(41)))));
            this.time1.Location = new System.Drawing.Point(245, 47);
            this.time1.Name = "time1";
            this.time1.Size = new System.Drawing.Size(126, 23);
            this.time1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(53)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(518, 383);
            this.Controls.Add(this.time1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.home1);
            this.Controls.Add(this.register1);
            this.Name = "Form1";
            this.Text = "Formular principal";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Button loginBttn;
        private System.Windows.Forms.Button registerBttn;
        private Home home1;
        private Register register1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox tbParola;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Button logBttn;
        private Time time1;
    }
}

