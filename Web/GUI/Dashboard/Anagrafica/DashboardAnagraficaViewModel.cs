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
using Library.Template.Dashboard;

namespace Web.GUI.Dashboard.Anagrafica
{
    public class DashboardAnagraficaViewModel: TemplateViewModel<DashboardDto, DashboardAnagraficaItem>
    {

        public DashboardAnagraficaViewModel(ISpace space)
            : base(space) 
        {

        }

        public override IQueryable<DashboardDto> QueryDashboards()
        {
            try
            {
                var dashboards = new List<DashboardDto>();
                var dashboardAnagraficaFornitore = new DashboardDto("Anagrafiche fornitori", "AF", "Archivia i fornitori verso i quali effettui l'approvviggionamento delle risorse per una rapida gestione degli archivi...", "Images.dashboard.anagraficafornitore.png", "", typeof(AnagraficaFornitoreView));
                var dashboardAnagraficaCommittente = new DashboardDto("Anagrafiche committenti", "AC", "Archivia i committenti verso i quali esegui le commesse dei lavori assegnati  per una rapida gestione degli storici...", "Images.dashboard.anagraficacommittente.png", "", typeof(AnagraficaCommittenteView));
                var dashboardAnagraficaArticolo = new DashboardDto("Anagrafiche articoli", "AA", "Archivia gli articoli e i prodotti acquistati per una gestione rapida delle movimentazioni di fatturazione e di magazzino...", "Images.dashboard.anagraficaarticolo.png", "", typeof(AnagraficaArticoloView));
               
                dashboards.Add(dashboardAnagraficaFornitore);
                dashboards.Add(dashboardAnagraficaCommittente);
                dashboards.Add(dashboardAnagraficaArticolo);

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