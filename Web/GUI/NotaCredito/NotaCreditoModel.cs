using BusinessLogic;
using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using WcfService.Dto;
using Web.Code;
using Web.GUI.FatturaAcquisto;

namespace Web.GUI.NotaCredito
{
	public partial class NotaCreditoModel : TemplateModel
	{
        private FornitoreDto fornitore = null;
        public NotaCreditoModel()
		{
			InitializeComponent();
            try
            {
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
		}

        public NotaCreditoModel(FornitoreDto fornitore)
        {
            InitializeComponent();
            try
            {
                this.fornitore = fornitore;
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
                var obj = (NotaCreditoDto)model;
                infoSubtitle.Text = "NOTA CREDITO "+ BusinessLogic.Fattura.GetCodifica(obj);
                infoSubtitleImage.Image = "Images.dashboard.notacredito.png";
                var fornitore = obj.Fornitore;
                infoTitle.Text = (obj.Id != 0 ? "NOTA CREDITO " + BusinessLogic.Fattura.GetCodifica(obj) : "NUOVA NOTA CREDITO") + " / FORNITORE " + BusinessLogic.Fornitore.GetCodifica(fornitore);
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
                    var obj = (NotaCreditoDto)model;
                    editNumero.Value = obj.Numero;
                    editData.Value = obj.Data;
                    editNote.Value = obj.Note;
                    editTotale.Value = obj.Totale;
                    editImponibile.Value = obj.Imponibile;
                    editIVA.Value = obj.IVA;
                    editDescrizione.Value = obj.Descrizione;

                    BindViewFornitore(obj.Fornitore);
                    BindViewResi(obj.Resos);
                }
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

        private void BindViewTotali()
        {
            try
            {
                var data = editData.Value;
                if (data != null)
                {
                    var obj = (WcfService.Dto.NotaCreditoDto)Model;
                    editImponibile.Value = BusinessLogic.Fattura.GetImponibileNotaCredito(obj, data.Value);
                    editIVA.Value = BusinessLogic.Fattura.GetIVANotaCredito(obj, data.Value);
                    editTotale.Value = BusinessLogic.Fattura.GetTotaleNotaCredito(obj, data.Value);
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
                    var obj = (NotaCreditoDto)model;
                    obj.Numero = editNumero.Value;
                    obj.Data = editData.Value;
                    obj.Totale = editTotale.Value;
                    obj.IVA = editIVA.Value;
                    obj.Imponibile = editImponibile.Value;
                    obj.Note = editNote.Value;
                    obj.Descrizione = editDescrizione.Value;

                    var fornitore = (FornitoreDto)editFornitore.Model;
                    if(fornitore!=null)
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

        private void btnResi_Click(object sender, EventArgs e)
        {
            try
            {
                bool saved = Save();
                if (saved)
                {
                    var obj = (NotaCreditoDto)Model;
                    var space = new Reso.ResoView(obj);
                    space.Title = "RESI / NOTA CREDITO " + BusinessLogic.Fattura.GetCodifica(obj);
                    Workspace.AddSpace(space);
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
                btnResi.Enabled = !editing;
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
