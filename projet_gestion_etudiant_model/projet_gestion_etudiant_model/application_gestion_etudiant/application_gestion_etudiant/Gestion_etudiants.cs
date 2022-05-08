using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using application_gestion_etudiant.Models;
using DLL_lib;
using System.Data.SqlClient;
using System.Data.Common;

namespace application_gestion_etudiant
{
    public partial class Gestion_etudiants : Form
    {
        private Rectangle labelCodeOriginalRect;
        private Rectangle labelNomOriginalRect;
        private Rectangle labelPrenomOriginalRect;
        private Rectangle labelNiveauOriginalRect;
        private Rectangle labelFiliereOriginalRect;
        private Rectangle textBoxCodeOriginalRect;
        private Rectangle textBoxNomOriginalRect;
        private Rectangle textBoxPrenomOriginalRect;
        private Rectangle comboBoxFiliereOriginalRect;
        private Rectangle comboBoxNiveauOriginalRect;
        private Rectangle buttonNouveauOriginalRect;
        private Rectangle buttonAjouterOriginalRect;
        private Rectangle buttonModifierOriginalRect;
        private Rectangle buttonSupprimerOriginalRect;
        private Rectangle buttonRechercherOriginalRect;
        private Rectangle buttonGestion_notesOriginalRect;
        private Rectangle datagridOriginalRect;
        private Rectangle checkCodeOriginalRect;
        private Rectangle checkNomOriginalRect;
        private Rectangle checkPrenomOriginalRect;
        private Rectangle checkFiliereOriginalRect;
        private Rectangle checkNiveauOriginalRect;
        private Size formOriginalSize;


        public void Initialize()
        {
            Eleve eleve = new Eleve();
            List<dynamic> eleves = new List<dynamic>();
            eleves = eleve.All();
            gridEleves.DataSource = eleves;
            textCode.Text = "";
            textNom.Text = "";
            textPrenom.Text = "";
        }

        public Gestion_etudiants()
        {
            
            InitializeComponent();
        }


        private void Gestion_etudiants_Load(object sender, EventArgs e)
        {


            formOriginalSize = Size;

            labelCodeOriginalRect = new Rectangle(labelCode.Location.X, labelCode.Location.Y, labelCode.Width, labelCode.Height);
            labelNomOriginalRect = new Rectangle(labelNom.Location.X, labelNom.Location.Y, labelNom.Width, labelNom.Height);
            labelPrenomOriginalRect = new Rectangle(labelPrenom.Location.X, labelPrenom.Location.Y, labelPrenom.Width, labelPrenom.Height);
            labelFiliereOriginalRect = new Rectangle(labelFiliere.Location.X, labelFiliere.Location.Y, labelFiliere.Width, labelFiliere.Height);
            labelNiveauOriginalRect = new Rectangle(labelNiveau.Location.X, labelNiveau.Location.Y, labelNiveau.Width, labelNiveau.Height);
            checkCodeOriginalRect = new Rectangle(checkCode.Location.X, checkCode.Location.Y, checkCode.Width, checkCode.Height);
            checkNomOriginalRect = new Rectangle(checkNom.Location.X, checkNom.Location.Y, checkNom.Width, checkNom.Height);
            checkPrenomOriginalRect = new Rectangle(checkPrenom.Location.X, checkPrenom.Location.Y, checkPrenom.Width, checkPrenom.Height);
            checkNiveauOriginalRect = new Rectangle(checkNiveau.Location.X, checkNiveau.Location.Y, checkNiveau.Width, checkNiveau.Height);
            checkFiliereOriginalRect = new Rectangle(checkFiliere.Location.X, checkFiliere.Location.Y, checkFiliere.Width, checkFiliere.Height);
            comboBoxFiliereOriginalRect = new Rectangle(comboFiliere.Location.X, comboFiliere.Location.Y, comboFiliere.Width, comboFiliere.Height);
            comboBoxNiveauOriginalRect = new Rectangle(comboNiveau.Location.X, comboNiveau.Location.Y, comboNiveau.Width, comboNiveau.Height);
            textBoxCodeOriginalRect = new Rectangle(textCode.Location.X, textCode.Location.Y, textCode.Width, textCode.Height);
            textBoxNomOriginalRect = new Rectangle(textNom.Location.X, textNom.Location.Y, textNom.Width, textNom.Height);
            textBoxPrenomOriginalRect = new Rectangle(textPrenom.Location.X, textPrenom.Location.Y, textPrenom.Width, textPrenom.Height);
            buttonNouveauOriginalRect = new Rectangle(buttonNouveau.Location.X, buttonNouveau.Location.Y, buttonNouveau.Width, buttonNouveau.Height);
            buttonAjouterOriginalRect = new Rectangle(buttonAjouter.Location.X, buttonAjouter.Location.Y, buttonAjouter.Width, buttonAjouter.Height);
            buttonModifierOriginalRect = new Rectangle(buttonModifier.Location.X, buttonModifier.Location.Y, buttonModifier.Width, buttonModifier.Height);
            buttonSupprimerOriginalRect = new Rectangle(buttonSupprimer.Location.X, buttonSupprimer.Location.Y, buttonSupprimer.Width, buttonSupprimer.Height);
            buttonRechercherOriginalRect = new Rectangle(buttonRechercher.Location.X, buttonRechercher.Location.Y, buttonRechercher.Width, buttonRechercher.Height);
            buttonGestion_notesOriginalRect = new Rectangle(buttonGestionNotes.Location.X, buttonGestionNotes.Location.Y, buttonGestionNotes.Width, buttonGestionNotes.Height);
            datagridOriginalRect = new Rectangle(gridEleves.Location.X, gridEleves.Location.Y, gridEleves.Width, gridEleves.Height);


            Eleve eleve = new Eleve();
            List<dynamic> eleves = new List<dynamic>();
            eleves = eleve.All();
            gridEleves.DataSource = eleves;
            gridEleves.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridEleves.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridEleves.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridEleves.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridEleves.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridEleves.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Now that DataGridView has calculated it's Widths; we can now store each column Width values.
            for (int i = 0; i <= gridEleves.Columns.Count - 1; i++)
            {
                // Store Auto Sized Widths:
                int colw = gridEleves.Columns[i].Width;

                // Remove AutoSizing:
                gridEleves.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                // Set Width to calculated AutoSize value:
                gridEleves.Columns[i].Width = colw;
            }

            textCode.Text = "";
            textNom.Text = "";
            textPrenom.Text = "";
        }

