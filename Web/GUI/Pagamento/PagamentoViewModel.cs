using Library.Code;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService.Dto;

namespace Web.GUI.Pagamento
{
    public class PagamentoViewModel : Library.Template.MVVM.TemplateViewModel<PagamentoDto, PagamentoItem>
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


        public PagamentoViewModel(ISpace space)
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
                IEnumerable<PagamentoDto> objs = null;
                if(fatturaAcquisto==null  && fornitore==null)
                    objs = wcf.LoadPagamenti(skip, take, search);
                else if (fatturaAcquisto != null)
                    objs = wcf.LoadPagamentiFatturaAcquisto(skip, take, fatturaAcquisto, search);
                else if (fornitore != null)
                    objs = wcf.LoadPagamentiFornitore(skip, take, fornitore, search);

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
                var count = 0;
                if (fatturaAcquisto == null && fornitore == null)
                    count = wcf.CountPagamenti(search);
                else if (fatturaAcquisto != null)
                    count = wcf.CountPagamentiFatturaAcquisto(fatturaAcquisto, search);
                else if (fornitore != null)
                    count = wcf.CountPagamentiFornitore(fornitore, search);
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
                            obj = newObj;
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

        public new PagamentoDto Read(object id)
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
                var obj = wcf.ReadPagamentoPagamentoUnificatoFatturaAcquisto(pagamentoUnificatoFatturaAcquisto);
                return obj;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }



        internal PagamentoDto ReadPagamentoOldPagamentoUnificatoFatturaAcquisto(PagamentoUnificatoDto pagamentoUnificato, FatturaAcquistoDto fatturaAcquisto)
        {
            try
            {
                var wcf = new WcfService.Service();
                var obj = wcf.ReadPagamentoOldPagamentoUnificatoFatturaAcquisto(pagamentoUnificato, fatturaAcquisto);
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