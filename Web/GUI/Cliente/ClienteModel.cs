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
using WcfService.Dto;
using Web.Code;

namespace Web.GUI.Cliente
{
	public partial class ClienteModel : TemplateModel
	{
        private CommessaDto commessa = null;

        public ClienteModel()
		{
			InitializeComponent();
		}

        public ClienteModel(CommessaDto commessa)
        {
            InitializeComponent();
            try
            {
                this.commessa = commessa;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
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
                    editTotaleFattureVendita.Value = BusinessLogic.Cliente.GetTotaleFattureVendita(obj);
                    editStato.Value = BusinessLogic.Cliente.GetStatoDescrizione(obj);
                    editTotaleLiquidazioni.Value = BusinessLogic.Cliente.GetTotaleLiquidazioni(obj);
                    editCodiceCliente.Value = obj.Codice;

                    BindViewCommessa(obj.Commessa);
                    BindViewFattureVendita(obj.FatturaVenditas);
                    BindViewLiquidazioni(obj);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewLiquidazioni(ClienteDto cliente)
        {
            try
            {
                var viewModel = new Liquidazione.LiquidazioneViewModel(this);
                viewModel.Cliente = cliente;
                btnLiquidazioni.TextButton = "Incassi (" + viewModel.GetCount() + ")";
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewFattureVendita(IList<FatturaVenditaDto> fattureVendita)
        {
            try
            {
                btnFattureVendita.TextButton = "Fatture di vendita (" + (fattureVendita!=null?fattureVendita.Count:0) + ")";
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewCommessa(CommessaDto commessa)
        {
            try
            {
                editCommessa.Model = commessa;
                editCommessa.Value = (commessa!=null?commessa.Codice + " - " + commessa.Denominazione:null);
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
                        obj.CommessaId = commessa.Id;
                    
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewTotali()
        {
            try
            {
                var obj = (WcfService.Dto.ClienteDto)Model;
                var fatture = obj.FatturaVenditas;
                var today = DateTime.Today;
                if (fatture != null)
            {
                    var totaleFatture = BusinessLogic.Cliente.GetTotaleFattureVendita(obj, today);
                    var totaleLiquidazioni = BusinessLogic.Cliente.GetTotaleLiquidazioni(obj, today);
                    var statoDescrizione = BusinessLogic.Cliente.GetStatoDescrizione(obj);

                    editStato.Value = statoDescrizione;
                    editTotaleFattureVendita.Value = totaleFatture;
                    editTotaleLiquidazioni.Value = totaleLiquidazioni;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
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

        private void SetNewValue()
        {
            try
            {
                if (commessa != null)
                {
                    editCommessa.Model = commessa;
                    editCommessa.Value = commessa.Codice + " - " + commessa.Denominazione;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnFattureVendita_Click(object sender, EventArgs e)
        {
            try
            {
                var obj = (ClienteDto)Model;
                var space = new FatturaVendita.FatturaVenditaView(obj);
                space.Title = "FATTURE DI VENDITA - " + obj.RagioneSociale;
                Workspace.AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnLiquidazioni_Click(object sender, EventArgs e)
        {
            try
            {
                var obj = (ClienteDto)Model;
                var space = new Liquidazione.LiquidazioneView(obj);
                space.Title = "INCASSI - " + obj.RagioneSociale;
                Workspace.AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void ClienteModel_Load(object sender, EventArgs e)
        {
            try
            {
                var obj = (ClienteDto)Model;
                if (obj != null && obj.Id == 0)
                    SetNewValue();

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
                BindViewCommessa(commessa);
                BindViewTotali();
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
                    BindViewTotali();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

	}
}
