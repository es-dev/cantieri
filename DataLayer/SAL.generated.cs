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
	public partial class SAL
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
		
		private int _commessaId;
		public virtual int CommessaId
		{
			get
			{
				return this._commessaId;
			}
			set
			{
				this._commessaId = value;
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
		
		private decimal? _totaleAcquisti;
		public virtual decimal? TotaleAcquisti
		{
			get
			{
				return this._totaleAcquisti;
			}
			set
			{
				this._totaleAcquisti = value;
			}
		}
		
		private decimal? _totaleVendite;
		public virtual decimal? TotaleVendite
		{
			get
			{
				return this._totaleVendite;
			}
			set
			{
				this._totaleVendite = value;
			}
		}
		
		private bool? _lock;
		public virtual bool? Lock
		{
			get
			{
				return this._lock;
			}
			set
			{
				this._lock = value;
			}
		}
		
		private string _denominazione;
		public virtual string Denominazione
		{
			get
			{
				return this._denominazione;
			}
			set
			{
				this._denominazione = value;
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
		
		private Commessa _commessa;
		public virtual Commessa Commessa
		{
			get
			{
				return this._commessa;
			}
			set
			{
				this._commessa = value;
			}
		}
		
	}
}
#pragma warning restore 1591
