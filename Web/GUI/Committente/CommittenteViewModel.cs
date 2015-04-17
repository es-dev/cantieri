using Library.Code;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService.Dto;

namespace Web.GUI.Committente
{
    public class CommittenteViewModel : Library.Template.MVVM.TemplateViewModel<CommittenteDto, CommittenteItem>
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

        public CommittenteViewModel(ISpace space)
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
                var objs = wcf.LoadCommittenti(skip, take, search, commessa);
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
                int count = wcf.CountCommittenti(search, commessa);
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
                    var obj = (CommittenteDto)model;
                    bool performed = false;
                    if (creating)
                    {
                        var newObj = wcf.CreateCommittente(obj);
                        performed = (newObj != null);
                        if (performed)
                            Update(obj, newObj);
                    }
                    else //updating
                        performed = wcf.UpdateCommittente(obj);
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
                    var obj = (CommittenteDto)model;
                    bool performed = wcf.DeleteCommittente(obj);
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
                var obj = wcf.ReadCommittente(id);
                return obj;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        internal IEnumerable<CommittenteDto> ReadCommittenti()
        {
            try
            {
                var wcf = new WcfService.Service();
                var objs = wcf.ReadCommittenti();
                return objs;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        internal IEnumerable<CommittenteDto> ReadCommittenti(CommessaDto commessa)
        {
            try
            {
                var wcf = new WcfService.Service();
                var objs = wcf.ReadCommittenti(commessa);
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