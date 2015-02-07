using Library.Code;
using Library.Code.Enum;
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
                    editStato.Value = obj.Stato; 
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
                    obj.Stato = editStato.Value;
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
                //prelievo dati da GUI
                var commessaId = editCommessa.Id;
                var data = editData.Value;
                if (commessaId != null && data != null)
                {
                    //prelievo dati da DB
                    var viewModelCommessa = new Commessa.CommessaViewModel(this);
                    var commessa = (WcfService.Dto.CommessaDto)viewModelCommessa.Read(commessaId);
                    var fornitori = commessa.Fornitores;
                    var cliente = commessa.Cliente;

                    //calcolo totali da Business Logic
                    var totaleAcquisti = BusinessLogic.SAL.GetTotaleFattureAcquisto(fornitori, data.Value);
                    var totaleVendite = BusinessLogic.SAL.GetTotaleFattureVendita(cliente, data.Value);
                    var totalePagamenti = BusinessLogic.SAL.GetTotalePagamenti(fornitori, data.Value);
                    var totaleIncassi = BusinessLogic.SAL.GetTotaleIncassi(cliente, data.Value);

                    //calcolo e verifica margine operativo = importoLavori - totaleAcquisti
                    var importoLavori = UtilityValidation.GetDecimal(commessa.Importo);
                    var margine = UtilityValidation.GetDecimal(commessa.Margine);
                    var margineOperativo = importoLavori - totaleAcquisti;

                    //valutazione dell'andamento del lavoro
                    var messaggio = "";
                    TypeStato stato = TypeStato.None;
                    if (margineOperativo < 0)
                    {
                        messaggio = "Andamento del lavoro critico. Il margine aziendale previsto è di " + margine.ToString("0.00€") + " e il margine operativo si attesta al valore critico di " + margineOperativo.ToString("0.00€") + " per un importo lavori di " + importoLavori.ToString("0.00€");
                        stato = TypeStato.Critical;
                    }
                    else if (margineOperativo < margine)
                    {
                        messaggio = "Andamento del lavoro negativo. Il margine aziendale previsto è di " + margine.ToString("0.00€") + " e il margine operativo si attesta ad un valore inferiore pari a " + margineOperativo.ToString("0.00€") + " per un importo lavori di " + importoLavori.ToString("0.00€");
                        stato = TypeStato.Warning;
                    }
                    else if (margineOperativo >= margine)
                    {
                        messaggio = "Andamento del lavoro positivo. Il margine aziendale previsto è di " + margine.ToString("0.00€") + " e il margine operativo si attesta a valori superiori pari a " + margineOperativo.ToString("0.00€") + " per un importo lavori di " + importoLavori.ToString("0.00€");
                        stato = TypeStato.Normal;
                    }

                    //binding dati in GUI
                    editStato.Value = stato.ToString() + " | " + messaggio;  //todo: da migliorare creando una classe StatoMessaggio oppure utilizzando editStato.ValueStato = stato
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

        private void editData_Confirm(DateTime? value)
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


	}
}
