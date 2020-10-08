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
        
        public void MostrarDados(Node lista)
        {
            Node aux = lista;
            Console.WriteLine("Dado" + aux.dado);

            if (aux.prox != null)
                MostrarDados(aux.prox);
        }
    }
}
