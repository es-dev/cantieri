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
                    var obj = (WcfService.Dto.SALDto)model;
                    infoImage.Image = "Images.dashboard.SAL.png";
                    var data = "N/D";
                    if (obj.Data != null)
                        data = obj.Data.Value.ToString("dd/MM/yyyy");
                    infoDenominazioneData.Text = obj.Denominazione + " del "+ data;
                    var commessaId = obj.CommessaId;
                    var viewModelCommessa = new Commessa.CommessaViewModel(this);
                    var commessa = (WcfService.Dto.CommessaDto)viewModelCommessa.Read(commessaId);
                    if (commessa != null)
                        infoCommesssa.Text = "Commessa (" + commessa.Codice + ") - " + commessa.Denominazione;

                    var today = DateTime.Today;
                    var fornitori = commessa.Fornitores;
                    var totaleAcquisti = BusinessLogic.SAL.GetTotaleFattureAcquisto(fornitori, today);
                    var importoLavori = UtilityValidation.GetDecimal(commessa.Importo);
                    var margine = UtilityValidation.GetDecimal(commessa.Margine);
                    var margineOperativo = importoLavori - totaleAcquisti;
                    infoAndamentoLavoro.Text = "Margine " + margineOperativo.ToString("0.00") + "€ su importo lavori di " + importoLavori.ToString("0.00") + "€";

                    var stato = BusinessLogic.SAL.GetStato(commessa, today);
                    var image = "";
                    var descrizione = "";
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
                    toolTip.SetToolTip(imgStato, descrizione);
                    imgStato.Image = image;

                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void SALItem_ItemClick(IItem item)
        {
            try
            {
                if (item != null)
                {
                    var space = new SALModel();
                    space.Title = "DETTAGLI SAL";
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
