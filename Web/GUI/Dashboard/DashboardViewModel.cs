using Library.Code;
using Library.Interfaces;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.GUI.Dashboard;
using Web.GUI.Dashboard.Anagrafiche;
using Web.GUI.Dashboard.Lavori;
using Web.GUI.Dashboard.Configurazione;
using Web.GUI.AnagraficaArticolo;
using Web.GUI.AnagraficaCliente;
using Web.GUI.AnagraficaFornitore;
using Web.GUI.Articolo;
using Web.GUI.Azienda;
using Web.GUI.CentroCosto;
using Web.GUI.Cliente;
using Web.GUI.Commessa;
using Web.GUI.FatturaAcquisto;
using Web.GUI.FatturaVendita;
using Web.GUI.Fornitore;
using Web.GUI.Liquidazione;
using Web.GUI.Pagamento;
using Web.GUI.SAL;
using Web.GUI.Tools;
using Web.GUI.ReportJob;

namespace Web.GUI.Dashboard
{
    public class DashboardViewModel: TemplateViewModel<Dashboard, DashboardItem>
    {

        public DashboardViewModel(ISpace space) : base(space) 
        {

        }

        public override void Load(int skip, int take, string search=null)
        {
            try
            {
                var objDtos = LoadDashboards(skip, take);
                Load(objDtos);
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
                var query = QueryDashboards();
                int count = query.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
        
        private IList<Dashboard> LoadDashboards(int skip, int take)
        {
            try
            {
                var query = QueryDashboards();
                var objDtos = query.Skip(skip).Take(take).ToList();
                return objDtos;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<Dashboard> QueryDashboards()
        {
            try
            {
                var dashboards = new List<Dashboard>();
                var dashboardLavori = new Dashboard("Lavori e commesse", "LAV", "Gestisci i tuoi lavori e le commesse di lavorazione, inserisci i dati contrattuali, i fornitori, i pagamenti. Gestisci le scadenze ed effettua i SAL per una verifica dello stato di avanzamento dei lavori...", "Images.dashboard.lavoro.png", "", typeof(DashboardLavoriView), false);
                var dashboardAnagrafiche = new Dashboard("Anagrafiche", "ANAG", "Inserisci le anagrafiche dei clienti, dei fornitori e degli articoli. Con un archivio strutturato potrai gestire i tuoi dati ed accedere facilmente alle informazioni...", "Images.dashboard.anagrafica.png", "", typeof(DashboardAnagraficheView), false);
                var dashboardConfigurazione = new Dashboard("Configurazioni", "CONF", "Definisci le aziende che vuoi gestire nel sistema Enterprise Manager e configura i parametri principali come i Centri di Costo, le impostazioni generali...", "Images.dashboard.configurazione.png", "", typeof(DashboardConfigurazioneView), false);
                var dashboardReports = new Dashboard("Report lavori", "RPT", "Crea un report di bilancio economico o effettua un controllo amministrativo per tenere sotto controllo le tue commesse, i tuoi committenti e i tuoi lavori...", "Images.dashboard.reportjob.png", "", typeof(ReportJobView), false);
                var dashboardTools = new Dashboard("Strumenti amministrativi", "TOOLS", "Controlla lo stato del tuo applicativo mediante una serie di strumenti per la verifica degli archivi, delle configurazioni e dell'integrità dei dati...", "Images.dashboard.tools.png", "", typeof(ToolsModel), false);

                dashboards.Add(dashboardLavori);
                dashboards.Add(dashboardConfigurazione);
                dashboards.Add(dashboardAnagrafiche);
                dashboards.Add(dashboardReports);
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