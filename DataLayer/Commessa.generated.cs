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
	public partial class Commessa
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
		
		private int _aziendaId;
		public virtual int AziendaId
		{
			get
			{
				return this._aziendaId;
			}
			set
			{
				this._aziendaId = value;
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
		
		private DateTime? _creazione;
		public virtual DateTime? Creazione
		{
			get
			{
				return this._creazione;
			}
			set
			{
				this._creazione = value;
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
		
		private string _riferimento;
		public virtual string Riferimento
		{
			get
			{
				return this._riferimento;
			}
			set
			{
				this._riferimento = value;
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
		
		private decimal? _margine;
		public virtual decimal? Margine
		{
			get
			{
				return this._margine;
			}
			set
			{
				this._margine = value;
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
		
		private Azienda _azienda;
		public virtual Azienda Azienda
		{
			get
			{
				return this._azienda;
			}
			set
			{
				this._azienda = value;
			}
		}
		
		private IList<Fornitore> _fornitores = new List<Fornitore>();
		public virtual IList<Fornitore> Fornitores
		{
			get
			{
				return this._fornitores;
			}
		}
		
		private IList<SAL> _sALs = new List<SAL>();
		public virtual IList<SAL> SALs
		{
			get
			{
				return this._sALs;
			}
		}
		
	}
}
#pragma warning restore 1591
