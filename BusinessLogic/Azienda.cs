using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService.Dto;

namespace BusinessLogic
{
    public class Azienda
    {
        public static string GetCodifica(AziendaDto azienda)
        {
            try
            {
                if(azienda!=null)
                {
                    var codifica = azienda.Codice + " - " + azienda.RagioneSociale;
                    return codifica;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static string GetCodifica(FatturaVenditaDto fatturaVendita)
        {
            try
            {
                if (fatturaVendita != null)
                {
                    var azienda = GetAzienda(fatturaVendita);
                    var codifica = GetCodifica(azienda);
                    return codifica;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static string GetCodifica(FatturaAcquistoDto fatturaAcquisto)
        {
            try
            {
                if (fatturaAcquisto != null)
                {
                    var azienda = GetAzienda(fatturaAcquisto);
                    var codifica = GetCodifica(azienda);
                    return codifica;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        internal static string GetEmail(FatturaVenditaDto fatturaVendita)
        {
            try
            {
                var azienda = GetAzienda(fatturaVendita);
                if(azienda!=null)
                {
                    var email = azienda.Email;
                    return email;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        internal static string GetEmail(FatturaAcquistoDto fatturaAcquisto)
        {
            try
            {
                var azienda = GetAzienda(fatturaAcquisto);
                if (azienda != null)
                {
                    var email = azienda.Email;
                    return email;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private static AziendaDto GetAzienda(FatturaVenditaDto fatturaVendita)
        {
            try
            {
                if(fatturaVendita!=null)
                {
                    var committente = fatturaVendita.Committente;
                    var azienda = GetAzieda(committente);
                    return azienda;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private static AziendaDto GetAzieda(CommittenteDto committente)
        {
            try
            {
                if (committente != null)
                {
                    var commessa = committente.Commessa;
                    var azienda = GetAzienda(commessa);
                    return azienda;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private static AziendaDto GetAzienda(FatturaAcquistoDto fatturaAcquisto)
        {
            try
            {
                if (fatturaAcquisto != null)
                {
                    var fornitore = fatturaAcquisto.Fornitore;
                    var azienda = GetAzienda(fornitore);
                    return azienda;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private static AziendaDto GetAzienda(FornitoreDto fornitore)
        {
            try
            {
                if (fornitore != null)
                {
                    var commessa = fornitore.Commessa;
                    var azienda = GetAzienda(commessa);
                    return azienda;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private static AziendaDto GetAzienda(CommessaDto commessa)
        {
            try
            {
                if(commessa!=null)
                {
                    var azienda = commessa.Azienda;
                    return azienda;
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
