﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ContextGenerator.ttinclude code generation file.
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
	public partial class EntitiesModel : OpenAccessContext, IEntitiesModelUnitOfWork
	{
		private static string connectionStringName = @"ESCantieriConnection";
			
		private static BackendConfiguration backend = GetBackendConfiguration();
				
		private static MetadataSource metadataSource = XmlMetadataSource.FromAssemblyResource("EntitiesModel.rlinq");
		
		public EntitiesModel()
			:base(connectionStringName, backend, metadataSource)
		{ }
		
		public EntitiesModel(string connection)
			:base(connection, backend, metadataSource)
		{ }
		
		public EntitiesModel(BackendConfiguration backendConfiguration)
			:base(connectionStringName, backendConfiguration, metadataSource)
		{ }
			
		public EntitiesModel(string connection, MetadataSource metadataSource)
			:base(connection, backend, metadataSource)
		{ }
		
		public EntitiesModel(string connection, BackendConfiguration backendConfiguration, MetadataSource metadataSource)
			:base(connection, backendConfiguration, metadataSource)
		{ }
			
		public IQueryable<Azienda> Aziendas 
		{
			get
			{
				return this.GetAll<Azienda>();
			}
		}
		
		public IQueryable<Commessa> Commessas 
		{
			get
			{
				return this.GetAll<Commessa>();
			}
		}
		
		public IQueryable<Fornitore> Fornitores 
		{
			get
			{
				return this.GetAll<Fornitore>();
			}
		}
		
		public IQueryable<Cliente> Clientes 
		{
			get
			{
				return this.GetAll<Cliente>();
			}
		}
		
		public IQueryable<Statistica> Statisticas 
		{
			get
			{
				return this.GetAll<Statistica>();
			}
		}
		
		public IQueryable<CentroCosto> CentroCostos 
		{
			get
			{
				return this.GetAll<CentroCosto>();
			}
		}
		
		public IQueryable<FatturaAcquisto> FatturaAcquistos 
		{
			get
			{
				return this.GetAll<FatturaAcquisto>();
			}
		}
		
		public IQueryable<Articolo> Articolos 
		{
			get
			{
				return this.GetAll<Articolo>();
			}
		}
		
		public IQueryable<Pagamento> Pagamentos 
		{
			get
			{
				return this.GetAll<Pagamento>();
			}
		}
		
		public IQueryable<FatturaVendita> FatturaVenditas 
		{
			get
			{
				return this.GetAll<FatturaVendita>();
			}
		}
		
		public IQueryable<Liquidazione> Liquidaziones 
		{
			get
			{
				return this.GetAll<Liquidazione>();
			}
		}
		
		public IQueryable<AnagraficaFornitore> AnagraficaFornitores 
		{
			get
			{
				return this.GetAll<AnagraficaFornitore>();
			}
		}
		
		public IQueryable<AnagraficaCliente> AnagraficaClientes 
		{
			get
			{
				return this.GetAll<AnagraficaCliente>();
			}
		}
		
		public IQueryable<SAL> SALs 
		{
			get
			{
				return this.GetAll<SAL>();
			}
		}
		
		public static BackendConfiguration GetBackendConfiguration()
		{
			BackendConfiguration backend = new BackendConfiguration();
			backend.Backend = "MsSql";
			backend.ProviderName = "System.Data.SqlClient";
			backend.Logging.MetricStoreSnapshotInterval = 0;
		
			CustomizeBackendConfiguration(ref backend);
		
			return backend;
		}
		
		/// <summary>
		/// Allows you to customize the BackendConfiguration of EntitiesModel.
		/// </summary>
		/// <param name="config">The BackendConfiguration of EntitiesModel.</param>
		static partial void CustomizeBackendConfiguration(ref BackendConfiguration config);
		
	}
	
	public interface IEntitiesModelUnitOfWork : IUnitOfWork
	{
		IQueryable<Azienda> Aziendas
		{
			get;
		}
		IQueryable<Commessa> Commessas
		{
			get;
		}
		IQueryable<Fornitore> Fornitores
		{
			get;
		}
		IQueryable<Cliente> Clientes
		{
			get;
		}
		IQueryable<Statistica> Statisticas
		{
			get;
		}
		IQueryable<CentroCosto> CentroCostos
		{
			get;
		}
		IQueryable<FatturaAcquisto> FatturaAcquistos
		{
			get;
		}
		IQueryable<Articolo> Articolos
		{
			get;
		}
		IQueryable<Pagamento> Pagamentos
		{
			get;
		}
		IQueryable<FatturaVendita> FatturaVenditas
		{
			get;
		}
		IQueryable<Liquidazione> Liquidaziones
		{
			get;
		}
		IQueryable<AnagraficaFornitore> AnagraficaFornitores
		{
			get;
		}
		IQueryable<AnagraficaCliente> AnagraficaClientes
		{
			get;
		}
		IQueryable<SAL> SALs
		{
			get;
		}
	}
}
#pragma warning restore 1591
