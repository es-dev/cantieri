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

        public override void BindViewTitle(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.FatturaVenditaDto)model;
                    infoSubtitle.Text = "FATTURA "+ BusinessLogic.Fattura.GetCodifica(obj);
                    infoSubtitleImage.Image = "Images.dashboard.fatturavendita.png";
                    var committente = obj.Committente;
                    infoTitle.Text = (obj.Id != 0 ? "FATTURA VENDITA " + BusinessLogic.Fattura.GetCodifica(obj) : "NUOVA FATTURA DI VENDITA") + " / COMMITTENTE " + BusinessLogic.Committente.GetCodifica(committente);
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
                    editTotale.Value = obj.Totale;
                    editNumero.Value = obj.Numero;
                    editTipoPagamento.Value = obj.TipoPagamento;
                    editScadenzaPagamento.Value = obj.ScadenzaPagamento;
                    editNote.Value = obj.Note;

                    BindViewCommittente(obj.Committente);
                    BindViewIncassi(obj.Incassos);
                    BindViewTotali(obj);
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
                editCommittente.Value = BusinessLogic.Committente.GetCodifica(committente);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            
        }

        private void BindViewTotali(FatturaVenditaDto obj)
        {
            try
            {
                var today = DateTime.Today;
                var totaleIncassi = BusinessLogic.Fattura.GetTotaleIncassi(obj, today);
                var statoDescrizione = BusinessLogic.Fattura.GetStatoDescrizione(obj);

                editStato.Value = statoDescrizione;
                editTotaleIncassi.Value = totaleIncassi;
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
                    var obj = (FatturaVenditaDto)model;
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
                  
                    var committente = (CommittenteDto)editCommittente.Model;
                    if (committente != null)
                        obj.CommittenteId = committente.Id;
                    
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
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
                BindViewCommittente(committente);
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
                    var obj = (FatturaVenditaDto)Model;
                    BindViewTotali(obj);
                }
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

        public override void SetEditing(bool editing, bool deleting)
        {
            try
            {
                base.SetEditing(editing, deleting);
                btnCalcoloTotali.Enabled = editing;
                btnIncassi.Enabled = !editing;
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
                bool saved = Save();
                if (saved)
                {
                    var obj = (FatturaVenditaDto)Model;
                    var space = new Incasso.IncassoView(obj);
                    space.Title = "INCASSI / FATTURA " + BusinessLogic.Fattura.GetCodifica(obj);
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
                BindViewCommittente(committente);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

	}
}
