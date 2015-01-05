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
		}

        public override void BindViewSubTitle(object model)
        {
            try
            {
                infoSubtitleImage.Image = "Images.dashboard.fatturavendita.png";
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
                    editSaldo.Value = obj.Saldo;  
                    editTipoPagamento.Value = obj.TipoPagamento;
                    editTotale.Value = obj.Totale; 
                    var cliente = obj.Cliente;
                    if (cliente != null)
                    {
                        editCliente.Model = cliente;
                        editCliente.Value = cliente.RagioneSociale;
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
                var obj = (WcfService.Dto.FatturaVenditaDto)model;
                obj.Data = editData.Value;
                obj.Descrizione = editDescrizione.Value;
                obj.Imponibile = editImponibile.Value;
                obj.IVA = editIVA.Value;
                obj.Numero = editNumero.Value;
                obj.Saldo = editSaldo.Value;
                obj.TipoPagamento = editTipoPagamento.Value;
                obj.Totale = editTotale.Value;
                obj.ClienteId = (int)editCliente.Id;
                obj.Cliente = (WcfService.Dto.ClienteDto)editCliente.Model;
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
                    editCliente.Value = cliente.RagioneSociale;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

	}
}
