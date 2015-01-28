using Library.Code;
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
	public partial class SALModel : TemplateModel
	{
        public SALModel()
		{
			InitializeComponent();
		}

        public override void BindViewSubTitle(object model)
        {
            try
            {
                infoSubtitleImage.Image = "Images.dashboard.SAL.png";
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
                    var obj = (WcfService.Dto.SALDto)model;
                    editData.Value = obj.Data;
                    editCodice.Value = obj.Codice;
                    editTotaleAcquisti.Value = obj.TotaleAcquisti;
                    editTotaleVendite.Value = obj.TotaleVendite;
                    editTotaleIncassi.Value = obj.TotaleIncassi;
                    editLock.Value = obj.Lock;
                    editDenominazione.Value = obj.Denominazione;
                    var commessa = obj.Commessa;
                    if (commessa != null)
                    {
                        editCommessa.Model = commessa;
                        editCommessa.Value = commessa.Denominazione;
                    }
                    decimal pagamenti = GetPagamenti(obj);
                    if(pagamenti !=null)
                        editTotalePagamenti.Value = pagamenti;// obj.TotalePagamenti;
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
                if (model != null)
                {
                    var obj = (WcfService.Dto.SALDto)model;
                    obj.Data = editData.Value;
                    obj.Codice = editCodice.Value;
                    obj.TotaleAcquisti = editTotaleAcquisti.Value;
                    obj.TotaleVendite = editTotaleVendite.Value;
                    obj.TotaleIncassi = editTotaleIncassi.Value;
                    obj.TotalePagamenti = editTotalePagamenti.Value;
                    obj.Lock = editLock.Value;
                    obj.Denominazione = editDenominazione.Value;
                    var commessa = (WcfService.Dto.CommessaDto)editCommessa.Model;
                    if(commessa!=null)
                        obj.CommessaId = commessa.Id;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editCommessa_ComboClick()
        {
            try
            {
                var view = new Commessa.CommessaView();
                view.Title = "SELEZIONA UNA COMMESSA";
                editCommessa.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
        

        private void editCommessa_ComboConfirm(object model)
        {
            try
            {
                var commessa = (WcfService.Dto.CommessaDto)model;
                if (commessa != null)
                    editCommessa.Value = commessa.Denominazione;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
        private decimal GetPagamenti(WcfService.Dto.SALDto obj) 
        {
            try
            {
                ////todo: va nel viewModel che poi richiama BL???... e qui devo richiamare solo il viewModel???????????
                //var pagamenti = 0;
                //var wcf = new WcfService.Service();
                //var fattureAcquisto = wcf.ReadFattureAcquistoCommessa(obj.Commessa); 
                //if (fattureAcquisto != null)
                //    pagamenti = BusinessLogic.SAL.GetTotalePagamenti(fattureAcquisto);
                //return pagamenti;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }


	}
}
