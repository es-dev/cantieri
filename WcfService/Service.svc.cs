using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Library.Code;
using System.Linq.Expressions;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service.svc or Service.svc.cs at the Solution Explorer and start debugging.
    public class Service : IService
    {
        #region Azienda
        #region CRUD
        public Dto.AziendaDto CreateAzienda(Dto.AziendaDto azienda)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateAzienda(azienda);
                var newAzienda = wcf.ReadAzienda(dtoKey);
                return newAzienda;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.AziendaDto> ReadAziende()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var aziende = wcf.ReadAziendas();
                return aziende;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateAzienda(Dto.AziendaDto azienda)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateAzienda(azienda);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteAzienda(Dto.AziendaDto azienda)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteAzienda(azienda);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountAziende()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.AziendasCount();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
        #endregion
        #region Custom
        public IEnumerable<Dto.AziendaDto> LoadAziende(int skip, int take, string search = null)
        {
            try
            {
                var aziende = QueryAziende(search);
                aziende = (from q in aziende select q).Skip(skip).Take(take);

                var aziendeDto = UtilityPOCO.Assemble<Dto.AziendaDto>(aziende);
                return aziendeDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountAziende(string search = null)
        {
            try
            {
                var aziende = QueryAziende(search);
                var count = aziende.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.AziendaDto ReadAzienda(object id)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = UtilityPOCO.GetDtoKey(id);
                var azienda = wcf.ReadAzienda(dtoKey);
                return azienda;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.Azienda> QueryAziende(string search)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var aziende = (from q in ef.Aziendas select q);
                if (search != null && search.Length > 0)
                    aziende = (from q in aziende where q.Codice.StartsWith(search) || q.RagioneSociale.Contains(search) || q.Comune.StartsWith(search) || q.Indirizzo.Contains(search) ||
                                   q.Provincia.StartsWith(search) select q);

                aziende = (from q in aziende orderby q.RagioneSociale select q);
                return aziende;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

       
        #endregion
        #endregion

        #region Account
        #region CRUD
        public Dto.AccountDto CreateAccount(Dto.AccountDto account)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateAccount(account);
                var newAccount = wcf.ReadAccount(dtoKey);
                return newAccount;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.AccountDto> ReadAccounts()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var accounts = wcf.ReadAccounts();
                return accounts;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateAccount(Dto.AccountDto account)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateAccount(account);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteAccount(Dto.AccountDto account)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteAccount(account);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountAccounts()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.AccountsCount();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
        #endregion
        #region Custom
        public IEnumerable<Dto.AccountDto> LoadAccounts(int skip, int take, string search = null)
        {
            try
            {
                var accounts = QueryAccounts(search);
                accounts = (from q in accounts select q).Skip(skip).Take(take);
                var accountsDto = UtilityPOCO.Assemble<Dto.AccountDto>(accounts);
                return accountsDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountAccounts(string search = null)
        {
            try
            {
                var accounts = QueryAccounts(search);
                var count = accounts.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.AccountDto ReadAccount(object id)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var account = (from q in ef.Accounts where q.Id == (int)id select q).FirstOrDefault();
                var accountDto = UtilityPOCO.Assemble<Dto.AccountDto>(account);
                return accountDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.Account> QueryAccounts(string search)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var accounts = (from q in ef.Accounts select q);
                if (search != null && search.Length > 0)
                    accounts = (from q in accounts
                               where q.Nickname.StartsWith(search) || q.Username.Contains(search) select q);

                accounts = (from q in accounts orderby q.Username select q);
                return accounts;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }


        #endregion
        #endregion

        #region Commessa
        #region CRUD
        public Dto.CommessaDto CreateCommessa(Dto.CommessaDto commessa)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateCommessa(commessa);
                var newCommessa = wcf.ReadCommessa(dtoKey);
                return newCommessa;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.CommessaDto> ReadCommesse()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var commesse = wcf.ReadCommessas();
                return commesse;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateCommessa(Dto.CommessaDto commessa)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateCommessa(commessa);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteCommessa(Dto.CommessaDto commessa)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteCommessa(commessa);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountCommesse()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.CommessasCount();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
        #endregion
        #region Custom
        public IEnumerable<Dto.CommessaDto> LoadCommesse(int skip, int take, string search = null)
        {
            try
            {
                var commesse = QueryCommesse(search);
                commesse = (from q in commesse select q).Skip(skip).Take(take);

                var commesseDto = UtilityPOCO.Assemble<Dto.CommessaDto>(commesse);
                return commesseDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.CommessaDto> LoadCommesseNonAssegnate(int skip, int take, string search = null)
        {
            try
            {
                var commesse = QueryCommesse(search);
                commesse = (from q in commesse where q.Cliente == null select q); //filtro aggiuntivo per commesse non assegnate (cliente nullo)
                commesse = (from q in commesse select q).Skip(skip).Take(take);

                var commesseDto = UtilityPOCO.Assemble<Dto.CommessaDto>(commesse);
                return commesseDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
        
        public int CountCommesse(string search = null)
        {
            try
            {
                var commesse = QueryCommesse(search);
                var count = commesse.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public int CountCommesseNonAssegnate(string search = null)
        {
            try
            {
                var commesse = QueryCommesse(search);
                commesse = (from q in commesse where q.Cliente == null select q); //filtro aggiuntivo per commesse non assegnate (cliente nullo)
                var count = commesse.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.CommessaDto ReadCommessa(object id)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var commessa = (from q in ef.Commessas where q.Id == (int)id select q).FirstOrDefault();
                var commessaDto = UtilityPOCO.Assemble<Dto.CommessaDto>(commessa);
                return commessaDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.Commessa> QueryCommesse(string search)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var commesse = (from q in ef.Commessas select q);
                if (search != null && search.Length > 0)
                    commesse = (from q in commesse
                                where q.Codice.StartsWith(search) || q.Denominazione.Contains(search) || q.Comune.StartsWith(search) ||
                                    q.Descrizione.Contains(search) || q.Indirizzo.Contains(search) || q.Numero.StartsWith(search) || q.Provincia.StartsWith(search) ||
                                    q.Riferimento.Contains(search) || q.Stato.StartsWith(search)
                                select q);

                commesse = (from q in commesse orderby q.Denominazione select q);
                return commesse;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.CommessaDto> ReadCommesse(IEnumerable<Dto.FornitoreDto> fornitori) //dto parametrici, vanno solo in where etc... mai in dataset
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var fornitoriId = (from q in fornitori select q.Id);
                var commesse =(from q in ef.Fornitores where fornitoriId.Contains(q.Id) select q.Commessa);
                var commesseDto = UtilityPOCO.Assemble<Dto.CommessaDto>(commesse);
                return commesseDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        #endregion
        #endregion

        #region Fornitore
        #region CRUD
        public Dto.FornitoreDto CreateFornitore(Dto.FornitoreDto fornitore)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateFornitore(fornitore);
                var newFornitore = wcf.ReadFornitore(dtoKey);
                return newFornitore;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.FornitoreDto> ReadFornitori()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var fornitori = wcf.ReadFornitores();
                return fornitori;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateFornitore(Dto.FornitoreDto fornitore)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateFornitore(fornitore);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteFornitore(Dto.FornitoreDto fornitore)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteFornitore(fornitore);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountFornitori()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.FornitoresCount();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
        #endregion
        #region Custom
        public IEnumerable<Dto.FornitoreDto> LoadFornitori(int skip, int take, string search = null)
        {
            try
            {
                var fornitori = QueryFornitori(search);
                fornitori = (from q in fornitori select q).Skip(skip).Take(take);

                var fornitoriDto = UtilityPOCO.Assemble<Dto.FornitoreDto>(fornitori);
                return fornitoriDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountFornitori(string search = null)
        {
            try
            {
                var fornitori = QueryFornitori(search);
                var count = fornitori.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.FornitoreDto ReadFornitore(object id)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var fornitore = (from q in ef.Fornitores where q.Id == (int)id select q).FirstOrDefault();
                var fornitoreDto = UtilityPOCO.Assemble<Dto.FornitoreDto>(fornitore);
                return fornitoreDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.Fornitore> QueryFornitori(string search)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var fornitori = (from q in ef.Fornitores select q);
                if (search != null && search.Length > 0)
                {
                    var commesseId = (from c in QueryCommesse(search) select c.Id).ToList();
                    fornitori = (from q in fornitori
                                 where q.Codice.StartsWith(search) || q.PartitaIva.StartsWith(search) ||
                                     q.RagioneSociale.StartsWith(search) || q.Indirizzo.Contains(search) ||
                                     q.Comune.StartsWith(search) || q.Provincia.StartsWith(search) ||
                                     commesseId.Contains(q.CommessaId)
                                 select q);
                }
                fornitori = (from q in fornitori orderby q.RagioneSociale select q);
                return fornitori;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.FornitoreDto> ReadFornitori(string codice)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var fornitori = (from q in ef.Fornitores where q.Codice == codice select q);
                var fornitoriDto = UtilityPOCO.Assemble<Dto.FornitoreDto>(fornitori);
                return fornitoriDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }



        #endregion
        #endregion

        #region CentroCosto
        #region CRUD
        public Dto.CentroCostoDto CreateCentroCosto(Dto.CentroCostoDto centroCosto)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateCentroCosto(centroCosto);
                var newCentroCosto = wcf.ReadCentroCosto(dtoKey);
                return newCentroCosto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.CentroCostoDto> ReadCentriCosto()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var centriCosto = wcf.ReadCentroCostos();
                return centriCosto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateCentroCosto(Dto.CentroCostoDto centroCosto)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateCentroCosto(centroCosto);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteCentroCosto(Dto.CentroCostoDto centroCosto)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteCentroCosto(centroCosto);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountCentriCosto()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.CentroCostosCount();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
        #endregion
        #region Custom
        public IEnumerable<Dto.CentroCostoDto> LoadCentriCosto(int skip, int take, string search = null)
        {
            try
            {
                var centriCosto = QueryCentriCosto(search);
                centriCosto = (from q in centriCosto select q).Skip(skip).Take(take);

                var centriCostoDto = UtilityPOCO.Assemble<Dto.CentroCostoDto>(centriCosto);
                return centriCostoDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountCentriCosto(string search = null)
        {
            try
            {
                var centriCosto = QueryCentriCosto(search);
                var count = centriCosto.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.CentroCostoDto ReadCentroCosto(object id)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = UtilityPOCO.GetDtoKey(id);
                var centroCosto = wcf.ReadCentroCosto(dtoKey);
                return centroCosto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.CentroCosto> QueryCentriCosto(string search)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var centriCosto = (from q in ef.CentroCostos select q);
                if (search != null && search.Length > 0)
                    centriCosto = (from q in centriCosto where q.Codice.StartsWith(search) || q.Denominazione.Contains(search)  
                                   select q);

                centriCosto = (from q in centriCosto orderby q.Denominazione select q);
                return centriCosto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        
        #endregion
        #endregion

        #region FatturaAcquisto
        #region CRUD
        public Dto.FatturaAcquistoDto CreateFatturaAcquisto(Dto.FatturaAcquistoDto fatturaAcquisto)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateFatturaAcquisto(fatturaAcquisto);
                var newFatturaAcquisto = wcf.ReadFatturaAcquisto(dtoKey);
                return newFatturaAcquisto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.FatturaAcquistoDto> ReadFattureAcquisto()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var fattureAcquisto = wcf.ReadFatturaAcquistos();
                return fattureAcquisto;

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateFatturaAcquisto(Dto.FatturaAcquistoDto fatturaAcquisto)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateFatturaAcquisto(fatturaAcquisto);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteFatturaAcquisto(Dto.FatturaAcquistoDto fatturaAcquisto)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteFatturaAcquisto(fatturaAcquisto);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountFattureAcquisto()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.FatturaAcquistosCount();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
        #endregion
        #region Custom
        public IEnumerable<Dto.FatturaAcquistoDto> LoadFattureAcquisto(int skip, int take, string search = null)
        {
            try
            {
                var fattureAcquisto = QueryFattureAcquisto(search);
                fattureAcquisto = (from q in fattureAcquisto select q).Skip(skip).Take(take);

                var fattureAcquistoDto = UtilityPOCO.Assemble<Dto.FatturaAcquistoDto>(fattureAcquisto);
                return fattureAcquistoDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.FatturaAcquistoDto> LoadFattureAcquistoFornitoreDare(int skip, int take, string search, Dto.AnagraficaFornitoreDto anagraficaFornitore)
        {
            try
            {
                var fattureAcquistoId= new List<int>();
                var fattureAcquisto = QueryFattureAcquisto(search);
                fattureAcquisto = (from q in fattureAcquisto where q.Fornitore.Codice ==anagraficaFornitore.Codice select q);
                foreach( var fatturaAcquisto in fattureAcquisto)
                {
                    var totale = UtilityValidation.GetDecimal(fatturaAcquisto.Totale);
                    var pagamenti = fatturaAcquisto.Pagamentos;
                    var totalePagamenti = UtilityValidation.GetDecimal((from q in pagamenti select q.Importo).Sum());
                    if (totalePagamenti < totale)
                    {
                        fattureAcquistoId.Add(fatturaAcquisto.Id);
                    }
                }
                fattureAcquisto = (from q in fattureAcquisto where fattureAcquistoId.Contains(q.Id) select q);
                fattureAcquisto = (from q in fattureAcquisto select q).Skip(skip).Take(take);
                var fattureAcquistoDto = UtilityPOCO.Assemble<Dto.FatturaAcquistoDto>(fattureAcquisto);
                return fattureAcquistoDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }


        public int CountFattureAcquisto(string search = null)
        {
            try
            {
                var fattureAcquisto = QueryFattureAcquisto(search);
                var count = fattureAcquisto.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public int CountFattureAcquisto(string search, Dto.AnagraficaFornitoreDto anagraficaFornitore)
        {
            try
            {
                var fattureAcquistoId = new List<int>();
                var fattureAcquisto = QueryFattureAcquisto(search);
                fattureAcquisto = (from q in fattureAcquisto where q.Fornitore.Codice == anagraficaFornitore.Codice select q);
                foreach (var fatturaAcquisto in fattureAcquisto)
                {
                    var totale = UtilityValidation.GetDecimal(fatturaAcquisto.Totale);
                    var pagamenti = fatturaAcquisto.Pagamentos;
                    var totalePagamenti = UtilityValidation.GetDecimal((from q in pagamenti select q.Importo).Sum());
                    if (totalePagamenti < totale)
                    {
                        fattureAcquistoId.Add(fatturaAcquisto.Id);
                    }
                }
                fattureAcquisto = (from q in fattureAcquisto where fattureAcquistoId.Contains(q.Id) select q);
                var count = fattureAcquisto.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.FatturaAcquistoDto ReadFatturaAcquisto(object id)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var fatturaAcquisto = (from q in ef.FatturaAcquistos where q.Id == (int)id select q).FirstOrDefault();
                var fatturaAcquistoDto = UtilityPOCO.Assemble<Dto.FatturaAcquistoDto>(fatturaAcquisto);
                return fatturaAcquistoDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.FatturaAcquistoDto> ReadFattureAcquistoCommessa(Dto.CommessaDto commessa)
        {
            try
            {
                var fattureAcquisto = QueryFattureAcquistoCommessa(commessa);

                var fattureAcquistoDto = UtilityPOCO.Assemble<Dto.FatturaAcquistoDto>(fattureAcquisto);
                return fattureAcquistoDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private static IQueryable<DataLayer.FatturaAcquisto> QueryFattureAcquistoCommessa(Dto.CommessaDto commessa)
        {
            var ef = new DataLayer.EntitiesModel();
            var fornitoriCommessa = (from q in ef.Fornitores where q.CommessaId == commessa.Id select q);
            var fornitoriCommessaId = (from q in fornitoriCommessa select q.Id);
            var fattureAcquisto = (from q in ef.FatturaAcquistos where fornitoriCommessaId.Contains(q.FornitoreId) select q);
            return fattureAcquisto;
        }

        private IQueryable<DataLayer.FatturaAcquisto> QueryFattureAcquisto(string search)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var fattureAcquisto = (from q in ef.FatturaAcquistos select q);
                if (search != null && search.Length > 0)
                {
                    var fornitoriId = (from q in QueryFornitori(search) select q.Id).ToList();
                    fattureAcquisto = (from q in fattureAcquisto
                                       where q.Numero.StartsWith(search) || q.Descrizione.Contains(search) || q.TipoPagamento.StartsWith(search) ||
                                       fornitoriId.Contains(q.FornitoreId)
                                       select q);
                }
                fattureAcquisto = (from q in fattureAcquisto orderby q.Numero select q);
                return fattureAcquisto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

       
        #endregion
        #endregion

        #region Articolo
        #region CRUD
        public Dto.ArticoloDto CreateArticolo(Dto.ArticoloDto articolo)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateArticolo(articolo);
                var newArticolo = wcf.ReadArticolo(dtoKey);
                return newArticolo;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.ArticoloDto> ReadArticoli()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var articoli = wcf.ReadArticolos();
                return articoli;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateArticolo(Dto.ArticoloDto articolo)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateArticolo(articolo);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteArticolo(Dto.ArticoloDto articolo)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteArticolo(articolo);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountArticoli()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.ArticolosCount();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
        #endregion
        #region Custom
        public IEnumerable<Dto.ArticoloDto> LoadArticoli(int skip, int take, string search = null)
        {
            try
            {
                var articoli = QueryArticoli(search);
                articoli = (from q in articoli select q).Skip(skip).Take(take);

                var articoliDto = UtilityPOCO.Assemble<Dto.ArticoloDto>(articoli);
                return articoliDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountArticoli(string search = null)
        {
            try
            {
                var articoli = QueryArticoli(search);
                var count = articoli.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.ArticoloDto ReadArticolo(object id)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = UtilityPOCO.GetDtoKey(id);
                var articolo = wcf.ReadArticolo(dtoKey);
                return articolo;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.Articolo> QueryArticoli(string search)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var articoli = (from q in ef.Articolos select q);
                if (search != null && search.Length > 0)
                {
                    var fattureAcquistoId = (from q in QueryFattureAcquisto(search) select q.Id).ToList();
                    articoli = (from q in articoli
                                where q.Codice.StartsWith(search) || q.Descrizione.Contains(search) ||
                                    fattureAcquistoId.Contains(q.FatturaAcquistoId)
                                select q);
                }
                articoli = (from q in articoli orderby q.Codice select q);
                return articoli;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

       
        #endregion
        #endregion

        #region Pagamento
        #region CRUD
        public Dto.PagamentoDto CreatePagamento(Dto.PagamentoDto pagamento)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreatePagamento(pagamento);
                var newPagamento = wcf.ReadPagamento(dtoKey);
                return newPagamento;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.PagamentoDto> ReadPagamenti()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var pagamenti = wcf.ReadPagamentos();
                return pagamenti;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdatePagamento(Dto.PagamentoDto pagamento)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdatePagamento(pagamento);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeletePagamento(Dto.PagamentoDto pagamento)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeletePagamento(pagamento);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountPagamenti()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.PagamentosCount();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
        #endregion
        #region Custom
        public IEnumerable<Dto.PagamentoDto> LoadPagamenti(int skip, int take, string search = null)
        {
            try
            {
                var pagamenti = QueryPagamenti(search);
                pagamenti = (from q in pagamenti select q).Skip(skip).Take(take);

                var pagamentiDto = UtilityPOCO.Assemble<Dto.PagamentoDto>(pagamenti);
                return pagamentiDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountPagamenti(string search = null)
        {
            try
            {
                var pagamenti = QueryPagamenti(search);
                var count = pagamenti.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.PagamentoDto ReadPagamento(object id)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = UtilityPOCO.GetDtoKey(id);
                var pagamento = wcf.ReadPagamento(dtoKey);
                return pagamento;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.Pagamento> QueryPagamenti(string search)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var pagamenti = (from q in ef.Pagamentos select q);
                if (search != null && search.Length > 0)
                {
                    var fattureAcquistoId = (from q in QueryFattureAcquisto(search) select q.Id).ToList();
                    pagamenti = (from q in pagamenti
                                 where q.Note.Contains(search) ||
                                     fattureAcquistoId.Contains(q.FatturaAcquistoId)
                                 select q);
                }
                pagamenti = (from q in pagamenti orderby q.Note select q);
                return pagamenti;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public Dto.PagamentoDto ReadPagamentoPagamentoUnificatoFatturaAcquisto(Dto.PagamentoUnificatoFatturaAcquistoDto pagamentoUnificatoFatturaAcquisto)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var pagamento = (from q in ef.Pagamentos where q.FatturaAcquistoId==pagamentoUnificatoFatturaAcquisto.FatturaAcquistoId &&
                                     q.PagamentoUnificatoId== pagamentoUnificatoFatturaAcquisto.PagamentoUnificatoId select q).FirstOrDefault();

                var pagamentoDto = UtilityPOCO.Assemble<Dto.PagamentoDto>(pagamento);
                return pagamentoDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        #endregion
        #endregion

        #region PagamentoUnificato
        #region CRUD
        public Dto.PagamentoUnificatoDto CreatePagamentoUnificato(Dto.PagamentoUnificatoDto pagamentoUnificato)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreatePagamentoUnificato(pagamentoUnificato);
                var newPagamentoUnificato = wcf.ReadPagamentoUnificato(dtoKey);
                return newPagamentoUnificato;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.PagamentoUnificatoDto> ReadPagamentiUnificati()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var pagamentiUnificati = wcf.ReadPagamentoUnificatos();
                return pagamentiUnificati;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdatePagamentoUnificato(Dto.PagamentoUnificatoDto pagamentoUnificato)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdatePagamentoUnificato(pagamentoUnificato);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeletePagamentoUnificato(Dto.PagamentoUnificatoDto pagamentoUnificato)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeletePagamentoUnificato(pagamentoUnificato);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountPagamentiUnificati()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.PagamentoUnificatosCount();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
        #endregion
        #region Custom
        public IEnumerable<Dto.PagamentoUnificatoDto> LoadPagamentiUnificati(int skip, int take, string search = null)
        {
            try
            {
                var pagamentiUnificati = QueryPagamentiUnificati(search);
                pagamentiUnificati = (from q in pagamentiUnificati select q).Skip(skip).Take(take);

                var pagamentiUnificatiDto = UtilityPOCO.Assemble<Dto.PagamentoUnificatoDto>(pagamentiUnificati);
                return pagamentiUnificatiDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountPagamentiUnificati(string search = null)
        {
            try
            {
                var pagamentiUnificati = QueryPagamentiUnificati(search);
                var count = pagamentiUnificati.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.PagamentoUnificatoDto ReadPagamentoUnificato(object id)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var pagamentoUnificato = (from q in ef.PagamentoUnificatos where q.Id == (int)id select q).FirstOrDefault();
                var pagamentoUnificatoDto = UtilityPOCO.Assemble<Dto.PagamentoUnificatoDto>(pagamentoUnificato);
                return pagamentoUnificatoDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }



        private IQueryable<DataLayer.PagamentoUnificato > QueryPagamentiUnificati(string search)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var pagamentiUnificati = (from q in ef.PagamentoUnificatos select q);
                if (search != null && search.Length > 0)
                {
                    var codiciFornitori = (from q in QueryFornitori(search) select q.Codice).ToList();
                    pagamentiUnificati = (from q in pagamentiUnificati
                                 where q.Note.Contains(search) ||
                                     codiciFornitori.Contains(q.CodiceFornitore)
                                 select q);
                }
                pagamentiUnificati = (from q in pagamentiUnificati orderby q.Note select q);
                return pagamentiUnificati;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }


        #endregion
        #endregion

        #region PagamentoUnificatoFatturaAcquisto
        #region CRUD
        public Dto.PagamentoUnificatoFatturaAcquistoDto CreatePagamentoUnificatoFatturaAcquisto(Dto.PagamentoUnificatoFatturaAcquistoDto pagamentoUnificatoFatturaAcquisto)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreatePagamentoUnificatoFatturaAcquisto(pagamentoUnificatoFatturaAcquisto);
                var newPagamentoUnificato = wcf.ReadPagamentoUnificatoFatturaAcquisto(dtoKey);
                return newPagamentoUnificato;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.PagamentoUnificatoFatturaAcquistoDto> ReadPagamentiUnificatiFatturaAcquisto()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var pagamentiUnificatiFatturaAcquisto = wcf.ReadPagamentoUnificatoFatturaAcquistos();
                return pagamentiUnificatiFatturaAcquisto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdatePagamentoUnificatoFatturaAcquisto(Dto.PagamentoUnificatoFatturaAcquistoDto pagamentoUnificatoFatturaAcquisto)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdatePagamentoUnificatoFatturaAcquisto(pagamentoUnificatoFatturaAcquisto);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeletePagamentoUnificatoFatturaAcquisto(Dto.PagamentoUnificatoFatturaAcquistoDto pagamentoUnificatoFatturaAcquisto)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeletePagamentoUnificatoFatturaAcquisto(pagamentoUnificatoFatturaAcquisto);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountPagamentiUnificatiFatturaAcquisto()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.PagamentoUnificatoFatturaAcquistosCount();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
        #endregion
        #region Custom
        public IEnumerable<Dto.PagamentoUnificatoFatturaAcquistoDto> LoadPagamentiUnificatiFatturaAcquisto(int skip, int take, string search = null)
        {
            try
            {
                var pagamentiUnificatiFatturaAcquisto = QueryPagamentiUnificatiFatturaAcquisto(search);
                pagamentiUnificatiFatturaAcquisto = (from q in pagamentiUnificatiFatturaAcquisto select q).Skip(skip).Take(take);

                var pagamentiUnificatiFatturaAcquistoDto = UtilityPOCO.Assemble<Dto.PagamentoUnificatoFatturaAcquistoDto>(pagamentiUnificatiFatturaAcquisto);
                return pagamentiUnificatiFatturaAcquistoDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountPagamentiUnificatiFatturaAcquisto(string search = null)
        {
            try
            {
                var pagamentiUnificatiFatturaAcquisto = QueryPagamentiUnificatiFatturaAcquisto(search);
                var count = pagamentiUnificatiFatturaAcquisto.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.PagamentoUnificatoFatturaAcquistoDto ReadPagamentoUnificatoFatturaAcquisto(object id)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var pagamentoUnificatoFatturaAcquisto = (from q in ef.PagamentoUnificatoFatturaAcquistos where q.Id == (int)id select q).FirstOrDefault();
                var pagamentoUnificatoFatturaAcquistoDto = UtilityPOCO.Assemble<Dto.PagamentoUnificatoFatturaAcquistoDto>(pagamentoUnificatoFatturaAcquisto);
                return pagamentoUnificatoFatturaAcquistoDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.PagamentoUnificatoFatturaAcquisto> QueryPagamentiUnificatiFatturaAcquisto(string search)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var pagamentiUnificatiFatturaAcquisto = (from q in ef.PagamentoUnificatoFatturaAcquistos select q);
                if (search != null && search.Length > 0)
                {
                    var fatturaAcquistoId = (from q in QueryFattureAcquisto(search) select q.Id).ToList();
                    pagamentiUnificatiFatturaAcquisto = (from q in pagamentiUnificatiFatturaAcquisto
                                          where q.Note.Contains(search) ||
                                              fatturaAcquistoId.Contains(q.FatturaAcquistoId)
                                          select q);
                }
                pagamentiUnificatiFatturaAcquisto = (from q in pagamentiUnificatiFatturaAcquisto orderby q.Note select q);
                return pagamentiUnificatiFatturaAcquisto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }


        #endregion
        #endregion

        #region Cliente
        #region CRUD
        public Dto.ClienteDto CreateCliente(Dto.ClienteDto cliente)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateCliente(cliente);
                var newCliente = wcf.ReadCliente(dtoKey);
                return newCliente;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.ClienteDto> ReadClienti()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var clienti = wcf.ReadClientes();
                return clienti;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateCliente(Dto.ClienteDto cliente)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateCliente(cliente);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteCliente(Dto.ClienteDto cliente)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteCliente(cliente);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountClienti()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.ClientesCount();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
        #endregion
        #region Custom
        public IEnumerable<Dto.ClienteDto> LoadClienti(int skip, int take, string search = null)
        {
            try
            {
                var clienti = QueryClienti(search);
                clienti = (from q in clienti select q).Skip(skip).Take(take);

                var clientiDto = UtilityPOCO.Assemble<Dto.ClienteDto>(clienti);
                return clientiDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountClienti(string search = null)
        {
            try
            {
                var clienti = QueryClienti(search);
                var count = clienti.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.ClienteDto ReadCliente(object id)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var cliente = (from q in ef.Clientes where q.Id == (int)id select q).FirstOrDefault();
                var clienteDto = UtilityPOCO.Assemble<Dto.ClienteDto>(cliente);
                return clienteDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.Cliente> QueryClienti(string search)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var clienti = (from q in ef.Clientes select q);
                if (search != null && search.Length > 0)
                {
                    var commesseId = (from c in QueryCommesse(search) select c.Id).ToList();
                    clienti = (from q in clienti
                               where q.Codice.StartsWith(search) || q.PartitaIva.StartsWith(search) ||
                                 q.RagioneSociale.StartsWith(search) || q.Indirizzo.Contains(search) ||
                                 q.Comune.StartsWith(search) || q.Provincia.StartsWith(search) ||
                                 commesseId.Contains(q.Commessa.Id)
                               select q);
                }
                clienti = (from q in clienti orderby q.RagioneSociale select q);
                return clienti;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
        #endregion
        #endregion

        #region FatturaVendita
        #region CRUD
        public Dto.FatturaVenditaDto CreateFatturaVendita(Dto.FatturaVenditaDto fatturaVendita)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateFatturaVendita(fatturaVendita);
                var newFatturaVendita = wcf.ReadFatturaVendita(dtoKey);
                return newFatturaVendita;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.FatturaVenditaDto> ReadFattureVendita()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var fattureVendita = wcf.ReadFatturaVenditas();
                return fattureVendita;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateFatturaVendita(Dto.FatturaVenditaDto fatturaVendita)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateFatturaVendita(fatturaVendita);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteFatturaVendita(Dto.FatturaVenditaDto fatturaVendita)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteFatturaVendita(fatturaVendita);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountFattureVendita()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.FatturaVenditasCount();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
        #endregion
        #region Custom
        public IEnumerable<Dto.FatturaVenditaDto> LoadFattureVendita(int skip, int take, string search = null)
        {
            try
            {
                var fattureVendita = QueryFattureVendita(search);
                fattureVendita = (from q in fattureVendita select q).Skip(skip).Take(take);

                var fattureVenditaDto = UtilityPOCO.Assemble<Dto.FatturaVenditaDto>(fattureVendita);
                return fattureVenditaDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountFattureVendita(string search = null)
        {
            try
            {
                var fattureVendita = QueryFattureVendita(search);
                var count = fattureVendita.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.FatturaVenditaDto ReadFatturaVendita(object id)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var fatturaVendita = (from q in ef.FatturaVenditas where q.Id == (int)id select q).FirstOrDefault();
                var fatturaVenditaDto = UtilityPOCO.Assemble<Dto.FatturaVenditaDto>(fatturaVendita);
                return fatturaVenditaDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.FatturaVendita> QueryFattureVendita(string search)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var fattureVendita = (from q in ef.FatturaVenditas select q);
                if (search != null && search.Length > 0)
                {
                    var clientiId = (from c in QueryClienti(search) select c.Id).ToList();
                    fattureVendita = (from q in fattureVendita
                                      where q.Numero.StartsWith(search) || q.Descrizione.Contains(search) || q.TipoPagamento.StartsWith(search) ||
                                          clientiId.Contains(q.ClienteId)
                                      select q);
                }
                fattureVendita = (from q in fattureVendita orderby q.Numero select q);
                return fattureVendita;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
        #endregion
        #endregion

        #region Liquidazione
        #region CRUD
        public Dto.LiquidazioneDto CreateLiquidazione(Dto.LiquidazioneDto liquidazione)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateLiquidazione(liquidazione);
                var newLiquidazione = wcf.ReadLiquidazione(dtoKey);
                return newLiquidazione;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.LiquidazioneDto> ReadLiquidazioni()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var liquidazioni = wcf.ReadLiquidaziones();
                return liquidazioni;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateLiquidazione(Dto.LiquidazioneDto liquidazione)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateLiquidazione(liquidazione);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteLiquidazione(Dto.LiquidazioneDto liquidazione)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteLiquidazione(liquidazione);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountLiquidazioni()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.LiquidazionesCount();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
        #endregion
        #region Custom
        public IEnumerable<Dto.LiquidazioneDto> LoadLiquidazioni(int skip, int take, string search = null)
        {
            try
            {
                var liquidazioni = QueryLiquidazioni(search);
                liquidazioni = (from q in liquidazioni select q).Skip(skip).Take(take);

                var liquidazioniDto = UtilityPOCO.Assemble<Dto.LiquidazioneDto>(liquidazioni);
                return liquidazioniDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountLiquidazioni(string search = null)
        {
            try
            {
                var liquidazioni = QueryLiquidazioni(search);
                var count = liquidazioni.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.LiquidazioneDto ReadLiquidazione(object id)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = UtilityPOCO.GetDtoKey(id);
                var liquidazione = wcf.ReadLiquidazione(dtoKey);
                return liquidazione;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.Liquidazione> QueryLiquidazioni(string search)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var liquidazioni = (from q in ef.Liquidaziones select q);
                if (search != null && search.Length > 0)
                {
                    var fattureVenditaId = (from q in QueryFattureVendita(search) select q.Id).ToList();
                    liquidazioni = (from q in liquidazioni
                                    where q.Note.Contains(search) ||
                                        fattureVenditaId.Contains(q.FatturaVenditaId)
                                    select q);
                }
                liquidazioni = (from q in liquidazioni orderby q.Note select q);
                return liquidazioni;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

      
        #endregion
        #endregion

        #region SAL
        #region CRUD
        public Dto.SALDto CreateSAL(Dto.SALDto sal)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateSAL(sal);
                var newSAL = wcf.ReadSAL(dtoKey);
                return newSAL;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.SALDto> ReadSALs()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var sals = wcf.ReadSALs();
                return sals;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateSAL(Dto.SALDto sal)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateSAL(sal);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteSAL(Dto.SALDto sal)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteSAL(sal);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountSALs()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.SALsCount();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
        #endregion
        #region Custom
        public IEnumerable<Dto.SALDto> LoadSALs(int skip, int take, string search = null)
        {
            try
            {
                var sals = QuerySALs(search);
                sals = (from q in sals select q).Skip(skip).Take(take);

                var salsDto = UtilityPOCO.Assemble<Dto.SALDto>(sals);
                return salsDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountSALs(string search = null)
        {
            try
            {
                var sals = QuerySALs(search);
                var count = sals.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.SALDto ReadSAL(object id)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = UtilityPOCO.GetDtoKey(id);
                var SAL = wcf.ReadSAL(dtoKey);
                return SAL;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.SAL> QuerySALs(string search)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var sals = (from q in ef.SALs select q);
                if (search != null && search.Length > 0)
                {
                    var commesseId = (from c in QueryCommesse(search) select c.Id).ToList();
                    sals = (from q in sals
                            where q.Codice.StartsWith(search) || q.Denominazione.StartsWith(search) ||
                                commesseId.Contains(q.CommessaId)
                            select q);
                }
                sals = (from q in sals orderby q.Id select q);
                return sals;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
        #endregion
        #endregion

        #region AnagraficaFornitore
        #region CRUD
        public Dto.AnagraficaFornitoreDto CreateAnagraficaFornitore(Dto.AnagraficaFornitoreDto anagraficaFornitore)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateAnagraficaFornitore(anagraficaFornitore);
                var newAnagraficaFornitore = wcf.ReadAnagraficaFornitore(dtoKey);
                return newAnagraficaFornitore;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.AnagraficaFornitoreDto> ReadAnagraficheFornitori()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var anagraficheFornitori = wcf.ReadAnagraficaFornitores();
                return anagraficheFornitori;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateAnagraficaFornitore(Dto.AnagraficaFornitoreDto anagraficaFornitore)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateAnagraficaFornitore(anagraficaFornitore);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteAnagraficaFornitore(Dto.AnagraficaFornitoreDto anagraficaFornitore)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteAnagraficaFornitore(anagraficaFornitore);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountAnagraficheFornitori()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.AnagraficaFornitoresCount();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
        #endregion
        #region Custom
        public IEnumerable<Dto.AnagraficaFornitoreDto> LoadAnagraficheFornitori(int skip, int take, string search = null)
        {
            try
            {
                var anagraficheFornitori = QueryAnagraficheFornitori(search);
                anagraficheFornitori = (from q in anagraficheFornitori select q).Skip(skip).Take(take);

                var anagraficheFornitoriDto = UtilityPOCO.Assemble<Dto.AnagraficaFornitoreDto>(anagraficheFornitori);
                return anagraficheFornitoriDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountAnagraficheFornitori(string search = null)
        {
            try
            {
                var anagraficheFornitori = QueryAnagraficheFornitori(search);
                var count = anagraficheFornitori.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.AnagraficaFornitoreDto ReadAnagraficaFornitore(object id)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = UtilityPOCO.GetDtoKey(id);
                var anagraficaFornitore = wcf.ReadAnagraficaFornitore(dtoKey);
                return anagraficaFornitore;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public Dto.AnagraficaFornitoreDto ReadAnagraficaFornitore(string codice)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var anagraficaFornitore = (from q in ef.AnagraficaFornitores where q.Codice == codice select q).FirstOrDefault();
                var anagraficaFornitoreDto = UtilityPOCO.Assemble<Dto.AnagraficaFornitoreDto>(anagraficaFornitore);
                return anagraficaFornitoreDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }


        private IQueryable<DataLayer.AnagraficaFornitore> QueryAnagraficheFornitori(string search)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var anagraficheFornitori = (from q in ef.AnagraficaFornitores select q);
                if (search != null && search.Length > 0)
                    anagraficheFornitori = (from q in anagraficheFornitori
                                            where q.Codice.StartsWith(search) || q.PartitaIva.StartsWith(search) ||
                                                q.RagioneSociale.StartsWith(search) || q.Indirizzo.Contains(search) ||
                                                q.Comune.StartsWith(search) || q.Provincia.StartsWith(search)
                                            select q);

                anagraficheFornitori = (from q in anagraficheFornitori orderby q.RagioneSociale select q);
                return anagraficheFornitori;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

      
        #endregion
        #endregion

        #region AnagraficaCliente
        #region CRUD
        public Dto.AnagraficaClienteDto CreateAnagraficaCliente(Dto.AnagraficaClienteDto anagraficaCiente)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateAnagraficaCliente(anagraficaCiente);
                var newAnagraficaCliente = wcf.ReadAnagraficaCliente(dtoKey);
                return newAnagraficaCliente;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.AnagraficaClienteDto> ReadAnagraficheClienti()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var anagraficheClienti = wcf.ReadAnagraficaClientes();
                return anagraficheClienti;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateAnagraficaCliente(Dto.AnagraficaClienteDto anagraficaCliente)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateAnagraficaCliente(anagraficaCliente);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteAnagraficaCliente(Dto.AnagraficaClienteDto anagraficaCliente)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteAnagraficaCliente(anagraficaCliente);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountAnagraficheClienti()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.AnagraficaClientesCount();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
        #endregion
        #region Custom
        public IEnumerable<Dto.AnagraficaClienteDto> LoadAnagraficheClienti(int skip, int take, string search = null)
        {
            try
            {
                var anagraficheClienti = QueryAnagraficheClienti(search);
                anagraficheClienti = (from q in anagraficheClienti select q).Skip(skip).Take(take);

                var anagraficheClientiDto = UtilityPOCO.Assemble<Dto.AnagraficaClienteDto>(anagraficheClienti);
                return anagraficheClientiDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountAnagraficheClienti(string search = null)
        {
            try
            {
                var anagraficheClienti = QueryAnagraficheClienti(search);
                var count = anagraficheClienti.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.AnagraficaClienteDto ReadAnagraficaCliente(object id)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = UtilityPOCO.GetDtoKey(id);
                var anagraficaCliente = wcf.ReadAnagraficaCliente(dtoKey);
                return anagraficaCliente;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.AnagraficaCliente> QueryAnagraficheClienti(string search)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var anagraficheClienti = (from q in ef.AnagraficaClientes select q);
                if (search != null && search.Length > 0)
                    anagraficheClienti = (from q in anagraficheClienti where q.Codice.StartsWith(search) || q.PartitaIva.StartsWith(search) ||
                                              q.RagioneSociale.StartsWith(search) || q.Indirizzo.Contains(search) ||
                                              q.Comune.StartsWith(search) || q.Provincia.StartsWith(search) select q);

                anagraficheClienti = (from q in anagraficheClienti orderby q.RagioneSociale select q);
                return anagraficheClienti;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

      
        #endregion
        #endregion

        #region AnagraficaArticolo
        #region CRUD
        public Dto.AnagraficaArticoloDto CreateAnagraficaArticolo(Dto.AnagraficaArticoloDto anagraficaArticolo)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateAnagraficaArticolo(anagraficaArticolo);
                var newAnagraficaArticolo = wcf.ReadAnagraficaArticolo(dtoKey);
                return newAnagraficaArticolo;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.AnagraficaArticoloDto> ReadAnagraficheArticoli()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var anagraficheArticoli = wcf.ReadAnagraficaArticolos();
                return anagraficheArticoli;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateAnagraficaArticolo(Dto.AnagraficaArticoloDto anagraficaArticolo)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateAnagraficaArticolo(anagraficaArticolo);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteAnagraficaArticolo(Dto.AnagraficaArticoloDto anagraficaArticolo)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteAnagraficaArticolo(anagraficaArticolo);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountAnagraficheArticoli()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.AnagraficaArticolosCount();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
        #endregion
        #region Custom
        public IEnumerable<Dto.AnagraficaArticoloDto> LoadAnagraficheArticoli(int skip, int take, string search = null)
        {
            try
            {
                var anagraficheArticoli = QueryAnagraficheArticoli(search);
                anagraficheArticoli = (from q in anagraficheArticoli select q).Skip(skip).Take(take);

                var anagraficheArticoliDto = UtilityPOCO.Assemble<Dto.AnagraficaArticoloDto>(anagraficheArticoli);
                return anagraficheArticoliDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountAnagraficheArticoli(string search = null)
        {
            try
            {
                var anagraficheArticoli = QueryAnagraficheArticoli(search);
                var count = anagraficheArticoli.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.AnagraficaArticoloDto ReadAnagraficaArticolo(object id)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = UtilityPOCO.GetDtoKey(id);
                var anagraficaArticolo = wcf.ReadAnagraficaArticolo(dtoKey);
                return anagraficaArticolo;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.AnagraficaArticolo> QueryAnagraficheArticoli(string search)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var anagraficheArticoli = (from q in ef.AnagraficaArticolos select q);
                if (search != null && search.Length > 0)
                    anagraficheArticoli = (from q in anagraficheArticoli where q.Codice.StartsWith(search) || q.Descrizione.Contains(search) select q);

                anagraficheArticoli = (from q in anagraficheArticoli orderby q.Codice select q);
                return anagraficheArticoli;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

       
        #endregion
        #endregion

        #region ReportJob
        #region CRUD
        public Dto.ReportJobDto CreateReportJob(Dto.ReportJobDto reportJob)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateReportJob(reportJob);
                var newReportJob = wcf.ReadReportJob(dtoKey);
                return newReportJob;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.ReportJobDto> ReadReportJobs()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var reportJobs = wcf.ReadReportJobs();
                return reportJobs;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateReportJob(Dto.ReportJobDto reportJob)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateReportJob(reportJob);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteReportJob(Dto.ReportJobDto reportJob)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteReportJob(reportJob);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountReportJobs()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.ReportJobsCount();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
        #endregion
        #region Custom
        public IEnumerable<Dto.ReportJobDto> LoadReportJobs(int skip, int take, string search = null)
        {
            try
            {
                var reportJobs = QueryReportJobs(search);
                reportJobs = (from q in reportJobs select q).Skip(skip).Take(take);

                var reportJobsDto = UtilityPOCO.Assemble<Dto.ReportJobDto>(reportJobs);
                return reportJobsDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountReportJobs(string search = null)
        {
            try
            {
                var reportJobs = QueryReportJobs(search);
                var count = reportJobs.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.ReportJobDto ReadReportJob(object id)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = UtilityPOCO.GetDtoKey(id);
                var reportJob = wcf.ReadReportJob(dtoKey);
                return reportJob;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.ReportJob> QueryReportJobs(string search)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var reportJobs = (from q in ef.ReportJobs select q);
                if (search != null && search.Length > 0)
                    reportJobs = (from q in reportJobs where q.Codice.StartsWith(search) || q.CodiceFornitore.Contains(search) select q);

                reportJobs = (from q in reportJobs orderby q.Codice select q);
                return reportJobs;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }


        #endregion
        #endregion

    }
}
