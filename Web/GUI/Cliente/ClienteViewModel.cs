using Library.Code;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService.Dto;

namespace Web.GUI.Cliente
{
    public class ClienteViewModel : Library.Template.MVVM.TemplateViewModel<ClienteDto, ClienteItem>
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

        public ClienteViewModel(ISpace space)
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
                IEnumerable<ClienteDto> objs = null;
                if (commessa==null)
                    objs = wcf.LoadClienti(skip, take, search);
                else
                    objs = wcf.LoadClientiCommessa(skip, take, commessa, search);

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
                int count = 0;
                if (commessa == null)
                    count = wcf.CountClienti(search);
                else
                    count = wcf.CountClientiCommessa(commessa, search);
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
                    var obj = (ClienteDto)model;
                    bool performed = false;
                    if (creating)
                    {
                        var newObj = wcf.CreateCliente(obj);
                        performed = (newObj != null);
                        if (performed)
                            obj = newObj;
                    }
                    else //updating
                        performed = wcf.UpdateCliente(obj);
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
                    var obj = (ClienteDto)model;
                    bool performed = wcf.DeleteCliente(obj);
                    return performed;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public new ClienteDto Read(object id)
        {
            try
            {
                var wcf = new WcfService.Service();
                var obj = wcf.ReadCliente(id);
                return obj;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        internal IEnumerable<ClienteDto> ReadClienti()
        {
            try
            {
                var wcf = new WcfService.Service();
                var objs = wcf.ReadClienti();
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