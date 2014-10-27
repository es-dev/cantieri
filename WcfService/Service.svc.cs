﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Library.Code;

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

        private IQueryable<DataLayer.Azienda> QueryAziende(string search)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var aziende = (from q in ef.Aziendas select q);
                if (search != null)
                    aziende = (from q in aziende where q.Denominazione.StartsWith(search) select q);
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
                var commesseDto = engine.Assemble(commesse);
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

        private IQueryable<DataLayer.Commessa> QueryCommesse(string search)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var commesse = (from q in ef.Commessas select q);
                if (search != null)
                    commesse = (from q in commesse where q.Denominazione.StartsWith(search) select q);
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
                var fornitoriDto = engine.Assemble(fornitori);
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

        private IQueryable<DataLayer.Fornitore> QueryFornitori(string search)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var fornitori = (from q in ef.Fornitores select q);
                if (search != null)
                    fornitori = (from q in fornitori where q.PIva.StartsWith(search) select q);
                fornitori = (from q in fornitori orderby q.PIva  select q);
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
                var centriCostoDto = engine.Assemble(centriCosto);
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

        private IQueryable<DataLayer.CentroCosto> QueryCentriCosto(string search)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var centriCosto = (from q in ef.CentroCostos select q);
                if (search != null)
                    centriCosto = (from q in centriCosto where q.Denominazione.StartsWith(search) select q);
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
                var fattureAcquistoDto = engine.Assemble(fattureAcquisto);
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

        private IQueryable<DataLayer.FatturaAcquisto> QueryFattureAcquisto(string search)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var fattureAcquisto = (from q in ef.FatturaAcquistos select q);
                if (search != null)
                    fattureAcquisto = (from q in fattureAcquisto where q.Numero.StartsWith(search) select q);
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
                var articoliDto = engine.Assemble(articoli);
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

        private IQueryable<DataLayer.Articolo> QueryArticoli(string search)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var articoli = (from q in ef.Articolos select q);
                if (search != null)
                    articoli = (from q in articoli where q.Codice.StartsWith(search) select q);
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
                var pagamentiDto = engine.Assemble(pagamenti);
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

        private IQueryable<DataLayer.Pagamento> QueryPagamenti(string search)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var pagamenti = (from q in ef.Pagamentos select q);
                if (search != null)
                    pagamenti = (from q in pagamenti where q.Modalita.StartsWith(search) select q); //todo: da verificare
                pagamenti = (from q in pagamenti orderby q.Modalita select q);
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
                var clientiDto = engine.Assemble(clienti);
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

        private IQueryable<DataLayer.Cliente> QueryClienti(string search)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var clienti = (from q in ef.Clientes select q);
                if (search != null)
                    clienti = (from q in clienti where q.RagioneSociale.StartsWith(search) select q);
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
                var fattureVenditaDto = engine.Assemble(fattureVendita);
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

        private IQueryable<DataLayer.FatturaVendita> QueryFattureVendita(string search)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var fattureVendita = (from q in ef.FatturaVenditas select q);
                if (search != null)
                    fattureVendita = (from q in fattureVendita where q.Numero.StartsWith(search) select q);
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
                var liquidazioniDto = engine.Assemble(liquidazioni);
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

        private IQueryable<DataLayer.Liquidazione> QueryLiquidazioni(string search)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var liquidazioni = (from q in ef.Liquidaziones select q);
                if (search != null)
                    liquidazioni = (from q in liquidazioni where q.Modalita.StartsWith(search) select q);  //todo: da verificare
                liquidazioni = (from q in liquidazioni orderby q.Modalita select q);
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

        #region Statistica
        #region CRUD
        public Dto.StatisticaDto CreateStatistica(Dto.StatisticaDto statistica)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateStatistica(statistica);
                var newStatistica = wcf.ReadStatistica(dtoKey);
                return newStatistica;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.StatisticaDto> ReadStatistiche()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var statistiche = wcf.ReadStatisticas();
                return statistiche;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateStatistica(Dto.StatisticaDto statistica)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateStatistica(statistica);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteStatistica(Dto.StatisticaDto statistica)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteStatistica(statistica);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountStatistiche()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.StatisticasCount();
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
        public IEnumerable<Dto.StatisticaDto> LoadStatistiche(int skip, int take, string search = null)
        {
            try
            {
                var statistiche = QueryStatistiche(search);
                statistiche = (from q in statistiche select q).Skip(skip).Take(take);
                var engine = new Assemblers.StatisticaAssembler();
                var statisticheDto = engine.Assemble(statistiche);
                return statisticheDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountStatistiche(string search = null)
        {
            try
            {
                var statistiche = QueryStatistiche(search);
                var count = statistiche.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        private IQueryable<DataLayer.Statistica> QueryStatistiche(string search)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var statistiche = (from q in ef.Statisticas select q);
                //if (search != null)
                //    statistiche = (from q in statistiche where q.Denominazione.StartsWith(search) select q);
                statistiche = (from q in statistiche orderby q.Id select q);
                return statistiche;
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
                var salsDto = engine.Assemble(sals);
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

        private IQueryable<DataLayer.SAL> QuerySALs(string search)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var sals = (from q in ef.SALs select q);
                //if (search != null)
                //    sals = (from q in sals where q.Denominazione.StartsWith(search) select q);
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
                var anagraficheFornitoriDto = engine.Assemble(anagraficheFornitori);
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

        private IQueryable<DataLayer.AnagraficaFornitore> QueryAnagraficheFornitori(string search)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var anagraficheFornitori = (from q in ef.AnagraficaFornitores select q);
                if (search != null)
                    anagraficheFornitori = (from q in anagraficheFornitori where q.RagioneSociale.StartsWith(search) select q);
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
                var anagraficheClientiDto = engine.Assemble(anagraficheClienti);
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

        private IQueryable<DataLayer.AnagraficaCliente> QueryAnagraficheClienti(string search)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var anagraficheClienti = (from q in ef.AnagraficaClientes select q);
                if (search != null)
                    anagraficheClienti = (from q in anagraficheClienti where q.RagioneSociale.StartsWith(search) select q);
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

    }
}
