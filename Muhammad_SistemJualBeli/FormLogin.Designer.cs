namespace Muhammad_SistemJualBeli
{
    partial class FormLogin
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
            this.panelPengaturan = new System.Windows.Forms.Panel();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.textBoxDatabase = new System.Windows.Forms.TextBox();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.labelDatabase = new System.Windows.Forms.Label();
            this.labelServer = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.linkLabelPengaturan = new System.Windows.Forms.LinkLabel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.panelPengaturan.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPengaturan
            // 
            this.panelPengaturan.BackColor = System.Drawing.Color.Lavender;
            this.panelPengaturan.Controls.Add(this.buttonSimpan);
            this.panelPengaturan.Controls.Add(this.textBoxDatabase);
            this.panelPengaturan.Controls.Add(this.textBoxServer);
            this.panelPengaturan.Controls.Add(this.labelDatabase);
            this.panelPengaturan.Controls.Add(this.labelServer);
            this.panelPengaturan.Location = new System.Drawing.Point(1, 198);
            this.panelPengaturan.Name = "panelPengaturan";
            this.panelPengaturan.Size = new System.Drawing.Size(453, 159);
            this.panelPengaturan.TabIndex = 3;
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.BackColor = System.Drawing.Color.Navy;
            this.buttonSimpan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.ForeColor = System.Drawing.Color.White;
            this.buttonSimpan.Location = new System.Drawing.Point(133, 103);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(122, 42);
            this.buttonSimpan.TabIndex = 4;
            this.buttonSimpan.Text = "SIMPAN";
            this.buttonSimpan.UseVisualStyleBackColor = false;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // textBoxDatabase
            // 
            this.textBoxDatabase.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDatabase.Location = new System.Drawing.Point(133, 54);
            this.textBoxDatabase.Name = "textBoxDatabase";
            this.textBoxDatabase.Size = new System.Drawing.Size(286, 26);
            this.textBoxDatabase.TabIndex = 3;
            // 
            // textBoxServer
            // 
            this.textBoxServer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxServer.Location = new System.Drawing.Point(133, 18);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(286, 26);
            this.textBoxServer.TabIndex = 1;
            // 
            // labelDatabase
            // 
            this.labelDatabase.AutoSize = true;
            this.labelDatabase.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatabase.Location = new System.Drawing.Point(37, 59);
            this.labelDatabase.Name = "labelDatabase";
            this.labelDatabase.Size = new System.Drawing.Size(81, 17);
            this.labelDatabase.TabIndex = 2;
            this.labelDatabase.Text = "Database :";
            // 
            // labelServer
            // 
            this.labelServer.AutoSize = true;
            this.labelServer.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServer.Location = new System.Drawing.Point(56, 23);
            this.labelServer.Name = "labelServer";
            this.labelServer.Size = new System.Drawing.Size(62, 17);
            this.labelServer.TabIndex = 0;
            this.labelServer.Text = "Server :";
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.Lavender;
            this.panelLogin.Controls.Add(this.buttonKeluar);
            this.panelLogin.Controls.Add(this.linkLabelPengaturan);
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Controls.Add(this.textBoxUsername);
            this.panelLogin.Controls.Add(this.labelUsername);
            this.panelLogin.Controls.Add(this.textBoxPassword);
            this.panelLogin.Controls.Add(this.labelPassword);
            this.panelLogin.Location = new System.Drawing.Point(1, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(453, 192);
            this.panelLogin.TabIndex = 2;
            this.panelLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogin_Paint);
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Navy;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.White;
            this.buttonKeluar.Location = new System.Drawing.Point(297, 103);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(122, 42);
            this.buttonKeluar.TabIndex = 5;
            this.buttonKeluar.Text = "KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // linkLabelPengaturan
            // 
            this.linkLabelPengaturan.AutoSize = true;
            this.linkLabelPengaturan.Location = new System.Drawing.Point(23, 156);
            this.linkLabelPengaturan.Name = "linkLabelPengaturan";
            this.linkLabelPengaturan.Size = new System.Drawing.Size(125, 17);
            this.linkLabelPengaturan.TabIndex = 6;
            this.linkLabelPengaturan.TabStop = true;
            this.linkLabelPengaturan.Text = "Pengaturan Lanjut";
            this.linkLabelPengaturan.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPengaturan_LinkClicked);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Navy;
            this.buttonLogin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(160, 103);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(122, 42);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "LOGIN";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(133, 21);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(286, 26);
            this.textBoxUsername.TabIndex = 1;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(32, 26);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(86, 17);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username :";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(133, 55);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(286, 26);
            this.textBoxPassword.TabIndex = 3;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(34, 60);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(84, 17);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Password :";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 357);
            this.Controls.Add(this.panelPengaturan);
            this.Controls.Add(this.panelLogin);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panelPengaturan.ResumeLayout(false);
            this.panelPengaturan.PerformLayout();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPengaturan;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.TextBox textBoxDatabase;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.Label labelDatabase;
        private System.Windows.Forms.Label labelServer;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.LinkLabel linkLabelPengaturan;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
    }
}