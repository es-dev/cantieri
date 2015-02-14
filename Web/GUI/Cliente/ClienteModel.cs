using Library.Code;
using Library.Code.Enum;
using Library.Controls;
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
                    var codice = UtilityValidation.GetStringND(obj.Codice);
                    var ragioneSociale = UtilityValidation.GetStringND(obj.RagioneSociale);
                    infoSubtitle.Text = codice + " - " + ragioneSociale;
                    infoSubtitleImage.Image = "Images.dashboard.cliente.png";
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
                    editComune.Value = new ComuniProvince.Comune(obj.Comune, obj.CodiceCatastale, obj.Provincia);
                    editTelefono.Value = obj.Telefono;
                    editFAX.Value = obj.Fax;
                    editMobile.Value = obj.Mobile;
                    editEmail.Value = obj.Email;
                    editLocalita.Value = obj.Localita;
                    editPartitaIVA.Value = obj.PIva;
                    editNote.Value = obj.Note;
                    editTotaleFattureVendita.Value = obj.TotaleFattureVendita;
                    editStato.Value = obj.Stato;
                    editTotaleLiquidazioni.Value = obj.TotaleLiquidazioni;
                    var commessa = obj.Commessa;
                    if (commessa != null)
                    {
                        editCommessa.Model = commessa;
                        editCommessa.Value =  commessa.Codice + " - " + commessa.Denominazione;
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
                    obj.Localita = editLocalita.Value;
                    obj.Telefono = editTelefono.Value;
                    obj.Fax = editFAX.Value;
                    obj.Mobile = editMobile.Value;
                    obj.Email = editEmail.Value;
                    obj.PIva = editPartitaIVA.Value;
                    obj.Note = editNote.Value;
                    obj.Codice = editCodiceCliente.Value;
                    obj.TotaleFattureVendita = editTotaleFattureVendita.Value;
                    obj.Stato = editStato.Value;
                    obj.TotaleLiquidazioni = editTotaleLiquidazioni.Value;
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
                    editCommessa.Value = commessa.Codice + " - " + commessa.Denominazione;
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
                var obj = (WcfService.Dto.ClienteDto)Model;
                var fatture = obj.FatturaVenditas;
                var today = DateTime.Today;
                if (fatture != null)
                {
                    var totaleFatture = BusinessLogic.Cliente.GetTotaleFatture(obj, today);
                    var totaleLiquidazioni = BusinessLogic.Cliente.GetTotaleLiquidazioni(obj, today);
                    var fattureInsolute = BusinessLogic.Cliente.GetFattureInsolute(fatture);
                    var fattureNonLiquidate = BusinessLogic.Cliente.GetFattureNonLiquidate(fatture);
                    var stato = GetStato(totaleFatture, totaleLiquidazioni, fattureInsolute, fattureNonLiquidate);
                    
                    editStato.Value = stato.ToString();
                    editTotaleFattureVendita.Value = totaleFatture;
                    editTotaleLiquidazioni.Value = totaleLiquidazioni;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private StateDescriptionImage GetStato(decimal totaleFatture, decimal totaleLiquidazioni, IList<WcfService.Dto.FatturaVenditaDto> fattureInsolute, IList<WcfService.Dto.FatturaVenditaDto> fattureNonLiquidate)
        {
            try
            {
                var descrizione = "";
                var stato = TypeState.None;
                var existFattureInsolute = (fattureInsolute.Count >= 1);
                var existFattureNonLiquidate = (fattureNonLiquidate.Count >= 1);
                var listaFattureInsolute = BusinessLogic.Fattura.GetLista(fattureInsolute);
                var listaFattureNonLiquidate = BusinessLogic.Fattura.GetLista(fattureNonLiquidate);

                if (totaleLiquidazioni < totaleFatture)
                {
                    if (existFattureInsolute) //condizione di non soluzione delle fatture, segalo le fatture insolute ed eventualmente quelle non pagate
                    {
                        descrizione = "Il cliente risulta insoluto. Il totale incassi pari a " + totaleLiquidazioni.ToString("0.00€") + " è inferiore al totale delle fatture pari a " + totaleFatture.ToString("0.00€") + ". Le fatture insolute sono " + listaFattureInsolute;
                        if (existFattureNonLiquidate)
                            descrizione += " Le fatture non liquidate sono " + listaFattureNonLiquidate;
                        stato = TypeState.Critical;
                    }
                    else //condizione di non pagamento (pagamenti nulli o non completi, se non completi segnalo le fatture non pagate)
                    {
                        descrizione = "Il cliente risulta non liquidato. Il totale incassi pari a " + totaleLiquidazioni.ToString("0.00€") + " è inferiore al totale delle fatture pari a " + totaleFatture.ToString("0.00€");
                        if (existFattureNonLiquidate)
                            descrizione += " Le fatture non pagate sono " + listaFattureNonLiquidate;
                        stato = TypeState.Warning;
                    }
                }
                else if (totaleLiquidazioni >= totaleFatture)
                {
                    descrizione = "Il cliente risulta liquidato. Tutte le fatture sono state saldate";  //non so se ha senso indicargli anche insolute o no!!!!! per ora NO
                    stato = TypeState.Normal;
                }
                var _stato = new StateDescriptionImage(stato, descrizione);
                return _stato;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        

	}
}
