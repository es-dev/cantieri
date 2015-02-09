using Library.Code;
using Library.Interfaces;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Web.Code;

namespace Web.GUI.FatturaAcquisto
{
	public partial class FatturaAcquistoItem : TemplateItem
	{
        public FatturaAcquistoItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.FatturaAcquistoDto)model;
                    infoImage.Image = "Images.dashboard.fatturaacquisto.png";
                    infoCodice.Text = "FA";
                    var numero = "N/D";
                    if (obj.Numero != null)
                        numero = obj.Numero;
                    var data = "N/D";
                    if (obj.Data != null)
                        data = obj.Data.Value.ToString("dd/MM/yyyy");
                    infoNumeroData.Text = "Fattura N." + numero + " del " + data;
                    var centroCosto = obj.CentroCosto;
                    if (centroCosto != null)
                        infoCentroCosto.Text = centroCosto.Denominazione;
                    var fornitore = obj.Fornitore;
                    if (fornitore != null)
                        infoFornitore.Text = fornitore.RagioneSociale;
                    
                    var totaleFattura = "N/D";
                    if (obj.Totale != null)
                        totaleFattura = obj.Totale.Value.ToString("0.00") + "€";
                    var totalePagamenti = BusinessLogic.Fattura.GetTotalePagamenti(obj, DateTime.Now);
                    infoPagamentoTotale.Text = "Pagato " + totalePagamenti.ToString("0.00")+ "€ su un totale di " + totaleFattura;

                    var stato=BusinessLogic.Fattura.GetStato(obj);
                    if (stato == BusinessLogic.Tipi.StatoFattura.Pagata)
                    {
                        imgStato.Image = "Images.messageConfirm.png";
                    }
                    else if (stato == BusinessLogic.Tipi.StatoFattura.NonPagata)
                    {
                        imgStato.Image = "Images.messageQuestion.png";
                    }
                    else if (stato == BusinessLogic.Tipi.StatoFattura.Insoluta)
                    {
                        imgStato.Image = "Images.messageAlert.png";
                    }

                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void FatturaAcquistoItem_ItemClick(IItem item)
        {
            try
            {
                if (item != null)
                {
                    var space = new FatturaAcquistoModel();
                    space.Title = "DETTAGLI FATTURA DI ACQUISTO";
                    AddSpace(space);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }
	}
}
