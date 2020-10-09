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
            //ListaEncadeadaSimples simples = new ListaEncadeadaSimples(100);
            //simples.MostrarDados();

            //simples.InserirElemento(8);

            //Console.WriteLine("Lista depois da inserção ");
            //simples.MostrarDados();

            //Console.ReadKey();

            //Pilha teste = new Pilha();

            //teste.Push(3);
            //teste.Push(4);

            //teste.MostrarDados();

            //teste.Push(1);

            //Console.WriteLine(teste.Top());

            //while (!teste.IsEmpty())
            //{
            //    Console.WriteLine(teste.Pop());
            //}

            //Console.ReadKey();

            //Exemplo de conversão para binário
            ConversorBinario converter = new ConversorBinario(15);
            converter.getBinario();
        }
    }
}
