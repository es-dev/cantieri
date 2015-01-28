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
                var dashboardConfigurazione = new Dashboard("Configurazioni", "CONF", "Definisci le aziende che vuoi gestire nel sistema Enterprise Manager e configura i parametri principali come i Centri di Costo, le impostazioni generali...", "Images.dashboard.configurazione.png", "", typeof(DashboardConfigurazioneView), false);
                var dashboardAnagrafiche = new Dashboard("Anagrafiche", "ANAG", "Inserisci le anagrafiche dei clienti, dei fornitori e degli articoli. Con un archivio strutturato potrai gestire i tuoi dati ed accedere facilmente alle informazioni...", "Images.dashboard.anagrafica.png", "", typeof(DashboardAnagraficheView), false);
                var dashboardLavori = new Dashboard("Lavori e commesse", "LAV", "Gestisci i tuoi lavori e le commesse di lavorazione, inserisci i dati contrattuali, i fornitori, i pagamenti. Gestisci le scadenze ed effettua i SAL per una verifica dello stato di avanzamento dei lavori...", "Images.dashboard.lavoro.png", "", typeof(DashboardLavoriView), false);

                var dashboardPagamento = new Dashboard("Pagamenti", "PAG", "Gestisci i pagamenti per le fattura inserite, controllando le scadenze, le passività e gli importi in dare/avere...", "Images.dashboard.pagamento.png", "", typeof(PagamentoView));
                var dashboardIncassi = new Dashboard("Incassi", "INC", "Gestisci gli incassi corrispondenti alle fatture di vendita per le commesse inserite nel sistema, visualizza i movimenti in dare/avere...", "Images.dashboard.liquidazione.png", "", typeof(LiquidazioneView));
                var dashboardSAL = new Dashboard("SAL", "SAL", "Crea uno Stato di Avanzamento Lavori (SAL) e controlla i bilanci delle tue commesse, evidenziando i movimenti in attivo/passivo...", "Images.dashboard.SAL.png", "", typeof(SALView));

                dashboards.Add(dashboardConfigurazione);
                dashboards.Add(dashboardAnagrafiche);
                dashboards.Add(dashboardLavori);
                dashboards.Add(dashboardPagamento);
                dashboards.Add(dashboardIncassi);
                dashboards.Add(dashboardSAL);

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