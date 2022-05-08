using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using application_gestion_etudiant.Models;

namespace application_gestion_etudiant
{
    public partial class Consultation_notes : Form
    {
        private Rectangle labelFiliereOriginalRect;
        private Rectangle labelMatiereOriginalRect;
        private Rectangle labelNiveauOriginalRect;
        private Rectangle labelMoyenneOriginalRect;
        private Rectangle FiliereOriginalRect;
        private Rectangle MatiereOriginalRect;
        private Rectangle NiveauOriginalRect;
        private Rectangle MoyenneOriginalRect;
        private Rectangle RechercheOriginalRect;
        private Rectangle TableOriginalRect;
        private Size formOriginalSize;

        Dictionary<string, string> list_code_matiere = new Dictionary<string, string>();
        public Consultation_notes()
        {
            InitializeComponent();
            // Charger();
            Filiere.Items.Clear();
            Filiere ele_filiere = new Filiere();
            List<dynamic> List_filiere = ele_filiere.All();
            foreach (Filiere fil in List_filiere)
            {
                Filiere.Items.Add(fil.Code);
            }




        }

        private void Recherche_Click(object sender, EventArgs e)
        {
            if (!Matiere.Text.Equals(""))
            {
                Moyenne.Text = "";
                Table.Rows.Clear();
                Eleve ele_eleve = new Eleve();
                Notes ele_notes = new Notes();


                List<dynamic> List_eleve = ele_eleve.All();
                List<dynamic> List_notes = ele_notes.All();
                int i = 0;
                double sum = 0;

                foreach (Notes n in List_notes)
                {
                    foreach (Eleve el in List_eleve)
                    {
                        if (n.Code_eleve.Equals(el.Code) == true && n.Code_mat.Equals(list_code_matiere[Matiere.Text]))
                        {

                            Table.Rows.Add();
                            Table.Rows[i].Cells[0].Value = el.Code;
                            Table.Rows[i].Cells[1].Value = el.Nom;
                            Table.Rows[i].Cells[2].Value = el.Prenom;
                            Table.Rows[i].Cells[3].Value = n.Note;
                            sum += n.Note;
                            i++;
                        }

                    }
                }

                sum /= i;
                Moyenne.Text = sum.ToString();
            }


        }

