using CodigosAltaPerformance.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigosAltaPerformance.Implementacao
{
    class FilaEncadeadaUtil
    {
        
        public static void Dequeue(IFila fila, Node node)
        {
            if (!IsEmpty(fila))
            {
                //Retira o primeiro elemento
                fila.inicio = fila.inicio.prox;
            }
        }

        public static void Enqueue(IFila fila, Node node)
        {
            node.dado = new Random(4).Next(1, 1000);

            //Ele é o ultimo da fila 
            node.prox = null;

            //Se a fila estiver vazia ele é o primeiro
            if (FilaEncadeadaUtil.IsEmpty(fila))
                fila.inicio = node;
            //Senão ele é o ultimo
            else
                fila.fim = node;
        }

        public static int First(IFila fila)
        {
            if (IsEmpty(fila))
                throw new Exception("Fila vazia");
            else
                return fila.inicio.dado;
        }

        public static void Init(IFila fila)
        {
            fila.inicio = null;
            fila.fim = null;
        }

        public static bool IsEmpty(IFila fila)
        {
            return fila.inicio == null && fila.fim == null;
        }

    }
}
