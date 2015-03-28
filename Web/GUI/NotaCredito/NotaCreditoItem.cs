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

namespace Web.GUI.NotaCredito
{
	public partial class NotaCreditoItem : TemplateItem
	{
        public NotaCreditoItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (NotaCreditoDto)model;
                    var totale = UtilityValidation.GetEuro(obj.Totale);
                    var numero = UtilityValidation.GetStringND(obj.Numero);
                    var data = UtilityValidation.GetDataND(obj.Data);
                 
                    infoData.Text = "Resa il " + data;
                    infoImage.Image = "Images.dashboard.notacredito.png";
                    infoCodice.Text = "NC";
                    infoNote.Text = obj.Note;
                    infoImporto.Text = "Totale: " + totale;
                    infoNotaCredito.Text = "Nota di credito N." + numero;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void NotaCreditoItem_ItemClick(IItem item)
        {
            try
            {
                if (item != null)
                {
                    var obj = (NotaCreditoDto)Model;
                    var space = new NotaCreditoModel();
                    var fornitore = obj.Fornitore;
                    space.Title = "NOTA DI CREDITO " + obj.Numero + " - " + fornitore.RagioneSociale;
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
