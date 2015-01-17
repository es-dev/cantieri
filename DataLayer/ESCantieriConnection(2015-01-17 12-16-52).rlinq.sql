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

