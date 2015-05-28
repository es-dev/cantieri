--SELECT 'ALTER SCHEMA dbo TRANSFER [' + SysSchemas.Name + '].[' +      DbObjects.Name + '];'+ CHAR(13)+ CHAR(10)+ 'GO '+ CHAR(13)+ CHAR(10)
--FROM sys.Objects DbObjects
--INNER JOIN sys.Schemas SysSchemas ON DbObjects.schema_id =     SysSchemas.schema_id
--WHERE SysSchemas.Name = 'MSSql101738'
--AND (DbObjects.Type IN ('U', 'P', 'V'))


ALTER SCHEMA dbo TRANSFER [MSSql101738].[Account];
GO 
ALTER SCHEMA dbo TRANSFER [MSSql101738].[AnagraficaFornitore];
GO 
ALTER SCHEMA dbo TRANSFER [MSSql101738].[Articolo];
GO 
ALTER SCHEMA dbo TRANSFER [MSSql101738].[Azienda];
GO 
ALTER SCHEMA dbo TRANSFER [MSSql101738].[CentroCosto];
GO 
ALTER SCHEMA dbo TRANSFER [MSSql101738].[Reso];
GO 
ALTER SCHEMA dbo TRANSFER [MSSql101738].[Commessa];
GO 
ALTER SCHEMA dbo TRANSFER [MSSql101738].[FatturaAcquisto];
GO 
ALTER SCHEMA dbo TRANSFER [MSSql101738].[FatturaVendita];
GO 
ALTER SCHEMA dbo TRANSFER [MSSql101738].[Fornitore];
GO 
ALTER SCHEMA dbo TRANSFER [MSSql101738].[Incasso];
GO 
ALTER SCHEMA dbo TRANSFER [MSSql101738].[Pagamento];
GO 
ALTER SCHEMA dbo TRANSFER [MSSql101738].[SAL];
GO 
ALTER SCHEMA dbo TRANSFER [MSSql101738].[Committente];
GO 
ALTER SCHEMA dbo TRANSFER [MSSql101738].[ReportJob];
GO 
ALTER SCHEMA dbo TRANSFER [MSSql101738].[PagamentoUnificato];
GO 
ALTER SCHEMA dbo TRANSFER [MSSql101738].[NotaCredito];
GO 
ALTER SCHEMA dbo TRANSFER [MSSql101738].[AnagraficaArticolo];
GO 
ALTER SCHEMA dbo TRANSFER [MSSql101738].[PagamentoUnificatoFatturaAcquisto];
GO 
ALTER SCHEMA dbo TRANSFER [MSSql101738].[AnagraficaCommittente];
GO 
