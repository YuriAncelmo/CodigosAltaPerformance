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

        void Enqueue(Node node);
        Node Dequeue();
        int First();
        /// <summary>
        /// Deve inicializar a fila, apontando os nós para nulo
        /// </summary>
        /// <param name="inicio">Fila a ser inicializada</param>
        void Init();
        /// <summary>
        /// Indica se a fila está vazia
        /// </summary>
        /// <param name="fila">fila a ser verificada</param>
        bool IsEmpty();
    }
}
