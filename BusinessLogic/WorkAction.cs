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

        private TimeSpan interval = new TimeSpan(0, 0, 30);
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


                var pathRoot = UtilityWeb.GetRootPath(context);
                //UtilityEmail.Send("pasqualeiaquinta@hotmail.com", "Test WFS - WorkActivity at " + DateTime.Now.ToString(), "Elaborazione flusso di lavoro avviato il " + DateTime.Now.ToString());
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
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
                foreach (var fatturaAcquisto in fattureAcquisto)
                {
                    fatturaAcquisto.Stato = BusinessLogic.Fattura.GetStatoDescrizione(fatturaAcquisto);
                    bool saved = wcf.UpdateFatturaAcquisto(fatturaAcquisto);
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
                foreach (var fatturaVendita in fattureVendita)
                {
                    fatturaVendita.Stato = BusinessLogic.Fattura.GetStatoDescrizione(fatturaVendita);
                    bool saved = wcf.UpdateFatturaVendita(fatturaVendita);
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
                foreach (var fornitore in fornitori)
                {
                    fornitore.Stato = BusinessLogic.Fornitore.GetStatoDescrizione(fornitore);
                    bool saved = wcf.UpdateFornitore(fornitore);
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
                foreach (var committente in committenti)
                {
                    committente.Stato = BusinessLogic.Committente.GetStatoDescrizione(committente);
                    bool saved = wcf.UpdateCommittente(committente);
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
