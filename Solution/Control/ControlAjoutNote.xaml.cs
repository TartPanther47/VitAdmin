﻿using MaterialDesignThemes.Wpf;
using System;
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
using VitAdmin.Model;

namespace VitAdmin.Control
{
    /// <summary>
    /// Interaction logic for ControlAjoutNote.xaml
    /// </summary>
    public partial class ControlAjoutNote : UserControl
    {
        private ControlModelAjoutNote ControlModelNote { get; set; }

        public ControlAjoutNote(Hospitalisation hospit)
        {
            InitializeComponent();
            DataContext = ControlModelNote = new ControlModelAjoutNote(hospit);
        }

        private void Confirmer_Click(object sender, RoutedEventArgs e)
        {
            ControlModelNote.CmdBtnClicConfirmerNoteMed.Execute(new NoteMedecin(Note.Text, (bool)Notifier.IsChecked));
            DialogHost.CloseDialogCommand.Execute(null, null);
        }


    }
}
