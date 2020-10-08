﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace CodigosAltaPerformance
{
    class ConversorBinario
    {
        int numero;
        /// <summary>
        /// Converte o número para binário
        /// </summary>
        /// <param name="numero">Número a ser convertido</param>
        public ConversorBinario(int numero)
        {
            this.numero = numero;
        }
        public void getBinario()
        {
            Pilha pilha = new Pilha();
            int aux = numero;
            while(aux / 2 != 0)
            {
                pilha.Push(aux % 2);
                aux = aux / 2;
            }
            Console.Write("O numero " + this.numero + " em binário é: ");
            // Desempilhar
            pilha.topo.MostrarDados(pilha.topo, "");
            Console.ReadKey();
        }
    }
}