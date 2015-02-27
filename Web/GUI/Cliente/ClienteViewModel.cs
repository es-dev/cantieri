﻿using Library.Code;
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

        private ClienteDto oldObj = null;
        public ClienteDto OldObj
        {
            get
            {
                return oldObj;
            }
            set
            {
                oldObj = value;
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
                var objs = wcf.LoadClienti(skip, take, search);
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
                var count = wcf.CountClienti(search);
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
                    var _obj = Read(obj.Id);
                    creating = (_obj == null); //condizione di creazione --> non esistenza in db
                    if (oldObj != null && oldObj.Id!=obj.Id) //eliminazione del modello preassociato
                        Delete(oldObj);

                    bool performed = false;
                    if (creating)
                    {
                        var newObj = wcf.CreateCliente(obj);
                        performed = (newObj != null);
                        if (performed)
                            obj.Id = newObj.Id;
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