using BusinessLogic;
using Library.Code;
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
                    infoTitle.Text = (obj.Id!=0?"FATTURA ACQUISTO " + BusinessLogic.Fattura.GetCodifica(obj) : "NUOVA FATTURA ACQUISTO")+ " | FORNITORE " + 
                        BusinessLogic.Fornitore.GetCodifica(obj.Fornitore);
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
                    editTotale.Value = obj.Totale;
                    editSconto.Value = obj.Sconto;
                    editNumero.Value = obj.Numero;
                    editTipoPagamento.Value = obj.TipoPagamento;
                    editScadenzaPagamento.Value = obj.ScadenzaPagamento;
                    editNote.Value = obj.Note;
                    
                    BindViewCentroCosto(obj.CentroCosto);
                    BindViewFornitore(obj.Fornitore);
                    BindViewPagamenti(obj.Pagamentos);
                    BindViewResi(obj.Resos);
                    BindViewArticoli(obj.Articolos);
                    BindViewTotali(obj);
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
                btnPagamenti.TextButton = "Pagamenti (" + (pagamenti != null ? pagamenti.Count : 0)+ ")" ;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewResi(IList<ResoDto> resi)
        {
            try
            {
                btnResi.TextButton = "Resi (" + (resi != null ? resi.Count : 0) + ")";
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
                btnArticoli.TextButton = "Dettaglio acquisti (" + (articoli != null ? articoli.Count  : 0)+ ")";
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
                editFornitore.Value = BusinessLogic.Fornitore.GetCodifica(fornitore);
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
                editCentroCosto.Value = BusinessLogic.CentroCosto.GetCodifica(centroCosto);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewTotali(FatturaAcquistoDto obj)
        {
            try
            {
                var today = DateTime.Today;
                var totalePagamenti = BusinessLogic.Fattura.GetTotalePagamenti(obj, today);
                var totaleResi = BusinessLogic.Fattura.GetTotaleResi(obj, today);
                var statoDescrizione = BusinessLogic.Fattura.GetStatoDescrizione(obj); 

                editStato.Value = statoDescrizione;
                editTotalePagamenti.Value = totalePagamenti;
                editTotaleResi.Value = totaleResi;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewTotaleFattura()
        {
            try
            {
                var imponibile = UtilityValidation.GetDecimal(editImponibile.Value);
                var iva = UtilityValidation.GetDecimal(editIVA.Value);
                var totaleFattura = BusinessLogic.Fattura.GetTotale(imponibile, iva);
                editTotale.Value = totaleFattura;
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
                
                    var centroCosto = (CentroCostoDto)editCentroCosto.Model;
                    if (centroCosto != null)
                        obj.CentroCostoId = centroCosto.Id;

                    var fornitore = (FornitoreDto)editFornitore.Model;
                    if (fornitore != null)
                        obj.FornitoreId = fornitore.Id;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
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
                var fornitore = (FornitoreDto)model;
                BindViewFornitore(fornitore);
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
                BindViewCentroCosto(centroCosto);
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
                BindViewTotaleFattura();
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
                    var obj = (FatturaAcquistoDto)Model;
                    BindViewTotali(obj);
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
                btnPagamenti.Enabled = !editing;
                btnResi.Enabled = !editing;
                btnArticoli.Enabled = !editing;
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
                    space.Title = "PAGAMENTI | FATTURA " + BusinessLogic.Fattura.GetCodifica(obj);
                    Workspace.AddSpace(space);
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
                    space.Title = "RESI | FATTURA" + BusinessLogic.Fattura.GetCodifica(obj);
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
                    space.Title = "DETTAGLIO ACQUISTI | FATTURA " + BusinessLogic.Fattura.GetCodifica(obj);
                    Workspace.AddSpace(space);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void SetNewValue(object model)
        {
            try
            {
                BindViewFornitore(fornitore);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

	}
}
