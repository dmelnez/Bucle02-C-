using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucle02.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        /// <summary>
        /// Metodo por el cual se le pide al usuario un valor y lo devuelve
        ///  <autor>30/10/2023 - DMN</autor>
        /// </summary>
        /// <returns></returns>
        public int pedirNumI( )
        {
            int valorI;
            Console.WriteLine("Introduzca un Valor tipo INT");
            valorI = Convert.ToInt32(Console.ReadLine());
            return valorI;


        }


        public double pedirNumD()
        {
            double valorD;
            Console.WriteLine("Introduzca un Valor tipo DOUBLE");
            valorD = Convert.ToDouble(Console.ReadLine());
            return valorD;


        }

    }
}
