using Library.Code;
using Library.Interfaces;
using Library.Template.MVVM;
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

        public DashboardFatturazioneViewModel(ISpace space)
            : base(space) 
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

        private IList<DashboardDto> LoadDashboards(int skip, int take)
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

        private IQueryable<DashboardDto> QueryDashboards()
        {
            try
            {
                var dashboards = new List<DashboardDto>();

                var dashboardFatturaAcquisto = new DashboardDto("Fatture di acquisto", "FA", "Inserisci le fatture di acquisto per i fornitori, specifica i prodotti acquistati e i costi relativi...", "Images.dashboard.fatturaacquisto.png", "", typeof(FatturaAcquistoView));
                var dashboardFatturaVendita = new DashboardDto("Fatture di vendita", "FV", "Inserisci le fatture di vendita per i committenti delle commesse, gestisci gli incassi e il conto economico...", "Images.dashboard.fatturavendita.png", "", typeof(FatturaVenditaView));
                var dashboardNotaCredito = new DashboardDto("Note di credito", "NC", "Gestisci le note di credito per i fornitori, specificando gli importi da stornare e le fatture di acquisto...", "Images.dashboard.notacredito.png", "", typeof(NotaCreditoView));
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