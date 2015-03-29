using Library.Code;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
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

        public enum TransazionePagamento
        {
            None,
            Acconto,
            Saldo
        }

        public enum ScadenzaPagamento
        {
            None,
            [Description("Scadenza a 30 giorni")]
            GG30,
            [Description("Scadenza a 60 giorni")]
            GG60,
            [Description("Scadenza a 90 giorni")]
            GG90,
            [Description("Scadenza a 120 giorni")]
            GG120
        }

        public enum StatoCommessa
        {
            None,
            Aperta,
            [Description("In lavorazione")]
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
            Pagata, //fattura il cui totale pagamenti >= Totale fattura
            Insoluta, //fattura il cui totale pagamenti < totale fattura e today >scadenza=data fattura+ scadenza pagamento
            [Description("Non pagata")]
            NonPagata, //fattura il cui totale pagamenti < totale fattura e today<=scadenza=data fattura+ scadenza pagamento
            Anomala //fattura il cui totale pagamenti > totale fattura
        }
        public enum StatoFornitore
        {
            None,
            Pagato, //fornitore il cui totale pagamenti >= Totale fatture
            Insoluto, //fornitore il cui totale pagamenti < totale fatture e per il quale ci sono fatture insolute
            [Description("Non pagato")]
            NonPagato, //fornitore il cui totale pagamenti < totale fatture e per il quale ci sono fatture non pagate
            Anomalo //fornitore il cui totale pagamenti > totale fatture
        }

        public enum StatoCommittente
        {
            None,
            Incassato, //committente il cui totale incassi >= Totale fattura
            Insoluto, //committente il cui totale incassi < totale fattura e per il quale ci sono fatture insolute
            [Description("Non incassato")]
            NonIncassato //committente il cui totale incassi < totale fattura e per il quale ci sono fatture non incassate
        }

        public enum TipoAccount
        {
            None,
            Supervisore,
            Amministratore,
            Operatore
        }
        
        public enum TipoReport
        {
            None,
            [Description("Situazione fornitore")]
            Fornitore,
            [Description("Situazione committente")]
            Committente,
            [Description("Stato fornitori")]
            Fornitori,
            [Description("Stato committenti")]
            Committenti,
            [Description("Stato pagamenti fatture")]
            FattureAcquisto,
            [Description("Stato incassi fatture")]
            FattureVendita,
            [Description("Stato avanzamento lavori")]
            SAL,
            [Description("Situazione commesse")]
            Commesse
        }

    }
}
