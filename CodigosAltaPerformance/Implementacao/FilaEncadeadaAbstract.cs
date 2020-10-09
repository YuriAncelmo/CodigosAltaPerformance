using CodigosAltaPerformance.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigosAltaPerformance.Implementacao
{
    abstract class FilaEncadeadaAbstract : IFila
    {
        public Node inicio { get; set; }
        public Node fim { get; set; }
        public FilaEncadeadaAbstract()
        {
            Init(this);
        }
        public void Dequeue(IFila fila, Node node)
        {
            FilaEncadeadaUtil.Dequeue(fila, node);
        }

        public void Enqueue(IFila fila, Node node)
        {
            FilaEncadeadaUtil.Enqueue(this, node);
        }

        public int First(IFila fila)
        {
           return FilaEncadeadaUtil.First(fila);
        }

        public void Init(IFila fila)
        {
            FilaEncadeadaUtil.Init(this);
        }

        public bool IsEmpty(IFila fila)
        {
            return FilaEncadeadaUtil.IsEmpty(fila);
        }


    }
}
