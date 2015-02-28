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

namespace Web.GUI.PagamentoUnificatoFatturaAcquisto
{
	public partial class PagamentoUnificatoFatturaAcquistoModel : TemplateModel
	{
        public PagamentoUnificatoFatturaAcquistoModel()
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

        public override void BindViewSubTitle(object model)
        {
            try
            {
                var obj = (PagamentoUnificatoFatturaAcquistoDto)model;
                var codice = "PU/FA";
                infoSubtitle.Text = codice;
                infoSubtitleImage.Image = "Images.dashboard.pagamento.png";
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
                    var obj = (PagamentoUnificatoFatturaAcquistoDto)model;
                    editNote.Value = obj.Note;
                    editSaldo.Value = obj.Saldo;
                    var fatturaAcquisto = obj.FatturaAcquisto;
                    if (fatturaAcquisto != null)
                    {
                        editFatturaAcquisto.Model = fatturaAcquisto;
                        editFatturaAcquisto.Value = fatturaAcquisto.Numero +"/"+ fatturaAcquisto.Data.Value.Year.ToString();
                    }
                    var pagamentoUnificato = obj.PagamentoUnificato;
                    if (pagamentoUnificato != null)
                    {
                        editPagamentoUnificato.Model = pagamentoUnificato;
                        editPagamentoUnificato.Value = pagamentoUnificato.Codice + "/" + pagamentoUnificato.Data.Value.Year.ToString();
                    }

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
                    var obj = (PagamentoUnificatoFatturaAcquistoDto)model;
                    obj.Note = editNote.Value;
                    obj.Saldo = editSaldo.Value;
                    var fatturaAcquisto = (FatturaAcquistoDto)editFatturaAcquisto.Model;
                    if(fatturaAcquisto!=null)
                        obj.FatturaAcquistoId = fatturaAcquisto.Id;
                    var pagamentoUnificato = (PagamentoUnificatoDto)editPagamentoUnificato.Model;
                    if (pagamentoUnificato != null)
                        obj.PagamentoUnificatoId = pagamentoUnificato.Id;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editFatturaAcquisto_ComboClick()
        {
            try
            {
                var view = new FatturaAcquisto.FatturaAcquistoView();
                view.Title = "SELEZIONA LA FATTURA DI ACQUISTO";
                editFatturaAcquisto.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editFatturaAcquisto_ComboConfirm(object model)
        {
            try
            {
                var fatturaAcquisto = (FatturaAcquistoDto)model;
                if (fatturaAcquisto != null)
                {
                    editFatturaAcquisto.Value = fatturaAcquisto.Numero + "/" + fatturaAcquisto.Data.Value.Year.ToString();
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editPagamentoUnificato_ComboClick()
        {
            try
            {
                var view = new PagamentoUnificato.PagamentoUnificatoView();
                view.Title = "SELEZIONA IL PAGAMENTO UNIFICATO";
                editPagamentoUnificato.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editPagamentoUnificato_ComboConfirm(object model)
        {
            try
            {
                var pagamentoUnificato = (PagamentoUnificatoDto)model;
                if (pagamentoUnificato != null)
                {
                    editPagamentoUnificato.Value = pagamentoUnificato.Codice + "/" + pagamentoUnificato.Data.Value.Year.ToString();
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

	}
}