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

namespace Web.GUI.AnagraficaFornitore
{
	public partial class AnagraficaFornitoreItem : TemplateItem
	{
        public AnagraficaFornitoreItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.AnagraficaFornitoreDto)model;
                    var ragioneSociale = UtilityValidation.GetStringND(obj.RagioneSociale);
                    var codice = UtilityValidation.GetStringND(obj.Codice);
                    var partitaIVA = UtilityValidation.GetStringND(obj.PartitaIva);
                    var indirizzo = UtilityValidation.GetStringND(obj.Indirizzo);
                    var cap = UtilityValidation.GetStringND(obj.CAP);
                    var comune = UtilityValidation.GetStringND(obj.Comune);
                    var provincia = UtilityValidation.GetStringND(obj.Provincia);

                    infoImage.Image = "Images.dashboard.anagraficafornitore.png";
                    infoRagioneSociale.Text = ragioneSociale;
                    infoCodice.Text = codice;
                    infoPartitaIVA.Text = "P.IVA " + partitaIVA;
                    infoIndirizzo.Text = indirizzo + " - " + cap + " - " + comune + " (" + provincia + ")";
                    infoTelefono.Text = "Telefono: " + UtilityValidation.GetStringND(obj.Telefono);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

     
	}
}
