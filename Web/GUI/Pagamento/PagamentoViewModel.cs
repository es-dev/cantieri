using Library.Code;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService.Dto;

namespace Web.GUI.Pagamento
{
    public class PagamentoViewModel : Library.Template.MVVM.TemplateViewModel<PagamentoView, PagamentoItem, PagamentoModel, PagamentoDto>
    {
        private FatturaAcquistoDto fatturaAcquisto = null;
        public FatturaAcquistoDto FatturaAcquisto
        {
            get
            {
                return fatturaAcquisto;
            }
            set
            {
                fatturaAcquisto = value;
            }
        }

        private FornitoreDto fornitore = null;
        public FornitoreDto Fornitore
        {
            get
            {
                return fornitore;
            }
            set
            {
                fornitore = value;
            }
        }

        public PagamentoViewModel()
            : base()
        {
            try
            {

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void Load(int skip, int take, string search = null, object advancedSearch = null, OrderBy orderBy = null)
        {
            try
            {
                var wcf = new WcfService.Service();
                var objs = wcf.LoadPagamenti(skip, take, search, advancedSearch, fornitore, fatturaAcquisto, orderBy);
                Load(objs);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override int Count(string search = null,  object advancedSearch=null)
        {
            try
            {
                var wcf = new WcfService.Service();
                var count = wcf.CountPagamenti(search, advancedSearch, fornitore, fatturaAcquisto);
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public override bool Save(object model, bool creating)
        {
            try
            {
                if (model != null)
                {
                    var wcf = new WcfService.Service();
                    var obj = (PagamentoDto)model;
                    bool performed = false;
                    if (creating)
                    {
                        var newObj = wcf.CreatePagamento(obj);
                        performed = (newObj != null);
                        if (performed)
                            Update(obj, newObj);
                    }
                    else //updating
                        performed = wcf.UpdatePagamento(obj);
                    return performed;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public override bool Delete(object model)
        {
            try
            {
                if (model != null)
                {
                    var wcf = new WcfService.Service();
                    var obj = (PagamentoDto)model;
                    bool performed = wcf.DeletePagamento(obj);
                    return performed;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public override object Read(object id)
        {
            try
            {
                var wcf = new WcfService.Service();
                var obj = wcf.ReadPagamento(id);
                return obj;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        internal PagamentoDto ReadPagamentoPagamentoUnificatoFatturaAcquisto(PagamentoUnificatoFatturaAcquistoDto pagamentoUnificatoFatturaAcquisto)
        {
            try
            {
                var wcf = new WcfService.Service();
                var obj = wcf.ReadPagamento(pagamentoUnificatoFatturaAcquisto);
                return obj;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        internal PagamentoDto ReadPagamentoOld(PagamentoUnificatoDto pagamentoUnificato, FatturaAcquistoDto fatturaAcquisto)
        {
            try
            {
                var wcf = new WcfService.Service();
                var obj = wcf.ReadPagamentoOld(pagamentoUnificato, fatturaAcquisto);
                return obj;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
    }
}