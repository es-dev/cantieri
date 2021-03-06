﻿using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService.Dto;

namespace BusinessLogic
{
    public class CentroCosto
    {
        public static string GetCodifica(CentroCostoDto centroCosto)
        {
            try
            {
                if(centroCosto!=null)
                {
                    var codifica = centroCosto.Codice + " - " + centroCosto.Denominazione;
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
