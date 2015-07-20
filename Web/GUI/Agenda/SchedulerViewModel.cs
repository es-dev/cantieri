using Library.Code;
using Library.Interfaces;
using Library.Template.Scheduler;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using WcfService.Dto;

namespace Web.GUI.Agenda
{
    public class SchedulerViewModel : Library.Template.Scheduler.TemplateViewModel<SchedulerView, SchedulerItem> 
    {
        public SchedulerViewModel()
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

        public override void Fill(object start, object end, string search, object advancedSearch = null, OrderBy orderBy = null)
        {
            try
            {
                var objs = new List<SchedulerDto>();
                var wcf = new WcfService.Service();
                var fattureAcquistoScadenza = wcf.ReadFattureAcquisto((DateTime)start, (DateTime)end, search, advancedSearch);
                if (fattureAcquistoScadenza!=null)
                {
                    var objsFattureAcquistoScadenza = GetEventiAgenda(fattureAcquistoScadenza);
                    objs.AddRange(objsFattureAcquistoScadenza);
                }

                var fattureVenditaScadenza = wcf.ReadFattureVendita((DateTime)start, (DateTime)end, search, advancedSearch);
                if (fattureVenditaScadenza != null)
                {
                    var objsFattureVenditaScadenza = GetEventiAgenda(fattureVenditaScadenza);
                    objs.AddRange(objsFattureVenditaScadenza);
                }

                var pagamenti = wcf.ReadPagamenti((DateTime)start, (DateTime)end, search, advancedSearch);
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

        private IList<SchedulerDto> GetEventiAgenda(IEnumerable<PagamentoDto> pagamentiData)
        {
            try
            {
                var eventi = new List<SchedulerDto>();
                foreach (var pagamentoData in pagamentiData)
                {
                    var evento = new SchedulerDto();
                    evento.Start = UtilityValidation.GetData(pagamentoData.Data);
                    evento.Model = pagamentoData;
                    evento.BackgroundColor = Color.LightBlue;

                    var codificaPagamento = BusinessLogic.Pagamento.GetCodifica(pagamentoData);
                    if (codificaPagamento != null)
                        codificaPagamento = codificaPagamento.ToLower();

                    var titolo = "Pagamento " + codificaPagamento + " per un importo di " + UtilityValidation.GetEuro(pagamentoData.Importo);
                    var fatturaAcquisto = pagamentoData.FatturaAcquisto;
                    if (fatturaAcquisto != null)
                    {
                        var scadenza = (DateTime)fatturaAcquisto.Scadenza;
                        var codificaFattura = BusinessLogic.Fattura.GetCodifica(fatturaAcquisto);
                        if (codificaFattura != null)
                            codificaFattura = codificaFattura.ToLower();

                        titolo += " relativo alla fattura di acquisto " + codificaFattura + " con scadenza il " + scadenza.ToString("dd/MM/yyyy") + 
                            " | Fornitore "+BusinessLogic.Fornitore.GetCodifica(fatturaAcquisto.Fornitore);
                    }
                    evento.Subject = titolo;

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

        private IList<SchedulerDto> GetEventiAgenda(IEnumerable<FatturaVenditaDto> fattureVendita)
        {
            try
            {
                var eventi = new List<SchedulerDto>();
                foreach (var fatturaVendita in fattureVendita)
                {
                    var evento = new SchedulerDto();
                    var scadenza = UtilityValidation.GetData(fatturaVendita.Scadenza);
                    evento.Start = scadenza;
                    evento.Model = fatturaVendita;

                    var today = DateTime.Today;
                    var totaleFatturaVendita = UtilityValidation.GetEuro(BusinessLogic.Fattura.GetTotaleFatturaVendita(fatturaVendita));
                    var incassiAvere = BusinessLogic.Fattura.GetTotaleIncassiAvere(fatturaVendita, today);
                    var incassiAvuto = BusinessLogic.Fattura.GetTotaleIncassiAvuto(fatturaVendita, today);
                    var codificaFattura = BusinessLogic.Fattura.GetCodifica(fatturaVendita);
                    if (codificaFattura != null)
                        codificaFattura = codificaFattura.ToLower();

                    var titolo = "Fattura di vendita " + codificaFattura + " con scadenza il " + scadenza.ToString("dd/MM/yyyy") +
                        " per un importo di " + totaleFatturaVendita.ToString();
                    if (incassiAvuto > 0)
                        titolo += ". Totale incassato = " + (UtilityValidation.GetEuro(incassiAvuto)).ToString();
                    if (incassiAvere > 0)
                        titolo += ", totale da incassare = " + (UtilityValidation.GetEuro(incassiAvere)).ToString();

                    titolo += " | Committente " + BusinessLogic.Committente.GetCodifica(fatturaVendita.Committente);
                    evento.Subject = titolo;

                    var color = Color.SandyBrown;
                    var stato = BusinessLogic.Fattura.GetStato(fatturaVendita);
                    if (stato == BusinessLogic.Tipi.StatoFattura.Insoluta)
                        color = Color.SandyBrown;
                    if (stato == BusinessLogic.Tipi.StatoFattura.Pagata)
                        color = Color.LightGreen;
                    if (stato == BusinessLogic.Tipi.StatoFattura.NonPagata)
                        color = Color.Yellow;
                    if (stato == BusinessLogic.Tipi.StatoFattura.Incoerente)
                        color = Color.Beige;
                    evento.BackgroundColor = color;

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

        private IList<SchedulerDto> GetEventiAgenda(IEnumerable<FatturaAcquistoDto> fattureAcquisto)
        {
            try
            {
                var eventi = new List<SchedulerDto>();
                foreach(var fatturaAcquisto in fattureAcquisto)
                {
                    var evento = new SchedulerDto();
                    var scadenza = UtilityValidation.GetData(fatturaAcquisto.Scadenza);
                    evento.Start = scadenza;
                    evento.Model = fatturaAcquisto;
                    
                    var today = DateTime.Today;
                    var saldoFatturaAcquisto = UtilityValidation.GetEuro(BusinessLogic.Fattura.GetTotaleSaldoFatturaAcquisto(fatturaAcquisto, today));
                    var pagamentiDare= BusinessLogic.Fattura.GetTotalePagamentiDare(fatturaAcquisto, today);
                    var pagamentiDato=BusinessLogic.Fattura.GetTotalePagamentiDato(fatturaAcquisto, today);
                    var codificaFattura = BusinessLogic.Fattura.GetCodifica(fatturaAcquisto);
                    if (codificaFattura != null)
                        codificaFattura = codificaFattura.ToLower();

                    var titolo = "Fattura di acquisto " + codificaFattura + " con scadenza il " + scadenza.ToString("dd/MM/yyyy") +
                        " per un importo di " + saldoFatturaAcquisto.ToString();
                    if(pagamentiDato > 0)
                        titolo+=". Totale pagato = " + (UtilityValidation.GetEuro(pagamentiDato)).ToString();
                    if(pagamentiDare > 0)
                        titolo += ", totale da pagare = " + (UtilityValidation.GetEuro(pagamentiDare)).ToString();

                    titolo += " | Fornitore " + BusinessLogic.Fornitore.GetCodifica(fatturaAcquisto.Fornitore);
                    evento.Subject = titolo;

                    var color = Color.SandyBrown;
                    var stato = BusinessLogic.Fattura.GetStato(fatturaAcquisto);
                    if (stato == BusinessLogic.Tipi.StatoFattura.Insoluta)
                        color = Color.SandyBrown;
                    if (stato == BusinessLogic.Tipi.StatoFattura.Pagata)
                        color = Color.LightGreen;
                    if (stato == BusinessLogic.Tipi.StatoFattura.NonPagata)
                        color = Color.Yellow;
                    if (stato == BusinessLogic.Tipi.StatoFattura.Incoerente)
                        color = Color.Beige;
                    evento.BackgroundColor = color;                  

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

        public override int Count(string search = null,  object advancedSearch=null)
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