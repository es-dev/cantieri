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
                IEnumerable<ResoDto> objs = null;
                if (notaCredito == null && fatturaAcquisto == null)
                    objs = wcf.LoadResi(skip, take, search);
                else if (notaCredito != null)
                    objs = wcf.LoadResiNotaCredito(skip, take, notaCredito, search);
                else if (fatturaAcquisto != null)
                    objs = wcf.LoadResiFatturaAcquisto(skip, take, fatturaAcquisto, search);

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
                if (notaCredito == null && fatturaAcquisto == null)
                    count = wcf.CountResi(search);
                else if (notaCredito != null)
                    count = wcf.CountResiNotaCredito(notaCredito, search);
                else if (fatturaAcquisto != null)
                    count = wcf.CountResiFatturaAcquisto(fatturaAcquisto, search);
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
                            obj = newObj;
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

        public new ResoDto Read(object id)
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