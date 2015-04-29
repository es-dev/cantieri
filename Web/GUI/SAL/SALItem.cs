using BusinessLogic;
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

namespace Web.GUI.SAL
{
	public partial class SALItem : TemplateItem
	{
        public SALItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (SALDto)model;
                    var data = UtilityValidation.GetData(obj.Data);

                    var commessa = GetCommessa(obj);
                    var importoLavori = UtilityValidation.GetEuro(commessa.Importo);
                    var margineOperativo = BusinessLogic.SAL.GetMargineOperativo(obj, commessa);

                    var stato = GetStato(commessa, data);
                    var codice = UtilityValidation.GetStringND(obj.Codice);
                    var _margineOperativo = UtilityValidation.GetEuro(margineOperativo);

                    infoCodice.Text="SAL-" + codice;
                    infoImage.Image = "Images.dashboard.SAL.png";
                    infoCommesssa.Text = "Commessa " + commessa.Codice + " - " + commessa.Denominazione;
                    infoSAL.Text = BusinessLogic.SAL.GetCodifica(obj);
                    infoAndamentoLavoro.Text = "Margine " + _margineOperativo + " su importo lavori di " + importoLavori;
                    imgStato.Image = stato.Image;
                    toolTip.SetToolTip(imgStato, stato.Description);

                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private CommessaDto GetCommessa(SALDto sal)
        {
            try
            {
                if (sal != null)
                {
                    var commessaId = sal.CommessaId;
                    var viewModel = new Commessa.CommessaViewModel();
                    var commessa = (CommessaDto)viewModel.Read(commessaId);
                    return commessa;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private static DescriptionImage GetStato(CommessaDto commessa, DateTime data)
        {
            try
            {
                var image = "";
                var descrizione = "";
                var stato = BusinessLogic.SAL.GetStato(commessa, data);
                if (stato == Tipi.StatoSAL.Positivo)
                {
                    image = "Images.messageConfirm.png";
                    descrizione = "SAL positivo";
                }
                else if (stato == Tipi.StatoSAL.Negativo)
                {
                    image = "Images.messageQuestion.png";
                    descrizione = "SAL negativo, il margine operativo è al di sotto del margine minimo garantito";
                }
                else if (stato == Tipi.StatoSAL.Perdita)
                {
                    image = "Images.messageAlert.png";
                    descrizione = "SAL in perdita, il margine operatvo risulta negativo. Commessa con profitto negativo";
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

      
	}
}
