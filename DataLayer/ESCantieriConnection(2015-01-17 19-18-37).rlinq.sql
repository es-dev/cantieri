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

-- add column for field _centroCosto
ALTER TABLE [FatturaAcquisto] ADD [CentroCostoId] int NULL

go

UPDATE [FatturaAcquisto] SET [CentroCostoId] = 0

go

ALTER TABLE [FatturaAcquisto] ALTER COLUMN [CentroCostoId] int NOT NULL

go

-- dropping unknown column [CodiceCentroCosto]
ALTER TABLE [Fornitore] DROP COLUMN [CodiceCentroCosto]

go

ALTER TABLE [FatturaAcquisto] ADD CONSTRAINT [ref_FttrAcqst_CntrCst_D90F110A] FOREIGN KEY ([CentroCostoId]) REFERENCES [CentroCosto]([Id])

go

-- Index 'idx_FttrAcquisto_CentroCostoId' was not detected in the database. It will be created
CREATE INDEX [idx_FttrAcquisto_CentroCostoId] ON [FatturaAcquisto]([CentroCostoId])

go

