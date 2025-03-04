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
using VitAdmin.ModelView;

namespace VitAdmin.View
{
    /// <summary>
    /// Logique d'interaction pour ViewConnexion.xaml
    /// </summary>
    public partial class ViewConnexion : Page
    {
        public ViewConnexion(GestionnaireEcrans gestionnaireEcrans)
        {
            InitializeComponent();
            DataContext = new ViewModelConnexion(gestionnaireEcrans);
            card.Content = new ControlConnexion(gestionnaireEcrans);
        }
    }
}
