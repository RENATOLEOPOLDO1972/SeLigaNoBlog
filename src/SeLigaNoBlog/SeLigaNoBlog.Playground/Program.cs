using System;
using System.Configuration;

namespace SeLigaNoBlog.Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine();

            var servico = new ServicoRecomendacao();

            servico.Executar(); 

            Console.ReadLine();
        }
    }
}
