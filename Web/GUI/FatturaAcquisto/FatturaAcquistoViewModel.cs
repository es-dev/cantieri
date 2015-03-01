using BusinessLogic;
using Library.Code;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService.Dto;

namespace Web.GUI.FatturaAcquisto
{
    public class FatturaAcquistoViewModel : Library.Template.MVVM.TemplateViewModel<FatturaAcquistoDto, FatturaAcquistoItem>
    {
        private AnagraficaFornitoreDto anagraficaFornitore = null;
        public AnagraficaFornitoreDto AnagraficaFornitore
        {
            get
            {
                return anagraficaFornitore;
            }
            set
            {
                anagraficaFornitore = value;
            }
        }

        private Tipi.StatoFattura statoFattura = Tipi.StatoFattura.None;
        public Tipi.StatoFattura StatoFattura
        {
            get
            {
                return statoFattura;
            }
            set
            {
                statoFattura = value;
            }
        }

        public FatturaAcquistoViewModel(ISpace space)
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
                IEnumerable<FatturaAcquistoDto> objs = null;
                if(anagraficaFornitore==null)
                    objs = wcf.LoadFattureAcquisto(skip, take, search);
                else if(anagraficaFornitore!=null && statoFattura== Tipi.StatoFattura.NonPagata || statoFattura== Tipi.StatoFattura.Insoluta)
                    objs = wcf.LoadFattureAcquistoFornitoreDare(skip, take, search, anagraficaFornitore);
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
                if(anagraficaFornitore==null)
                     count = wcf.CountFattureAcquisto(search);
                else if(anagraficaFornitore!=null && statoFattura== Tipi.StatoFattura.NonPagata || statoFattura== Tipi.StatoFattura.Insoluta)
                    count = wcf.CountFattureAcquisto(search, anagraficaFornitore);
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
                    var obj = (FatturaAcquistoDto)model;
                    bool performed = false;
                    if (creating)
                    {
                        var newObj = wcf.CreateFatturaAcquisto(obj);
                        performed = (newObj != null);
                        if (performed)
                            obj = newObj;
                    }
                    else //updating
                        performed = wcf.UpdateFatturaAcquisto(obj);
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
                    var obj = (FatturaAcquistoDto)model;
                    bool performed = wcf.DeleteFatturaAcquisto(obj);
                    return performed;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public new FatturaAcquistoDto Read(object id)
        {
            try
            {
                var wcf = new WcfService.Service();
                var obj = wcf.ReadFatturaAcquisto(id);
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