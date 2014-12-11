using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Web.Code;

namespace Web.GUI.Fornitore
{
	public partial class FornitoreModel : TemplateModel
	{
        public FornitoreModel()
		{
			InitializeComponent();
		}

        public override void BindViewSubTitle(object model)
        {
            try
            {
                
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
                    var obj = (WcfService.Dto.FornitoreDto)model;
                    editRagioneSociale.Value = obj.RagioneSociale;
                    editIndirizzo.Value = obj.Indirizzo;
                    editCAP.Value = obj.CAP;
                    editComune.Value = obj.Comune;
                    editProvincia.Value = obj.Provincia;
                    editTelefono.Value = obj.Telefono;
                    editFAX.Value = obj.Fax;
                    editMobile.Value = obj.Mobile;
                    editEmail.Value = obj.Email;
                    editPartitaIVA.Value = obj.PIva;
                    var commessa = obj.Commessa;
                    if (commessa != null)
                    {
                        editCommessa.Model = commessa;
                        editCommessa.Value = commessa.Denominazione;
                    }
                    editCentroCosto.Value = obj.CodiceCentroCosto;
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
                var obj = (WcfService.Dto.FornitoreDto)model;
                obj.RagioneSociale = editRagioneSociale.Value;
                obj.Indirizzo = editIndirizzo.Value;
                obj.CAP = editCAP.Value;
                obj.Comune = editComune.Value;
                obj.Provincia = editIndirizzo.Value;
                obj.Telefono = editTelefono.Value;
                obj.Fax = editFAX.Value;
                obj.Mobile = editMobile.Value;
                obj.Email = editEmail.Value;
                obj.CodiceCentroCosto = editCentroCosto.Value;
                obj.CommessaId = (int)editCommessa.Id;
                obj.Commessa = (WcfService.Dto.CommessaDto)editCommessa.Model;
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
                var commessa = (WcfService.Dto.CommessaDto)model;
                if (commessa != null)
                    editCommessa.Value = commessa.Denominazione;

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editCentroCosto_ComboConfirm(object model)
        {
            try
            {
                var view = new CentroCosto.CentroCostoView();
                editCentroCosto.Show(view);

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editCentroCosto_ComboClick()
        {
            try
            {
                //var centroCosto = (WcfService.Dto.CentroCostoDto)model;
                //if (centroCosto != null)
                //    editCentroCosto.Value = centroCosto.Denominazione;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }


	}
}
