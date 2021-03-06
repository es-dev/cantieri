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

namespace Web.GUI.AnagraficaArticolo
{
	public partial class AnagraficaArticoloModel : TemplateModel
	{
        public AnagraficaArticoloModel()
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
                    var obj = (AnagraficaArticoloDto)model;
                    infoSubtitle.Text = BusinessLogic.Articolo.GetCodifica(obj);
                    infoSubtitleImage.Image = "Images.dashboard.anagraficaarticolo.png";
                    infoTitle.Text = (obj.Id!=0? "ANAGRAFICA ARTICOLO " + BusinessLogic.Articolo.GetCodifica(obj): "NUOVA ANAGRAFICA ARTICOLO");
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
                    var obj = (AnagraficaArticoloDto)model;
                    editCodice.Value = obj.Codice;
                    editDescrizione.Value = obj.Descrizione;
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
                    var obj = (WcfService.Dto.AnagraficaArticoloDto)model;
                    obj.Codice = editCodice.Value;
                    obj.Descrizione = editDescrizione.Value;
                    obj.Note = editNote.Value;

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

                var obj = (AnagraficaArticoloDto)Model;
                var viewModel = (AnagraficaArticoloViewModel)ViewModel;
                var azienda = (AziendaDto)editAzienda.Model;
                if (azienda != null)
                {
                    var anagraficheArticoli = viewModel.ReadArticoli(azienda);
                    var validateAnagraficaArticolo = BusinessLogic.Diagnostico.ValidateAnagraficaArticolo(obj, anagraficheArticoli);
                    if (validateAnagraficaArticolo != null)
                    {
                        validated.State = validateAnagraficaArticolo.State;
                        validated.Message = validateAnagraficaArticolo.Message;
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
