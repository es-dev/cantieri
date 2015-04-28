using BusinessLogic;
using Library.Code;
using Library.Code.Enum;
using Library.Template.Controls;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using WcfService.Dto;
using Web.Code;

namespace Web.GUI.FatturaAcquisto
{
	public partial class FatturaAcquistoModel : TemplateModel
	{
        private FornitoreDto fornitore = null;

        public FatturaAcquistoModel()
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

        public FatturaAcquistoModel(FornitoreDto fornitore)
        {
            InitializeComponent();
            try
            {
                InitCombo();
                this.fornitore = fornitore;
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

        public override void BindViewTitle(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (FatturaAcquistoDto)model;
                    infoSubtitle.Text = BusinessLogic.Fattura.GetCodifica(obj);
                    infoSubtitleImage.Image = "Images.dashboard.fatturaacquisto.png";
                    var fornitore = obj.Fornitore;
                    infoTitle.Text = (obj.Id!=0?"FATTURA DI ACQUISTO N." + obj.Numero + " - " + fornitore.RagioneSociale: "NUOVA FATTURA DI ACQUISTO");
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
                    var obj = (FatturaAcquistoDto)model;
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
                    editTotalePagamenti.Value = BusinessLogic.Fattura.GetTotalePagamenti(obj, commessa);
                    editStato.Value = BusinessLogic.Fattura.GetStatoDescrizione(obj, commessa);
                    editSconto.Value = obj.Sconto;
                    
                    BindViewCentroCosto(obj.CentroCosto);
                    BindViewFornitore(obj.Fornitore);
                    BindViewPagamenti(obj.Pagamentos);
                    BindViewArticoli(obj.Articolos);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewPagamenti(IList<PagamentoDto> pagamenti)
        {
            try
            {
                btnPagamenti.TextButton = "Pagamenti (" + (pagamenti != null ? pagamenti.Count + ")" : null);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
        private void BindViewArticoli(IList<ArticoloDto> articoli)
        {
            try
            {
                btnArticoli.TextButton = "Articoli (" + (articoli != null ? articoli.Count + ")" : null);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
        private void BindViewFornitore(FornitoreDto fornitore)
        {
            try
            {
                editFornitore.Model = fornitore;
                editFornitore.Value = (fornitore!=null?fornitore.Codice + " - " + fornitore.RagioneSociale:null);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
           
        }

        private void BindViewCentroCosto(CentroCostoDto centroCosto)
        {
            try
            {
                editCentroCosto.Model = centroCosto;
                editCentroCosto.Value = (centroCosto!=null?centroCosto.Codice + " - " + centroCosto.Denominazione:null);
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
                var obj = (WcfService.Dto.FatturaAcquistoDto)Model;
                var today = DateTime.Today;
                var imponibile = UtilityValidation.GetDecimal(editImponibile.Value);
                var iva = UtilityValidation.GetDecimal(editIVA.Value);
                var totaleFattura = BusinessLogic.Fattura.GetTotale(imponibile, iva);
                var totalePagamenti = BusinessLogic.Fattura.GetTotalePagamenti(obj, today);
                var totaleResi = BusinessLogic.Fattura.GetTotaleResi(obj, today);

                var commessa = GetCommessa(obj);
                var statoDescrizione = BusinessLogic.Fattura.GetStatoDescrizione(obj, commessa); 

                editStato.Value = statoDescrizione;
                editTotale.Value = totaleFattura;
                editTotalePagamenti.Value = totalePagamenti;
                editTotaleResi.Value = totaleResi;
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
                    var obj = (FatturaAcquistoDto)model;
                    obj.Data = editData.Value;
                    obj.Descrizione = editDescrizione.Value;
                    obj.Imponibile = editImponibile.Value;
                    obj.IVA = editIVA.Value;
                    obj.Numero = editNumero.Value;
                    obj.TipoPagamento = editTipoPagamento.Value;
                    obj.ScadenzaPagamento = editScadenzaPagamento.Value;
                    obj.Totale = editTotale.Value;
                    obj.Note = editNote.Value;
                    obj.TotalePagamenti = editTotalePagamenti.Value;
                    obj.Stato = editStato.Value;
                    obj.Sconto = editSconto.Value;
                    obj.Scadenza = BusinessLogic.Fattura.GetScadenza(obj);                    
                    var centroCosto = (WcfService.Dto.CentroCostoDto)editCentroCosto.Model;
                    if (centroCosto != null)
                        obj.CentroCostoId = centroCosto.Id;
                    var fornitore = (WcfService.Dto.FornitoreDto)editFornitore.Model;
                    if (fornitore != null)
                        obj.FornitoreId = fornitore.Id;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }


        private CommessaDto GetCommessa(FatturaAcquistoDto fatturaAcquisto)
        {
            try
            {
                if (fatturaAcquisto != null)
                {
                    var fornitoreId = fatturaAcquisto.FornitoreId;
                    var viewModel = new Fornitore.FornitoreViewModel();
                    var fornitore = (FornitoreDto)viewModel.Read(fornitoreId);
                    if(fornitore!=null)
                    {
                        var commessa = fornitore.Commessa;
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

        private void editFornitore_ComboClick()
        {
            try
            {
                var view = new Fornitore.FornitoreView();
                view.Title = "SELEZIONA UN FORNITORE";
                editFornitore.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editFornitore_ComboConfirm(object model)
        {
            try
            {
                var fornitore = (WcfService.Dto.FornitoreDto)model;
                if (fornitore != null)
                    editFornitore.Value =  fornitore.Codice+ " - " +fornitore.RagioneSociale;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editCentroCosto_ComboClick()
        {
            try
            {
                var view = new CentroCosto.CentroCostoView();
                view.Title = "SELEZIONA UN CENTRO DI COSTO";
                editCentroCosto.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editCentroCosto_ComboConfirm(object model)
        {
            try
            {
                var centroCosto = (WcfService.Dto.CentroCostoDto)model;
                if (centroCosto != null)
                    editCentroCosto.Value = centroCosto.Codice + " - " + centroCosto.Denominazione;
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

        private void btnCalcoloTotali_Click(object sender, EventArgs e)
        {
            try
            {
                bool saved = Save();
                if (saved)
                {
                    BindViewTotali();
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
                btnPagamenti.Enabled = editing;
                btnResi.Enabled = editing;
                btnArticoli.Enabled = editing;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnPagamenti_Click(object sender, EventArgs e)
        {
            try
            {
                bool saved = Save();
                if (saved)
                {
                    var obj = (FatturaAcquistoDto)Model;
                    var space = new Pagamento.PagamentoView(obj);
                    space.Title = "PAGAMENTI " + BusinessLogic.Fattura.GetCodifica(obj);
                    Workspace.AddSpace(space);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void FatturaAcquistoModel_Load(object sender, EventArgs e)
        {
            try
            {
                var obj = (FatturaAcquistoDto)Model;
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
                if (fornitore != null)
                {
                    editFornitore.Model = fornitore;
                    editFornitore.Value = fornitore.Codice + " - " + fornitore.RagioneSociale;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnResi_Click(object sender, EventArgs e)
        {
            try
            {
                bool saved = Save();
                if (saved)
                {
                    var obj = (FatturaAcquistoDto)Model;
                    var space = new Reso.ResoView(obj);
                    space.Title = "RESI " + BusinessLogic.Fattura.GetCodifica(obj);
                    Workspace.AddSpace(space);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnArticoli_Click(object sender, EventArgs e)
        {
            try
            {
                bool saved = Save();
                if (saved)
                {
                    var obj = (FatturaAcquistoDto)Model;
                    var space = new Articolo.ArticoloView(obj);
                    space.Title = "ARTICOLO " + BusinessLogic.Fattura.GetCodifica(obj);
                    Workspace.AddSpace(space);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

	}
}
