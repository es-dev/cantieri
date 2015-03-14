ALTER TABLE [NotaCredito] DROP CONSTRAINT [ref_NtCrdt_FttrAcqsto_F6E19BC0]

go

-- Index 'idx_NtCrdito_FatturaAcquistoId' was detected in the database but with a different configuration. It will be recreated
DROP INDEX [idx_NtCrdito_FatturaAcquistoId] ON [NotaCredito]

go

-- add column for field _fornitore
ALTER TABLE [NotaCredito] ADD [FornitoreId] int NULL

go

UPDATE [NotaCredito] SET [FornitoreId] = 0

go

ALTER TABLE [NotaCredito] ALTER COLUMN [FornitoreId] int NOT NULL

go

-- dropping unknown column [FatturaAcquistoId]
ALTER TABLE [NotaCredito] DROP COLUMN [FatturaAcquistoId]

go

ALTER TABLE [NotaCredito] ADD CONSTRAINT [ref_NotaCredito_Fornitore] FOREIGN KEY ([FornitoreId]) REFERENCES [Fornitore]([Id])

go

-- Index 'idx_NtCrdito_FatturaAcquistoId' was detected in the database but with a different configuration. It will be recreated
CREATE INDEX [idx_NtCrdito_FatturaAcquistoId] ON [NotaCredito]([FornitoreId])

go

