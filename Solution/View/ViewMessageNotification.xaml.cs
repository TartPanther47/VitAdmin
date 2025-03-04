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
using VitAdmin.ViewModel;

namespace VitAdmin.View
{
    /// <summary>
    /// Logique d'interaction pour ViewMessageNotification.xaml
    /// </summary>
    public partial class ViewMessageNotification : Page
    {
        public ViewMessageNotification(int senderID, string titre, string message)
        {
            InitializeComponent();
            DataContext = new ViewModelMessageNotification(senderID, titre, message);
        }
    }
}
