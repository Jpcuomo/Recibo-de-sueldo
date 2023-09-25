using ClassLibrary1;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            while (continuar)
            {
                string nombre = Validador.ValidarNombre();
                double valorHora = Validador.ValidarDouble();
                int antiguedad = Validador.ValidarEntero();
                double horasTrabajadas = Validador.ValidarDouble();
                Empleado empleado = new Empleado(nombre, valorHora, antiguedad, horasTrabajadas);
                empleado.CalcularSueldoBruto();
                empleado.MostrarSueldo();

                Console.Write("Cargar otro empleado? (s/n): ");
                string respuesta = Console.ReadLine();
                if (respuesta.ToLower() == "n")
                {
                    continuar = false;
                } 
            }
        }
    }
}