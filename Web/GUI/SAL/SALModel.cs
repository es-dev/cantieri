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
                    editDenominazione.Value = obj.Denominazione;
                    editTotalePagamenti.Value = obj.TotalePagamenti;
                    editStato.Text = obj.Stato; //todo: realizzare un controllo di stato che accetta impostazioni di info, warning, alert con immagine
                    var commessa = obj.Commessa;
                    if (commessa != null)
                    {
                        editCommessa.Model = commessa;
                        editCommessa.Value = commessa.Denominazione;
                    }
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
                    obj.Denominazione = editDenominazione.Value;
                    obj.Stato = editStato.Text;
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
                {
                    editCommessa.Value = commessa.Denominazione;
                    CalcolaTotali();
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void CalcolaTotali()
        {
            try
            {
                var commessa = (WcfService.Dto.CommessaDto)editCommessa.Model;
                var data = editData.Value;
                if (commessa != null && data != null)
                {
                    var fornitori = commessa.Fornitores;
                    var cliente = commessa.Cliente;

                    //lettura totali da Business Logic
                    var totaleAcquisti = BusinessLogic.SAL.GetTotaleFattureAcquisto(fornitori, data.Value);
                    var totaleVendite = BusinessLogic.SAL.GetTotaleFattureVendita(cliente, data.Value);
                    var totalePagamenti = BusinessLogic.SAL.GetTotalePagamenti(fornitori, data.Value);
                    var totaleIncassi = BusinessLogic.SAL.GetTotaleIncassi(cliente, data.Value);

                    //calcolo e verifica margine operativo = importoLavori - totaleAcquisti
                    var importoLavori = UtilityValidation.GetDecimal(commessa.Importo);
                    var margine = UtilityValidation.GetDecimal(commessa.Margine);
                    var margineOperativo = importoLavori - totaleAcquisti;

                    //valutazione dell'andamento del lavoro
                    var stato = "";
                    var foreColor = Color.Blue;
                    var backColor = Color.Transparent;
                    if (margineOperativo < 0)
                    {
                        stato = "Andamento del lavoro critico. Il margine aziendale previsto è di " + margine.ToString("0.00€") + " e il margine operativo si attesta al valore critico di " + margineOperativo.ToString("0.00€") + " per un importo lavori di " + importoLavori.ToString("0.00€");
                        foreColor = Color.White;
                        backColor = Color.Red;
                    }
                    else if (margineOperativo < margine)
                    {
                        stato = "Andamento del lavoro negativo. Il margine aziendale previsto è di " + margine.ToString("0.00€") + " e il margine operativo si attesta ad un valore inferiore pari a " + margineOperativo.ToString("0.00€") + " per un importo lavori di " + importoLavori.ToString("0.00€");
                        foreColor = Color.Red;
                    }
                    else if (margineOperativo >= margine)
                        stato = "Andamento del lavoro positivo. Il margine aziendale previsto è di " + margine.ToString("0.00€") + " e il margine operativo si attesta a valori superiori pari a " + margineOperativo.ToString("0.00€") + " per un importo lavori di " + importoLavori.ToString("0.00€");
                    editStato.ForeColor = foreColor;
                    editStato.BackColor = backColor;
                    
                    //binding dati in GUI
                    editStato.Text = stato;
                    editTotaleAcquisti.Value = totaleAcquisti;
                    editTotaleVendite.Value = totaleVendite;
                    editTotalePagamenti.Value = totalePagamenti;
                    editTotaleIncassi.Value = totaleIncassi;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

       
        private void editData_Leave(object sender, EventArgs e)
        {
            try
            {
                CalcolaTotali();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnCalcoloSAL_Click(object sender, EventArgs e)
        {
            try
            {
                CalcolaTotali();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }


	}
}
