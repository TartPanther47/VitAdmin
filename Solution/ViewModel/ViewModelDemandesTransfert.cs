﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VitAdmin.Model;
using VitAdmin.MVVM;

namespace VitAdmin.ViewModel
{
    public class ViewModelDemandesTransfert : ObjetObservable
    {
        Citoyen Citoyen { get; set; }
        public ViewModelDemandesTransfert(Citoyen citoyen)
        {
            Citoyen = citoyen;
        }
    }
}
