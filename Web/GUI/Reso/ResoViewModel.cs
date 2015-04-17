using Library.Code;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService.Dto;

namespace Web.GUI.Reso
{
    public class ResoViewModel : Library.Template.MVVM.TemplateViewModel<ResoDto, ResoItem>
    {

        private NotaCreditoDto notaCredito = null;
        public NotaCreditoDto NotaCredito
        {
            get
            {
                return notaCredito;
            }
            set
            {
                notaCredito = value;
            }
        }

        private FatturaAcquistoDto fatturaAcquisto = null;
        public FatturaAcquistoDto FatturaAcquisto
        {
            get
            {
                return fatturaAcquisto;
            }
            set
            {
                fatturaAcquisto = value;
            }
        }


        public ResoViewModel(ISpace space)
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

        public override void Load(int skip, int take, string search = null)
        {
            try
            {
                var wcf = new WcfService.Service();
                var objs = wcf.LoadResi(skip, take, search, notaCredito, fatturaAcquisto);
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
                var count = wcf.CountResi(search, notaCredito, fatturaAcquisto);
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
                    var obj = (ResoDto)model;
                    bool performed = false;
                    if (creating)
                    {
                        var newObj = wcf.CreateReso(obj);
                        performed = (newObj != null);
                        if (performed)
                            Update(obj, newObj);
                    }
                    else //updating
                        performed = wcf.UpdateReso(obj);
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
                    var obj = (ResoDto)model;
                    bool performed = wcf.DeleteReso(obj);
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
                var obj = wcf.ReadReso(id);
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