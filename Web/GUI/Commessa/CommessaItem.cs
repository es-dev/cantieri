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
using WcfService.Dto;
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
                    var codice = UtilityValidation.GetStringND(obj.Codice);
                    var numero = UtilityValidation.GetStringND(obj.Numero);
                    var denominazione = UtilityValidation.GetStringND(obj.Denominazione);
                    var descrizione = UtilityValidation.GetStringND(obj.Descrizione);
                    var scadenza = UtilityValidation.GetDataND(obj.Scadenza);
                    var stato = GetStato(obj);

                    infoStatoLavori.Text = "Scadenza lavori al " + scadenza;
                    infoImage.Image = "Images.dashboard.commessa.png";
                    infoCodice.Text = codice;
                    infoDenominazione.Text = numero + " - " + denominazione;
                    infoDescrizione.Text = descrizione;
                    imgStato.Image = stato.Image;
                    toolTip.SetToolTip(imgStato, stato.Description);

                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private static DescriptionImage GetStato(CommessaDto commessa)
        {
            try
            {
                var image = "";
                var descrizione = "";
                var stato = UtilityEnum.GetValue<Tipi.StatoCommessa>(commessa.Stato);
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
                var _stato = new DescriptionImage(descrizione, image);
                return _stato;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private void CommessaItem_ItemClick(IItem item)
        {
            try
            {
                if (item != null)
                {
                    var obj = (WcfService.Dto.CommessaDto)Model;
                    var space = new CommessaModel();
                    space.Title = "COMMESSA " + obj.Codice + " - " + obj.Denominazione; 
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
