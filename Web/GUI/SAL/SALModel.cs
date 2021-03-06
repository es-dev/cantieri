using BusinessLogic;
using Library.Code;
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

        public override void BindViewTitle(object model)
        {
            try
            {
                var obj = (SALDto)model;
                infoSubtitle.Text = BusinessLogic.SAL.GetCodifica(obj);
                infoSubtitleImage.Image = "Images.dashboard.SAL.png";
                infoTitle.Text = (obj.Id != 0 ? "SAL " + BusinessLogic.SAL.GetCodifica(obj) : "NUOVO SAL") + " | COMMESSA " + BusinessLogic.Commessa.GetCodifica(obj.Commessa);
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
                    var obj = (SALDto)model;
                    editData.Value = obj.Data;
                    editCodice.Value = obj.Codice;
                    editNote.Value = obj.Note;
                    editDenominazione.Value = obj.Denominazione;

                    BindViewCommessa(obj.Commessa);
                    BindViewTotali(obj);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewCodiceSAL(CommessaDto commessa)
        {
            try
            {
                var codice = BusinessLogic.SAL.GetNewCodice(commessa);
                var data = DateTime.Now;
                editCodice.Value = codice;
                editData.Value =  data;
                editDenominazione.Value = BusinessLogic.SAL.GetDenominazione(codice, data, commessa);
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
                editCommessa.Value = BusinessLogic.Commessa.GetCodifica(commessa);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
           
        }

        private void BindViewTotali(SALDto obj)
        {
            try
            {
                if (obj != null)
                {
                    var viewModel = new Commessa.CommessaViewModel();
                    var commessa = viewModel.ReadCommessa(obj);
                    if (commessa != null)
                    {
                        var data = UtilityValidation.GetData(editData.Value);

                        var fornitori = commessa.Fornitores;
                        var committenti = commessa.Committentes;

                        var totaleFattureAcquisto = BusinessLogic.SAL.GetTotaleFattureAcquisto(fornitori, data);
                        var totaleFattureVendita = BusinessLogic.SAL.GetTotaleFattureVendita(committenti, data);
                        var totalePagamenti = BusinessLogic.SAL.GetTotalePagamenti(fornitori, data);
                        var totaleIncassi = BusinessLogic.SAL.GetTotaleIncassi(committenti, data);
                        var statoDescrizione = BusinessLogic.SAL.GetStatoDescrizione(obj, commessa);

                        editStato.Value = statoDescrizione;
                        editTotaleFattureAcquisto.Value = totaleFattureAcquisto;
                        editTotaleFattureVendita.Value = totaleFattureVendita;
                        editTotalePagamenti.Value = totalePagamenti;
                        editTotaleIncassi.Value = totaleIncassi;
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
                    var obj = (SALDto)model;
                    obj.Data = editData.Value;
                    obj.Codice = editCodice.Value;
                    obj.Note = editNote.Value;
                    obj.TotaleFattureAcquisto = editTotaleFattureAcquisto.Value;
                    obj.TotaleFattureVendita = editTotaleFattureVendita.Value;
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
                BindViewCommessa(commessa);
                BindViewCodiceSAL(commessa);

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
                bool saved = Save();
                if (saved)
                {
                    var obj = (SALDto)Model;
                    BindViewTotali(obj);
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
                btnCalcoloSAL.Enabled = editing;
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
                BindViewCommessa(commessa);
                BindViewCodiceSAL(commessa);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        

        

	}
}
