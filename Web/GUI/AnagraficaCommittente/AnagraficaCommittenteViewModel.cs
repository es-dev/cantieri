using Library.Code;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService.Dto;

namespace Web.GUI.AnagraficaCommittente
{
    public class AnagraficaCommittenteViewModel : Library.Template.MVVM.TemplateViewModel<AnagraficaCommittenteView, AnagraficaCommittenteItem, AnagraficaCommittenteModel, AnagraficaCommittenteDto>
    {

        public AnagraficaCommittenteViewModel()
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
                var objs = wcf.LoadAnagraficheCommittenti(skip, take, search, advancedSearch, orderBy);
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
                var count = wcf.CountAnagraficheCommittenti(search, advancedSearch);
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
                    var obj = (AnagraficaCommittenteDto)model;
                    bool performed = false;
                    if (creating)
                    {
                        var newObj = wcf.CreateAnagraficaCommittente(obj);
                        performed = (newObj != null);
                        if (performed)
                            Update(obj, newObj);
                    }
                    else //updating
                        performed = wcf.UpdateAnagraficaCommittente(obj);
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
                    var obj = (AnagraficaCommittenteDto)model;
                    bool performed = wcf.DeleteAnagraficaCommittente(obj);
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
                var obj = wcf.ReadAnagraficaCommittente(id);
                return obj;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        internal IEnumerable<AnagraficaCommittenteDto> ReadAnagraficheCommittenti()
        {
            try
            {
                var wcf = new WcfService.Service();
                var objs = wcf.ReadAnagraficheCommittenti();
                return objs;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        internal AnagraficaCommittenteDto ReadAnagraficaCommittente(string codice)
        {
            try
            {
                var wcf = new WcfService.Service();
                var obj = wcf.ReadAnagraficaCommittente(codice);
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