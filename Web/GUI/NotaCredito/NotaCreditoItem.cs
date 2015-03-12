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
                    var importo = UtilityValidation.GetEuro(obj.Importo);
                    var codice = UtilityValidation.GetStringND(obj.Codice);
                    var data = UtilityValidation.GetDataND(obj.Data);
                 
                    infoData.Text = "Resa il " + data;
                    infoImage.Image = "Images.dashboard.notacredito.png";
                    infoCodice.Text = "NC";
                    infoNote.Text = obj.Note;
                    infoImporto.Text = "Importo: " + importo;
                    infoNotaCredito.Text = "Nota di credito N." + codice;
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
                    var space = new NotaCreditoModel();
                    space.Title = "DETTAGLI NOTA DI CREDITO";
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
