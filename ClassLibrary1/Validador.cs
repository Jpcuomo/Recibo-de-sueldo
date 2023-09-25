using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ClassLibrary1
{
    public static class Validador
    {

        /// <summary>
        /// Valida el o nombre ingresado
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns>Nombre (type string)</returns>
        public static string ValidarNombre()
        {
            while (true)
            {
                Console.Write("Ingrese nombre del empleado: ");
                string nombre = Console.ReadLine();
                string patron = @"^[A-Z][a-z]+([ A-Z][a-z]+)?$";
                if (Regex.IsMatch(nombre, patron))
                {
                    return nombre;
                }
                Console.WriteLine("Formato de nombre incorrecto");
            }
        }

        /// <summary>
        /// Valida el ingreso de núeros con decimales
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Type double</returns>
        public static double ValidarDouble()
        {
            while(true)
            {
                Console.Write("Ingrese un número mayor a cero (puede ser entero o decimal): ");
                string numeroStr = Console.ReadLine();
                string patron = @"^[0-9]+([\.0-9]+)?$";

                if (Regex.IsMatch(numeroStr, patron))
                {
                    if (double.TryParse(numeroStr, out double numero))
                    {
                        return numero;
                    }
                }
                Console.WriteLine("Formato de número incorrecto. Introduzca un número válido.");
            }
        }


        /// <summary>
        /// Valida el ingreso de números enteros
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Type int</returns>
        public static int ValidarEntero()
        {
            while (true)
            {
                Console.WriteLine("Ingrese antigüedad");
                string numeroStr = Console.ReadLine() ;
                string patron = @"^[0-9]+$";
                if (Regex.IsMatch(numeroStr, patron))
                {
                    if(int.TryParse(numeroStr,out int numero))
                    {
                        return numero;
                    }
                }
                Console.WriteLine("Formato de número incorrecto. Introduzca un número válido.");

            }
        }
    }
}
