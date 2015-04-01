﻿using Library.Code;
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
                IEnumerable<PagamentoUnificatoFatturaAcquistoDto> objs = null;
                if(pagamentoUnificato==null)
                    objs = wcf.LoadPagamentiUnificatiFatturaAcquisto(skip, take, search);
                else
                    objs = wcf.LoadPagamentiUnificatiFatturaAcquistoPagamentoUnificato(skip, take, search, pagamentoUnificato);
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
                if(pagamentoUnificato==null)
                    count = wcf.CountPagamentiUnificatiFatturaAcquisto(search);
                else
                    count = wcf.CountPagamentiUnificatiFatturaAcquistoPagamentoUnificato(search, pagamentoUnificato);
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
                            obj = newObj;
                    }
                    else //updating
                        performed = wcf.UpdatePagamentoUnificatoFatturaAcquisto(obj);

                    if(performed) //sync pagamento
                    {
                        var viewModelPagamento = new Pagamento.PagamentoViewModel(Space);
                        var pagamento = viewModelPagamento.ReadPagamentoPagamentoUnificatoFatturaAcquisto(obj);
                        if(pagamento==null)
                        {
                            pagamento = GetPagamento(obj);
                        }
                        viewModelPagamento.Save(pagamento, creating);
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

        private PagamentoDto GetPagamento(PagamentoUnificatoFatturaAcquistoDto obj)
        {
            try
            {
                if (obj != null)
                {
                    var fatturaAcquisto = obj.FatturaAcquisto;
                    var pagamentoUnificato = obj.PagamentoUnificato;
                    var pagamento = new PagamentoDto();
                    pagamento.Codice = BusinessLogic.Pagamento.GetCodice(fatturaAcquisto);
                    pagamento.Data = pagamentoUnificato.Data;
                    pagamento.Descrizione = pagamentoUnificato.Descrizione;
                    pagamento.FatturaAcquistoId = obj.FatturaAcquistoId;
                    pagamento.Importo = obj.Saldo;
                    pagamento.Note = "Pagamento unificato " + pagamentoUnificato.Codice;
                    pagamento.PagamentoUnificatoId = obj.PagamentoUnificatoId;
                    pagamento.TipoPagamento = pagamentoUnificato.TipoPagamento;
                    return pagamento;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
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

        public new PagamentoUnificatoFatturaAcquistoDto Read(object id)
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