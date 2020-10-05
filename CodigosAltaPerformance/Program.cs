using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigosAltaPerformance
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaEncadeadaSimples simples = new ListaEncadeadaSimples(100);
            simples.MostrarDados();
            
            simples.InserirElemento(8);

            Console.WriteLine("Lista depois da inserção ");
            simples.MostrarDados();
            
            Console.ReadKey();
        }
    }
}
