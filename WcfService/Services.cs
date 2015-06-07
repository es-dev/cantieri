#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace WcfService.Services
{
	using Telerik.OpenAccess;
	using System.Linq.Dynamic;
	using DataLayer;
	using WcfService.Dto;
	using WcfService.Assemblers;
	using WcfService.Repositories;
	using WcfService.Converters;
	using System;
	using System.Linq;
	using System.Linq.Expressions;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.Serialization;

	
	public partial interface IService<TDto, TEntity>
	    where TEntity : class
		where TDto : IDtoWithKey
	{
	    IAssembler<TDto, TEntity> Assembler { get; }
	    IRepository<TEntity> Repository { get; }
	
	    IEnumerable<TDto> Find(Expression<Func<TEntity, bool>> filter);
	    IEnumerable<TDto> GetAll();
		
		IEnumerable<TDto> Find(int startRowIndex, int maximumRows);
	    IEnumerable<TDto> Find(string sortExpression, string filterExpression);
	    IEnumerable<TDto> Find(int? startRowIndex, int? maximumRows, string sortExpression, string filterExpression);
	    
		int Count();
	    int Count(string filterExpression);
		
		TDto GetByKey(string dtoKey);
	    string Add(TDto dto);
		void Update(TDto dto);
	    void Delete(TDto dto);	
	}
	
	public abstract partial class Service<TDto, TEntity> : IService<TDto, TEntity>
	    where TEntity : class
		where TDto : IDtoWithKey
	{
	    IAssembler<TDto, TEntity> assembler;
	    IRepository<TEntity> repository;
	
	    public Service(IAssembler<TDto, TEntity> assembler,
	        IRepository<TEntity> repository)
	    {
	        this.assembler = assembler;
	        this.repository = repository;
	    }
	
	    public IAssembler<TDto, TEntity> Assembler 
	    { 
	        get 
	        {
	            return this.assembler; 
	        } 
	    }
	
	    public IRepository<TEntity> Repository 
	    { 
	        get 
	        {
	            return this.repository; 
	        }
	    }
		
		public virtual IEnumerable<TDto> GetAll()
	    {
	        return this.assembler.Assemble(this.Repository.GetAll());
	    }
	
	    public virtual IEnumerable<TDto> Find(Expression<Func<TEntity, bool>> filter)
	    {
	        return this.Assembler.Assemble(this.Repository.Find(filter));
	    }
	
	    public virtual IEnumerable<TDto> Find(int startRowIndex, int maximumRows)
	    {
	        return this.Find(startRowIndex, maximumRows, null, null);
	    }
	
	    public virtual IEnumerable<TDto> Find(string sortExpression, string filterExpression)
	    {
	        return this.Find(null, null, sortExpression, filterExpression);
	    }
	
	    public virtual IEnumerable<TDto> Find(int? startRowIndex, int? maximumRows, string sortExpression, string filterExpression)
	    {
	        IQueryable<TEntity> query = this.Repository.GetAll();
	
	        if (!string.IsNullOrEmpty(filterExpression))
	        {
	            query = query.Where(filterExpression);
	        }
	        if (!string.IsNullOrEmpty(sortExpression))
	        {
	            query = query.OrderBy(sortExpression);
	        }
	        if (startRowIndex.HasValue)
	        {
	            query = query.Skip(startRowIndex.Value);
	        }
	        if (maximumRows.HasValue)
	        {
	            query = query.Take(maximumRows.Value);
	        }
	
	        return this.Assembler.Assemble(query);
	    }
	
	    public virtual int Count()
	    {
	        return this.Count(string.Empty);
	    }
	
	    public virtual int Count(string filterExpression)
	    {
	        IQueryable<TEntity> query = this.Repository.GetAll();
	
	        if (!string.IsNullOrEmpty(filterExpression))
	        {
	            query = query.Where(filterExpression);    
	        }
	
	        return query.Count();
	    }
	
	    
	    public virtual TDto GetByKey(string dtoKey)
	    {
	        ObjectKey key = KeyUtility.Instance.Convert<TEntity>(dtoKey);
			
	        return this.assembler.Assemble(this.Repository.Get(key));
	    }
	
	    public virtual string Add(TDto dto)
	    {
	        TEntity entity = this.assembler.Assemble(null, dto);
	
	        this.repository.Add(entity);
	
	        ObjectKey key = KeyUtility.Instance.Create(entity);
	
	        return KeyUtility.Instance.Convert(key);
	    }
	
	    public virtual void Update(TDto dto)
	    {
	        ObjectKey key = KeyUtility.Instance.Convert<TEntity>(dto.DtoKey);
	        TEntity entity = this.repository.Get(key);
	
	        this.assembler.Assemble(entity, dto);
	    }
	
	    public virtual void Delete(TDto dto)
	    {
			ObjectKey key = KeyUtility.Instance.Convert<TEntity>(dto.DtoKey);
	        TEntity entity = this.repository.Get(key);
	
	        this.Repository.Remove(entity);
	    }
	}
	
	public partial interface IAziendaService : IService<AziendaDto, Azienda>
	{
	
	}
	
	public partial class AziendaService : Service<AziendaDto, Azienda>, IAziendaService
	{
	    public AziendaService(IAziendaAssembler assembler, IAziendaRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface ICommessaService : IService<CommessaDto, Commessa>
	{
	
	}
	
	public partial class CommessaService : Service<CommessaDto, Commessa>, ICommessaService
	{
	    public CommessaService(ICommessaAssembler assembler, ICommessaRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface IFornitoreService : IService<FornitoreDto, Fornitore>
	{
	
	}
	
	public partial class FornitoreService : Service<FornitoreDto, Fornitore>, IFornitoreService
	{
	    public FornitoreService(IFornitoreAssembler assembler, IFornitoreRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface ICommittenteService : IService<CommittenteDto, Committente>
	{
	
	}
	
	public partial class CommittenteService : Service<CommittenteDto, Committente>, ICommittenteService
	{
	    public CommittenteService(ICommittenteAssembler assembler, ICommittenteRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface ICentroCostoService : IService<CentroCostoDto, CentroCosto>
	{
	
	}
	
	public partial class CentroCostoService : Service<CentroCostoDto, CentroCosto>, ICentroCostoService
	{
	    public CentroCostoService(ICentroCostoAssembler assembler, ICentroCostoRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface IFatturaAcquistoService : IService<FatturaAcquistoDto, FatturaAcquisto>
	{
	
	}
	
	public partial class FatturaAcquistoService : Service<FatturaAcquistoDto, FatturaAcquisto>, IFatturaAcquistoService
	{
	    public FatturaAcquistoService(IFatturaAcquistoAssembler assembler, IFatturaAcquistoRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface IArticoloService : IService<ArticoloDto, Articolo>
	{
	
	}
	
	public partial class ArticoloService : Service<ArticoloDto, Articolo>, IArticoloService
	{
	    public ArticoloService(IArticoloAssembler assembler, IArticoloRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface IPagamentoService : IService<PagamentoDto, Pagamento>
	{
	
	}
	
	public partial class PagamentoService : Service<PagamentoDto, Pagamento>, IPagamentoService
	{
	    public PagamentoService(IPagamentoAssembler assembler, IPagamentoRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface IFatturaVenditaService : IService<FatturaVenditaDto, FatturaVendita>
	{
	
	}
	
	public partial class FatturaVenditaService : Service<FatturaVenditaDto, FatturaVendita>, IFatturaVenditaService
	{
	    public FatturaVenditaService(IFatturaVenditaAssembler assembler, IFatturaVenditaRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface IIncassoService : IService<IncassoDto, Incasso>
	{
	
	}
	
	public partial class IncassoService : Service<IncassoDto, Incasso>, IIncassoService
	{
	    public IncassoService(IIncassoAssembler assembler, IIncassoRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface IAnagraficaFornitoreService : IService<AnagraficaFornitoreDto, AnagraficaFornitore>
	{
	
	}
	
	public partial class AnagraficaFornitoreService : Service<AnagraficaFornitoreDto, AnagraficaFornitore>, IAnagraficaFornitoreService
	{
	    public AnagraficaFornitoreService(IAnagraficaFornitoreAssembler assembler, IAnagraficaFornitoreRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface IAnagraficaCommittenteService : IService<AnagraficaCommittenteDto, AnagraficaCommittente>
	{
	
	}
	
	public partial class AnagraficaCommittenteService : Service<AnagraficaCommittenteDto, AnagraficaCommittente>, IAnagraficaCommittenteService
	{
	    public AnagraficaCommittenteService(IAnagraficaCommittenteAssembler assembler, IAnagraficaCommittenteRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface ISALService : IService<SALDto, SAL>
	{
	
	}
	
	public partial class SALService : Service<SALDto, SAL>, ISALService
	{
	    public SALService(ISALAssembler assembler, ISALRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface IAnagraficaArticoloService : IService<AnagraficaArticoloDto, AnagraficaArticolo>
	{
	
	}
	
	public partial class AnagraficaArticoloService : Service<AnagraficaArticoloDto, AnagraficaArticolo>, IAnagraficaArticoloService
	{
	    public AnagraficaArticoloService(IAnagraficaArticoloAssembler assembler, IAnagraficaArticoloRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface IAccountService : IService<AccountDto, Account>
	{
	
	}
	
	public partial class AccountService : Service<AccountDto, Account>, IAccountService
	{
	    public AccountService(IAccountAssembler assembler, IAccountRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface IReportJobService : IService<ReportJobDto, ReportJob>
	{
	
	}
	
	public partial class ReportJobService : Service<ReportJobDto, ReportJob>, IReportJobService
	{
	    public ReportJobService(IReportJobAssembler assembler, IReportJobRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface IPagamentoUnificatoService : IService<PagamentoUnificatoDto, PagamentoUnificato>
	{
	
	}
	
	public partial class PagamentoUnificatoService : Service<PagamentoUnificatoDto, PagamentoUnificato>, IPagamentoUnificatoService
	{
	    public PagamentoUnificatoService(IPagamentoUnificatoAssembler assembler, IPagamentoUnificatoRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface IPagamentoUnificatoFatturaAcquistoService : IService<PagamentoUnificatoFatturaAcquistoDto, PagamentoUnificatoFatturaAcquisto>
	{
	
	}
	
	public partial class PagamentoUnificatoFatturaAcquistoService : Service<PagamentoUnificatoFatturaAcquistoDto, PagamentoUnificatoFatturaAcquisto>, IPagamentoUnificatoFatturaAcquistoService
	{
	    public PagamentoUnificatoFatturaAcquistoService(IPagamentoUnificatoFatturaAcquistoAssembler assembler, IPagamentoUnificatoFatturaAcquistoRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface INotaCreditoService : IService<NotaCreditoDto, NotaCredito>
	{
	
	}
	
	public partial class NotaCreditoService : Service<NotaCreditoDto, NotaCredito>, INotaCreditoService
	{
	    public NotaCreditoService(INotaCreditoAssembler assembler, INotaCreditoRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface IResoService : IService<ResoDto, Reso>
	{
	
	}
	
	public partial class ResoService : Service<ResoDto, Reso>, IResoService
	{
	    public ResoService(IResoAssembler assembler, IResoRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface INotificaService : IService<NotificaDto, Notifica>
	{
	
	}
	
	public partial class NotificaService : Service<NotificaDto, Notifica>, INotificaService
	{
	    public NotificaService(INotificaAssembler assembler, INotificaRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
}
#pragma warning restore 1591
