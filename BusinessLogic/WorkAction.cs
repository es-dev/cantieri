using Library.Code;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using WcfService.Dto;

namespace BusinessLogic
{
    public class WorkAction : Library.Code.WorkAction
    {
        public WorkAction()
        {

        }

        private string name = "ES.Cantieri";
        public override string Name
        {
            get
            {
                return name;
            }
        }

        private string description = "Workflow per la gestione degli stati, invio delle notifiche, ...";
        public override string Description
        {
            get
            {
                return description;
            }
        }

        private TimeSpan interval = new TimeSpan(0, 5, 0);
        public override TimeSpan Interval
        {
            get
            {
                return interval;
            }
        }

        private HttpContext context = null;
        public override HttpContext Context
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

        public override void Start()
        {
            try
            {
                AddLog("Avvio work force manager...", "START");
                KeepAlive();
                CheckState();
                CheckScadenze();
                ClearNotifiche();
                AddLog("Stop work force manager...", "END");

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void ClearNotifiche()
        {
            try
            {
                int periodoLog = 7;
                AddLog("Clear delle notifiche storiche | periodo-log = "+periodoLog+" giorni ...", "OK");
                var dataMax = DateTime.Today.AddDays(-periodoLog);
                var wcf = new WcfService.Service();
                var notifiche = wcf.ReadNotifiche(dataMax, name);
                if(notifiche!=null)
                {
                    foreach (var notifica in notifiche)
                        wcf.DeleteNotifica(notifica);
                }
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
                AddLog("Controllo scadenze per fatture di acquisto...", "OK");
                CheckScadenzeFattureAcquisto();
                AddLog("Controllo scadenze per fatture di acquisto...", "OK");
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
                var giorniPreavviso = 7;
                var inizio = DateTime.Today;
                var fine = inizio.AddDays(giorniPreavviso);
                var wcf = new WcfService.Service();
                var fattureVendita = wcf.ReadFattureVendita(inizio, fine);
                if (fattureVendita != null)
                {
                    foreach (var fatturaVendita in fattureVendita)
                    {
                        var notifica = BusinessLogic.Notifica.GetNewNotifica(fatturaVendita, name);
                        var _notifica = wcf.ReadNotifica(notifica);
                        if (_notifica == null)
                        {
                            var data = DateTime.Today;
                            var totaleIncassiAvere = BusinessLogic.Fattura.GetTotaleIncassiAvere(fatturaVendita, data);
                            if (totaleIncassiAvere > 0)
                            {
                                var subject = GetSubjectAvvisoScadenzaFattura(fatturaVendita);
                                var body = GetBodyAvvisoScadenzaFattura(fatturaVendita, data, totaleIncassiAvere);
                                var email = BusinessLogic.Azienda.GetEmail(fatturaVendita);
                                if (email != null && email.Length > 0)
                                {
                                    UtilityEmail.Send("pasqualeiaquinta@hotmail.com", subject, body);
                                    var sent = UtilityEmail.Send(email, subject, body);
                                    if (sent)
                                    {
                                        notifica.Descrizione = subject;
                                        wcf.CreateNotifica(notifica);
                                    }
                                }
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

        private void CheckScadenzeFattureAcquisto()
        {
            try
            {
                var giorniPreavviso = 7;
                var inizio = DateTime.Today;
                var fine = inizio.AddDays(giorniPreavviso);
                var wcf = new WcfService.Service();
                var fattureAcquisto = wcf.ReadFattureAcquisto(inizio, fine);
                if(fattureAcquisto!=null)
                {
                    foreach (var fatturaAcquisto in fattureAcquisto)
                    {
                        var notifica = BusinessLogic.Notifica.GetNewNotifica(fatturaAcquisto, name);
                        var _notifica = wcf.ReadNotifica(notifica);
                        if (_notifica == null)
                        {
                            var data = DateTime.Today;
                            var totalePagamentiDare = BusinessLogic.Fattura.GetTotalePagamentiDare(fatturaAcquisto, data);
                            if (totalePagamentiDare > 0)
                            {
                                var subject = GetSubjectAvvisoScadenzaFattura(fatturaAcquisto);
                                var body = GetBodyAvvisoScadenzaFattura(fatturaAcquisto, data, totalePagamentiDare);
                                var email = BusinessLogic.Azienda.GetEmail(fatturaAcquisto);
                                if (email != null && email.Length > 0)
                                {
                                    UtilityEmail.Send("pasqualeiaquinta@hotmail.com", subject, body);
                                    var sent = UtilityEmail.Send(email, subject, body);
                                    if (sent)
                                    {
                                        notifica.Descrizione = subject;
                                        wcf.CreateNotifica(notifica);
                                    }
                                }
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

        private string GetSubjectAvvisoScadenzaFattura(FatturaAcquistoDto fatturaAcquisto)
        {
            try
            {
                var codificaFattura = BusinessLogic.Fattura.GetCodifica(fatturaAcquisto);
                var subject = "AVVISO DI SCADENZA FATTURA DI ACQUISTO N." + codificaFattura;
                return subject;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private string GetSubjectAvvisoScadenzaFattura(FatturaVenditaDto fatturaVendita)
        {
            try
            {
                var codificaFattura = BusinessLogic.Fattura.GetCodifica(fatturaVendita);
                var subject = "AVVISO DI SCADENZA FATTURA DI VENDITA N." + codificaFattura;
                return subject;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private string GetBodyAvvisoScadenzaFattura(FatturaAcquistoDto fatturaAcquisto, DateTime data, decimal totalePagamentiDare)
        {
            try
            {
                var pathRoot = UtilityWeb.GetRootPath(context);
                var pathTemplateAvvisoScadenzaFattura = pathRoot + @"\Resources\Templates\TemplateAvvisoScadenzaFatturaAcquisto.html";
                var content = System.IO.File.ReadAllText(pathTemplateAvvisoScadenzaFattura);
                var codificaFattura = BusinessLogic.Fattura.GetCodifica(fatturaAcquisto).ToLower();
                var codificaAzienda = BusinessLogic.Azienda.GetCodifica(fatturaAcquisto);
                var codificaFornitore = BusinessLogic.Fornitore.GetCodifica(fatturaAcquisto.Fornitore);
                var codificaPagamenti = GetCodificaPagamenti(fatturaAcquisto.Pagamentos);
                var scadenza = UtilityValidation.GetDataND(fatturaAcquisto.Scadenza);
                var totalePagamentiDato = UtilityValidation.GetEuro(BusinessLogic.Fattura.GetTotalePagamentiDato(fatturaAcquisto, data));
                var totaleFattura = UtilityValidation.GetEuro(fatturaAcquisto.Totale);
                content = content.Replace("$codificaAzienda$", codificaAzienda);
                content = content.Replace("$codificaFattura$", codificaFattura);
                content = content.Replace("$codificaFornitore$",codificaFornitore);
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

        private string GetBodyAvvisoScadenzaFattura(FatturaVenditaDto fatturaVendita, DateTime data, decimal totaleIncassiAvere)
        {
            try
            {
                var pathRoot = UtilityWeb.GetRootPath(context);
                var pathTemplateAvvisoScadenzaFattura = pathRoot + @"\Resources\Templates\TemplateAvvisoScadenzaFatturaVendita.html";
                var content = System.IO.File.ReadAllText(pathTemplateAvvisoScadenzaFattura);
                var codificaFattura = BusinessLogic.Fattura.GetCodifica(fatturaVendita).ToLower();
                var codificaAzienda = BusinessLogic.Azienda.GetCodifica(fatturaVendita);
                var codificaIncassi = GetCodificaIncassi(fatturaVendita.Incassos);
                var codificaCommittente = BusinessLogic.Committente.GetCodifica(fatturaVendita.Committente);
                var scadenza = UtilityValidation.GetDataND(fatturaVendita.Scadenza);
                var totaleIncassiAvuto = UtilityValidation.GetEuro(BusinessLogic.Fattura.GetTotaleIncassiAvuto(fatturaVendita, data));
                var totaleFattura = UtilityValidation.GetEuro(fatturaVendita.Totale);
                content = content.Replace("$codificaAzienda$", codificaAzienda);
                content = content.Replace("$codificaFattura$", codificaFattura);
                content = content.Replace("$codificaCommittente$", codificaCommittente);
                content = content.Replace("$codificaIncassi$", codificaIncassi);
                content = content.Replace("$scadenza$", scadenza);
                content = content.Replace("$totaleIncassiAvuto$", totaleIncassiAvuto);
                content = content.Replace("$totaleIncassiAvere$", UtilityValidation.GetEuro(totaleIncassiAvere));
                content = content.Replace("$totaleFattura$", totaleFattura);

                return content;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private string GetCodificaPagamenti(IList<PagamentoDto> pagamenti)
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

        private string GetCodificaIncassi(IList<IncassoDto> incassi)
        {
            try
            {
                string listaIncassi = null;
                if (incassi != null && incassi.Count >= 1)
                {
                    foreach (var incasso in incassi)
                    {
                        if (listaIncassi != null)
                            listaIncassi += "<br />";

                        listaIncassi += "N. " + BusinessLogic.Incasso.GetCodifica(incasso).ToLower() + " per un importo pari a " + UtilityValidation.GetEuro(incasso.Importo) +
                            " | Tipo transazione: " + incasso.TransazionePagamento;
                    }
                }
                if (listaIncassi == null)
                    listaIncassi = "Nessun incasso";

                return listaIncassi;
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
                AddLog("Controllo stato per fatture di acquisto...", "OK");
                CheckStatiFattureAcquisto();
                AddLog("Controllo stato per fatture di vendita...", "OK");
                CheckStatiFattureVendita();
                AddLog("Controllo stato per fornitori...", "OK");
                CheckStatiFornitori();
                AddLog("Controllo stato per committenti...", "OK");
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
                AddLog("KeepAlive avviato per sito " + url, "OK");
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
           
        }
       
    }
}
