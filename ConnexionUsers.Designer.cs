namespace ProjetHygiene
{
    partial class ConnexionUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnexionUsers));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaCheckBox1 = new Guna.UI.WinForms.GunaCheckBox();
            this.btnConnexion2 = new Guna.UI.WinForms.GunaButton();
            this.txtConCmdp = new Guna.UI.WinForms.GunaTextBox();
            this.txtConMdp = new Guna.UI.WinForms.GunaTextBox();
            this.txtConNom = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.gunaPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gunaPanel1.Controls.Add(this.gunaCheckBox1);
            this.gunaPanel1.Controls.Add(this.btnConnexion2);
            this.gunaPanel1.Controls.Add(this.txtConCmdp);
            this.gunaPanel1.Controls.Add(this.txtConMdp);
            this.gunaPanel1.Controls.Add(this.txtConNom);
            this.gunaPanel1.Controls.Add(this.gunaLabel3);
            this.gunaPanel1.Controls.Add(this.gunaLabel2);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Location = new System.Drawing.Point(12, 12);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1025, 606);
            this.gunaPanel1.TabIndex = 0;
            // 
            // gunaCheckBox1
            // 
            this.gunaCheckBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCheckBox1.CheckedOffColor = System.Drawing.Color.Gray;
            this.gunaCheckBox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaCheckBox1.FillColor = System.Drawing.Color.White;
            this.gunaCheckBox1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaCheckBox1.Location = new System.Drawing.Point(449, 415);
            this.gunaCheckBox1.Name = "gunaCheckBox1";
            this.gunaCheckBox1.Size = new System.Drawing.Size(250, 26);
            this.gunaCheckBox1.TabIndex = 8;
            this.gunaCheckBox1.Text = "Afficher le mot de passe";
            this.gunaCheckBox1.CheckedChanged += new System.EventHandler(this.gunaCheckBox1_CheckedChanged);
            // 
            // btnConnexion2
            // 
            this.btnConnexion2.AnimationHoverSpeed = 0.07F;
            this.btnConnexion2.AnimationSpeed = 0.03F;
            this.btnConnexion2.BackColor = System.Drawing.Color.Transparent;
            this.btnConnexion2.BaseColor = System.Drawing.Color.SlateGray;
            this.btnConnexion2.BorderColor = System.Drawing.Color.Transparent;
            this.btnConnexion2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnConnexion2.FocusedColor = System.Drawing.Color.Empty;
            this.btnConnexion2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnexion2.ForeColor = System.Drawing.Color.Lavender;
            this.btnConnexion2.Image = ((System.Drawing.Image)(resources.GetObject("btnConnexion2.Image")));
            this.btnConnexion2.ImageSize = new System.Drawing.Size(20, 20);
            this.btnConnexion2.Location = new System.Drawing.Point(449, 495);
            this.btnConnexion2.Name = "btnConnexion2";
            this.btnConnexion2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnConnexion2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnConnexion2.OnHoverForeColor = System.Drawing.Color.White;
            this.btnConnexion2.OnHoverImage = null;
            this.btnConnexion2.OnPressedColor = System.Drawing.Color.Black;
            this.btnConnexion2.Radius = 10;
            this.btnConnexion2.Size = new System.Drawing.Size(280, 42);
            this.btnConnexion2.TabIndex = 7;
            this.btnConnexion2.Text = "Se Connecter";
            this.btnConnexion2.Click += new System.EventHandler(this.btnConnexion2_Click);
            // 
            // txtConCmdp
            // 
            this.txtConCmdp.BackColor = System.Drawing.Color.Transparent;
            this.txtConCmdp.BaseColor = System.Drawing.Color.White;
            this.txtConCmdp.BorderColor = System.Drawing.Color.Silver;
            this.txtConCmdp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConCmdp.FocusedBaseColor = System.Drawing.Color.White;
            this.txtConCmdp.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtConCmdp.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtConCmdp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtConCmdp.Location = new System.Drawing.Point(476, 268);
            this.txtConCmdp.Name = "txtConCmdp";
            this.txtConCmdp.PasswordChar = '.';
            this.txtConCmdp.Radius = 20;
            this.txtConCmdp.SelectedText = "";
            this.txtConCmdp.Size = new System.Drawing.Size(344, 50);
            this.txtConCmdp.TabIndex = 6;
            // 
            // txtConMdp
            // 
            this.txtConMdp.BackColor = System.Drawing.Color.Transparent;
            this.txtConMdp.BaseColor = System.Drawing.Color.White;
            this.txtConMdp.BorderColor = System.Drawing.Color.Silver;
            this.txtConMdp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConMdp.FocusedBaseColor = System.Drawing.Color.White;
            this.txtConMdp.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtConMdp.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtConMdp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtConMdp.Location = new System.Drawing.Point(467, 162);
            this.txtConMdp.Name = "txtConMdp";
            this.txtConMdp.PasswordChar = '.';
            this.txtConMdp.Radius = 20;
            this.txtConMdp.SelectedText = "";
            this.txtConMdp.Size = new System.Drawing.Size(344, 50);
            this.txtConMdp.TabIndex = 5;
            // 
            // txtConNom
            // 
            this.txtConNom.BackColor = System.Drawing.Color.Transparent;
            this.txtConNom.BaseColor = System.Drawing.Color.White;
            this.txtConNom.BorderColor = System.Drawing.Color.Silver;
            this.txtConNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConNom.FocusedBaseColor = System.Drawing.Color.White;
            this.txtConNom.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtConNom.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtConNom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtConNom.Location = new System.Drawing.Point(467, 67);
            this.txtConNom.Name = "txtConNom";
            this.txtConNom.PasswordChar = '\0';
            this.txtConNom.Radius = 20;
            this.txtConNom.SelectedText = "";
            this.txtConNom.Size = new System.Drawing.Size(344, 50);
            this.txtConNom.TabIndex = 4;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gunaLabel3.Location = new System.Drawing.Point(39, 288);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(374, 30);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = " Confirmation de mot de passe";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gunaLabel2.Location = new System.Drawing.Point(96, 162);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(212, 37);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Mot de passe";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gunaLabel1.Location = new System.Drawing.Point(123, 67);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(86, 38);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Nom";
            // 
            // ConnexionUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 663);
            this.Controls.Add(this.gunaPanel1);
            this.Name = "ConnexionUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConnexionUsers";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaTextBox txtConNom;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txtConCmdp;
        private Guna.UI.WinForms.GunaTextBox txtConMdp;
        private Guna.UI.WinForms.GunaButton btnConnexion2;
        private Guna.UI.WinForms.GunaCheckBox gunaCheckBox1;
    }
}