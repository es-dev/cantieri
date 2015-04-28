using Library.Code;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService.Dto;

namespace Web.GUI.AnagraficaFornitore
{
    public class AnagraficaFornitoreViewModel : Library.Template.MVVM.TemplateViewModel<AnagraficaFornitoreView, AnagraficaFornitoreItem, AnagraficaFornitoreModel, AnagraficaFornitoreDto>
    {

        public AnagraficaFornitoreViewModel()
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
                var objs = wcf.LoadAnagraficheFornitori(skip, take, search, advancedSearch, orderBy);
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
                var count = wcf.CountAnagraficheFornitori(search, advancedSearch);
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
                    var obj = (AnagraficaFornitoreDto)model;
                    bool performed = false;
                    if (creating)
                    {
                        var newObj = wcf.CreateAnagraficaFornitore(obj);
                        performed = (newObj != null);
                        if (performed)
                            Update(obj, newObj);
                    }
                    else //updating
                        performed = wcf.UpdateAnagraficaFornitore(obj);
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
                    var obj = (AnagraficaFornitoreDto)model;
                    bool performed = wcf.DeleteAnagraficaFornitore(obj);
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
                var obj = wcf.ReadAnagraficaFornitore(id);
                return obj;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        internal IEnumerable<AnagraficaFornitoreDto> ReadAnagraficheFornitori()
        {
            try
            {
                var wcf = new WcfService.Service();
                var objs = wcf.ReadAnagraficheFornitori();
                return objs;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        internal AnagraficaFornitoreDto ReadAnagraficaFornitore(string codice)
        {
            try
            {
                var wcf = new WcfService.Service();
                var obj = wcf.ReadAnagraficaFornitore(codice);
                return obj;

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public AnagraficaFornitoreDto ReadAnagraficaFornitore(FornitoreDto fornitore)
        {
            try
            {
                if (fornitore != null)
                {
                    var codiceFornitore = fornitore.Codice;
                    var anagraficaFornitore = ReadAnagraficaFornitore(codiceFornitore);
                    return anagraficaFornitore;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        internal AnagraficaFornitoreDto ReadAnagraficaFornitore(PagamentoUnificatoDto pagamentoUnificato)
        {
            try
            {
                if(pagamentoUnificato!=null)
                {
                    var codiceFornitore = pagamentoUnificato.CodiceFornitore;
                    var anagraficaFornitore = ReadAnagraficaFornitore(codiceFornitore);
                    return anagraficaFornitore;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
    }
}