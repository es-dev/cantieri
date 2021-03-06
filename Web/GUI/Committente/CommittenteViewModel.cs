﻿using Library.Code;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService.Dto;

namespace Web.GUI.Committente
{
    public class CommittenteViewModel : Library.Template.MVVM.TemplateViewModel<CommittenteView, CommittenteItem, CommittenteModel, CommittenteDto>
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

        public CommittenteViewModel()
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

        public override void Load(int skip, int take, string search=null, object advancedSearch=null, OrderBy orderBy=null)
        {
            try
            {
                var wcf = new WcfService.Service();
                var objs = wcf.LoadCommittenti(skip, take, search, advancedSearch, commessa, orderBy);
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
                int count = wcf.CountCommittenti(search, advancedSearch, commessa);
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

        internal IEnumerable<CommittenteDto> ReadCommittenti(AnagraficaCommittenteDto anagraficaCommittente)
        {
            try
            {
                var wcf = new WcfService.Service();
                var objs = wcf.ReadCommittenti(anagraficaCommittente);
                return objs;

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        internal IEnumerable<CommittenteDto> ReadCommittenti(IEnumerable<AnagraficaCommittenteDto> anagraficheCommittenti)
        {
            try
            {
                var wcf = new WcfService.Service();
                var objs = wcf.ReadCommittenti(anagraficheCommittenti);
                return objs;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        internal CommittenteDto ReadCommittente(FatturaVenditaDto fatturaVendita)
        {
            try
            {
                if(fatturaVendita!=null)
                {
                    var viewModel = new FatturaVendita.FatturaVenditaViewModel();
                    var _fatturaVendita = (FatturaVenditaDto)viewModel.Read(fatturaVendita.Id);
                    if(_fatturaVendita!=null)
                    {
                        var committente = _fatturaVendita.Committente;
                        return committente;
                    }
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