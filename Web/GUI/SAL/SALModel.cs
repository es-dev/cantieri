using BusinessLogic;
using Library.Code;
using Library.Code.Enum;
using Library.Template.Controls;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using WcfService.Dto;
using Web.Code;

namespace Web.GUI.SAL
{
	public partial class SALModel : TemplateModel
	{
        private CommessaDto commessa = null;

        public SALModel()
		{
			InitializeComponent();
		}

        public SALModel(CommessaDto commessa)
        {
            InitializeComponent();
            try
            {
                this.commessa = commessa;
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
                var obj = (SALDto)model;
                var codice = UtilityValidation.GetStringND(obj.Codice);
                var denominazione = UtilityValidation.GetStringND(obj.Denominazione);
                infoSubtitle.Text = codice + " - " + denominazione;
                infoSubtitleImage.Image = "Images.dashboard.SAL.png";
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
                    var obj = (WcfService.Dto.SALDto)model;
                    editData.Value = obj.Data;
                    editCodice.Value = obj.Codice;
                    editNote.Value = obj.Note;

                    var commessa = GetCommessa(obj);
                    editTotaleAcquisti.Value = BusinessLogic.SAL.GetTotaleAcquisti(obj, commessa);
                    editTotaleVendite.Value = BusinessLogic.SAL.GetTotaleVendite(obj, commessa);
                    editTotaleIncassi.Value = BusinessLogic.SAL.GetTotaleIncassi(obj, commessa);
                    editDenominazione.Value = obj.Denominazione;
                    editTotalePagamenti.Value = BusinessLogic.SAL.GatTotalePagamenti(obj, commessa);
                    editStato.Value = BusinessLogic.SAL.GetStatoDescrizione(obj, commessa); 
                    
                    BindViewCommessa(obj.Commessa);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewCommessa(CommessaDto commessa)
        {
            try
            {
                editCommessa.Model = commessa;
                editCommessa.Value = (commessa != null ? commessa.Codice + " - " + commessa.Denominazione : null);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
           
        }

        private void BindViewTotali()
        {
            try
            {
                var obj = (WcfService.Dto.SALDto)Model;
                var commessa = GetCommessa(obj);
                var data = editData.Value;
                if (commessa != null && data != null)
                {
                    var fornitori = commessa.Fornitores;
                    var committenti = commessa.Committentes;

                    var totaleFattureAcquisto = BusinessLogic.SAL.GetTotaleFattureAcquisto(fornitori, data.Value);
                    var totaleFattureVendite = BusinessLogic.SAL.GetTotaleFattureVendita(committenti, data.Value);
                    var totalePagamenti = BusinessLogic.SAL.GetTotalePagamenti(fornitori, data.Value);
                    var totaleIncassi = BusinessLogic.SAL.GetTotaleIncassi(committenti, data.Value);
                    var statoDescrizione = BusinessLogic.SAL.GetStatoDescrizione(obj, commessa);

                    editStato.Value = statoDescrizione;
                    editTotaleAcquisti.Value = totaleFattureAcquisto;
                    editTotaleVendite.Value = totaleFattureVendite;
                    editTotalePagamenti.Value = totalePagamenti;
                    editTotaleIncassi.Value = totaleIncassi;
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
                    var obj = (SALDto)model;
                    obj.Data = editData.Value;
                    obj.Codice = editCodice.Value;
                    obj.Note = editNote.Value;
                    obj.TotaleFattureAcquisto = editTotaleAcquisti.Value;
                    obj.TotaleFattureVendite = editTotaleVendite.Value;
                    obj.TotaleIncassi = editTotaleIncassi.Value;
                    obj.TotalePagamenti = editTotalePagamenti.Value;
                    obj.Denominazione = editDenominazione.Value;
                    obj.Stato = editStato.Value;
                    var commessa = (CommessaDto)editCommessa.Model;
                    if (commessa != null)
                        obj.CommessaId = commessa.Id;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editCommessa_ComboClick()
        {
            try
            {
                var view = new Commessa.CommessaView();
                view.Title = "SELEZIONA UNA COMMESSA";
                editCommessa.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editCommessa_ComboConfirm(object model)
        {
            try
            {
                var commessa = (CommessaDto)model;
                if (commessa != null)
                {
                    editCommessa.Value = commessa.Denominazione;
                    BindViewTotali();
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
  
        private void btnCalcoloSAL_Click(object sender, EventArgs e)
        {
            try
            {
                BindViewTotali();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editData_Confirm(DateTime? value)
        {
            try
            {
                if (Editing)
                    BindViewTotali();
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
                btnCalcoloSAL.Enabled = editing;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void SALModel_Load(object sender, EventArgs e)
        {
            try
            {
                var obj = (SALDto)Model;
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
                if (commessa != null)
                {
                    editCommessa.Model = commessa;
                    editCommessa.Value = commessa.Codice + " - " + commessa.Denominazione;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private CommessaDto GetCommessa(SALDto sal)
        {
            try
            {
                if (sal != null)
                {
                    var commessaId = sal.CommessaId;
                    var viewModelCommittente = new Commessa.CommessaViewModel(this);
                    var commessa = viewModelCommittente.Read(commessaId);
                    return commessa;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

	}
}
