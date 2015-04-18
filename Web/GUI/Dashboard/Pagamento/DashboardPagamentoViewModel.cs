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
using Web.GUI.Reso;
using Library.Template.Dashboard;

namespace Web.GUI.Dashboard.Pagamento
{
    public class DashboardPagamentoViewModel : TemplateViewModel<DashboardDto, DashboardPagamentoItem>
    {

        public DashboardPagamentoViewModel(ISpace space)
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

                var dashboardPagamenti = new DashboardDto("Pagamenti", "PAG", "Gestisci i pagamenti per le fattura inserite, controlla le scadenze, le passività e gli importi dati e in dare...", "Images.dashboard.pagamento.png", "", typeof(PagamentoView));
                var dashboardIncassi = new DashboardDto("Incassi", "INC", "Gestisci gli incassi corrispondenti alle fatture di vendita per le commesse inserite nel sistema, visualizza i movimenti in date e in dare...", "Images.dashboard.incasso.png", "", typeof(IncassoView));
                var dashboardResi = new DashboardDto("Resi", "RES", "Gestisci i resi specificando gli importi per i quali è stata eseguita una restituizione della merce. Puoi indicare la nota di credito di riferimento...", "Images.dashboard.reso.png", "", typeof(ResoView));
                var dashboardPagamentiUnificati = new DashboardDto("Pagamenti unificati", "PU", "Gestisci i pagamenti unificati per i fornitori inseriti. Potrai saldare in un unico pagamento una o più fatture insolute...", "Images.dashboard.pagamentounificato.png", "", typeof(PagamentoUnificatoView));
                var dashboardPagamentiUnificatiFatturaAcquisto = new DashboardDto("Dettaglio pagamenti unificati", "PU/FA", "Specifica le fatture di acquisto da associare la pagamento unificato. Il sistema valuterà in automatico il saldo da pagare...", "Images.dashboard.pagamentounificatofatturaacquisto.png", "", typeof(PagamentoUnificatoFatturaAcquistoView));
               

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