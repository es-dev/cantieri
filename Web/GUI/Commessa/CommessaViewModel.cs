using BusinessLogic;
using Library.Code;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using WcfService.Dto;

namespace Web.GUI.Commessa
{
    public class CommessaViewModel : Library.Template.MVVM.TemplateViewModel<CommessaView, CommessaItem, CommessaModel, CommessaDto>
    {
     
        public CommessaViewModel()
            : base() 
        {
           
        }

        public override void Load(int skip, int take, string search = null, object advancedSearch=null, OrderBy orderBy=null)
        {
            try
            {
                var wcf = new WcfService.Service();
                var objs = wcf.LoadCommesse(skip, take, search, advancedSearch, orderBy);
                Load(objs);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override int Count(string search = null, object advancedSearch=null)
        {
            try
            {
                var wcf = new WcfService.Service();
                var count = wcf.CountCommesse(search, advancedSearch);
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
                            Update(obj, newObj);
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

        public override object Read(object id)
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

        public CommessaDto ReadCommessa(SALDto sal)
        {
            try
            {
                var wcf = new WcfService.Service();
                var commessaId = sal.CommessaId;
                var obj = wcf.ReadCommessa(commessaId, true);
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

        public CommessaDto ReadCommessa(FatturaAcquistoDto fatturaAcquisto)
        {
            try
            {
                if (fatturaAcquisto != null)
                {
                    var fornitoreId = fatturaAcquisto.FornitoreId;
                    var viewModel = new Fornitore.FornitoreViewModel();
                    var fornitore = (FornitoreDto)viewModel.Read(fornitoreId);
                    if (fornitore != null)
                    {
                        var commessa = fornitore.Commessa;
                        return commessa;
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public CommessaDto ReadCommessa(FatturaVenditaDto fatturaVendita)
        {
            try
            {
                if (fatturaVendita != null)
                {
                    var committenteId = fatturaVendita.CommittenteId;
                    var viewModel = new Committente.CommittenteViewModel();
                    var committente = (CommittenteDto)viewModel.Read(committenteId);
                    if (committente != null)
                    {
                        var commessa = committente.Commessa;
                        return commessa;
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