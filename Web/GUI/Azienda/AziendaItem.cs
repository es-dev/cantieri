using Library.Code;
using Library.Interfaces;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using WcfService.Dto;
using Web.Code;

namespace Web.GUI.Azienda
{
	public partial class AziendaItem : TemplateItem
	{
        public AziendaItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (AziendaDto)model;
                    var indirizzo = UtilityValidation.GetStringND(obj.Indirizzo);
                    var cap = UtilityValidation.GetStringND(obj.CAP);
                    var comune = UtilityValidation.GetStringND(obj.Comune);
                    var provincia = UtilityValidation.GetStringND(obj.Provincia);
                    var codice = UtilityValidation.GetStringND(obj.Codice);
                    var ragioneSociale = UtilityValidation.GetStringND(obj.RagioneSociale);

                    infoCodice.Text = codice;
                    infoImage.Image = "Images.dashboard.azienda.png";
                    infoDenominazione.Text = ragioneSociale;
                    infoIndirizzo.Text = indirizzo + " - " + cap + " - " + comune + " (" + provincia + ")";
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

       
	}
}
