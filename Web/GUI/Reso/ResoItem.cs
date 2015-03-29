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

namespace Web.GUI.Reso
{
	public partial class ResoItem : TemplateItem
	{
        public ResoItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (ResoDto)model;
                    var totale = UtilityValidation.GetEuro(obj.Totale);
                    var codice = UtilityValidation.GetStringND(obj.Codice);
                    var data = UtilityValidation.GetDataND(obj.Data);
                 
                    infoData.Text = "Pagato il " + data;
                    infoImage.Image = "Images.dashboard.reso.png";
                    infoCodice.Text = "RES";
                    infoNote.Text = obj.Note;
                    infoImporto.Text = "Totale: " + totale;
                    infoReso.Text = "Reso N." + codice;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void ResoItem_ItemClick(IItem item)
        {
            try
            {
                if (item != null)
                {
                    var obj = (ResoDto)Model;
                    var space = new ResoModel();
                    var notaCredito = obj.NotaCredito;
                    space.Title = "RESO " + obj.Codice + " - NOTA DI CREDITO N." + notaCredito.Numero;
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
