using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Empleado
    {
        public const int valorAntiguedad = 150;
        public const int descuento = 15;

        private string _nombre; public string Nombre { get; set; }
        private double _valorHora; public double ValorHora { get; set; }
        private int _antiguedad; public int Antiguedad { get; set; }
        private double _horasTrabajadas; public double HorasTrabajadas { get; set; }


        public Empleado(string nombre, double valorHora, int antiguedad, double horasTrabajadas)
        {
            Nombre = nombre;
            ValorHora = valorHora;
            Antiguedad = antiguedad;
            HorasTrabajadas = horasTrabajadas;
        }

        /// <summary>
        /// Calcula el sueldo bruto de un empleado
        /// </summary>
        /// <returns>Sueldo bruto (type double)</returns>
        public double CalcularSueldoBruto()
        {
            double sueldoBruto = (ValorHora * HorasTrabajadas + Antiguedad * valorAntiguedad);
            return sueldoBruto;
        }

        /// <summary>
        /// Muestra el recibo de sueldo de un empleado
        /// </summary>
        public void MostrarSueldo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Antigüedad: {Antiguedad} años");
            sb.AppendLine($"Valor hora: $ {ValorHora}");
            sb.AppendLine($"Sueldo bruto: $ {CalcularSueldoBruto()}");
            sb.AppendLine($"Sueldo neto: $ {CalcularSueldoBruto() * (100 - descuento) / 100}");
            sb.AppendLine("-------------------------------------------");
            string cadena = sb.ToString();
            Console.WriteLine( cadena );
        }

    }
}
