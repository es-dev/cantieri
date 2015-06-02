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

namespace Web.GUI.Dashboard.Fatturazione
{
    public class DashboardFatturazioneViewModel : TemplateViewModel<DashboardDto, DashboardFatturazioneItem>
    {

        public DashboardFatturazioneViewModel()
            : base() 
        {

        }

        public override IQueryable<DashboardDto> QueryDashboards()
        {
            try
            {
                var dashboards = new List<DashboardDto>();
                var dashboardFatturaAcquisto = new DashboardDto("Fatture di acquisto", "FA", "Inserisci le fatture di acquisto dei fornitori, specifica i prodotti acquistati e i costi relativi...", "Images.dashboard.fatturaacquisto.png", "", typeof(FatturaAcquistoView));
                var dashboardFatturaVendita = new DashboardDto("Fatture di vendita", "FV", "Inserisci le fatture di vendita per i committenti delle tue commesse, gestisci gli incassi e il conto economico...", "Images.dashboard.fatturavendita.png", "", typeof(FatturaVenditaView));
                var dashboardNotaCredito = new DashboardDto("Note di credito", "NC", "Gestisci le note di credito emesse dai fornitori, specifica gli importi da stornare e le fatture di acquisto annullate...", "Images.dashboard.notacredito.png", "", typeof(NotaCreditoView));
                var dashboardArticolo = new DashboardDto("Dettaglio acquisti", "ART", "Inserisci gli articoli di dettaglio per le fatture di acquisto, specifica le quantità, i costi e gli eventuali sconti relativi...", "Images.dashboard.articolo.png", "", typeof(ArticoloView));

                dashboards.Add(dashboardFatturaAcquisto);
                dashboards.Add(dashboardFatturaVendita);
                dashboards.Add(dashboardNotaCredito);
                dashboards.Add(dashboardArticolo);

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