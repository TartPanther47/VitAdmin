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
using VitAdmin.Model;
using VitAdmin.ControlModel;

namespace VitAdmin.Control
{
    // Bonheur à Laurence : https://stackoverflow.com/questions/15268760/upload-file-to-ftp-using-c-sharp

    /// <summary>
    /// Interaction logic for ControlDossierPatientResultatsLabo.xaml
    /// </summary>
    public partial class ControlDossierPatientResultatsLabo : UserControl
    {
        private ControlModelDossierPatientResultatsLabo ControlModelResultat { get; set; }

        public ControlDossierPatientResultatsLabo(Citoyen patient, Hospitalisation hospit)
        {
            InitializeComponent();
            DataContext = ControlModelResultat = new ControlModelDossierPatientResultatsLabo(patient, hospit, Data.DataModelResultatsLabo.GetResultatsLaboCitoyens(patient.AssMaladie, hospit.DateDebut));

        }

        private void DataGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            img.Source = ((ResultatLabo)(((DataGrid)sender).SelectedItem)).Resultats;
        }

        private void NouveauResultat_Click(object sender, RoutedEventArgs e)
            => ControlModelResultat.CmdBtnClicNouveauResultat.Execute(ControlModelResultat.Hospit);
    }
}
