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
        IEnumerable<Dto.FornitoreDto> LoadFornitori(int skip, int take, string search = null, Dto.CommessaDto commessa=null);

        [OperationContract]
        int CountFornitori(string search = null, Dto.CommessaDto commessa = null);

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
        IEnumerable<Dto.FatturaAcquistoDto> LoadFattureAcquisto(int skip, int take, string search = null, Dto.FornitoreDto fornitore=null, 
            Dto.AnagraficaFornitoreDto anagraficaFornitore=null, IList<string> stati=null);

        [OperationContract]
        int CountFattureAcquisto(string search = null, Dto.FornitoreDto fornitore=null, Dto.AnagraficaFornitoreDto anagraficaFornitore=null, IList<string> stati=null);

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
        IEnumerable<Dto.PagamentoDto> LoadPagamenti(int skip, int take, string search = null, Dto.FornitoreDto fornitore=null, Dto.FatturaAcquistoDto fatturaAcquisto=null);

        [OperationContract]
        int CountPagamenti(string search = null, Dto.FornitoreDto fornitore = null, Dto.FatturaAcquistoDto fatturaAcquisto = null);

        [OperationContract]
        Dto.PagamentoDto ReadPagamento(object id);

        [OperationContract]
        Dto.PagamentoDto ReadPagamentoPagamentoUnificatoFatturaAcquisto(Dto.PagamentoUnificatoFatturaAcquistoDto pagamentoUnificatoFatturaAcquisto);

        [OperationContract]
        Dto.PagamentoDto ReadPagamentoOldPagamentoUnificatoFatturaAcquisto(Dto.PagamentoUnificatoDto pagamentoUnificato, Dto.FatturaAcquistoDto fatturaAcquisto);
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
        IEnumerable<Dto.NotaCreditoDto> LoadNoteCredito(int skip, int take, string search = null, Dto.FornitoreDto fornitore=null);

        [OperationContract]
        int CountNoteCredito(string search = null, Dto.FornitoreDto fornitore=null);

        [OperationContract]
        Dto.NotaCreditoDto ReadNotaCredito(object id);
        #endregion
        #endregion

        #region Reso
        #region CRUD
        [OperationContract]
        Dto.ResoDto CreateReso(Dto.ResoDto reso);

        [OperationContract]
        IEnumerable<Dto.ResoDto> ReadResi();

        [OperationContract]
        bool UpdateReso(Dto.ResoDto reso);

        [OperationContract]
        bool DeleteReso(Dto.ResoDto reso);

        [OperationContract]
        int CountResi();
        #endregion

        #region Custom
        [OperationContract]
        IEnumerable<Dto.ResoDto> LoadResi(int skip, int take, string search = null);

        [OperationContract]
        int CountResi(string search = null);

        [OperationContract]
        IEnumerable<Dto.ResoDto> LoadResiNotaCredito(int skip, int take, Dto.NotaCreditoDto notaCredito, string search = null);

        [OperationContract]
        int CountResiNotaCredito(Dto.NotaCreditoDto notaCredito, string search = null);

        [OperationContract]
        IEnumerable<Dto.ResoDto> LoadResiFatturaAcquisto(int skip, int take, Dto.FatturaAcquistoDto fatturaAcquisto, string search);

        [OperationContract]
        int CountResiFatturaAcquisto(Dto.FatturaAcquistoDto fatturaAcquisto, string search = null);

        [OperationContract]
        Dto.ResoDto ReadReso(object id);
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

        #region Committente
        #region CRUD
        [OperationContract]
        Dto.CommittenteDto CreateCommittente(Dto.CommittenteDto committente);

        [OperationContract]
        IEnumerable<Dto.CommittenteDto> ReadCommittenti();

        [OperationContract]
        bool UpdateCommittente(Dto.CommittenteDto committente);

        [OperationContract]
        bool DeleteCommittente(Dto.CommittenteDto committente);

        [OperationContract]
        int CountCommittenti();
        #endregion

        #region Custom
        [OperationContract]
        IEnumerable<Dto.CommittenteDto> LoadCommittenti(int skip, int take, string search = null, Dto.CommessaDto commessa=null);

        [OperationContract]
        int CountCommittenti(string search = null, Dto.CommessaDto commessa=null);

        [OperationContract]
        Dto.CommittenteDto ReadCommittente(object id);
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
        IEnumerable<Dto.FatturaVenditaDto> LoadFattureVendita(int skip, int take, string search = null, Dto.CommittenteDto committente=null);

        [OperationContract]
        int CountFattureVendita(string search = null, Dto.CommittenteDto committente = null);

        [OperationContract]
        Dto.FatturaVenditaDto ReadFatturaVendita(object id);
        #endregion
        #endregion

        #region Incasso
        #region CRUD
        [OperationContract]
        Dto.IncassoDto CreateIncasso(Dto.IncassoDto incasso);

        [OperationContract]
        IEnumerable<Dto.IncassoDto> ReadIncassi();

        [OperationContract]
        bool UpdateIncasso(Dto.IncassoDto incasso);

        [OperationContract]
        bool DeleteIncasso(Dto.IncassoDto incasso);

        [OperationContract]
        int CountIncassi();
        #endregion

        #region Custom
        [OperationContract]
        IEnumerable<Dto.IncassoDto> LoadIncassi(int skip, int take, string search = null);

        [OperationContract]
        int CountIncassi(string search = null);

        [OperationContract]
        IEnumerable<Dto.IncassoDto> LoadIncassiCommittente(int skip, int take,Dto.CommittenteDto committente, string search = null);

        [OperationContract]
        int CountIncassiCommittente(Dto.CommittenteDto committente, string search = null);

        [OperationContract]
        IEnumerable<Dto.IncassoDto> LoadIncassiFatturaVendita(int skip, int take, Dto.FatturaVenditaDto fatturaVendita, string search = null);

        [OperationContract]
        int CountIncassiFatturaVendita(Dto.FatturaVenditaDto fatturaVendita, string search = null);

        [OperationContract]
        Dto.IncassoDto ReadIncasso(object id);
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
        IEnumerable<Dto.SALDto> LoadSALs(int skip, int take, string search = null, Dto.CommessaDto commessa=null);

        [OperationContract]
        int CountSALs(string search = null, Dto.CommessaDto commessa=null);

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

        #region AnagraficaCommittente
        #region CRUD
        [OperationContract]
        Dto.AnagraficaCommittenteDto CreateAnagraficaCommittente(Dto.AnagraficaCommittenteDto anagraficaCommittente);

        [OperationContract]
        IEnumerable<Dto.AnagraficaCommittenteDto> ReadAnagraficheCommittenti();

        [OperationContract]
        bool UpdateAnagraficaCommittente(Dto.AnagraficaCommittenteDto anagraficaCommittente);

        [OperationContract]
        bool DeleteAnagraficaCommittente(Dto.AnagraficaCommittenteDto anagraficaCommittente);

        [OperationContract]
        int CountAnagraficheCommittenti();
        #endregion

        #region Custom
        [OperationContract]
        IEnumerable<Dto.AnagraficaCommittenteDto> LoadAnagraficheCommittenti(int skip, int take, string search = null);

        [OperationContract]
        int CountAnagraficheCommittenti(string search = null);

        [OperationContract]
        Dto.AnagraficaCommittenteDto ReadAnagraficaCommittente(object id);
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