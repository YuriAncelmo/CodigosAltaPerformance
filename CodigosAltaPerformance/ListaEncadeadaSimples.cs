
using System;

namespace CodigosAltaPerformance
{
    class ListaEncadeadaSimples
    {
        public Node lista { get; set; }
        
        /// <summary>
        /// Cria uma instancia de lista encadeada simples
        /// </summary>
        /// <param name="numero_elementos">Representa a quantidade de nós que serão gerados</param>
        public ListaEncadeadaSimples(int numero_elementos)
        {
            InicializarLista(numero_elementos);
        }

        private void InicializarLista(int numero_elementos)
        {
            //Inicia a lista com ponteiro null
            lista = null;

            for (int i = numero_elementos; i > 0; i--)
            {
                Node novo = new Node();
                novo.dado = i * 2 + 5;
                //Na primeira execução é nulo
                //Na segunda execução é o úl/timo elemento
                novo.prox = lista;
                //primeiro elemento da fila 
                lista = novo;
            }
        }

        public void MostrarDados()
        {
            lista.MostrarDados(lista," ");
        }
        public void InserirElemento(int valor)
        {
            Node aux = lista;

            while(aux.prox != null)
            {
                if (aux.dado < valor && aux.prox.dado > valor)
                {
                    Node novo = new Node();
                    novo.dado = valor;
                    novo.prox = aux.prox;
                    aux.prox = novo;
                    break;
                }
                else aux = aux.prox;
            }
            //lista = aux; Não é necessário pois a lista já contem o primeiro elemento 
        }
    }
}
