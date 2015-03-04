using BusinessLogic;
using Library.Code;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService.Dto;

namespace Web.GUI.Commessa
{
    public class CommessaViewModel : Library.Template.MVVM.TemplateViewModel<CommessaDto, CommessaItem>
    {

        public CommessaViewModel(ISpace space)
            : base(space) 
        {
           
        }

        public override void Load(int skip, int take, string search=null)
        {
            try
            {
                var wcf = new WcfService.Service();
                var objs = wcf.LoadCommesse(skip, take, search);
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
                var count = wcf.CountCommesse(search);
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
                    var obj = (CommessaDto)model;
                    bool performed = false;
                    if (creating)
                    {
                        var newObj = wcf.CreateCommessa(obj);
                        performed = (newObj != null);
                        if (performed)
                            obj = newObj;
                    }
                    else //updating
                        performed = wcf.UpdateCommessa(obj);
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
                    var obj = (CommessaDto)model;
                    bool performed = wcf.DeleteCommessa(obj);
                    return performed;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public new CommessaDto Read(object id)
        {
            try
            {
                var wcf = new WcfService.Service();
                var obj = wcf.ReadCommessa(id);
                return obj;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        internal IEnumerable<CommessaDto> ReadCommesse()
        {
            try
            {
                var wcf = new WcfService.Service();
                var objs = wcf.ReadCommesse();
                return objs;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }



        internal IEnumerable<CommessaDto> ReadCommesse(IEnumerable<FornitoreDto> fornitori)
        {
            try
            {
                var wcf = new WcfService.Service();
                var objs = wcf.ReadCommesse(fornitori);
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