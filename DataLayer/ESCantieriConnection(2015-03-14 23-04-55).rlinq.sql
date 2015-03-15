-- DataLayer.NotaCredito
CREATE TABLE [NotaCredito] (
    [Codice] varchar(max) NULL,             -- _codice
    [Data] datetime NULL,                   -- _data
    [Descrizione] varchar(max) NULL,        -- _descrizione
    [FornitoreId] int NOT NULL,             -- _fornitore
    [Id] int IDENTITY NOT NULL,             -- _id
    [Importo] numeric(20,10) NULL,          -- _importo
    [Note] varchar(max) NULL,               -- _note
    [TipoPagamento] varchar(max) NULL,      -- _tipoPagamento
    CONSTRAINT [pk_NotaCredito] PRIMARY KEY ([Id])
)

go

ALTER TABLE [NotaCredito] ADD CONSTRAINT [ref_NotaCredito_Fornitore] FOREIGN KEY ([FornitoreId]) REFERENCES [Fornitore]([Id])

go

ALTER TABLE [PagamentoUnificatoFatturaAcquisto] ADD CONSTRAINT [ref_PgmntUnfctFttrAcq_E372AC8A] FOREIGN KEY ([FatturaAcquistoId]) REFERENCES [FatturaAcquisto]([Id])

go

ALTER TABLE [PagamentoUnificatoFatturaAcquisto] ADD CONSTRAINT [ref_PgmntUnfctFttrAcq_3ABF1543] FOREIGN KEY ([PagamentoUnificatoId]) REFERENCES [PagamentoUnificato]([Id])

go

-- Index 'idx_NtCrdito_FatturaAcquistoId' was not detected in the database. It will be created
CREATE INDEX [idx_NtCrdito_FatturaAcquistoId] ON [NotaCredito]([FornitoreId])

go

-- Index 'idx_PgmntUnfctFttrAcqst_PgmntU' was not detected in the database. It will be created
CREATE INDEX [idx_PgmntUnfctFttrAcqst_PgmntU] ON [PagamentoUnificatoFatturaAcquisto]([PagamentoUnificatoId])

go

-- Index 'idx_PgmntUnfctFttrAcqst_FttrAc' was not detected in the database. It will be created
CREATE INDEX [idx_PgmntUnfctFttrAcqst_FttrAc] ON [PagamentoUnificatoFatturaAcquisto]([FatturaAcquistoId])

go

