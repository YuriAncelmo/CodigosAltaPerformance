using System;

namespace CodigosAltaPerformance
{
    class Pilha
    {
        public Node topo { get; set; }
        public Pilha()
        {
            Init();
        }
        private void Init()
        {
            topo = null;
        }
        public bool IsEmpty()
        {
            return topo == null;
        }
        public void Push(int dado)
        {
            Node novo = new Node();
            novo.dado = dado;
            novo.prox = topo;
            topo = novo;
        }
        public int Top()
        {
            if (!IsEmpty())
                return topo.dado;
            throw new Exception("Pilha Vazia");
        }
        public object Pop()
        {
            return IsEmpty() ? IsEmpty() : Remove();
        }

        private object Remove()
        {
            int elem = topo.dado;
            topo = topo.prox;
            return elem;
        }
        public void MostrarDados()
        {
            if(!IsEmpty()) topo.MostrarDados(topo);
        }
    }
}
