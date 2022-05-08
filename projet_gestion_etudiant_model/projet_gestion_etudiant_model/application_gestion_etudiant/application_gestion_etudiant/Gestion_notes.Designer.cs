
namespace application_gestion_etudiant
{
    partial class Gestion_notes
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
            this.labelCode = new System.Windows.Forms.Label();
            this.labelMatiere = new System.Windows.Forms.Label();
            this.labelNote = new System.Windows.Forms.Label();
            this.Code_eleve = new System.Windows.Forms.TextBox();
            this.Note = new System.Windows.Forms.TextBox();
            this.Nouveau = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.Recherche = new System.Windows.Forms.Button();
            this.Matiere = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.labelCode.Location = new System.Drawing.Point(88, 49);
            this.labelCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(90, 18);
            this.labelCode.TabIndex = 0;
            this.labelCode.Text = "Code eleve";
            this.labelCode.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelMatiere
            // 
            this.labelMatiere.AutoSize = true;
            this.labelMatiere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.labelMatiere.Location = new System.Drawing.Point(88, 100);
            this.labelMatiere.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMatiere.Name = "labelMatiere";
            this.labelMatiere.Size = new System.Drawing.Size(62, 18);
            this.labelMatiere.TabIndex = 1;
            this.labelMatiere.Text = "Matiere";
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.labelNote.Location = new System.Drawing.Point(88, 158);
            this.labelNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(42, 18);
            this.labelNote.TabIndex = 2;
            this.labelNote.Text = "Note";
            // 
            // Code_eleve
            // 
            this.Code_eleve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.Code_eleve.Location = new System.Drawing.Point(275, 43);
            this.Code_eleve.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Code_eleve.Name = "Code_eleve";
            this.Code_eleve.Size = new System.Drawing.Size(112, 25);
            this.Code_eleve.TabIndex = 3;
            // 
            // Note
            // 
            this.Note.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.Note.Location = new System.Drawing.Point(275, 158);
            this.Note.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(112, 25);
            this.Note.TabIndex = 5;
            // 
            // Nouveau
            // 
            this.Nouveau.Location = new System.Drawing.Point(472, 41);
            this.Nouveau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Nouveau.Name = "Nouveau";
            this.Nouveau.Size = new System.Drawing.Size(85, 26);
            this.Nouveau.TabIndex = 6;
            this.Nouveau.Text = "nouveau";
            this.Nouveau.UseVisualStyleBackColor = true;
            this.Nouveau.Click += new System.EventHandler(this.Nouveau_Click);
            // 
            // Ajouter
            // 
            this.Ajouter.Location = new System.Drawing.Point(472, 100);
            this.Ajouter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(85, 26);
            this.Ajouter.TabIndex = 7;
            this.Ajouter.Text = "ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // Modifier
            // 
            this.Modifier.Location = new System.Drawing.Point(472, 158);
            this.Modifier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(85, 26);
            this.Modifier.TabIndex = 8;
            this.Modifier.Text = "modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            this.Modifier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Modifier_KeyPress);
            // 
            // Supprimer
            // 
            this.Supprimer.Location = new System.Drawing.Point(670, 41);
            this.Supprimer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(85, 26);
            this.Supprimer.TabIndex = 9;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // Recherche
            // 
            this.Recherche.Location = new System.Drawing.Point(670, 97);
            this.Recherche.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Recherche.Name = "Recherche";
            this.Recherche.Size = new System.Drawing.Size(85, 26);
            this.Recherche.TabIndex = 10;
            this.Recherche.Text = "Recherche";
            this.Recherche.UseVisualStyleBackColor = true;
            this.Recherche.Click += new System.EventHandler(this.Recherche_Click);
            // 
            // Matiere
            // 
            this.Matiere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.Matiere.FormattingEnabled = true;
            this.Matiere.Location = new System.Drawing.Point(275, 100);
            this.Matiere.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Matiere.Name = "Matiere";
            this.Matiere.Size = new System.Drawing.Size(135, 26);
            this.Matiere.TabIndex = 11;
            this.Matiere.SelectedIndexChanged += new System.EventHandler(this.Matiere_SelectedIndexChanged);
            // 
            // Gestion_notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(125)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(900, 506);
            this.Controls.Add(this.Matiere);
            this.Controls.Add(this.Recherche);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.Nouveau);
            this.Controls.Add(this.Note);
            this.Controls.Add(this.Code_eleve);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.labelMatiere);
            this.Controls.Add(this.labelCode);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Gestion_notes";
            this.Text = "Gestion des notes";
            this.Load += new System.EventHandler(this.Gestion_notes_Load);
            this.Resize += new System.EventHandler(this.Gestion_notes_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.Label labelMatiere;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.TextBox Code_eleve;
        private System.Windows.Forms.TextBox Note;
        private System.Windows.Forms.Button Nouveau;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Button Recherche;
        private System.Windows.Forms.ComboBox Matiere;
    }
}