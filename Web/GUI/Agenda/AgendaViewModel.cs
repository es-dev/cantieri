using Library.Code;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using WcfService.Dto;

namespace Web.GUI.Agenda
{
    public class AgendaViewModel : Library.Template.MVVM.TemplateViewModel<AgendaDto, AgendaItem> 
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
                var objs = new List<AgendaDto>();
                var wcf = new WcfService.Service();
                var fattureAcquistoScadenza = wcf.LoadFattureAcquisto(0,1000); // wcf.ReadFattureAcquistoScadenza(start, end, search);
                var objsFattureScadenza = GetEventiAgenda(fattureAcquistoScadenza);  

                //var pagamenti = wcf.ReadPagamenti(start, end, search);
                //var objsPagamenti = GetEventi(pagamenti); 

                objs.AddRange(objsFattureScadenza);
                //objs.AddRange(objsPagamenti);

                Load(objs);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private IList<AgendaDto> GetEventiAgenda(IEnumerable<FatturaAcquistoDto> fattureAcquistoScadenza)
        {
            try
            {
                var eventi = new List<AgendaDto>();
                foreach(var fatturaAcquistoScadenza in fattureAcquistoScadenza)
                {
                    var evento = new AgendaDto();
                    evento.Color = Color.Yellow;
                    evento.Data = UtilityValidation.GetData(fatturaAcquistoScadenza.Data);
                    evento.Model = fatturaAcquistoScadenza;
                    evento.Titolo = "Fattura di acquisto n."+ fatturaAcquistoScadenza.Numero + " del " + evento.Data.ToString("dd/MM/yyyy");

                    eventi.Add(evento);
                }
                return eventi;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public override int GetCount(string search=null)
        {
            try
            {
                var count = Items.Count;
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