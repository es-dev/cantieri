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
	public partial class CentroCosto
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
		
		private IList<FatturaAcquisto> _fatturaAcquistos = new List<FatturaAcquisto>();
		public virtual IList<FatturaAcquisto> FatturaAcquistos
		{
			get
			{
				return this._fatturaAcquistos;
			}
		}
		
	}
}
#pragma warning restore 1591
