using Library.Code;
using Library.Interfaces;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Dashboard;
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

namespace Web.Dashboard
{
    public class DashboardViewModel: TemplateViewModel<Dashboard, DashboardItem>
    {

        public DashboardViewModel(ISpace space) : base(space) 
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
                var dashboardAzienda = new Dashboard("Aziende", "AZ", "Definisci la tua azienda, inserisci il logo aziendale, l'intestazione e i dati commerciali...", "Images.dashboard.azienda.png", "", typeof(AziendaView));
                var dashboardCommessa = new Dashboard("Commesse", "COM", "Visualizza le tue commesse, verifica i bilanci e il margine operativo mediante strumenti grafici e analisi statistiche...", "Images.dashboard.commessa.png", "", typeof(CommessaView));
                var dashboardFornitore = new Dashboard("Fornitori", "FOR", "Specifica i fornitori per le commesse inserite nel sistema, inserisci i dati identificativi e i dati di fornitura...", "Images.dashboard.fornitore.png", "", typeof(FornitoreView));
                var dashboardCentroCosto = new Dashboard("Centri di costo", "CC", "Definisci i centri di costo per organizzare al meglio il tuo lavoro e per raggruppare i flussi economici in voci di costo separate...", "Images.dashboard.centrocosto.png", "", typeof(CentroCostoView));
                var dashboardFatturaAcquisto = new Dashboard("Fatture di acquisto", "FA", "Inserisci le fatture di acquisto per i fornitori, specificando i prodotti acquistati e i costi relativi...", "Images.dashboard.fatturaacquisto.png", "", typeof(FatturaAcquistoView));
                var dashboardArticolo = new Dashboard("Articoli", "ART", "Inserisci gli articoli per le fattura di acquisto, specificandone le quantità, i costi e gli eventuali sconti relativi...", "Images.dashboard.articolo.png", "", typeof(ArticoloView));
                var dashboardPagamento = new Dashboard("Pagamenti", "PAG", "Gestisci i pagamenti per le fattura inserite, controllando le scadenze, le passività e gli importi in dare/avere...", "Images.dashboard.pagamento.png", "", typeof(PagamentoView));
                var dashboardCliente = new Dashboard("Clienti", "CL", "Specifica i clienti per le commesse inserite nel sistema, definisci gli importi attribuiti ai vari SAL...", "Images.dashboard.cliente.png", "", typeof(ClienteView));
                var dashboardFatturaVendita = new Dashboard("Fatture di vendita", "FV", "Inserisci le fatture di vendita per i clienti delle commesse, gestisci i pagamenti e il conto economico...", "Images.dashboard.fatturavendita.png", "", typeof(FatturaVenditaView));
                var dashboardLiquidazione = new Dashboard("Liquidazioni", "LIQ", "Gestisci le liquidazioni corrispondenti alle fatture di vendita per le commesse inserite nel sistema, visualizza i movimenti in dare/avere...", "Images.dashboard.liquidazione.png", "", typeof(LiquidazioneView));
                var dashboardSAL = new Dashboard("SAL", "SAL", "Crea uno Stato di Avanzamento Lavori (SAL) e controlla i bilanci delle tue commesse, evidenziando i movimenti in attivo/passivo...", "Images.dashboard.SAL.png", "", typeof(SALView));
                var dashboardAnagraficaFornitore = new Dashboard("Anagrafiche fornitori", "AF", "Archivia i fornitori verso i quali effettui l'approvviggionamento delle risorse per una rapida gestione degli archivi...", "Images.dashboard.anagraficafornitore.png", "", typeof(AnagraficaFornitoreView));
                var dashboardAnagraficaCliente = new Dashboard("Anagrafiche clienti", "AC", "Archivia i clienti verso i quali esegui le commesse dei lavori assegnati  per una rapida gestione degli storici...", "Images.dashboard.anagraficacliente.png", "", typeof(AnagraficaClienteView));
                var dashboardAnagraficaArticolo = new Dashboard("Anagrafiche articoli", "AA", "Archivia gli articoli e i prodotti acquistati per una gestione rapida delle movimentazioni di fatturazione e di magazzino...", "Images.dashboard.anagraficaarticolo.png", "", typeof(AnagraficaArticoloView));
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
                dashboards.Add(dashboardSAL);
                dashboards.Add(dashboardAnagraficaFornitore);
                dashboards.Add(dashboardAnagraficaCliente);
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