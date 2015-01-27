﻿using Library.Code;
using Library.Interfaces;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Dashboard;
using Web.DashboardConfigurazione;
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

namespace Web.DashboardLavori
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

                var dashboardCommessa = new DashboardLavori("Commesse", "COM", "Visualizza le tue commesse, verifica i bilanci e il margine operativo mediante strumenti grafici e analisi statistiche...", "Images.dashboard.commessa.png", "", typeof(CommessaView));
                var dashboardFornitore = new DashboardLavori("Fornitori", "FOR", "Specifica i fornitori per le commesse inserite nel sistema, inserisci i dati identificativi e i dati di fornitura...", "Images.dashboard.fornitore.png", "", typeof(FornitoreView));
                var dashboardFatturaAcquisto = new DashboardLavori("Fatture di acquisto", "FA", "Inserisci le fatture di acquisto per i fornitori, specificando i prodotti acquistati e i costi relativi...", "Images.dashboard.fatturaacquisto.png", "", typeof(FatturaAcquistoView));
                var dashboardArticolo = new DashboardLavori("Articoli", "ART", "Inserisci gli articoli per le fattura di acquisto, specificandone le quantità, i costi e gli eventuali sconti relativi...", "Images.dashboard.articolo.png", "", typeof(ArticoloView));
                var dashboardPagamento = new DashboardLavori("Pagamenti", "PAG", "Gestisci i pagamenti per le fattura inserite, controllando le scadenze, le passività e gli importi in dare/avere...", "Images.dashboard.pagamento.png", "", typeof(PagamentoView));
                var dashboardCliente = new DashboardLavori("Clienti", "CL", "Specifica i clienti per le commesse inserite nel sistema, definisci gli importi attribuiti ai vari SAL...", "Images.dashboard.cliente.png", "", typeof(ClienteView));
                var dashboardFatturaVendita = new DashboardLavori("Fatture di vendita", "FV", "Inserisci le fatture di vendita per i clienti delle commesse, gestisci i pagamenti e il conto economico...", "Images.dashboard.fatturavendita.png", "", typeof(FatturaVenditaView));
                var dashboardIncassi = new DashboardLavori("Incassi", "INC", "Gestisci gli incassi corrispondenti alle fatture di vendita per le commesse inserite nel sistema, visualizza i movimenti in dare/avere...", "Images.dashboard.liquidazione.png", "", typeof(LiquidazioneView));
                var dashboardSAL = new DashboardLavori("SAL", "SAL", "Crea uno Stato di Avanzamento Lavori (SAL) e controlla i bilanci delle tue commesse, evidenziando i movimenti in attivo/passivo...", "Images.dashboard.SAL.png", "", typeof(SALView));
               

                dashboards.Add(dashboardCommessa);
                dashboards.Add(dashboardFornitore);
                dashboards.Add(dashboardFatturaAcquisto);
                dashboards.Add(dashboardArticolo);
                dashboards.Add(dashboardPagamento);
                dashboards.Add(dashboardCliente);
                dashboards.Add(dashboardFatturaVendita);
                dashboards.Add(dashboardIncassi);
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