        private void Filiere_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Filiere.Text.Equals(""))
            {
                Moyenne.Text = "";
                Table.Rows.Clear();
                Niveau.Text = "";
                Matiere.Text = "";
                Niveau.Items.Clear();
                Matiere.Items.Clear();
                if (Filiere.Text.Equals("AP"))
                {
                    Niveau.Items.AddRange(new object[] { 1, 2 });
                }
                else
                {
                    Niveau.Items.AddRange(new object[] { 1, 2, 3 });

                }


            }
        }

        private void Niveau_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (!Niveau.Text.Equals(""))
            {
                Moyenne.Text = "";
                Table.Rows.Clear();
                Matiere.Text = "";
                Matiere.Items.Clear();
                list_code_matiere.Clear();

                Filiere ele_filiere = new Filiere();
                List<dynamic> List_filiere = ele_filiere.All();

                Module ele_module = new Module();
                List<dynamic> List_module = ele_module.All();

                Matiere ele_matiere = new Matiere();
                List<dynamic> List_matiere = ele_matiere.All();

                foreach (Filiere f in List_filiere)
                {
                    foreach (Module mo in List_module)
                    {
                        if (f.Code.Equals(mo.Code_fil) == true && f.Code.Equals(Filiere.Text) == true && mo.Niveau == Int32.Parse(Niveau.Text))
                        {
                            foreach (Matiere ma in List_matiere)
                            {
                                if (ma.Code_module.Equals(mo.Code))
                                {
                                    Matiere.Items.Add(ma.Designation);
                                    list_code_matiere.Add(ma.Designation, ma.Code);
                                }

                            }

                        }
                    }
                }



            }




        }

        //----------------------------------------------------------------------------
        private void Charger()
        {

            Table.Rows.Clear();
            Eleve ele_eleve = new Eleve();
            Notes ele_notes = new Notes();


            List<dynamic> List_eleve = ele_eleve.All();
            List<dynamic> List_notes = ele_notes.All();
            int i = 0;


            foreach (Notes n in List_notes)
            {
                foreach (Eleve el in List_eleve)
                {
                    if (n.Code_eleve.Equals(el.Code))
                    {

                        Table.Rows.Add();
                        Table.Rows[i].Cells[0].Value = el.Code;
                        Table.Rows[i].Cells[1].Value = el.Nom;
                        Table.Rows[i].Cells[2].Value = el.Prenom;
                        Table.Rows[i].Cells[3].Value = n.Note;

                        i++;
                    }

                }
            }





        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Charger();
        }

        private void Consultation_notes_Load(object sender, EventArgs e)
        {
            formOriginalSize = Size;
            labelMatiereOriginalRect = new Rectangle(labelMatiere.Location.X, labelMatiere.Location.Y, labelMatiere.Width, labelMatiere.Height);
            labelNiveauOriginalRect = new Rectangle(labelNiveau.Location.X, labelNiveau.Location.Y, labelNiveau.Width, labelNiveau.Height);
            labelFiliereOriginalRect = new Rectangle(labelFiliere.Location.X, labelFiliere.Location.Y, labelFiliere.Width, labelFiliere.Height);
            labelMoyenneOriginalRect = new Rectangle(labelMoyenne.Location.X, labelMoyenne.Location.Y, labelMoyenne.Width, labelMoyenne.Height);
            FiliereOriginalRect = new Rectangle(Filiere.Location.X, Filiere.Location.Y, Filiere.Width, Filiere.Height);
            MatiereOriginalRect = new Rectangle(Matiere.Location.X,Matiere.Location.Y, Matiere.Width, Matiere.Height);
            MoyenneOriginalRect = new Rectangle(Moyenne.Location.X, Moyenne.Location.Y, Moyenne.Width, Moyenne.Height);
            NiveauOriginalRect = new Rectangle(Niveau.Location.X, Niveau.Location.Y, Niveau.Width, Niveau.Height);
            RechercheOriginalRect = new Rectangle(Recherche.Location.X, Recherche.Location.Y, Recherche.Width, Recherche.Height);           
            TableOriginalRect = new Rectangle(Table.Location.X, Table.Location.Y, Table.Width, Table.Height);

            Table.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Table.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Table.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Table.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i <= Table.Columns.Count - 1; i++)
            {
                // Store Auto Sized Widths:
                int colw = Table.Columns[i].Width;

                // Remove AutoSizing:
                Table.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                // Set Width to calculated AutoSize value:
                Table.Columns[i].Width = colw;
            }
        }

        private void resizeChildrenControls()
        {
            resizeControl(labelNiveauOriginalRect, labelNiveau);
            resizeControl(labelFiliereOriginalRect, labelFiliere);
            resizeControl(labelMatiereOriginalRect, labelMatiere);
            resizeControl(labelMoyenneOriginalRect, labelMoyenne);


            resizeControl(NiveauOriginalRect, Niveau);
            resizeControl(FiliereOriginalRect, Filiere);
            resizeControl(MatiereOriginalRect, Matiere);
            resizeControl(MoyenneOriginalRect, Moyenne);


            resizeControl(TableOriginalRect, Table);

            resizeControl(RechercheOriginalRect, Recherche);
            

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

        private void Consultation_notes_Resize(object sender, EventArgs e)
        {
            resizeChildrenControls();
            Table.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Table.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Table.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Table.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            // Now that DataGridView has calculated it's Widths; we can now store each column Width values.
            for (int i = 0; i <= Table.Columns.Count - 1; i++)
            {
                // Store Auto Sized Widths:
                int colw = Table.Columns[i].Width;

                // Remove AutoSizing:
                Table.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                // Set Width to calculated AutoSize value:
                Table.Columns[i].Width = colw;
            }
        }
    }
}
