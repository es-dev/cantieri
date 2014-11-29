using Library.Code;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService.Dto;

namespace Web.GUI.AnagraficaFornitore
{
    public class AnagraficaFornitoreViewModel : Library.Template.MVVM.TemplateViewModel<AnagraficaFornitoreDto, AnagraficaFornitoreItem>
    {

        public AnagraficaFornitoreViewModel(ISpace space)
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

        public override void Load(int skip, int take)
        {
            try
            {
                var wcf = new WcfService.Service();
                var objs = wcf.LoadAnagraficheFornitori(skip, take);
                Load(objs);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override int GetCount()
        {
            try
            {
                var wcf = new WcfService.Service();
                var count = wcf.CountAnagraficheFornitori();
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
                            obj.Id = newObj.Id;
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

        public override object Read(object Id)
        {
            try
            {
                var wcf = new WcfService.Service();
                var obj = wcf.ReadAnagraficaFornitore(Id);
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