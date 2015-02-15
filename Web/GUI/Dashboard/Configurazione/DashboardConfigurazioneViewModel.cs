using Library.Code;
using Library.Interfaces;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.GUI.Dashboard;
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
using Web.GUI.Account;

namespace Web.GUI.Dashboard.Configurazione
{
    public class DashboardConfigurazioneViewModel : TemplateViewModel<DashboardConfigurazione, DashboardConfigurazioneItem>
    {
        
        public DashboardConfigurazioneViewModel(ISpace space) : base(space) 
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

        private IList<DashboardConfigurazione> LoadDashboards(int skip, int take)
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

        private IQueryable<DashboardConfigurazione> QueryDashboards()
        {
            try
            {
                var dashboards = new List<DashboardConfigurazione>();
                var dashboardAzienda = new DashboardConfigurazione("Aziende", "AZ", "Definisci la tua azienda, inserisci il logo aziendale, l'intestazione e i dati commerciali...", "Images.dashboard.azienda.png", "", typeof(AziendaView));
                var dashboardCentroCosto = new DashboardConfigurazione("Centri di costo", "CC", "Definisci i centri di costo per organizzare al meglio il tuo lavoro e per raggruppare i flussi economici in voci di costo separate...", "Images.dashboard.centrocosto.png", "", typeof(CentroCostoView));
                var dashboardAccount = new DashboardConfigurazione("Accounts", "ACC", "Definisci gli account specificando Username, Password ed il ruolo ad esso associato...", "Images.dashboard.centrocosto.png", "", typeof(AccountView));
            
                dashboards.Add(dashboardAzienda);
                dashboards.Add(dashboardCentroCosto);
                dashboards.Add(dashboardAccount);

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