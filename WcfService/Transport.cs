#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using DataLayer;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WcfService.Dto
{
	public interface IDtoWithKey
	{
		string DtoKey { get; set; }
	}
	
	[DataContract(IsReference = true)]
	[KnownType(typeof(CommessaDto))]
	public partial class AziendaDto : IDtoWithKey
	{
		public AziendaDto()
		{
		}
		
		public AziendaDto(int _id, string _denominazione, string _indirizzo, string _cAP, string _comune, string _provincia, string _pIva, int? _dipendenti, string _telefono, string _fax, string _email, string _codice, string _codiceCatastale, IList<CommessaDto> _commessas)
		{
			this.Id = _id;
			this.Denominazione = _denominazione;
			this.Indirizzo = _indirizzo;
			this.CAP = _cAP;
			this.Comune = _comune;
			this.Provincia = _provincia;
			this.PIva = _pIva;
			this.Dipendenti = _dipendenti;
			this.Telefono = _telefono;
			this.Fax = _fax;
			this.Email = _email;
			this.Codice = _codice;
			this.CodiceCatastale = _codiceCatastale;
			this.Commessas = _commessas;
		}
		
		[DataMember]
		public virtual string DtoKey { get; set; }
		
		[DataMember]
		public virtual int Id { get;set; }

		[DataMember]
		public virtual string Denominazione { get;set; }

		[DataMember]
		public virtual string Indirizzo { get;set; }

		[DataMember]
		public virtual string CAP { get;set; }

		[DataMember]
		public virtual string Comune { get;set; }

		[DataMember]
		public virtual string Provincia { get;set; }

		[DataMember]
		public virtual string PIva { get;set; }

		[DataMember]
		public virtual int? Dipendenti { get;set; }

		[DataMember]
		public virtual string Telefono { get;set; }

		[DataMember]
		public virtual string Fax { get;set; }

		[DataMember]
		public virtual string Email { get;set; }

		[DataMember]
		public virtual string Codice { get;set; }

		[DataMember]
		public virtual string CodiceCatastale { get;set; }

		[DataMember]
		public virtual IList<CommessaDto> Commessas { get;set; }

	}
	
	[DataContract(IsReference = true)]
	[KnownType(typeof(AziendaDto))]
	[KnownType(typeof(FornitoreDto))]
	[KnownType(typeof(SALDto))]
	[KnownType(typeof(ClienteDto))]
	public partial class CommessaDto : IDtoWithKey
	{
		public CommessaDto()
		{
		}
		
		public CommessaDto(int _id, int _aziendaId, string _numero, DateTime? _creazione, DateTime? _scadenza, string _descrizione, string _denominazione, string _indirizzo, string _cAP, string _comune, string _provincia, string _riferimento, decimal? _importo, decimal? _margine, string _stato, string _oggetto, string _codiceCatastale, string _codice, decimal? _importoAvanzamento, decimal? _percentuale, string _estremiContratto, decimal? _importoPerizie, DateTime? _inizioLavori, DateTime? _fineLavori, AziendaDto _azienda, IList<FornitoreDto> _fornitores, IList<SALDto> _sALs, ClienteDto _cliente)
		{
			this.Id = _id;
			this.AziendaId = _aziendaId;
			this.Numero = _numero;
			this.Creazione = _creazione;
			this.Scadenza = _scadenza;
			this.Descrizione = _descrizione;
			this.Denominazione = _denominazione;
			this.Indirizzo = _indirizzo;
			this.CAP = _cAP;
			this.Comune = _comune;
			this.Provincia = _provincia;
			this.Riferimento = _riferimento;
			this.Importo = _importo;
			this.Margine = _margine;
			this.Stato = _stato;
			this.Oggetto = _oggetto;
			this.CodiceCatastale = _codiceCatastale;
			this.Codice = _codice;
			this.ImportoAvanzamento = _importoAvanzamento;
			this.Percentuale = _percentuale;
			this.EstremiContratto = _estremiContratto;
			this.ImportoPerizie = _importoPerizie;
			this.InizioLavori = _inizioLavori;
			this.FineLavori = _fineLavori;
			this.Azienda = _azienda;
			this.Fornitores = _fornitores;
			this.SALs = _sALs;
			this.Cliente = _cliente;
		}
		
		[DataMember]
		public virtual string DtoKey { get; set; }
		
		[DataMember]
		public virtual int Id { get;set; }

		[DataMember]
		public virtual int AziendaId { get;set; }

		[DataMember]
		public virtual string Numero { get;set; }

		[DataMember]
		public virtual DateTime? Creazione { get;set; }

		[DataMember]
		public virtual DateTime? Scadenza { get;set; }

		[DataMember]
		public virtual string Descrizione { get;set; }

		[DataMember]
		public virtual string Denominazione { get;set; }

		[DataMember]
		public virtual string Indirizzo { get;set; }

		[DataMember]
		public virtual string CAP { get;set; }

		[DataMember]
		public virtual string Comune { get;set; }

		[DataMember]
		public virtual string Provincia { get;set; }

		[DataMember]
		public virtual string Riferimento { get;set; }

		[DataMember]
		public virtual decimal? Importo { get;set; }

		[DataMember]
		public virtual decimal? Margine { get;set; }

		[DataMember]
		public virtual string Stato { get;set; }

		[DataMember]
		public virtual string Oggetto { get;set; }

		[DataMember]
		public virtual string CodiceCatastale { get;set; }

		[DataMember]
		public virtual string Codice { get;set; }

		[DataMember]
		public virtual decimal? ImportoAvanzamento { get;set; }

		[DataMember]
		public virtual decimal? Percentuale { get;set; }

		[DataMember]
		public virtual string EstremiContratto { get;set; }

		[DataMember]
		public virtual decimal? ImportoPerizie { get;set; }

		[DataMember]
		public virtual DateTime? InizioLavori { get;set; }

		[DataMember]
		public virtual DateTime? FineLavori { get;set; }

		[DataMember]
		public virtual AziendaDto Azienda { get;set; }

		[DataMember]
		public virtual IList<FornitoreDto> Fornitores { get;set; }

		[DataMember]
		public virtual IList<SALDto> SALs { get;set; }

		[DataMember]
		public virtual ClienteDto Cliente { get;set; }

	}
	
	[DataContract(IsReference = true)]
	[KnownType(typeof(CommessaDto))]
	[KnownType(typeof(FatturaAcquistoDto))]
	public partial class FornitoreDto : IDtoWithKey
	{
		public FornitoreDto()
		{
		}
		
		public FornitoreDto(int _id, int _commessaId, string _ragioneSociale, string _indirizzo, string _cAP, string _comune, string _provincia, string _telefono, string _mobile, string _fax, string _email, string _pIva, string _codice, string _codiceCatastale, decimal? _totaleFattureAcquisto, string _stato, decimal? _totalePagamenti, CommessaDto _commessa, IList<FatturaAcquistoDto> _fatturaAcquistos)
		{
			this.Id = _id;
			this.CommessaId = _commessaId;
			this.RagioneSociale = _ragioneSociale;
			this.Indirizzo = _indirizzo;
			this.CAP = _cAP;
			this.Comune = _comune;
			this.Provincia = _provincia;
			this.Telefono = _telefono;
			this.Mobile = _mobile;
			this.Fax = _fax;
			this.Email = _email;
			this.PIva = _pIva;
			this.Codice = _codice;
			this.CodiceCatastale = _codiceCatastale;
			this.TotaleFattureAcquisto = _totaleFattureAcquisto;
			this.Stato = _stato;
			this.TotalePagamenti = _totalePagamenti;
			this.Commessa = _commessa;
			this.FatturaAcquistos = _fatturaAcquistos;
		}
		
		[DataMember]
		public virtual string DtoKey { get; set; }
		
		[DataMember]
		public virtual int Id { get;set; }

		[DataMember]
		public virtual int CommessaId { get;set; }

		[DataMember]
		public virtual string RagioneSociale { get;set; }

		[DataMember]
		public virtual string Indirizzo { get;set; }

		[DataMember]
		public virtual string CAP { get;set; }

		[DataMember]
		public virtual string Comune { get;set; }

		[DataMember]
		public virtual string Provincia { get;set; }

		[DataMember]
		public virtual string Telefono { get;set; }

		[DataMember]
		public virtual string Mobile { get;set; }

		[DataMember]
		public virtual string Fax { get;set; }

		[DataMember]
		public virtual string Email { get;set; }

		[DataMember]
		public virtual string PIva { get;set; }

		[DataMember]
		public virtual string Codice { get;set; }

		[DataMember]
		public virtual string CodiceCatastale { get;set; }

		[DataMember]
		public virtual decimal? TotaleFattureAcquisto { get;set; }

		[DataMember]
		public virtual string Stato { get;set; }

		[DataMember]
		public virtual decimal? TotalePagamenti { get;set; }

		[DataMember]
		public virtual CommessaDto Commessa { get;set; }

		[DataMember]
		public virtual IList<FatturaAcquistoDto> FatturaAcquistos { get;set; }

	}
	
	[DataContract(IsReference = true)]
	[KnownType(typeof(CommessaDto))]
	[KnownType(typeof(FatturaVenditaDto))]
	public partial class ClienteDto : IDtoWithKey
	{
		public ClienteDto()
		{
		}
		
		public ClienteDto(int _id, string _ragioneSociale, string _indirizzo, string _cAP, string _comune, string _provincia, string _telefono, string _mobile, string _fax, string _email, string _pIva, string _codice, string _codiceCatastale, decimal? _totaleFattureVendita, string _stato, decimal? _totaleLiquidazioni, CommessaDto _commessa, IList<FatturaVenditaDto> _fatturaVenditas)
		{
			this.Id = _id;
			this.RagioneSociale = _ragioneSociale;
			this.Indirizzo = _indirizzo;
			this.CAP = _cAP;
			this.Comune = _comune;
			this.Provincia = _provincia;
			this.Telefono = _telefono;
			this.Mobile = _mobile;
			this.Fax = _fax;
			this.Email = _email;
			this.PIva = _pIva;
			this.Codice = _codice;
			this.CodiceCatastale = _codiceCatastale;
			this.TotaleFattureVendita = _totaleFattureVendita;
			this.Stato = _stato;
			this.TotaleLiquidazioni = _totaleLiquidazioni;
			this.Commessa = _commessa;
			this.FatturaVenditas = _fatturaVenditas;
		}
		
		[DataMember]
		public virtual string DtoKey { get; set; }
		
		[DataMember]
		public virtual int Id { get;set; }

		[DataMember]
		public virtual string RagioneSociale { get;set; }

		[DataMember]
		public virtual string Indirizzo { get;set; }

		[DataMember]
		public virtual string CAP { get;set; }

		[DataMember]
		public virtual string Comune { get;set; }

		[DataMember]
		public virtual string Provincia { get;set; }

		[DataMember]
		public virtual string Telefono { get;set; }

		[DataMember]
		public virtual string Mobile { get;set; }

		[DataMember]
		public virtual string Fax { get;set; }

		[DataMember]
		public virtual string Email { get;set; }

		[DataMember]
		public virtual string PIva { get;set; }

		[DataMember]
		public virtual string Codice { get;set; }

		[DataMember]
		public virtual string CodiceCatastale { get;set; }

		[DataMember]
		public virtual decimal? TotaleFattureVendita { get;set; }

		[DataMember]
		public virtual string Stato { get;set; }

		[DataMember]
		public virtual decimal? TotaleLiquidazioni { get;set; }

		[DataMember]
		public virtual CommessaDto Commessa { get;set; }

		[DataMember]
		public virtual IList<FatturaVenditaDto> FatturaVenditas { get;set; }

	}
	
	[DataContract(IsReference = true)]
	[KnownType(typeof(FatturaAcquistoDto))]
	public partial class CentroCostoDto : IDtoWithKey
	{
		public CentroCostoDto()
		{
		}
		
		public CentroCostoDto(int _id, string _codice, string _denominazione, IList<FatturaAcquistoDto> _fatturaAcquistos)
		{
			this.Id = _id;
			this.Codice = _codice;
			this.Denominazione = _denominazione;
			this.FatturaAcquistos = _fatturaAcquistos;
		}
		
		[DataMember]
		public virtual string DtoKey { get; set; }
		
		[DataMember]
		public virtual int Id { get;set; }

		[DataMember]
		public virtual string Codice { get;set; }

		[DataMember]
		public virtual string Denominazione { get;set; }

		[DataMember]
		public virtual IList<FatturaAcquistoDto> FatturaAcquistos { get;set; }

	}
	
	[DataContract(IsReference = true)]
	[KnownType(typeof(CentroCostoDto))]
	[KnownType(typeof(FornitoreDto))]
	[KnownType(typeof(ArticoloDto))]
	[KnownType(typeof(PagamentoDto))]
	public partial class FatturaAcquistoDto : IDtoWithKey
	{
		public FatturaAcquistoDto()
		{
		}
		
		public FatturaAcquistoDto(int _id, int _fornitoreId, DateTime? _data, string _numero, string _tipoPagamento, string _descrizione, decimal? _imponibile, decimal? _iVA, decimal? _totale, string _scadenzaPagamento, int _centroCostoId, decimal? _totalePagamenti, string _stato, CentroCostoDto _centroCosto, FornitoreDto _fornitore, IList<ArticoloDto> _articolos, IList<PagamentoDto> _pagamentos)
		{
			this.Id = _id;
			this.FornitoreId = _fornitoreId;
			this.Data = _data;
			this.Numero = _numero;
			this.TipoPagamento = _tipoPagamento;
			this.Descrizione = _descrizione;
			this.Imponibile = _imponibile;
			this.IVA = _iVA;
			this.Totale = _totale;
			this.ScadenzaPagamento = _scadenzaPagamento;
			this.CentroCostoId = _centroCostoId;
			this.TotalePagamenti = _totalePagamenti;
			this.Stato = _stato;
			this.CentroCosto = _centroCosto;
			this.Fornitore = _fornitore;
			this.Articolos = _articolos;
			this.Pagamentos = _pagamentos;
		}
		
		[DataMember]
		public virtual string DtoKey { get; set; }
		
		[DataMember]
		public virtual int Id { get;set; }

		[DataMember]
		public virtual int FornitoreId { get;set; }

		[DataMember]
		public virtual DateTime? Data { get;set; }

		[DataMember]
		public virtual string Numero { get;set; }

		[DataMember]
		public virtual string TipoPagamento { get;set; }

		[DataMember]
		public virtual string Descrizione { get;set; }

		[DataMember]
		public virtual decimal? Imponibile { get;set; }

		[DataMember]
		public virtual decimal? IVA { get;set; }

		[DataMember]
		public virtual decimal? Totale { get;set; }

		[DataMember]
		public virtual string ScadenzaPagamento { get;set; }

		[DataMember]
		public virtual int CentroCostoId { get;set; }

		[DataMember]
		public virtual decimal? TotalePagamenti { get;set; }

		[DataMember]
		public virtual string Stato { get;set; }

		[DataMember]
		public virtual CentroCostoDto CentroCosto { get;set; }

		[DataMember]
		public virtual FornitoreDto Fornitore { get;set; }

		[DataMember]
		public virtual IList<ArticoloDto> Articolos { get;set; }

		[DataMember]
		public virtual IList<PagamentoDto> Pagamentos { get;set; }

	}
	
	[DataContract(IsReference = true)]
	[KnownType(typeof(FatturaAcquistoDto))]
	public partial class ArticoloDto : IDtoWithKey
	{
		public ArticoloDto()
		{
		}
		
		public ArticoloDto(int _id, int _fatturaAcquistoId, string _codice, string _descrizione, decimal? _quantita, decimal? _sconto, decimal? _costo, decimal? _importo, decimal? _iVA, decimal? _totale, decimal? _prezzoUnitario, FatturaAcquistoDto _fattura)
		{
			this.Id = _id;
			this.FatturaAcquistoId = _fatturaAcquistoId;
			this.Codice = _codice;
			this.Descrizione = _descrizione;
			this.Quantita = _quantita;
			this.Sconto = _sconto;
			this.Costo = _costo;
			this.Importo = _importo;
			this.IVA = _iVA;
			this.Totale = _totale;
			this.PrezzoUnitario = _prezzoUnitario;
			this.Fattura = _fattura;
		}
		
		[DataMember]
		public virtual string DtoKey { get; set; }
		
		[DataMember]
		public virtual int Id { get;set; }

		[DataMember]
		public virtual int FatturaAcquistoId { get;set; }

		[DataMember]
		public virtual string Codice { get;set; }

		[DataMember]
		public virtual string Descrizione { get;set; }

		[DataMember]
		public virtual decimal? Quantita { get;set; }

		[DataMember]
		public virtual decimal? Sconto { get;set; }

		[DataMember]
		public virtual decimal? Costo { get;set; }

		[DataMember]
		public virtual decimal? Importo { get;set; }

		[DataMember]
		public virtual decimal? IVA { get;set; }

		[DataMember]
		public virtual decimal? Totale { get;set; }

		[DataMember]
		public virtual decimal? PrezzoUnitario { get;set; }

		[DataMember]
		public virtual FatturaAcquistoDto Fattura { get;set; }

	}
	
	[DataContract(IsReference = true)]
	[KnownType(typeof(FatturaAcquistoDto))]
	public partial class PagamentoDto : IDtoWithKey
	{
		public PagamentoDto()
		{
		}
		
		public PagamentoDto(int _id, int _fatturaAcquistoId, DateTime? _data, decimal? _importo, string _note, string _codice, string _tipoPagamento, string _descrizione, FatturaAcquistoDto _fatturaAcquisto)
		{
			this.Id = _id;
			this.FatturaAcquistoId = _fatturaAcquistoId;
			this.Data = _data;
			this.Importo = _importo;
			this.Note = _note;
			this.Codice = _codice;
			this.TipoPagamento = _tipoPagamento;
			this.Descrizione = _descrizione;
			this.FatturaAcquisto = _fatturaAcquisto;
		}
		
		[DataMember]
		public virtual string DtoKey { get; set; }
		
		[DataMember]
		public virtual int Id { get;set; }

		[DataMember]
		public virtual int FatturaAcquistoId { get;set; }

		[DataMember]
		public virtual DateTime? Data { get;set; }

		[DataMember]
		public virtual decimal? Importo { get;set; }

		[DataMember]
		public virtual string Note { get;set; }

		[DataMember]
		public virtual string Codice { get;set; }

		[DataMember]
		public virtual string TipoPagamento { get;set; }

		[DataMember]
		public virtual string Descrizione { get;set; }

		[DataMember]
		public virtual FatturaAcquistoDto FatturaAcquisto { get;set; }

	}
	
	[DataContract(IsReference = true)]
	[KnownType(typeof(ClienteDto))]
	[KnownType(typeof(LiquidazioneDto))]
	public partial class FatturaVenditaDto : IDtoWithKey
	{
		public FatturaVenditaDto()
		{
		}
		
		public FatturaVenditaDto(int _id, int _clienteId, DateTime? _data, string _numero, string _tipoPagamento, string _descrizione, decimal? _imponibile, decimal? _iVA, decimal? _totale, string _scadenzaPagamento, string _stato, decimal? _totaleLiquidazioni, ClienteDto _cliente, IList<LiquidazioneDto> _liquidaziones)
		{
			this.Id = _id;
			this.ClienteId = _clienteId;
			this.Data = _data;
			this.Numero = _numero;
			this.TipoPagamento = _tipoPagamento;
			this.Descrizione = _descrizione;
			this.Imponibile = _imponibile;
			this.IVA = _iVA;
			this.Totale = _totale;
			this.ScadenzaPagamento = _scadenzaPagamento;
			this.Stato = _stato;
			this.TotaleLiquidazioni = _totaleLiquidazioni;
			this.Cliente = _cliente;
			this.Liquidaziones = _liquidaziones;
		}
		
		[DataMember]
		public virtual string DtoKey { get; set; }
		
		[DataMember]
		public virtual int Id { get;set; }

		[DataMember]
		public virtual int ClienteId { get;set; }

		[DataMember]
		public virtual DateTime? Data { get;set; }

		[DataMember]
		public virtual string Numero { get;set; }

		[DataMember]
		public virtual string TipoPagamento { get;set; }

		[DataMember]
		public virtual string Descrizione { get;set; }

		[DataMember]
		public virtual decimal? Imponibile { get;set; }

		[DataMember]
		public virtual decimal? IVA { get;set; }

		[DataMember]
		public virtual decimal? Totale { get;set; }

		[DataMember]
		public virtual string ScadenzaPagamento { get;set; }

		[DataMember]
		public virtual string Stato { get;set; }

		[DataMember]
		public virtual decimal? TotaleLiquidazioni { get;set; }

		[DataMember]
		public virtual ClienteDto Cliente { get;set; }

		[DataMember]
		public virtual IList<LiquidazioneDto> Liquidaziones { get;set; }

	}
	
	[DataContract(IsReference = true)]
	[KnownType(typeof(FatturaVenditaDto))]
	public partial class LiquidazioneDto : IDtoWithKey
	{
		public LiquidazioneDto()
		{
		}
		
		public LiquidazioneDto(int _id, int _fatturaVenditaId, DateTime? _data, decimal? _importo, string _note, string _codice, string _tipoPagamento, string _descrizione, FatturaVenditaDto _fatturaVendita)
		{
			this.Id = _id;
			this.FatturaVenditaId = _fatturaVenditaId;
			this.Data = _data;
			this.Importo = _importo;
			this.Note = _note;
			this.Codice = _codice;
			this.TipoPagamento = _tipoPagamento;
			this.Descrizione = _descrizione;
			this.FatturaVendita = _fatturaVendita;
		}
		
		[DataMember]
		public virtual string DtoKey { get; set; }
		
		[DataMember]
		public virtual int Id { get;set; }

		[DataMember]
		public virtual int FatturaVenditaId { get;set; }

		[DataMember]
		public virtual DateTime? Data { get;set; }

		[DataMember]
		public virtual decimal? Importo { get;set; }

		[DataMember]
		public virtual string Note { get;set; }

		[DataMember]
		public virtual string Codice { get;set; }

		[DataMember]
		public virtual string TipoPagamento { get;set; }

		[DataMember]
		public virtual string Descrizione { get;set; }

		[DataMember]
		public virtual FatturaVenditaDto FatturaVendita { get;set; }

	}
	
	[DataContract(IsReference = true)]
	public partial class AnagraficaFornitoreDto : IDtoWithKey
	{
		public AnagraficaFornitoreDto()
		{
		}
		
		public AnagraficaFornitoreDto(int _id, string _ragioneSociale, string _indirizzo, string _cAP, string _comune, string _provincia, string _telefono, string _mobile, string _fax, string _email, string _pIva, string _codice, string _codiceCatastale)
		{
			this.Id = _id;
			this.RagioneSociale = _ragioneSociale;
			this.Indirizzo = _indirizzo;
			this.CAP = _cAP;
			this.Comune = _comune;
			this.Provincia = _provincia;
			this.Telefono = _telefono;
			this.Mobile = _mobile;
			this.Fax = _fax;
			this.Email = _email;
			this.PIva = _pIva;
			this.Codice = _codice;
			this.CodiceCatastale = _codiceCatastale;
		}
		
		[DataMember]
		public virtual string DtoKey { get; set; }
		
		[DataMember]
		public virtual int Id { get;set; }

		[DataMember]
		public virtual string RagioneSociale { get;set; }

		[DataMember]
		public virtual string Indirizzo { get;set; }

		[DataMember]
		public virtual string CAP { get;set; }

		[DataMember]
		public virtual string Comune { get;set; }

		[DataMember]
		public virtual string Provincia { get;set; }

		[DataMember]
		public virtual string Telefono { get;set; }

		[DataMember]
		public virtual string Mobile { get;set; }

		[DataMember]
		public virtual string Fax { get;set; }

		[DataMember]
		public virtual string Email { get;set; }

		[DataMember]
		public virtual string PIva { get;set; }

		[DataMember]
		public virtual string Codice { get;set; }

		[DataMember]
		public virtual string CodiceCatastale { get;set; }

	}
	
	[DataContract(IsReference = true)]
	public partial class AnagraficaClienteDto : IDtoWithKey
	{
		public AnagraficaClienteDto()
		{
		}
		
		public AnagraficaClienteDto(int _id, string _ragioneSociale, string _indirizzo, string _cAP, string _comune, string _provincia, string _telefono, string _mobile, string _fax, string _email, string _pIva, string _codice, string _codiceCatastale)
		{
			this.Id = _id;
			this.RagioneSociale = _ragioneSociale;
			this.Indirizzo = _indirizzo;
			this.CAP = _cAP;
			this.Comune = _comune;
			this.Provincia = _provincia;
			this.Telefono = _telefono;
			this.Mobile = _mobile;
			this.Fax = _fax;
			this.Email = _email;
			this.PIva = _pIva;
			this.Codice = _codice;
			this.CodiceCatastale = _codiceCatastale;
		}
		
		[DataMember]
		public virtual string DtoKey { get; set; }
		
		[DataMember]
		public virtual int Id { get;set; }

		[DataMember]
		public virtual string RagioneSociale { get;set; }

		[DataMember]
		public virtual string Indirizzo { get;set; }

		[DataMember]
		public virtual string CAP { get;set; }

		[DataMember]
		public virtual string Comune { get;set; }

		[DataMember]
		public virtual string Provincia { get;set; }

		[DataMember]
		public virtual string Telefono { get;set; }

		[DataMember]
		public virtual string Mobile { get;set; }

		[DataMember]
		public virtual string Fax { get;set; }

		[DataMember]
		public virtual string Email { get;set; }

		[DataMember]
		public virtual string PIva { get;set; }

		[DataMember]
		public virtual string Codice { get;set; }

		[DataMember]
		public virtual string CodiceCatastale { get;set; }

	}
	
	[DataContract(IsReference = true)]
	[KnownType(typeof(CommessaDto))]
	public partial class SALDto : IDtoWithKey
	{
		public SALDto()
		{
		}
		
		public SALDto(int _id, int _commessaId, DateTime? _data, decimal? _totaleAcquisti, decimal? _totaleVendite, string _denominazione, string _codice, decimal? _totaleIncassi, decimal? _totalePagamenti, string _stato, CommessaDto _commessa)
		{
			this.Id = _id;
			this.CommessaId = _commessaId;
			this.Data = _data;
			this.TotaleAcquisti = _totaleAcquisti;
			this.TotaleVendite = _totaleVendite;
			this.Denominazione = _denominazione;
			this.Codice = _codice;
			this.TotaleIncassi = _totaleIncassi;
			this.TotalePagamenti = _totalePagamenti;
			this.Stato = _stato;
			this.Commessa = _commessa;
		}
		
		[DataMember]
		public virtual string DtoKey { get; set; }
		
		[DataMember]
		public virtual int Id { get;set; }

		[DataMember]
		public virtual int CommessaId { get;set; }

		[DataMember]
		public virtual DateTime? Data { get;set; }

		[DataMember]
		public virtual decimal? TotaleAcquisti { get;set; }

		[DataMember]
		public virtual decimal? TotaleVendite { get;set; }

		[DataMember]
		public virtual string Denominazione { get;set; }

		[DataMember]
		public virtual string Codice { get;set; }

		[DataMember]
		public virtual decimal? TotaleIncassi { get;set; }

		[DataMember]
		public virtual decimal? TotalePagamenti { get;set; }

		[DataMember]
		public virtual string Stato { get;set; }

		[DataMember]
		public virtual CommessaDto Commessa { get;set; }

	}
	
	[DataContract(IsReference = true)]
	public partial class AnagraficaArticoloDto : IDtoWithKey
	{
		public AnagraficaArticoloDto()
		{
		}
		
		public AnagraficaArticoloDto(int _id, string _codice, string _descrizione)
		{
			this.Id = _id;
			this.Codice = _codice;
			this.Descrizione = _descrizione;
		}
		
		[DataMember]
		public virtual string DtoKey { get; set; }
		
		[DataMember]
		public virtual int Id { get;set; }

		[DataMember]
		public virtual string Codice { get;set; }

		[DataMember]
		public virtual string Descrizione { get;set; }

	}
	
}
#pragma warning restore 1591
