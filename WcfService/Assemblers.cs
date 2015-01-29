#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace WcfService.Assemblers
{
	using Telerik.OpenAccess;
	using WcfService.Dto;
	using WcfService.Converters;
	using DataLayer;
	using System;
	using System.Linq;
	using System.Linq.Expressions;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.Serialization;

			
	public partial interface IAssembler<TDto, TEntity>
	    where TEntity : class
	{
	    TDto Assemble(TEntity entity);
	    TEntity Assemble(TEntity entity, TDto dto);
	
	    IEnumerable<TDto> Assemble(IEnumerable<TEntity> entityList);
	    IEnumerable<TEntity> Assemble(IEnumerable<TDto> dtoList);
	}
	
	public abstract class Assembler<TDto, TEntity> : IAssembler<TDto, TEntity>
	    where TEntity : class
	{
	    public abstract TDto Assemble(TEntity domainEntity);
	    public abstract TEntity Assemble(TEntity entity, TDto dto);
	
	    public void AssembleNavigational(TEntity entity, TDto dto)
	    {
	    	this.AssembleReferences(entity, dto);
	    	this.AssembleCollections(entity, dto);
	    }
	
	    public abstract void AssembleReferences(TEntity entity, TDto dto);
	    public abstract void AssembleCollections(TEntity entity, TDto dto);
	
	
	    public virtual IEnumerable<TDto> Assemble(IEnumerable<TEntity> domainEntityList)
	    {
	        List<TDto> dtos = Activator.CreateInstance<List<TDto>>();
	        foreach (TEntity domainEntity in domainEntityList)
	        {
	            dtos.Add(Assemble(domainEntity));
	        }
	        return dtos;
	    }
	
	    public virtual IEnumerable<TEntity> Assemble(IEnumerable<TDto> dtoList)
	    {
	        List<TEntity> domainEntities = Activator.CreateInstance<List<TEntity>>();
	        foreach (TDto dto in dtoList)
	        {
	            domainEntities.Add(Assemble(null, dto));
	        }
	        return domainEntities;
	    }
	}
	
	public partial interface IAziendaAssembler : IAssembler<AziendaDto, Azienda>
	{ 
	
	}
	
	public partial class AziendaAssemblerBase : Assembler<AziendaDto, Azienda>
	{
		/// <summary>
	    /// Invoked after the AziendaDto instance is assembled.
	    /// </summary>
	    /// <param name="dto"><see cref="AziendaDto"/> The Dto instance.</param>
		partial void OnDTOAssembled(AziendaDto dto);
	
		/// <summary>
	    /// Invoked after the Azienda instance is assembled.
	    /// </summary>
	    /// <param name="entity">The <see cref="Azienda"/> instance.</param>
		partial void OnEntityAssembled(Azienda entity);
		
	    public override Azienda Assemble(Azienda entity, AziendaDto dto)
	    {
	        if (entity == null)
	        {
	            entity = new Azienda();
	        }
			
			entity.Id = dto.Id;
			entity.Denominazione = dto.Denominazione;
			entity.Indirizzo = dto.Indirizzo;
			entity.CAP = dto.CAP;
			entity.Comune = dto.Comune;
			entity.Provincia = dto.Provincia;
			entity.PIva = dto.PIva;
			entity.Dipendenti = dto.Dipendenti;
			entity.Telefono = dto.Telefono;
			entity.Fax = dto.Fax;
			entity.Email = dto.Email;
			entity.Codice = dto.Codice;
	        this.OnEntityAssembled(entity);
	        return entity;
	    }
	
	    public override AziendaDto Assemble(Azienda entity)
	    {
	        AziendaDto dto = new AziendaDto();
	        
			ObjectKey key = KeyUtility.Instance.Create(entity);
			dto.DtoKey = KeyUtility.Instance.Convert(key);
			dto.Id = entity.Id;
			dto.Denominazione = entity.Denominazione;
			dto.Indirizzo = entity.Indirizzo;
			dto.CAP = entity.CAP;
			dto.Comune = entity.Comune;
			dto.Provincia = entity.Provincia;
			dto.PIva = entity.PIva;
			dto.Dipendenti = entity.Dipendenti;
			dto.Telefono = entity.Telefono;
			dto.Fax = entity.Fax;
			dto.Email = entity.Email;
			dto.Codice = entity.Codice;
			this.OnDTOAssembled(dto); 
	        return dto;
	    }
	
	    public override void AssembleReferences(Azienda entity, AziendaDto dto)
	    {
	    }
	
	    public override void AssembleCollections(Azienda entity, AziendaDto dto)
	    {
			CommessaAssembler commessaAssembler = new CommessaAssembler();

			dto.Commessas = new List<CommessaDto>();
			foreach (Commessa item in entity.Commessas)
			{
				var dtoItem = commessaAssembler.Assemble(item);
				dtoItem.Azienda = dto;
				dto.Commessas.Add(dtoItem);
			}

	    }
	
	}
	
	
	public partial class AziendaAssembler : AziendaAssemblerBase, IAziendaAssembler
	{
	    
	}
	
	public partial interface ICommessaAssembler : IAssembler<CommessaDto, Commessa>
	{ 
	
	}
	
	public partial class CommessaAssemblerBase : Assembler<CommessaDto, Commessa>
	{
		/// <summary>
	    /// Invoked after the CommessaDto instance is assembled.
	    /// </summary>
	    /// <param name="dto"><see cref="CommessaDto"/> The Dto instance.</param>
		partial void OnDTOAssembled(CommessaDto dto);
	
		/// <summary>
	    /// Invoked after the Commessa instance is assembled.
	    /// </summary>
	    /// <param name="entity">The <see cref="Commessa"/> instance.</param>
		partial void OnEntityAssembled(Commessa entity);
		
	    public override Commessa Assemble(Commessa entity, CommessaDto dto)
	    {
	        if (entity == null)
	        {
	            entity = new Commessa();
	        }
			
			entity.Id = dto.Id;
			entity.AziendaId = dto.AziendaId;
			entity.Numero = dto.Numero;
			entity.Creazione = dto.Creazione;
			entity.Scadenza = dto.Scadenza;
			entity.Descrizione = dto.Descrizione;
			entity.Denominazione = dto.Denominazione;
			entity.Indirizzo = dto.Indirizzo;
			entity.CAP = dto.CAP;
			entity.Comune = dto.Comune;
			entity.Provincia = dto.Provincia;
			entity.Riferimento = dto.Riferimento;
			entity.Importo = dto.Importo;
			entity.Margine = dto.Margine;
			entity.Stato = dto.Stato;
			entity.Codice = dto.Codice;
			entity.ImportoAvanzamento = dto.ImportoAvanzamento;
			entity.Percentuale = dto.Percentuale;
			entity.EstremiContratto = dto.EstremiContratto;
			entity.ImportoPerizie = dto.ImportoPerizie;
			entity.InizioLavori = dto.InizioLavori;
			entity.FineLavori = dto.FineLavori;
			entity.Oggetto = dto.Oggetto;
	        this.OnEntityAssembled(entity);
	        return entity;
	    }
	
	    public override CommessaDto Assemble(Commessa entity)
	    {
	        CommessaDto dto = new CommessaDto();
	        
			ObjectKey key = KeyUtility.Instance.Create(entity);
			dto.DtoKey = KeyUtility.Instance.Convert(key);
			dto.Id = entity.Id;
			dto.AziendaId = entity.AziendaId;
			dto.Numero = entity.Numero;
			dto.Creazione = entity.Creazione;
			dto.Scadenza = entity.Scadenza;
			dto.Descrizione = entity.Descrizione;
			dto.Denominazione = entity.Denominazione;
			dto.Indirizzo = entity.Indirizzo;
			dto.CAP = entity.CAP;
			dto.Comune = entity.Comune;
			dto.Provincia = entity.Provincia;
			dto.Riferimento = entity.Riferimento;
			dto.Importo = entity.Importo;
			dto.Margine = entity.Margine;
			dto.Stato = entity.Stato;
			dto.Codice = entity.Codice;
			dto.ImportoAvanzamento = entity.ImportoAvanzamento;
			dto.Percentuale = entity.Percentuale;
			dto.EstremiContratto = entity.EstremiContratto;
			dto.ImportoPerizie = entity.ImportoPerizie;
			dto.InizioLavori = entity.InizioLavori;
			dto.FineLavori = entity.FineLavori;
			dto.Oggetto = entity.Oggetto;
			this.OnDTOAssembled(dto); 
	        return dto;
	    }
	
	    public override void AssembleReferences(Commessa entity, CommessaDto dto)
	    {
			AziendaAssembler aziendaAssembler = new AziendaAssembler();
			dto.Azienda = aziendaAssembler.Assemble(entity.Azienda);

			ClienteAssembler clienteAssembler = new ClienteAssembler();
			dto.Cliente = clienteAssembler.Assemble(entity.Cliente);

	    }
	
	    public override void AssembleCollections(Commessa entity, CommessaDto dto)
	    {
			FornitoreAssembler fornitoreAssembler = new FornitoreAssembler();

			dto.Fornitores = new List<FornitoreDto>();
			foreach (Fornitore item in entity.Fornitores)
			{
				var dtoItem = fornitoreAssembler.Assemble(item);
				dtoItem.Commessa = dto;
				dto.Fornitores.Add(dtoItem);
			}

			SALAssembler sALAssembler = new SALAssembler();

			dto.SALs = new List<SALDto>();
			foreach (SAL item in entity.SALs)
			{
				var dtoItem = sALAssembler.Assemble(item);
				dtoItem.Commessa = dto;
				dto.SALs.Add(dtoItem);
			}

	    }
	
	}
	
	
	public partial class CommessaAssembler : CommessaAssemblerBase, ICommessaAssembler
	{
	    
	}
	
	public partial interface IFornitoreAssembler : IAssembler<FornitoreDto, Fornitore>
	{ 
	
	}
	
	public partial class FornitoreAssemblerBase : Assembler<FornitoreDto, Fornitore>
	{
		/// <summary>
	    /// Invoked after the FornitoreDto instance is assembled.
	    /// </summary>
	    /// <param name="dto"><see cref="FornitoreDto"/> The Dto instance.</param>
		partial void OnDTOAssembled(FornitoreDto dto);
	
		/// <summary>
	    /// Invoked after the Fornitore instance is assembled.
	    /// </summary>
	    /// <param name="entity">The <see cref="Fornitore"/> instance.</param>
		partial void OnEntityAssembled(Fornitore entity);
		
	    public override Fornitore Assemble(Fornitore entity, FornitoreDto dto)
	    {
	        if (entity == null)
	        {
	            entity = new Fornitore();
	        }
			
			entity.Id = dto.Id;
			entity.CommessaId = dto.CommessaId;
			entity.RagioneSociale = dto.RagioneSociale;
			entity.Indirizzo = dto.Indirizzo;
			entity.CAP = dto.CAP;
			entity.Comune = dto.Comune;
			entity.Provincia = dto.Provincia;
			entity.Telefono = dto.Telefono;
			entity.Mobile = dto.Mobile;
			entity.Fax = dto.Fax;
			entity.Email = dto.Email;
			entity.PIva = dto.PIva;
			entity.Codice = dto.Codice;
	        this.OnEntityAssembled(entity);
	        return entity;
	    }
	
	    public override FornitoreDto Assemble(Fornitore entity)
	    {
	        FornitoreDto dto = new FornitoreDto();
	        
			ObjectKey key = KeyUtility.Instance.Create(entity);
			dto.DtoKey = KeyUtility.Instance.Convert(key);
			dto.Id = entity.Id;
			dto.CommessaId = entity.CommessaId;
			dto.RagioneSociale = entity.RagioneSociale;
			dto.Indirizzo = entity.Indirizzo;
			dto.CAP = entity.CAP;
			dto.Comune = entity.Comune;
			dto.Provincia = entity.Provincia;
			dto.Telefono = entity.Telefono;
			dto.Mobile = entity.Mobile;
			dto.Fax = entity.Fax;
			dto.Email = entity.Email;
			dto.PIva = entity.PIva;
			dto.Codice = entity.Codice;
			this.OnDTOAssembled(dto); 
	        return dto;
	    }
	
	    public override void AssembleReferences(Fornitore entity, FornitoreDto dto)
	    {
			CommessaAssembler commessaAssembler = new CommessaAssembler();
			dto.Commessa = commessaAssembler.Assemble(entity.Commessa);

	    }
	
	    public override void AssembleCollections(Fornitore entity, FornitoreDto dto)
	    {
			FatturaAcquistoAssembler fatturaAcquistoAssembler = new FatturaAcquistoAssembler();

			dto.Fatturas = new List<FatturaAcquistoDto>();
			foreach (FatturaAcquisto item in entity.Fatturas)
			{
				var dtoItem = fatturaAcquistoAssembler.Assemble(item);
				dtoItem.Fornitore = dto;
				dto.Fatturas.Add(dtoItem);
			}

	    }
	
	}
	
	
	public partial class FornitoreAssembler : FornitoreAssemblerBase, IFornitoreAssembler
	{
	    
	}
	
	public partial interface IClienteAssembler : IAssembler<ClienteDto, Cliente>
	{ 
	
	}
	
	public partial class ClienteAssemblerBase : Assembler<ClienteDto, Cliente>
	{
		/// <summary>
	    /// Invoked after the ClienteDto instance is assembled.
	    /// </summary>
	    /// <param name="dto"><see cref="ClienteDto"/> The Dto instance.</param>
		partial void OnDTOAssembled(ClienteDto dto);
	
		/// <summary>
	    /// Invoked after the Cliente instance is assembled.
	    /// </summary>
	    /// <param name="entity">The <see cref="Cliente"/> instance.</param>
		partial void OnEntityAssembled(Cliente entity);
		
	    public override Cliente Assemble(Cliente entity, ClienteDto dto)
	    {
	        if (entity == null)
	        {
	            entity = new Cliente();
	        }
			
			entity.Id = dto.Id;
			entity.RagioneSociale = dto.RagioneSociale;
			entity.Indirizzo = dto.Indirizzo;
			entity.CAP = dto.CAP;
			entity.Comune = dto.Comune;
			entity.Provincia = dto.Provincia;
			entity.Telefono = dto.Telefono;
			entity.Mobile = dto.Mobile;
			entity.Fax = dto.Fax;
			entity.Email = dto.Email;
			entity.PIva = dto.PIva;
			entity.Codice = dto.Codice;
	        this.OnEntityAssembled(entity);
	        return entity;
	    }
	
	    public override ClienteDto Assemble(Cliente entity)
	    {
	        ClienteDto dto = new ClienteDto();
	        
			ObjectKey key = KeyUtility.Instance.Create(entity);
			dto.DtoKey = KeyUtility.Instance.Convert(key);
			dto.Id = entity.Id;
			dto.RagioneSociale = entity.RagioneSociale;
			dto.Indirizzo = entity.Indirizzo;
			dto.CAP = entity.CAP;
			dto.Comune = entity.Comune;
			dto.Provincia = entity.Provincia;
			dto.Telefono = entity.Telefono;
			dto.Mobile = entity.Mobile;
			dto.Fax = entity.Fax;
			dto.Email = entity.Email;
			dto.PIva = entity.PIva;
			dto.Codice = entity.Codice;
			this.OnDTOAssembled(dto); 
	        return dto;
	    }
	
	    public override void AssembleReferences(Cliente entity, ClienteDto dto)
	    {
			CommessaAssembler commessaAssembler = new CommessaAssembler();
			dto.Commessa = commessaAssembler.Assemble(entity.Commessa);

	    }
	
	    public override void AssembleCollections(Cliente entity, ClienteDto dto)
	    {
			FatturaVenditaAssembler fatturaVenditaAssembler = new FatturaVenditaAssembler();

			dto.FatturaVenditas = new List<FatturaVenditaDto>();
			foreach (FatturaVendita item in entity.FatturaVenditas)
			{
				var dtoItem = fatturaVenditaAssembler.Assemble(item);
				dtoItem.Cliente = dto;
				dto.FatturaVenditas.Add(dtoItem);
			}

	    }
	
	}
	
	
	public partial class ClienteAssembler : ClienteAssemblerBase, IClienteAssembler
	{
	    
	}
	
	public partial interface ICentroCostoAssembler : IAssembler<CentroCostoDto, CentroCosto>
	{ 
	
	}
	
	public partial class CentroCostoAssemblerBase : Assembler<CentroCostoDto, CentroCosto>
	{
		/// <summary>
	    /// Invoked after the CentroCostoDto instance is assembled.
	    /// </summary>
	    /// <param name="dto"><see cref="CentroCostoDto"/> The Dto instance.</param>
		partial void OnDTOAssembled(CentroCostoDto dto);
	
		/// <summary>
	    /// Invoked after the CentroCosto instance is assembled.
	    /// </summary>
	    /// <param name="entity">The <see cref="CentroCosto"/> instance.</param>
		partial void OnEntityAssembled(CentroCosto entity);
		
	    public override CentroCosto Assemble(CentroCosto entity, CentroCostoDto dto)
	    {
	        if (entity == null)
	        {
	            entity = new CentroCosto();
	        }
			
			entity.Id = dto.Id;
			entity.Codice = dto.Codice;
			entity.Denominazione = dto.Denominazione;
	        this.OnEntityAssembled(entity);
	        return entity;
	    }
	
	    public override CentroCostoDto Assemble(CentroCosto entity)
	    {
	        CentroCostoDto dto = new CentroCostoDto();
	        
			ObjectKey key = KeyUtility.Instance.Create(entity);
			dto.DtoKey = KeyUtility.Instance.Convert(key);
			dto.Id = entity.Id;
			dto.Codice = entity.Codice;
			dto.Denominazione = entity.Denominazione;
			this.OnDTOAssembled(dto); 
	        return dto;
	    }
	
	    public override void AssembleReferences(CentroCosto entity, CentroCostoDto dto)
	    {
	    }
	
	    public override void AssembleCollections(CentroCosto entity, CentroCostoDto dto)
	    {
			FatturaAcquistoAssembler fatturaAcquistoAssembler = new FatturaAcquistoAssembler();

			dto.FatturaAcquistos = new List<FatturaAcquistoDto>();
			foreach (FatturaAcquisto item in entity.FatturaAcquistos)
			{
				var dtoItem = fatturaAcquistoAssembler.Assemble(item);
				dtoItem.CentroCosto = dto;
				dto.FatturaAcquistos.Add(dtoItem);
			}

	    }
	
	}
	
	
	public partial class CentroCostoAssembler : CentroCostoAssemblerBase, ICentroCostoAssembler
	{
	    
	}
	
	public partial interface IFatturaAcquistoAssembler : IAssembler<FatturaAcquistoDto, FatturaAcquisto>
	{ 
	
	}
	
	public partial class FatturaAcquistoAssemblerBase : Assembler<FatturaAcquistoDto, FatturaAcquisto>
	{
		/// <summary>
	    /// Invoked after the FatturaAcquistoDto instance is assembled.
	    /// </summary>
	    /// <param name="dto"><see cref="FatturaAcquistoDto"/> The Dto instance.</param>
		partial void OnDTOAssembled(FatturaAcquistoDto dto);
	
		/// <summary>
	    /// Invoked after the FatturaAcquisto instance is assembled.
	    /// </summary>
	    /// <param name="entity">The <see cref="FatturaAcquisto"/> instance.</param>
		partial void OnEntityAssembled(FatturaAcquisto entity);
		
	    public override FatturaAcquisto Assemble(FatturaAcquisto entity, FatturaAcquistoDto dto)
	    {
	        if (entity == null)
	        {
	            entity = new FatturaAcquisto();
	        }
			
			entity.Id = dto.Id;
			entity.FornitoreId = dto.FornitoreId;
			entity.Data = dto.Data;
			entity.Numero = dto.Numero;
			entity.TipoPagamento = dto.TipoPagamento;
			entity.Descrizione = dto.Descrizione;
			entity.Imponibile = dto.Imponibile;
			entity.IVA = dto.IVA;
			entity.Totale = dto.Totale;
			entity.Saldo = dto.Saldo;
			entity.ScadenzaPagamento = dto.ScadenzaPagamento;
			entity.CentroCostoId = dto.CentroCostoId;
	        this.OnEntityAssembled(entity);
	        return entity;
	    }
	
	    public override FatturaAcquistoDto Assemble(FatturaAcquisto entity)
	    {
	        FatturaAcquistoDto dto = new FatturaAcquistoDto();
	        
			ObjectKey key = KeyUtility.Instance.Create(entity);
			dto.DtoKey = KeyUtility.Instance.Convert(key);
			dto.Id = entity.Id;
			dto.FornitoreId = entity.FornitoreId;
			dto.Data = entity.Data;
			dto.Numero = entity.Numero;
			dto.TipoPagamento = entity.TipoPagamento;
			dto.Descrizione = entity.Descrizione;
			dto.Imponibile = entity.Imponibile;
			dto.IVA = entity.IVA;
			dto.Totale = entity.Totale;
			dto.Saldo = entity.Saldo;
			dto.ScadenzaPagamento = entity.ScadenzaPagamento;
			dto.CentroCostoId = entity.CentroCostoId;
			this.OnDTOAssembled(dto); 
	        return dto;
	    }
	
	    public override void AssembleReferences(FatturaAcquisto entity, FatturaAcquistoDto dto)
	    {
			FornitoreAssembler fornitoreAssembler = new FornitoreAssembler();
			dto.Fornitore = fornitoreAssembler.Assemble(entity.Fornitore);

			CentroCostoAssembler centroCostoAssembler = new CentroCostoAssembler();
			dto.CentroCosto = centroCostoAssembler.Assemble(entity.CentroCosto);

	    }
	
	    public override void AssembleCollections(FatturaAcquisto entity, FatturaAcquistoDto dto)
	    {
			ArticoloAssembler articoloAssembler = new ArticoloAssembler();

			dto.Articolos = new List<ArticoloDto>();
			foreach (Articolo item in entity.Articolos)
			{
				var dtoItem = articoloAssembler.Assemble(item);
				dtoItem.Fattura = dto;
				dto.Articolos.Add(dtoItem);
			}

			PagamentoAssembler pagamentoAssembler = new PagamentoAssembler();

			dto.Pagamentos = new List<PagamentoDto>();
			foreach (Pagamento item in entity.Pagamentos)
			{
				var dtoItem = pagamentoAssembler.Assemble(item);
				dtoItem.FatturaAcquisto = dto;
				dto.Pagamentos.Add(dtoItem);
			}

	    }
	
	}
	
	
	public partial class FatturaAcquistoAssembler : FatturaAcquistoAssemblerBase, IFatturaAcquistoAssembler
	{
	    
	}
	
	public partial interface IArticoloAssembler : IAssembler<ArticoloDto, Articolo>
	{ 
	
	}
	
	public partial class ArticoloAssemblerBase : Assembler<ArticoloDto, Articolo>
	{
		/// <summary>
	    /// Invoked after the ArticoloDto instance is assembled.
	    /// </summary>
	    /// <param name="dto"><see cref="ArticoloDto"/> The Dto instance.</param>
		partial void OnDTOAssembled(ArticoloDto dto);
	
		/// <summary>
	    /// Invoked after the Articolo instance is assembled.
	    /// </summary>
	    /// <param name="entity">The <see cref="Articolo"/> instance.</param>
		partial void OnEntityAssembled(Articolo entity);
		
	    public override Articolo Assemble(Articolo entity, ArticoloDto dto)
	    {
	        if (entity == null)
	        {
	            entity = new Articolo();
	        }
			
			entity.Id = dto.Id;
			entity.FatturaAcquistoId = dto.FatturaAcquistoId;
			entity.Codice = dto.Codice;
			entity.Descrizione = dto.Descrizione;
			entity.Quantita = dto.Quantita;
			entity.Sconto = dto.Sconto;
			entity.Costo = dto.Costo;
			entity.Importo = dto.Importo;
			entity.IVA = dto.IVA;
			entity.Totale = dto.Totale;
			entity.PrezzoUnitario = dto.PrezzoUnitario;
	        this.OnEntityAssembled(entity);
	        return entity;
	    }
	
	    public override ArticoloDto Assemble(Articolo entity)
	    {
	        ArticoloDto dto = new ArticoloDto();
	        
			ObjectKey key = KeyUtility.Instance.Create(entity);
			dto.DtoKey = KeyUtility.Instance.Convert(key);
			dto.Id = entity.Id;
			dto.FatturaAcquistoId = entity.FatturaAcquistoId;
			dto.Codice = entity.Codice;
			dto.Descrizione = entity.Descrizione;
			dto.Quantita = entity.Quantita;
			dto.Sconto = entity.Sconto;
			dto.Costo = entity.Costo;
			dto.Importo = entity.Importo;
			dto.IVA = entity.IVA;
			dto.Totale = entity.Totale;
			dto.PrezzoUnitario = entity.PrezzoUnitario;
			this.OnDTOAssembled(dto); 
	        return dto;
	    }
	
	    public override void AssembleReferences(Articolo entity, ArticoloDto dto)
	    {
			FatturaAcquistoAssembler fatturaAcquistoAssembler = new FatturaAcquistoAssembler();
			dto.Fattura = fatturaAcquistoAssembler.Assemble(entity.Fattura);

	    }
	
	    public override void AssembleCollections(Articolo entity, ArticoloDto dto)
	    {
	    }
	
	}
	
	
	public partial class ArticoloAssembler : ArticoloAssemblerBase, IArticoloAssembler
	{
	    
	}
	
	public partial interface IPagamentoAssembler : IAssembler<PagamentoDto, Pagamento>
	{ 
	
	}
	
	public partial class PagamentoAssemblerBase : Assembler<PagamentoDto, Pagamento>
	{
		/// <summary>
	    /// Invoked after the PagamentoDto instance is assembled.
	    /// </summary>
	    /// <param name="dto"><see cref="PagamentoDto"/> The Dto instance.</param>
		partial void OnDTOAssembled(PagamentoDto dto);
	
		/// <summary>
	    /// Invoked after the Pagamento instance is assembled.
	    /// </summary>
	    /// <param name="entity">The <see cref="Pagamento"/> instance.</param>
		partial void OnEntityAssembled(Pagamento entity);
		
	    public override Pagamento Assemble(Pagamento entity, PagamentoDto dto)
	    {
	        if (entity == null)
	        {
	            entity = new Pagamento();
	        }
			
			entity.Id = dto.Id;
			entity.FatturaAcquistoId = dto.FatturaAcquistoId;
			entity.Data = dto.Data;
			entity.Importo = dto.Importo;
			entity.Note = dto.Note;
			entity.Codice = dto.Codice;
	        this.OnEntityAssembled(entity);
	        return entity;
	    }
	
	    public override PagamentoDto Assemble(Pagamento entity)
	    {
	        PagamentoDto dto = new PagamentoDto();
	        
			ObjectKey key = KeyUtility.Instance.Create(entity);
			dto.DtoKey = KeyUtility.Instance.Convert(key);
			dto.Id = entity.Id;
			dto.FatturaAcquistoId = entity.FatturaAcquistoId;
			dto.Data = entity.Data;
			dto.Importo = entity.Importo;
			dto.Note = entity.Note;
			dto.Codice = entity.Codice;
			this.OnDTOAssembled(dto); 
	        return dto;
	    }
	
	    public override void AssembleReferences(Pagamento entity, PagamentoDto dto)
	    {
			FatturaAcquistoAssembler fatturaAcquistoAssembler = new FatturaAcquistoAssembler();
			dto.FatturaAcquisto = fatturaAcquistoAssembler.Assemble(entity.FatturaAcquisto);

	    }
	
	    public override void AssembleCollections(Pagamento entity, PagamentoDto dto)
	    {
	    }
	
	}
	
	
	public partial class PagamentoAssembler : PagamentoAssemblerBase, IPagamentoAssembler
	{
	    
	}
	
	public partial interface IFatturaVenditaAssembler : IAssembler<FatturaVenditaDto, FatturaVendita>
	{ 
	
	}
	
	public partial class FatturaVenditaAssemblerBase : Assembler<FatturaVenditaDto, FatturaVendita>
	{
		/// <summary>
	    /// Invoked after the FatturaVenditaDto instance is assembled.
	    /// </summary>
	    /// <param name="dto"><see cref="FatturaVenditaDto"/> The Dto instance.</param>
		partial void OnDTOAssembled(FatturaVenditaDto dto);
	
		/// <summary>
	    /// Invoked after the FatturaVendita instance is assembled.
	    /// </summary>
	    /// <param name="entity">The <see cref="FatturaVendita"/> instance.</param>
		partial void OnEntityAssembled(FatturaVendita entity);
		
	    public override FatturaVendita Assemble(FatturaVendita entity, FatturaVenditaDto dto)
	    {
	        if (entity == null)
	        {
	            entity = new FatturaVendita();
	        }
			
			entity.Id = dto.Id;
			entity.ClienteId = dto.ClienteId;
			entity.Data = dto.Data;
			entity.Numero = dto.Numero;
			entity.TipoPagamento = dto.TipoPagamento;
			entity.Descrizione = dto.Descrizione;
			entity.Imponibile = dto.Imponibile;
			entity.IVA = dto.IVA;
			entity.Totale = dto.Totale;
			entity.Saldo = dto.Saldo;
			entity.ScadenzaPagamento = dto.ScadenzaPagamento;
	        this.OnEntityAssembled(entity);
	        return entity;
	    }
	
	    public override FatturaVenditaDto Assemble(FatturaVendita entity)
	    {
	        FatturaVenditaDto dto = new FatturaVenditaDto();
	        
			ObjectKey key = KeyUtility.Instance.Create(entity);
			dto.DtoKey = KeyUtility.Instance.Convert(key);
			dto.Id = entity.Id;
			dto.ClienteId = entity.ClienteId;
			dto.Data = entity.Data;
			dto.Numero = entity.Numero;
			dto.TipoPagamento = entity.TipoPagamento;
			dto.Descrizione = entity.Descrizione;
			dto.Imponibile = entity.Imponibile;
			dto.IVA = entity.IVA;
			dto.Totale = entity.Totale;
			dto.Saldo = entity.Saldo;
			dto.ScadenzaPagamento = entity.ScadenzaPagamento;
			this.OnDTOAssembled(dto); 
	        return dto;
	    }
	
	    public override void AssembleReferences(FatturaVendita entity, FatturaVenditaDto dto)
	    {
			ClienteAssembler clienteAssembler = new ClienteAssembler();
			dto.Cliente = clienteAssembler.Assemble(entity.Cliente);

	    }
	
	    public override void AssembleCollections(FatturaVendita entity, FatturaVenditaDto dto)
	    {
			LiquidazioneAssembler liquidazioneAssembler = new LiquidazioneAssembler();

			dto.Liquidaziones = new List<LiquidazioneDto>();
			foreach (Liquidazione item in entity.Liquidaziones)
			{
				var dtoItem = liquidazioneAssembler.Assemble(item);
				dtoItem.FatturaVendita = dto;
				dto.Liquidaziones.Add(dtoItem);
			}

	    }
	
	}
	
	
	public partial class FatturaVenditaAssembler : FatturaVenditaAssemblerBase, IFatturaVenditaAssembler
	{
	    
	}
	
	public partial interface ILiquidazioneAssembler : IAssembler<LiquidazioneDto, Liquidazione>
	{ 
	
	}
	
	public partial class LiquidazioneAssemblerBase : Assembler<LiquidazioneDto, Liquidazione>
	{
		/// <summary>
	    /// Invoked after the LiquidazioneDto instance is assembled.
	    /// </summary>
	    /// <param name="dto"><see cref="LiquidazioneDto"/> The Dto instance.</param>
		partial void OnDTOAssembled(LiquidazioneDto dto);
	
		/// <summary>
	    /// Invoked after the Liquidazione instance is assembled.
	    /// </summary>
	    /// <param name="entity">The <see cref="Liquidazione"/> instance.</param>
		partial void OnEntityAssembled(Liquidazione entity);
		
	    public override Liquidazione Assemble(Liquidazione entity, LiquidazioneDto dto)
	    {
	        if (entity == null)
	        {
	            entity = new Liquidazione();
	        }
			
			entity.Id = dto.Id;
			entity.FatturaVenditaId = dto.FatturaVenditaId;
			entity.Data = dto.Data;
			entity.Importo = dto.Importo;
			entity.Note = dto.Note;
			entity.Codice = dto.Codice;
	        this.OnEntityAssembled(entity);
	        return entity;
	    }
	
	    public override LiquidazioneDto Assemble(Liquidazione entity)
	    {
	        LiquidazioneDto dto = new LiquidazioneDto();
	        
			ObjectKey key = KeyUtility.Instance.Create(entity);
			dto.DtoKey = KeyUtility.Instance.Convert(key);
			dto.Id = entity.Id;
			dto.FatturaVenditaId = entity.FatturaVenditaId;
			dto.Data = entity.Data;
			dto.Importo = entity.Importo;
			dto.Note = entity.Note;
			dto.Codice = entity.Codice;
			this.OnDTOAssembled(dto); 
	        return dto;
	    }
	
	    public override void AssembleReferences(Liquidazione entity, LiquidazioneDto dto)
	    {
			FatturaVenditaAssembler fatturaVenditaAssembler = new FatturaVenditaAssembler();
			dto.FatturaVendita = fatturaVenditaAssembler.Assemble(entity.FatturaVendita);

	    }
	
	    public override void AssembleCollections(Liquidazione entity, LiquidazioneDto dto)
	    {
	    }
	
	}
	
	
	public partial class LiquidazioneAssembler : LiquidazioneAssemblerBase, ILiquidazioneAssembler
	{
	    
	}
	
	public partial interface IAnagraficaFornitoreAssembler : IAssembler<AnagraficaFornitoreDto, AnagraficaFornitore>
	{ 
	
	}
	
	public partial class AnagraficaFornitoreAssemblerBase : Assembler<AnagraficaFornitoreDto, AnagraficaFornitore>
	{
		/// <summary>
	    /// Invoked after the AnagraficaFornitoreDto instance is assembled.
	    /// </summary>
	    /// <param name="dto"><see cref="AnagraficaFornitoreDto"/> The Dto instance.</param>
		partial void OnDTOAssembled(AnagraficaFornitoreDto dto);
	
		/// <summary>
	    /// Invoked after the AnagraficaFornitore instance is assembled.
	    /// </summary>
	    /// <param name="entity">The <see cref="AnagraficaFornitore"/> instance.</param>
		partial void OnEntityAssembled(AnagraficaFornitore entity);
		
	    public override AnagraficaFornitore Assemble(AnagraficaFornitore entity, AnagraficaFornitoreDto dto)
	    {
	        if (entity == null)
	        {
	            entity = new AnagraficaFornitore();
	        }
			
			entity.Id = dto.Id;
			entity.RagioneSociale = dto.RagioneSociale;
			entity.Indirizzo = dto.Indirizzo;
			entity.CAP = dto.CAP;
			entity.Comune = dto.Comune;
			entity.Provincia = dto.Provincia;
			entity.Telefono = dto.Telefono;
			entity.Mobile = dto.Mobile;
			entity.Fax = dto.Fax;
			entity.Email = dto.Email;
			entity.PIva = dto.PIva;
			entity.Codice = dto.Codice;
	        this.OnEntityAssembled(entity);
	        return entity;
	    }
	
	    public override AnagraficaFornitoreDto Assemble(AnagraficaFornitore entity)
	    {
	        AnagraficaFornitoreDto dto = new AnagraficaFornitoreDto();
	        
			ObjectKey key = KeyUtility.Instance.Create(entity);
			dto.DtoKey = KeyUtility.Instance.Convert(key);
			dto.Id = entity.Id;
			dto.RagioneSociale = entity.RagioneSociale;
			dto.Indirizzo = entity.Indirizzo;
			dto.CAP = entity.CAP;
			dto.Comune = entity.Comune;
			dto.Provincia = entity.Provincia;
			dto.Telefono = entity.Telefono;
			dto.Mobile = entity.Mobile;
			dto.Fax = entity.Fax;
			dto.Email = entity.Email;
			dto.PIva = entity.PIva;
			dto.Codice = entity.Codice;
			this.OnDTOAssembled(dto); 
	        return dto;
	    }
	
	    public override void AssembleReferences(AnagraficaFornitore entity, AnagraficaFornitoreDto dto)
	    {
	    }
	
	    public override void AssembleCollections(AnagraficaFornitore entity, AnagraficaFornitoreDto dto)
	    {
	    }
	
	}
	
	
	public partial class AnagraficaFornitoreAssembler : AnagraficaFornitoreAssemblerBase, IAnagraficaFornitoreAssembler
	{
	    
	}
	
	public partial interface IAnagraficaClienteAssembler : IAssembler<AnagraficaClienteDto, AnagraficaCliente>
	{ 
	
	}
	
	public partial class AnagraficaClienteAssemblerBase : Assembler<AnagraficaClienteDto, AnagraficaCliente>
	{
		/// <summary>
	    /// Invoked after the AnagraficaClienteDto instance is assembled.
	    /// </summary>
	    /// <param name="dto"><see cref="AnagraficaClienteDto"/> The Dto instance.</param>
		partial void OnDTOAssembled(AnagraficaClienteDto dto);
	
		/// <summary>
	    /// Invoked after the AnagraficaCliente instance is assembled.
	    /// </summary>
	    /// <param name="entity">The <see cref="AnagraficaCliente"/> instance.</param>
		partial void OnEntityAssembled(AnagraficaCliente entity);
		
	    public override AnagraficaCliente Assemble(AnagraficaCliente entity, AnagraficaClienteDto dto)
	    {
	        if (entity == null)
	        {
	            entity = new AnagraficaCliente();
	        }
			
			entity.Id = dto.Id;
			entity.RagioneSociale = dto.RagioneSociale;
			entity.Indirizzo = dto.Indirizzo;
			entity.CAP = dto.CAP;
			entity.Comune = dto.Comune;
			entity.Provincia = dto.Provincia;
			entity.Telefono = dto.Telefono;
			entity.Mobile = dto.Mobile;
			entity.Fax = dto.Fax;
			entity.Email = dto.Email;
			entity.PIva = dto.PIva;
			entity.Codice = dto.Codice;
	        this.OnEntityAssembled(entity);
	        return entity;
	    }
	
	    public override AnagraficaClienteDto Assemble(AnagraficaCliente entity)
	    {
	        AnagraficaClienteDto dto = new AnagraficaClienteDto();
	        
			ObjectKey key = KeyUtility.Instance.Create(entity);
			dto.DtoKey = KeyUtility.Instance.Convert(key);
			dto.Id = entity.Id;
			dto.RagioneSociale = entity.RagioneSociale;
			dto.Indirizzo = entity.Indirizzo;
			dto.CAP = entity.CAP;
			dto.Comune = entity.Comune;
			dto.Provincia = entity.Provincia;
			dto.Telefono = entity.Telefono;
			dto.Mobile = entity.Mobile;
			dto.Fax = entity.Fax;
			dto.Email = entity.Email;
			dto.PIva = entity.PIva;
			dto.Codice = entity.Codice;
			this.OnDTOAssembled(dto); 
	        return dto;
	    }
	
	    public override void AssembleReferences(AnagraficaCliente entity, AnagraficaClienteDto dto)
	    {
	    }
	
	    public override void AssembleCollections(AnagraficaCliente entity, AnagraficaClienteDto dto)
	    {
	    }
	
	}
	
	
	public partial class AnagraficaClienteAssembler : AnagraficaClienteAssemblerBase, IAnagraficaClienteAssembler
	{
	    
	}
	
	public partial interface ISALAssembler : IAssembler<SALDto, SAL>
	{ 
	
	}
	
	public partial class SALAssemblerBase : Assembler<SALDto, SAL>
	{
		/// <summary>
	    /// Invoked after the SALDto instance is assembled.
	    /// </summary>
	    /// <param name="dto"><see cref="SALDto"/> The Dto instance.</param>
		partial void OnDTOAssembled(SALDto dto);
	
		/// <summary>
	    /// Invoked after the SAL instance is assembled.
	    /// </summary>
	    /// <param name="entity">The <see cref="SAL"/> instance.</param>
		partial void OnEntityAssembled(SAL entity);
		
	    public override SAL Assemble(SAL entity, SALDto dto)
	    {
	        if (entity == null)
	        {
	            entity = new SAL();
	        }
			
			entity.Id = dto.Id;
			entity.CommessaId = dto.CommessaId;
			entity.Data = dto.Data;
			entity.TotaleAcquisti = dto.TotaleAcquisti;
			entity.TotaleVendite = dto.TotaleVendite;
			entity.Lock = dto.Lock;
			entity.Denominazione = dto.Denominazione;
			entity.Codice = dto.Codice;
			entity.TotaleIncassi = dto.TotaleIncassi;
			entity.TotalePagamenti = dto.TotalePagamenti;
			entity.Stato = dto.Stato;
	        this.OnEntityAssembled(entity);
	        return entity;
	    }
	
	    public override SALDto Assemble(SAL entity)
	    {
	        SALDto dto = new SALDto();
	        
			ObjectKey key = KeyUtility.Instance.Create(entity);
			dto.DtoKey = KeyUtility.Instance.Convert(key);
			dto.Id = entity.Id;
			dto.CommessaId = entity.CommessaId;
			dto.Data = entity.Data;
			dto.TotaleAcquisti = entity.TotaleAcquisti;
			dto.TotaleVendite = entity.TotaleVendite;
			dto.Lock = entity.Lock;
			dto.Denominazione = entity.Denominazione;
			dto.Codice = entity.Codice;
			dto.TotaleIncassi = entity.TotaleIncassi;
			dto.TotalePagamenti = entity.TotalePagamenti;
			dto.Stato = entity.Stato;
			this.OnDTOAssembled(dto); 
	        return dto;
	    }
	
	    public override void AssembleReferences(SAL entity, SALDto dto)
	    {
			CommessaAssembler commessaAssembler = new CommessaAssembler();
			dto.Commessa = commessaAssembler.Assemble(entity.Commessa);

	    }
	
	    public override void AssembleCollections(SAL entity, SALDto dto)
	    {
	    }
	
	}
	
	
	public partial class SALAssembler : SALAssemblerBase, ISALAssembler
	{
	    
	}
	
	public partial interface IAnagraficaArticoloAssembler : IAssembler<AnagraficaArticoloDto, AnagraficaArticolo>
	{ 
	
	}
	
	public partial class AnagraficaArticoloAssemblerBase : Assembler<AnagraficaArticoloDto, AnagraficaArticolo>
	{
		/// <summary>
	    /// Invoked after the AnagraficaArticoloDto instance is assembled.
	    /// </summary>
	    /// <param name="dto"><see cref="AnagraficaArticoloDto"/> The Dto instance.</param>
		partial void OnDTOAssembled(AnagraficaArticoloDto dto);
	
		/// <summary>
	    /// Invoked after the AnagraficaArticolo instance is assembled.
	    /// </summary>
	    /// <param name="entity">The <see cref="AnagraficaArticolo"/> instance.</param>
		partial void OnEntityAssembled(AnagraficaArticolo entity);
		
	    public override AnagraficaArticolo Assemble(AnagraficaArticolo entity, AnagraficaArticoloDto dto)
	    {
	        if (entity == null)
	        {
	            entity = new AnagraficaArticolo();
	        }
			
			entity.Id = dto.Id;
			entity.Codice = dto.Codice;
			entity.Descrizione = dto.Descrizione;
	        this.OnEntityAssembled(entity);
	        return entity;
	    }
	
	    public override AnagraficaArticoloDto Assemble(AnagraficaArticolo entity)
	    {
	        AnagraficaArticoloDto dto = new AnagraficaArticoloDto();
	        
			ObjectKey key = KeyUtility.Instance.Create(entity);
			dto.DtoKey = KeyUtility.Instance.Convert(key);
			dto.Id = entity.Id;
			dto.Codice = entity.Codice;
			dto.Descrizione = entity.Descrizione;
			this.OnDTOAssembled(dto); 
	        return dto;
	    }
	
	    public override void AssembleReferences(AnagraficaArticolo entity, AnagraficaArticoloDto dto)
	    {
	    }
	
	    public override void AssembleCollections(AnagraficaArticolo entity, AnagraficaArticoloDto dto)
	    {
	    }
	
	}
	
	
	public partial class AnagraficaArticoloAssembler : AnagraficaArticoloAssemblerBase, IAnagraficaArticoloAssembler
	{
	    
	}
}
#pragma warning restore 1591
