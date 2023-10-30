using Bucle02;
using Bucle02.Servicios;
using System.ComponentModel.Design;

/// <summary>
/// Clase Principal por la cual el programa se Inicia
/// <autor>30/10/2023 - DMN</autor>
/// </summary>
class Program
{
    /// <summary>
    /// Metodo por el cual la aplicacion se inicializa
    /// <autor>30/10/2023 - DMN</autor>
    /// </summary>
    /// <param name="args"></param>
    public static void Main(String[] args)
    {

        MenuInterfaz mi = new MenuImplementacion();

        int i = mi.pedirNumI();

        double a = mi.pedirNumD();

           Console.WriteLine(a);
           Console.WriteLine(i);

        for (int b = 1; b <= i; ++b) /*Creacion del bucle encargado de la multiplicacion del numero double por si mismo, tantas veces como indique el cdouble*/
        {
            double multiplicacion = a * a;
            Console.WriteLine(multiplicacion);
            
        }

    }
}