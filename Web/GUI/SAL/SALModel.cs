using BusinessLogic;
using Library.Code;
using Library.Code.Enum;
using Library.Template.Controls;
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
                var obj = (SALDto)model;
                var codice = UtilityValidation.GetStringND(obj.Codice);
                var denominazione = UtilityValidation.GetStringND(obj.Denominazione);
                infoSubtitle.Text = codice + " - " + denominazione;
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
                    editNote.Value = obj.Note;
                    editTotaleAcquisti.Value = GetTotaleAcquisti(obj);
                    editTotaleVendite.Value = GetTotaleVendite(obj);
                    editTotaleLiquidazioni.Value = GetTotaleLiquidazioni(obj);
                    editDenominazione.Value = obj.Denominazione;
                    editTotalePagamenti.Value = GatTotalePagamenti(obj);
                    editStato.Value = GetStato(obj); 
                    
                    BindViewCommessa(obj.Commessa);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewCommessa(CommessaDto commessa)
        {
            try
            {
                editCommessa.Model = commessa;
                editCommessa.Value = (commessa != null ? commessa.Codice + " - " + commessa.Denominazione : null);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
           
        }

        private string GetStato(SALDto sal)
        {
            try
            {
                var stato = "N/D";
                var commessaId = sal.CommessaId;
                var viewModelCliente = new Commessa.CommessaViewModel(this);
                var commessa = viewModelCliente.Read(commessaId);

                var statoCommessa = commessa.Stato;
                if (statoCommessa == Tipi.StatoCommessa.Chiusa.ToString())
                    stato = sal.Stato;
                else
                {
                    var today = DateTime.Today;
                    var data = sal.Data;
                    var fornitori = commessa.Fornitores;
                    var totaleAcquisti = BusinessLogic.SAL.GetTotaleFattureAcquisto(fornitori, data.Value);
                    var importoLavori = UtilityValidation.GetDecimal(commessa.Importo);
                    var margine = UtilityValidation.GetDecimal(commessa.Margine);
                    var margineOperativo = importoLavori - totaleAcquisti;
                    var statoSAL = BusinessLogic.SAL.GetStato(commessa, data.Value);
                    var _stato = GetStato(importoLavori, margine, margineOperativo, statoSAL);
                    stato = _stato.ToString();
                }

                return stato;

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private decimal GatTotalePagamenti(SALDto sal)
        {
            try
            {
                decimal totalePagamenti = 0;
                var commessaId = sal.CommessaId;
                var viewModelCliente = new Commessa.CommessaViewModel(this);
                var commessa = viewModelCliente.Read(commessaId);
                var fornitori = commessa.Fornitores;
                var statoCommessa = commessa.Stato;
                if (statoCommessa == Tipi.StatoCommessa.Chiusa.ToString())
                    totalePagamenti = UtilityValidation.GetDecimal(sal.TotalePagamenti);
                else
                {
                    var data = sal.Data;
                    totalePagamenti = BusinessLogic.SAL.GetTotalePagamenti(fornitori, data.Value);
                }
                return totalePagamenti;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        private decimal GetTotaleLiquidazioni(SALDto sal)
        {
            try
            {
                decimal totaleLiquidazioni = 0;
                var commessaId = sal.CommessaId;
                var viewModelCliente = new Commessa.CommessaViewModel(this);
                var commessa = viewModelCliente.Read(commessaId);
                var clienti = commessa.Clientes;
                var statoCommessa = commessa.Stato;
                if (statoCommessa == Tipi.StatoCommessa.Chiusa.ToString())
                    totaleLiquidazioni = UtilityValidation.GetDecimal(sal.TotaleLiquidazioni);
                else
                {
                    var data = sal.Data;
                    totaleLiquidazioni = BusinessLogic.SAL.GetTotaleLiquidazioni(clienti, data.Value);
                }
                return totaleLiquidazioni;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        private decimal GetTotaleVendite(SALDto sal)
        {
            try
            {
                decimal totaleVendite = 0;
                var commessaId = sal.CommessaId;
                var viewModelCliente = new Commessa.CommessaViewModel(this);
                var commessa = viewModelCliente.Read(commessaId);
                var clienti = commessa.Clientes;
                var statoCommessa = commessa.Stato;
                if (statoCommessa == Tipi.StatoCommessa.Chiusa.ToString())
                    totaleVendite = UtilityValidation.GetDecimal(sal.TotaleVendite);
                else
                {
                    var data = sal.Data;
                    totaleVendite = BusinessLogic.SAL.GetTotaleFattureVendita(clienti, data.Value);
                }
                return totaleVendite;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        private decimal GetTotaleAcquisti(SALDto sal)
        {
            try
            {
                decimal totaleAcquisti = 0;
                var commessaId = sal.CommessaId;
                var viewModelCliente = new Commessa.CommessaViewModel(this);
                var commessa = viewModelCliente.Read(commessaId);
                var fornitori = commessa.Fornitores;
                var statoCommessa = commessa.Stato;
                if (statoCommessa == Tipi.StatoCommessa.Chiusa.ToString())
                    totaleAcquisti = UtilityValidation.GetDecimal(sal.TotaleAcquisti);
                else
                {
                    var data = sal.Data;
                    totaleAcquisti = BusinessLogic.SAL.GetTotaleFattureAcquisto(fornitori, data.Value);
                }
                return totaleAcquisti;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public override void BindModel(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (SALDto)model;
                    obj.Data = editData.Value;
                    obj.Codice = editCodice.Value;
                    obj.Note = editNote.Value;
                    obj.TotaleAcquisti = editTotaleAcquisti.Value;
                    obj.TotaleVendite = editTotaleVendite.Value;
                    obj.TotaleLiquidazioni = editTotaleLiquidazioni.Value;
                    obj.TotalePagamenti = editTotalePagamenti.Value;
                    obj.Denominazione = editDenominazione.Value;
                    obj.Stato = editStato.Value;
                    var commessa = (CommessaDto)editCommessa.Model;
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
                var commessa = (CommessaDto)model;
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
                var obj = (WcfService.Dto.SALDto)Model;
                var commessaId = editCommessa.Id;
                var data = editData.Value;
                if (commessaId != null && data != null)
                {
                    var viewModelCommessa = new Commessa.CommessaViewModel(this);
                    var commessa = (WcfService.Dto.CommessaDto)viewModelCommessa.Read(commessaId);
                    var fornitori = commessa.Fornitores;
                    var clienti = commessa.Clientes;

                    var totaleAcquisti = BusinessLogic.SAL.GetTotaleFattureAcquisto(fornitori, data.Value);
                    var totaleVendite = BusinessLogic.SAL.GetTotaleFattureVendita(clienti, data.Value);
                    var totalePagamenti = BusinessLogic.SAL.GetTotalePagamenti(fornitori, data.Value);
                    var totaleLiquidazioni = BusinessLogic.SAL.GetTotaleLiquidazioni(clienti, data.Value);
                    var importoLavori = UtilityValidation.GetDecimal(commessa.Importo);
                    var margine = UtilityValidation.GetDecimal(commessa.Margine);
                    var margineOperativo = importoLavori - totaleAcquisti;
                    var statoSAL = BusinessLogic.SAL.GetStato(commessa, data.Value);
                    var _stato = GetStato(importoLavori, margine, margineOperativo, statoSAL);
                   
                    editStato.Value = _stato.ToString();
                    editTotaleAcquisti.Value = totaleAcquisti;
                    editTotaleVendite.Value = totaleVendite;
                    editTotalePagamenti.Value = totalePagamenti;
                    editTotaleLiquidazioni.Value = totaleLiquidazioni;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private StateDescriptionImage GetStato(decimal importoLavori, decimal margine, decimal margineOperativo, Tipi.StatoSAL statoSAL)
        {
            try
            {
                var descrizione = "";
                var stato = TypeState.None;
                var _margine = UtilityValidation.GetEuro(margine);
                var _margineOperativo = UtilityValidation.GetEuro(margineOperativo);
                var _importoLavori = UtilityValidation.GetEuro(importoLavori);

                if (statoSAL== Tipi.StatoSAL.Perdita)
                {
                    descrizione = "Andamento del lavoro critico. Il margine aziendale previsto è di " + _margine + " e il margine operativo si attesta al valore critico di " + _margineOperativo + " per un importo lavori di " + _importoLavori;
                    stato = TypeState.Critical;
                }
                else if (statoSAL == Tipi.StatoSAL.Negativo)
                {
                    descrizione = "Andamento del lavoro negativo. Il margine aziendale previsto è di " + _margine + " e il margine operativo si attesta ad un valore inferiore pari a " + _margineOperativo + " per un importo lavori di " + _importoLavori;
                    stato = TypeState.Warning;
                }
                else if (statoSAL == Tipi.StatoSAL.Positivo)
                {
                    descrizione = "Andamento del lavoro positivo. Il margine aziendale previsto è di " + _margine + " e il margine operativo si attesta a valori superiori pari a " + _margineOperativo + " per un importo lavori di " + _importoLavori;
                    stato = TypeState.Normal;
                }
                var _stato = new StateDescriptionImage(stato, descrizione);
                return _stato;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
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
                if (Editing)
                    CalcolaTotali();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void SetEditing(bool editing, bool deleting)
        {
            try
            {
                base.SetEditing(editing, deleting);
                btnCalcoloSAL.Enabled = editing;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

	}
}
