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
        private PagamentoUnificatoDto pagamentoUnificato = null;

        public PagamentoUnificatoFatturaAcquistoModel()
		{
			InitializeComponent();
		}

        public PagamentoUnificatoFatturaAcquistoModel(PagamentoUnificatoDto pagamentoUnificato)
        {
            InitializeComponent();
            try
            {
                this.pagamentoUnificato = pagamentoUnificato;
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
                infoSubtitleImage.Image = "Images.dashboard.pagamentounificatofatturaacquisto.png";
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
                    
                    BindViewFatturaAcquisto(obj.FatturaAcquisto);
                    BindViewPagamentoUnificato(obj.PagamentoUnificato);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewPagamentoUnificato(PagamentoUnificatoDto pagamentoUnificato)
        {
            try
            {
                editPagamentoUnificato.Model = pagamentoUnificato;
                editPagamentoUnificato.Value = (pagamentoUnificato != null ? pagamentoUnificato.Codice + "/" + pagamentoUnificato.Data.Value.Year.ToString() : null);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            
        }

        private void BindViewFatturaAcquisto(FatturaAcquistoDto fatturaAcquisto)
        {
            try
            {
                editFatturaAcquisto.Model = fatturaAcquisto;
                editFatturaAcquisto.Value = (fatturaAcquisto != null ? fatturaAcquisto.Numero + " del " + fatturaAcquisto.Data.Value.ToString("dd/MM/yyyy") : null);
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
                var obj = (PagamentoUnificatoFatturaAcquistoDto)Model;
                var pagamentoUnificato = (PagamentoUnificatoDto)editPagamentoUnificato.Model;
                var codiceFornitore = pagamentoUnificato.CodiceFornitore;
                var viewModelAnagraficaFornitore = new AnagraficaFornitore.AnagraficaFornitoreViewModel(this);
                var anagraficaFornitore = viewModelAnagraficaFornitore.ReadAnagraficaFornitore(codiceFornitore);
                var view = new FatturaAcquisto.FatturaAcquistoView(anagraficaFornitore, Tipi.StatoFattura.NonPagata | Tipi.StatoFattura.Insoluta);
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
                    CalcolaSaldo();
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

        private void CalcolaSaldo()
        {
            try
            {
                var fatturaAcquisto = (FatturaAcquistoDto)editFatturaAcquisto.Model;
                if (fatturaAcquisto != null)
                {
                    var today = DateTime.Today;
                    var saldo = BusinessLogic.Fattura.GetTotalePagamentiDare(fatturaAcquisto, today);
                    editSaldo.Value = saldo;
                }

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void PagamentoUnificatoFatturaAcquistoModel_Load(object sender, EventArgs e)
        {
            try
            {
                var obj = (PagamentoUnificatoFatturaAcquistoDto)Model;
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
                if (pagamentoUnificato != null)
                {
                    editPagamentoUnificato.Model = pagamentoUnificato;
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
