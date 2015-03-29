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

namespace Web.GUI.Dashboard.Anagrafica
{
    public class DashboardAnagraficaViewModel: TemplateViewModel<DashboardAnagrafica, DashboardAnagraficaItem>
    {

        public DashboardAnagraficaViewModel(ISpace space)
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

        private IList<DashboardAnagrafica> LoadDashboards(int skip, int take)
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

        private IQueryable<DashboardAnagrafica> QueryDashboards()
        {
            try
            {
                var dashboards = new List<DashboardAnagrafica>();
                var dashboardAnagraficaFornitore = new DashboardAnagrafica("Anagrafiche fornitori", "AF", "Archivia i fornitori verso i quali effettui l'approvviggionamento delle risorse per una rapida gestione degli archivi...", "Images.dashboard.anagraficafornitore.png", "", typeof(AnagraficaFornitoreView));
                var dashboardAnagraficaCommittente = new DashboardAnagrafica("Anagrafiche committenti", "AC", "Archivia i committenti verso i quali esegui le commesse dei lavori assegnati  per una rapida gestione degli storici...", "Images.dashboard.anagraficacommittente.png", "", typeof(AnagraficaCommittenteView));
                var dashboardAnagraficaArticolo = new DashboardAnagrafica("Anagrafiche articoli", "AA", "Archivia gli articoli e i prodotti acquistati per una gestione rapida delle movimentazioni di fatturazione e di magazzino...", "Images.dashboard.anagraficaarticolo.png", "", typeof(AnagraficaArticoloView));
               
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