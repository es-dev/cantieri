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

        #region Custom
        [OperationContract]
        IEnumerable<Dto.CommessaDto> LoadCommesse(int skip, int take, string search = null);

        [OperationContract]
        int CountCommesse(string search = null);
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
        int CountFornitori(string search = null);
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
        int CountFattureAcquisto(string search = null);
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
        int CountClienti(string search = null);
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
        #endregion
        #endregion

    }
}