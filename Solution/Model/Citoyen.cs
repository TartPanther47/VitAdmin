﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitAdmin.Model
{
    // TODO: Max
    public class Citoyen
    {
        public String Nom { get; set; }
        public String Prenom { get; set; }
        public String AssMaladie { get; set; }
        public String Adresse { get; set; }
        public String NumTelephone { get; set; }
        public List<Hospitalisation> Hospitalisations { get; set; }
        public Lit Lit { get; set; }


        bool ValiderTelephone() { return new bool(); }
        bool ValiderAssMaladie() { return new bool(); }
        bool ValiderDateNaissance() { return new bool(); }
        String FormaterAdresse() { return ""; }
        DateTime AvoirDateNaissance() { return new DateTime(); }
    }
}