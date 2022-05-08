using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using application_gestion_etudiant.Models;


namespace application_gestion_etudiant
{
    public partial class Bilan_annuel : Form
    {
        Dictionary<string, string> list_code_filiere = new Dictionary<string, string>();

        private Rectangle labelFiliereOriginalRect;
        private Rectangle labelEtudiantOriginalRect;
        private Rectangle labelNiveauOriginalRect;
        private Rectangle labelMoyenneOriginalRect;
        private Rectangle FiliereOriginalRect;
        private Rectangle EtudiantOriginalRect;
        private Rectangle NiveauOriginalRect;
        private Rectangle MoyenneOriginalRect;
        private Rectangle RechercheOriginalRect;
        private Rectangle EXELOriginalRect;
        private Rectangle TableOriginalRect;
        private Size formOriginalSize;

        public Bilan_annuel()
        {
            InitializeComponent();
            Filiere.Items.Clear();
            Filiere ele_filiere = new Filiere();
            List<dynamic> List_filiere = ele_filiere.All();
            foreach (Filiere fil in List_filiere)
            {
                Filiere.Items.Add(fil.Code);

            }
        }

        private void Bilan_annuel_Load(object sender, EventArgs e)
        {
            formOriginalSize = Size;
            labelEtudiantOriginalRect = new Rectangle(labelEtudiant.Location.X, labelEtudiant.Location.Y, labelEtudiant.Width, labelEtudiant.Height);
            labelNiveauOriginalRect = new Rectangle(labelNiveau.Location.X, labelNiveau.Location.Y, labelNiveau.Width, labelNiveau.Height);
            labelFiliereOriginalRect = new Rectangle(labelFiliere.Location.X, labelFiliere.Location.Y, labelFiliere.Width, labelFiliere.Height);
            labelMoyenneOriginalRect = new Rectangle(labelMoyenne.Location.X, labelMoyenne.Location.Y, labelMoyenne.Width, labelMoyenne.Height);
            FiliereOriginalRect = new Rectangle(Filiere.Location.X, Filiere.Location.Y, Filiere.Width, Filiere.Height);
            EtudiantOriginalRect = new Rectangle(Etudiant.Location.X, Etudiant.Location.Y,Etudiant.Width,Etudiant.Height);
            MoyenneOriginalRect = new Rectangle(Moyenne.Location.X, Moyenne.Location.Y, Moyenne.Width, Moyenne.Height);
            NiveauOriginalRect = new Rectangle(Niveau.Location.X, Niveau.Location.Y, Niveau.Width, Niveau.Height);
            RechercheOriginalRect = new Rectangle(Recherche.Location.X, Recherche.Location.Y, Recherche.Width, Recherche.Height);
            EXELOriginalRect = new Rectangle(EXEL.Location.X, EXEL.Location.Y, EXEL.Width, EXEL.Height);
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
            resizeControl(labelEtudiantOriginalRect, labelEtudiant);
            resizeControl(labelMoyenneOriginalRect, labelMoyenne);
         

            resizeControl(NiveauOriginalRect, Niveau);
            resizeControl(FiliereOriginalRect, Filiere);
            resizeControl(EtudiantOriginalRect, Etudiant);
            resizeControl(MoyenneOriginalRect, Moyenne);
          

            resizeControl(TableOriginalRect, Table);

            resizeControl(RechercheOriginalRect, Recherche);
            resizeControl(EXELOriginalRect, EXEL);
     
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

        private void Recherche_Click(object sender, EventArgs e)
        {
            if (!Etudiant.Text.Equals(""))
            {
                Moyenne.Text = "";
                Table.Rows.Clear();

                Notes ele_notes = new Notes();
                Matiere ele_matiere = new Matiere();
                Module ele_module = new Module();




                List<dynamic> List_notes = ele_notes.All();
                List<dynamic> List_module = ele_module.All();
                List<dynamic> List_matiere = ele_matiere.All();


                //------------------------------------------------------------------------------

                Filiere ele_filiere = new Filiere();
                List<dynamic> List_filiere = ele_filiere.All();


                int count_Matiere = 0;


                foreach (Filiere f in List_filiere)
                {
                    foreach (Module mo in List_module)
                    {

                        foreach (Matiere ma in List_matiere)
                        {
                            if (f.Code == mo.Code_fil && mo.Code == ma.Code_module && f.Code == Filiere.Text && mo.Niveau == int.Parse(Niveau.Text))

                                count_Matiere++;
                        }

                    }
                }


                //----------------------------------------------------------------------------------
                int count_eleve_note = 0;
                foreach (Notes n in List_notes)
                {
                    if (n.Code_eleve == Etudiant.Text)
                        count_eleve_note++;

                }



                //-------------------------------------------------------------------------------------------

                int i = 0;
                double sum = 0;


                foreach (Notes n in List_notes)
                {
                    foreach (Module mo in List_module)
                    {
                        foreach (Matiere ma in List_matiere)
                        {
                            if (n.Code_eleve.Equals(Etudiant.Text) && mo.Code_fil.Equals(Filiere.Text) && mo.Code.Equals(ma.Code_module) 
                                && mo.Niveau == Int32.Parse(Niveau.Text) && n.Code_mat.Equals(ma.Code))
                            {

                                Table.Rows.Add();
                                Table.Rows[i].Cells[0].Value = ma.Code;
                                Table.Rows[i].Cells[1].Value = ma.Designation;
                                Table.Rows[i].Cells[2].Value = mo.Semestre;
                                Table.Rows[i].Cells[3].Value = n.Note;
                                if (count_Matiere == count_eleve_note)
                                {
                                    sum += n.Note;
                                }
                                i++;

                            }
                        }

                    }
                }





                if (sum != 0)
                {
                    sum /= i;
                    Moyenne.Text = sum.ToString();
                }

               
            }

        }

        private void Filiere_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Filiere.Text.Equals(""))
            {
                Moyenne.Text = "";
                Table.Rows.Clear();
                Niveau.Text = "";
                Etudiant.Text = "";
                Niveau.Items.Clear();
                Etudiant.Items.Clear();
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
                Etudiant.Items.Clear();
                Moyenne.Text = "";
                Etudiant.Text = "";
                
                Table.Rows.Clear();

                Filiere ele_filiere = new Filiere();
                List<dynamic> List_filiere = ele_filiere.All();


                Eleve ele_eleve = new Eleve();
                List<dynamic> List_eleve = ele_eleve.All();


                foreach (Filiere f in List_filiere)
                {
                    foreach (Eleve el in List_eleve)
                    {
                        if (f.Code.Equals(el.Code_fil) == true && f.Code.Equals(Filiere.Text) == true && el.Niveau == Int32.Parse(Niveau.Text))
                        {
                            Etudiant.Items.Add(el.Code);

                        }
                    }
                }



            }


        }

        private void EXEL_Click(object sender, EventArgs e)
        {
            if (Table.Rows.Count > 1)
            {
                SaveFileDialog sfd = new SaveFileDialog();

                sfd.Filter = "CSV (.csv)|.csv";
                sfd.FileName = Etudiant.Text + "_" + Filiere.Text + "_" + Niveau.Text + ".csv";

                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Possible To Write DATA : " + ex.Message);
                        }
                    }


                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = Table.Columns.Count;
                            string columnNames = "";

                            string[] outputCsv = new string[Table.Rows.Count + 1];

                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += Table.Columns[i].HeaderText.ToString() + ";";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; i < Table.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += Table.Rows[i - 1].Cells[j].Value.ToString() + ";";
                                }
                            }

                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        private void Table_Resize(object sender, EventArgs e)
        {

        }

        private void Bilan_annuel_Resize(object sender, EventArgs e)
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
