-- add column for field _codiceCatastale
ALTER TABLE [Azienda] ADD [CodiceCatastale] varchar(max) NULL

go

-- add column for field _stato
ALTER TABLE [Cliente] ADD [Stato] varchar(max) NULL

go

-- add column for field _totaleFattureVendita
ALTER TABLE [Cliente] ADD [TotaleFattureVendita] numeric(20,10) NULL

go

-- add column for field _totaleLiquidazioni
ALTER TABLE [Cliente] ADD [TotaleLiquidazioni] numeric(20,10) NULL

go

-- add column for field _stato
ALTER TABLE [FatturaVendita] ADD [Stato] varchar(max) NULL

go

-- add column for field _totaleLiquidazioni
ALTER TABLE [FatturaVendita] ADD [TotaleLiquidazioni] numeric(20,10) NULL

go

