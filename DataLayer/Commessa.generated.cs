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
		
		private string _oggetto;
		public virtual string Oggetto
		{
			get
			{
				return this._oggetto;
			}
			set
			{
				this._oggetto = value;
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
		
		private decimal? _importoAvanzamento;
		public virtual decimal? ImportoAvanzamento
		{
			get
			{
				return this._importoAvanzamento;
			}
			set
			{
				this._importoAvanzamento = value;
			}
		}
		
		private decimal? _percentuale;
		public virtual decimal? Percentuale
		{
			get
			{
				return this._percentuale;
			}
			set
			{
				this._percentuale = value;
			}
		}
		
		private string _estremiContratto;
		public virtual string EstremiContratto
		{
			get
			{
				return this._estremiContratto;
			}
			set
			{
				this._estremiContratto = value;
			}
		}
		
		private decimal? _importoPerizie;
		public virtual decimal? ImportoPerizie
		{
			get
			{
				return this._importoPerizie;
			}
			set
			{
				this._importoPerizie = value;
			}
		}
		
		private DateTime? _inizioLavori;
		public virtual DateTime? InizioLavori
		{
			get
			{
				return this._inizioLavori;
			}
			set
			{
				this._inizioLavori = value;
			}
		}
		
		private DateTime? _fineLavori;
		public virtual DateTime? FineLavori
		{
			get
			{
				return this._fineLavori;
			}
			set
			{
				this._fineLavori = value;
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
		
		private IList<Committente> _committentes = new List<Committente>();
		public virtual IList<Committente> Committentes
		{
			get
			{
				return this._committentes;
			}
		}
		
	}
}
#pragma warning restore 1591
