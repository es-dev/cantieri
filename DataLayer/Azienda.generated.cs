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
	public partial class Azienda
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
		
		private string _indirizzo;
		public virtual string Indirizzo
		{
			get
			{
				return this._indirizzo;
			}
			set
			{
				this._indirizzo = value;
			}
		}
		
		private string _cAP;
		public virtual string CAP
		{
			get
			{
				return this._cAP;
			}
			set
			{
				this._cAP = value;
			}
		}
		
		private string _comune;
		public virtual string Comune
		{
			get
			{
				return this._comune;
			}
			set
			{
				this._comune = value;
			}
		}
		
		private string _provincia;
		public virtual string Provincia
		{
			get
			{
				return this._provincia;
			}
			set
			{
				this._provincia = value;
			}
		}
		
		private string _partitaIva;
		public virtual string PartitaIva
		{
			get
			{
				return this._partitaIva;
			}
			set
			{
				this._partitaIva = value;
			}
		}
		
		private int? _dipendenti;
		public virtual int? Dipendenti
		{
			get
			{
				return this._dipendenti;
			}
			set
			{
				this._dipendenti = value;
			}
		}
		
		private string _telefono;
		public virtual string Telefono
		{
			get
			{
				return this._telefono;
			}
			set
			{
				this._telefono = value;
			}
		}
		
		private string _fax;
		public virtual string Fax
		{
			get
			{
				return this._fax;
			}
			set
			{
				this._fax = value;
			}
		}
		
		private string _email;
		public virtual string Email
		{
			get
			{
				return this._email;
			}
			set
			{
				this._email = value;
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
		
		private string _codiceCatastale;
		public virtual string CodiceCatastale
		{
			get
			{
				return this._codiceCatastale;
			}
			set
			{
				this._codiceCatastale = value;
			}
		}
		
		private string _localita;
		public virtual string Localita
		{
			get
			{
				return this._localita;
			}
			set
			{
				this._localita = value;
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
		
		private IList<Commessa> _commessas = new List<Commessa>();
		public virtual IList<Commessa> Commessas
		{
			get
			{
				return this._commessas;
			}
		}
		
		private IList<Account> _accounts = new List<Account>();
		public virtual IList<Account> Accounts
		{
			get
			{
				return this._accounts;
			}
		}
		
	}
}
#pragma warning restore 1591
