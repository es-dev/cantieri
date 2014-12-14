using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Web.Code;

namespace Web.GUI.AnagraficaCliente
{
	public partial class AnagraficaClienteModel : TemplateModel
	{
        public AnagraficaClienteModel()
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
                    var obj = (WcfService.Dto.AnagraficaClienteDto)model;
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
                var obj = (WcfService.Dto.AnagraficaClienteDto)model;
                obj.RagioneSociale = editRagioneSociale.Value;
                obj.Indirizzo = editIndirizzo.Value;
                obj.CAP = editCAP.Value;
                obj.Comune = editComune.Value;
                obj.Provincia = editIndirizzo.Value;
                obj.Telefono = editTelefono.Value;
                obj.Fax = editFAX.Value;
                obj.Mobile = editMobile.Value;
                obj.Email = editEmail.Value;
                obj.PIva = editPartitaIVA.Value;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

	}
}
