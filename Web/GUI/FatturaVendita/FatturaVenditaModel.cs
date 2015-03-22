using BusinessLogic;
using Library.Code;
using Library.Code.Enum;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using WcfService.Dto;
using Web.Code;

namespace Web.GUI.FatturaVendita
{
	public partial class FatturaVenditaModel : TemplateModel
	{
        private ClienteDto cliente = null;

        public FatturaVenditaModel()
		{
			InitializeComponent();
            try
            {
                InitCombo();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
		}

        public FatturaVenditaModel(ClienteDto cliente)
        {
            InitializeComponent();
            try
            {
                this.cliente = cliente;
                InitCombo();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void InitCombo()
        {
            try
            {
                editTipoPagamento.DisplayValues = UtilityEnum.GetDisplayValues<Tipi.TipoPagamento>();
                editScadenzaPagamento.DisplayValues = UtilityEnum.GetDisplayValues<Tipi.ScadenzaPagamento>();
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
                    var obj = (WcfService.Dto.FatturaVenditaDto)model;
                    var numero = UtilityValidation.GetStringND(obj.Numero);
                    var descrizione = UtilityValidation.GetStringND(obj.Descrizione);
                    infoSubtitle.Text = numero + " - " + descrizione;
                    infoSubtitleImage.Image = "Images.dashboard.fatturavendita.png";
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
                    var obj = (WcfService.Dto.FatturaVenditaDto)model;
                    editData.Value = obj.Data;
                    editDescrizione.Value = obj.Descrizione;
                    editImponibile.Value = obj.Imponibile;
                    editIVA.Value = obj.IVA;              
                    editNumero.Value = obj.Numero;
                    editTipoPagamento.Value = obj.TipoPagamento;
                    editScadenzaPagamento.Value = obj.ScadenzaPagamento;
                    editNote.Value = obj.Note;
                    editTotale.Value = obj.Totale;

                    var commessa = GetCommessa(obj);
                    editTotaleLiquidazioni.Value = BusinessLogic.Fattura.GetTotaleLiquidazioni(obj, commessa);
                    editStato.Value = BusinessLogic.Fattura.GetStatoDescrizione(obj,commessa); 

                    BindViewCliente(obj.Cliente);
                    BindViewLiquidazioni(obj.Liquidaziones);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewLiquidazioni(IList<LiquidazioneDto> liquidazioni)
        {
            try
            {
                btnLiquidazioni.TextButton = "Incassi (" + (liquidazioni != null ? liquidazioni.Count : 0) + ")";
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewCliente(ClienteDto cliente)
        {
            try
            {
                editCliente.Model = cliente;
                editCliente.Value = (cliente != null ? cliente.Codice + " - " + cliente.RagioneSociale : null);
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
                var imponibile = UtilityValidation.GetDecimal(editImponibile.Value);
                var iva = UtilityValidation.GetDecimal(editIVA.Value);
                var data = editData.Value;
                var _scadenzaPagamento = editScadenzaPagamento.Value;
                var today = DateTime.Today;

                if (data != null)
                {
                    var obj = (WcfService.Dto.FatturaVenditaDto)Model;
                    var totaleFattura = BusinessLogic.Fattura.GetTotale(imponibile, iva);
                    var totaleLiquidazioni = BusinessLogic.Fattura.GetTotaleLiquidazioni(obj, today);

                    var commessa = GetCommessa(obj);
                    var statoDescrizione = BusinessLogic.Fattura.GetStatoDescrizione(obj, commessa);

                    editStato.Value = statoDescrizione;
                    editTotale.Value = totaleFattura;
                    editTotaleLiquidazioni.Value = totaleLiquidazioni;
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
                    var obj = (WcfService.Dto.FatturaVenditaDto)model;
                    obj.Data = editData.Value;
                    obj.Descrizione = editDescrizione.Value;
                    obj.Imponibile = editImponibile.Value;
                    obj.IVA = editIVA.Value;
                    obj.Numero = editNumero.Value;
                    obj.TipoPagamento = editTipoPagamento.Value;
                    obj.ScadenzaPagamento = editScadenzaPagamento.Value;
                    obj.Note = editNote.Value;
                    obj.Totale = editTotale.Value;
                    obj.TotaleLiquidazioni = editTotaleLiquidazioni.Value;
                    obj.Stato = editStato.Value;
                    var cliente = (WcfService.Dto.ClienteDto)editCliente.Model;
                    if (cliente != null)
                        obj.ClienteId = cliente.Id;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private CommessaDto GetCommessa(FatturaVenditaDto fatturaVendita)
        {
            try
            {
                if (fatturaVendita != null)
                {
                    var clienteId = fatturaVendita.ClienteId;
                    var viewModelCliente = new Cliente.ClienteViewModel(this);
                    var cliente = viewModelCliente.Read(clienteId);
                    if (cliente != null)
                    {
                        var commessa = cliente.Commessa;
                        return commessa;
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private void editCliente_ComboClick()
        {
            try
            {
                var view = new Cliente.ClienteView();
                view.Title = "SELEZIONA UN COMMITTENTE";
                editCliente.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editCliente_ComboConfirm(object model)
        {
            try
            {
                var cliente = (WcfService.Dto.ClienteDto)model;
                if (cliente != null)
                    editCliente.Value = cliente.Codice + " - " + cliente.RagioneSociale;
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

        private void editImponibileIVA_Leave(object sender, EventArgs e)
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

        private void btnLiquidazioni_Click(object sender, EventArgs e)
        {
            try
            {
                var obj = (FatturaVenditaDto)Model;
                var space = new Liquidazione.LiquidazioneView(obj);
                space.Title = "INCASSI FATTURA N. " + obj.Numero;
                Workspace.AddSpace(space);

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }

        }

        private void FatturaVenditaModel_Load(object sender, EventArgs e)
        {
            try
            {
                var obj = (FatturaVenditaDto)Model;
                if (obj != null && obj.Id == 0)
                    SetNewValue();

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
                if (cliente != null)
                {
                    editCliente.Model = cliente;
                    editCliente.Value = cliente.Codice + " - " + cliente.RagioneSociale;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

	}
}
