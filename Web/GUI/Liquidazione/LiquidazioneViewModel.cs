using Library.Code;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService.Dto;

namespace Web.GUI.Liquidazione
{
    public class LiquidazioneViewModel : Library.Template.MVVM.TemplateViewModel<LiquidazioneDto, LiquidazioneItem>
    {
        private ClienteDto cliente = null;

        public ClienteDto Cliente
        {
            get
            {
                return cliente;
            }
            set
            {
                cliente = value;
            }
        }

        private FatturaVenditaDto fatturaVendita = null;

        public FatturaVenditaDto FatturaVendita
        {
            get
            {
                return fatturaVendita;
            }
            set
            {
                fatturaVendita = value;
            }
        }
        public LiquidazioneViewModel(ISpace space)
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

        public override void Load(int skip, int take, string search=null)
        {
            try
            {
                var wcf = new WcfService.Service();
                IEnumerable<LiquidazioneDto> objs = null;
                if (cliente == null && fatturaVendita == null)
                    objs = wcf.LoadLiquidazioni(skip, take, search);
                else if (cliente!=null)
                    objs = wcf.LoadLiquidazioniCliente(skip, take, cliente, search);
                else if (fatturaVendita != null)
                    objs = wcf.LoadLiquidazioniFatturaVendita(skip, take, fatturaVendita, search);
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
                if (cliente == null && fatturaVendita == null)
                    count = wcf.CountLiquidazioni(search);
                else if (cliente != null)
                    count = wcf.CountLiquidazioniCliente(cliente, search);
                else if (fatturaVendita != null)
                    count = wcf.CountLiquidazioniFatturaVendita(fatturaVendita, search);
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
                    var obj = (LiquidazioneDto)model;
                    bool performed = false;
                    if (creating)
                    {
                        var newObj = wcf.CreateLiquidazione(obj);
                        performed = (newObj != null);
                        if (performed)
                            obj = newObj;
                    }
                    else //updating
                        performed = wcf.UpdateLiquidazione(obj);
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
                    var obj = (LiquidazioneDto)model;
                    bool performed = wcf.DeleteLiquidazione(obj);
                    return performed;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public new LiquidazioneDto Read(object id)
        {
            try
            {
                var wcf = new WcfService.Service();
                var obj = wcf.ReadLiquidazione(id);
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