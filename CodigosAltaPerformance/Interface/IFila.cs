using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigosAltaPerformance.Interface
{
    interface IFila
    {
        Node inicio { get; set; }
        Node fim { get; set; }

        void Enqueue(IFila fila, Node node);
        void Dequeue(IFila fila, Node node);
        int First(IFila fila);
        /// <summary>
        /// Deve inicializar a fila, apontando os nós para nulo
        /// </summary>
        /// <param name="inicio">Fila a ser inicializada</param>
        void Init(IFila fila);
        /// <summary>
        /// Indica se a fila está vazia
        /// </summary>
        /// <param name="fila">fila a ser verificada</param>
        bool IsEmpty(IFila fila);
    }
}
