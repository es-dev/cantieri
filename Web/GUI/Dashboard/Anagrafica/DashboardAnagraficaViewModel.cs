using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using Web.GUI.AnagraficaArticolo;
using Web.GUI.AnagraficaCommittente;
using Web.GUI.AnagraficaFornitore;
using Library.Template.Dashboard;

namespace Web.GUI.Dashboard.Anagrafica
{
    public class DashboardAnagraficaViewModel: TemplateViewModel<DashboardDto, DashboardAnagraficaItem>
    {

        public DashboardAnagraficaViewModel()
            : base() 
        {

        }

        public override IQueryable<DashboardDto> QueryDashboards()
        {
            try
            {
                var dashboards = new List<DashboardDto>();
                var dashboardAnagraficaFornitore = new DashboardDto("Anagrafiche fornitori", "AF", "Organizza il tuo archivio dei fornitori, specifica le informazioni anagrafiche e di approvvigionamento delle risorse, per una gestione facile e strutturata...", "Images.dashboard.anagraficafornitore.png", "", typeof(AnagraficaFornitoreView));
                var dashboardAnagraficaCommittente = new DashboardDto("Anagrafiche committenti", "AC", "Gestisci l'archivio dei committenti, organizza le informazioni anagrafiche e di associazione alle commesse di lavorazione, per una gestione semplificata dei progetti...", "Images.dashboard.anagraficacommittente.png", "", typeof(AnagraficaCommittenteView));
                var dashboardAnagraficaArticolo = new DashboardDto("Anagrafiche articoli", "AA", "Archivia gli articoli e i prodotti acquistati, per una gestione rapida delle movimentazioni di fatturazione e di magazzino...", "Images.dashboard.anagraficaarticolo.png", "", typeof(AnagraficaArticoloView));
               
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