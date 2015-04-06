using BusinessLogic;
using Library.Code;
using Library.Code.Enum;
using Library.Controls;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using WcfService.Dto;
using Web.Code;

namespace Web.GUI.Commessa
{
	public partial class CommessaModel : TemplateModel
	{
        public CommessaModel()
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

        private void InitCombo()
        {
            try
            {
                editStato.DisplayValues = UtilityEnum.GetDisplayValues<Tipi.StatoCommessa>();
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
                    var obj = (WcfService.Dto.CommessaDto)model;
                    var codice = UtilityValidation.GetStringND(obj.Codice);
                    var denominazione = UtilityValidation.GetStringND(obj.Denominazione);
                    infoSubtitle.Text = codice + " - " + denominazione;
                    infoSubtitleImage.Image = "Images.dashboard.commessa.png";
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
                    var obj = (WcfService.Dto.CommessaDto)model;
                    editDenominazione.Value = obj.Denominazione;
                    editCodice.Value = obj.Codice;
                    editCAP.Value = obj.CAP;
                    editComune.Value = new Countries.City(obj.Comune, obj.CodiceCatastale, obj.Provincia);
                    editLocalita.Value = obj.Localita;
                    editIndirizzo.Value = obj.Indirizzo;
                    editCreazione.Value = obj.Creazione;
                    editDescrizione.Value = obj.Descrizione;
                    editNumero.Value = obj.Numero;
                    editRiferimento.Value = obj.Riferimento;
                    editScadenza.Value = obj.Scadenza;
                    editStato.Value = obj.Stato;
                    editNote.Value = obj.Note;
                    editImporto.Value = obj.Importo;
                    editMargine.Value = obj.Margine;
                    editImportoAvanzamentoLavori.Value = BusinessLogic.Commessa.GetImportoAvanzamentoLavori(obj);
                    editPercentualeAvanzamento.Value = BusinessLogic.Commessa.GetPercentualeAvanzamento(obj);
                    editEstremiContratto.Value = obj.EstremiContratto;
                    editOggetto.Value = obj.Oggetto;
                    editImportoPerizie.Value = obj.ImportoPerizie;
                    editInizioLavori.Value = obj.InizioLavori;
                    editFineLavori.Value = obj.FineLavori;
                    
                    BindViewAzienda(obj.Azienda);
                    BindViewFornitori(obj.Fornitores);
                    BindViewCommittenti(obj.Committentes);
                    BindViewSALs(obj.SALs);

                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewSALs(IList<SALDto> sals)
        {
            try
            {
                btnSAL.TextButton = "SAL (" + (sals != null ? sals.Count : 0) + ")";
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewCommittenti(IList<CommittenteDto> committenti)
        {
            try
            {
                btnCommittenti.TextButton = "Committenti (" + (committenti!=null?committenti.Count:0) + ")";
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewFornitori(IList<FornitoreDto> fornitori)
        {
            try
            {
                btnFornitori.TextButton = "Fornitori (" + (fornitori!=null?fornitori.Count:0) + ")";
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewAzienda(AziendaDto azienda)
        {
            try
            {
                editAzienda.Model = azienda;
                editAzienda.Value = (azienda != null ? azienda.Codice + " - " + azienda.RagioneSociale : null);
            }           
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewAvanzamentoLavori()
        {
            try
            {
                var obj = (CommessaDto)Model;
                var importo = BusinessLogic.Commessa.GetImportoAvanzamentoLavori(obj);
                var percentuale = BusinessLogic.Commessa.GetPercentualeAvanzamento(obj);

                editPercentualeAvanzamento.Value = percentuale;
                editImportoAvanzamentoLavori.Value = importo;
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
                    var obj = (WcfService.Dto.CommessaDto)model;
                    obj.Denominazione = editDenominazione.Value;
                    obj.Codice = editCodice.Value;
                    obj.CAP = editCAP.Value;
                    obj.Comune = editComune.Value.Description;
                    obj.CodiceCatastale = editComune.Value.Code;
                    obj.Provincia = editComune.Value.County;
                    obj.Localita = editLocalita.Value;
                    obj.Indirizzo = editIndirizzo.Value;
                    obj.Creazione = editCreazione.Value;
                    obj.Descrizione = editDescrizione.Value;
                    obj.Numero = editNumero.Value;
                    obj.Riferimento = editRiferimento.Value;
                    obj.Scadenza = editScadenza.Value;
                    obj.Stato = editStato.Value;
                    obj.Note = editNote.Value;
                    obj.Importo = editImporto.Value;
                    obj.Margine = editMargine.Value;
                    obj.ImportoAvanzamento = editImportoAvanzamentoLavori.Value;
                    obj.Percentuale = editPercentualeAvanzamento.Value;
                    obj.EstremiContratto = editEstremiContratto.Value;
                    obj.Oggetto = editOggetto.Value;
                    obj.ImportoPerizie = editImportoPerizie.Value;
                    obj.InizioLavori = editInizioLavori.Value;
                    obj.FineLavori = editFineLavori.Value;
                    
                    var azienda = (WcfService.Dto.AziendaDto)editAzienda.Model;
                    if (azienda != null)
                        obj.AziendaId = azienda.Id;
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
                btnCalcoloAvanzamentoLavori.Enabled = editing;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override UtilityValidation.ValidationState IsValidated()
        {
            try
            {
                var validated = new UtilityValidation.ValidationState();
                var importo= UtilityValidation.GetDecimal(editImporto.Value);
                if (importo < 1000)
                {
                    validated.State = false;
                    validated.Message = "L'importo inserito non può essere negativo...";
                }
                return validated;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private void btnFornitori_Click(object sender, EventArgs e)
        {
            try
            {
                var obj = (CommessaDto)Model;
                var space = new Fornitore.FornitoreView(obj);
                space.Title = "FORNITORI - COMMESSA " + obj.Denominazione;
                Workspace.AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnCommittenti_Click(object sender, EventArgs e)
        {
            try
            {
                var obj = (CommessaDto)Model;
                var space = new Committente.CommittenteView(obj);
                space.Title = "COMMITTENTI - COMMESSA " + obj.Denominazione;
                Workspace.AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editAzienda_ComboClick()
        {
            try
            {
                var view = new Azienda.AziendaView();
                view.Title = "SELEZIONA UN'AZIENDA";
                editAzienda.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editAzienda_ComboConfirm(object model)
        {
            try
            {
                var azienda = (AziendaDto)model;
                if (azienda != null)
                    editAzienda.Value = azienda.RagioneSociale;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnCalcoloAvanzamentoLavori_Click(object sender, EventArgs e)
        {
            try
            {
                BindViewAvanzamentoLavori();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnSAL_Click(object sender, EventArgs e)
        {
            try
            {
                var obj = (CommessaDto)Model;
                var space = new SAL.SALView(obj);
                space.Title = "SAL - COMMESSSA " + obj.Denominazione;
                Workspace.AddSpace(space);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

	}
}