        private void resizeChildrenControls()
        {
            resizeControl(labelNiveauOriginalRect, labelNiveau);
            resizeControl(labelFiliereOriginalRect, labelFiliere);
            resizeControl(labelNomOriginalRect, labelNom);
            resizeControl(labelPrenomOriginalRect, labelPrenom);
            resizeControl(labelCodeOriginalRect, labelCode);

            resizeControl(checkNiveauOriginalRect, checkNiveau);
            resizeControl(checkFiliereOriginalRect, checkFiliere);
            resizeControl(checkNomOriginalRect, checkNom);
            resizeControl(checkPrenomOriginalRect, checkPrenom);
            resizeControl(checkCodeOriginalRect, checkCode);

            resizeControl(datagridOriginalRect, gridEleves);
           
            resizeControl(buttonNouveauOriginalRect, buttonNouveau);
            resizeControl(buttonAjouterOriginalRect, buttonAjouter);
            resizeControl(buttonModifierOriginalRect, buttonModifier);
            resizeControl(buttonSupprimerOriginalRect, buttonSupprimer);
            resizeControl(buttonRechercherOriginalRect, buttonRechercher);
            resizeControl(buttonGestion_notesOriginalRect, buttonGestionNotes);

            resizeControl(textBoxCodeOriginalRect, textCode);
            resizeControl(textBoxNomOriginalRect, textNom);
            resizeControl(textBoxPrenomOriginalRect, textPrenom);
            resizeControl(comboBoxFiliereOriginalRect, comboFiliere);
            resizeControl(comboBoxNiveauOriginalRect, comboNiveau);
        }

        private void resizeControl(Rectangle originalControlRect, Control control)
        {
            float xRatio = (float)(this.Width) /(float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);
            int newX = (int)(originalControlRect.Location.X * xRatio);
            int newY = (int)(originalControlRect.Location.Y * yRatio);
            int newWidth = (int)(originalControlRect.Width * xRatio);
            int newHeigt = (int)(originalControlRect.Height * yRatio);
            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeigt);
        }

