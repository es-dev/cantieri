using BusinessLogic;
using Library.Code;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Web.Code;

namespace Web.GUI.FatturaVendita
{
	public partial class FatturaVenditaModel : TemplateModel
	{
        public FatturaVenditaModel()
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
                    var obj = (WcfService.Dto.FatturaVenditaDto)model;
                    infoSubtitleImage.Image = "Images.dashboard.fatturavendita.png";
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
                    var obj = (WcfService.Dto.FatturaVenditaDto)model;
                    editData.Value = obj.Data;
                    editDescrizione.Value = obj.Descrizione;
                    editImponibile.Value = obj.Imponibile;
                    editIVA.Value = obj.IVA;              
                    editNumero.Value = obj.Numero;
                    editTipoPagamento.Value = obj.TipoPagamento;
                    editScadenzaPagamento.Value = obj.ScadenzaPagamento;
                    editTotale.Value = obj.Totale; 
                    var cliente = obj.Cliente;
                    if (cliente != null)
                    {
                        editCliente.Model = cliente;
                        editCliente.Value = "(" + cliente.Codice + ") - " + cliente.RagioneSociale;
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
                    var obj = (WcfService.Dto.FatturaVenditaDto)model;
                    obj.Data = editData.Value;
                    obj.Descrizione = editDescrizione.Value;
                    obj.Imponibile = editImponibile.Value;
                    obj.IVA = editIVA.Value;
                    obj.Numero = editNumero.Value;
                    obj.TipoPagamento = editTipoPagamento.Value;
                    obj.ScadenzaPagamento = editScadenzaPagamento.Value;
                    obj.Totale = editTotale.Value;
                    var cliente = (WcfService.Dto.ClienteDto)editCliente.Model;
                    if(cliente!=null)
                        obj.ClienteId = cliente.Id;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editCliente_ComboClick()
        {
            try
            {
                var view = new Cliente.ClienteView();
                view.Title = "SELEZIONA UN CLIENTE";
                editCliente.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editCliente_ComboConfirm(object model)
        {
            try
            {
                var cliente = (WcfService.Dto.ClienteDto)model;
                if (cliente != null)
                    editCliente.Value = "(" + cliente.Codice + ") - " + cliente.RagioneSociale;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void btnCalcoloTotali_Click(object sender, EventArgs e)
        {
            CalcolaTotali();
        }

        private void CalcolaTotali()
        {
            try
            {
                //prelievo dati da GUI
                var imponibile = editImponibile.Value;
                var iva = editIVA.Value;
                var data = editData.Value;
                var scadenzaPagamento = editScadenzaPagamento.Value;
                var today = DateTime.Today;

                if (imponibile != null && iva != null && data != null)
                {
                    //prelievo dati da DB
                    var obj = (WcfService.Dto.FatturaVenditaDto)Model;

                    var _scadenzaPagamento = (Tipi.ScadenzaPagamento)Enum.Parse(typeof(Tipi.ScadenzaPagamento), scadenzaPagamento);
                    var scadenza = BusinessLogic.Fattura.GetScadenza(data.Value, _scadenzaPagamento);
                    var totaleFattura = BusinessLogic.Fattura.GetTotale((decimal)imponibile, (decimal)iva);
                    var totaleIncassi= BusinessLogic.Fattura.GetTotaleIncassi(obj, today);

                    //valutazione dell'andamento del lavoro
                    //var stato = GetStato(today, scadenza, totaleFattura, totaleIncassi);

                    //binding dati in GUI
                    //editStato.Value = stato.ToString();
                    editTotale.Value = totaleFattura;
                    editTotaleIncassi.Value = totaleIncassi;
                }
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
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

	}
}
