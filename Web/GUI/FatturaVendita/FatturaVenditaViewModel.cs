using Library.Code;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService.Dto;

namespace Web.GUI.FatturaVendita
{
    public class FatturaVenditaViewModel : Library.Template.MVVM.TemplateViewModel<FatturaVenditaDto, FatturaVenditaItem>
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

        public FatturaVenditaViewModel(ISpace space)
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
                IEnumerable<FatturaVenditaDto> objs = null;
                if (cliente==null)
                    objs = wcf.LoadFattureVendita(skip, take, search);
                else
                    objs = wcf.LoadFattureVenditaCliente(skip, take,cliente, search);
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
                if (cliente==null)
                    count = wcf.CountFattureVendita(search);
                else
                    count = wcf.CountFattureVenditaCliente(cliente, search);
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
                    var obj = (FatturaVenditaDto)model;
                    bool performed = false;
                    if (creating)
                    {
                        var newObj = wcf.CreateFatturaVendita(obj);
                        performed = (newObj != null);
                        if (performed)
                            obj = newObj;
                    }
                    else //updating
                        performed = wcf.UpdateFatturaVendita(obj);
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
                    var obj = (FatturaVenditaDto)model;
                    bool performed = wcf.DeleteFatturaVendita(obj);
                    return performed;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public new FatturaVenditaDto Read(object id)
        {
            try
            {
                var wcf = new WcfService.Service();
                var obj = wcf.ReadFatturaVendita(id);
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