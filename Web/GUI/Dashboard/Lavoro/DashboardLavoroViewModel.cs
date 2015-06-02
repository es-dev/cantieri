using Library.Code;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.GUI.Dashboard;
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
using Web.GUI.PagamentoUnificato;
using Web.GUI.PagamentoUnificatoFatturaAcquisto;
using Web.GUI.NotaCredito;
using Library.Template.Dashboard;

namespace Web.GUI.Dashboard.Lavoro
{
    public class DashboardLavoroViewModel : TemplateViewModel<DashboardDto, DashboardLavoroItem>
    {

        public DashboardLavoroViewModel()
            : base() 
        {

        }

        public override IQueryable<DashboardDto> QueryDashboards()
        {
            try
            {
                var dashboards = new List<DashboardDto>();
                var dashboardCommessa = new DashboardDto("Commesse", "CM", "Visualizza le tue commesse, verifica il bilancio aziendale e il margine operativo mediante strumenti grafici e analisi statistiche...", "Images.dashboard.commessa.png", "", typeof(CommessaView));
                var dashboardFornitore = new DashboardDto("Fornitori", "FOR", "Specifica i fornitori per le tue commesse di lavorazione, inserisci i dati identificativi del fornitore e il dettaglio acquisti...", "Images.dashboard.fornitore.png", "", typeof(FornitoreView));
                var dashboardCommittente = new DashboardDto("Committenti", "CT", "Specifica i committenti per le commesse inserite nel sistema, definisci gli importi contrattuali e quelli attribuiti ai vari SAL...", "Images.dashboard.committente.png", "", typeof(CommittenteView));
                var dashboardSAL = new DashboardDto("SAL", "SAL", "Crea uno Stato di Avanzamento Lavori (SAL), controlla il bilancio contabile delle tue commesse, evidenzia i movimenti in attivo/passivo...", "Images.dashboard.SAL.png", "", typeof(SALView));

                dashboards.Add(dashboardCommessa);
                dashboards.Add(dashboardFornitore);
                dashboards.Add(dashboardCommittente);
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