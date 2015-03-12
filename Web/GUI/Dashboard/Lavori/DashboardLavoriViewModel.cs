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

namespace Web.GUI.Dashboard.Lavori
{
    public class DashboardLavoriViewModel : TemplateViewModel<DashboardLavori, DashboardLavoriItem>
    {

        public DashboardLavoriViewModel(ISpace space)
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

        private IList<DashboardLavori> LoadDashboards(int skip, int take)
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

        private IQueryable<DashboardLavori> QueryDashboards()
        {
            try
            {
                var dashboards = new List<DashboardLavori>();

                var dashboardCommessa = new DashboardLavori("Commesse", "CM", "Visualizza le tue commesse, verifica i bilanci e il margine operativo mediante l'utilizzo di strumenti grafici e di analisi statistiche...", "Images.dashboard.commessa.png", "", typeof(CommessaView));
                var dashboardFornitore = new DashboardLavori("Fornitori", "FOR", "Specifica i fornitori per le commesse inserite nel sistema, inserisci i dati identificativi e i dati di fornitura...", "Images.dashboard.fornitore.png", "", typeof(FornitoreView));
                var dashboardFatturaAcquisto = new DashboardLavori("Fatture di acquisto", "FA", "Inserisci le fatture di acquisto per i fornitori, specifica i prodotti acquistati e i costi relativi...", "Images.dashboard.fatturaacquisto.png", "", typeof(FatturaAcquistoView));
                var dashboardArticolo = new DashboardLavori("Articoli", "ART", "Inserisci gli articoli per le fattura di acquisto, specifica le quantità, i costi e gli eventuali sconti relativi...", "Images.dashboard.articolo.png", "", typeof(ArticoloView));
                var dashboardPagamento = new DashboardLavori("Pagamenti", "PAG", "Gestisci i pagamenti per le fattura inserite, controlla le scadenze, le passività e gli importi dati e in dare...", "Images.dashboard.pagamento.png", "", typeof(PagamentoView));
                var dashboardNotaCredito = new DashboardLavori("Note di credito", "NC", "Gestisci le note di credito per i fornitori, specificando gli importi da stornare e le fatture di acquisto...", "Images.dashboard.notacredito.png", "", typeof(NotaCreditoView));
                var dashboardPagamentoUnificato = new DashboardLavori("Pagamenti unificati", "PU", "Gestisci i pagamenti unificati per i fornitori inseriti. Potrai saldare in un unico pagamento una o più fatture insolute...", "Images.dashboard.pagamentounificato.png", "", typeof(PagamentoUnificatoView));
                var dashboardPagamentoUnificatoFatturaAcquisto = new DashboardLavori("Pagamenti unificati - fatture", "PU/FA", "Specifica le fatture di acquisto da associare la pagamento unificato. Il sistema valuterà in automatico il saldo da pagare...", "Images.dashboard.pagamentounificatofatturaacquisto.png", "", typeof(PagamentoUnificatoFatturaAcquistoView));
                var dashboardCliente = new DashboardLavori("Committenti", "CT", "Specifica i committenti per le commesse inserite nel sistema, definisci gli importi attribuiti ai vari SAL...", "Images.dashboard.cliente.png", "", typeof(ClienteView));
                var dashboardFatturaVendita = new DashboardLavori("Fatture di vendita", "FV", "Inserisci le fatture di vendita per i committenti delle commesse, gestisci gli incassi e il conto economico...", "Images.dashboard.fatturavendita.png", "", typeof(FatturaVenditaView));
                var dashboardLiquidazioni = new DashboardLavori("Incassi", "INC", "Gestisci gli incassi corrispondenti alle fatture di vendita per le commesse inserite nel sistema, visualizza i movimenti in date e in dare...", "Images.dashboard.liquidazione.png", "", typeof(LiquidazioneView));
                var dashboardSAL = new DashboardLavori("SAL", "SAL", "Crea uno Stato di Avanzamento Lavori (SAL), controlla i bilanci delle tue commesse, evidenzia i movimenti in attivo/passivo...", "Images.dashboard.SAL.png", "", typeof(SALView));
               

                dashboards.Add(dashboardCommessa);
                dashboards.Add(dashboardFornitore);
                dashboards.Add(dashboardFatturaAcquisto);
                dashboards.Add(dashboardArticolo);
                dashboards.Add(dashboardPagamento);
                dashboards.Add(dashboardNotaCredito);
                dashboards.Add(dashboardPagamentoUnificato);
                dashboards.Add(dashboardPagamentoUnificatoFatturaAcquisto);
                dashboards.Add(dashboardCliente);
                dashboards.Add(dashboardFatturaVendita);
                dashboards.Add(dashboardLiquidazioni);
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