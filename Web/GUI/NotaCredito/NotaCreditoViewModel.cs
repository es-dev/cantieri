using Library.Code;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService.Dto;

namespace Web.GUI.NotaCredito
{
    public class NotaCreditoViewModel : Library.Template.MVVM.TemplateViewModel<NotaCreditoDto, NotaCreditoItem>
    {

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

        public NotaCreditoViewModel(ISpace space)
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
                var objs = wcf.LoadNoteCredito(skip, take, search, fornitore);
                Load(objs);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override int Count(string search = null)
        {
            try
            {
                var wcf = new WcfService.Service();
                var count = wcf.CountNoteCredito(search, fornitore);
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
                    var obj = (NotaCreditoDto)model;
                    bool performed = false;
                    if (creating)
                    {
                        var newObj = wcf.CreateNotaCredito(obj);
                        performed = (newObj != null);
                        if (performed)
                            Update(obj, newObj);
                    }
                    else //updating
                        performed = wcf.UpdateNotaCredito(obj);
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
                    var obj = (NotaCreditoDto)model;
                    bool performed = wcf.DeleteNotaCredito(obj);
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
                var obj = wcf.ReadNotaCredito(id);
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