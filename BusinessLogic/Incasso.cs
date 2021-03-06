﻿using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService.Dto;

namespace BusinessLogic
{
    public class Incasso
    {
        public static string GetCodice(FatturaVenditaDto fatturaVendita)
        {
            try
            {
                if (fatturaVendita != null)
                {
                    var incassi = fatturaVendita.Incassos;
                    var progressivo = 1;
                    if (incassi != null)
                        progressivo = incassi.Count + 1;
                    var codice = fatturaVendita.Numero + "/" + DateTime.Today.Year.ToString() + "/" + progressivo.ToString("000");  //numero/anno/progressivo
                    return codice;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static string GetCodifica(IncassoDto incasso)
        {
            try
            {
                if (incasso != null)
                {
                    var codifica = incasso.Codice + " DEL " + UtilityValidation.GetDataND(incasso.Data);
                    return codifica;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
    }
}
