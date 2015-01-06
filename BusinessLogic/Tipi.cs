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
            Contanti
        }

        public enum StatoCommessa
        {
            Aperta,
            Chiusa
        }

        public enum ScadenzaPagamento
        {
            S1_30gg=30,
            S2_60gg=60,
            S3_120gg=120
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
