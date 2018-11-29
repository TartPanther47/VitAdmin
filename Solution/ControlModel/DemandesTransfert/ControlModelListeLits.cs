﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using VitAdmin.Model;
using VitAdmin.MVVM;

namespace VitAdmin.ControlModel.DemandesTransfert
{
    public class ControlModelListeLits : ObjetObservable
    {
        public List<Lit> LstLits { get; set; }

        public ControlModelListeLits(List<Lit> lstLits = null)
        {
            LstLits = lstLits;
        }

        public ICommand CmdDtgLstLitDrop
        {
            get
            {
                return new CommandeDeleguee(demandeDrop =>
                {
                    //LstLits

                });
            }
        }
    }
}
