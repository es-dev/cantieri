using Library.Code;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.GUI.Agenda
{
    public class AgendaViewModel : Library.Template.MVVM.TemplateViewModel<EventoDto, AgendaItem> 
    {
        public AgendaViewModel(ISpace space)
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

        public override void Fill(object start, object end, string search)
        {
            try
            {
                List<EventoDto> objs = null;
                var wcf = new WcfService.Service();
                //qui richiamo da db tutto ciò che mi occorre rappresentare come eventi, fatture in scadenza, creazione fatture, pagamenti effettuati, note di credito ....
                //var fattureAcquistoScadenza = wcf.ReadFattureAcquistoScadenza(start, end, search);
                //var objsFattureScadenza = GetEventi(fattureAcquisto);  //qui dalle fatture ricavo gli eventi

                //var pagamenti = wcf.ReadPagamenti(start, end, search);
                //var objsPagamenti = GetEventi(pagamenti); 

                //objs.AddRange(objsFattureScadenza);
                //objs.AddRange(objsPagamenti);
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
                var count = 0;// wcf.CountAziende(search);
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

    }
}