using CodigosAltaPerformance.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigosAltaPerformance.Implementacao
{
    public class FilaEncadeada : IFila
    {
        public Node inicio { get; set; }
        public Node fim { get; set; }
        public FilaEncadeada()
        {
            Init();
        }
        public Node Dequeue()
        {
            return FilaEncadeadaUtil.Dequeue(this);
        }

        public void Enqueue(Node node)
        {
            FilaEncadeadaUtil.Enqueue(this, node);
        }

        public int First()
        {
           return FilaEncadeadaUtil.First(this);
        }

        public void Init()
        {
            FilaEncadeadaUtil.Init(this);
        }

        public bool IsEmpty()
        {
            return FilaEncadeadaUtil.IsEmpty(this);
        }
    }
}
