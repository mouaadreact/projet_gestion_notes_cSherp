
namespace application_gestion_etudiant
{
    partial class Gestion_etudiants
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelCode = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelFiliere = new System.Windows.Forms.Label();
            this.labelNiveau = new System.Windows.Forms.Label();
            this.textCode = new System.Windows.Forms.TextBox();
            this.textNom = new System.Windows.Forms.TextBox();
            this.textPrenom = new System.Windows.Forms.TextBox();
            this.comboFiliere = new System.Windows.Forms.ComboBox();
            this.comboNiveau = new System.Windows.Forms.ComboBox();
            this.buttonNouveau = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.buttonGestionNotes = new System.Windows.Forms.Button();
            this.checkNiveau = new System.Windows.Forms.CheckBox();
            this.checkCode = new System.Windows.Forms.CheckBox();
            this.checkPrenom = new System.Windows.Forms.CheckBox();
            this.checkNom = new System.Windows.Forms.CheckBox();
            this.checkFiliere = new System.Windows.Forms.CheckBox();
            this.gridEleves = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridEleves)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.labelCode.Location = new System.Drawing.Point(108, 7);
            this.labelCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(46, 18);
            this.labelCode.TabIndex = 0;
            this.labelCode.Text = "Code";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.labelNom.Location = new System.Drawing.Point(108, 43);
            this.labelNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(40, 18);
            this.labelNom.TabIndex = 1;
            this.labelNom.Text = "Nom";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPrenom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.labelPrenom.Location = new System.Drawing.Point(108, 86);
            this.labelPrenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(63, 18);
            this.labelPrenom.TabIndex = 2;
            this.labelPrenom.Text = "Prenom";
            // 
            // labelFiliere
            // 
            this.labelFiliere.AutoSize = true;
            this.labelFiliere.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFiliere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.labelFiliere.Location = new System.Drawing.Point(108, 130);
            this.labelFiliere.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFiliere.Name = "labelFiliere";
            this.labelFiliere.Size = new System.Drawing.Size(53, 18);
            this.labelFiliere.TabIndex = 3;
            this.labelFiliere.Text = "Filiere";
            // 
            // labelNiveau
            // 
            this.labelNiveau.AutoSize = true;
            this.labelNiveau.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNiveau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.labelNiveau.Location = new System.Drawing.Point(113, 170);
            this.labelNiveau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNiveau.Name = "labelNiveau";
            this.labelNiveau.Size = new System.Drawing.Size(58, 18);
            this.labelNiveau.TabIndex = 4;
            this.labelNiveau.Text = "Niveau";
            // 
            // textCode
            // 
            this.textCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.textCode.Location = new System.Drawing.Point(225, 7);
            this.textCode.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textCode.Name = "textCode";
            this.textCode.Size = new System.Drawing.Size(243, 25);
            this.textCode.TabIndex = 5;
            // 
            // textNom
            // 
            this.textNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.textNom.Location = new System.Drawing.Point(225, 43);
            this.textNom.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(243, 25);
            this.textNom.TabIndex = 6;
            // 
            // textPrenom
            // 
            this.textPrenom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.textPrenom.Location = new System.Drawing.Point(225, 86);
            this.textPrenom.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textPrenom.Name = "textPrenom";
            this.textPrenom.Size = new System.Drawing.Size(243, 25);
            this.textPrenom.TabIndex = 7;
            // 
            // comboFiliere
            // 
            this.comboFiliere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.comboFiliere.FormattingEnabled = true;
            this.comboFiliere.Items.AddRange(new object[] {
            "AP",
            "GIL",
            "GINF",
            "G3EI",
            "GSTR",
            "GSEA"});
            this.comboFiliere.Location = new System.Drawing.Point(225, 122);
            this.comboFiliere.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.comboFiliere.Name = "comboFiliere";
            this.comboFiliere.Size = new System.Drawing.Size(243, 26);
            this.comboFiliere.TabIndex = 9;
            this.comboFiliere.SelectedIndexChanged += new System.EventHandler(this.comboFiliere_SelectedIndexChanged);
            // 
            // comboNiveau
            // 
            this.comboNiveau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.comboNiveau.FormattingEnabled = true;
            this.comboNiveau.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboNiveau.Location = new System.Drawing.Point(225, 163);
            this.comboNiveau.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.comboNiveau.Name = "comboNiveau";
            this.comboNiveau.Size = new System.Drawing.Size(243, 26);
            this.comboNiveau.TabIndex = 10;
            this.comboNiveau.SelectedIndexChanged += new System.EventHandler(this.comboNiveau_SelectedIndexChanged);
            // 
            // buttonNouveau
            // 
            this.buttonNouveau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(125)))), ((int)(((byte)(122)))));
            this.buttonNouveau.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonNouveau.Location = new System.Drawing.Point(748, 11);
            this.buttonNouveau.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonNouveau.Name = "buttonNouveau";
            this.buttonNouveau.Size = new System.Drawing.Size(162, 26);
            this.buttonNouveau.TabIndex = 11;
            this.buttonNouveau.Text = "Nouveau";
            this.buttonNouveau.UseVisualStyleBackColor = false;
            this.buttonNouveau.Click += new System.EventHandler(this.buttonNouveau_Click);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(125)))), ((int)(((byte)(122)))));
            this.buttonAjouter.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAjouter.Location = new System.Drawing.Point(748, 43);
            this.buttonAjouter.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(162, 24);
            this.buttonAjouter.TabIndex = 12;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = false;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(125)))), ((int)(((byte)(122)))));
            this.buttonModifier.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonModifier.Location = new System.Drawing.Point(748, 80);
            this.buttonModifier.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(162, 24);
            this.buttonModifier.TabIndex = 13;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = false;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(125)))), ((int)(((byte)(122)))));
            this.buttonSupprimer.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSupprimer.Location = new System.Drawing.Point(748, 110);
            this.buttonSupprimer.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(162, 25);
            this.buttonSupprimer.TabIndex = 14;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = false;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(125)))), ((int)(((byte)(122)))));
            this.buttonRechercher.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRechercher.Location = new System.Drawing.Point(748, 140);
            this.buttonRechercher.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(162, 26);
            this.buttonRechercher.TabIndex = 15;
            this.buttonRechercher.Text = "Rechercher";
            this.buttonRechercher.UseVisualStyleBackColor = false;
            this.buttonRechercher.Click += new System.EventHandler(this.buttonRechercher_Click);
            // 
            // buttonGestionNotes
            // 
            this.buttonGestionNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(125)))), ((int)(((byte)(122)))));
            this.buttonGestionNotes.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonGestionNotes.Location = new System.Drawing.Point(748, 172);
            this.buttonGestionNotes.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonGestionNotes.Name = "buttonGestionNotes";
            this.buttonGestionNotes.Size = new System.Drawing.Size(162, 24);
            this.buttonGestionNotes.TabIndex = 16;
            this.buttonGestionNotes.Text = "Gestion notes";
            this.buttonGestionNotes.UseVisualStyleBackColor = false;
            this.buttonGestionNotes.Click += new System.EventHandler(this.buttonGestionNotes_Click);
            // 
            // checkNiveau
            // 
            this.checkNiveau.AutoSize = true;
            this.checkNiveau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.checkNiveau.Location = new System.Drawing.Point(589, 163);
            this.checkNiveau.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.checkNiveau.Name = "checkNiveau";
            this.checkNiveau.Size = new System.Drawing.Size(18, 17);
            this.checkNiveau.TabIndex = 22;
            this.checkNiveau.UseVisualStyleBackColor = false;
            // 
            // checkCode
            // 
            this.checkCode.AutoSize = true;
            this.checkCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.checkCode.Location = new System.Drawing.Point(589, 10);
            this.checkCode.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.checkCode.Name = "checkCode";
            this.checkCode.Size = new System.Drawing.Size(18, 17);
            this.checkCode.TabIndex = 18;
            this.checkCode.UseVisualStyleBackColor = false;
            // 
            // checkPrenom
            // 
            this.checkPrenom.AutoSize = true;
            this.checkPrenom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.checkPrenom.Location = new System.Drawing.Point(589, 86);
            this.checkPrenom.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.checkPrenom.Name = "checkPrenom";
            this.checkPrenom.Size = new System.Drawing.Size(18, 17);
            this.checkPrenom.TabIndex = 19;
            this.checkPrenom.UseVisualStyleBackColor = false;
            // 
            // checkNom
            // 
            this.checkNom.AutoSize = true;
            this.checkNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.checkNom.Location = new System.Drawing.Point(589, 43);
            this.checkNom.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.checkNom.Name = "checkNom";
            this.checkNom.Size = new System.Drawing.Size(18, 17);
            this.checkNom.TabIndex = 20;
            this.checkNom.UseVisualStyleBackColor = false;
            // 
            // checkFiliere
            // 
            this.checkFiliere.AutoSize = true;
            this.checkFiliere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.checkFiliere.Location = new System.Drawing.Point(589, 122);
            this.checkFiliere.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.checkFiliere.Name = "checkFiliere";
            this.checkFiliere.Size = new System.Drawing.Size(18, 17);
            this.checkFiliere.TabIndex = 21;
            this.checkFiliere.UseVisualStyleBackColor = false;
            this.checkFiliere.CheckedChanged += new System.EventHandler(this.checkFiliere_CheckedChanged);
            // 
            // gridEleves
            // 
            this.gridEleves.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.gridEleves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEleves.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gridEleves.Location = new System.Drawing.Point(14, 216);
            this.gridEleves.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gridEleves.Name = "gridEleves";
            this.gridEleves.RowHeadersWidth = 51;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(125)))), ((int)(((byte)(122)))));
            this.gridEleves.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridEleves.RowTemplate.Height = 29;
            this.gridEleves.Size = new System.Drawing.Size(1009, 272);
            this.gridEleves.TabIndex = 17;
            this.gridEleves.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEleves_CellContentClick);
            // 
            // Gestion_etudiants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(60)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1036, 499);
            this.Controls.Add(this.checkNiveau);
            this.Controls.Add(this.checkFiliere);
            this.Controls.Add(this.checkNom);
            this.Controls.Add(this.checkPrenom);
            this.Controls.Add(this.checkCode);
            this.Controls.Add(this.gridEleves);
            this.Controls.Add(this.buttonGestionNotes);
            this.Controls.Add(this.buttonRechercher);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.buttonNouveau);
            this.Controls.Add(this.comboNiveau);
            this.Controls.Add(this.comboFiliere);
            this.Controls.Add(this.textPrenom);
            this.Controls.Add(this.textNom);
            this.Controls.Add(this.textCode);
            this.Controls.Add(this.labelNiveau);
            this.Controls.Add(this.labelFiliere);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.labelCode);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(230)))), ((int)(((byte)(219)))));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Gestion_etudiants";
            this.Text = "Gestion_etudiants";
            this.Load += new System.EventHandler(this.Gestion_etudiants_Load);
            this.Resize += new System.EventHandler(this.Gestion_etudiants_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.gridEleves)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelFiliere;
        private System.Windows.Forms.Label labelNiveau;
        private System.Windows.Forms.TextBox textCode;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.TextBox textPrenom;
        private System.Windows.Forms.ComboBox comboFiliere;
        private System.Windows.Forms.ComboBox comboNiveau;
        private System.Windows.Forms.Button buttonNouveau;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonRechercher;
        private System.Windows.Forms.Button buttonGestionNotes;
        private System.Windows.Forms.CheckBox checkNiveau;
        private System.Windows.Forms.CheckBox checkCode;
        private System.Windows.Forms.CheckBox checkPrenom;
        private System.Windows.Forms.CheckBox checkNom;
        private System.Windows.Forms.CheckBox checkFiliere;
        private System.Windows.Forms.DataGridView gridEleves;
    }
}