-- add column for field _note
ALTER TABLE [AnagraficaArticolo] ADD [Note] varchar(max) NULL

go

-- add column for field _note
ALTER TABLE [AnagraficaCliente] ADD [Note] varchar(max) NULL

go

-- add column for field _note
ALTER TABLE [AnagraficaFornitore] ADD [Note] varchar(max) NULL

go

-- add column for field _note
ALTER TABLE [Articolo] ADD [Note] varchar(max) NULL

go

-- add column for field _note
ALTER TABLE [Azienda] ADD [Note] varchar(max) NULL

go

-- add column for field _note
ALTER TABLE [CentroCosto] ADD [Note] varchar(max) NULL

go

-- add column for field _note
ALTER TABLE [Cliente] ADD [Note] varchar(max) NULL

go

-- add column for field _note
ALTER TABLE [Commessa] ADD [Note] varchar(max) NULL

go

-- add column for field _note
ALTER TABLE [FatturaAcquisto] ADD [Note] varchar(max) NULL

go

-- add column for field _note
ALTER TABLE [FatturaVendita] ADD [Note] varchar(max) NULL

go

-- add column for field _note
ALTER TABLE [Fornitore] ADD [Note] varchar(max) NULL

go

-- add column for field _note
ALTER TABLE [SAL] ADD [Note] varchar(max) NULL

go

-- add column for field _totaleLiquidazioni
ALTER TABLE [SAL] ADD [TotaleLiquidazioni] numeric(20,10) NULL

go

-- dropping unknown column [TotaleIncassi]
ALTER TABLE [SAL] DROP COLUMN [TotaleIncassi]

go

