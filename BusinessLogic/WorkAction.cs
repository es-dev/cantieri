using Library.Code;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BusinessLogic
{
    public class WorkAction : IWorkAction
    {
        public WorkAction()
        {

        }

        private string name = "Workflow per la gestione degli stati, invio delle notifiche, ...";
        public string Name
        {
            get
            {
                return name;
            }
        }

        private TimeSpan interval = new TimeSpan(0, 5, 0);
        public TimeSpan Interval
        {
            get
            {
                return interval;
            }
        }

        private HttpContext context = null;
        public HttpContext Context
        {
            get
            {
                return context;
            }
            set
            {
                context = value;
            }
        }

        public void Start()
        {
            try
            {
                KeepAlive();
                CheckState();
                //CheckScadenze();

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void CheckScadenze()
        {
            try
            {
                CheckScadenzeFattureAcquisto();
                CheckScadenzeFattureVendita();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void CheckScadenzeFattureVendita()
        {
            try
            {

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void CheckScadenzeFattureAcquisto()
        {
            try
            {
                var giorniPreavviso = 7;
                var inizio = DateTime.Now;
                var fine = inizio.AddDays(giorniPreavviso);
                var wcf = new WcfService.Service();
                var fattureAcquisto = wcf.ReadFattureAcquisto(inizio, fine);
                if(fattureAcquisto!=null)
                {
                    foreach (var fatturaAcquisto in fattureAcquisto)
                    {
                        //verifica se già notificata
                        var data = DateTime.Today;
                        var codificaFattura = BusinessLogic.Fattura.GetCodifica(fatturaAcquisto);
                        var scadenza = UtilityValidation.GetDataND(fatturaAcquisto.Scadenza);
                        var totalePagamentiDare = BusinessLogic.Fattura.GetTotalePagamentiDare(fatturaAcquisto, data);
                        if (totalePagamentiDare > 0)
                        {
                            var email = "pasqualeiaquinta@hotmail.com";
                            var subject = GetSubjectAvvisoScadenzaFattura(fatturaAcquisto, codificaFattura, scadenza, totalePagamentiDare);
                            var body = GetBodyAvvisoScadenzaFattura(fatturaAcquisto, data, scadenza, totalePagamentiDare);
                            var sent = UtilityEmail.Send(email, subject, body);
                            if (sent)
                            {
                                //aggiornamento tabella notifiche
                                break;
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private string GetBodyAvvisoScadenzaFattura(WcfService.Dto.FatturaAcquistoDto fatturaAcquisto, DateTime data, string scadenza, decimal totalePagamentiDare)
        {
            try
            {
                var pathRoot = UtilityWeb.GetRootPath(context);
                var pathTemplateAvvisoScadenzaFattura = pathRoot + @"\Resources\Templates\TemplateAvvisoScadenzaFattura.html";
                var content = System.IO.File.ReadAllText(pathTemplateAvvisoScadenzaFattura);
                var codificaFattura = BusinessLogic.Fattura.GetCodifica(fatturaAcquisto).ToLower();
                var codificaFornitore = BusinessLogic.Fornitore.GetCodifica(fatturaAcquisto.Fornitore);
                var codificaAzienda = BusinessLogic.Azienda.GetCodifica(fatturaAcquisto.Fornitore.Commessa.Azienda);
                var codificaPagamenti = GetCodificaPagamenti(fatturaAcquisto.Pagamentos);
                var totalePagamentiDato = UtilityValidation.GetEuro(BusinessLogic.Fattura.GetTotalePagamentiDato(fatturaAcquisto, data));
                var totaleFattura = UtilityValidation.GetEuro(fatturaAcquisto.Totale);
                content = content.Replace("$codificaAzienda$", codificaAzienda);
                content = content.Replace("$codificaFattura$", codificaFattura);
                content = content.Replace("$codificaFornitore$",codificaFornitore );
                content = content.Replace("$codificaPagamenti$", codificaPagamenti);
                content = content.Replace("$scadenza$", scadenza);
                content = content.Replace("$totalePagamentiDato$",totalePagamentiDato);
                content = content.Replace("$totalePagamentiDare$", UtilityValidation.GetEuro(totalePagamentiDare));
                content = content.Replace("$totaleFattura$", totaleFattura);

                return content;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private string GetCodificaPagamenti(IList<WcfService.Dto.PagamentoDto> pagamenti)
        {
            try
            {
                string listaPagamenti = null;
                if (pagamenti != null && pagamenti.Count >= 1)
                {
                    foreach (var pagamento in pagamenti)
                    {
                        if (listaPagamenti != null)
                            listaPagamenti += "<br />";

                        listaPagamenti += "N. " + BusinessLogic.Pagamento.GetCodifica(pagamento).ToLower() + " per un importo pari a " + UtilityValidation.GetEuro(pagamento.Importo) +
                            " | Tipo transazione: " + pagamento.TransazionePagamento;
                    }
                }
                if (listaPagamenti == null)
                    listaPagamenti = "Nessun pagamento";

                return listaPagamenti;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private string GetSubjectAvvisoScadenzaFattura(WcfService.Dto.FatturaAcquistoDto fatturaAcquisto, string codificaFattura, string scadenza, decimal totalePagamentiDare)
        {
            try
            {
                var subject = "AVVISO DI SCADENZA | FATTURA N." + codificaFattura + " | SCADENZA IL " + scadenza + " | TOTALE DA PAGARE " + UtilityValidation.GetEuro(totalePagamentiDare);
                return subject;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private void CheckState()
        {
            try
            {
                CheckStatiFattureAcquisto();
                CheckStatiFattureVendita();
                CheckStatiFornitori();
                CheckStatiCommittenti();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void CheckStatiFattureAcquisto()
        {
            try
            {
                var wcf = new WcfService.Service();
                var stati = BusinessLogic.Tipi.GetStatiFattureInsoluteNonPagate();
                var fattureAcquisto = wcf.ReadFattureAcquisto(stati);
                if (fattureAcquisto != null)
                {
                    foreach (var fatturaAcquisto in fattureAcquisto)
                    {
                        fatturaAcquisto.Stato = BusinessLogic.Fattura.GetStatoDescrizione(fatturaAcquisto);
                        bool saved = wcf.UpdateFatturaAcquisto(fatturaAcquisto);
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void CheckStatiFattureVendita()
        {
            try
            {
                var wcf = new WcfService.Service();
                var stati = BusinessLogic.Tipi.GetStatiFattureInsoluteNonPagate();
                var fattureVendita = wcf.ReadFattureVendita(stati);
                if (fattureVendita != null)
                {
                    foreach (var fatturaVendita in fattureVendita)
                    {
                        fatturaVendita.Stato = BusinessLogic.Fattura.GetStatoDescrizione(fatturaVendita);
                        bool saved = wcf.UpdateFatturaVendita(fatturaVendita);
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }


        private void CheckStatiFornitori()
        {
            try
            {
                var wcf = new WcfService.Service();
                var stati = Tipi.GetStatiFornitoriInsolutiNonPagati();
                var fornitori = wcf.ReadFornitori(stati);
                if (fornitori != null)
                {
                    foreach (var fornitore in fornitori)
                    {
                        fornitore.Stato = BusinessLogic.Fornitore.GetStatoDescrizione(fornitore);
                        bool saved = wcf.UpdateFornitore(fornitore);
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void CheckStatiCommittenti()
        {
            try
            {
                var wcf = new WcfService.Service();
                var stati = Tipi.GetStatiCommittentiInsolutiNonIncassati();
                var committenti = wcf.ReadCommittenti(stati);
                if (committenti != null)
                {
                    foreach (var committente in committenti)
                    {
                        committente.Stato = BusinessLogic.Committente.GetStatoDescrizione(committente);
                        bool saved = wcf.UpdateCommittente(committente);
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void KeepAlive()
        {
            try
            {
                var url = UtilityWeb.GetRootUrl(context);
                var webclient = new WebClient();
                webclient.DownloadString(url);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
           
        }
       
    }
}
