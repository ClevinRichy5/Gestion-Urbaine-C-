namespace ProjetHygiene
{
    partial class Ordures
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv2 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvVille = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQuartier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNiveau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvZone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCommentaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvImg = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv2
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvVille,
            this.dgvQuartier,
            this.dgvNiveau,
            this.dgvZone,
            this.dgvCommentaire,
            this.dgvImg});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv2.Location = new System.Drawing.Point(12, 168);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowHeadersVisible = false;
            this.dgv2.RowTemplate.Height = 82;
            this.dgv2.Size = new System.Drawing.Size(1144, 387);
            this.dgv2.TabIndex = 0;
            this.dgv2.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv2.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv2.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv2.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv2.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv2.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv2.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv2.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv2.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv2.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.ThemeStyle.HeaderStyle.Height = 32;
            this.dgv2.ThemeStyle.ReadOnly = false;
            this.dgv2.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv2.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv2.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv2.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv2.ThemeStyle.RowsStyle.Height = 82;
            this.dgv2.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv2.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dgvVille
            // 
            this.dgvVille.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvVille.HeaderText = "Ville";
            this.dgvVille.Name = "dgvVille";
            // 
            // dgvQuartier
            // 
            this.dgvQuartier.HeaderText = "Quartier";
            this.dgvQuartier.Name = "dgvQuartier";
            // 
            // dgvNiveau
            // 
            this.dgvNiveau.HeaderText = "Niveau";
            this.dgvNiveau.Name = "dgvNiveau";
            // 
            // dgvZone
            // 
            this.dgvZone.HeaderText = "Zone";
            this.dgvZone.Name = "dgvZone";
            // 
            // dgvCommentaire
            // 
            this.dgvCommentaire.HeaderText = "Commentaire";
            this.dgvCommentaire.Name = "dgvCommentaire";
            // 
            // dgvImg
            // 
            this.dgvImg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvImg.HeaderText = "Image";
            this.dgvImg.Name = "dgvImg";
            // 
            // Ordures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 640);
            this.Controls.Add(this.dgv2);
            this.Name = "Ordures";
            this.Text = "Ordures";
            this.Load += new System.EventHandler(this.Ordures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgv2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvVille;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQuartier;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNiveau;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvZone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCommentaire;
        private System.Windows.Forms.DataGridViewImageColumn dgvImg;

    }
}