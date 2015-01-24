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

namespace Web.GUI.AnagraficaCliente
{
	public partial class AnagraficaClienteItem : TemplateItem
	{
        public AnagraficaClienteItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.AnagraficaClienteDto)model;
                    infoImage.Image = "Images.dashboard.anagraficacliente.png";
                    var ragioneSociale = "Non definito";
                    if (obj.RagioneSociale != null)
                        ragioneSociale = obj.RagioneSociale;
                    infoRagioneSociale.Text = ragioneSociale;
                    var codice = "N/D";
                    if (obj.Codice != null)
                        codice = obj.Codice;
                    infoCodice.Text = codice;
                    var pIva = "N/D";
                    if (obj.PIva != null)
                        pIva = obj.PIva;
                    infoPartitaIVA.Text = "P.IVA " + pIva;
                    var indirizzo = "Non definito";
                    if (obj.Indirizzo != null)
                    {
                        indirizzo = obj.Indirizzo;
                        if (obj.CAP != null)
                            indirizzo += " - " + obj.CAP;
                        if (obj.Comune != null)
                            indirizzo += " - " + obj.Comune;
                        if(obj.Provincia!=null)
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

        private void AnagraficaClienteItem_ItemClick(IItem item)
        {
            try
            {
                if (item != null)
                {
                    var space = new AnagraficaClienteModel();
                    space.Title = "DETTAGLI ANAGRAFICA CLIENTE";
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
