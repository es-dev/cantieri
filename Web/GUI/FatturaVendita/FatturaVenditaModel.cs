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
        private CommittenteDto committente = null;

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

        public FatturaVenditaModel(CommittenteDto committente)
        {
            InitializeComponent();
            try
            {
                this.committente = committente;
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
                    var data = UtilityValidation.GetDataND(obj.Data);
                    var descrizione = UtilityValidation.GetStringND(obj.Descrizione);
                    infoSubtitle.Text = "N."+ numero + " del " + data + " - " + descrizione;
                    infoSubtitleImage.Image = "Images.dashboard.fatturavendita.png";
                    var committente = obj.Committente;
                    infoTitle.Text = (obj.Id!=0? "FATTURA DI VENDITA " + obj.Numero + " - " + committente.RagioneSociale:"NUOVA FATTURA DI VENDITA");
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
                    editTotaleIncassi.Value = BusinessLogic.Fattura.GetTotaleIncassi(obj, commessa);
                    editStato.Value = BusinessLogic.Fattura.GetStatoDescrizione(obj,commessa); 

                    BindViewCommittente(obj.Committente);
                    BindViewIncassi(obj.Incassos);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewIncassi(IList<IncassoDto> incassi)
        {
            try
            {
                btnIncassi.TextButton = "Incassi (" + (incassi != null ? incassi.Count : 0) + ")";
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewCommittente(CommittenteDto committente)
        {
            try
            {
                editCommittente.Model = committente;
                editCommittente.Value = (committente != null ? committente.Codice + " - " + committente.RagioneSociale : null);
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
                var obj = (WcfService.Dto.FatturaVenditaDto)Model;
                var imponibile = UtilityValidation.GetDecimal(editImponibile.Value);
                var iva = UtilityValidation.GetDecimal(editIVA.Value);
                var data = editData.Value;
                var today = DateTime.Today;

                var totaleFattura = BusinessLogic.Fattura.GetTotale(imponibile, iva);
                var totaleIncassi = BusinessLogic.Fattura.GetTotaleIncassi(obj, today);

                var commessa = GetCommessa(obj);
                var statoDescrizione = BusinessLogic.Fattura.GetStatoDescrizione(obj, commessa);

                editStato.Value = statoDescrizione;
                editTotale.Value = totaleFattura;
                editTotaleIncassi.Value = totaleIncassi;
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
                    obj.TotaleIncassi = editTotaleIncassi.Value;
                    obj.Stato = editStato.Value;
                    obj.Scadenza = BusinessLogic.Fattura.GetScadenza(obj);                    
                    var committente = (WcfService.Dto.CommittenteDto)editCommittente.Model;
                    if (committente != null)
                        obj.CommittenteId = committente.Id;
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
                    var committenteId = fatturaVendita.CommittenteId;
                    var viewModel = new Committente.CommittenteViewModel(this);
                    var committente = (CommittenteDto)viewModel.Read(committenteId);
                    if (committente != null)
                    {
                        var commessa = committente.Commessa;
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

        private void editCommittente_ComboClick()
        {
            try
            {
                var view = new Committente.CommittenteView();
                view.Title = "SELEZIONA UN COMMITTENTE";
                editCommittente.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editCommittente_ComboConfirm(object model)
        {
            try
            {
                var committente = (WcfService.Dto.CommittenteDto)model;
                if (committente != null)
                    editCommittente.Value = committente.Codice + " - " + committente.RagioneSociale;
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

        private void btnIncassi_Click(object sender, EventArgs e)
        {
            try
            {
                var obj = (FatturaVenditaDto)Model;
                var space = new Incasso.IncassoView(obj);
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
                if (committente != null)
                {
                    editCommittente.Model = committente;
                    editCommittente.Value = committente.Codice + " - " + committente.RagioneSociale;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

	}
}
