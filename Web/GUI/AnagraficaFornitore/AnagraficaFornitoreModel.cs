using Library.Code;
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

namespace Web.GUI.AnagraficaFornitore
{
	public partial class AnagraficaFornitoreModel : TemplateModel
	{
        public AnagraficaFornitoreModel()
		{
			InitializeComponent();
		}

        public override void SetNewValue(object model)
        {
            try
            {
                var azienda = SessionManager.GetAzienda(Context);
                BindViewAzienda(azienda);
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
                    var obj = (AnagraficaFornitoreDto)model;
                    infoSubtitle.Text = BusinessLogic.Fornitore.GetCodifica(obj);
                    infoSubtitleImage.Image = "Images.dashboard.anagraficafornitore.png";
                    infoTitle.Text = (obj.Id != 0 ? "ANAGRAFICA FORNITORE " + BusinessLogic.Fornitore.GetCodifica(obj) : "NUOVA ANAGRAFICA FORNITORE");
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
                    var obj = (AnagraficaFornitoreDto)model;
                    editRagioneSociale.Value = obj.RagioneSociale;
                    editIndirizzo.Value = obj.Indirizzo;
                    editCAP.Value = obj.CAP;
                    editComune.Value = new Countries.City(obj.Comune, obj.CodiceCatastale, obj.Provincia);
                    editLocalita.Value = obj.Localita;
                    editTelefono.Value = obj.Telefono;
                    editFAX.Value = obj.Fax;
                    editMobile.Value = obj.Mobile;
                    editEmail.Value = obj.Email;
                    editPartitaIVA.Value = obj.PartitaIva;
                    editCodice.Value = obj.Codice;
                    editNote.Value = obj.Note;

                    BindViewAzienda(obj.Azienda);
                }
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
                editAzienda.Value = BusinessLogic.Azienda.GetCodifica(azienda);
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
                    var obj = (AnagraficaFornitoreDto)model;
                    obj.RagioneSociale = editRagioneSociale.Value;
                    obj.Indirizzo = editIndirizzo.Value;
                    obj.CAP = editCAP.Value;
                    obj.Comune = editComune.Value.Description;
                    obj.Localita = editLocalita.Value;
                    obj.CodiceCatastale = editComune.Value.Code;
                    obj.Provincia = editComune.Value.County;
                    obj.Telefono = editTelefono.Value;
                    obj.Fax = editFAX.Value;
                    obj.Mobile = editMobile.Value;
                    obj.Email = editEmail.Value;
                    obj.PartitaIva = editPartitaIVA.Value;
                    obj.Codice = editCodice.Value;
                    obj.Note = editNote.Value;
                
                    var azienda = (AziendaDto)editAzienda.Model;
                    if (azienda != null)
                        obj.AziendaId = azienda.Id;
                }
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
                BindViewAzienda(azienda);
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

                var obj = (AnagraficaFornitoreDto)Model;
                var viewModel = (AnagraficaFornitoreViewModel)ViewModel;
                var azienda = (AziendaDto)editAzienda.Model;
                if (azienda != null)
                {
                    var anagraficheFornitori = viewModel.ReadAnagraficheFornitori(azienda);
                    var validateAnagraficaFornitore = BusinessLogic.Diagnostico.ValidateAnagraficaFornitore(obj, anagraficheFornitori);
                    if (validateAnagraficaFornitore != null)
                    {
                        validated.State = validateAnagraficaFornitore.State;
                        validated.Message = validateAnagraficaFornitore.Message;
                    }
                }
                return validated;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
	}
}
