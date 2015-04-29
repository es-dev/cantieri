using Library.Code;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService.Dto;

namespace Web.GUI.Articolo
{
    public class ArticoloViewModel : Library.Template.MVVM.TemplateViewModel<ArticoloView, ArticoloItem, ArticoloModel, ArticoloDto>
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


        public ArticoloViewModel()
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
                var objs = wcf.LoadArticoli(skip, take, search, advancedSearch, fatturaAcquisto, orderBy);
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
                var count = wcf.CountArticoli(search, advancedSearch, fatturaAcquisto);
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
                    var obj = (ArticoloDto)model;
                    bool performed = false;
                    if (creating)
                    {
                        var newObj = wcf.CreateArticolo(obj);
                        performed = (newObj != null);
                        if (performed)
                            Update(obj, newObj);
                    }
                    else //updating
                        performed = wcf.UpdateArticolo(obj);
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
                    var obj = (ArticoloDto)model;
                    bool performed = wcf.DeleteArticolo(obj);
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
                var obj = wcf.ReadArticolo(id);
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