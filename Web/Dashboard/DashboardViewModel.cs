using Library.Code;
using Library.Interfaces;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Dashboard;
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
using Web.GUI.Statistica;

namespace Web.Dashboard
{
    public class DashboardViewModel: TemplateViewModel<Dashboard, DashboardItem>
    {

        public DashboardViewModel(ISpace space) : base(space) 
        {

        }

        public override void Load(int skip, int take)
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

        public override int GetCount()
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
                var dashboardAzienda = new Dashboard("Aziende", "CODE", "Description...", "Images.dashboard.png", "", typeof(AziendaView));
                var dashboardCommessa = new Dashboard("Commesse", "CODE", "Description...", "Images.dashboard.png", "", typeof(CommessaView));
                var dashboardFornitore = new Dashboard("Fornitori", "CODE", "Description...", "Images.dashboard.png", "", typeof(FornitoreView));
                var dashboardCentroCosto = new Dashboard("Centri di costo", "CODE", "Description...", "Images.dashboard.png", "", typeof(CentroCostoView));
                var dashboardFatturaAcquisto = new Dashboard("Fatture acquisto", "CODE", "Description...", "Images.dashboard.png", "", typeof(FatturaAcquistoView));
                var dashboardArticolo = new Dashboard("Articoli", "CODE", "Description...", "Images.dashboard.png", "", typeof(ArticoloView));
                var dashboardPagamento = new Dashboard("Pagamenti", "CODE", "Description...", "Images.dashboard.png", "", typeof(PagamentoView));
                var dashboardCliente = new Dashboard("Clienti", "CODE", "Description...", "Images.dashboard.png", "", typeof(ClienteView));
                var dashboardFatturaVendita = new Dashboard("Fatture vendita", "CODE", "Description...", "Images.dashboard.png", "", typeof(FatturaVenditaView));
                var dashboardLiquidazione = new Dashboard("Liquidazioni", "CODE", "Description...", "Images.dashboard.png", "", typeof(LiquidazioneView));
                var dashboardStatistica = new Dashboard("Statistiche", "CODE", "Description...", "Images.dashboard.png", "", typeof(StatisticaView));
                var dashboardSAL = new Dashboard("SAL", "CODE", "Description...", "Images.dashboard.png", "", typeof(SALView));
                var dashboardAnagraficaFornitore = new Dashboard("Anagrafiche fornitori", "CODE", "Description...", "Images.dashboard.png", "", typeof(AnagraficaFornitoreView));
                var dashboardAnagraficaCliente = new Dashboard("Anagrafiche clienti", "CODE", "Description...", "Images.dashboard.png", "", typeof(AnagraficaClienteView));
               dashboards.Add(dashboardAzienda);
                dashboards.Add(dashboardCommessa);
                dashboards.Add(dashboardFornitore);
                dashboards.Add(dashboardCentroCosto);
                dashboards.Add(dashboardFatturaAcquisto);
                dashboards.Add(dashboardArticolo);
                dashboards.Add(dashboardPagamento);
                dashboards.Add(dashboardCliente);
                dashboards.Add(dashboardFatturaVendita);
                dashboards.Add(dashboardLiquidazione);
                dashboards.Add(dashboardStatistica);
                dashboards.Add(dashboardSAL);
                dashboards.Add(dashboardAnagraficaFornitore);
                dashboards.Add(dashboardAnagraficaCliente);

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