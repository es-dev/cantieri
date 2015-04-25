using Library.Code;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.GUI.Dashboard;
using Web.GUI.Dashboard.Anagrafica;
using Web.GUI.Dashboard.Lavoro;
using Web.GUI.Dashboard.Configurazione;
using Web.GUI.AnagraficaArticolo;
using Web.GUI.AnagraficaCommittente;
using Web.GUI.AnagraficaFornitore;
using Web.GUI.Articolo;
using Web.GUI.Azienda;
using Web.GUI.CentroCosto;
using Web.GUI.Committente;
using Web.GUI.Commessa;
using Web.GUI.FatturaAcquisto;
using Web.GUI.FatturaVendita;
using Web.GUI.Fornitore;
using Web.GUI.Incasso;
using Web.GUI.Pagamento;
using Web.GUI.SAL;
using Web.GUI.Tools;
using Web.GUI.ReportJob;
using Web.GUI.Dashboard.Fatturazione;
using Web.GUI.Dashboard.Pagamento;
using Web.GUI.Agenda;
using Library.Template.Dashboard;

namespace Web.GUI.Dashboard
{
    public class DashboardViewModel: TemplateViewModel<DashboardDto, DashboardItem>
    {

        public DashboardViewModel() : base() 
        {

        }
       
        public override IQueryable<DashboardDto> QueryDashboards()
        {
            try
            {
                var dashboards = new List<DashboardDto>();
                var dashboardAgenda = new DashboardDto("Agenda e scadenzario", "AG-SCA", "Organizza il tuo lavoro in una comoda e pratica agenda digitale. Visualizza le scadenze imminenti e i pagamenti effettuati. Pianifica i tuoi lavori e gli stati di avanzamento lavori...", "Images.dashboard.agenda.png", "", typeof(SchedulerView), false);
                var dashboardLavori = new DashboardDto("Lavori e commesse", "LAV", "Gestisci i tuoi lavori e le commesse di lavorazione, inserisci i dati contrattuali, i fornitori e i committenti. Potrai gestire le scadenze ed effettuare un SAL per verificare lo stato di avanzamento lavori...", "Images.dashboard.lavori.png", "", typeof(DashboardLavoroView), false);
                var dashboardFatturazioni = new DashboardDto("Fatturazioni", "FA", "Inserisci le fatture di acquisto, di vendita e le note di credito per le tue commesse. Potrai verificare lo stato della fatturazione in dare/avere e analizzare in qualunque momento lo stato della contabilità generale...", "Images.dashboard.fatturazioni.png", "", typeof(DashboardFatturazioneView), false);
                var dashboardPagamenti = new DashboardDto("Pagamenti", "PA", "Gestisci i tuoi pagamenti e i tuoi incassi, organizza il flusso economico aziendale in ingresso e in uscita. Potrai effettuare un pagamento unificato specificando le fatture da pagare e indicare il fornitore beneficiario...", "Images.dashboard.pagamenti.png", "", typeof(DashboardPagamentoView), false);
                var dashboardReports = new DashboardDto("Reports", "RPT", "Crea un report di bilancio economico o effettua un controllo amministrativo. Potrai tenere sotto controllo le tue commesse, i pagamenti, gli insoluti e gli incassi dei tuoi lavori...", "Images.dashboard.reportjob.png", "", typeof(ReportJobView));
                var dashboardAnagrafiche = new DashboardDto("Anagrafiche", "ANAG", "Inserisci le anagrafiche dei committenti, dei fornitori e degli articoli. Con un archivio strutturato potrai gestire i tuoi dati ed accedere facilmente alle informazioni...", "Images.dashboard.anagrafiche.png", "", typeof(DashboardAnagraficaView), false);
                var dashboardConfigurazione = new DashboardDto("Configurazioni", "CONF", "Definisci le aziende che vuoi gestire nel sistema Enterprise Manager e configura i parametri principali come i Centri di Costo, le Impostazioni Generali...", "Images.dashboard.configurazioni.png", "", typeof(DashboardConfigurazioneView), false);
                var dashboardTools = new DashboardDto("Strumenti amministrativi", "TOOLS", "Controlla lo stato del tuo applicativo mediante una serie di strumenti per la verifica degli archivi, delle configurazioni e dell'integrità dei dati...", "Images.dashboard.tools.png", "", typeof(ToolsModel), false);

                dashboards.Add(dashboardAgenda);
                dashboards.Add(dashboardLavori);
                dashboards.Add(dashboardFatturazioni);
                dashboards.Add(dashboardPagamenti);
                dashboards.Add(dashboardReports);
                dashboards.Add(dashboardConfigurazione);
                dashboards.Add(dashboardAnagrafiche);
                dashboards.Add(dashboardTools);

                var query = dashboards.AsQueryable();
                return query;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
    }
}