using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Web.Code;

namespace Web.GUI.Pagamento
{
	public partial class PagamentoModel : TemplateModel
	{
        public PagamentoModel()
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
                    var obj = (WcfService.Dto.PagamentoDto)model;
                    editData.Value = obj.Data;
                    editEseguito.Value = obj.Eseguito;
                    editImporto.Value = obj.Importo;
                    editModalita.Value = obj.Modalita;
                    editScadenza.Value = obj.Scadenza;
                    var fatturaAcquisto = obj.FatturaAcquisto;
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
                var obj = (WcfService.Dto.PagamentoDto)model;
                obj.Data = editData.Value;
                //obj.Eseguito = editEseguito.Value;
                obj.Importo = editImporto.Value;
                obj.Modalita = editModalita.Value;
                obj.Scadenza = editScadenza.Value;
                obj.FatturaAcquistoId = (int)editFatturaAcquisto.Id;
                obj.FatturaAcquisto = (WcfService.Dto.FatturaAcquistoDto)editFatturaAcquisto.Model;

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
