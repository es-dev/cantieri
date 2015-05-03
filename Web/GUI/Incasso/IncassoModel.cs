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

namespace Web.GUI.Incasso
{
	public partial class IncassoModel : TemplateModel
	{
        private FatturaVenditaDto fatturaVendita = null;

        public IncassoModel()
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

        public IncassoModel(FatturaVenditaDto fatturaVendita)
        {
            InitializeComponent();
            try
            {
                this.fatturaVendita = fatturaVendita;
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
                editTransazionePagamento.DisplayValues = UtilityEnum.GetDisplayValues<Tipi.TransazionePagamento>();
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
                    var obj = (IncassoDto)model;
                    infoSubtitle.Text = obj.Codice + " - " + obj.Descrizione;
                    infoSubtitleImage.Image = "Images.dashboard.incasso.png";
                    var fatturaVendita = obj.FatturaVendita;
                    string title = "INCASSO " + obj.Codice + " - " + BusinessLogic.Fattura.GetCodifica(fatturaVendita);
                    infoTitle.Text = (obj.Id!=0? title:"NUOVO INCASSO");
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
                    var obj = (WcfService.Dto.IncassoDto)model;
                    editCodice.Value = obj.Codice;
                    editData.Value = obj.Data;
                    editImporto.Value = obj.Importo;
                    editNote.Value = obj.Note;
                    editTipoPagamento.Value = obj.TipoPagamento;
                    editDescrizione.Value = obj.Descrizione;
                    editTransazionePagamento.Value = obj.TransazionePagamento;
                    BindViewFatturaVendita(obj.FatturaVendita);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewFatturaVendita(FatturaVenditaDto fatturaVendita)
        {
            try
            {
                editFatturaVendita.Model = fatturaVendita;
                var viewModelFatturaVendita = new FatturaVendita.FatturaVenditaViewModel();
                var fatturaVenditaId = fatturaVendita.Id;
                var _fatturaVendita= (FatturaVenditaDto)viewModelFatturaVendita.Read(fatturaVenditaId);
                var committente = _fatturaVendita.Committente;
                editFatturaVendita.Value = (fatturaVendita != null ? BusinessLogic.Fattura.GetCodifica(fatturaVendita, false) : null) + " - " + committente.RagioneSociale;
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
                    var obj = (WcfService.Dto.IncassoDto)model;
                    obj.Codice = editCodice.Value;
                    obj.Data = editData.Value;
                    obj.Importo = editImporto.Value;
                    obj.Note = editNote.Value;
                    obj.Descrizione = editDescrizione.Value;
                    obj.TipoPagamento = editTipoPagamento.Value;
                    obj.TransazionePagamento = editTransazionePagamento.Value;
                    var fatturaVendita = (WcfService.Dto.FatturaVenditaDto)editFatturaVendita.Model;
                    if(fatturaVendita!=null)
                        obj.FatturaVenditaId = fatturaVendita.Id;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editFatturaVendita_ComboClick()
        {
            try
            {
                var view = new FatturaVendita.FatturaVenditaView();
                view.Title = "SELEZIONA LA FATTURA DI VENDITA";
                editFatturaVendita.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editFatturaVendita_ComboConfirm(object model)
        {
            try
            {
                SetFatturaVendita(model);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void SetFatturaVendita(object model)
        {
            try
            {
                var fatturaVendita = (WcfService.Dto.FatturaVenditaDto)model;
                if (fatturaVendita != null)
                {
                    var viewModelFatturaVendita = new FatturaVendita.FatturaVenditaViewModel();
                    var fatturaVenditaId = fatturaVendita.Id;
                    var _fatturaVendita = (FatturaVenditaDto)viewModelFatturaVendita.Read(fatturaVenditaId);
                    var committente = _fatturaVendita.Committente;
                    editFatturaVendita.Value = (fatturaVendita != null ? BusinessLogic.Fattura.GetCodifica(fatturaVendita, false) : null) + " - " + committente.RagioneSociale;
                    var obj = (WcfService.Dto.IncassoDto)Model;
                    if (obj != null && obj.Id == 0)
                    {
                        var codice = BusinessLogic.Incasso.GetCodice(fatturaVendita);
                        editCodice.Value = codice;
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void IncassoModel_Load(object sender, EventArgs e)
        {
            try
            {
                var obj = (IncassoDto)Model;
                if (obj != null && obj.Id == 0)
                    SetNewValue(obj);

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void SetNewValue(object model)
        {
            try
            {
                SetFatturaVendita(model);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

	}
}
