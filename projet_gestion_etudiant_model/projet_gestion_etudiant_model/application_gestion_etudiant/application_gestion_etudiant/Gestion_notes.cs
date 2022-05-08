
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using application_gestion_etudiant.Models;
using DLL_lib;

namespace application_gestion_etudiant
{
    public partial class Gestion_notes : Form
    {
        private Rectangle labelCodeOriginalRect;
        private Rectangle labelMatiereOriginalRect;
        private Rectangle labelNoteOriginalRect;
        private Rectangle Code_eleveOriginalRect;
        private Rectangle MatiereOriginalRect;
        private Rectangle NoteOriginalRect;
        private Rectangle buttonNouveauOriginalRect;
        private Rectangle buttonAjouterOriginalRect;
        private Rectangle buttonModifierOriginalRect;
        private Rectangle buttonSupprimerOriginalRect;
        private Rectangle buttonRechercherOriginalRect;
        private Size formOriginalSize;

        string code;
        string filiere;
        int niveau;
        public Gestion_notes(string code, string filiere, int niveau)
        {
            this.code = code;
            this.filiere = filiere;
            this.niveau = niveau;
            InitializeComponent();
        }

        public void Initialize()
        {

            Code_eleve.Text = code;
            Note.Text = "";
            Matiere.Items.Clear();
            Matiere matiere = new Matiere();
            Module module = new Module();

            Dictionary<string, object> dictionary1 = new Dictionary<string, object>();

            dictionary1.Add("code_fil", filiere);
            dictionary1.Add("niveau", niveau);

            Dictionary<string, object> dico = new Dictionary<string, object>();

            foreach (Module m in module.Select(dictionary1))
            {
                dico.Add("code_module", m.Code);
                foreach (Matiere mat in matiere.Select(dico))
                {
                    if (mat.Code_module == m.Code)
                    {
                        Matiere.Items.Add(mat.Code);
                    }
                }
                dico.Clear();
            }
        }

        public void Enregister()
        {

            Notes note = new Notes();
            note.Code_eleve = code;
            note.Code_mat = Matiere.Text;
            note.Note = double.Parse(Note.Text);
            MessageBox.Show(note.Note.ToString());
            note.save();
            Initialize();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Matiere_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Gestion_notes_Load(object sender, EventArgs e)
        {
            Initialize();

            formOriginalSize = Size;
            labelCodeOriginalRect = new Rectangle(labelCode.Location.X, labelCode.Location.Y, labelCode.Width, labelCode.Height);
            labelMatiereOriginalRect = new Rectangle(labelMatiere.Location.X, labelMatiere.Location.Y, labelMatiere.Width, labelMatiere.Height);
            labelNoteOriginalRect = new Rectangle(labelNote.Location.X, labelNote.Location.Y, labelNote.Width, labelNote.Height);
           
            Code_eleveOriginalRect = new Rectangle(Code_eleve.Location.X, Code_eleve.Location.Y, Code_eleve.Width, Code_eleve.Height);
           MatiereOriginalRect = new Rectangle(Matiere.Location.X, Matiere.Location.Y, Matiere.Width, Matiere.Height);
            NoteOriginalRect = new Rectangle(Note.Location.X, Note.Location.Y, Note.Width, Note.Height);
            buttonNouveauOriginalRect = new Rectangle(Nouveau.Location.X, Nouveau.Location.Y, Nouveau.Width, Nouveau.Height);
            buttonAjouterOriginalRect = new Rectangle(Ajouter.Location.X, Ajouter.Location.Y, Ajouter.Width, Ajouter.Height);
            buttonModifierOriginalRect = new Rectangle(Modifier.Location.X,Modifier.Location.Y, Modifier.Width,Modifier.Height);
            buttonSupprimerOriginalRect = new Rectangle(Supprimer.Location.X, Supprimer.Location.Y, Supprimer.Width, Supprimer.Height);
            buttonRechercherOriginalRect = new Rectangle(Recherche.Location.X, Recherche.Location.Y, Recherche.Width, Recherche.Height);

        }

        private void resizeChildrenControls()
        {
            resizeControl(labelCodeOriginalRect, labelCode);
            resizeControl(labelMatiereOriginalRect, labelMatiere);
            resizeControl(labelNoteOriginalRect, labelNote);
            resizeControl(Code_eleveOriginalRect, Code_eleve);
            resizeControl(MatiereOriginalRect,Matiere);
            resizeControl(NoteOriginalRect, Note);
            resizeControl(buttonNouveauOriginalRect, Nouveau);
            resizeControl(buttonAjouterOriginalRect,Ajouter);
            resizeControl(buttonModifierOriginalRect,Modifier);
            resizeControl(buttonSupprimerOriginalRect,Supprimer);
            resizeControl(buttonRechercherOriginalRect,Recherche);
       
        }

        private void resizeControl(Rectangle originalControlRect, Control control)
        {
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);
            int newX = (int)(originalControlRect.Location.X * xRatio);
            int newY = (int)(originalControlRect.Location.Y * yRatio);
            int newWidth = (int)(originalControlRect.Width * xRatio);
            int newHeigt = (int)(originalControlRect.Height * yRatio);
            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeigt);
        }

