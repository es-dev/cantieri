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
	public partial class NotaCredito
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
		
		private int _fatturaAcquistoId;
		public virtual int FatturaAcquistoId
		{
			get
			{
				return this._fatturaAcquistoId;
			}
			set
			{
				this._fatturaAcquistoId = value;
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
		
		private decimal? _importo;
		public virtual decimal? Importo
		{
			get
			{
				return this._importo;
			}
			set
			{
				this._importo = value;
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
		
		private string _codice;
		public virtual string Codice
		{
			get
			{
				return this._codice;
			}
			set
			{
				this._codice = value;
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
		
		private FatturaAcquisto _fatturaAcquisto;
		public virtual FatturaAcquisto FatturaAcquisto
		{
			get
			{
				return this._fatturaAcquisto;
			}
			set
			{
				this._fatturaAcquisto = value;
			}
		}
		
	}
}
#pragma warning restore 1591