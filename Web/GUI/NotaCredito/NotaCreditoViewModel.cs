using Library.Code;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService.Dto;

namespace Web.GUI.NotaCredito
{
    public class NotaCreditoViewModel : Library.Template.MVVM.TemplateViewModel<NotaCreditoDto, NotaCreditoItem>
    {

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

        private FornitoreDto fornitore = null;

        public FornitoreDto Fornitore
        {
            get
            {
                return fornitore;
            }
            set
            {
                fornitore = value;
            }
        }


        public NotaCreditoViewModel(ISpace space)
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
                IEnumerable<NotaCreditoDto> objs = null;
                if(fatturaAcquisto==null  && fornitore==null)
                    objs = wcf.LoadNoteCredito(skip, take, search);
                else if (fatturaAcquisto != null)
                    objs = wcf.LoadNoteCreditoFatturaAcquisto(skip, take, fatturaAcquisto, search);
                else if (fornitore != null)
                    objs = wcf.LoadNoteCreditoFornitore(skip, take, fornitore, search);

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
                if (fatturaAcquisto == null && fornitore == null)
                    count = wcf.CountNoteCredito(search);
                else if (fatturaAcquisto != null)
                    count = wcf.CountNoteCreditoFatturaAcquisto(fatturaAcquisto, search);
                else if (fornitore != null)
                    count = wcf.CountNoteCreditoFornitore(fornitore, search);
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
                    var obj = (NotaCreditoDto)model;
                    bool performed = false;
                    if (creating)
                    {
                        var newObj = wcf.CreateNotaCredito(obj);
                        performed = (newObj != null);
                        if (performed)
                            obj = newObj;
                    }
                    else //updating
                        performed = wcf.UpdateNotaCredito(obj);
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
                    var obj = (NotaCreditoDto)model;
                    bool performed = wcf.DeleteNotaCredito(obj);
                    return performed;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public new NotaCreditoDto Read(object id)
        {
            try
            {
                var wcf = new WcfService.Service();
                var obj = wcf.ReadNotaCredito(id);
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