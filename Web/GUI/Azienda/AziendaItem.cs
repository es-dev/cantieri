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
                    var obj = (WcfService.Dto.AziendaDto)model;
                    infoCodice.Text = obj.Codice;
                    infoImage.Image = "Images.dashboard.azienda.png";
                    infoDenominazione.Text = obj.Denominazione;
                    var indirizzo = "Non definito";
                    if (obj.Indirizzo != null)
                    {
                        indirizzo = obj.Indirizzo;
                        if (obj.CAP != null)
                            indirizzo += " - " + obj.CAP;
                        if (obj.Comune != null)
                            indirizzo += " - " + obj.Comune;
                        if (obj.Provincia != null)
                            indirizzo += " (" + obj.Provincia + ")";
                    }
                    infoIndirizzo.Text = indirizzo; // obj.Indirizzo + " - " + obj.CAP + " - " + obj.Comune + " (" + obj.Provincia + ")";
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void AziendaItem_ItemClick(IItem item)
        {
            try
            {
                if (item != null)
                {
                    var space = new AziendaModel();
                    space.Title = "DETTAGLI AZIENDA";
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
