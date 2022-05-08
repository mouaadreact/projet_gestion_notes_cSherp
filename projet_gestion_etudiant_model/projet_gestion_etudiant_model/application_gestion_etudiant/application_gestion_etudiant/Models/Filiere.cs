using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DLL_lib;

namespace application_gestion_etudiant.Models
{
    class Filiere : Model
    {
        private string code;
        private string designation;

        public string Code { get => code; set => code = value; }
        public string Designation { get => designation; set => designation = value; }
    }
}
