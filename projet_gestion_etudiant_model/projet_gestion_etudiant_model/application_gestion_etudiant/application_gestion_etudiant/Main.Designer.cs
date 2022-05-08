
namespace application_gestion_etudiant
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Gestion_filiere = new System.Windows.Forms.ToolStripMenuItem();
            this.Gestion_Matieres = new System.Windows.Forms.ToolStripMenuItem();
            this.Gestion_etudiants = new System.Windows.Forms.ToolStripMenuItem();
            this.Gestion_notes = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Consultation_notes = new System.Windows.Forms.ToolStripMenuItem();
            this.bilan_annuel = new System.Windows.Forms.ToolStripMenuItem();
            this.bilanAnnuelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(125)))), ((int)(((byte)(122)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionToolStripMenuItem,
            this.affichageToolStripMenuItem,
            this.bilan_annuel});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(900, 50);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Gestion_filiere,
            this.Gestion_Matieres,
            this.Gestion_etudiants,
            this.Gestion_notes});
            this.gestionToolStripMenuItem.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gestionToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.gestionToolStripMenuItem.Text = "Gestion";
            // 
            // Gestion_filiere
            // 
            this.Gestion_filiere.Name = "Gestion_filiere";
            this.Gestion_filiere.Size = new System.Drawing.Size(146, 26);
            this.Gestion_filiere.Text = "Filieres";
            this.Gestion_filiere.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // Gestion_Matieres
            // 
            this.Gestion_Matieres.Name = "Gestion_Matieres";
            this.Gestion_Matieres.Size = new System.Drawing.Size(146, 26);
            this.Gestion_Matieres.Text = "Matieres";
            this.Gestion_Matieres.Click += new System.EventHandler(this.Gestion_Matieres_Click);
            // 
            // Gestion_etudiants
            // 
            this.Gestion_etudiants.Name = "Gestion_etudiants";
            this.Gestion_etudiants.Size = new System.Drawing.Size(146, 26);
            this.Gestion_etudiants.Text = "Etudiants";
            this.Gestion_etudiants.Click += new System.EventHandler(this.Gestion_etudiants_Click);
            // 
            // Gestion_notes
            // 
            this.Gestion_notes.Name = "Gestion_notes";
            this.Gestion_notes.Size = new System.Drawing.Size(146, 26);
            this.Gestion_notes.Text = "Notes";
            // 
            // affichageToolStripMenuItem
            // 
            this.affichageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Consultation_notes});
            this.affichageToolStripMenuItem.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.affichageToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.affichageToolStripMenuItem.Name = "affichageToolStripMenuItem";
            this.affichageToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.affichageToolStripMenuItem.Text = "Affichage";
            // 
            // Consultation_notes
            // 
            this.Consultation_notes.Name = "Consultation_notes";
            this.Consultation_notes.Size = new System.Drawing.Size(231, 26);
            this.Consultation_notes.Text = "Consultation des notes";
            this.Consultation_notes.Click += new System.EventHandler(this.Consultation_notes_Click);
            // 
            // bilan_annuel
            // 
            this.bilan_annuel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bilanAnnuelToolStripMenuItem});
            this.bilan_annuel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bilan_annuel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.bilan_annuel.Name = "bilan_annuel";
            this.bilan_annuel.Size = new System.Drawing.Size(54, 24);
            this.bilan_annuel.Text = "Bilan";
            // 
            // bilanAnnuelToolStripMenuItem
            // 
            this.bilanAnnuelToolStripMenuItem.Name = "bilanAnnuelToolStripMenuItem";
            this.bilanAnnuelToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.bilanAnnuelToolStripMenuItem.Text = "Bilan annuel";
            this.bilanAnnuelToolStripMenuItem.Click += new System.EventHandler(this.bilanAnnuelToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::application_gestion_etudiant.Properties.Resources.vadim_sherbakov_d6ebY_faOO0_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Gestion_filiere;
        private System.Windows.Forms.ToolStripMenuItem Gestion_Matieres;
        private System.Windows.Forms.ToolStripMenuItem Gestion_etudiants;
        private System.Windows.Forms.ToolStripMenuItem Gestion_notes;
        private System.Windows.Forms.ToolStripMenuItem affichageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Consultation_notes;
        private System.Windows.Forms.ToolStripMenuItem bilan_annuel;
        private System.Windows.Forms.ToolStripMenuItem bilanAnnuelToolStripMenuItem;
    }
}

