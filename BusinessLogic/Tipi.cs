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

        public enum StatoCommessa
        {
            None,
            Aperta,
            Chiusa,
            Sospesa,
        }

        public enum ScadenzaPagamento
        {
            None,
            GG30 = 30,
            GG60=60,
            GG90=90,
            GG120=120
        }

        public enum StatoFattura
        {
            None,
            Pagata, //fattura il cui totale pagamenti>=Totale fattura
            Insoluta, //fattura il cui totale pagamenti <totale fattura e today >scadenza=data fattura+ scadenza pagamento
            NonPagata, //fattura il cui totale pagamenti <totale fattura e today<=scadenza=data fattura+ scadenza pagamento

        }
        public static IList<string> GetNames(Type type)
        {
            try
            {
                string[] names = Enum.GetNames(type);
                return names.ToList();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
    }
}
