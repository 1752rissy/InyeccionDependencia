﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaDI_1
{
    public class Saludo : ILeer
    {
        
        public string Leer(string mensaje)
        {
            return mensaje;
        }
    }
}
