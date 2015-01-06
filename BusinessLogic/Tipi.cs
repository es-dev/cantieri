using Library.Code;
using System;
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
            Contanti
        }

        public enum StatoCommessa
        {
            Aperta,
            Chiusa
        }

        public enum ScadenzaPagamento
        {
            GG30=30,
            GG60=60,
            GG120=120
        }

        public static IList<string> GetTipi(Type type)
        {
            try
            {
                string[] names=Enum.GetNames(type);
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
