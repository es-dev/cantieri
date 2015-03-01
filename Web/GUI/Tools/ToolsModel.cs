using Library.Code;
using Library.Code.Enum;
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

        public override void BindViewSubTitle(object model)
        {
            try
            {
                infoSubtitleImage.Image = "Images.dashboard.tools.png";
                infoSubtitle.Text = "TOOLS - STRUMENTI AMMINISTRATIVI";
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
                UtilityAsync.Execute(CheckArchivi);

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
                CheckClienti(comuni);
                CheckFornitori(comuni);
                CheckAnagraficheFornitori(comuni);
                CheckAnagraficheClienti(comuni);

                lblWarning.Text = (warning ? "Sono stati riscontrati errori nelle procedure di controllo, verificare i log ricercando la parola chiave ERROR per avere maggiori dettagli..." : "Tutti i controlli sono stati effettuati con successo...");
                lblWarning.ForeColor = (warning ? Color.Red : Color.Blue);
                lblWarning.Visible = true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void CheckAnagraficheClienti(IList<Countries.City> comuni)
        {
            try
            {
                AddLog("Avvio controllo anagrafiche clienti");
                var viewModel = new AnagraficaCliente.AnagraficaClienteViewModel(this);
                var anagraficheClienti= viewModel.ReadAnagraficheClienti();
                foreach (var anagraficaCliente in anagraficheClienti)
                {
                    var comune = (from q in comuni where q.Description == anagraficaCliente.Comune && q.County == anagraficaCliente.Provincia select q).FirstOrDefault();
                    if (comune != null)
                    {
                        anagraficaCliente.Comune = comune.Description;
                        anagraficaCliente.CodiceCatastale = comune.Code;
                        anagraficaCliente.Provincia = comune.County;
                        viewModel.Save(anagraficaCliente, false);
                        AddLog("Anagrafica committenti " + anagraficaCliente.RagioneSociale + " aggiornata con successo ... OK");
                    }
                    else
                    {
                        AddLog("Anagrafica committenti " + anagraficaCliente.RagioneSociale + " non aggiornata, comune " + anagraficaCliente.Comune + " non trovato... ERROR");
                        warning = true;
                    }
                }
                AddLog("Fine controllo anagrafiche clienti");
                
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
                var viewModel = new AnagraficaFornitore.AnagraficaFornitoreViewModel(this);
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
                var viewModel = new Fornitore.FornitoreViewModel(this);
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

        private void CheckClienti(IList<Countries.City> comuni)
        {
            try
            {
                AddLog("Avvio controllo clienti");
                var viewModel = new Cliente.ClienteViewModel(this);
                var clienti = viewModel.ReadClienti();
                foreach (var cliente in clienti)
                {
                    var comune = (from q in comuni where q.Description == cliente.Comune && q.County == cliente.Provincia select q).FirstOrDefault();
                    if (comune != null)
                    {
                        cliente.Comune = comune.Description;
                        cliente.CodiceCatastale = comune.Code;
                        cliente.Provincia = comune.County;
                        viewModel.Save(cliente, false);
                        AddLog("Cliente " + cliente.RagioneSociale + " aggiornato con successo ... OK");
                    }
                    else
                    {
                        AddLog("Cliente " + cliente.RagioneSociale + " non aggiornato, comune " + cliente.Comune + " non trovato... ERROR");
                        warning = true;
                    }
                }
                AddLog("Fine controllo clienti");
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
                var viewModel = new Commessa.CommessaViewModel(this);
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
                var viewModel = new Azienda.AziendaViewModel(this);
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
          
      

	}
}
