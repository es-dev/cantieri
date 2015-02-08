using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Web.Code;

namespace Web.GUI.Azienda
{
	public partial class AziendaModel : TemplateModel
	{
        public AziendaModel()
		{
			InitializeComponent();
		}

        public override void BindViewSubTitle(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.AziendaDto)model;
                    infoSubtitleImage.Image = "Images.dashboard.azienda.png";
                    infoSubtitle.Text = obj.Codice + " " + obj.Denominazione;
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
                    var obj = (WcfService.Dto.AziendaDto)model;
                    editCodice.Value = obj.Codice;
                    editDenominazione.Value = obj.Denominazione;
                    editCAP.Value = obj.CAP;
                    editComune.Value = new Library.Controls.ComuniProvince.Comune(obj.Comune, obj.CodiceCatastale, obj.Provincia);
                    editIndirizzo.Value = obj.Indirizzo;
                    editNumeroDipendenti.Value = obj.Dipendenti;
                    editPartitaIVA.Value = obj.PIva;
                    editTelefono.Value = obj.Telefono;
                    editFAX.Value = obj.Fax;
                    editEmail.Value = obj.Email;
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
                    var obj = (WcfService.Dto.AziendaDto)model;
                    obj.Codice = editCodice.Value;
                    obj.Denominazione = editDenominazione.Value;
                    obj.CAP = editCAP.Value;
                    obj.Comune = editComune.Value.Denominazione;
                    obj.CodiceCatastale = editComune.Value.CodiceCatastale;
                    obj.Provincia = editComune.Value.Provincia;
                    obj.Dipendenti = editNumeroDipendenti.Value;
                    obj.Indirizzo = editIndirizzo.Value;
                    obj.PIva = editPartitaIVA.Value;
                    obj.Telefono = editTelefono.Value;
                    obj.Fax = editFAX.Value;
                    obj.Email = editEmail.Value;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

   
	}
}
