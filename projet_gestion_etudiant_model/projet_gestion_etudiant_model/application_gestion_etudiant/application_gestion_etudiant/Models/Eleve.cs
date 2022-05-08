using System;
using System.Collections.Generic;
using System.Text;
using DLL_lib;


namespace application_gestion_etudiant.Models
{
    class Eleve:Model
    {
        private string code;
        private string nom;
        private string prenom;
        private int niveau;
        private string code_fil;

        public string Code { get => code; set => code = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int Niveau { get => niveau; set => niveau = value; }
        public string Code_fil { get => code_fil; set => code_fil = value; }
    }
}
