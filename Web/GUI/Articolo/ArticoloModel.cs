using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Web.Code;

namespace Web.GUI.Articolo
{
	public partial class ArticoloModel : TemplateModel
	{
        public ArticoloModel()
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
                    var obj = (WcfService.Dto.ArticoloDto)model;
                    //editCosto.Value = obj.Costo;
                    editDescrizione.Value = obj.Descrizione;
                    //editImporto.Value = obj.Importo;
                    //editIVA.Value = obj.IVA;
                    editQuantita.Value = obj.Quantita;
                    //editSconto.Value = obj.Sconto;
                    //editTotale.Value = obj.Totale;
                    var fatturaAcquisto = obj.Fattura;
                    if (fatturaAcquisto != null)
                    {
                        editFatturaAcquisto.Model = fatturaAcquisto;
                        editFatturaAcquisto.Value = fatturaAcquisto.Numero;
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
                var obj = (WcfService.Dto.ArticoloDto)model;
                obj.Codice = editCodice.Value;
                //obj.Costo = editCosto.Value;
                obj.Descrizione = editDescrizione.Value;
                //obj.Importo = editImporto.Value;
                //obj.IVA = editIVA.Value;
                obj.Quantita = editQuantita.Value;
                //obj.Sconto = editSconto.Value;
                //obj.Totale = editTotale.Value;
                obj.FatturaId = (int)editFatturaAcquisto.Id;
                obj.Fattura = (WcfService.Dto.FatturaAcquistoDto)editFatturaAcquisto.Model;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editFatturaAcquisto_ComboClick()
        {
            try
            {
                var view = new FatturaAcquisto.FatturaAcquistoView();
                editFatturaAcquisto.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editFatturaAcquisto_ComboConfirm(object model)
        {
            try
            {
                var fatturaAcquisto = (WcfService.Dto.FatturaAcquistoDto)model;
                if (fatturaAcquisto != null)
                    editFatturaAcquisto.Value = fatturaAcquisto.Numero;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

	}
}
