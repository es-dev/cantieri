using Library.Code;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService.Dto;

namespace Web.GUI.Incasso
{
    public class IncassoViewModel : Library.Template.MVVM.TemplateViewModel<IncassoDto, IncassoItem>
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

        public IncassoViewModel(ISpace space)
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
                var objs = wcf.LoadIncassi(skip, take, search, committente, fatturaVendita);
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
                var count = wcf.CountIncassi(search, committente, fatturaVendita);
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
                    var obj = (IncassoDto)model;
                    bool performed = false;
                    if (creating)
                    {
                        var newObj = wcf.CreateIncasso(obj);
                        performed = (newObj != null);
                        if (performed)
                            obj.Id = newObj.Id;
                    }
                    else //updating
                        performed = wcf.UpdateIncasso(obj);
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
                    var obj = (IncassoDto)model;
                    bool performed = wcf.DeleteIncasso(obj);
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
                var obj = wcf.ReadIncasso(id);
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