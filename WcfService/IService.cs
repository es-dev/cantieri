using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
    [ServiceContract]
    public interface IService
    {
        #region Azienda
        #region CRUD
        [OperationContract]
        Dto.AziendaDto CreateAzienda(Dto.AziendaDto azienda);

        [OperationContract]
        IEnumerable<Dto.AziendaDto> ReadAziende();

        [OperationContract]
        bool UpdateAzienda(Dto.AziendaDto azienda);

        [OperationContract]
        bool DeleteAzienda(Dto.AziendaDto azienda);

        [OperationContract]
        int CountAziende();
        #endregion
        #region Custom
        [OperationContract]
        IEnumerable<Dto.AziendaDto> LoadAziende(int skip, int take, string search = null);

        [OperationContract]
        int CountAziende(string search = null);

        [OperationContract]
        Dto.AziendaDto ReadAzienda(object id);
        #endregion
        #endregion

        #region Account
        #region CRUD
        [OperationContract]
        Dto.AccountDto CreateAccount(Dto.AccountDto account);

        [OperationContract]
        IEnumerable<Dto.AccountDto> ReadAccounts();

        [OperationContract]
        bool UpdateAccount(Dto.AccountDto account);

        [OperationContract]
        bool DeleteAccount(Dto.AccountDto account);

        [OperationContract]
        int CountAccounts();
        #endregion
        #region Custom
        [OperationContract]
        IEnumerable<Dto.AccountDto> LoadAccounts(int skip, int take, string search = null);

        [OperationContract]
        int CountAccounts(string search = null);

        [OperationContract]
        Dto.AccountDto ReadAccount(object id);
        #endregion
        #endregion

        #region Commessa
        #region CRUD
        [OperationContract]
        Dto.CommessaDto CreateCommessa(Dto.CommessaDto commessa);

        [OperationContract]
        IEnumerable<Dto.CommessaDto> ReadCommesse();

        [OperationContract]
        bool UpdateCommessa(Dto.CommessaDto commessa);

        [OperationContract]
        bool DeleteCommessa(Dto.CommessaDto commessa);

        [OperationContract]
        int CountCommesse();
        #endregion

        [OperationContract]
        int CountCommesseNonAssegnate(string search = null);

        #region Custom
        [OperationContract]
        IEnumerable<Dto.CommessaDto> LoadCommesse(int skip, int take, string search = null);

        [OperationContract]
        IEnumerable<Dto.CommessaDto> LoadCommesseNonAssegnate(int skip, int take, string search = null);

        [OperationContract]
        int CountCommesse(string search = null);

        [OperationContract]
        Dto.CommessaDto ReadCommessa(object id);

        [OperationContract]
        IEnumerable<Dto.CommessaDto> ReadCommesse(IEnumerable<Dto.FornitoreDto> fornitori);

        #endregion
        #endregion

        #region Fornitore
        #region CRUD
        [OperationContract]
        Dto.FornitoreDto CreateFornitore(Dto.FornitoreDto fornitore);

        [OperationContract]
        IEnumerable<Dto.FornitoreDto> ReadFornitori();

        [OperationContract]
        bool UpdateFornitore(Dto.FornitoreDto fornitore);

        [OperationContract]
        bool DeleteFornitore(Dto.FornitoreDto fornitore);

        [OperationContract]
        int CountFornitori();
        #endregion

        #region Custom
        [OperationContract]
        IEnumerable<Dto.FornitoreDto> LoadFornitori(int skip, int take, string search = null);

        [OperationContract]
        IEnumerable<Dto.FornitoreDto> LoadFornitoriCommessa(int skip, int take, Dto.CommessaDto commessa, string search = null);

        [OperationContract]
        int CountFornitori(string search = null);

        [OperationContract]
        int CountFornitoriCommessa(Dto.CommessaDto commessa, string search = null);

        [OperationContract]
        Dto.FornitoreDto ReadFornitore(object id);

        [OperationContract]
        IEnumerable<Dto.FornitoreDto> ReadFornitori(string codice);

        #endregion
        #endregion

        #region CentroCosto
        #region CRUD
        [OperationContract]
        Dto.CentroCostoDto CreateCentroCosto(Dto.CentroCostoDto centroCosto);

        [OperationContract]
        IEnumerable<Dto.CentroCostoDto> ReadCentriCosto();

        [OperationContract]
        bool UpdateCentroCosto(Dto.CentroCostoDto centroCosto);

        [OperationContract]
        bool DeleteCentroCosto(Dto.CentroCostoDto centroCosto);

        [OperationContract]
        int CountCentriCosto();
        #endregion

        #region Custom
        [OperationContract]
        IEnumerable<Dto.CentroCostoDto> LoadCentriCosto(int skip, int take, string search = null);

        [OperationContract]
        int CountCentriCosto(string search = null);

        [OperationContract]
        Dto.CentroCostoDto ReadCentroCosto(object id);
        #endregion
        #endregion

        #region FatturaAcquisto
        #region CRUD
        [OperationContract]
        Dto.FatturaAcquistoDto CreateFatturaAcquisto(Dto.FatturaAcquistoDto fatturaAcquisto);

        [OperationContract]
        IEnumerable<Dto.FatturaAcquistoDto> ReadFattureAcquisto();

        [OperationContract]
        bool UpdateFatturaAcquisto(Dto.FatturaAcquistoDto fatturaAcquisto);

        [OperationContract]
        bool DeleteFatturaAcquisto(Dto.FatturaAcquistoDto fatturaAcquisto);

        [OperationContract]
        int CountFattureAcquisto();
        #endregion

        #region Custom
        [OperationContract]
        IEnumerable<Dto.FatturaAcquistoDto> LoadFattureAcquisto(int skip, int take, string search = null);

        [OperationContract]
        IEnumerable<Dto.FatturaAcquistoDto> LoadFattureAcquistoFornitoreDare(int skip, int take, string search, Dto.AnagraficaFornitoreDto anagraficaFornitore);

        [OperationContract]
        int CountFattureAcquisto(string search = null);

        [OperationContract]
        int CountFattureAcquistoFornitoreDare(string search, Dto.AnagraficaFornitoreDto anagraficaFornitore);

        [OperationContract]
        IEnumerable<Dto.FatturaAcquistoDto> LoadFattureAcquistoFornitore(int skip, int take, Dto.FornitoreDto fornitore, string search);

        [OperationContract]
        int CountFattureAcquistoFornitore(Dto.FornitoreDto fornitore, string search);

        [OperationContract]
        IEnumerable<Dto.FatturaAcquistoDto> ReadFattureAcquistoCommessa(Dto.CommessaDto commessa);

        [OperationContract]
        Dto.FatturaAcquistoDto ReadFatturaAcquisto(object id);
        #endregion
        #endregion

        #region Articolo
        #region CRUD
        [OperationContract]
        Dto.ArticoloDto CreateArticolo(Dto.ArticoloDto articolo);

        [OperationContract]
        IEnumerable<Dto.ArticoloDto> ReadArticoli();

        [OperationContract]
        bool UpdateArticolo(Dto.ArticoloDto articolo);

        [OperationContract]
        bool DeleteArticolo(Dto.ArticoloDto articolo);

        [OperationContract]
        int CountArticoli();
        #endregion

        #region Custom
        [OperationContract]
        IEnumerable<Dto.ArticoloDto> LoadArticoli(int skip, int take, string search = null);

        [OperationContract]
        int CountArticoli(string search = null);

        [OperationContract]
        Dto.ArticoloDto ReadArticolo(object id);
        #endregion
        #endregion

        #region Pagamento
        #region CRUD
        [OperationContract]
        Dto.PagamentoDto CreatePagamento(Dto.PagamentoDto pagamento);

        [OperationContract]
        IEnumerable<Dto.PagamentoDto> ReadPagamenti();

        [OperationContract]
        bool UpdatePagamento(Dto.PagamentoDto pagamento);

        [OperationContract]
        bool DeletePagamento(Dto.PagamentoDto pagamento);

        [OperationContract]
        int CountPagamenti();
        #endregion

        #region Custom
        [OperationContract]
        IEnumerable<Dto.PagamentoDto> LoadPagamenti(int skip, int take, string search = null);

        [OperationContract]
        int CountPagamenti(string search = null);

        [OperationContract]
        IEnumerable<Dto.PagamentoDto> LoadPagamentiFatturaAcquisto(int skip, int take, Dto.FatturaAcquistoDto fatturaAcquisto, string search = null);

        [OperationContract]
        int CountPagamentiFatturaAcquisto(Dto.FatturaAcquistoDto fatturaAcquisto, string search = null);

        [OperationContract]
        IEnumerable<Dto.PagamentoDto> LoadPagamentiFornitore(int skip, int take, Dto.FornitoreDto fornitore, string search = null);

        [OperationContract]
        int CountPagamentiFornitore(Dto.FornitoreDto fornitore, string search = null);

        [OperationContract]
        Dto.PagamentoDto ReadPagamento(object id);
        #endregion
        #endregion

        #region NotaCredito
        #region CRUD
        [OperationContract]
        Dto.NotaCreditoDto CreateNotaCredito(Dto.NotaCreditoDto notaCredito);

        [OperationContract]
        IEnumerable<Dto.NotaCreditoDto> ReadNoteCredito();

        [OperationContract]
        bool UpdateNotaCredito(Dto.NotaCreditoDto notaCredito);

        [OperationContract]
        bool DeleteNotaCredito(Dto.NotaCreditoDto notaCredito);

        [OperationContract]
        int CountNoteCredito();
        #endregion

        #region Custom
        [OperationContract]
        IEnumerable<Dto.NotaCreditoDto> LoadNoteCredito(int skip, int take, string search = null);

        [OperationContract]
        int CountNoteCredito(string search = null);

        [OperationContract]
        IEnumerable<Dto.NotaCreditoDto> LoadNoteCreditoFatturaAcquisto(int skip, int take, Dto.FatturaAcquistoDto fatturaAcquisto, string search = null);

        [OperationContract]
        int CountNoteCreditoFatturaAcquisto(Dto.FatturaAcquistoDto fatturaAcquisto, string search = null);

        [OperationContract]
        IEnumerable<Dto.NotaCreditoDto> LoadNoteCreditoFornitore(int skip, int take, Dto.FornitoreDto fornitore, string search = null);

        [OperationContract]
        int CountNoteCreditoFornitore(Dto.FornitoreDto fornitore, string search = null);

        [OperationContract]
        Dto.NotaCreditoDto ReadNotaCredito(object id);
        #endregion
        #endregion


        #region PagamentoUnificato
        #region CRUD
        [OperationContract]
        Dto.PagamentoUnificatoDto CreatePagamentoUnificato(Dto.PagamentoUnificatoDto pagamentoUnificato);

        [OperationContract]
        IEnumerable<Dto.PagamentoUnificatoDto> ReadPagamentiUnificati();

        [OperationContract]
        bool UpdatePagamentoUnificato(Dto.PagamentoUnificatoDto pagamentoUnificato);

        [OperationContract]
        bool DeletePagamentoUnificato(Dto.PagamentoUnificatoDto pagamentoUnificato);

        [OperationContract]
        int CountPagamentiUnificati();
        #endregion

        #region Custom
        [OperationContract]
        IEnumerable<Dto.PagamentoUnificatoDto> LoadPagamentiUnificati(int skip, int take, string search = null);

        [OperationContract]
        int CountPagamentiUnificati(string search = null);

        [OperationContract]
        Dto.PagamentoUnificatoDto ReadPagamentoUnificato(object id);
        #endregion
        #endregion

        #region PagamentoUnificatoFatturaAcquisto
        #region CRUD
        [OperationContract]
        Dto.PagamentoUnificatoFatturaAcquistoDto CreatePagamentoUnificatoFatturaAcquisto(Dto.PagamentoUnificatoFatturaAcquistoDto pagamentoUnificatoFatturaAcquisto);

        [OperationContract]
        IEnumerable<Dto.PagamentoUnificatoFatturaAcquistoDto> ReadPagamentiUnificatiFatturaAcquisto();

        [OperationContract]
        bool UpdatePagamentoUnificatoFatturaAcquisto(Dto.PagamentoUnificatoFatturaAcquistoDto pagamentoUnificatoFatturaAcquisto);

        [OperationContract]
        bool DeletePagamentoUnificatoFatturaAcquisto(Dto.PagamentoUnificatoFatturaAcquistoDto pagamentoUnificatoFatturaAcquisto);

        [OperationContract]
        int CountPagamentiUnificatiFatturaAcquisto();
        #endregion

        #region Custom
        [OperationContract]
        IEnumerable<Dto.PagamentoUnificatoFatturaAcquistoDto> LoadPagamentiUnificatiFatturaAcquisto(int skip, int take, string search = null);

        [OperationContract]
        int CountPagamentiUnificatiFatturaAcquisto(string search = null);

        [OperationContract]
        Dto.PagamentoUnificatoFatturaAcquistoDto ReadPagamentoUnificatoFatturaAcquisto(object id);
        #endregion
        #endregion

        #region Cliente
        #region CRUD
        [OperationContract]
        Dto.ClienteDto CreateCliente(Dto.ClienteDto cliente);

        [OperationContract]
        IEnumerable<Dto.ClienteDto> ReadClienti();

        [OperationContract]
        bool UpdateCliente(Dto.ClienteDto cliente);

        [OperationContract]
        bool DeleteCliente(Dto.ClienteDto cliente);

        [OperationContract]
        int CountClienti();
        #endregion

        #region Custom
        [OperationContract]
        IEnumerable<Dto.ClienteDto> LoadClienti(int skip, int take, string search = null);

        [OperationContract]
        IEnumerable<Dto.ClienteDto> LoadClientiCommessa(int skip, int take, Dto.CommessaDto commessa, string search = null);

        [OperationContract]
        int CountClienti(string search = null);

        [OperationContract]
        int CountClientiCommessa(Dto.CommessaDto commessa, string search = null);

        [OperationContract]
        Dto.ClienteDto ReadCliente(object id);
        #endregion
        #endregion

        #region FatturaVendita
        #region CRUD
        [OperationContract]
        Dto.FatturaVenditaDto CreateFatturaVendita(Dto.FatturaVenditaDto fatturaVendita);

        [OperationContract]
        IEnumerable<Dto.FatturaVenditaDto> ReadFattureVendita();

        [OperationContract]
        bool UpdateFatturaVendita(Dto.FatturaVenditaDto fatturaVendita);

        [OperationContract]
        bool DeleteFatturaVendita(Dto.FatturaVenditaDto fatturaVendita);

        [OperationContract]
        int CountFattureVendita();
        #endregion

        #region Custom
        [OperationContract]
        IEnumerable<Dto.FatturaVenditaDto> LoadFattureVendita(int skip, int take, string search = null);

        [OperationContract]
        int CountFattureVendita(string search = null);
        [OperationContract]

        IEnumerable<Dto.FatturaVenditaDto> LoadFattureVenditaCliente(int skip, int take, Dto.ClienteDto cliente,  string search = null);

        [OperationContract]
        int CountFattureVenditaCliente(Dto.ClienteDto cliente, string search = null);

        [OperationContract]
        Dto.FatturaVenditaDto ReadFatturaVendita(object id);
        #endregion
        #endregion

        #region Liquidazione
        #region CRUD
        [OperationContract]
        Dto.LiquidazioneDto CreateLiquidazione(Dto.LiquidazioneDto liquidazione);

        [OperationContract]
        IEnumerable<Dto.LiquidazioneDto> ReadLiquidazioni();

        [OperationContract]
        bool UpdateLiquidazione(Dto.LiquidazioneDto liquidazione);

        [OperationContract]
        bool DeleteLiquidazione(Dto.LiquidazioneDto liquidazione);

        [OperationContract]
        int CountLiquidazioni();
        #endregion

        #region Custom
        [OperationContract]
        IEnumerable<Dto.LiquidazioneDto> LoadLiquidazioni(int skip, int take, string search = null);

        [OperationContract]
        int CountLiquidazioni(string search = null);

        [OperationContract]
        IEnumerable<Dto.LiquidazioneDto> LoadLiquidazioniCliente(int skip, int take,Dto.ClienteDto cliente, string search = null);

        [OperationContract]
        int CountLiquidazioniCliente(Dto.ClienteDto cliente, string search = null);

        [OperationContract]
        IEnumerable<Dto.LiquidazioneDto> LoadLiquidazioniFatturaVendita(int skip, int take, Dto.FatturaVenditaDto fatturaVendita, string search = null);

        [OperationContract]
        int CountLiquidazioniFatturaVendita(Dto.FatturaVenditaDto fatturaVendita, string search = null);

        [OperationContract]
        Dto.LiquidazioneDto ReadLiquidazione(object id);
        #endregion
        #endregion

        #region SAL
        #region CRUD
        [OperationContract]
        Dto.SALDto CreateSAL(Dto.SALDto sal);

        [OperationContract]
        IEnumerable<Dto.SALDto> ReadSALs();

        [OperationContract]
        bool UpdateSAL(Dto.SALDto sal);

        [OperationContract]
        bool DeleteSAL(Dto.SALDto sal);

        [OperationContract]
        int CountSALs();
        #endregion

        #region Custom
        [OperationContract]
        IEnumerable<Dto.SALDto> LoadSALs(int skip, int take, string search = null);

        [OperationContract]
        int CountSALs(string search = null);

        [OperationContract]
        Dto.SALDto ReadSAL(object id);
        #endregion
        #endregion

        #region AnagraficaFornitore
        #region CRUD
        [OperationContract]
        Dto.AnagraficaFornitoreDto CreateAnagraficaFornitore(Dto.AnagraficaFornitoreDto anagraficaFornitore);

        [OperationContract]
        IEnumerable<Dto.AnagraficaFornitoreDto> ReadAnagraficheFornitori();

        [OperationContract]
        bool UpdateAnagraficaFornitore(Dto.AnagraficaFornitoreDto anagraficaFornitore);

        [OperationContract]
        bool DeleteAnagraficaFornitore(Dto.AnagraficaFornitoreDto anagraficaFornitore);

        [OperationContract]
        int CountAnagraficheFornitori();
        #endregion

        #region Custom
        [OperationContract]
        IEnumerable<Dto.AnagraficaFornitoreDto> LoadAnagraficheFornitori(int skip, int take, string search = null);

        [OperationContract]
        int CountAnagraficheFornitori(string search = null);

        [OperationContract]
        Dto.AnagraficaFornitoreDto ReadAnagraficaFornitore(object id);

        [OperationContract]
        Dto.AnagraficaFornitoreDto ReadAnagraficaFornitore(string codice);

        #endregion
        #endregion

        #region AnagraficaCliente
        #region CRUD
        [OperationContract]
        Dto.AnagraficaClienteDto CreateAnagraficaCliente(Dto.AnagraficaClienteDto anagraficaCliente);

        [OperationContract]
        IEnumerable<Dto.AnagraficaClienteDto> ReadAnagraficheClienti();

        [OperationContract]
        bool UpdateAnagraficaCliente(Dto.AnagraficaClienteDto anagraficaCliente);

        [OperationContract]
        bool DeleteAnagraficaCliente(Dto.AnagraficaClienteDto anagraficaCliente);

        [OperationContract]
        int CountAnagraficheClienti();
        #endregion

        #region Custom
        [OperationContract]
        IEnumerable<Dto.AnagraficaClienteDto> LoadAnagraficheClienti(int skip, int take, string search = null);

        [OperationContract]
        int CountAnagraficheClienti(string search = null);

        [OperationContract]
        Dto.AnagraficaClienteDto ReadAnagraficaCliente(object id);
        #endregion
        #endregion

        #region AnagraficaArticolo
        #region CRUD
        [OperationContract]
        Dto.AnagraficaArticoloDto CreateAnagraficaArticolo(Dto.AnagraficaArticoloDto anagraficaArticolo);

        [OperationContract]
        IEnumerable<Dto.AnagraficaArticoloDto> ReadAnagraficheArticoli();

        [OperationContract]
        bool UpdateAnagraficaArticolo(Dto.AnagraficaArticoloDto anagraficaArticolo);

        [OperationContract]
        bool DeleteAnagraficaArticolo(Dto.AnagraficaArticoloDto anagraficaArticolo);

        [OperationContract]
        int CountAnagraficheArticoli();
        #endregion

        #region Custom
        [OperationContract]
        IEnumerable<Dto.AnagraficaArticoloDto> LoadAnagraficheArticoli(int skip, int take, string search = null);

        [OperationContract]
        int CountAnagraficheArticoli(string search = null);
        
        [OperationContract]
        Dto.AnagraficaArticoloDto ReadAnagraficaArticolo(object id);
        #endregion
        #endregion

        #region ReportJob
        #region CRUD
        [OperationContract]
        Dto.ReportJobDto CreateReportJob(Dto.ReportJobDto reportJob);

        [OperationContract]
        IEnumerable<Dto.ReportJobDto> ReadReportJobs();

        [OperationContract]
        bool UpdateReportJob(Dto.ReportJobDto reportJob);

        [OperationContract]
        bool DeleteReportJob(Dto.ReportJobDto reportJob);

        [OperationContract]
        int CountReportJobs();
        #endregion

        #region Custom
        [OperationContract]
        IEnumerable<Dto.ReportJobDto> LoadReportJobs(int skip, int take, string search = null);

        [OperationContract]
        int CountReportJobs(string search = null);

        [OperationContract]
        Dto.ReportJobDto ReadReportJob(object id);
        #endregion
        #endregion

    }
}