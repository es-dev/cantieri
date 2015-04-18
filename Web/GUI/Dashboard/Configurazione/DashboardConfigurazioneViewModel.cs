using Library.Code;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.GUI.Dashboard;
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
using Web.GUI.Account;
using Library.Template.Dashboard;

namespace Web.GUI.Dashboard.Configurazione
{
    public class DashboardConfigurazioneViewModel : TemplateViewModel<DashboardDto, DashboardConfigurazioneItem>
    {
        
        public DashboardConfigurazioneViewModel(ISpace space) : base(space) 
        {

        }

       

        public override IQueryable<DashboardDto> QueryDashboards()
        {
            try
            {
                var dashboards = new List<DashboardDto>();
                var dashboardAzienda = new DashboardDto("Aziende", "AZ", "Definisci la tua azienda, inserisci il logo aziendale, l'intestazione e i dati commerciali...", "Images.dashboard.azienda.png", "", typeof(AziendaView));
                var dashboardCentroCosto = new DashboardDto("Centri di costo", "CC", "Definisci i centri di costo per organizzare al meglio il tuo lavoro e per raggruppare i flussi economici in voci di costo separate...", "Images.dashboard.centrocosto.png", "", typeof(CentroCostoView));
                var dashboardAccount = new DashboardDto("Accounts", "ACC", "Definisci gli accounts specificando la username, la password ed il ruolo ad esso associato...", "Images.dashboard.account.png", "", typeof(AccountView));
            
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