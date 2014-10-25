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

    }
}