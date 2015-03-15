ALTER TABLE [NotaCredito] DROP CONSTRAINT [ref_NtCrdt_FttrAcqsto_F6E19BC0]

go

-- Index 'idx_NtCrdito_FatturaAcquistoId' was detected in the database but with a different configuration. It will be recreated
DROP INDEX [idx_NtCrdito_FatturaAcquistoId] ON [NotaCredito]

go

-- add column for field _sconto
ALTER TABLE [FatturaAcquisto] ADD [Sconto] numeric(20,10) NULL

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

-- DataLayer.PagamentoUnificatoFatturaAcquisto
CREATE TABLE [PagamentoUnificatoFatturaAcquisto] (
    [FatturaAcquistoId] int NOT NULL,       -- _fatturaAcquisto
    [Id] int IDENTITY NOT NULL,             -- _id
    [Note] varchar(max) NULL,               -- _note
    [PagamentoUnificatoId] int NOT NULL,    -- _pagamentoUnificato
    [Saldo] numeric(20,10) NULL,            -- _saldo
    CONSTRAINT [pk_PgmntUnfctFttrAcqs_22038CF4] PRIMARY KEY ([Id])
)

go

ALTER TABLE [NotaCredito] ADD CONSTRAINT [ref_NotaCredito_Fornitore] FOREIGN KEY ([FornitoreId]) REFERENCES [Fornitore]([Id])

go

ALTER TABLE [PagamentoUnificatoFatturaAcquisto] ADD CONSTRAINT [ref_PgmntUnfctFttrAcq_E372AC8A] FOREIGN KEY ([FatturaAcquistoId]) REFERENCES [FatturaAcquisto]([Id])

go

ALTER TABLE [PagamentoUnificatoFatturaAcquisto] ADD CONSTRAINT [ref_PgmntUnfctFttrAcq_3ABF1543] FOREIGN KEY ([PagamentoUnificatoId]) REFERENCES [PagamentoUnificato]([Id])

go

-- Index 'idx_NtCrdito_FatturaAcquistoId' was detected in the database but with a different configuration. It will be recreated
CREATE INDEX [idx_NtCrdito_FatturaAcquistoId] ON [NotaCredito]([FornitoreId])

go

-- Index 'idx_PgmntUnfctFttrAcqst_PgmntU' was not detected in the database. It will be created
CREATE INDEX [idx_PgmntUnfctFttrAcqst_PgmntU] ON [PagamentoUnificatoFatturaAcquisto]([PagamentoUnificatoId])

go

-- Index 'idx_PgmntUnfctFttrAcqst_FttrAc' was not detected in the database. It will be created
CREATE INDEX [idx_PgmntUnfctFttrAcqst_FttrAc] ON [PagamentoUnificatoFatturaAcquisto]([FatturaAcquistoId])

go

