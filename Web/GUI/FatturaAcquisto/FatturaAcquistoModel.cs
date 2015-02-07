using BusinessLogic;
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

namespace Web.GUI.FatturaAcquisto
{
	public partial class FatturaAcquistoModel : TemplateModel
	{
        public FatturaAcquistoModel()
		{
			InitializeComponent();
            try
            {
                InitCombo();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
		}

        private void InitCombo()
        {
            try
            {
                var tipiPagamenti = Tipi.GetNames(typeof(Tipi.TipoPagamento));
                editTipoPagamento.Items = tipiPagamenti;
                var scadenzaPagamenti = Tipi.GetNames(typeof(Tipi.ScadenzaPagamento));
                editScadenzaPagamento.Items = scadenzaPagamenti;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void BindViewSubTitle(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.FatturaAcquistoDto)model;
                    infoSubtitleImage.Image = "Images.dashboard.fatturaacquisto.png";
                    infoSubtitle.Text = obj.Numero;
                }
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
                    var obj = (WcfService.Dto.FatturaAcquistoDto)model;
                    editData.Value = obj.Data;
                    editDescrizione.Value = obj.Descrizione;
                    editImponibile.Value = obj.Imponibile; 
                    editIVA.Value = obj.IVA;               
                    editNumero.Value = obj.Numero;
                    editTipoPagamento.Value = obj.TipoPagamento;
                    editScadenzaPagamento.Value = obj.ScadenzaPagamento;
                    editTotale.Value = obj.Totale;
                    editTotalePagamenti.Value = obj.TotalePagamenti;
                    editStato.Value = obj.Stato;
                    var centroCosto=obj.CentroCosto;
                    if (centroCosto!=null)
                    {
                        editCentroCosto.Model = centroCosto;
                        editCentroCosto.Value = "(" + centroCosto.Codice + ") - " + centroCosto.Denominazione;
                    }
                    var fornitore = obj.Fornitore;
                    if (fornitore != null)
                    {
                        editFornitore.Model = fornitore;
                        editFornitore.Value = "(" + fornitore.Codice + ") - " + fornitore.RagioneSociale;
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
                    var obj = (WcfService.Dto.FatturaAcquistoDto)model;
                    obj.Data = editData.Value;
                    obj.Descrizione = editDescrizione.Value;
                    obj.Imponibile = editImponibile.Value;
                    obj.IVA = editIVA.Value;
                    obj.Numero = editNumero.Value;
                    obj.TipoPagamento = editTipoPagamento.Value;
                    obj.ScadenzaPagamento = editScadenzaPagamento.Value;
                    obj.Totale = editTotale.Value;
                    obj.TotalePagamenti = editTotalePagamenti.Value;
                    obj.Stato = editStato.Value;
                    var centroCosto = (WcfService.Dto.CentroCostoDto)editCentroCosto.Model;
                    if(centroCosto!=null)
                        obj.CentroCostoId = centroCosto.Id;
                    var fornitore = (WcfService.Dto.FornitoreDto)editFornitore.Model;
                    if(fornitore!=null)
                        obj.FornitoreId = fornitore.Id;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editFornitore_ComboClick()
        {
            try
            {
                var view = new Fornitore.FornitoreView();
                view.Title = "SELEZIONA UN FORNITORE";
                editFornitore.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editFornitore_ComboConfirm(object model)
        {
            try
            {
                var fornitore = (WcfService.Dto.FornitoreDto)model;
                if (fornitore != null)
                    editFornitore.Value = "(" + fornitore.Codice+ ") - " +fornitore.RagioneSociale;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editCentroCosto_ComboClick()
        {
            try
            {
                var view = new CentroCosto.CentroCostoView();
                view.Title = "SELEZIONA UN CENTRO DI COSTO";
                editCentroCosto.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editCentroCosto_ComboConfirm(object model)
        {
            try
            {
                var centroCosto = (WcfService.Dto.CentroCostoDto)model;
                if (centroCosto != null)
                    editCentroCosto.Value = "(" + centroCosto.Codice + ") - " + centroCosto.Denominazione;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editImponibileIVA_Leave(object sender, EventArgs e)
        {
            try
            {
                CalcolaTotali();
                
                //var imponibile = editImponibile.Value;
                //var iva = editIVA.Value;
                //if (imponibile != null && iva != null)
                //{
                //    var totale = BusinessLogic.Fattura.GetTotale((decimal)imponibile, (decimal)iva);
                //    editTotale.Value = totale;
                //}
                //prelievo valori da grafica in variabili var xxx = editControl.Value
                //invio i dati a BL per calcolo e restituzione valori  ver tot = BL.GetXXXXXX
                //impostazione dei dati in grafica  editControl.Value = tot
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

                var imponibile = editImponibile.Value;
                var iva = editIVA.Value;
                var data = editData.Value;

                if (imponibile != null && iva != null && data!=null)
                {
                    //prelievo dati da DB
                    var obj = (WcfService.Dto.FatturaAcquistoDto)Model;
                    var pagamenti = obj.Pagamentos;
                    
                    var totaleFattura = BusinessLogic.Fattura.GetTotale((decimal)imponibile, (decimal)iva);
                    var totalePagamenti = BusinessLogic.Fattura.GetTotalePagamenti(obj, data.Value);  //ho la funzione a cui passo fattura direttamente

                    //valutazione dell'andamento del lavoro
                    var today= DateTime.Today;
                    var scadenza = obj.Data; //+ objpagamento.scadenza
                    var statoFattura = BusinessLogic.Tipi.StatoFattura.None;
                    if (totalePagamenti >= totaleFattura)
                        statoFattura = BusinessLogic.Tipi.StatoFattura.Pagata;
                    else if (totalePagamenti < totaleFattura && today>scadenza)
                        statoFattura = BusinessLogic.Tipi.StatoFattura.Pagata;
                    else if (totalePagamenti < totaleFattura && today <= scadenza)
                        statoFattura = BusinessLogic.Tipi.StatoFattura.Pagata;


                    //var messaggio = "";
                  //TypeStato stato = TypeStato.None;
                  //  if (totalePagamenti < totaleFattura)
                  //  {
                  //      messaggio = "Andamento del lavoro critico. Il margine aziendale previsto è di " + margine.ToString("0.00€") + " e il margine operativo si attesta al valore critico di " + margineOperativo.ToString("0.00€") + " per un importo lavori di " + importoLavori.ToString("0.00€");
                  //      stato = TypeStato.Critical;
                  //  }
                  //  else if (margineOperativo < margine)
                  //  {
                  //      messaggio = "Andamento del lavoro negativo. Il margine aziendale previsto è di " + margine.ToString("0.00€") + " e il margine operativo si attesta ad un valore inferiore pari a " + margineOperativo.ToString("0.00€") + " per un importo lavori di " + importoLavori.ToString("0.00€");
                  //      stato = TypeStato.Warning;
                  //  }
                  //  else if (margineOperativo >= margine)
                  //  {
                  //      messaggio = "Andamento del lavoro positivo. Il margine aziendale previsto è di " + margine.ToString("0.00€") + " e il margine operativo si attesta a valori superiori pari a " + margineOperativo.ToString("0.00€") + " per un importo lavori di " + importoLavori.ToString("0.00€");
                  //      stato = TypeStato.Normal;
                  //  }

                    //binding dati in GUI
                    //editStato.Value = stato.ToString() + " | " + messaggio;  //todo: da migliorare creando una classe StatoMessaggio oppure utilizzando editStato.ValueStato = stato

                    editTotale.Value = totaleFattura;
                    editTotalePagamenti.Value= totalePagamenti;
                }


            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }


	}
}
