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
                    editDenominazione.Value = obj.Denominazione;
                    editCAP.Value = obj.CAP;
                    editComune.Value = obj.Comune;
                    editIndirizzo.Value = obj.Indirizzo;
                    editNumeroDipendenti.Value = obj.Dipendenti;
                    editPartitaIVA.Value = obj.PIva;
                    editProvincia.Value = obj.Provincia;
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
                var obj = (WcfService.Dto.AziendaDto)model;
                obj.Denominazione = editDenominazione.Value;
                obj.CAP = editCAP.Value;
                obj.Comune = editComune.Value;
                obj.Dipendenti = editNumeroDipendenti.Value;
                obj.Indirizzo = editIndirizzo.Value;
                obj.PIva = editPartitaIVA.Value;
                obj.Provincia = editIndirizzo.Value;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

	}
}
