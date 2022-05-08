using System;
using System.Collections.Generic;
using System.Text;

using DLL_lib;

namespace application_gestion_etudiant.Models
{
    class Module : Model
    {
        private string code;
        private string designation;
        private int niveau;
        private string semestre;
        private string code_fil;

        public int Niveau { get => niveau; set => niveau = value; }
        public string Semestre { get => semestre; set => semestre = value; }
        public string Code_fil { get => code_fil; set => code_fil = value; }

        public string Code { get => code; set => code = value; }
        public string Designation { get => designation; set => designation = value; }


    }
}
