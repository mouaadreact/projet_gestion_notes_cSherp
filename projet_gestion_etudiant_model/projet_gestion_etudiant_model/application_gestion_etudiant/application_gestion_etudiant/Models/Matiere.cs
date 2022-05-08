using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DLL_lib;

namespace application_gestion_etudiant.Models
{
    class Matiere : Model
    {
        private string code;
        private string designation;
        private int vh;
        private string code_module;

        public int Vh { get => vh; set => vh = value; }
        public string Code_module { get => code_module; set => code_module = value; }

        public string Code { get => code; set => code = value; }
        public string Designation { get => designation; set => designation = value; }

    }
}
