using BusinessLogic;
using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
                var statiCommessa = Tipi.GetNames(typeof(Tipi.StatoCommessa));
                editStato.Items = statiCommessa;
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
                infoSubtitleImage.Image = "Images.dashboard.commessa.png";
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
                    editComune.Value = obj.Comune;
                    editIndirizzo.Value = obj.Indirizzo;
                    editProvincia.Value = obj.Provincia;
                    editCreazione.Value = obj.Creazione;
                    editDescrizione.Value = obj.Descrizione;
                    editNumero.Value = obj.Numero;
                    editRiferimento.Value = obj.Riferimento;
                    editScadenza.Value = obj.Scadenza;
                    editStato.Value = obj.Stato;
                    editImporto.Value = obj.Importo;
                    editMargine.Value = obj.Margine;
                    var azienda = obj.Azienda;
                    if (azienda != null)
                    {
                        editAzienda.Model = azienda;
                        editAzienda.Value = azienda.Denominazione;
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
                var obj = (WcfService.Dto.CommessaDto)model;
                obj.Denominazione = editDenominazione.Value;
                obj.Codice = editCodice.Value;
                obj.CAP = editCAP.Value;
                obj.Comune = editComune.Value;
                obj.Indirizzo = editIndirizzo.Value;
                obj.Provincia = editProvincia.Value;
                obj.Creazione = editCreazione.Value;
                obj.Descrizione = editDescrizione.Value;
                obj.Numero = editNumero.Value;
                obj.Riferimento = editRiferimento.Value;
                obj.Scadenza = editScadenza.Value;
                obj.Stato = editStato.Value;
                obj.Importo = editImporto.Value;    
                obj.Margine = editMargine.Value;    
                obj.AziendaId = (int)editAzienda.Id;
                obj.Azienda = (WcfService.Dto.AziendaDto)editAzienda.Model;
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
                var azienda = (WcfService.Dto.AziendaDto)model;
                if (azienda != null)
                    editAzienda.Value = azienda.Denominazione;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

	}
}
