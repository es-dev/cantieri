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
                    infoCodice.Text = "FA";
                    infoNumero.Text = obj.Numero;
                    infoData.Text = (obj.Data!=null? obj.Data.Value.ToString("dd/MM/yyyy"):"Non Impostata"); //oppure ti fai una funzione GetData
                    // ricorda che bool?, datetime?, e tutte le variabili con xxx? accettano il valore null, quindi vanno controllate e accedi al valore, se non sono nulle, con .Value
                    infoDescrizione.Text = obj.Descrizione;
                    var fornitore = obj.Fornitore;
                    if (fornitore != null)
                        infoFornitore.Text = fornitore.RagioneSociale;
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
                    space.Title = "DETTAGLI FATTURA ACQUISTO";
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
