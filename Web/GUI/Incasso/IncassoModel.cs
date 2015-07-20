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

        public override void SetNewValue(object model)
        {
            try
            {
                BindViewFatturaVendita(fatturaVendita);
                BindViewCodiceIncasso(fatturaVendita);

                editData.Value = DateTime.Now;
                editTransazionePagamento.Value = Tipi.TransazionePagamento.Acconto.ToString();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewCodiceIncasso(FatturaVenditaDto fatturaVendita)
        {
            try
            {
                var codice = BusinessLogic.Incasso.GetCodice(fatturaVendita);
                editCodice.Value = codice;

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
                    infoSubtitle.Text = BusinessLogic.Incasso.GetCodifica(obj);
                    infoSubtitleImage.Image = "Images.dashboard.incasso.png";
                    infoTitle.Text = (obj.Id != 0 ? "INCASSO " + BusinessLogic.Incasso.GetCodifica(obj) : "NUOVO INCASSO") + " | FATTURA VENDITA " + BusinessLogic.Fattura.GetCodifica(obj.FatturaVendita);
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
                var fatturaVenditaCommittente = BusinessLogic.Fattura.GetCodifica(fatturaVendita);
                if (fatturaVendita != null)
                {
                    var committente = fatturaVendita.Committente;
                    var anagraficaCommittente = committente.AnagraficaCommittente;
                    fatturaVenditaCommittente += anagraficaCommittente.RagioneSociale;
                }
                editFatturaVendita.Value = fatturaVenditaCommittente;
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
                var fatturaVendita = (FatturaVenditaDto)model;
                BindViewFatturaVendita(fatturaVendita);
                BindViewCodiceIncasso(fatturaVendita);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

       

	}
}
