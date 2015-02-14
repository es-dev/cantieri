using Library.Code;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Tipi
    {
        public enum TipoPagamento
        {
            None,
            Assegno,
            Bonifico,
            Carta,
            Contanti,
            RIBA,
            RID
        }

        public enum ScadenzaPagamento
        {
            None,
            GG30,
            GG60,
            GG90,
            GG120
        }

        public enum StatoCommessa
        {
            None,
            Aperta,
            InLavorazione,
            Chiusa,
            Sospesa
        }

        public enum StatoSAL
        {
            None,
            Perdita,
            Negativo,
            Positivo
        }

        public enum StatoFattura
        {
            None,
            Pagata, //fattura il cui totale pagamenti>=Totale fattura
            Insoluta, //fattura il cui totale pagamenti <totale fattura e today >scadenza=data fattura+ scadenza pagamento
            NonPagata, //fattura il cui totale pagamenti <totale fattura e today<=scadenza=data fattura+ scadenza pagamento
        }
        public enum StatoFornitore
        {
            None,
            Pagato, //fornitore il cui totale pagamenti>=Totale fattura
            Insoluto, //fornitore il cui totale pagamenti <totale fattura e....
            NonPagato, //fornitore il cui totale pagamenti <totale fattura e....
        }

        public enum StatoCliente
        {
            None,
            Liquidato, //cliente il cui totale incassi>=Totale fattura
            Insoluto, //cliente il cui totale incassi <totale fattura e....
            NonLiquidato, //cliente il cui totale incassi <totale fattura e....
        }

        

    }
}
