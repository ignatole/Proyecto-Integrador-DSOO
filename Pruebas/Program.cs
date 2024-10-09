using System;
using proyectoIntegrador.Datos;

namespace Pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario();

            Console.Write("Ingrese nombre de usuario: ");
            string nombreUsuario = Console.ReadLine();

            Console.Write("Ingrese contraseña: ");
            string passwordUsuario = Console.ReadLine();

            // Llamar al método Log_Usu
            int resultado = usuario.Log_Usu(nombreUsuario, passwordUsuario);

            // Verificar el resultado
            if (resultado == 1)
            {
                Console.WriteLine("Login exitoso");
            }
            else
            {
                Console.WriteLine("Login fallido");
            }

            // Esperar que el usuario presione una tecla antes de cerrar
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
