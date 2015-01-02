using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    class Tipi
    {

        public enum TipoPagamento
        {
            Assegno,
            Bonifico,
            Contanti
        }

        public enum StatoCommessa
        {
            Aperta,
            Chiusa
        }
    }
}
