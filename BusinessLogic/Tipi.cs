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
        public enum TipoNotifica
        {
            FatturaAcquisto,
            FatturaVendita
        }

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
            [Description("Scadenza immediata")]
            GG0,
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
            Incoerente //fattura il cui totale pagamenti > totale fattura
        }
       
        public enum StatoFornitore
        {
            None,
            Pagato, //fornitore il cui totale pagamenti >= Totale fatture
            Insoluto, //fornitore il cui totale pagamenti < totale fatture e per il quale ci sono fatture insolute
            [Description("Non pagato")]
            NonPagato, //fornitore il cui totale pagamenti < totale fatture e per il quale ci sono fatture non pagate
            Incoerente //fornitore il cui totale pagamenti > totale fatture
        }

        public enum StatoCommittente
        {
            None,
            Incassato, //committente il cui totale incassi >= Totale fattura
            Insoluto, //committente il cui totale incassi < totale fattura e per il quale ci sono fatture insolute
            [Description("Non incassato")]
            NonIncassato, //committente il cui totale incassi < totale fattura e per il quale ci sono fatture non incassate
            Incoerente //committente il cui totale incassi > totale fatture
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
            [Description("Resoconto fornitori")]
            Fornitori,
            [Description("Resoconto committenti")]
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

        public static IList<string> GetStatiFattureInsoluteNonPagate()
        {
            try
            {
                var stati = new List<string>();
                stati.Add(StatoFattura.Insoluta.ToString());
                stati.Add(StatoFattura.NonPagata.ToString());
                stati.Add(StatoFattura.Incoerente.ToString());
                return stati;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static IList<string> GetStatiFornitoriInsolutiNonPagati()
        {
            try
            {
                var stati = new List<string>();
                stati.Add(StatoFornitore.Insoluto.ToString());
                stati.Add(StatoFornitore.NonPagato.ToString());
                stati.Add(StatoFornitore.Incoerente.ToString());
                return stati;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static IList<string> GetStatiCommittentiInsolutiNonIncassati()
        {
            try
            {
                var stati = new List<string>();
                stati.Add(StatoCommittente.Insoluto.ToString());
                stati.Add(StatoCommittente.NonIncassato.ToString());
                stati.Add(StatoCommittente.Incoerente.ToString());
                return stati;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

    }
}
