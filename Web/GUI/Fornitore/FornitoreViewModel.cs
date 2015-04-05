using Library.Code;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService.Dto;

namespace Web.GUI.Fornitore
{
    public class FornitoreViewModel : Library.Template.MVVM.TemplateViewModel<FornitoreDto, FornitoreItem>
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

        public FornitoreViewModel(ISpace space)
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
                IEnumerable<FornitoreDto> objs = null;
                if (commessa==null)
                    objs = wcf.LoadFornitori(skip, take, search);
                else
                    objs = wcf.LoadFornitoriCommessa(skip, take, commessa, search);
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
                if (commessa==null)
                    count = wcf.CountFornitori(search);
                else
                    count = wcf.CountFornitoriCommessa(commessa, search);
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
                            obj = newObj;
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

        public new FornitoreDto Read(object id)
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

        internal IEnumerable<FornitoreDto> ReadFornitori(string codiceFornitore)
        {
            try
            {
                var wcf = new WcfService.Service();
                var objs = wcf.ReadFornitori(codiceFornitore);
                return objs;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

    }
}