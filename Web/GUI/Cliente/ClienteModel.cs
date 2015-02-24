using BusinessLogic;
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
                    editComune.Value = new Countries.City(obj.Comune, obj.CodiceCatastale, obj.Provincia);
                    editTelefono.Value = obj.Telefono;
                    editFAX.Value = obj.Fax;
                    editMobile.Value = obj.Mobile;
                    editEmail.Value = obj.Email;
                    editLocalita.Value = obj.Localita;
                    editPartitaIVA.Value = obj.PartitaIva;
                    editNote.Value = obj.Note;
                    editTotaleFattureVendita.Value =GetTotaleFattureVendita(obj);
                    editStato.Value = GetStato(obj);
                    editTotaleLiquidazioni.Value = GetTotaleLiquidazioni(obj);
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

        private decimal GetTotaleLiquidazioni(WcfService.Dto.ClienteDto cliente)
        {
            try
            {
                decimal totaleLiquidazioni = 0;
                var today = DateTime.Today;
                var commessa = cliente.Commessa;
                var statoCommessa = commessa.Stato;
                if (statoCommessa == Tipi.StatoCommessa.Chiusa.ToString())
                    totaleLiquidazioni = UtilityValidation.GetDecimal(cliente.TotaleLiquidazioni);
                else
                    totaleLiquidazioni = BusinessLogic.Cliente.GetTotaleLiquidazioni(cliente, today);
                return totaleLiquidazioni;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        private string GetStato(WcfService.Dto.ClienteDto cliente)
        {
            try
            {
                var stato = "N/D";
                var commessa = cliente.Commessa;
                var statoCommessa = commessa.Stato;
                if (statoCommessa == Tipi.StatoCommessa.Chiusa.ToString())
                    stato = cliente.Stato;
                else
                {
                    var today = DateTime.Today;
                    var fatture = cliente.FatturaVenditas;
                    var totaleFatture = BusinessLogic.Cliente.GetTotaleFatture(cliente, today);
                    var totaleLiquidazioni = BusinessLogic.Cliente.GetTotaleLiquidazioni(cliente, today);
                    var fattureInsolute = BusinessLogic.Cliente.GetFattureInsolute(fatture);
                    var fattureNonLiquidate = BusinessLogic.Cliente.GetFattureNonLiquidate(fatture);
                    var statoCliente = BusinessLogic.Cliente.GetStato(cliente);
                    var _stato = GetStato(totaleFatture, totaleLiquidazioni, fattureInsolute, fattureNonLiquidate, statoCliente);
                    stato = _stato.ToString();
                }
                return stato;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private decimal GetTotaleFattureVendita(WcfService.Dto.ClienteDto cliente)
        {
            try
            {

                decimal totaleFattureVendita = 0;
                var today = DateTime.Today;
                var commessa = cliente.Commessa;
                var statoCommessa = commessa.Stato;
                if (statoCommessa == Tipi.StatoCommessa.Chiusa.ToString())
                    totaleFattureVendita = UtilityValidation.GetDecimal(cliente.TotaleFattureVendita);
                else
                    totaleFattureVendita = BusinessLogic.Cliente.GetTotaleFatture(cliente, today);
                return totaleFattureVendita;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
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
                    obj.Comune = editComune.Value.Description;
                    obj.CodiceCatastale = editComune.Value.Code;
                    obj.Provincia = editComune.Value.County;
                    obj.Localita = editLocalita.Value;
                    obj.Telefono = editTelefono.Value;
                    obj.Fax = editFAX.Value;
                    obj.Mobile = editMobile.Value;
                    obj.Email = editEmail.Value;
                    obj.PartitaIva = editPartitaIVA.Value;
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
                    CalcolaTotali();
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
                view.Title = "SELEZIONA UN COMMITTENTE";
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
                    editComune.Value = new Library.Controls.Countries.City(anagraficaCliente.Comune, anagraficaCliente.CodiceCatastale, anagraficaCliente.Provincia);
                    editEmail.Value = anagraficaCliente.Email;
                    editFAX.Value = anagraficaCliente.Fax;
                    editIndirizzo.Value = anagraficaCliente.Indirizzo;
                    editMobile.Value = anagraficaCliente.Mobile;
                    editPartitaIVA.Value = anagraficaCliente.PartitaIva;
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
                if (Editing)
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
                    var statoCliente = BusinessLogic.Cliente.GetStato(obj);
                    var stato = GetStato(totaleFatture, totaleLiquidazioni, fattureInsolute, fattureNonLiquidate, statoCliente);

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

        private StateDescriptionImage GetStato(decimal totaleFatture, decimal totaleLiquidazioni, IList<WcfService.Dto.FatturaVenditaDto> fattureInsolute, 
            IList<WcfService.Dto.FatturaVenditaDto> fattureNonLiquidate, Tipi.StatoCliente statoCliente)
        {
            try
            {
                var descrizione = "";
                var stato = TypeState.None;
                var existFattureInsolute = (fattureInsolute.Count >= 1);
                var existFattureNonLiquidate = (fattureNonLiquidate.Count >= 1);
                var listaFattureInsolute = BusinessLogic.Fattura.GetLista(fattureInsolute);
                var listaFattureNonLiquidate = BusinessLogic.Fattura.GetLista(fattureNonLiquidate);
                var _totaleLiquidazioni = UtilityValidation.GetEuro(totaleLiquidazioni);
                var _totaleFatture = UtilityValidation.GetEuro(totaleFatture);

                if (statoCliente == Tipi.StatoCliente.Insoluto) //condizione di non soluzione delle fatture, segalo le fatture insolute ed eventualmente quelle non pagate
                {
                    descrizione = "Il committente risulta insoluto. Il totale incassi pari a " + _totaleLiquidazioni + " è inferiore al totale delle fatture pari a " + _totaleFatture + ". Le fatture insolute sono " + listaFattureInsolute;
                    if (existFattureNonLiquidate)
                        descrizione += " Le fatture non incassate sono " + listaFattureNonLiquidate;
                    stato = TypeState.Critical;
                }
                else if (statoCliente == Tipi.StatoCliente.NonLiquidato) //condizione di non pagamento (pagamenti nulli o non completi, se non completi segnalo le fatture non pagate)
                {
                    descrizione = "Il committente risulta non incassato. Il totale incassi pari a " + _totaleLiquidazioni + " è inferiore al totale delle fatture pari a " + _totaleFatture;
                    if (existFattureNonLiquidate)
                        descrizione += " Le fatture non pagate sono " + listaFattureNonLiquidate;
                    stato = TypeState.Warning;
                }
                else if (statoCliente == Tipi.StatoCliente.Liquidato)
                {
                    descrizione = "Il committente risulta incassato. Tutte le fatture sono state liquidate";  //non so se ha senso indicargli anche insolute o no!!!!! per ora NO
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

        public override void SetEditing(bool editing, bool deleting)
        {
            try
            {
                base.SetEditing(editing, deleting);
                btnCalcoloTotali.Enabled = editing;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
        

	}
}
