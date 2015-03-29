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
                IEnumerable<IncassoDto> objs = null;
                if (committente == null && fatturaVendita == null)
                    objs = wcf.LoadIncassi(skip, take, search);
                else if (committente!=null)
                    objs = wcf.LoadIncassiCommittente(skip, take, committente, search);
                else if (fatturaVendita != null)
                    objs = wcf.LoadIncassiFatturaVendita(skip, take, fatturaVendita, search);
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
                if (committente == null && fatturaVendita == null)
                    count = wcf.CountIncassi(search);
                else if (committente != null)
                    count = wcf.CountIncassiCommittente(committente, search);
                else if (fatturaVendita != null)
                    count = wcf.CountIncassiFatturaVendita(fatturaVendita, search);
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
                            obj = newObj;
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

        public new IncassoDto Read(object id)
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