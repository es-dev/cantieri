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

namespace Web.GUI.Incasso
{
	public partial class IncassoItem : TemplateItem
	{
        public IncassoItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.IncassoDto)model;
                 
                    var importo = UtilityValidation.GetEuro(obj.Importo);
                    var codice = UtilityValidation.GetStringND(obj.Codice);
                    var data = UtilityValidation.GetDataND(obj.Data);
                    
                    infoData.Text = "Incassato il " + data;
                    infoImage.Image = "Images.dashboard.incasso.png";
                    infoCodice.Text = "INC-"+codice;
                    infoTransazionePagamento.Text = obj.TransazionePagamento;
                    infoImporto.Text = "Importo: " + importo;
                    infoIncasso.Text = "Incasso N." + codice;
                    var fatturaVendita = obj.FatturaVendita;
                    infoFatturaVendita.Text = "Fattura " + BusinessLogic.Fattura.GetCodifica(fatturaVendita);
                    if(fatturaVendita!=null)
                    {
                        var committente = fatturaVendita.Committente;
                        var anagraficaCommittente = committente.AnagraficaCommittente;
                        infoCommittente.Text = anagraficaCommittente.RagioneSociale;
                    }

                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

      
	}
}
