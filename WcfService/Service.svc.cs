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
        public IEnumerable<Dto.AziendaDto> LoadAziende(int skip, int take, string search = null, object advancedSearch = null, object orderBy = null)
        {
            try
            {
                var aziende = QueryAziende(search, advancedSearch, orderBy);
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

        public int CountAziende(string search = null, object advancedSearch = null)
        {
            try
            {
                var aziende = QueryAziende(search, advancedSearch);
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
                var dtoKey = UtilityPOCO.GetDtoKey((int)id);
                var azienda = wcf.ReadAzienda(dtoKey);
                return azienda;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.Azienda> QueryAziende(string search = null, object advancedSearch=null, object orderBy=null)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var aziende = (from q in ef.Aziendas select q);

                if (advancedSearch != null)
                    aziende = aziende.Where((Func<DataLayer.Azienda, bool>)advancedSearch).AsQueryable();

                if (search != null && search.Length > 0)
                    aziende = (from q in aziende where q.Codice.StartsWith(search) || q.RagioneSociale.Contains(search) || q.Comune.StartsWith(search) || q.Indirizzo.Contains(search) ||
                                   q.Provincia.StartsWith(search) select q);

                aziende = (from q in aziende orderby q.RagioneSociale select q);
                if (orderBy != null)
                    aziende = aziende.OrderBy((Func<DataLayer.Azienda, object>)orderBy).AsQueryable();
                
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
        public IEnumerable<Dto.AccountDto> LoadAccounts(int skip, int take, string search = null, object advancedSearch = null, object orderBy = null)
        {
            try
            {
                var accounts = QueryAccounts(search, advancedSearch, orderBy);
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

        public int CountAccounts(string search = null, object advancedSearch = null)
        {
            try
            {
                var accounts = QueryAccounts(search, advancedSearch);
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

        private IQueryable<DataLayer.Account> QueryAccounts(string search = null, object advancedSearch = null, object orderBy = null)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var accounts = (from q in ef.Accounts select q);

                if (advancedSearch != null)
                    accounts = accounts.Where((Func<DataLayer.Account, bool>)advancedSearch).AsQueryable();

                if (search != null && search.Length > 0)
                    accounts = (from q in accounts
                               where q.Nickname.StartsWith(search) || q.Username.Contains(search) select q);

                accounts = (from q in accounts orderby q.Username select q);
                if (orderBy != null)
                    accounts = accounts.OrderBy((Func<DataLayer.Account, object>)orderBy).AsQueryable();
                
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
                var id = UtilityPOCO.GetId(dtoKey);
                var newCommessa = ReadCommessa(id);
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
        public IEnumerable<Dto.CommessaDto> LoadCommesse(int skip, int take, string search = null, object advancedSearch=null, object orderBy=null)
        {
            try
            {
                var commesse = QueryCommesse(search, advancedSearch, orderBy);
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

        public int CountCommesse(string search = null, object advancedSearch = null)
        {
            try
            {
                var commesse = QueryCommesse(search, advancedSearch);
                var count = commesse.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.CommessaDto ReadCommessa(object id, bool recursive=false)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var commessa = (from q in ef.Commessas where q.Id == (int)id select q).FirstOrDefault();
                
                var commessaDto = UtilityPOCO.Assemble<Dto.CommessaDto>(commessa, recursive); //lettura ricorsiva
                return commessaDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.Commessa> QueryCommesse(string search = null, object advancedSearch = null, object orderBy=null)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var commesse = (from q in ef.Commessas select q);

                if (advancedSearch != null)
                    commesse = commesse.Where((Func<DataLayer.Commessa,bool>)advancedSearch).AsQueryable();
           
                if (search != null && search.Length > 0)
                    commesse = (from q in commesse
                                where q.Codice.StartsWith(search) || q.Denominazione.Contains(search) || q.Comune.StartsWith(search) ||
                                    q.Descrizione.Contains(search) || q.Indirizzo.Contains(search) || q.Numero.StartsWith(search) || q.Provincia.StartsWith(search) ||
                                    q.Riferimento.Contains(search) || q.Stato.StartsWith(search)
                                select q);

                commesse = (from q in commesse orderby q.Id descending select q);
                if(orderBy!=null)
                    commesse = commesse.OrderBy((Func<DataLayer.Commessa, object>)orderBy).AsQueryable();

                return commesse;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.CommessaDto> ReadCommesse(IEnumerable<Dto.FornitoreDto> fornitori) 
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
                var id = UtilityPOCO.GetId(dtoKey);
                var newFornitore = ReadFornitore(id);
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
        public IEnumerable<Dto.FornitoreDto> LoadFornitori(int skip, int take, string search = null, object advancedSearch = null, Dto.CommessaDto commessa = null, 
            object orderBy = null)
        {
            try
            {
                var fornitori = QueryFornitori(search, advancedSearch, commessa, orderBy);
                fornitori = (from q in fornitori select q).Skip(skip).Take(take);
                var fornitoriDto = UtilityPOCO.Assemble<Dto.FornitoreDto>(fornitori, true); //lettura ricorsiva
                return fornitoriDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountFornitori(string search = null, object advancedSearch = null, Dto.CommessaDto commessa = null)
        {
            try
            {
                var fornitori = QueryFornitori(search, advancedSearch, commessa);
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
                var fornitoreDto = UtilityPOCO.Assemble<Dto.FornitoreDto>(fornitore, true);
                return fornitoreDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.Fornitore> QueryFornitori(string search = null, object advancedSearch = null, Dto.CommessaDto commessa = null, object orderBy = null)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var fornitori = (from q in ef.Fornitores select q);
                if(commessa!=null)
                    fornitori = (from q in fornitori where q.CommessaId == commessa.Id select q);

                if (advancedSearch != null)
                    fornitori = fornitori.Where((Func<DataLayer.Fornitore, bool>)advancedSearch).AsQueryable();

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
                if (orderBy != null)
                    fornitori = fornitori.OrderBy((Func<DataLayer.Fornitore, object>)orderBy).AsQueryable();
                
                return fornitori;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.FornitoreDto> ReadFornitori(Dto.AnagraficaFornitoreDto anagraficaFornitore)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var fornitori = (from q in ef.Fornitores where q.Codice == anagraficaFornitore.Codice select q);
                var fornitoriDto = UtilityPOCO.Assemble<Dto.FornitoreDto>(fornitori, true); //lettura ricorsiva
                return fornitoriDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.FornitoreDto> ReadFornitori(Dto.CommessaDto commessa)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var fornitori = (from q in ef.Fornitores where q.CommessaId == commessa.Id select q);
                var fornitoriDto = UtilityPOCO.Assemble<Dto.FornitoreDto>(fornitori); 
                return fornitoriDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.FornitoreDto> ReadFornitori(IEnumerable<Dto.AnagraficaFornitoreDto> anagraficheFornitori)
        {
            try
            {
                if (anagraficheFornitori != null)
                {
                    var ef = new DataLayer.EntitiesModel();
                    var codiciFornitori = (from q in anagraficheFornitori select q.Codice).ToList();
                    var fornitori = (from q in ef.Fornitores where codiciFornitori.Contains(q.Codice) select q);
                    var fornitoriDto = UtilityPOCO.Assemble<Dto.FornitoreDto>(fornitori, true); //lettura ricorsiva
                    return fornitoriDto;
                }
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
        public IEnumerable<Dto.CentroCostoDto> LoadCentriCosto(int skip, int take, string search = null, object advancedSearch = null, object orderBy = null)
        {
            try
            {
                var centriCosto = QueryCentriCosto(search, advancedSearch, orderBy);
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

        public int CountCentriCosto(string search = null, object advancedSearch = null)
        {
            try
            {
                var centriCosto = QueryCentriCosto(search, advancedSearch);
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
                var ef = new DataLayer.EntitiesModel();
                var centroCosto = (from q in ef.CentroCostos where q.Id == (int)id select q).FirstOrDefault();
                var centroCostoDto = UtilityPOCO.Assemble<Dto.CentroCostoDto>(centroCosto);
                return centroCostoDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.CentroCosto> QueryCentriCosto(string search = null, object advancedSearch = null, object orderBy = null)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var centriCosto = (from q in ef.CentroCostos select q);

                if (advancedSearch != null)
                    centriCosto = centriCosto.Where((Func<DataLayer.CentroCosto, bool>)advancedSearch).AsQueryable();

                if (search != null && search.Length > 0)
                    centriCosto = (from q in centriCosto where q.Codice.StartsWith(search) || q.Denominazione.Contains(search)  
                                   select q);

                centriCosto = (from q in centriCosto orderby q.Denominazione select q);
                if (orderBy != null)
                    centriCosto = centriCosto.OrderBy((Func<DataLayer.CentroCosto, object>)orderBy).AsQueryable();
                
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
                var id = UtilityPOCO.GetId(dtoKey);
                var newFatturaAcquisto = ReadFatturaAcquisto(id);
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

        public IEnumerable<Dto.FatturaAcquistoDto> LoadFattureAcquisto(int skip, int take, string search = null, object advancedSearch = null, Dto.FornitoreDto fornitore = null,
            Dto.AnagraficaFornitoreDto anagraficaFornitore = null, object orderBy = null)
        {
            try
            {
                var fattureAcquisto = QueryFattureAcquisto(search, advancedSearch, fornitore, anagraficaFornitore, null, null, orderBy);
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

        public int CountFattureAcquisto(string search = null, object advancedSearch = null, Dto.FornitoreDto fornitore = null, Dto.AnagraficaFornitoreDto anagraficaFornitore = null)
        {
            try
            {
                var fattureAcquisto = QueryFattureAcquisto(search, advancedSearch, fornitore, anagraficaFornitore);
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

        private IQueryable<DataLayer.FatturaAcquisto> QueryFattureAcquisto(string search = null, object advancedSearch = null, Dto.FornitoreDto fornitore = null,
            Dto.AnagraficaFornitoreDto anagraficaFornitore = null, DateTime? start = null, DateTime? end = null, object orderBy = null)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var fattureAcquisto = (from q in ef.FatturaAcquistos select q);
                if(fornitore!=null)
                    fattureAcquisto = (from q in fattureAcquisto where q.FornitoreId == fornitore.Id select q);

                if(anagraficaFornitore!=null) //ricerca fatture insolute/non pagate per un fornitore anagrafico
                    fattureAcquisto = (from q in fattureAcquisto where q.Fornitore.Codice == anagraficaFornitore.Codice select q); 
                
                if(start!=null && end!=null)
                    fattureAcquisto = (from q in fattureAcquisto where start <= q.Scadenza && q.Scadenza <= end select q);

                if (advancedSearch != null)
                    fattureAcquisto = fattureAcquisto.Where((Func<DataLayer.FatturaAcquisto, bool>)advancedSearch).AsQueryable();

                if (search != null && search.Length > 0)
                {
                    var fornitoriId = (from q in QueryFornitori(search) select q.Id).ToList();
                    fattureAcquisto = (from q in fattureAcquisto
                                       where q.Numero.StartsWith(search) || q.Descrizione.Contains(search) || q.TipoPagamento.StartsWith(search) ||
                                       fornitoriId.Contains(q.FornitoreId)
                                       select q);
                }
                fattureAcquisto = (from q in fattureAcquisto orderby q.Id descending select q);
                if (orderBy != null)
                    fattureAcquisto = fattureAcquisto.OrderBy((Func<DataLayer.FatturaAcquisto, object>)orderBy).AsQueryable();
                
                return fattureAcquisto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.FatturaAcquistoDto> ReadFattureAcquisto(DateTime start, DateTime end, string search = null, object advancedSearch=null)
        {
            try
            {
                var fattureAcquisto = QueryFattureAcquisto(search, advancedSearch, null, null, start, end);

                var fattureAcquistoDto = UtilityPOCO.Assemble<Dto.FatturaAcquistoDto>(fattureAcquisto);
                return fattureAcquistoDto;
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
        public IEnumerable<Dto.ArticoloDto> LoadArticoli(int skip, int take, string search = null, object advancedSearch = null, object orderBy = null)
        {
            try
            {
                var articoli = QueryArticoli(search, advancedSearch, orderBy);
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

        public int CountArticoli(string search = null, object advancedSearch = null)
        {
            try
            {
                var articoli = QueryArticoli(search, advancedSearch);
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
                var ef = new DataLayer.EntitiesModel();
                var articolo = (from q in ef.Articolos where q.Id == (int)id select q).FirstOrDefault();
                var articoloDto = UtilityPOCO.Assemble<Dto.ArticoloDto>(articolo);
                return articoloDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.Articolo> QueryArticoli(string search = null, object advancedSearch = null, object orderBy = null)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var articoli = (from q in ef.Articolos select q);

                if (advancedSearch != null)
                    articoli = articoli.Where((Func<DataLayer.Articolo, bool>)advancedSearch).AsQueryable();

                if (search != null && search.Length > 0)
                {
                    var fattureAcquistoId = (from q in QueryFattureAcquisto(search) select q.Id).ToList();
                    articoli = (from q in articoli
                                where q.Codice.StartsWith(search) || q.Descrizione.Contains(search) ||
                                    fattureAcquistoId.Contains(q.FatturaAcquistoId)
                                select q);
                }
                articoli = (from q in articoli orderby q.Id descending select q);
                if (orderBy != null)
                    articoli = articoli.OrderBy((Func<DataLayer.Articolo, object>)orderBy).AsQueryable();
             
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
                var id = UtilityPOCO.GetId(dtoKey);
                var newPagamento = ReadPagamento(id);
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
        public IEnumerable<Dto.PagamentoDto> LoadPagamenti(int skip, int take, string search = null, object advancedSearch = null, Dto.FornitoreDto fornitore = null,
            Dto.FatturaAcquistoDto fatturaAcquisto = null, object orderBy = null)
        {
            try
            {
                var pagamenti = QueryPagamenti(search, advancedSearch, fornitore, fatturaAcquisto, null, null, orderBy);
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

        public int CountPagamenti(string search = null, object advancedSearch = null, Dto.FornitoreDto fornitore = null, Dto.FatturaAcquistoDto fatturaAcquisto = null)
        {
            try
            {
                var pagamenti = QueryPagamenti(search, advancedSearch, fornitore, fatturaAcquisto);
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
                var ef = new DataLayer.EntitiesModel();
                var pagamento = (from q in ef.Pagamentos where q.Id == (int)id select q).FirstOrDefault();
                var pagamentoDto = UtilityPOCO.Assemble<Dto.PagamentoDto>(pagamento);
                return pagamentoDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.Pagamento> QueryPagamenti(string search = null, object advancedSearch = null, Dto.FornitoreDto fornitore = null,
            Dto.FatturaAcquistoDto fatturaAcquisto = null, DateTime? start = null, DateTime? end = null, object orderBy = null)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var pagamenti = (from q in ef.Pagamentos select q);
                if (fatturaAcquisto != null)
                    pagamenti = (from q in pagamenti where q.FatturaAcquistoId == fatturaAcquisto.Id select q);

                if(fornitore!=null)
                {
                    var fattureAcquisto = fornitore.FatturaAcquistos;
                    var fattureAcquistoIds = (from q in fattureAcquisto select q.Id);
                    pagamenti = (from q in pagamenti where fattureAcquistoIds.Contains(q.FatturaAcquistoId) select q);
                }

                if (start != null && end != null)
                    pagamenti = (from q in pagamenti where start <= q.Data && q.Data <= end select q);

                if (advancedSearch != null)
                    pagamenti = pagamenti.Where((Func<DataLayer.Pagamento, bool>)advancedSearch).AsQueryable();

                if (search != null && search.Length > 0)
                {
                    var fattureAcquistoId = (from q in QueryFattureAcquisto(search) select q.Id).ToList();
                    pagamenti = (from q in pagamenti
                                 where q.Note.Contains(search) ||
                                     fattureAcquistoId.Contains(q.FatturaAcquistoId)
                                 select q);
                }
                pagamenti = (from q in pagamenti orderby q.Id descending select q);
                if (orderBy != null)
                    pagamenti = pagamenti.OrderBy((Func<DataLayer.Pagamento, object>)orderBy).AsQueryable();
                
                return pagamenti;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public Dto.PagamentoDto ReadPagamento(Dto.PagamentoUnificatoFatturaAcquistoDto pagamentoUnificatoFatturaAcquisto)
        {
            try
            {
                if (pagamentoUnificatoFatturaAcquisto != null)
                {
                    var ef = new DataLayer.EntitiesModel();
                    var pagamento = (from q in ef.Pagamentos
                                     where q.FatturaAcquistoId == pagamentoUnificatoFatturaAcquisto.FatturaAcquistoId &&
                                         q.PagamentoUnificatoId == pagamentoUnificatoFatturaAcquisto.PagamentoUnificatoId
                                     select q).FirstOrDefault();

                    var pagamentoDto = UtilityPOCO.Assemble<Dto.PagamentoDto>(pagamento);
                    return pagamentoDto;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public Dto.PagamentoDto ReadPagamentoOld(Dto.PagamentoUnificatoDto pagamentoUnificato, Dto.FatturaAcquistoDto fatturaAcquisto)
        {
            try
            {
                if (pagamentoUnificato != null && fatturaAcquisto != null)
                {
                    var ef = new DataLayer.EntitiesModel();
                    var pagamento = (from q in ef.Pagamentos
                                     where q.FatturaAcquistoId == fatturaAcquisto.Id && q.PagamentoUnificatoId == pagamentoUnificato.Id
                                     select q).FirstOrDefault();

                    var pagamentoDto = UtilityPOCO.Assemble<Dto.PagamentoDto>(pagamento);
                    return pagamentoDto;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.PagamentoDto> ReadPagamenti(DateTime start, DateTime end, string search=null, object advancedSearch = null) 
        {
            try
            {
                var pagamenti = QueryPagamenti(search, advancedSearch,null,null, start, end);
                var pagamentiDto = UtilityPOCO.Assemble<Dto.PagamentoDto>(pagamenti);
                return pagamentiDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }


        #endregion
        #endregion

        #region NotaCredito
        #region CRUD
        public Dto.NotaCreditoDto CreateNotaCredito(Dto.NotaCreditoDto notaCredito)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateNotaCredito(notaCredito);
                var id = UtilityPOCO.GetId(dtoKey);
                var newNotaCredito = ReadNotaCredito(id);
                return newNotaCredito;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.NotaCreditoDto> ReadNoteCredito()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var noteCredito = wcf.ReadNotaCreditos();
                return noteCredito;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateNotaCredito(Dto.NotaCreditoDto notaCredito)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateNotaCredito(notaCredito);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteNotaCredito(Dto.NotaCreditoDto notaCredito)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteNotaCredito(notaCredito);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountNoteCredito()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.NotaCreditosCount();
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

        public IEnumerable<Dto.NotaCreditoDto> LoadNoteCredito(int skip, int take, string search = null, object advancedSearch = null, Dto.FornitoreDto fornitore = null, 
            object orderBy = null)
        {
            try
            {
                var noteCredito = QueryNoteCredito(search, advancedSearch, fornitore, orderBy);
                noteCredito = (from q in noteCredito select q).Skip(skip).Take(take);

                var noteCreditoDto = UtilityPOCO.Assemble<Dto.NotaCreditoDto>(noteCredito);
                return noteCreditoDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountNoteCredito(string search = null, object advancedSearch = null, Dto.FornitoreDto fornitore = null)
        {
            try
            {
                var noteCredito = QueryNoteCredito(search, advancedSearch, fornitore);
                var count = noteCredito.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.NotaCreditoDto ReadNotaCredito(object id)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var notaCredito = (from q in ef.NotaCreditos where q.Id == (int)id select q).FirstOrDefault();
                var notaCreditoDto = UtilityPOCO.Assemble<Dto.NotaCreditoDto>(notaCredito);
                return notaCreditoDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.NotaCredito> QueryNoteCredito(string search = null, object advancedSearch = null, Dto.FornitoreDto fornitore = null, object orderBy = null)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var noteCredito = (from q in ef.NotaCreditos select q);
                if(fornitore!=null)
                    noteCredito = (from q in noteCredito where q.FornitoreId == fornitore.Id select q);

                if (advancedSearch != null)
                    noteCredito = noteCredito.Where((Func<DataLayer.NotaCredito, bool>)advancedSearch).AsQueryable();

                if (search != null && search.Length > 0)
                {
                    var fornitoreId = (from q in QueryFornitori(search) select q.Id).ToList();
                    noteCredito = (from q in noteCredito
                                 where q.Note.Contains(search) ||
                                     fornitoreId.Contains(q.FornitoreId)
                                 select q);
                }
                noteCredito = (from q in noteCredito orderby q.Id descending select q);
                if (orderBy != null)
                    noteCredito = noteCredito.OrderBy((Func<DataLayer.NotaCredito, object>)orderBy).AsQueryable();
                
                return noteCredito;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        #endregion
        #endregion

        #region Reso
        #region CRUD
        public Dto.ResoDto CreateReso(Dto.ResoDto reso)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateReso(reso);
                var id = UtilityPOCO.GetId(dtoKey);
                var newReso = ReadReso(id);
                return newReso;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.ResoDto> ReadResi()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var resi = wcf.ReadResos();
                return resi;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateReso(Dto.ResoDto reso)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateReso(reso);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteReso(Dto.ResoDto reso)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteReso(reso);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountResi()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.ResosCount();
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
        public IEnumerable<Dto.ResoDto> LoadResi(int skip, int take, string search = null, object advancedSearch = null, Dto.NotaCreditoDto notaCredito = null,
            Dto.FatturaAcquistoDto fatturaAcquisto = null, object orderBy = null)
        {
            try
            {
                var reso = QueryResi(search, advancedSearch, notaCredito, fatturaAcquisto, orderBy);
                reso = (from q in reso select q).Skip(skip).Take(take);

                var resiDto = UtilityPOCO.Assemble<Dto.ResoDto>(reso);
                return resiDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountResi(string search = null, object advancedSearch = null, Dto.NotaCreditoDto notaCredito = null, Dto.FatturaAcquistoDto fatturaAcquisto = null)
        {
            try
            {
                var resi = QueryResi(search, advancedSearch, notaCredito, fatturaAcquisto);
                var count = resi.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.ResoDto ReadReso(object id)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var reso = (from q in ef.Resos where q.Id == (int)id select q).FirstOrDefault();
                var resoDto = UtilityPOCO.Assemble<Dto.ResoDto>(reso);
                return resoDto;

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.Reso> QueryResi(string search = null, object advancedSearch = null, Dto.NotaCreditoDto notaCredito = null,
            Dto.FatturaAcquistoDto fatturaAcquisto = null, object orderBy = null)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var resi = (from q in ef.Resos select q);
                if(notaCredito!=null)
                    resi = (from q in resi where q.NotaCreditoId == notaCredito.Id select q);

                if(fatturaAcquisto!=null)
                    resi = (from q in resi where q.FatturaAcquistoId == fatturaAcquisto.Id select q);

                if (advancedSearch != null)
                    resi = resi.Where((Func<DataLayer.Reso, bool>)advancedSearch).AsQueryable();

                if (search != null && search.Length > 0)
                {
                    var notaCreditoId = (from q in QueryNoteCredito(search) select q.Id).ToList();
                    resi = (from q in resi
                                 where q.Note.Contains(search) ||
                                     notaCreditoId.Contains(q.NotaCreditoId)
                                 select q);
                }
                resi = (from q in resi orderby q.Id descending select q);
                if (orderBy != null)
                    resi = resi.OrderBy((Func<DataLayer.Reso, object>)orderBy).AsQueryable();
                
                return resi;
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
                var id = UtilityPOCO.GetId(dtoKey);
                var newPagamentoUnificato = ReadPagamentoUnificato(id);
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
        public IEnumerable<Dto.PagamentoUnificatoDto> LoadPagamentiUnificati(int skip, int take, string search = null, object advancedSearch = null, object orderBy = null)
        {
            try
            {
                var pagamentiUnificati = QueryPagamentiUnificati(search, advancedSearch, orderBy);
                pagamentiUnificati = (from q in pagamentiUnificati select q).Skip(skip).Take(take);

                var pagamentiUnificatiDto = UtilityPOCO.Assemble<Dto.PagamentoUnificatoDto>(pagamentiUnificati, true ); //lettura iterativa
                return pagamentiUnificatiDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountPagamentiUnificati(string search = null, object advancedSearch = null)
        {
            try
            {
                var pagamentiUnificati = QueryPagamentiUnificati(search, advancedSearch);
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

                var pagamentoUnificatoDto = UtilityPOCO.Assemble<Dto.PagamentoUnificatoDto>(pagamentoUnificato, true);
                return pagamentoUnificatoDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.PagamentoUnificato> QueryPagamentiUnificati(string search = null, object advancedSearch = null, object orderBy = null)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var pagamentiUnificati = (from q in ef.PagamentoUnificatos select q);

                if (advancedSearch != null)
                    pagamentiUnificati = pagamentiUnificati.Where((Func<DataLayer.PagamentoUnificato, bool>)advancedSearch).AsQueryable();

                if (search != null && search.Length > 0)
                {
                    var codiciFornitori = (from q in QueryFornitori(search) select q.Codice).ToList();
                    pagamentiUnificati = (from q in pagamentiUnificati
                                 where q.Note.Contains(search) ||
                                     codiciFornitori.Contains(q.CodiceFornitore)
                                 select q);
                }
                pagamentiUnificati = (from q in pagamentiUnificati orderby q.Id descending select q);
                if (orderBy != null)
                    pagamentiUnificati = pagamentiUnificati.OrderBy((Func<DataLayer.PagamentoUnificato, object>)orderBy).AsQueryable();
               
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
                var id = UtilityPOCO.GetId(dtoKey);
                var newPagamentoUnificato = ReadPagamentoUnificatoFatturaAcquisto(id);
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
        public IEnumerable<Dto.PagamentoUnificatoFatturaAcquistoDto> LoadPagamentiUnificatiFatturaAcquisto(int skip, int take, string search = null, object advancedSearch = null,
            Dto.PagamentoUnificatoDto pagamentoUnificato = null, object orderBy = null)
        {
            try
            {
                var pagamentiUnificatiFatturaAcquisto = QueryPagamentiUnificatiFatturaAcquisto(search, advancedSearch, pagamentoUnificato, orderBy);
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

        public int CountPagamentiUnificatiFatturaAcquisto(string search = null, object advancedSearch = null, Dto.PagamentoUnificatoDto pagamentoUnificato = null)
        {
            try
            {
                var pagamentiUnificatiFatturaAcquisto = QueryPagamentiUnificatiFatturaAcquisto(search, advancedSearch, pagamentoUnificato);
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

        private IQueryable<DataLayer.PagamentoUnificatoFatturaAcquisto> QueryPagamentiUnificatiFatturaAcquisto(string search = null, object advancedSearch = null,
            Dto.PagamentoUnificatoDto pagamentoUnificato = null, object orderBy = null)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var pagamentiUnificatiFatturaAcquisto = (from q in ef.PagamentoUnificatoFatturaAcquistos select q);
                if(pagamentoUnificato!=null)
                    pagamentiUnificatiFatturaAcquisto = (from q in pagamentiUnificatiFatturaAcquisto where q.PagamentoUnificatoId == pagamentoUnificato.Id select q);

                if (advancedSearch != null)
                    pagamentiUnificatiFatturaAcquisto = pagamentiUnificatiFatturaAcquisto.Where((Func<DataLayer.PagamentoUnificatoFatturaAcquisto, bool>)advancedSearch).AsQueryable();

                if (search != null && search.Length > 0)
                {
                    var fatturaAcquistoId = (from q in QueryFattureAcquisto(search) select q.Id).ToList();
                    pagamentiUnificatiFatturaAcquisto = (from q in pagamentiUnificatiFatturaAcquisto
                                          where q.Note.Contains(search) ||
                                              fatturaAcquistoId.Contains(q.FatturaAcquistoId)
                                          select q);
                }
                pagamentiUnificatiFatturaAcquisto = (from q in pagamentiUnificatiFatturaAcquisto orderby q.Id descending select q);
                if (orderBy != null)
                    pagamentiUnificatiFatturaAcquisto = pagamentiUnificatiFatturaAcquisto.OrderBy((Func<DataLayer.PagamentoUnificatoFatturaAcquisto, object>)orderBy).AsQueryable();
            
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

        #region Committente
        #region CRUD
        public Dto.CommittenteDto CreateCommittente(Dto.CommittenteDto committente)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateCommittente(committente);
                var id = UtilityPOCO.GetId(dtoKey);
                var newCommittente = ReadCommittente(id);
                return newCommittente;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.CommittenteDto> ReadCommittenti()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var committenti = wcf.ReadCommittentes();
                return committenti;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateCommittente(Dto.CommittenteDto committente)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateCommittente(committente);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteCommittente(Dto.CommittenteDto committente)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteCommittente(committente);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountCommittenti()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.CommittentesCount();
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

        public IEnumerable<Dto.CommittenteDto> LoadCommittenti(int skip, int take, string search = null, object advancedSearch = null, Dto.CommessaDto commessa = null, 
            object orderBy = null)
        {
            try
            {
                var committenti = QueryCommittenti(search, advancedSearch, commessa, orderBy);
                committenti = (from q in committenti select q).Skip(skip).Take(take);

                var committentiDto = UtilityPOCO.Assemble<Dto.CommittenteDto>(committenti, true); //lettura ricorsiva
                return committentiDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountCommittenti(string search = null, object advancedSearch = null, Dto.CommessaDto commessa = null)
        {
            try
            {
                var committenti = QueryCommittenti(search, advancedSearch, commessa);
                var count = committenti.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.CommittenteDto ReadCommittente(object id)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var committente = (from q in ef.Committentes where q.Id == (int)id select q).FirstOrDefault();
                var committenteDto = UtilityPOCO.Assemble<Dto.CommittenteDto>(committente, true);
                return committenteDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.Committente> QueryCommittenti(string search = null, object advancedSearch = null, Dto.CommessaDto commessa = null, object orderBy = null)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var committenti = (from q in ef.Committentes select q);
                if(commessa!=null)
                    committenti = (from q in committenti where q.CommessaId == commessa.Id select q);

                if (advancedSearch != null)
                    committenti = committenti.Where((Func<DataLayer.Committente, bool>)advancedSearch).AsQueryable();

                if (search != null && search.Length > 0)
                {
                    var commesseId = (from c in QueryCommesse(search) select c.Id).ToList();
                    committenti = (from q in committenti
                               where q.Codice.StartsWith(search) || q.PartitaIva.StartsWith(search) ||
                                 q.RagioneSociale.StartsWith(search) || q.Indirizzo.Contains(search) ||
                                 q.Comune.StartsWith(search) || q.Provincia.StartsWith(search) ||
                                 commesseId.Contains(q.Commessa.Id)
                               select q);
                }
                committenti = (from q in committenti orderby q.RagioneSociale select q);
                if (orderBy != null)
                    committenti = committenti.OrderBy((Func<DataLayer.Committente, object>)orderBy).AsQueryable();
               
                return committenti;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.CommittenteDto> ReadCommittenti(Dto.CommessaDto commessa)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var committenti = (from q in ef.Committentes where q.CommessaId == commessa.Id select q);
                var committentiDto = UtilityPOCO.Assemble<Dto.CommittenteDto>(committenti);
                return committentiDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.CommittenteDto> ReadCommittenti(Dto.AnagraficaCommittenteDto anagraficaCommittente)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var committenti = (from q in ef.Committentes where q.Codice == anagraficaCommittente.Codice select q);
                var committentiDto = UtilityPOCO.Assemble<Dto.CommittenteDto>(committenti, true); //lettura ricorsiva
                return committentiDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.CommittenteDto> ReadCommittenti(IEnumerable<Dto.AnagraficaCommittenteDto> anagraficheCommittenti)
        {
            try
            {
                if (anagraficheCommittenti != null)
                {
                    var ef = new DataLayer.EntitiesModel();
                    var codiciCommittenti = (from q in anagraficheCommittenti select q.Codice).ToList();
                    var committenti = (from q in ef.Committentes where codiciCommittenti.Contains(q.Codice) select q);
                    var committentiDto = UtilityPOCO.Assemble<Dto.CommittenteDto>(committenti, true); //lettura ricorsiva
                    return committentiDto;
                }
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
                var id = UtilityPOCO.GetId(dtoKey);
                var newFatturaVendita = ReadFatturaVendita(id);
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

        public IEnumerable<Dto.FatturaVenditaDto> LoadFattureVendita(int skip, int take, string search = null, object advancedSearch = null, Dto.CommittenteDto committente = null, 
            object orderBy = null)
        {
            try
            {
                var fattureVendita = QueryFattureVendita(search, advancedSearch, committente, orderBy);
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

        public int CountFattureVendita(string search = null, object advancedSearch = null, Dto.CommittenteDto committente = null)
        {
            try
            {
                var fattureVendita = QueryFattureVendita(search, advancedSearch, committente);
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

        private IQueryable<DataLayer.FatturaVendita> QueryFattureVendita(string search = null, object advancedSearch = null, Dto.CommittenteDto committente = null, object orderBy = null)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var fattureVendita = (from q in ef.FatturaVenditas select q);
                if(committente!=null)
                    fattureVendita = (from q in fattureVendita where q.CommittenteId == committente.Id select q);

                if (advancedSearch != null)
                    fattureVendita = fattureVendita.Where((Func<DataLayer.FatturaVendita, bool>)advancedSearch).AsQueryable();

                if (search != null && search.Length > 0)
                {
                    var committentiId = (from c in QueryCommittenti(search) select c.Id).ToList();
                    fattureVendita = (from q in fattureVendita
                                      where q.Numero.StartsWith(search) || q.Descrizione.Contains(search) || q.TipoPagamento.StartsWith(search) ||
                                          committentiId.Contains(q.CommittenteId)
                                      select q);
                }
                fattureVendita = (from q in fattureVendita orderby q.Id descending select q);
                if (orderBy != null)
                    fattureVendita = fattureVendita.OrderBy((Func<DataLayer.FatturaVendita, object>)orderBy).AsQueryable();
             
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

        #region Incasso
        #region CRUD
        public Dto.IncassoDto CreateIncasso(Dto.IncassoDto incasso)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateIncasso(incasso);
                var id = UtilityPOCO.GetId(dtoKey);
                var newIncasso = ReadIncasso(id);
                return newIncasso;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.IncassoDto> ReadIncassi()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var incassi = wcf.ReadIncassos();
                return incassi;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateIncasso(Dto.IncassoDto incasso)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateIncasso(incasso);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteIncasso(Dto.IncassoDto incasso)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteIncasso(incasso);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountIncassi()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.IncassosCount();
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
        public IEnumerable<Dto.IncassoDto> LoadIncassi(int skip, int take, string search = null, object advancedSearch = null, Dto.CommittenteDto committente = null,
            Dto.FatturaVenditaDto fatturaVendita = null, object orderBy = null)
        {
            try
            {
                var incassi = QueryIncassi(search, advancedSearch, committente, fatturaVendita, orderBy);
                incassi = (from q in incassi select q).Skip(skip).Take(take);

                var incassiDto = UtilityPOCO.Assemble<Dto.IncassoDto>(incassi);
                return incassiDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountIncassi(string search = null, object advancedSearch = null, Dto.CommittenteDto committente = null, Dto.FatturaVenditaDto fatturaVendita = null)
        {
            try
            {
                var incassi = QueryIncassi(search, advancedSearch, committente, fatturaVendita);
                var count = incassi.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.IncassoDto ReadIncasso(object id)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var incasso = (from q in ef.Incassos where q.Id == (int)id select q).FirstOrDefault();
                var incassoDto = UtilityPOCO.Assemble<Dto.IncassoDto>(incasso);
                return incassoDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.Incasso> QueryIncassi(string search = null, object advancedSearch = null, Dto.CommittenteDto committente = null, 
            Dto.FatturaVenditaDto fatturaVendita = null, object orderBy = null)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var incassi = (from q in ef.Incassos select q);
                if(fatturaVendita!=null)
                    incassi = (from q in incassi where q.FatturaVenditaId == fatturaVendita.Id select q);

                if (committente != null)
                {
                    var fattureVendita = committente.FatturaVenditas;
                    if (fattureVendita != null)
                    {
                        var fattureVenditaIds = (from q in fattureVendita select q.Id);
                        incassi = (from q in incassi where fattureVenditaIds.Contains(q.FatturaVenditaId) select q);
                    }
                }

                if (advancedSearch != null)
                    incassi = incassi.Where((Func<DataLayer.Incasso, bool>)advancedSearch).AsQueryable();

                if (search != null && search.Length > 0)
                {
                    var fattureVenditaId = (from q in QueryFattureVendita(search) select q.Id).ToList();
                    incassi = (from q in incassi
                                    where q.Note.Contains(search) ||
                                        fattureVenditaId.Contains(q.FatturaVenditaId)
                                    select q);
                }
                incassi = (from q in incassi orderby q.Id descending select q);
                if (orderBy != null)
                    incassi = incassi.OrderBy((Func<DataLayer.Incasso, object>)orderBy).AsQueryable();
            
                return incassi;
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
                var id = UtilityPOCO.GetId(dtoKey);
                var newSAL = ReadSAL(id);
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

        public IEnumerable<Dto.SALDto> LoadSALs(int skip, int take, string search = null, object advancedSearch = null, Dto.CommessaDto commessa = null, object orderBy = null)
        {
            try
            {
                var sals = QuerySALs(search, advancedSearch, commessa, orderBy);
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

        public int CountSALs(string search = null, object advancedSearch = null, Dto.CommessaDto commessa = null)
        {
            try
            {
                var sals = QuerySALs(search, advancedSearch, commessa);
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
                var ef = new DataLayer.EntitiesModel();
                var sal = (from q in ef.SALs where q.Id == (int)id select q).FirstOrDefault();
                var salDto = UtilityPOCO.Assemble<Dto.SALDto>(sal);
                return salDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.SAL> QuerySALs(string search = null, object advancedSearch = null, Dto.CommessaDto commessa = null, object orderBy = null)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var sals = (from q in ef.SALs select q);
                if(commessa!=null)
                    sals = (from q in sals where q.CommessaId == commessa.Id select q);

                if (advancedSearch != null)
                    sals = sals.Where((Func<DataLayer.SAL, bool>)advancedSearch).AsQueryable();

                if (search != null && search.Length > 0)
                {
                    var commesseId = (from c in QueryCommesse(search) select c.Id).ToList();
                    sals = (from q in sals
                            where q.Codice.StartsWith(search) || q.Denominazione.StartsWith(search) ||
                                commesseId.Contains(q.CommessaId)
                            select q);
                }
                sals = (from q in sals orderby q.Id descending select q);
                if (orderBy != null)
                    sals = sals.OrderBy((Func<DataLayer.SAL, object>)orderBy).AsQueryable();
                
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
        public IEnumerable<Dto.AnagraficaFornitoreDto> LoadAnagraficheFornitori(int skip, int take, string search = null, object advancedSearch = null, object orderBy = null)
        {
            try
            {
                var anagraficheFornitori = QueryAnagraficheFornitori(search, advancedSearch, orderBy);
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

        public int CountAnagraficheFornitori(string search = null, object advancedSearch = null)
        {
            try
            {
                var anagraficheFornitori = QueryAnagraficheFornitori(search, advancedSearch);
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
                var ef = new DataLayer.EntitiesModel();
                var anagraficaFornitore = (from q in ef.AnagraficaFornitores where q.Id == (int)id select q).FirstOrDefault();
                var anagraficaFornitoreDto = UtilityPOCO.Assemble<Dto.AnagraficaFornitoreDto>(anagraficaFornitore);
                return anagraficaFornitoreDto;
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

        private IQueryable<DataLayer.AnagraficaFornitore> QueryAnagraficheFornitori(string search = null, object advancedSearch = null, object orderBy = null)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var anagraficheFornitori = (from q in ef.AnagraficaFornitores select q);

                if (advancedSearch != null)
                    anagraficheFornitori = anagraficheFornitori.Where((Func<DataLayer.AnagraficaFornitore, bool>)advancedSearch).AsQueryable();

                if (search != null && search.Length > 0)
                    anagraficheFornitori = (from q in anagraficheFornitori
                                            where q.Codice.StartsWith(search) || q.PartitaIva.StartsWith(search) ||
                                                q.RagioneSociale.StartsWith(search) || q.Indirizzo.Contains(search) ||
                                                q.Comune.StartsWith(search) || q.Provincia.StartsWith(search)
                                            select q);

                anagraficheFornitori = (from q in anagraficheFornitori orderby q.RagioneSociale select q);
                if (orderBy != null)
                    anagraficheFornitori = anagraficheFornitori.OrderBy((Func<DataLayer.AnagraficaFornitore, object>)orderBy).AsQueryable();
                
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

        #region AnagraficaCommittente
        #region CRUD
        public Dto.AnagraficaCommittenteDto CreateAnagraficaCommittente(Dto.AnagraficaCommittenteDto anagraficaCiente)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateAnagraficaCommittente(anagraficaCiente);
                var newAnagraficaCommittente = wcf.ReadAnagraficaCommittente(dtoKey);
                return newAnagraficaCommittente;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.AnagraficaCommittenteDto> ReadAnagraficheCommittenti()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var anagraficheCommittenti = wcf.ReadAnagraficaCommittentes();
                return anagraficheCommittenti;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateAnagraficaCommittente(Dto.AnagraficaCommittenteDto anagraficaCommittente)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateAnagraficaCommittente(anagraficaCommittente);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteAnagraficaCommittente(Dto.AnagraficaCommittenteDto anagraficaCommittente)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteAnagraficaCommittente(anagraficaCommittente);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountAnagraficheCommittenti()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.AnagraficaCommittentesCount();
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
        public IEnumerable<Dto.AnagraficaCommittenteDto> LoadAnagraficheCommittenti(int skip, int take, string search = null, object advancedSearch = null, object orderBy = null)
        {
            try
            {
                var anagraficheCommittenti = QueryAnagraficheCommittenti(search, advancedSearch, orderBy);
                anagraficheCommittenti = (from q in anagraficheCommittenti select q).Skip(skip).Take(take);

                var anagraficheCommittentiDto = UtilityPOCO.Assemble<Dto.AnagraficaCommittenteDto>(anagraficheCommittenti);
                return anagraficheCommittentiDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountAnagraficheCommittenti(string search = null, object advancedSearch = null)
        {
            try
            {
                var anagraficheCommittenti = QueryAnagraficheCommittenti(search, advancedSearch);
                var count = anagraficheCommittenti.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.AnagraficaCommittenteDto ReadAnagraficaCommittente(object id)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var anagraficaCommittente = (from q in ef.AnagraficaFornitores where q.Id == (int)id select q).FirstOrDefault();
                var anagraficaCommittenteDto = UtilityPOCO.Assemble<Dto.AnagraficaCommittenteDto>(anagraficaCommittente);
                return anagraficaCommittenteDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public Dto.AnagraficaCommittenteDto ReadAnagraficaCommittente(string codice)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var anagraficaCommittente = (from q in ef.AnagraficaCommittentes where q.Codice == codice select q).FirstOrDefault();
                var anagraficaCommittenteDto = UtilityPOCO.Assemble<Dto.AnagraficaCommittenteDto>(anagraficaCommittente);
                return anagraficaCommittenteDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.AnagraficaCommittente> QueryAnagraficheCommittenti(string search = null, object advancedSearch = null, object orderBy = null)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var anagraficheCommittenti = (from q in ef.AnagraficaCommittentes select q);

                if (advancedSearch != null)
                    anagraficheCommittenti = anagraficheCommittenti.Where((Func<DataLayer.AnagraficaCommittente, bool>)advancedSearch).AsQueryable();

                if (search != null && search.Length > 0)
                    anagraficheCommittenti = (from q in anagraficheCommittenti where q.Codice.StartsWith(search) || q.PartitaIva.StartsWith(search) ||
                                              q.RagioneSociale.StartsWith(search) || q.Indirizzo.Contains(search) ||
                                              q.Comune.StartsWith(search) || q.Provincia.StartsWith(search) select q);

                anagraficheCommittenti = (from q in anagraficheCommittenti orderby q.RagioneSociale select q);
                if (orderBy != null)
                    anagraficheCommittenti = anagraficheCommittenti.OrderBy((Func<DataLayer.AnagraficaCommittente, object>)orderBy).AsQueryable();
               
                return anagraficheCommittenti;
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
        public IEnumerable<Dto.AnagraficaArticoloDto> LoadAnagraficheArticoli(int skip, int take, string search = null, object advancedSearch = null, object orderBy = null)
        {
            try
            {
                var anagraficheArticoli = QueryAnagraficheArticoli(search, advancedSearch, orderBy);
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

        public int CountAnagraficheArticoli(string search = null, object advancedSearch = null)
        {
            try
            {
                var anagraficheArticoli = QueryAnagraficheArticoli(search, advancedSearch);
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
                var ef = new DataLayer.EntitiesModel();
                var anagraficaArticolo = (from q in ef.AnagraficaFornitores where q.Id == (int)id select q).FirstOrDefault();
                var anagraficaArticoloDto = UtilityPOCO.Assemble<Dto.AnagraficaArticoloDto>(anagraficaArticolo);
                return anagraficaArticoloDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.AnagraficaArticolo> QueryAnagraficheArticoli(string search = null, object advancedSearch = null, object orderBy = null)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var anagraficheArticoli = (from q in ef.AnagraficaArticolos select q);

                if (advancedSearch != null)
                    anagraficheArticoli = anagraficheArticoli.Where((Func<DataLayer.AnagraficaArticolo, bool>)advancedSearch).AsQueryable();

                if (search != null && search.Length > 0)
                    anagraficheArticoli = (from q in anagraficheArticoli where q.Codice.StartsWith(search) || q.Descrizione.Contains(search) select q);

                anagraficheArticoli = (from q in anagraficheArticoli orderby q.Codice select q);
                if (orderBy != null)
                    anagraficheArticoli = anagraficheArticoli.OrderBy((Func<DataLayer.AnagraficaArticolo, object>)orderBy).AsQueryable();
               
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
        public IEnumerable<Dto.ReportJobDto> LoadReportJobs(int skip, int take, string search = null, object advancedSearch = null, object orderBy = null)
        {
            try
            {
                var reportJobs = QueryReportJobs(search, advancedSearch, orderBy);
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

        public int CountReportJobs(string search = null, object advancedSearch = null)
        {
            try
            {
                var reportJobs = QueryReportJobs(search, advancedSearch);
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
                var ef = new DataLayer.EntitiesModel();
                var reportJob = (from q in ef.ReportJobs where q.Id == (int)id select q).FirstOrDefault();
                var reportJobDto = UtilityPOCO.Assemble<Dto.ReportJobDto>(reportJob);
                return reportJobDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.ReportJob> QueryReportJobs(string search = null, object advancedSearch = null, object orderBy = null)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var reportJobs = (from q in ef.ReportJobs select q);

                if (advancedSearch != null)
                    reportJobs = reportJobs.Where((Func<DataLayer.ReportJob, bool>)advancedSearch).AsQueryable();

                if (search != null && search.Length > 0)
                    reportJobs = (from q in reportJobs where q.Codice.StartsWith(search) || q.CodiceFornitore.Contains(search) select q);

                reportJobs = (from q in reportJobs orderby q.Id descending select q);
                if (orderBy != null)
                    reportJobs = reportJobs.OrderBy((Func<DataLayer.ReportJob, object>)orderBy).AsQueryable();
                
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
