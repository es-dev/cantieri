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
                var fattureAcquistoScadenza = wcf.ReadFattureAcquistoScadenza((DateTime)start, (DateTime)end, search);
                if (fattureAcquistoScadenza!=null)
                {
                    var objsFattureScadenza = GetEventiAgenda(fattureAcquistoScadenza);
                    objs.AddRange(objsFattureScadenza);
                }

                var pagamenti = wcf.ReadPagamentiData((DateTime)start, (DateTime)end, search);
                if (pagamenti != null)
                {
                    var objsPagamenti = GetEventiAgenda(pagamenti);
                    objs.AddRange(objsPagamenti);
                }

                Load(objs);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private IList<AgendaDto> GetEventiAgenda(IEnumerable<PagamentoDto> pagamentiData)
        {
            try
            {
                var eventi = new List<AgendaDto>();
                foreach (var pagamentoData in pagamentiData)
                {
                    var evento = new AgendaDto();
                    evento.Data = UtilityValidation.GetData(pagamentoData.Data);
                    evento.Model = pagamentoData;
                    evento.Color = Color.RoyalBlue;

                    var data = (DateTime)pagamentoData.Data;
                    evento.Titolo = "Pagamento n." + pagamentoData.Codice + " del " + data.ToString("dd/MM/yyyy") + " per un importo di " + UtilityValidation.GetEuro(pagamentoData.Importo);
                    var fatturaAcquisto = pagamentoData.FatturaAcquisto;
                    if (fatturaAcquisto != null)
                        evento.Titolo += " relativo alla fattura " + fatturaAcquisto.Numero;

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

        private IList<AgendaDto> GetEventiAgenda(IEnumerable<FatturaAcquistoDto> fattureAcquistoScadenza)
        {
            try
            {
                var eventi = new List<AgendaDto>();
                foreach(var fatturaAcquistoScadenza in fattureAcquistoScadenza)
                {
                    var evento = new AgendaDto();
                    evento.Data = UtilityValidation.GetData(fatturaAcquistoScadenza.Scadenza);
                    evento.Model = fatturaAcquistoScadenza;
                    
                    var today = DateTime.Today;
                    var saldoFatturaAcquisto = UtilityValidation.GetEuro(BusinessLogic.Fattura.GetTotaleSaldoFatturaAcquisto(fatturaAcquistoScadenza, today));
                    var pagamentiDare= UtilityValidation.GetEuro(BusinessLogic.Fattura.GetTotalePagamentiDare(fatturaAcquistoScadenza, today));
                    var pagamentiDato=UtilityValidation.GetEuro( BusinessLogic.Fattura.GetTotalePagamentiDato(fatturaAcquistoScadenza, today));
                    var data = (DateTime)fatturaAcquistoScadenza.Data;
                    evento.Titolo = "Fattura di acquisto n." + fatturaAcquistoScadenza.Numero + " del " + data.ToString("dd/MM/yyyy") + " con scadenza il " + 
                        evento.Data.ToString("dd/MM/yyyy") + " per un importo di " + saldoFatturaAcquisto.ToString() + ". Totale pagato = " +
                        pagamentiDato.ToString() + ", totale a pagare = " + pagamentiDare.ToString();

                    var stato = BusinessLogic.Fattura.GetStato(fatturaAcquistoScadenza);
                    if (stato == BusinessLogic.Tipi.StatoFattura.Insoluta)
                        evento.Color = Color.Red;
                    if (stato == BusinessLogic.Tipi.StatoFattura.Pagata)
                        evento.Color = Color.Green;
                    if (stato == BusinessLogic.Tipi.StatoFattura.NonPagata)
                        evento.Color = Color.Yellow;

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
                var wcf = new WcfService.Service();
                var countFattureAcquistoScadenza = wcf.CountFattureAcquisto(search);
                var countPagamenti = wcf.CountPagamenti(search);

                var count = countFattureAcquistoScadenza + countPagamenti;
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