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
using VitAdmin.ControlModel;

namespace VitAdmin.Control
{
    /// <summary>
    /// Logique d'interaction pour ControlConnexion.xaml
    /// </summary>
    public partial class ControlConnexion : UserControl
    {
        public ControlConnexion(GestionnaireEcrans gestionnaireEcrans)
        {
            InitializeComponent();
            DataContext = new ControlModelConnexion(gestionnaireEcrans);
        }
    }
}
