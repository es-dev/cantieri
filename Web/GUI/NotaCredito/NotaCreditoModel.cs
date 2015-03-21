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
                InitCombo();
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
                var obj = (NotaCreditoDto)model;
                var numero = UtilityValidation.GetStringND(obj.Numero);
                var descrizione = UtilityValidation.GetStringND(obj.Descrizione);
                infoSubtitle.Text = numero + " - " + descrizione;
                infoSubtitleImage.Image = "Images.dashboard.notacredito.png";
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
                    editStato.Value = obj.Stato;
                    editDescrizione.Value = obj.Descrizione;
                    
                    BindViewFornitore(obj.Fornitore);
                }
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
                editFornitore.Value = (fornitore!=null? fornitore.Codice + " - " + fornitore.RagioneSociale:null);
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
                    obj.Stato = editStato.Value;
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
                view.Title = "SELEZIONA IL FORNITORE";
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
                if (fornitore != null)
                {
                    editFornitore.Value = fornitore.Codice + " - " + fornitore.RagioneSociale;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void NotaCreditoModel_Load(object sender, EventArgs e)
        {
            try
            {
                var obj = (NotaCreditoDto)Model;
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
                if (fornitore!=null)
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

	}
}
