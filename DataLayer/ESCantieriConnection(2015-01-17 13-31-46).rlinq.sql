-- add column for field _estremiContratto
ALTER TABLE [Commessa] ADD [EstremiContratto] varchar(255) NULL

go

-- add column for field _fineLavori
ALTER TABLE [Commessa] ADD [FineLavori] datetime NULL

go

-- add column for field _importoAvanzamento
ALTER TABLE [Commessa] ADD [ImportoAvanzamento] numeric(20,10) NULL

go

-- add column for field _importoPerizie
ALTER TABLE [Commessa] ADD [ImportoPerizie] numeric(20,10) NULL

go

-- add column for field _inizioLavori
ALTER TABLE [Commessa] ADD [InizioLavori] datetime NULL

go

-- add column for field _percentuale
ALTER TABLE [Commessa] ADD [Percentuale] numeric(20,10) NULL

go

