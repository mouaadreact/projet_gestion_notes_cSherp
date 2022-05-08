using System;
using System.Collections.Generic;
using System.Text;

using DLL_lib;

namespace application_gestion_etudiant.Models
{
    class Notes : Model
    {
        private string code_eleve, code_mat;
        private double note;

        public string Code_eleve { get => code_eleve; set => code_eleve = value; }
        public string Code_mat { get => code_mat; set => code_mat = value; }
        public double Note { get => note; set => note = value; }
    }
}
