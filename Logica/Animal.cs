﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Animal
    {

        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public bool Eliminado { get; set; }

    }
}
