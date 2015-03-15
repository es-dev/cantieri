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
using Web.GUI.PagamentoUnificato;
using Web.GUI.PagamentoUnificatoFatturaAcquisto;
using Web.GUI.NotaCredito;

namespace Web.GUI.Dashboard.Lavoro
{
    public class DashboardLavoroViewModel : TemplateViewModel<DashboardLavoro, DashboardLavoroItem>
    {

        public DashboardLavoroViewModel(ISpace space)
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

        private IList<DashboardLavoro> LoadDashboards(int skip, int take)
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

        private IQueryable<DashboardLavoro> QueryDashboards()
        {
            try
            {
                var dashboards = new List<DashboardLavoro>();

                var dashboardCommessa = new DashboardLavoro("Commesse", "CM", "Visualizza le tue commesse, verifica i bilanci e il margine operativo mediante l'utilizzo di strumenti grafici e di analisi statistiche...", "Images.dashboard.commessa.png", "", typeof(CommessaView));
                var dashboardFornitore = new DashboardLavoro("Fornitori", "FOR", "Specifica i fornitori per le commesse inserite nel sistema, inserisci i dati identificativi e i dati di fornitura...", "Images.dashboard.fornitore.png", "", typeof(FornitoreView));
                var dashboardCliente = new DashboardLavoro("Committenti", "CT", "Specifica i committenti per le commesse inserite nel sistema, definisci gli importi attribuiti ai vari SAL...", "Images.dashboard.cliente.png", "", typeof(ClienteView));
                var dashboardSAL = new DashboardLavoro("SAL", "SAL", "Crea uno Stato di Avanzamento Lavori (SAL), controlla i bilanci delle tue commesse, evidenzia i movimenti in attivo/passivo...", "Images.dashboard.SAL.png", "", typeof(SALView));
               

                dashboards.Add(dashboardCommessa);
                dashboards.Add(dashboardFornitore);
                dashboards.Add(dashboardCliente);
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