using Library.Code;
using Library.Controls;
using Library.Template.Controls;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using Web.Code;

namespace Web.GUI.Tools
{
	public partial class ToolsModel : TemplateModel
	{
        public ToolsModel()
		{
			InitializeComponent();
		}

        public override void BindViewTitle(object model)
        {
            try
            {
                infoSubtitleImage.Image = "Images.dashboard.tools.png";
                infoSubtitle.Text = "TOOLS - STRUMENTI AMMINISTRATIVI";
                infoTitle.Text = "STRUMENTI AMMINISTRATIVI";
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void Init()
        {
            try
            {
                base.Init();
                btnDelete.Visible = false;
                btnSave.Visible = false;
                btnUpdateCancel.Visible = false;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnCheckComuni_Click(object sender, EventArgs e)
        {
            try
            {
                btnCheckComuni.Enabled = false;
                btnCheckComuni.Text = "Attendere...";
                UtilityAsync.Execute(CheckArchivi, null, 250, "Images.progress.gif", btnCheckComuni);

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        bool warning = false;

        private void CheckArchivi()
        {
            try
            {
                var comuni = ReadComuni();
                warning = false;
                CheckAziende(comuni);
                CheckCommesse(comuni);
                CheckCommittenti(comuni);
                CheckFornitori(comuni);
                CheckAnagraficheFornitori(comuni);
                CheckAnagraficheCommittenti(comuni);

                lblWarning.Text = (warning ? "Sono stati riscontrati errori nelle procedure di controllo, verificare i log ricercando la parola chiave ERROR per avere maggiori dettagli..." : "Tutti i controlli sono stati effettuati con successo...");
                lblWarning.ForeColor = (warning ? Color.Red : Color.Blue);
                lblWarning.Visible = true;
                btnCheckComuni.Enabled = true;
                btnCheckComuni.Text = "Avvia";
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void CheckAnagraficheCommittenti(IList<Countries.City> comuni)
        {
            try
            {
                AddLog("Avvio controllo anagrafiche committenti");
                var viewModel = new AnagraficaCommittente.AnagraficaCommittenteViewModel();
                var anagraficheCommittenti= viewModel.ReadAnagraficheCommittenti();
                foreach (var anagraficaCommittente in anagraficheCommittenti)
                {
                    var comune = (from q in comuni where q.Description == anagraficaCommittente.Comune && q.County == anagraficaCommittente.Provincia select q).FirstOrDefault();
                    if (comune != null)
                    {
                        anagraficaCommittente.Comune = comune.Description;
                        anagraficaCommittente.CodiceCatastale = comune.Code;
                        anagraficaCommittente.Provincia = comune.County;
                        viewModel.Save(anagraficaCommittente, false);
                        AddLog("Anagrafica committenti " + anagraficaCommittente.RagioneSociale + " aggiornata con successo ... OK");
                    }
                    else
                    {
                        AddLog("Anagrafica committenti " + anagraficaCommittente.RagioneSociale + " non aggiornata, comune " + anagraficaCommittente.Comune + " non trovato... ERROR");
                        warning = true;
                    }
                }
                AddLog("Fine controllo anagrafiche committenti");
                
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }

        }

        private void CheckAnagraficheFornitori(IList<Countries.City> comuni)
        {
            try
            {
                AddLog("Avvio controllo anagrafiche fornitori");
                var viewModel = new AnagraficaFornitore.AnagraficaFornitoreViewModel();
                var anagraficheFornitori = viewModel.ReadAnagraficheFornitori();
                foreach (var anagraficaFornitore in anagraficheFornitori)
                {
                    var comune = (from q in comuni where q.Description == anagraficaFornitore.Comune && q.County == anagraficaFornitore.Provincia select q).FirstOrDefault();
                    if (comune != null)
                    {
                        anagraficaFornitore.Comune = comune.Description;
                        anagraficaFornitore.CodiceCatastale = comune.Code;
                        anagraficaFornitore.Provincia = comune.County;
                        viewModel.Save(anagraficaFornitore, false);
                        AddLog("Anagrafica fornitore " + anagraficaFornitore.RagioneSociale + " aggiornata con successo ... OK");
                    }
                    else
                    {
                        AddLog("Anagrafica fornitore " + anagraficaFornitore.RagioneSociale + " non aggiornata, comune " + anagraficaFornitore.Comune + " non trovato... ERROR");
                        warning = true;
                    }
                }
                AddLog("Fine controllo anagrafiche fornitori");
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }

        }

        private void CheckFornitori(IList<Countries.City> comuni)
        {
            try
            {
                AddLog("Avvio controllo fornitori");
                var viewModel = new Fornitore.FornitoreViewModel();
                var fornitori = viewModel.ReadFornitori();
                foreach (var fornitore in fornitori)
                {
                    var comune = (from q in comuni where q.Description == fornitore.Comune && q.County == fornitore.Provincia select q).FirstOrDefault();
                    if (comune != null)
                    {
                        fornitore.Comune = comune.Description;
                        fornitore.CodiceCatastale = comune.Code;
                        fornitore.Provincia = comune.County;
                        viewModel.Save(fornitore, false);
                        AddLog("Fornitore " + fornitore.RagioneSociale + " aggiornato con successo ... OK");
                    }
                    else
                    {
                        AddLog("Fornitore " + fornitore.RagioneSociale + " non aggiornato, comune " + fornitore.Comune + " non trovato... ERROR");
                        warning = true;
                    }
                }
                AddLog("Fine controllo fornitori");
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }

        }

        private void CheckCommittenti(IList<Countries.City> comuni)
        {
            try
            {
                AddLog("Avvio controllo committenti");
                var viewModel = new Committente.CommittenteViewModel();
                var committenti = viewModel.ReadCommittenti();
                foreach (var committente in committenti)
                {
                    var comune = (from q in comuni where q.Description == committente.Comune && q.County == committente.Provincia select q).FirstOrDefault();
                    if (comune != null)
                    {
                        committente.Comune = comune.Description;
                        committente.CodiceCatastale = comune.Code;
                        committente.Provincia = comune.County;
                        viewModel.Save(committente, false);
                        AddLog("Committente " + committente.RagioneSociale + " aggiornato con successo ... OK");
                    }
                    else
                    {
                        AddLog("Committente " + committente.RagioneSociale + " non aggiornato, comune " + committente.Comune + " non trovato... ERROR");
                        warning = true;
                    }
                }
                AddLog("Fine controllo committenti");
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }

        }

        private void CheckCommesse(IList<Countries.City> comuni)
        {
            try
            {
                AddLog("Avvio controllo commesse");
                var viewModel = new Commessa.CommessaViewModel();
                var commesse = viewModel.ReadCommesse();
                foreach (var commessa in commesse)
                {
                    var comune = (from q in comuni where q.Description == commessa.Comune && q.County == commessa.Provincia select q).FirstOrDefault();
                    if (comune != null)
                    {
                        commessa.Comune = comune.Description;
                        commessa.CodiceCatastale = comune.Code;
                        commessa.Provincia = comune.County;
                        viewModel.Save(commessa, false);
                        AddLog("Commessa " + commessa.Denominazione + " aggiornata con successo ... OK");
                    }
                    else
                    {
                        AddLog("Commessa " + commessa.Denominazione + " non aggiornata, comune " + commessa.Comune + " non trovato... ERROR");
                        warning = true;
                    }
                }

                AddLog("Fine controllo commesse");
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }

        }

        private void CheckAziende(IList<Countries.City> comuni)
        {
            try
            {
                AddLog("Avvio controllo aziende");
                var viewModel = new Azienda.AziendaViewModel();
                var aziende = viewModel.ReadAziende();
                foreach (var azienda in aziende)
                {
                    var comune = (from q in comuni where q.Description == azienda.Comune && q.County == azienda.Provincia select q).FirstOrDefault();
                    if (comune != null)
                    {
                        azienda.Comune = comune.Description;
                        azienda.CodiceCatastale = comune.Code;
                        azienda.Provincia = comune.County;
                        viewModel.Save(azienda, false);
                        AddLog("Azienda " + azienda.RagioneSociale + " aggiornata con successo ... OK");
                    }
                    else
                    {
                        AddLog("Azienda " + azienda.RagioneSociale + " non aggiornata, comune " + azienda.Comune + " non trovato... ERROR");
                        warning = true;
                    }
                }
                AddLog("Fine controllo aziende");
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            
        }
               

        private void AddLog(string message)
        {
            try
            {
                var item = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " | " + message;
                listLogger.Items.Insert(0,item);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private IList<Countries.City> ReadComuni()
        {
            try
            {
                var comuniProvince = new Countries(this);
                var comuni = comuniProvince.ReadCities();
                return comuni;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            try
            {
                listLogger.Items.Clear();
                lblWarning.Visible = false;
                warning = false;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnCheckStati_Click(object sender, EventArgs e)
        {
            try
            {
                btnCheckStati.Enabled = false;
                btnCheckStati.Text = "Attendere...";
                UtilityAsync.Execute(CheckStati,null, 250, "Images.progress.gif", btnCheckStati);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void CheckStati()
        {
            try
            {
                warning = false;
                CheckStatiFattureAcquisto();
                CheckStatiFattureVendita();
                CheckStatiFornitori();
                CheckStatiCommittenti();


                lblWarning.Text = (warning ? "Sono stati riscontrati incoerenze nella verifica degli stati, tuttavia tutti gli errori sono stati corretti. Verificare i log per avere maggiori dettagli..." : "Tutti i controlli sono stati effettuati con successo...");
                lblWarning.ForeColor = (warning ? Color.Red : Color.Blue);
                lblWarning.Visible = true;
                btnCheckStati.Enabled = true;
                btnCheckStati.Text = "Avvia";
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void CheckStatiFattureAcquisto()
        {
            try
            {
                AddLog("Avvio controllo stati fatture di acquisto");
                var viewModel = new FatturaAcquisto.FatturaAcquistoViewModel();
                var fattureAcquisto = viewModel.ReadFatture();
                var viewModelCommessa = new Commessa.CommessaViewModel();
                foreach (var fatturaAcquisto in fattureAcquisto)
                {
                    var commessa = viewModelCommessa.ReadCommessa(fatturaAcquisto);
                    fatturaAcquisto.Stato = BusinessLogic.Fattura.GetStatoDescrizione(fatturaAcquisto, commessa);
                    bool saved = viewModel.Save(fatturaAcquisto, false);
                    var codifica = BusinessLogic.Fattura.GetCodifica(fatturaAcquisto, false);
                    if (saved)
                        AddLog("Fattura di acquisto n." + codifica + " aggiornata con successo ... OK");
                    else
                        AddLog("Fattura di acquisto n." + codifica + " non aggiornata ... ERROR");
                }
                AddLog("Fine controllo stati fatture di acquisto");
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void CheckStatiFattureVendita()
        {
            try
            {
                AddLog("Avvio controllo stati fatture di vendita");
                var viewModel = new FatturaVendita.FatturaVenditaViewModel();
                var fattureVendita = viewModel.ReadFatture();
                var viewModelCommessa = new Commessa.CommessaViewModel();
                foreach (var fatturaVendita in fattureVendita)
                {
                    var commessa = viewModelCommessa.ReadCommessa(fatturaVendita);
                    fatturaVendita.Stato = BusinessLogic.Fattura.GetStatoDescrizione(fatturaVendita, commessa);
                    bool saved = viewModel.Save(fatturaVendita, false);
                    var codifica = BusinessLogic.Fattura.GetCodifica(fatturaVendita, false);
                    if (saved)
                        AddLog("Fattura di vendita n." + codifica + " aggiornata con successo ... OK");
                    else
                        AddLog("Fattura di vendita n." + codifica + " non aggiornata ... ERROR");
                }
                AddLog("Fine controllo stati fatture di vendita");
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }


        private void CheckStatiFornitori()
        {
            try
            {
                AddLog("Avvio controllo stati fornitori");
                var viewModel = new Fornitore.FornitoreViewModel();
                var fornitori = viewModel.ReadFornitori();
                foreach (var fornitore in fornitori)
                {
                    var commessa = fornitore.Commessa;
                    fornitore.Stato = BusinessLogic.Fornitore.GetStatoDescrizione(fornitore);
                    bool saved = viewModel.Save(fornitore, false);
                    var codifica = fornitore.RagioneSociale;
                    if (saved)
                        AddLog("Fornitore " + codifica + " aggiornato con successo ... OK");
                    else
                        AddLog("Fornitore " + codifica + " non aggiornato ... ERROR");
                }
                AddLog("Fine controllo stati fornitori");
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void CheckStatiCommittenti()
        {
            try
            {
                AddLog("Avvio controllo stati committenti");
                var viewModel = new Committente.CommittenteViewModel();
                var committenti = viewModel.ReadCommittenti();
                foreach (var committente in committenti)
                {
                    var commessa = committente.Commessa;
                    committente.Stato = BusinessLogic.Committente.GetStatoDescrizione(committente);
                    bool saved = viewModel.Save(committente, false);
                    var codifica = committente.RagioneSociale;
                    if (saved)
                        AddLog("Committente " + codifica + " aggiornato con successo ... OK");
                    else
                        AddLog("Committente " + codifica + " non aggiornato ... ERROR");
                }
                AddLog("Fine controllo stati committenti");
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

	}
}
