using Library.Code;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService.Dto;

namespace Web.GUI.Fornitore
{
    public class FornitoreViewModel : Library.Template.MVVM.TemplateViewModel<FornitoreView, FornitoreItem, FornitoreModel, FornitoreDto>
    {
        private CommessaDto commessa = null;

        public CommessaDto Commessa
        {
            get
            {
                return commessa;
            }
            set
            {
                commessa = value;
            }
        }

        public FornitoreViewModel()
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

        public override void Load(int skip, int take, string search=null, object advancedSearch=null)
        {
            try
            {
                var wcf = new WcfService.Service();
                var objs = wcf.LoadFornitori(skip, take, search, commessa);
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
                var count = wcf.CountFornitori(search, commessa);
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
                    var obj = (FornitoreDto)model;
                    bool performed = false;
                    if (creating)
                    {
                        var newObj = wcf.CreateFornitore(obj);
                        performed = (newObj != null);
                        if (performed)
                            Update(obj, newObj);
                    }
                    else //updating
                        performed = wcf.UpdateFornitore(obj);
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
                    var obj = (FornitoreDto)model;
                    bool performed = wcf.DeleteFornitore(obj);
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
                var obj = wcf.ReadFornitore(id);
                return obj;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        internal IEnumerable<FornitoreDto> ReadFornitori()
        {
            try
            {
                var wcf = new WcfService.Service();
                var objs = wcf.ReadFornitori();
                return objs;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        internal IEnumerable<FornitoreDto> ReadFornitori(AnagraficaFornitoreDto anagraficaFornitore)
        {
            try
            {
                var wcf = new WcfService.Service();
                var objs = wcf.ReadFornitori(anagraficaFornitore);
                return objs;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        internal IEnumerable<FornitoreDto> ReadFornitori(CommessaDto commessa)
        {
            try
            {
                var wcf = new WcfService.Service();
                var objs = wcf.ReadFornitori(commessa);
                return objs;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }


        internal IEnumerable<FornitoreDto> ReadFornitori(IEnumerable<AnagraficaFornitoreDto> anagraficheFornitori)
        {
            try
            {
                var wcf = new WcfService.Service();
                var objs = wcf.ReadFornitori(anagraficheFornitori);
                return objs;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        internal FornitoreDto ReadFornitore(NotaCreditoDto notaCredito)
        {
            try
            {
                if(notaCredito!=null)
                {
                    var fornitoreId = notaCredito.FornitoreId;
                    var fornitore = (FornitoreDto)Read(fornitoreId);
                    return fornitore;
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