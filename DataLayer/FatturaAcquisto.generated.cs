#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ClassGenerator.ttinclude code generation file.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;
using DataLayer;

namespace DataLayer	
{
	public partial class FatturaAcquisto
	{
		private int _id;
		public virtual int Id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
			}
		}
		
		private int _fornitoreId;
		public virtual int FornitoreId
		{
			get
			{
				return this._fornitoreId;
			}
			set
			{
				this._fornitoreId = value;
			}
		}
		
		private DateTime? _data;
		public virtual DateTime? Data
		{
			get
			{
				return this._data;
			}
			set
			{
				this._data = value;
			}
		}
		
		private string _numero;
		public virtual string Numero
		{
			get
			{
				return this._numero;
			}
			set
			{
				this._numero = value;
			}
		}
		
		private string _tipoPagamento;
		public virtual string TipoPagamento
		{
			get
			{
				return this._tipoPagamento;
			}
			set
			{
				this._tipoPagamento = value;
			}
		}
		
		private string _descrizione;
		public virtual string Descrizione
		{
			get
			{
				return this._descrizione;
			}
			set
			{
				this._descrizione = value;
			}
		}
		
		private decimal? _imponibile;
		public virtual decimal? Imponibile
		{
			get
			{
				return this._imponibile;
			}
			set
			{
				this._imponibile = value;
			}
		}
		
		private decimal? _iVA;
		public virtual decimal? IVA
		{
			get
			{
				return this._iVA;
			}
			set
			{
				this._iVA = value;
			}
		}
		
		private decimal? _totale;
		public virtual decimal? Totale
		{
			get
			{
				return this._totale;
			}
			set
			{
				this._totale = value;
			}
		}
		
		private string _scadenzaPagamento;
		public virtual string ScadenzaPagamento
		{
			get
			{
				return this._scadenzaPagamento;
			}
			set
			{
				this._scadenzaPagamento = value;
			}
		}
		
		private int _centroCostoId;
		public virtual int CentroCostoId
		{
			get
			{
				return this._centroCostoId;
			}
			set
			{
				this._centroCostoId = value;
			}
		}
		
		private decimal? _totalePagamenti;
		public virtual decimal? TotalePagamenti
		{
			get
			{
				return this._totalePagamenti;
			}
			set
			{
				this._totalePagamenti = value;
			}
		}
		
		private string _stato;
		public virtual string Stato
		{
			get
			{
				return this._stato;
			}
			set
			{
				this._stato = value;
			}
		}
		
		private string _note;
		public virtual string Note
		{
			get
			{
				return this._note;
			}
			set
			{
				this._note = value;
			}
		}
		
		private decimal? _totaleResi;
		public virtual decimal? TotaleResi
		{
			get
			{
				return this._totaleResi;
			}
			set
			{
				this._totaleResi = value;
			}
		}
		
		private decimal? _sconto;
		public virtual decimal? Sconto
		{
			get
			{
				return this._sconto;
			}
			set
			{
				this._sconto = value;
			}
		}
		
		private DateTime? _scadenza;
		public virtual DateTime? Scadenza
		{
			get
			{
				return this._scadenza;
			}
			set
			{
				this._scadenza = value;
			}
		}
		
		private CentroCosto _centroCosto;
		public virtual CentroCosto CentroCosto
		{
			get
			{
				return this._centroCosto;
			}
			set
			{
				this._centroCosto = value;
			}
		}
		
		private Fornitore _fornitore;
		public virtual Fornitore Fornitore
		{
			get
			{
				return this._fornitore;
			}
			set
			{
				this._fornitore = value;
			}
		}
		
		private IList<Articolo> _articolos = new List<Articolo>();
		public virtual IList<Articolo> Articolos
		{
			get
			{
				return this._articolos;
			}
		}
		
		private IList<Pagamento> _pagamentos = new List<Pagamento>();
		public virtual IList<Pagamento> Pagamentos
		{
			get
			{
				return this._pagamentos;
			}
		}
		
		private IList<PagamentoUnificatoFatturaAcquisto> _pagamentoUnificatoFatturaAcquistos = new List<PagamentoUnificatoFatturaAcquisto>();
		public virtual IList<PagamentoUnificatoFatturaAcquisto> PagamentoUnificatoFatturaAcquistos
		{
			get
			{
				return this._pagamentoUnificatoFatturaAcquistos;
			}
		}
		
		private IList<Reso> _resos = new List<Reso>();
		public virtual IList<Reso> Resos
		{
			get
			{
				return this._resos;
			}
		}
		
	}
}
#pragma warning restore 1591
