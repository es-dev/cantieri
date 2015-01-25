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

namespace Web.GUI.Articolo
{
	public partial class ArticoloItem : TemplateItem
	{
        public ArticoloItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.ArticoloDto)model;
                    infoImage.Image = "Images.dashboard.articolo.png";
                    infoCodice.Text = "ART";
                    var codiceArticolo = "Non definito";
                    if (obj.Codice != null)
                        codiceArticolo = obj.Codice;
                    infoCodiceArticolo.Text = codiceArticolo;
                    var descrizione = "Descrizione non inserita";
                    if (obj.Descrizione != null)
                        descrizione = obj.Descrizione;
                    infoDescrizione.Text = descrizione;
                    var fattura = obj.Fattura;
                    var numeroFattura = "N/D";
                    if (fattura != null)
                        if (fattura.Numero != null)
                            numeroFattura = fattura.Numero;
                    infoFattura.Text = "Fattura N. " + numeroFattura;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void ArticoloItem_ItemClick(IItem item)
        {
            try
            {
                if (item != null)
                {
                    var space = new ArticoloModel();
                    space.Title = "DETTAGLI ARTICOLO";
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
