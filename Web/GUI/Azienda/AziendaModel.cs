using Library.Code;
using Library.Controls;
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
                    var codice = UtilityValidation.GetStringND(obj.Codice);
                    var ragioneSociale = UtilityValidation.GetStringND(obj.RagioneSociale);
                    infoSubtitle.Text = codice + " - " + ragioneSociale;
                    infoSubtitleImage.Image = "Images.dashboard.azienda.png";
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
                    editRagioneSociale.Value = obj.RagioneSociale;
                    editCAP.Value = obj.CAP;
                    editComune.Value = new Countries.City(obj.Comune, obj.CodiceCatastale, obj.Provincia);
                    editIndirizzo.Value = obj.Indirizzo;
                    editLocalita.Value = obj.Localita;
                    editNumeroDipendenti.Value = obj.Dipendenti;
                    editPartitaIVA.Value = obj.PartitaIva;
                    editTelefono.Value = obj.Telefono;
                    editFAX.Value = obj.Fax;
                    editEmail.Value = obj.Email;
                    editNote.Value = obj.Note;
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
                    obj.RagioneSociale = editRagioneSociale.Value;
                    obj.CAP = editCAP.Value;
                    obj.Comune = editComune.Value.Description;
                    obj.CodiceCatastale = editComune.Value.Code;
                    obj.Provincia = editComune.Value.County;
                    obj.Dipendenti = editNumeroDipendenti.Value;
                    obj.Indirizzo = editIndirizzo.Value;
                    obj.Localita = editLocalita.Value;
                    obj.PartitaIva = editPartitaIVA.Value;
                    obj.Telefono = editTelefono.Value;
                    obj.Fax = editFAX.Value;
                    obj.Email = editEmail.Value;
                    obj.Note = editNote.Value;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

   
	}
}
