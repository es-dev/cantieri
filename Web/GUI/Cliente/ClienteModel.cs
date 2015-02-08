using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Web.Code;

namespace Web.GUI.Cliente
{
	public partial class ClienteModel : TemplateModel
	{
        public ClienteModel()
		{
			InitializeComponent();
		}

        public override void BindViewSubTitle(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.ClienteDto)model;
                    infoSubtitleImage.Image = "Images.dashboard.cliente.png";
                    infoSubtitle.Text = obj.Codice + " - " + obj.RagioneSociale;
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
                    var obj = (WcfService.Dto.ClienteDto)model;
                    editRagioneSociale.Value = obj.RagioneSociale;
                    editIndirizzo.Value = obj.Indirizzo;
                    editCAP.Value = obj.CAP;
                    editComune.Value = new Library.Controls.ComuniProvince.Comune(obj.Comune, obj.CodiceCatastale, obj.Provincia);
                    editTelefono.Value = obj.Telefono;
                    editFAX.Value = obj.Fax;
                    editMobile.Value = obj.Mobile;
                    editEmail.Value = obj.Email;
                    editPartitaIVA.Value = obj.PIva;
                    var commessa = obj.Commessa;
                    if (commessa != null)
                    {
                        editCommessa.Model = commessa;
                        editCommessa.Value = "(" + commessa.Codice + ") - " + commessa.Denominazione;
                    }
                    editCodiceCliente.Value = obj.Codice;

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
                    var obj = (WcfService.Dto.ClienteDto)model;
                    obj.RagioneSociale = editRagioneSociale.Value;
                    obj.Indirizzo = editIndirizzo.Value;
                    obj.CAP = editCAP.Value;
                    obj.Comune = editComune.Value.Denominazione;
                    obj.CodiceCatastale = editComune.Value.CodiceCatastale;
                    obj.Provincia = editComune.Value.Provincia;
                    obj.Telefono = editTelefono.Value;
                    obj.Fax = editFAX.Value;
                    obj.Mobile = editMobile.Value;
                    obj.Email = editEmail.Value;
                    obj.PIva = editPartitaIVA.Value;
                    obj.Codice = editCodiceCliente.Value;
                    var commessa = (WcfService.Dto.CommessaDto)editCommessa.Model;
                    if (commessa != null)
                        obj.Id = commessa.Id;
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
                var commessa = (WcfService.Dto.CommessaDto)model;
                if (commessa != null)
                    editCommessa.Value = "(" + commessa.Codice + ") - " + commessa.Denominazione;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editCodiceCliente_ComboClick()
        {
            try
            {
                var view = new AnagraficaCliente.AnagraficaClienteView();
                view.Title = "SELEZIONA UN CLIENTE DALL'ANAGRAFICA CLIENTI";
                editCodiceCliente.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editCodiceCliente_ComboConfirm(object model)
        {
            try
            {
                var anagraficaCliente = (WcfService.Dto.AnagraficaClienteDto)model;
                if (anagraficaCliente != null)
                {
                    editCodiceCliente.Value = anagraficaCliente.Codice;
                    editCAP.Value = anagraficaCliente.CAP;
                    editComune.Value = new Library.Controls.ComuniProvince.Comune(anagraficaCliente.Comune, anagraficaCliente.Provincia);
                    editEmail.Value = anagraficaCliente.Email;
                    editFAX.Value = anagraficaCliente.Fax;
                    editIndirizzo.Value = anagraficaCliente.Indirizzo;
                    editMobile.Value = anagraficaCliente.Mobile;
                    editPartitaIVA.Value = anagraficaCliente.PIva;
                    editRagioneSociale.Value = anagraficaCliente.RagioneSociale;
                    editTelefono.Value = anagraficaCliente.Telefono;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

	}
}
