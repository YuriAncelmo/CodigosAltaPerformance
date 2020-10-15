using CodigosAltaPerformance.Implementacao;
using CodigosAltaPerformance.Interface;
using System;
using System.Security.AccessControl;

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
            //ConversorBinario converter = new ConversorBinario(15);
            //converter.getBinario();
            IFila fila = new FilaEncadeada();
            //Empilhar 
            Node novo = new Node();
            novo.dado = 83;
            fila.Enqueue(novo);
            //Mostrar
            Node retorno = fila.Dequeue();
            Console.WriteLine(retorno.dado);
        }
    }
}
