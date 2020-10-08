using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigosAltaPerformance
{
    public class Node
    {
        public int dado;
        public Node prox;
        /// <summary>
        /// Mostra os dados que estão dentro dos nós
        /// </summary>
        /// <param name="lista">Lista a ser exibida</param>
        /// <param name="concatenate">Concatenação dos elementos da lista</param>
        public void MostrarDados(Node lista, string concatenate)
        {
            Node aux = lista;
            Console.Write( aux.dado + concatenate);

            if (aux.prox != null)
                MostrarDados(aux.prox, concatenate);
        }
        
    }
}
