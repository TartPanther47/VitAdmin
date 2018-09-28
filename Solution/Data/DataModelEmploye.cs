﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VitAdmin.Model;

namespace VitAdmin.Data
{
    public static class DataModelEmploye
    {
        public static List<Employe> GetEmployes()
        {
            List<Employe> lstEmployes = new List<Employe>();

            if (ConnexionBD.Instance().EstConnecte())
            {
                string requete = "SELECT * FROM Employes e " +
                                 "JOIN Postes p ON p.idPoste = e.idPoste";
                ConnexionBD.Instance().ExecuterRequete(requete, SqlDR =>
                {
                    lstEmployes.Add(new Employe
                    {
                        NumEmploye = SqlDR.GetString("e.numEmploye"),
                        NumPermis = SqlDR.GetString("e.numPermis"),
                        NAS = SqlDR.GetString("e.NAS"),
                        Poste = SqlDR.GetString("p.nom")
                    });
                });
            }

            return lstEmployes;
        }

        public static void AddEmploye (Employe employe)
        {
            EtatAvecMessage retour = new EtatAvecMessage();

            if (ConnexionBD.Instance().EstConnecte())
            {
                string requete = string.Format("INSERT INTO Employes " +
                                           "(idCitoyen, idPoste, numEmploye, numPermis, NAS) " +
                                           "VALUES (" +
                                           "(SELECT idCitoyen FROM Citoyens WHERE numAssuranceMaladie = '{0}'," +
                                           "(SELECT idPoste FROM Postes WHERE nom = '{1}'," +
                                           "'{2}'," +
                                           "'{3}'," +
                                           "'{4}'"
                                           , employe.AssMaladie, employe.Poste, employe.NumEmploye, employe.NumPermis, employe.NAS);

                DataModelCitoyen.AddCitoyen(employe);
                ConnexionBD.Instance().ExecuterRequete(requete);
                // TODO : Recevoir code erreur BD dans cas d'erreur (duplicata)
            }
        }
    }
}
