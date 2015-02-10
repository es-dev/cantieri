using Library.Code;
using Library.Code.Enum;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Web.Code;

namespace Web.GUI.Cliente
{
	public partial class ClienteModel : TemplateModel
	{
        public ClienteModel()
		{
			InitializeComponent();
		}

        public override void BindViewSubTitle(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.ClienteDto)model;
                    infoSubtitleImage.Image = "Images.dashboard.cliente.png";
                    infoSubtitle.Text = obj.Codice + " - " + obj.RagioneSociale;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void BindView(object model)  
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.ClienteDto)model;
                    editRagioneSociale.Value = obj.RagioneSociale;
                    editIndirizzo.Value = obj.Indirizzo;
                    editCAP.Value = obj.CAP;
                    editComune.Value = new Library.Controls.ComuniProvince.Comune(obj.Comune, obj.CodiceCatastale, obj.Provincia);
                    editTelefono.Value = obj.Telefono;
                    editFAX.Value = obj.Fax;
                    editMobile.Value = obj.Mobile;
                    editEmail.Value = obj.Email;
                    editPartitaIVA.Value = obj.PIva;
                    editTotaleFattureVendita.Value = obj.TotaleFattureVendita;
                    editStato.Value = obj.Stato;
                    editTotaleIncassi.Value = obj.TotaleLiquidazioni;
                    var commessa = obj.Commessa;
                    if (commessa != null)
                    {
                        editCommessa.Model = commessa;
                        editCommessa.Value = "(" + commessa.Codice + ") - " + commessa.Denominazione;
                    }
                    editCodiceCliente.Value = obj.Codice;

                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void BindModel(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.ClienteDto)model;
                    obj.RagioneSociale = editRagioneSociale.Value;
                    obj.Indirizzo = editIndirizzo.Value;
                    obj.CAP = editCAP.Value;
                    obj.Comune = editComune.Value.Denominazione;
                    obj.CodiceCatastale = editComune.Value.CodiceCatastale;
                    obj.Provincia = editComune.Value.Provincia;
                    obj.Telefono = editTelefono.Value;
                    obj.Fax = editFAX.Value;
                    obj.Mobile = editMobile.Value;
                    obj.Email = editEmail.Value;
                    obj.PIva = editPartitaIVA.Value;
                    obj.Codice = editCodiceCliente.Value;
                    obj.TotaleFattureVendita = editTotaleFattureVendita.Value;
                    obj.Stato = editStato.Value;
                    obj.TotaleLiquidazioni = editTotaleIncassi.Value;
                    var commessa = (WcfService.Dto.CommessaDto)editCommessa.Model;
                    if (commessa != null)
                        obj.Id = commessa.Id;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editCommessa_ComboClick()
        {
            try
            {
                var view = new Commessa.CommessaView();
                view.Title = "SELEZIONA UNA COMMESSA";
                editCommessa.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editCommessa_ComboConfirm(object model)
        {
            try
            {
                var commessa = (WcfService.Dto.CommessaDto)model;
                if (commessa != null)
                    editCommessa.Value = "(" + commessa.Codice + ") - " + commessa.Denominazione;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editCodiceCliente_ComboClick()
        {
            try
            {
                var view = new AnagraficaCliente.AnagraficaClienteView();
                view.Title = "SELEZIONA UN CLIENTE DALL'ANAGRAFICA CLIENTI";
                editCodiceCliente.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editCodiceCliente_ComboConfirm(object model)
        {
            try
            {
                var anagraficaCliente = (WcfService.Dto.AnagraficaClienteDto)model;
                if (anagraficaCliente != null)
                {
                    editCodiceCliente.Value = anagraficaCliente.Codice;
                    editCAP.Value = anagraficaCliente.CAP;
                    editComune.Value = new Library.Controls.ComuniProvince.Comune(anagraficaCliente.Comune, anagraficaCliente.Provincia);
                    editEmail.Value = anagraficaCliente.Email;
                    editFAX.Value = anagraficaCliente.Fax;
                    editIndirizzo.Value = anagraficaCliente.Indirizzo;
                    editMobile.Value = anagraficaCliente.Mobile;
                    editPartitaIVA.Value = anagraficaCliente.PIva;
                    editRagioneSociale.Value = anagraficaCliente.RagioneSociale;
                    editTelefono.Value = anagraficaCliente.Telefono;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnCalcoloTotali_Click(object sender, EventArgs e)
        {
            try
            {
                CalcolaTotali();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void CalcolaTotali()
        {
            try
            {
                //prelievo dati da GUI -->non prelevo nnt da GUI
                //prelievo dati DB
                var obj = (WcfService.Dto.ClienteDto)Model;
                var fatture = obj.FatturaVenditas;
                var today = DateTime.Today;
                if (fatture != null)
                {
                    var totaleFatture = BusinessLogic.Cliente.GetTotaleFatture(obj, today);
                    var totaleIncassi = BusinessLogic.Cliente.GetTotaleIncassi(obj, today);
                    var fattureInsolute = BusinessLogic.Cliente.GetFattureInsolute(fatture);
                    var fattureNonPagate = BusinessLogic.Cliente.GetFattureNonPagate(fatture);

                    //valutazione dell'andamento del lavoro
                    var statoDescrizione = GetStatoDescrizione(totaleFatture, totaleIncassi, fattureInsolute, fattureNonPagate);

                    ////binding dati in GUI
                    editStato.Value = statoDescrizione.ToString();
                    editTotaleFattureVendita.Value = totaleFatture;
                    editTotaleIncassi.Value = totaleIncassi;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private StatoDescrizione GetStatoDescrizione(decimal totaleFatture, decimal totaleIncassi, IList<WcfService.Dto.FatturaVenditaDto> fattureInsolute, IList<WcfService.Dto.FatturaVenditaDto> fattureNonPagate)
        {
            try
            {
                var descrizione = "";
                var stato = TypeStato.None;
                var existFattureInsolute = (fattureInsolute.Count >= 1);
                var existFattureNonPagate = (fattureNonPagate.Count >= 1);
                var listaFattureInsolute = BusinessLogic.Fattura.GetLista(fattureInsolute);
                var listaFattureNonPagate = BusinessLogic.Fattura.GetLista(fattureNonPagate);

                if (totaleIncassi < totaleFatture)
                {
                    if (existFattureInsolute) //condizione di non soluzione delle fatture, segalo le fatture insolute ed eventualmente quelle non pagate
                    {
                        descrizione = "Il fornitore risulta insoluto. Il totale incassi pari a " + totaleIncassi.ToString("0.00€") + " è inferiore al totale delle fatture pari a " + totaleFatture.ToString("0.00€") + ". Le fatture insolute sono " + listaFattureInsolute;
                        if (existFattureNonPagate)
                            descrizione += " Le fatture non pagate sono " + listaFattureNonPagate;
                        stato = TypeStato.Critical;
                    }
                    else //condizione di non pagamento (pagamenti nulli o non completi, se non completi segnalo le fatture non pagate)
                    {
                        descrizione = "Il fornitore risulta non pagato. Il totale incassi pari a " + totaleIncassi.ToString("0.00€") + " è inferiore al totale delle fatture pari a " + totaleFatture.ToString("0.00€");
                        if (existFattureNonPagate)
                            descrizione += " Le fatture non pagate sono " + listaFattureNonPagate;
                        stato = TypeStato.Warning;
                    }
                }
                else if (totaleIncassi >= totaleFatture)
                {
                    descrizione = "Il fornitore risulta pagato. Tutte le fatture sono state saldate";  //non so se ha senso indicargli anche insolute o no!!!!! per ora NO
                    stato = TypeStato.Normal;
                }
                var statoDescrizione = new StatoDescrizione(stato, descrizione);
                return statoDescrizione;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        

	}
}
