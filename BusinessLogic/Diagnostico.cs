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

        public static UtilityValidation.ValidationState ValidateFornitore(FornitoreDto fornitore, IEnumerable<FornitoreDto> fornitori, AnagraficaFornitoreDto anagraficaFornitore, 
            CommessaDto commessa)
        {
            try
            {
                if (fornitori != null && anagraficaFornitore != null)
                {
                    var validated = new UtilityValidation.ValidationState();
                    var exist = ((from q in fornitori where q.Id != fornitore.Id && q.Codice == anagraficaFornitore.Codice select q).Count() >= 1);
                    validated.State = !exist;
                    if(exist)
                        validated.Message = "Il fornitore selezionato " + anagraficaFornitore.RagioneSociale + " è già presente nella commessa " + commessa.Codice + " - " + commessa.Denominazione;
                    return validated;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static UtilityValidation.ValidationState ValidateCommittente(CommittenteDto committente, IEnumerable<CommittenteDto> committenti, AnagraficaCommittenteDto anagraficaCommittente,
            CommessaDto commessa)
        {
            try
            {
                if (committenti != null && anagraficaCommittente != null)
                {
                    var validated = new UtilityValidation.ValidationState();
                    var exist = ((from q in committenti where q.Id != committente.Id && q.Codice == anagraficaCommittente.Codice select q).Count() >= 1);
                    validated.State = !exist;
                    if (exist)
                        validated.Message = "Il committente selezionato " + anagraficaCommittente.RagioneSociale + " è già presente nella commessa " + commessa.Codice + " - " + commessa.Denominazione;
                    return validated;
                }
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
