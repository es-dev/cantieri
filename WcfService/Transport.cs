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
	[KnownType(typeof(AccountDto))]
	public partial class AziendaDto : IDtoWithKey
	{
		public AziendaDto()
		{
		}
		
		public AziendaDto(int _id, string _ragioneSociale, string _indirizzo, string _cAP, string _comune, string _provincia, string _partitaIva, int? _dipendenti, string _telefono, string _fax, string _email, string _codice, string _codiceCatastale, string _localita, string _note, IList<CommessaDto> _commessas, IList<AccountDto> _accounts)
		{
			this.Id = _id;
			this.RagioneSociale = _ragioneSociale;
			this.Indirizzo = _indirizzo;
			this.CAP = _cAP;
			this.Comune = _comune;
			this.Provincia = _provincia;
			this.PartitaIva = _partitaIva;
			this.Dipendenti = _dipendenti;
			this.Telefono = _telefono;
			this.Fax = _fax;
			this.Email = _email;
			this.Codice = _codice;
			this.CodiceCatastale = _codiceCatastale;
			this.Localita = _localita;
			this.Note = _note;
			this.Commessas = _commessas;
			this.Accounts = _accounts;
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
		public virtual string PartitaIva { get;set; }

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
		public virtual string Localita { get;set; }

		[DataMember]
		public virtual string Note { get;set; }

		[DataMember]
		public virtual IList<CommessaDto> Commessas { get;set; }

		[DataMember]
		public virtual IList<AccountDto> Accounts { get;set; }

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
		
		public CommessaDto(int _id, int _aziendaId, string _numero, DateTime? _creazione, DateTime? _scadenza, string _descrizione, string _denominazione, string _indirizzo, string _cAP, string _comune, string _provincia, string _riferimento, decimal? _importo, decimal? _margine, string _stato, string _oggetto, string _codiceCatastale, string _codice, decimal? _importoAvanzamento, decimal? _percentuale, string _estremiContratto, decimal? _importoPerizie, DateTime? _inizioLavori, DateTime? _fineLavori, string _localita, string _note, AziendaDto _azienda, IList<FornitoreDto> _fornitores, IList<SALDto> _sALs, IList<ClienteDto> _clientes)
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
			this.Localita = _localita;
			this.Note = _note;
			this.Azienda = _azienda;
			this.Fornitores = _fornitores;
			this.SALs = _sALs;
			this.Clientes = _clientes;
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
		public virtual string Localita { get;set; }

		[DataMember]
		public virtual string Note { get;set; }

		[DataMember]
		public virtual AziendaDto Azienda { get;set; }

		[DataMember]
		public virtual IList<FornitoreDto> Fornitores { get;set; }

		[DataMember]
		public virtual IList<SALDto> SALs { get;set; }

		[DataMember]
		public virtual IList<ClienteDto> Clientes { get;set; }

	}
	
	[DataContract(IsReference = true)]
	[KnownType(typeof(CommessaDto))]
	[KnownType(typeof(FatturaAcquistoDto))]
	[KnownType(typeof(NotaCreditoDto))]
	public partial class FornitoreDto : IDtoWithKey
	{
		public FornitoreDto()
		{
		}
		
		public FornitoreDto(int _id, int _commessaId, string _ragioneSociale, string _indirizzo, string _cAP, string _comune, string _provincia, string _telefono, string _mobile, string _fax, string _email, string _partitaIva, string _codice, string _codiceCatastale, decimal? _totaleFattureAcquisto, string _stato, decimal? _totalePagamenti, string _localita, string _note, decimal? _totaleNoteCredito, CommessaDto _commessa, IList<FatturaAcquistoDto> _fatturaAcquistos, IList<NotaCreditoDto> _notaCreditos)
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
			this.PartitaIva = _partitaIva;
			this.Codice = _codice;
			this.CodiceCatastale = _codiceCatastale;
			this.TotaleFattureAcquisto = _totaleFattureAcquisto;
			this.Stato = _stato;
			this.TotalePagamenti = _totalePagamenti;
			this.Localita = _localita;
			this.Note = _note;
			this.TotaleNoteCredito = _totaleNoteCredito;
			this.Commessa = _commessa;
			this.FatturaAcquistos = _fatturaAcquistos;
			this.NotaCreditos = _notaCreditos;
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
		public virtual string PartitaIva { get;set; }

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
		public virtual string Localita { get;set; }

		[DataMember]
		public virtual string Note { get;set; }

		[DataMember]
		public virtual decimal? TotaleNoteCredito { get;set; }

		[DataMember]
		public virtual CommessaDto Commessa { get;set; }

		[DataMember]
		public virtual IList<FatturaAcquistoDto> FatturaAcquistos { get;set; }

		[DataMember]
		public virtual IList<NotaCreditoDto> NotaCreditos { get;set; }

	}
	
	[DataContract(IsReference = true)]
	[KnownType(typeof(CommessaDto))]
	[KnownType(typeof(FatturaVenditaDto))]
	public partial class ClienteDto : IDtoWithKey
	{
		public ClienteDto()
		{
		}
		
		public ClienteDto(int _id, string _ragioneSociale, string _indirizzo, string _cAP, string _comune, string _provincia, string _telefono, string _mobile, string _fax, string _email, string _partitaIva, string _codice, string _codiceCatastale, decimal? _totaleFattureVendita, string _stato, decimal? _totaleLiquidazioni, string _localita, string _note, int _commessaId, CommessaDto _commessa, IList<FatturaVenditaDto> _fatturaVenditas)
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
			this.PartitaIva = _partitaIva;
			this.Codice = _codice;
			this.CodiceCatastale = _codiceCatastale;
			this.TotaleFattureVendita = _totaleFattureVendita;
			this.Stato = _stato;
			this.TotaleLiquidazioni = _totaleLiquidazioni;
			this.Localita = _localita;
			this.Note = _note;
			this.CommessaId = _commessaId;
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
		public virtual string PartitaIva { get;set; }

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
		public virtual string Localita { get;set; }

		[DataMember]
		public virtual string Note { get;set; }

		[DataMember]
		public virtual int CommessaId { get;set; }

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
		
		public CentroCostoDto(int _id, string _codice, string _denominazione, string _note, IList<FatturaAcquistoDto> _fatturaAcquistos)
		{
			this.Id = _id;
			this.Codice = _codice;
			this.Denominazione = _denominazione;
			this.Note = _note;
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
		public virtual string Note { get;set; }

		[DataMember]
		public virtual IList<FatturaAcquistoDto> FatturaAcquistos { get;set; }

	}
	
	[DataContract(IsReference = true)]
	[KnownType(typeof(CentroCostoDto))]
	[KnownType(typeof(FornitoreDto))]
	[KnownType(typeof(ArticoloDto))]
	[KnownType(typeof(PagamentoDto))]
	[KnownType(typeof(PagamentoUnificatoFatturaAcquistoDto))]
	[KnownType(typeof(ResoDto))]
	public partial class FatturaAcquistoDto : IDtoWithKey
	{
		public FatturaAcquistoDto()
		{
		}
		
		public FatturaAcquistoDto(int _id, int _fornitoreId, DateTime? _data, string _numero, string _tipoPagamento, string _descrizione, decimal? _imponibile, decimal? _iVA, decimal? _totale, string _scadenzaPagamento, int _centroCostoId, decimal? _totalePagamenti, string _stato, string _note, decimal? _totaleResi, decimal? _sconto, CentroCostoDto _centroCosto, FornitoreDto _fornitore, IList<ArticoloDto> _articolos, IList<PagamentoDto> _pagamentos, IList<PagamentoUnificatoFatturaAcquistoDto> _pagamentoUnificatoFatturaAcquistos, IList<ResoDto> _resos)
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
			this.Note = _note;
			this.TotaleResi = _totaleResi;
			this.Sconto = _sconto;
			this.CentroCosto = _centroCosto;
			this.Fornitore = _fornitore;
			this.Articolos = _articolos;
			this.Pagamentos = _pagamentos;
			this.PagamentoUnificatoFatturaAcquistos = _pagamentoUnificatoFatturaAcquistos;
			this.Resos = _resos;
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
		public virtual string Note { get;set; }

		[DataMember]
		public virtual decimal? TotaleResi { get;set; }

		[DataMember]
		public virtual decimal? Sconto { get;set; }

		[DataMember]
		public virtual CentroCostoDto CentroCosto { get;set; }

		[DataMember]
		public virtual FornitoreDto Fornitore { get;set; }

		[DataMember]
		public virtual IList<ArticoloDto> Articolos { get;set; }

		[DataMember]
		public virtual IList<PagamentoDto> Pagamentos { get;set; }

		[DataMember]
		public virtual IList<PagamentoUnificatoFatturaAcquistoDto> PagamentoUnificatoFatturaAcquistos { get;set; }

		[DataMember]
		public virtual IList<ResoDto> Resos { get;set; }

	}
	
	[DataContract(IsReference = true)]
	[KnownType(typeof(FatturaAcquistoDto))]
	public partial class ArticoloDto : IDtoWithKey
	{
		public ArticoloDto()
		{
		}
		
		public ArticoloDto(int _id, int _fatturaAcquistoId, string _codice, string _descrizione, decimal? _quantita, decimal? _sconto, decimal? _costo, decimal? _importo, decimal? _iVA, decimal? _totale, decimal? _prezzoUnitario, string _note, FatturaAcquistoDto _fattura)
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
			this.Note = _note;
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
		public virtual string Note { get;set; }

		[DataMember]
		public virtual FatturaAcquistoDto Fattura { get;set; }

	}
	
	[DataContract(IsReference = true)]
	[KnownType(typeof(FatturaAcquistoDto))]
	[KnownType(typeof(PagamentoUnificatoDto))]
	public partial class PagamentoDto : IDtoWithKey
	{
		public PagamentoDto()
		{
		}
		
		public PagamentoDto(int _id, int _fatturaAcquistoId, DateTime? _data, decimal? _importo, string _note, string _codice, string _tipoPagamento, string _descrizione, int? _pagamentoUnificatoId, string _transazionePagamento, FatturaAcquistoDto _fatturaAcquisto, PagamentoUnificatoDto _pagamentoUnificato)
		{
			this.Id = _id;
			this.FatturaAcquistoId = _fatturaAcquistoId;
			this.Data = _data;
			this.Importo = _importo;
			this.Note = _note;
			this.Codice = _codice;
			this.TipoPagamento = _tipoPagamento;
			this.Descrizione = _descrizione;
			this.PagamentoUnificatoId = _pagamentoUnificatoId;
			this.TransazionePagamento = _transazionePagamento;
			this.FatturaAcquisto = _fatturaAcquisto;
			this.PagamentoUnificato = _pagamentoUnificato;
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
		public virtual int? PagamentoUnificatoId { get;set; }

		[DataMember]
		public virtual string TransazionePagamento { get;set; }

		[DataMember]
		public virtual FatturaAcquistoDto FatturaAcquisto { get;set; }

		[DataMember]
		public virtual PagamentoUnificatoDto PagamentoUnificato { get;set; }

	}
	
	[DataContract(IsReference = true)]
	[KnownType(typeof(ClienteDto))]
	[KnownType(typeof(LiquidazioneDto))]
	public partial class FatturaVenditaDto : IDtoWithKey
	{
		public FatturaVenditaDto()
		{
		}
		
		public FatturaVenditaDto(int _id, int _clienteId, DateTime? _data, string _numero, string _tipoPagamento, string _descrizione, decimal? _imponibile, decimal? _iVA, decimal? _totale, string _scadenzaPagamento, string _stato, decimal? _totaleLiquidazioni, string _note, ClienteDto _cliente, IList<LiquidazioneDto> _liquidaziones)
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
			this.Note = _note;
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
		public virtual string Note { get;set; }

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
		
		public LiquidazioneDto(int _id, int _fatturaVenditaId, DateTime? _data, decimal? _importo, string _note, string _codice, string _tipoPagamento, string _descrizione, string _transazionePagamento, FatturaVenditaDto _fatturaVendita)
		{
			this.Id = _id;
			this.FatturaVenditaId = _fatturaVenditaId;
			this.Data = _data;
			this.Importo = _importo;
			this.Note = _note;
			this.Codice = _codice;
			this.TipoPagamento = _tipoPagamento;
			this.Descrizione = _descrizione;
			this.TransazionePagamento = _transazionePagamento;
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
		public virtual string TransazionePagamento { get;set; }

		[DataMember]
		public virtual FatturaVenditaDto FatturaVendita { get;set; }

	}
	
	[DataContract(IsReference = true)]
	public partial class AnagraficaFornitoreDto : IDtoWithKey
	{
		public AnagraficaFornitoreDto()
		{
		}
		
		public AnagraficaFornitoreDto(int _id, string _ragioneSociale, string _indirizzo, string _cAP, string _comune, string _provincia, string _telefono, string _mobile, string _fax, string _email, string _partitaIva, string _codice, string _codiceCatastale, string _localita, string _note)
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
			this.PartitaIva = _partitaIva;
			this.Codice = _codice;
			this.CodiceCatastale = _codiceCatastale;
			this.Localita = _localita;
			this.Note = _note;
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
		public virtual string PartitaIva { get;set; }

		[DataMember]
		public virtual string Codice { get;set; }

		[DataMember]
		public virtual string CodiceCatastale { get;set; }

		[DataMember]
		public virtual string Localita { get;set; }

		[DataMember]
		public virtual string Note { get;set; }

	}
	
	[DataContract(IsReference = true)]
	public partial class AnagraficaClienteDto : IDtoWithKey
	{
		public AnagraficaClienteDto()
		{
		}
		
		public AnagraficaClienteDto(int _id, string _ragioneSociale, string _indirizzo, string _cAP, string _comune, string _provincia, string _telefono, string _mobile, string _fax, string _email, string _partitaIva, string _codice, string _codiceCatastale, string _localita, string _note)
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
			this.PartitaIva = _partitaIva;
			this.Codice = _codice;
			this.CodiceCatastale = _codiceCatastale;
			this.Localita = _localita;
			this.Note = _note;
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
		public virtual string PartitaIva { get;set; }

		[DataMember]
		public virtual string Codice { get;set; }

		[DataMember]
		public virtual string CodiceCatastale { get;set; }

		[DataMember]
		public virtual string Localita { get;set; }

		[DataMember]
		public virtual string Note { get;set; }

	}
	
	[DataContract(IsReference = true)]
	[KnownType(typeof(CommessaDto))]
	public partial class SALDto : IDtoWithKey
	{
		public SALDto()
		{
		}
		
		public SALDto(int _id, int _commessaId, DateTime? _data, decimal? _totaleAcquisti, decimal? _totaleVendite, string _denominazione, string _codice, decimal? _totaleLiquidazioni, decimal? _totalePagamenti, string _stato, string _note, CommessaDto _commessa)
		{
			this.Id = _id;
			this.CommessaId = _commessaId;
			this.Data = _data;
			this.TotaleAcquisti = _totaleAcquisti;
			this.TotaleVendite = _totaleVendite;
			this.Denominazione = _denominazione;
			this.Codice = _codice;
			this.TotaleLiquidazioni = _totaleLiquidazioni;
			this.TotalePagamenti = _totalePagamenti;
			this.Stato = _stato;
			this.Note = _note;
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
		public virtual decimal? TotaleLiquidazioni { get;set; }

		[DataMember]
		public virtual decimal? TotalePagamenti { get;set; }

		[DataMember]
		public virtual string Stato { get;set; }

		[DataMember]
		public virtual string Note { get;set; }

		[DataMember]
		public virtual CommessaDto Commessa { get;set; }

	}
	
	[DataContract(IsReference = true)]
	public partial class AnagraficaArticoloDto : IDtoWithKey
	{
		public AnagraficaArticoloDto()
		{
		}
		
		public AnagraficaArticoloDto(int _id, string _codice, string _descrizione, string _note)
		{
			this.Id = _id;
			this.Codice = _codice;
			this.Descrizione = _descrizione;
			this.Note = _note;
		}
		
		[DataMember]
		public virtual string DtoKey { get; set; }
		
		[DataMember]
		public virtual int Id { get;set; }

		[DataMember]
		public virtual string Codice { get;set; }

		[DataMember]
		public virtual string Descrizione { get;set; }

		[DataMember]
		public virtual string Note { get;set; }

	}
	
	[DataContract(IsReference = true)]
	[KnownType(typeof(AziendaDto))]
	public partial class AccountDto : IDtoWithKey
	{
		public AccountDto()
		{
		}
		
		public AccountDto(int _id, int _aziendaId, string _username, string _password, string _nickname, string _ruolo, string _note, DateTime? _creazione, bool? _abilitato, AziendaDto _azienda)
		{
			this.Id = _id;
			this.AziendaId = _aziendaId;
			this.Username = _username;
			this.Password = _password;
			this.Nickname = _nickname;
			this.Ruolo = _ruolo;
			this.Note = _note;
			this.Creazione = _creazione;
			this.Abilitato = _abilitato;
			this.Azienda = _azienda;
		}
		
		[DataMember]
		public virtual string DtoKey { get; set; }
		
		[DataMember]
		public virtual int Id { get;set; }

		[DataMember]
		public virtual int AziendaId { get;set; }

		[DataMember]
		public virtual string Username { get;set; }

		[DataMember]
		public virtual string Password { get;set; }

		[DataMember]
		public virtual string Nickname { get;set; }

		[DataMember]
		public virtual string Ruolo { get;set; }

		[DataMember]
		public virtual string Note { get;set; }

		[DataMember]
		public virtual DateTime? Creazione { get;set; }

		[DataMember]
		public virtual bool? Abilitato { get;set; }

		[DataMember]
		public virtual AziendaDto Azienda { get;set; }

	}
	
	[DataContract(IsReference = true)]
	public partial class ReportJobDto : IDtoWithKey
	{
		public ReportJobDto()
		{
		}
		
		public ReportJobDto(int _id, DateTime? _creazione, string _codice, string _denominazione, string _tipo, string _codiceFornitore, DateTime? _elaborazione, string _note, string _nomeFile)
		{
			this.Id = _id;
			this.Creazione = _creazione;
			this.Codice = _codice;
			this.Denominazione = _denominazione;
			this.Tipo = _tipo;
			this.CodiceFornitore = _codiceFornitore;
			this.Elaborazione = _elaborazione;
			this.Note = _note;
			this.NomeFile = _nomeFile;
		}
		
		[DataMember]
		public virtual string DtoKey { get; set; }
		
		[DataMember]
		public virtual int Id { get;set; }

		[DataMember]
		public virtual DateTime? Creazione { get;set; }

		[DataMember]
		public virtual string Codice { get;set; }

		[DataMember]
		public virtual string Denominazione { get;set; }

		[DataMember]
		public virtual string Tipo { get;set; }

		[DataMember]
		public virtual string CodiceFornitore { get;set; }

		[DataMember]
		public virtual DateTime? Elaborazione { get;set; }

		[DataMember]
		public virtual string Note { get;set; }

		[DataMember]
		public virtual string NomeFile { get;set; }

	}
	
	[DataContract(IsReference = true)]
	[KnownType(typeof(PagamentoDto))]
	[KnownType(typeof(PagamentoUnificatoFatturaAcquistoDto))]
	public partial class PagamentoUnificatoDto : IDtoWithKey
	{
		public PagamentoUnificatoDto()
		{
		}
		
		public PagamentoUnificatoDto(int _id, DateTime? _data, decimal? _importo, string _note, string _codice, string _tipoPagamento, string _descrizione, string _codiceFornitore, IList<PagamentoDto> _pagamentos, IList<PagamentoUnificatoFatturaAcquistoDto> _pagamentoUnificatoFatturaAcquistos)
		{
			this.Id = _id;
			this.Data = _data;
			this.Importo = _importo;
			this.Note = _note;
			this.Codice = _codice;
			this.TipoPagamento = _tipoPagamento;
			this.Descrizione = _descrizione;
			this.CodiceFornitore = _codiceFornitore;
			this.Pagamentos = _pagamentos;
			this.PagamentoUnificatoFatturaAcquistos = _pagamentoUnificatoFatturaAcquistos;
		}
		
		[DataMember]
		public virtual string DtoKey { get; set; }
		
		[DataMember]
		public virtual int Id { get;set; }

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
		public virtual string CodiceFornitore { get;set; }

		[DataMember]
		public virtual IList<PagamentoDto> Pagamentos { get;set; }

		[DataMember]
		public virtual IList<PagamentoUnificatoFatturaAcquistoDto> PagamentoUnificatoFatturaAcquistos { get;set; }

	}
	
	[DataContract(IsReference = true)]
	[KnownType(typeof(FatturaAcquistoDto))]
	[KnownType(typeof(PagamentoUnificatoDto))]
	public partial class PagamentoUnificatoFatturaAcquistoDto : IDtoWithKey
	{
		public PagamentoUnificatoFatturaAcquistoDto()
		{
		}
		
		public PagamentoUnificatoFatturaAcquistoDto(int _id, int _fatturaAcquistoId, int _pagamentoUnificatoId, decimal? _saldo, string _note, FatturaAcquistoDto _fatturaAcquisto, PagamentoUnificatoDto _pagamentoUnificato)
		{
			this.Id = _id;
			this.FatturaAcquistoId = _fatturaAcquistoId;
			this.PagamentoUnificatoId = _pagamentoUnificatoId;
			this.Saldo = _saldo;
			this.Note = _note;
			this.FatturaAcquisto = _fatturaAcquisto;
			this.PagamentoUnificato = _pagamentoUnificato;
		}
		
		[DataMember]
		public virtual string DtoKey { get; set; }
		
		[DataMember]
		public virtual int Id { get;set; }

		[DataMember]
		public virtual int FatturaAcquistoId { get;set; }

		[DataMember]
		public virtual int PagamentoUnificatoId { get;set; }

		[DataMember]
		public virtual decimal? Saldo { get;set; }

		[DataMember]
		public virtual string Note { get;set; }

		[DataMember]
		public virtual FatturaAcquistoDto FatturaAcquisto { get;set; }

		[DataMember]
		public virtual PagamentoUnificatoDto PagamentoUnificato { get;set; }

	}
	
	[DataContract(IsReference = true)]
	[KnownType(typeof(FornitoreDto))]
	[KnownType(typeof(ResoDto))]
	public partial class NotaCreditoDto : IDtoWithKey
	{
		public NotaCreditoDto()
		{
		}
		
		public NotaCreditoDto(int _id, int _fornitoreId, DateTime? _data, decimal? _imponibile, string _note, string _descrizione, string _numero, decimal? _iVA, decimal? _totale, string _stato, FornitoreDto _fornitore, IList<ResoDto> _resos)
		{
			this.Id = _id;
			this.FornitoreId = _fornitoreId;
			this.Data = _data;
			this.Imponibile = _imponibile;
			this.Note = _note;
			this.Descrizione = _descrizione;
			this.Numero = _numero;
			this.IVA = _iVA;
			this.Totale = _totale;
			this.Stato = _stato;
			this.Fornitore = _fornitore;
			this.Resos = _resos;
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
		public virtual decimal? Imponibile { get;set; }

		[DataMember]
		public virtual string Note { get;set; }

		[DataMember]
		public virtual string Descrizione { get;set; }

		[DataMember]
		public virtual string Numero { get;set; }

		[DataMember]
		public virtual decimal? IVA { get;set; }

		[DataMember]
		public virtual decimal? Totale { get;set; }

		[DataMember]
		public virtual string Stato { get;set; }

		[DataMember]
		public virtual FornitoreDto Fornitore { get;set; }

		[DataMember]
		public virtual IList<ResoDto> Resos { get;set; }

	}
	
	[DataContract(IsReference = true)]
	[KnownType(typeof(NotaCreditoDto))]
	[KnownType(typeof(FatturaAcquistoDto))]
	public partial class ResoDto : IDtoWithKey
	{
		public ResoDto()
		{
		}
		
		public ResoDto(int _id, int _notaCreditoId, DateTime? _data, decimal? _importo, string _note, string _codice, string _descrizione, int _fatturaAcquistoId, decimal? _iVA, decimal? _totale, NotaCreditoDto _notaCredito, FatturaAcquistoDto _fatturaAcquisto)
		{
			this.Id = _id;
			this.NotaCreditoId = _notaCreditoId;
			this.Data = _data;
			this.Importo = _importo;
			this.Note = _note;
			this.Codice = _codice;
			this.Descrizione = _descrizione;
			this.FatturaAcquistoId = _fatturaAcquistoId;
			this.IVA = _iVA;
			this.Totale = _totale;
			this.NotaCredito = _notaCredito;
			this.FatturaAcquisto = _fatturaAcquisto;
		}
		
		[DataMember]
		public virtual string DtoKey { get; set; }
		
		[DataMember]
		public virtual int Id { get;set; }

		[DataMember]
		public virtual int NotaCreditoId { get;set; }

		[DataMember]
		public virtual DateTime? Data { get;set; }

		[DataMember]
		public virtual decimal? Importo { get;set; }

		[DataMember]
		public virtual string Note { get;set; }

		[DataMember]
		public virtual string Codice { get;set; }

		[DataMember]
		public virtual string Descrizione { get;set; }

		[DataMember]
		public virtual int FatturaAcquistoId { get;set; }

		[DataMember]
		public virtual decimal? IVA { get;set; }

		[DataMember]
		public virtual decimal? Totale { get;set; }

		[DataMember]
		public virtual NotaCreditoDto NotaCredito { get;set; }

		[DataMember]
		public virtual FatturaAcquistoDto FatturaAcquisto { get;set; }

	}
	
}
#pragma warning restore 1591
