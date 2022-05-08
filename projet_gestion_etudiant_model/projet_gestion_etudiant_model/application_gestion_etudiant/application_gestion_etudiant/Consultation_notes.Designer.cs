
namespace application_gestion_etudiant
{
    partial class Consultation_notes
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
            this.labelFiliere = new System.Windows.Forms.Label();
            this.labelMatiere = new System.Windows.Forms.Label();
            this.labelNiveau = new System.Windows.Forms.Label();
            this.Filiere = new System.Windows.Forms.ComboBox();
            this.Matiere = new System.Windows.Forms.ComboBox();
            this.Niveau = new System.Windows.Forms.ComboBox();
            this.Recherche = new System.Windows.Forms.Button();
            this.Table = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moyenne = new System.Windows.Forms.TextBox();
            this.labelMoyenne = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFiliere
            // 
            this.labelFiliere.AutoSize = true;
            this.labelFiliere.Location = new System.Drawing.Point(112, 46);
            this.labelFiliere.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFiliere.Name = "labelFiliere";
            this.labelFiliere.Size = new System.Drawing.Size(53, 18);
            this.labelFiliere.TabIndex = 0;
            this.labelFiliere.Text = "Filiere";
            // 
            // labelMatiere
            // 
            this.labelMatiere.AutoSize = true;
            this.labelMatiere.Location = new System.Drawing.Point(112, 121);
            this.labelMatiere.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMatiere.Name = "labelMatiere";
            this.labelMatiere.Size = new System.Drawing.Size(62, 18);
            this.labelMatiere.TabIndex = 1;
            this.labelMatiere.Text = "Matiere";
            // 
            // labelNiveau
            // 
            this.labelNiveau.AutoSize = true;
            this.labelNiveau.Location = new System.Drawing.Point(477, 46);
            this.labelNiveau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNiveau.Name = "labelNiveau";
            this.labelNiveau.Size = new System.Drawing.Size(58, 18);
            this.labelNiveau.TabIndex = 2;
            this.labelNiveau.Text = "Niveau";
            // 
            // Filiere
            // 
            this.Filiere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.Filiere.FormattingEnabled = true;
            this.Filiere.Location = new System.Drawing.Point(244, 38);
            this.Filiere.Margin = new System.Windows.Forms.Padding(4);
            this.Filiere.Name = "Filiere";
            this.Filiere.Size = new System.Drawing.Size(135, 26);
            this.Filiere.TabIndex = 3;
            this.Filiere.SelectedIndexChanged += new System.EventHandler(this.Filiere_SelectedIndexChanged);
            // 
            // Matiere
            // 
            this.Matiere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.Matiere.FormattingEnabled = true;
            this.Matiere.Location = new System.Drawing.Point(244, 113);
            this.Matiere.Margin = new System.Windows.Forms.Padding(4);
            this.Matiere.Name = "Matiere";
            this.Matiere.Size = new System.Drawing.Size(135, 26);
            this.Matiere.TabIndex = 4;
            // 
            // Niveau
            // 
            this.Niveau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.Niveau.FormattingEnabled = true;
            this.Niveau.Location = new System.Drawing.Point(607, 38);
            this.Niveau.Margin = new System.Windows.Forms.Padding(4);
            this.Niveau.Name = "Niveau";
            this.Niveau.Size = new System.Drawing.Size(135, 26);
            this.Niveau.TabIndex = 5;
            this.Niveau.SelectedIndexChanged += new System.EventHandler(this.Niveau_SelectedIndexChanged);
            // 
            // Recherche
            // 
            this.Recherche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(125)))), ((int)(((byte)(122)))));
            this.Recherche.Location = new System.Drawing.Point(607, 113);
            this.Recherche.Margin = new System.Windows.Forms.Padding(4);
            this.Recherche.Name = "Recherche";
            this.Recherche.Size = new System.Drawing.Size(122, 26);
            this.Recherche.TabIndex = 6;
            this.Recherche.Text = "Recherche";
            this.Recherche.UseVisualStyleBackColor = false;
            this.Recherche.Click += new System.EventHandler(this.Recherche_Click);
            // 
            // Table
            // 
            this.Table.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.nom,
            this.prenom,
            this.Note});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(60)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Table.DefaultCellStyle = dataGridViewCellStyle1;
            this.Table.Location = new System.Drawing.Point(14, 185);
            this.Table.Margin = new System.Windows.Forms.Padding(4);
            this.Table.Name = "Table";
            this.Table.RowHeadersWidth = 51;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(60)))), ((int)(((byte)(64)))));
            this.Table.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Table.RowTemplate.Height = 24;
            this.Table.Size = new System.Drawing.Size(890, 169);
            this.Table.TabIndex = 7;
            this.Table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Code
            // 
            this.Code.HeaderText = "Code";
            this.Code.MinimumWidth = 6;
            this.Code.Name = "Code";
            this.Code.Width = 125;
            // 
            // nom
            // 
            this.nom.HeaderText = "nom";
            this.nom.MinimumWidth = 6;
            this.nom.Name = "nom";
            this.nom.Width = 125;
            // 
            // prenom
            // 
            this.prenom.HeaderText = "prenom";
            this.prenom.MinimumWidth = 6;
            this.prenom.Name = "prenom";
            this.prenom.Width = 125;
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
            this.Moyenne.Location = new System.Drawing.Point(446, 401);
            this.Moyenne.Margin = new System.Windows.Forms.Padding(4);
            this.Moyenne.Name = "Moyenne";
            this.Moyenne.Size = new System.Drawing.Size(112, 25);
            this.Moyenne.TabIndex = 8;
            // 
            // labelMoyenne
            // 
            this.labelMoyenne.AutoSize = true;
            this.labelMoyenne.Location = new System.Drawing.Point(253, 404);
            this.labelMoyenne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMoyenne.Name = "labelMoyenne";
            this.labelMoyenne.Size = new System.Drawing.Size(144, 18);
            this.labelMoyenne.TabIndex = 9;
            this.labelMoyenne.Text = "Moyenne de classe";
            // 
            // Consultation_notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(60)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(900, 506);
            this.Controls.Add(this.labelMoyenne);
            this.Controls.Add(this.Moyenne);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.Recherche);
            this.Controls.Add(this.Niveau);
            this.Controls.Add(this.Matiere);
            this.Controls.Add(this.Filiere);
            this.Controls.Add(this.labelNiveau);
            this.Controls.Add(this.labelMatiere);
            this.Controls.Add(this.labelFiliere);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Consultation_notes";
            this.Text = "Consultation des notes";
            this.Load += new System.EventHandler(this.Consultation_notes_Load);
            this.Resize += new System.EventHandler(this.Consultation_notes_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFiliere;
        private System.Windows.Forms.Label labelMatiere;
        private System.Windows.Forms.Label labelNiveau;
        private System.Windows.Forms.ComboBox Filiere;
        private System.Windows.Forms.ComboBox Matiere;
        private System.Windows.Forms.ComboBox Niveau;
        private System.Windows.Forms.Button Recherche;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.TextBox Moyenne;
        private System.Windows.Forms.Label labelMoyenne;
    }
}