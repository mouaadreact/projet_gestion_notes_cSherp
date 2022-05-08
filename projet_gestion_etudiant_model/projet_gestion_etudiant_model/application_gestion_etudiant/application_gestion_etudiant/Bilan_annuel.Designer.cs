
namespace application_gestion_etudiant
{
    partial class Bilan_annuel
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
            this.labelFiliere = new System.Windows.Forms.Label();
            this.labelEtudiant = new System.Windows.Forms.Label();
            this.labelNiveau = new System.Windows.Forms.Label();
            this.labelMoyenne = new System.Windows.Forms.Label();
            this.Filiere = new System.Windows.Forms.ComboBox();
            this.Etudiant = new System.Windows.Forms.ComboBox();
            this.Niveau = new System.Windows.Forms.ComboBox();
            this.Recherche = new System.Windows.Forms.Button();
            this.Table = new System.Windows.Forms.DataGridView();
            this.Code_matiere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moyenne = new System.Windows.Forms.TextBox();
            this.EXEL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFiliere
            // 
            this.labelFiliere.AutoSize = true;
            this.labelFiliere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.labelFiliere.Location = new System.Drawing.Point(124, 49);
            this.labelFiliere.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFiliere.Name = "labelFiliere";
            this.labelFiliere.Size = new System.Drawing.Size(53, 18);
            this.labelFiliere.TabIndex = 0;
            this.labelFiliere.Text = "Filiere";
            // 
            // labelEtudiant
            // 
            this.labelEtudiant.AutoSize = true;
            this.labelEtudiant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.labelEtudiant.Location = new System.Drawing.Point(124, 119);
            this.labelEtudiant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEtudiant.Name = "labelEtudiant";
            this.labelEtudiant.Size = new System.Drawing.Size(67, 18);
            this.labelEtudiant.TabIndex = 1;
            this.labelEtudiant.Text = "Etudiant";
            // 
            // labelNiveau
            // 
            this.labelNiveau.AutoSize = true;
            this.labelNiveau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.labelNiveau.Location = new System.Drawing.Point(544, 49);
            this.labelNiveau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNiveau.Name = "labelNiveau";
            this.labelNiveau.Size = new System.Drawing.Size(58, 18);
            this.labelNiveau.TabIndex = 2;
            this.labelNiveau.Text = "Niveau";
            // 
            // labelMoyenne
            // 
            this.labelMoyenne.AutoSize = true;
            this.labelMoyenne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.labelMoyenne.Location = new System.Drawing.Point(239, 439);
            this.labelMoyenne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMoyenne.Name = "labelMoyenne";
            this.labelMoyenne.Size = new System.Drawing.Size(125, 18);
            this.labelMoyenne.TabIndex = 3;
            this.labelMoyenne.Text = "Moyenne annuel";
            // 
            // Filiere
            // 
            this.Filiere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.Filiere.FormattingEnabled = true;
            this.Filiere.Location = new System.Drawing.Point(260, 46);
            this.Filiere.Margin = new System.Windows.Forms.Padding(4);
            this.Filiere.Name = "Filiere";
            this.Filiere.Size = new System.Drawing.Size(135, 26);
            this.Filiere.TabIndex = 4;
            this.Filiere.SelectedIndexChanged += new System.EventHandler(this.Filiere_SelectedIndexChanged);
            // 
            // Etudiant
            // 
            this.Etudiant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.Etudiant.FormattingEnabled = true;
            this.Etudiant.Location = new System.Drawing.Point(260, 119);
            this.Etudiant.Margin = new System.Windows.Forms.Padding(4);
            this.Etudiant.Name = "Etudiant";
            this.Etudiant.Size = new System.Drawing.Size(135, 26);
            this.Etudiant.TabIndex = 5;
            // 
            // Niveau
            // 
            this.Niveau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.Niveau.FormattingEnabled = true;
            this.Niveau.Location = new System.Drawing.Point(655, 41);
            this.Niveau.Margin = new System.Windows.Forms.Padding(4);
            this.Niveau.Name = "Niveau";
            this.Niveau.Size = new System.Drawing.Size(135, 26);
            this.Niveau.TabIndex = 6;
            this.Niveau.SelectedIndexChanged += new System.EventHandler(this.Niveau_SelectedIndexChanged);
            // 
            // Recherche
            // 
            this.Recherche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(125)))), ((int)(((byte)(122)))));
            this.Recherche.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.Recherche.Location = new System.Drawing.Point(655, 119);
            this.Recherche.Margin = new System.Windows.Forms.Padding(4);
            this.Recherche.Name = "Recherche";
            this.Recherche.Size = new System.Drawing.Size(136, 26);
            this.Recherche.TabIndex = 7;
            this.Recherche.Text = "Recherche";
            this.Recherche.UseVisualStyleBackColor = false;
            this.Recherche.Click += new System.EventHandler(this.Recherche_Click);
            // 
            // Table
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code_matiere,
            this.Designation,
            this.Semestre,
            this.Note});
            this.Table.Location = new System.Drawing.Point(71, 217);
            this.Table.Margin = new System.Windows.Forms.Padding(4);
            this.Table.Name = "Table";
            this.Table.RowHeadersWidth = 51;
            this.Table.RowTemplate.Height = 24;
            this.Table.Size = new System.Drawing.Size(743, 169);
            this.Table.TabIndex = 8;
            this.Table.Resize += new System.EventHandler(this.Table_Resize);
            // 
            // Code_matiere
            // 
            this.Code_matiere.HeaderText = "Code matiere";
            this.Code_matiere.MinimumWidth = 6;
            this.Code_matiere.Name = "Code_matiere";
            this.Code_matiere.Width = 125;
            // 
            // Designation
            // 
            this.Designation.HeaderText = "Designation";
            this.Designation.MinimumWidth = 6;
            this.Designation.Name = "Designation";
            this.Designation.Width = 125;
            // 
            // Semestre
            // 
            this.Semestre.HeaderText = "Semestre";
            this.Semestre.MinimumWidth = 6;
            this.Semestre.Name = "Semestre";
            this.Semestre.Width = 125;
            // 
            // Note
            // 
            this.Note.HeaderText = "Note";
            this.Note.MinimumWidth = 6;
            this.Note.Name = "Note";
            this.Note.Width = 125;
            // 
            // Moyenne
            // 
            this.Moyenne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.Moyenne.Location = new System.Drawing.Point(431, 433);
            this.Moyenne.Margin = new System.Windows.Forms.Padding(4);
            this.Moyenne.Name = "Moyenne";
            this.Moyenne.Size = new System.Drawing.Size(112, 25);
            this.Moyenne.TabIndex = 9;
            // 
            // EXEL
            // 
            this.EXEL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(125)))), ((int)(((byte)(122)))));
            this.EXEL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.EXEL.Location = new System.Drawing.Point(734, 431);
            this.EXEL.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.EXEL.Name = "EXEL";
            this.EXEL.Size = new System.Drawing.Size(106, 26);
            this.EXEL.TabIndex = 10;
            this.EXEL.Text = "EXEL";
            this.EXEL.UseVisualStyleBackColor = false;
            this.EXEL.Click += new System.EventHandler(this.EXEL_Click);
            // 
            // Bilan_annuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(60)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(900, 506);
            this.Controls.Add(this.EXEL);
            this.Controls.Add(this.Moyenne);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.Recherche);
            this.Controls.Add(this.Niveau);
            this.Controls.Add(this.Etudiant);
            this.Controls.Add(this.Filiere);
            this.Controls.Add(this.labelMoyenne);
            this.Controls.Add(this.labelNiveau);
            this.Controls.Add(this.labelEtudiant);
            this.Controls.Add(this.labelFiliere);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(60)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Bilan_annuel";
            this.Text = "Bilan annuel";
            this.Load += new System.EventHandler(this.Bilan_annuel_Load);
            this.Resize += new System.EventHandler(this.Bilan_annuel_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFiliere;
        private System.Windows.Forms.Label labelEtudiant;
        private System.Windows.Forms.Label labelNiveau;
        private System.Windows.Forms.Label labelMoyenne;
        private System.Windows.Forms.ComboBox Filiere;
        private System.Windows.Forms.ComboBox Etudiant;
        private System.Windows.Forms.ComboBox Niveau;
        private System.Windows.Forms.Button Recherche;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code_matiere;
        private System.Windows.Forms.DataGridViewTextBoxColumn Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.TextBox Moyenne;
        private System.Windows.Forms.Button EXEL;
    }
}