        private void buttonNouveau_Click(object sender, EventArgs e)
        {
            Initialize();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            if (textCode.Text == "" || textNom.Text == "" || textPrenom.Text == "" || comboFiliere.Text == "" || comboNiveau.Text == "")
            {
                MessageBox.Show("Veuillez Remplir tout les champs");
                return;
            }
            Eleve etudiant = new Eleve();
            etudiant.Id = 0;
            etudiant.Code = textCode.Text;
            etudiant.Nom = textNom.Text;
            etudiant.Prenom = textPrenom.Text;
            etudiant.Code_fil = comboFiliere.Text;
            etudiant.Niveau = Convert.ToInt32(comboNiveau.Text);
            try
            {
                etudiant.save();
            }catch (DbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            Initialize();
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {

            if (textCode.Text == "")
            {
                MessageBox.Show("Veuillez entrer un code pour la recherche");
                return;
            }
            Eleve eleve = new Eleve();
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("Code", textCode.Text);
            List<dynamic> liste = eleve.Select(dictionary);
            if (liste.Count == 0)
            {
                MessageBox.Show("Eleve n'existe pas");
                return;
            }
            dictionary.Add("Nom", textNom.Text);
            dictionary.Add("Prenom", textPrenom.Text);
            dictionary.Add("Code_fil", comboFiliere.Text);
            dictionary.Add("Niveau", Convert.ToInt32(comboNiveau.Text));
            dictionary.Add("Id", liste[0].Id);
            if (textNom.Text == "")
            {
                dictionary["Nom"] = liste[0].Nom;
            }
            if (textPrenom.Text == "")
            {
                dictionary["Prenom"] = liste[0].Prenom;
            }
            if (comboNiveau.Text == "")
            {
                dictionary["Niveau"] = liste[0].Niveau;
            }
            if (comboFiliere.Text == "")
            {
                dictionary["Code_fil"] = liste[0].Code_fil;
            }
            eleve = eleve.DictionaryToObject(dictionary);

            eleve.save();
            Initialize();
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (textCode.Text == "")
            {
                MessageBox.Show("Le champs code est vide");
                return;
            }
            Eleve eleve = new Eleve();
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("Code", textCode.Text);
            List<dynamic> liste = eleve.Select(dictionary);

            if (liste.Count == 0)
            {
                MessageBox.Show("utilisateur n'existe pas");
                return;
            }
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult choix = MessageBox.Show("voulez vous vraiment supprimer cette eleve avec le code: "
                + textCode.Text, "Alert", buttons);
            if (choix == DialogResult.No)
            {
                return;
            }
            liste[0].delete();
            Initialize();
        }

        private void buttonRechercher_Click(object sender, EventArgs e)
        {
            Dictionary<string, dynamic> data = new Dictionary<string, dynamic>();
            if (checkNom.Checked)
            {
                if (textNom.Text == "")
                {
                    MessageBox.Show("veuillez remplir tous les champs chochee");
                    return;
                }
                else
                {
                    data.Add("nom", textNom.Text);
                }
            }
            if (checkNom.Checked)
            {
                if (textPrenom.Text == "")
                {
                    MessageBox.Show("veuillez remplir tous les champs chochee");
                    return;
                }
                else
                {
                    data.Add("prenom", textPrenom.Text);
                }
            }
            if (checkCode.Checked)
            {
                if (textCode.Text == "")
                {
                    MessageBox.Show("veuillez remplir tous les champs chochee");
                    return;
                }
                else
                {
                    data.Add("code", textCode.Text);
                }
            }
            if (checkNiveau.Checked)
            {
                if (comboNiveau.Text == "")
                {
                    MessageBox.Show("veuillez remplir tous les champs chochee");
                    return;
                }
                else
                {
                    data.Add("niveau", Convert.ToInt32(comboNiveau.Text));

                }
            }
            if (checkFiliere.Checked)
            {
                if (comboFiliere.Text == "")
                {
                    MessageBox.Show("veuillez remplir tous les champs chochee");
                    return;
                }
                else
                {
                    data.Add("code_fil", comboFiliere.Text);
                }
            }
            List<dynamic> eleves = new List<dynamic>();
            Eleve eleve = new Eleve();
            eleves = eleve.Select(data);
            gridEleves.DataSource = eleves;
        }

        private void buttonGestionNotes_Click(object sender, EventArgs e)
        {

            if (textCode.Text == null)
            {
                MessageBox.Show("entrer un code d'eleves");
            }
            else
            {
                Dictionary<string, object> dico = new Dictionary<string, object>();
                dico.Add("Code", textCode.Text);
                Eleve el = new Eleve();
                List<dynamic> eleves = el.Select(dico);
                

                if (eleves.Count == 0)
                {
                    MessageBox.Show("l'etudiant n'existe pas");
                }
                else
                {
                    new Gestion_notes(textCode.Text,comboFiliere.Text,Convert.ToInt32(comboNiveau.Text)).Show();

                }
            }
        }

        private void Gestion_etudiants_Resize(object sender, EventArgs e)
        {
            resizeChildrenControls();
            gridEleves.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridEleves.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridEleves.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridEleves.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridEleves.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridEleves.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Now that DataGridView has calculated it's Widths; we can now store each column Width values.
            for (int i = 0; i <= gridEleves.Columns.Count - 1; i++)
            {
                // Store Auto Sized Widths:
                int colw = gridEleves.Columns[i].Width;

                // Remove AutoSizing:
                gridEleves.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                // Set Width to calculated AutoSize value:
                gridEleves.Columns[i].Width = colw;
            }

        }

        private void checkFiliere_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gridEleves_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboNiveau_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboFiliere_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboNiveau.Items.Clear();
            comboNiveau.Items.Add("1");
            comboNiveau.Items.Add("2");
            if (comboFiliere.Text != "AP")
            {
                comboNiveau.Items.Add("3");
            }
        }
    }
}
