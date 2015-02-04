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
            Assegno,
            Bonifico,
            Carta,
            Contanti,
            RIBA,
            RID
        }

        public enum StatoCommessa
        {
            Aperta,
            Chiusa,
            Sospesa,
        }

        public enum ScadenzaPagamento
        {
            GG30=30,
            GG60=60,
            GG90=90,
            GG120=120
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
