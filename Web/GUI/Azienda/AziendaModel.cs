using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Web.Code;

namespace Web.GUI.Comune
{
	public partial class AziendaModel : TemplateModel
	{
        public AziendaModel()
		{
			InitializeComponent();
		}

        public override void BindViewSubTitle(object model)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void BindView(object model)  
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.ComuneDto)model;
                    editNome.Value = obj.Nome;
                    editDescrizione.Value = obj.Descrizione;
                    editCodiceISTAT.Value = obj.CodiceISTAT;
                    editNumeroSezioni.Value = obj.NumeroSezioni;
                    editProvincia.Value = obj.Provincia;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void BindModel(object model)
        {
            try
            {
                var obj = (WcfService.Dto.ComuneDto)model;
                obj.Nome = editNome.Value;
                obj.Descrizione= editDescrizione.Value;
                obj.CodiceISTAT=editCodiceISTAT.Value;
                obj.NumeroSezioni= editNumeroSezioni.Value;
                obj.Provincia= editProvincia.Value;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

	}
}
