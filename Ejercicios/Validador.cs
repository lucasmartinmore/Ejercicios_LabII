﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Validador
    {
        public static bool ValidarRespuesta(char respuesta)
        {
            if(respuesta=='s' || respuesta == 'S')
            {
                return true;    
            }
            return false;
        }
    }
}
