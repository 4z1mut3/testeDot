using System;
using System.Linq;

namespace Prova
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var contexto = new ProvaContext();

            var tiposSeguros = contexto.TiposSeguros.Select(s=>s);

            foreach (var tipoSeguro in tiposSeguros)
            {
                Console.WriteLine(tipoSeguro.DS_TIPOSEGURO);
            }

            Console.WriteLine("Banco Inicializado.");
            Console.ReadLine();
        }
    }
}