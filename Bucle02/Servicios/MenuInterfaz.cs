using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucle02.Servicios
{
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Conexion al metodo que solicita al usuario un valor
        /// <autor>30/10/2023 - DMN</autor>
        /// </summary>
 
        public int pedirNumI();
        public double pedirNumD();
    }

}
