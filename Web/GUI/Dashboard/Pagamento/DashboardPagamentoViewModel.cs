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
using Web.GUI.Reso;
using Library.Template.Dashboard;

namespace Web.GUI.Dashboard.Pagamento
{
    public class DashboardPagamentoViewModel : TemplateViewModel<DashboardDto, DashboardPagamentoItem>
    {

        public DashboardPagamentoViewModel()
            : base() 
        {

        }

        public override IQueryable<DashboardDto> QueryDashboards()
        {
            try
            {
                var dashboards = new List<DashboardDto>();
                var dashboardPagamenti = new DashboardDto("Pagamenti", "PAG", "Gestisci i pagamenti delle fattura di acquisto inserite nel sistema, controlla le scadenze, le passività e gli importi...", "Images.dashboard.pagamento.png", "", typeof(PagamentoView));
                var dashboardIncassi = new DashboardDto("Incassi", "INC", "Gestisci gli incassi delle fatture di vendita per le commesse inserite nel sistema, visualizza i movimenti dei tuoi committenti...", "Images.dashboard.incasso.png", "", typeof(IncassoView));
                var dashboardResi = new DashboardDto("Resi", "RES", "Gestisci i resi specificando gli importi per i quali è stata eseguita una restituizione al fornitore. Puoi indicare la nota di credito di riferimento...", "Images.dashboard.reso.png", "", typeof(ResoView));
                var dashboardPagamentiUnificati = new DashboardDto("Pagamenti unificati", "PU", "Gestisci i pagamenti unificati per i fornitori inseriti. Potrai saldare in un'unica transazione una o più fatture di acquisto...", "Images.dashboard.pagamentounificato.png", "", typeof(PagamentoUnificatoView));
                var dashboardPagamentiUnificatiFatturaAcquisto = new DashboardDto("Dettaglio pagamenti unificati", "PU/FA", "Specifica le fatture di acquisto da associare al pagamento unificato. Il sistema valuterà in automatico il saldo da portare in pagamento...", "Images.dashboard.pagamentounificatofatturaacquisto.png", "", typeof(PagamentoUnificatoFatturaAcquistoView));
               
                dashboards.Add(dashboardPagamenti);
                dashboards.Add(dashboardIncassi);
                dashboards.Add(dashboardResi);
                dashboards.Add(dashboardPagamentiUnificati);
                dashboards.Add(dashboardPagamentiUnificatiFatturaAcquisto);

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