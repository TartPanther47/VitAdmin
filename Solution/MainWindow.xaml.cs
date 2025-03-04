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
using VitAdmin.Data;
using VitAdmin.View;

namespace VitAdmin
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GestionnaireEcrans GestionnaireEcrans { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            GestionnaireEcrans = new GestionnaireEcrans(grdMain); // Initialiser le gestionnaire d'écrans.
            GestionnaireEcrans.Changer(new ViewConnexion(GestionnaireEcrans));
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
            => ConnexionBD.Instance().Fermer();
    }
}
