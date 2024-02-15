namespace ProjetHygiene
{
    partial class Rapport
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnU = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(35)))), ((int)(((byte)(65)))));
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choissisez un Rapport";
            // 
            // btnU
            // 
            this.btnU.BackColor = System.Drawing.Color.White;
            this.btnU.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(35)))), ((int)(((byte)(65)))));
            this.btnU.Location = new System.Drawing.Point(95, 84);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(212, 41);
            this.btnU.TabIndex = 1;
            this.btnU.Text = "Utilisateur";
            this.btnU.UseVisualStyleBackColor = false;
            this.btnU.Click += new System.EventHandler(this.btnU_Click);
            // 
            // btnS
            // 
            this.btnS.BackColor = System.Drawing.Color.White;
            this.btnS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(35)))), ((int)(((byte)(65)))));
            this.btnS.Location = new System.Drawing.Point(95, 131);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(212, 40);
            this.btnS.TabIndex = 2;
            this.btnS.Text = "Signalement";
            this.btnS.UseVisualStyleBackColor = false;
            // 
            // btnE
            // 
            this.btnE.BackColor = System.Drawing.Color.White;
            this.btnE.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(35)))), ((int)(((byte)(65)))));
            this.btnE.Location = new System.Drawing.Point(95, 177);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(212, 44);
            this.btnE.TabIndex = 3;
            this.btnE.Text = " Equipe Nettoyage";
            this.btnE.UseVisualStyleBackColor = false;
            // 
            // btnP
            // 
            this.btnP.BackColor = System.Drawing.Color.White;
            this.btnP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(35)))), ((int)(((byte)(65)))));
            this.btnP.Location = new System.Drawing.Point(12, 241);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(94, 41);
            this.btnP.TabIndex = 1;
            this.btnP.Text = "Prev";
            this.btnP.UseVisualStyleBackColor = false;
            this.btnP.Click += new System.EventHandler(this.btnP_Click);
            // 
            // Rapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(35)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(415, 294);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.btnU);
            this.Controls.Add(this.label1);
            this.Name = "Rapport";
            this.Text = "Rapport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnU;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnP;
    }
}