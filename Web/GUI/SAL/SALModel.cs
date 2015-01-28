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
                    infoStato.Text = obj.Stato;
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
                    obj.Stato = infoStato.Text;
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
                //prelevo i dati dalla grafica, commessa da editCommessa e la data da editData
                //se ho i dati disponibili inizio il calcolo parzializzato
                var commessa = (WcfService.Dto.CommessaDto)editCommessa.Model;
                var data = editData.Value;
                if (commessa != null && data != null)
                {
                    var fornitori = commessa.Fornitores;
                    var cliente = commessa.Cliente;

                    CalcolaTotaliFatture(fornitori, cliente, data.Value);
                    CalcoloTotalePagamenti(fornitori, cliente, data.Value);

                    //sviluppo i vari totali granularizzando fino ai pagamenti e liquidazione e conservando i totali per fornitore, fattura - cliente, fattura
                    //alla fine imposto i valori nelle editXXX
                    //considero poi la commessa e il margine, valuto il margine operativo = importo commessa - somma fatture acquisto e valuto lock = (margineoperativo < margine)
                    //in stato riporto una descrizione combinando l'andamento e riportando i totali fatture, totali incassi e situazione margine operativo

                    //spostare le funzioni di calcolo nella business logic una volta che dalla grafica hai i modelli Dto
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void CalcoloTotalePagamenti(IList<WcfService.Dto.FornitoreDto> fornitori, WcfService.Dto.ClienteDto cliente, DateTime data)
        {
            try
            {
                var totalePagamenti = BusinessLogic.SAL.GetTotalePagamenti(fornitori, data);
                var totaleIncassi = BusinessLogic.SAL.GetTotaleIncassi(cliente, data);
                editTotalePagamenti.Value = totalePagamenti;
                editTotaleIncassi.Value = totaleIncassi;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

       

        private void CalcolaTotaliFatture(IList<WcfService.Dto.FornitoreDto> fornitori, WcfService.Dto.ClienteDto cliente, DateTime data)
        {
            try
            {
                var totaleAcquisti= BusinessLogic.SAL.GetTotaleFattureAcquisto(fornitori, data);
                var totaleVendite = BusinessLogic.SAL.GetTotaleFattureVendita(cliente, data);

                editTotaleAcquisti.Value= totaleAcquisti;
                editTotaleVendite.Value = totaleVendite;
                //assegni a controlli grafici edit
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

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }


	}
}
