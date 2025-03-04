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
using VitAdmin.ControlModel;

namespace VitAdmin.Control
{
    /// <summary>
    /// Logique d'interaction pour ControlAjoutQuart.xaml
    /// </summary>
    public partial class ControlAjoutQuart : UserControl
    {
        public ControlAjoutQuart(Border quart)
        {
            InitializeComponent();
            DataContext = new ControlModelAjoutQuart(quart);
        }
    }
}