        private void Nouveau_Click(object sender, EventArgs e)
        {
            Initialize();

        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            if (Matiere.Text == "")
            {
                MessageBox.Show("Saisir la matière!");
                return;
            }
            if (Note.Text == "")
            {
                MessageBox.Show("Saisir la note!");
                return;
            }

            string notestring = Note.Text;
            double note;
            bool isParsable = double.TryParse(notestring, out note);
            if (isParsable)
            {
                if (note >= 0 && note <= 20) { }

                else
                {
                    MessageBox.Show("La note doit être >=0 et <=20");
                    return;
                }
            }
            else
            {
                MessageBox.Show("la note doit être un nombre réel");
                return;
            }
            Notes notes = new Notes();
            int index = -1;
            int i = 0;
            foreach (Notes n in notes.All())
            {
                if (n.Code_mat == Matiere.Text && n.Code_eleve == Code_eleve.Text)
                {
                    index = i;
                    break;
                }
                else { i++; }
            }
            if (index != -1)
            {
                MessageBox.Show("Cet Etudiant a une note dans cette matière!");
                return;
            }
            else
            {
                Enregister();
            }


        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            if (Matiere.Text == "")
            {
                MessageBox.Show("Saisir la matière!");
                return;
            }
            if (Note.Text == "")
            {
                MessageBox.Show("Saisir la note!");
                return;
            }

            string notestring = Note.Text;
            double note;
            bool isParsable = double.TryParse(notestring, out note);
            if (isParsable)
            {
                if (note >= 0 && note <= 20) { }

                else
                {
                    MessageBox.Show("La note doit être >=0 et <=20");
                    return;
                }
            }
            else
            {
                MessageBox.Show("la note doit être un nombre réel");
                return;
            }
            Notes notes = new Notes();
            foreach (Notes n in notes.All())
            {
                if (n.Code_mat == Matiere.Text && n.Code_eleve == Code_eleve.Text)
                {
                    n.Code_mat = Matiere.Text;
                    n.Code_eleve = Code_eleve.Text;
                    n.Note = double.Parse(Note.Text);
                    n.save("Modifier");
                    Initialize();
                    return;
                }
            }
            MessageBox.Show("Cet Etudiant n'a pas une note dans cette matière!");
            return;
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            if (Matiere.Text == "")
            {
                MessageBox.Show("Saisir la matière!");
                return;
            }

            int index = -1;
            Notes notes = new Notes();
            int i = 0;
            foreach (Notes n in notes.All())
            {
                if (n.Code_mat == Matiere.Text && n.Code_eleve == Code_eleve.Text)
                {
                    index = i;
                    n.delete();
                    break;
                }
                else { i++; }
            }
            if (index == -1)
            {
                MessageBox.Show("Cet Etudiant n'a pas de note dans cette matière!");
                return;
            }

            Initialize();
        }

        private void Recherche_Click(object sender, EventArgs e)
        {
            if (Matiere.Text == "")
            {
                MessageBox.Show("Saisir la matière!");
                return;
            }

            int index = -1;
            int i = 0;
            Notes notes = new Notes();
            foreach (Notes n in notes.All())
            {
                if (n.Code_mat == Matiere.Text && n.Code_eleve == Code_eleve.Text)
                {
                    index = i;
                    break;
                }
                else { i++; }
            }
            if (index == -1)
            {
                MessageBox.Show("Cet Etudiant n'a pas de note dans cette matière!");
                return;
            }
            else
            {
                
                double note = notes.All()[i].Note;
                Note.Text = note.ToString();
                MessageBox.Show(" la note de l'etudiant est : " + Note.Text);
            }

            
        }

        private void Modifier_KeyPress(object sender, KeyPressEventArgs e)
        {

            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void Gestion_notes_Resize(object sender, EventArgs e)
        {
            resizeChildrenControls();
        }
    }
}
