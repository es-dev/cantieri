using BusinessLogic;
using Library.Code;
using Library.Code.Enum;
using Library.Interfaces;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Web.Code;

namespace Web.GUI.Commessa
{
	public partial class CommessaItem : TemplateItem
	{
        public CommessaItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.CommessaDto)model;
                    infoImage.Image = "Images.dashboard.commessa.png";
                    var codice = "N/D";
                    if (obj.Codice != null)
                        codice = obj.Codice;
                    infoCodice.Text = codice;
                    var numero = "N/D";
                    if (obj.Numero != null)
                        numero = obj.Numero;
                    var denominazione = "Non definito";
                    if (obj.Denominazione != null)
                        denominazione = obj.Denominazione;
                    infoDenominazione.Text = numero + " - " + denominazione;
                    infoDescrizione.Text = obj.Descrizione;

                    var scadenza = (obj.Scadenza!=null? obj.Scadenza.Value.ToString("dd/MM/yyyy"):"N/D");
                    infoStato.Text = "Scadenza lavori al " + scadenza;

                    var stato = UtilityEnum.GetValue<Tipi.StatoCommessa>(obj.Stato);
                    var image = "";
                    var descrizione = "";
                    if (stato == Tipi.StatoCommessa.Chiusa)
                    {
                        image = "Images.messageConfirm.png";
                        descrizione = "Commessa chiusa";
                    }
                    else if (stato == Tipi.StatoCommessa.InLavorazione)
                    {
                        image = "Images.messageQuestion.png";
                        descrizione = "Commessa in lavorazione";
                    }
                    else if (stato == Tipi.StatoCommessa.Sospesa)
                    {
                        image = "Images.messageAlert.png";
                        descrizione = "Lavori sospesi per la commessa";
                    }
                    else if (stato == Tipi.StatoCommessa.Aperta)
                    {
                        image = "Images.messageInfo.png";
                        descrizione = "Commessa aperta";
                    }
                    toolTip.SetToolTip(imgStato, descrizione);
                    imgStato.Image = image;

                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void CommessaItem_ItemClick(IItem item)
        {
            try
            {
                if (item != null)
                {
                    var space = new CommessaModel();
                    space.Title = "DETTAGLI COMMESSA";
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
