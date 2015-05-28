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
	public partial class Articolo
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
		
		private decimal? _quantita;
		public virtual decimal? Quantita
		{
			get
			{
				return this._quantita;
			}
			set
			{
				this._quantita = value;
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
		
		private decimal? _costo;
		public virtual decimal? Costo
		{
			get
			{
				return this._costo;
			}
			set
			{
				this._costo = value;
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
		
		private decimal? _prezzoUnitario;
		public virtual decimal? PrezzoUnitario
		{
			get
			{
				return this._prezzoUnitario;
			}
			set
			{
				this._prezzoUnitario = value;
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
		
		private int _anagraficaArticoloId;
		public virtual int AnagraficaArticoloId
		{
			get
			{
				return this._anagraficaArticoloId;
			}
			set
			{
				this._anagraficaArticoloId = value;
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
		
		private AnagraficaArticolo _anagraficaArticolo;
		public virtual AnagraficaArticolo AnagraficaArticolo
		{
			get
			{
				return this._anagraficaArticolo;
			}
			set
			{
				this._anagraficaArticolo = value;
			}
		}
		
	}
}
#pragma warning restore 1591
