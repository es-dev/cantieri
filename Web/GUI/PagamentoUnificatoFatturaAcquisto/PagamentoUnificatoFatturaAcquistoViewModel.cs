using Library.Code;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService.Dto;

namespace Web.GUI.PagamentoUnificatoFatturaAcquisto
{
    public class PagamentoUnificatoFatturaAcquistoViewModel : Library.Template.MVVM.TemplateViewModel<PagamentoUnificatoFatturaAcquistoDto, PagamentoUnificatoFatturaAcquistoItem>
    {
        private PagamentoUnificatoDto pagamentoUnificato = null;
        public PagamentoUnificatoDto PagamentoUnificato
        {
            get
            {
                return pagamentoUnificato;
            }
            set
            {
                pagamentoUnificato = value;
            }
        }

        private PagamentoUnificatoDto pagamentoUnificatoOld = null;
        public PagamentoUnificatoDto PagamentoUnificatoOld
        {
            get
            {
                return pagamentoUnificatoOld;
            }
            set
            {
                pagamentoUnificatoOld = value;
            }
        }

        private FatturaAcquistoDto fatturaAcquistoOld = null;
        public FatturaAcquistoDto FatturaAcquistoOld
        {
            get
            {
                return fatturaAcquistoOld;
            }
            set
            {
                fatturaAcquistoOld = value;
            }
        }
        public PagamentoUnificatoFatturaAcquistoViewModel(ISpace space)
            : base(space) 
        {
            try
            {

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void Load(int skip, int take, string search = null)
        {
            try
            {
                var wcf = new WcfService.Service();
                var objs = wcf.LoadPagamentiUnificatiFatturaAcquisto(skip, take, search, pagamentoUnificato);
                Load(objs);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override int GetCount(string search=null)
        {
            try
            {
                var wcf = new WcfService.Service();
                var count = wcf.CountPagamentiUnificatiFatturaAcquisto(search, pagamentoUnificato);
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
                    var obj = (PagamentoUnificatoFatturaAcquistoDto)model;
                    bool performed = false;
                    if (creating)
                    {
                        var newObj = wcf.CreatePagamentoUnificatoFatturaAcquisto(obj);
                        performed = (newObj != null);
                        if (performed)
                            obj.Id = newObj.Id;
                    }
                    else //updating
                        performed = wcf.UpdatePagamentoUnificatoFatturaAcquisto(obj);

                    //sync pagamento
                    if(performed)
                    {
                        var viewModelPagamento = new Pagamento.PagamentoViewModel(Space);
                        var pagamento = viewModelPagamento.ReadPagamentoPagamentoUnificatoFatturaAcquisto(obj);
                        creating = (pagamento == null);
                        if(pagamento==null)
                            pagamento = BusinessLogic.Pagamento.GetPagamento(obj);
                        
                        var pagamentoOld = viewModelPagamento.ReadPagamentoOldPagamentoUnificatoFatturaAcquisto(pagamentoUnificatoOld, fatturaAcquistoOld);
                        if (pagamentoOld!=null)
                            viewModelPagamento.Delete(pagamentoOld);
                        performed = viewModelPagamento.Save(pagamento, creating);
                    }
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
                    var obj = (PagamentoUnificatoFatturaAcquistoDto)model;
                    bool performed = wcf.DeletePagamentoUnificatoFatturaAcquisto(obj);
                    if (performed) //sync  pagamento
                    {
                        var viewModelPagamento = new Pagamento.PagamentoViewModel(Space);
                        var pagamento = viewModelPagamento.ReadPagamentoPagamentoUnificatoFatturaAcquisto(obj);
                        viewModelPagamento.Delete(pagamento);
                    }

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
                var obj = wcf.ReadPagamentoUnificatoFatturaAcquisto(id);
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