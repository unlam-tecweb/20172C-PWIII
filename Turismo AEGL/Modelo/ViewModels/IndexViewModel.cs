﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.ViewModels
{
    public class IndexViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int CantidadDeNoches { get; set; }
        public float Precio { get; set; }
        public int DiaDeSalida { get; set; }
        public string MesDeSalida { get; set; }
        public string Foto { get; set; }
    }
}
