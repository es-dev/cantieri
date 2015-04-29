using Library.Code;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService.Dto;

namespace Web.GUI.FatturaVendita
{
    public class FatturaVenditaViewModel : Library.Template.MVVM.TemplateViewModel<FatturaVenditaView, FatturaVenditaItem, FatturaVenditaModel, FatturaVenditaDto>
    {
        private CommittenteDto committente = null;

        public CommittenteDto Committente
        {
            get
            {
                return committente;
            }
            set
            {
                committente = value;
            }
        }

        public FatturaVenditaViewModel()
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

        public override void Load(int skip, int take, string search=null, object advancedSearch=null, object orderBy=null)
        {
            try
            {
                var wcf = new WcfService.Service();
                var objs = wcf.LoadFattureVendita(skip, take, search, advancedSearch, committente, orderBy);
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
                var count = wcf.CountFattureVendita(search, advancedSearch, committente);
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
                            Update(obj, newObj);
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

        public override object Read(object id)
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