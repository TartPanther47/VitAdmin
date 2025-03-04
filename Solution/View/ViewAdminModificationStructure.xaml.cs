﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VitAdmin.Control;
using VitAdmin.Data;
using VitAdmin.View.Tool;
using VitAdmin.ViewModel;

namespace VitAdmin.View
{
    /// <summary>
    /// Logique d'interaction pour ViewAdminModificationStructure.xaml
    /// </summary>
    public partial class ViewAdminModificationStructure : Page, IEcranRetour, IEcranAAideContextuelle
    {
        private GestionnaireEcrans GestionnaireEcrans { get; set; }

        public ViewAdminModificationStructure(GestionnaireEcrans gestionnaireEcrans)
        {
            InitializeComponent();
            GestionnaireEcrans = gestionnaireEcrans;
            DataContext = new ModelViewAdminModificationStructure(gestionnaireEcrans);
            cpDepartementsAvecApercu.Content = new ControlDepartementsAvecDetails(gestionnaireEcrans);
        }

        public Action CmdRetourEcranPrecedent
        {
            get { return () => { GestionnaireEcrans.Changer(new ViewHubAdmin(GestionnaireEcrans)); }; }
        }

        public string TexteBoutonRetourEcran
        {
            get { return "< Accueil"; }
        }

        public string AncreSectionAideContextuelle => "MAdepartements";
    }
}
