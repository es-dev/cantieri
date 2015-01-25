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
                var engine = new Assemblers.AziendaAssembler();
                var aziendeDto = engine.Assemble(aziende);
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

        public Dto.AziendaDto ReadAzienda(object Id)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var azienda = wcf.ReadAzienda("Id=" + Id);
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
                    aziende = (from q in aziende where q.Codice.StartsWith(search) || q.Denominazione.Contains(search) || q.Comune.StartsWith(search) || q.Indirizzo.Contains(search) ||
                                   q.Provincia.StartsWith(search) select q);

                aziende = (from q in aziende orderby q.Denominazione select q);
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
                var engine = new Assemblers.CommessaAssembler();
                var commesseDto = new List<Dto.CommessaDto>();
                foreach (var commessa in commesse)
                {
                    var commessaDto = engine.Assemble(commessa);
                    engine.AssembleNavigational(commessa, commessaDto);
                    commesseDto.Add(commessaDto);
                }
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

        public Dto.CommessaDto ReadCommessa(object Id)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var commessa = wcf.ReadCommessa("Id=" + Id);
                return commessa;
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
                var engine = new Assemblers.FornitoreAssembler();
                var fornitoriDto = new List<Dto.FornitoreDto>();
                foreach (var fornitore in fornitori)
                {
                    var fornitoreDto = engine.Assemble(fornitore);
                    engine.AssembleNavigational(fornitore, fornitoreDto);
                    fornitoriDto.Add(fornitoreDto);
                }

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

        public Dto.FornitoreDto ReadFornitore(object Id)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var fornitore = wcf.ReadFornitore("Id=" + Id);
                return fornitore;
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
                                 where q.Codice.StartsWith(search) || q.PIva.StartsWith(search) ||
                                     q.RagioneSociale.StartsWith(search) || q.Indirizzo.Contains(search) ||
                                     q.Comune.StartsWith(search) || q.Provincia.StartsWith(search) ||
                                     commesseId.Contains(q.CommessaId)
                                 select q);
                }
                fornitori = (from q in fornitori orderby q.PIva select q);
                return fornitori;
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
                var engine = new Assemblers.CentroCostoAssembler();
                var centriCostoDto = new List<Dto.CentroCostoDto>();
                foreach (var centroCosto in centriCosto)
                {
                    var centroCostoDto = engine.Assemble(centroCosto);
                    engine.AssembleNavigational(centroCosto, centroCostoDto);
                    centriCostoDto.Add(centroCostoDto);
                }
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

        public Dto.CentroCostoDto ReadCentroCosto(object Id)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var centroCosto = wcf.ReadCentroCosto("Id=" + Id);
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
                var engine = new Assemblers.FatturaAcquistoAssembler();
                var fattureAcquistoDto = new List<Dto.FatturaAcquistoDto>();
                foreach (var fatturaAcquisto in fattureAcquisto)
                {
                    var fatturaAcquistoDto = engine.Assemble(fatturaAcquisto);
                    engine.AssembleNavigational(fatturaAcquisto, fatturaAcquistoDto);
                    fattureAcquistoDto.Add(fatturaAcquistoDto);
                }
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

        public Dto.FatturaAcquistoDto ReadFatturaAcquisto(object Id)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var fatturaAcquisto = wcf.ReadFatturaAcquisto("Id=" + Id);
                return fatturaAcquisto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.FatturaAcquisto> QueryFattureAcquisto(string search)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var fattureAcquisto = (from q in ef.FatturaAcquistos select q);
                if (search != null && search.Length > 0)
                {
                    var fornitoriId = (from f in QueryFornitori(search) select f.Id).ToList();
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
                var engine = new Assemblers.ArticoloAssembler();
                var articoliDto = new List<Dto.ArticoloDto>();
                foreach (var articolo in articoli)
                {
                    var articoloDto = engine.Assemble(articolo);
                    engine.AssembleNavigational(articolo, articoloDto);
                    articoliDto.Add(articoloDto);
                }
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

        public Dto.ArticoloDto ReadArticolo(object Id)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var articolo = wcf.ReadArticolo("Id=" + Id);
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
                    var fattureAcquistoId = (from f in QueryFattureAcquisto(search) select f.Id).ToList();
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
                var engine = new Assemblers.PagamentoAssembler();
                var pagamentiDto = new List<Dto.PagamentoDto>();
                foreach (var pagamento in pagamenti)
                {
                    var pagamentoDto = engine.Assemble(pagamento);
                    engine.AssembleNavigational(pagamento, pagamentoDto);
                    pagamentiDto.Add(pagamentoDto);
                }
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

        public Dto.PagamentoDto ReadPagamento(object Id)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var pagamento = wcf.ReadPagamento("Id=" + Id);
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
                    var fattureAcquistoId = (from f in QueryFattureAcquisto(search) select f.Id).ToList();
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
                var engine = new Assemblers.ClienteAssembler();
                var clientiDto = new List<Dto.ClienteDto>();
                foreach (var cliente in clienti)
                {
                    var clienteDto = engine.Assemble(cliente);
                    engine.AssembleNavigational(cliente, clienteDto);
                    clientiDto.Add(clienteDto);
                }
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

        public Dto.ClienteDto ReadCliente(object Id)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var cliente = wcf.ReadCliente("Id=" + Id);
                return cliente;
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
                               where q.Codice.StartsWith(search) || q.PIva.StartsWith(search) ||
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
                var engine = new Assemblers.FatturaVenditaAssembler();
                var fattureVenditaDto = new List<Dto.FatturaVenditaDto>();
                foreach (var fatturaVendita in fattureVendita)
                {
                    var fatturaVenditaDto = engine.Assemble(fatturaVendita);
                    engine.AssembleNavigational(fatturaVendita, fatturaVenditaDto);
                    fattureVenditaDto.Add(fatturaVenditaDto);
                }
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

        public Dto.FatturaVenditaDto ReadFatturaVendita(object Id)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var fatturaVendita = wcf.ReadFatturaVendita("Id=" + Id);
                return fatturaVendita;
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
                var engine = new Assemblers.LiquidazioneAssembler();
                var liquidazioniDto = new List<Dto.LiquidazioneDto>();
                foreach (var liquidazione in liquidazioni)
                {
                    var liquidazioneDto = engine.Assemble(liquidazione);
                    engine.AssembleNavigational(liquidazione, liquidazioneDto);
                    liquidazioniDto.Add(liquidazioneDto);
                }
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

        public Dto.LiquidazioneDto ReadLiquidazione(object Id)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var liquidazione = wcf.ReadLiquidazione("Id=" + Id);
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
                    var fattureVenditaId = (from f in QueryFattureVendita(search) select f.Id).ToList();
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
                var engine = new Assemblers.SALAssembler();
                var salsDto = new List<Dto.SALDto>();
                foreach (var sal in sals)
                {
                    var salDto = engine.Assemble(sal);
                    engine.AssembleNavigational(sal, salDto);
                    salsDto.Add(salDto);
                }
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

        public Dto.SALDto ReadSAL(object Id)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var SAL = wcf.ReadSAL("Id=" + Id);
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
                var engine = new Assemblers.AnagraficaFornitoreAssembler();
                var anagraficheFornitoriDto = new List<Dto.AnagraficaFornitoreDto>();
                foreach (var anagraficaFornitore in anagraficheFornitori)
                {
                    var anagraficaFornitoreDto = engine.Assemble(anagraficaFornitore);
                    engine.AssembleNavigational(anagraficaFornitore, anagraficaFornitoreDto);
                    anagraficheFornitoriDto.Add(anagraficaFornitoreDto);
                }
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

        public Dto.AnagraficaFornitoreDto ReadAnagraficaFornitore(object Id)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var anagraficaFornitore = wcf.ReadAnagraficaFornitore("Id=" + Id);
                return anagraficaFornitore;
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
                                            where q.Codice.StartsWith(search) || q.PIva.StartsWith(search) ||
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
                var engine = new Assemblers.AnagraficaClienteAssembler();
                var anagraficheClientiDto = new List<Dto.AnagraficaClienteDto>();
                foreach (var anagraficaCliente in anagraficheClienti)
                {
                    var anagraficaClienteDto = engine.Assemble(anagraficaCliente);
                    engine.AssembleNavigational(anagraficaCliente, anagraficaClienteDto);
                    anagraficheClientiDto.Add(anagraficaClienteDto);
                }
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

        public Dto.AnagraficaClienteDto ReadAnagraficaCliente(object Id)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var anagraficaCliente = wcf.ReadAnagraficaCliente("Id=" + Id);
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
                    anagraficheClienti = (from q in anagraficheClienti where q.Codice.StartsWith(search) || q.PIva.StartsWith(search) ||
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
                var engine = new Assemblers.AnagraficaArticoloAssembler();
                var anagraficheArticoliDto = new List<Dto.AnagraficaArticoloDto>();
                foreach (var anagraficaArticolo in anagraficheArticoli)
                {
                    var anagraficaArticoloDto = engine.Assemble(anagraficaArticolo);
                    engine.AssembleNavigational(anagraficaArticolo, anagraficaArticoloDto);
                    anagraficheArticoliDto.Add(anagraficaArticoloDto);
                }
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

        public Dto.AnagraficaArticoloDto ReadAnagraficaArticolo(object Id)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var anagraficaArticolo = wcf.ReadAnagraficaArticolo("Id=" + Id);
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

    }
}
