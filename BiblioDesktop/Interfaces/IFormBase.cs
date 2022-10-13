﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BiblioDesktop.Interfaces
{
    public interface IFormBase
    {
        int? IdEditar { get; set; }
        public DialogResult ShowDialog();
        public void CargarDatosEnPantalla();
        public void LimpiarDatosDeLaPantalla();
    }
}
