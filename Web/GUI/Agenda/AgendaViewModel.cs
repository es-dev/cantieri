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
                    evento.Color = Color.LightBlue;

                    evento.Titolo = BusinessLogic.Pagamento.GetCodifica(pagamentoData) + " per un importo di " + UtilityValidation.GetEuro(pagamentoData.Importo);
                    var fatturaAcquisto = pagamentoData.FatturaAcquisto;
                    if (fatturaAcquisto != null)
                    {
                        var scadenzaFatturaAcquisto = (DateTime)fatturaAcquisto.Scadenza;
                        evento.Titolo += " relativo alla " + BusinessLogic.Fattura.GetCodifica(fatturaAcquisto) + " con scadenza " + scadenzaFatturaAcquisto.ToString("dd/MM/yyyy");
                    }
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

        private IList<AgendaDto> GetEventiAgenda(IEnumerable<FatturaAcquistoDto> fattureAcquisto)
        {
            try
            {
                var eventi = new List<AgendaDto>();
                foreach(var fatturaAcquisto in fattureAcquisto)
                {
                    var evento = new AgendaDto();
                    evento.Data = UtilityValidation.GetData(fatturaAcquisto.Scadenza);
                    evento.Model = fatturaAcquisto;
                    
                    var today = DateTime.Today;
                    var saldoFatturaAcquisto = UtilityValidation.GetEuro(BusinessLogic.Fattura.GetTotaleSaldoFatturaAcquisto(fatturaAcquisto, today));
                    var pagamentiDare= BusinessLogic.Fattura.GetTotalePagamentiDare(fatturaAcquisto, today);
                    var pagamentiDato=BusinessLogic.Fattura.GetTotalePagamentiDato(fatturaAcquisto, today);
                    
                    evento.Titolo = BusinessLogic.Fattura.GetCodifica(fatturaAcquisto) + " con scadenza il " +
                                    evento.Data.ToString("dd/MM/yyyy") + " per un importo di " + saldoFatturaAcquisto.ToString();
                    if(pagamentiDato > 0)
                        evento.Titolo+=". Totale pagato = " + (UtilityValidation.GetEuro(pagamentiDato)).ToString();
                    if(pagamentiDare > 0)
                        evento.Titolo += ", totale da pagare = " + (UtilityValidation.GetEuro(pagamentiDare)).ToString();

                    var stato = BusinessLogic.Fattura.GetStato(fatturaAcquisto);
                    if (stato == BusinessLogic.Tipi.StatoFattura.Insoluta)
                        evento.Color = Color.Red;
                    if (stato == BusinessLogic.Tipi.StatoFattura.Pagata)
                        evento.Color = Color.LightGreen;
                    if (stato == BusinessLogic.Tipi.StatoFattura.NonPagata)
                        evento.Color = Color.Yellow;
                    if (stato == BusinessLogic.Tipi.StatoFattura.Incoerente)
                        evento.Color = Color.Orange;

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