using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService.Dto;
using Library.Template.MVVM;

namespace BusinessLogic
{
    public class Diagnostico
    {

        public static UtilityValidation.ValidationState ValidateFornitore(FornitoreDto fornitore, AnagraficaFornitoreDto anagraficaFornitore, CommessaDto commessa)
        {
            try
            {
                var validation = new UtilityValidation.ValidationState();              
                if (fornitore!=null && commessa != null && anagraficaFornitore != null)
                {
                    var fornitori = commessa.Fornitores;
                    if (fornitori != null)
                    {
                        var exist = ((from q in fornitori where q.Id != fornitore.Id && q.AnagraficaFornitoreId == anagraficaFornitore.Id select q).Count() >= 1);
                        validation.State = !exist;
                        if (exist)
                            validation.Message = "Il fornitore selezionato " + BusinessLogic.Fornitore.GetCodifica(anagraficaFornitore) + " è già presente nella commessa " + 
                                BusinessLogic.Commessa.GetCodifica(commessa);
                    }
                }
                return validation;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static UtilityValidation.ValidationState ValidateCommittente(CommittenteDto committente, AnagraficaCommittenteDto anagraficaCommittente, CommessaDto commessa)
        {
            try
            {
                var validation = new UtilityValidation.ValidationState();
                if (committente != null && commessa != null && anagraficaCommittente != null)
                {
                    var committenti = commessa.Committentes;
                    if (committenti != null)
                    {
                        var exist = ((from q in committenti where q.Id != committente.Id && q.AnagraficaCommittenteId == anagraficaCommittente.Id select q).Count() >= 1);
                        validation.State = !exist;
                        if (exist)
                            validation.Message = "Il committente selezionato " + BusinessLogic.Committente.GetCodifica(anagraficaCommittente) + " è già presente nella commessa " + 
                                BusinessLogic.Commessa.GetCodifica(commessa);
                    }
                }
                return validation;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static UtilityValidation.ValidationState ValidateAnagraficaCommittente(AnagraficaCommittenteDto anagraficaCommittente, IEnumerable<AnagraficaCommittenteDto> anagraficheCommittenti)
        {
            try
            {
                if (anagraficaCommittente != null && anagraficheCommittenti != null)
                {
                    var validated = new UtilityValidation.ValidationState();
                    var exist = ((from q in anagraficheCommittenti where q.Id != anagraficaCommittente.Id && q.Codice == anagraficaCommittente.Codice select q).Count() >= 1);
                    validated.State = !exist;
                    if (exist)
                        validated.Message = "Il committente con ragione sociale " + anagraficaCommittente.RagioneSociale + " è già presente in archivio con il codice "+anagraficaCommittente.Codice;
                    return validated;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static UtilityValidation.ValidationState ValidateAnagraficaFornitore(AnagraficaFornitoreDto anagraficaFornitore, IEnumerable<AnagraficaFornitoreDto> anagraficheFornitori)
        {
            try
            {
                if (anagraficaFornitore != null && anagraficheFornitori != null)
                {
                    var validated = new UtilityValidation.ValidationState();
                    var exist = ((from q in anagraficheFornitori where q.Id != anagraficaFornitore.Id && q.Codice == anagraficaFornitore.Codice select q).Count() >= 1);
                    validated.State = !exist;
                    if (exist)
                        validated.Message = "Il fornitore con ragione sociale " + anagraficaFornitore.RagioneSociale + " è già presente in archivio con il codice " + anagraficaFornitore.Codice;
                    return validated;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static UtilityValidation.ValidationState ValidateAnagraficaArticolo(AnagraficaArticoloDto anagraficaArticolo, IEnumerable<AnagraficaArticoloDto> anagraficheArticoli)
        {
            try
            {
                if (anagraficaArticolo != null && anagraficheArticoli != null)
                {
                    var validated = new UtilityValidation.ValidationState();
                    var exist = ((from q in anagraficheArticoli where q.Id != anagraficaArticolo.Id && q.Codice == anagraficaArticolo.Codice select q).Count() >= 1);
                    validated.State = !exist;
                    if (exist)
                        validated.Message = "L'articolo indicato " + anagraficaArticolo.Descrizione+ " è già presente in archivio con il codice " + anagraficaArticolo.Codice;
                    return validated;
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
