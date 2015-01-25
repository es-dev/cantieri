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

namespace Web.GUI.AnagraficaArticolo
{
	public partial class AnagraficaArticoloItem : TemplateItem
	{
        public AnagraficaArticoloItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.AnagraficaArticoloDto)model;
                    infoImage.Image = "Images.dashboard.anagraficaarticolo.png";
                    infoCodice.Text = "CA";
                    var codiceArticolo = "N/D";
                    if (obj.Codice != null)
                        codiceArticolo = obj.Codice;
                    infoCodiceArticolo.Text = "CODICE ARTICOLO: " + codiceArticolo;

                    infoDescrizione.Text = obj.Descrizione;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void AnagraficaArticoloItem_ItemClick(IItem item)
        {
            try
            {
                if (item != null)
                {
                    var space = new AnagraficaArticoloModel();
                    space.Title = "DETTAGLI ANAGRAFICA ARTICOLO";
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
