-- add column for field _ragioneSociale
ALTER TABLE [Azienda] ADD [RagioneSociale] varchar(max) NULL

go

-- dropping unknown column [Denominazione]
ALTER TABLE [Azienda] DROP COLUMN [Denominazione]

go

-- add column for field _pagamentoUnificato
ALTER TABLE [Pagamento] ADD [PagamentoUnificatoId] int NULL

go

-- DataLayer.PagamentoUnificato
CREATE TABLE [PagamentoUnificato] (
    [Codice] varchar(max) NULL,             -- _codice
    [CodiceFornitore] varchar(max) NULL,    -- _codiceFornitore
    [Data] datetime NULL,                   -- _data
    [Descrizione] varchar(max) NULL,        -- _descrizione
    [Id] int IDENTITY NOT NULL,             -- _id
    [Importo] numeric(20,10) NULL,          -- _importo
    [Note] varchar(max) NULL,               -- _note
    [TipoPagamento] varchar(max) NULL,      -- _tipoPagamento
    CONSTRAINT [pk_PagamentoUnificato] PRIMARY KEY ([Id])
)

go

-- DataLayer.PagamentoUnificatoFatturaAcquisto
CREATE TABLE [PgmntoUnificatoFatturaAcquisto] (
    [FatturaAcquistoId] int NOT NULL,       -- _fatturaAcquisto
    [Id] int IDENTITY NOT NULL,             -- _id
    [Note] varchar(max) NULL,               -- _note
    [PagamentoUnificatoId] int NOT NULL,    -- _pagamentoUnificato
    [Saldo] numeric(20,10) NULL,            -- _saldo
    CONSTRAINT [pk_PgmntUnfctFttrAcqs_06786C70] PRIMARY KEY ([Id])
)

go

ALTER TABLE [Pagamento] ADD CONSTRAINT [ref_Pgmnt_PgmntUnfcto_BFAD7281] FOREIGN KEY ([PagamentoUnificatoId]) REFERENCES [PagamentoUnificato]([Id])

go

ALTER TABLE [PgmntoUnificatoFatturaAcquisto] ADD CONSTRAINT [ref_PgmntUnfctFttrAcq_B197116A] FOREIGN KEY ([FatturaAcquistoId]) REFERENCES [FatturaAcquisto]([Id])

go

ALTER TABLE [PgmntoUnificatoFatturaAcquisto] ADD CONSTRAINT [ref_PgmntUnfctFttrAcq_125603B3] FOREIGN KEY ([PagamentoUnificatoId]) REFERENCES [PagamentoUnificato]([Id])

go

-- Index 'idx_Pgmnt_PagamentoUnificatoId' was not detected in the database. It will be created
CREATE INDEX [idx_Pgmnt_PagamentoUnificatoId] ON [Pagamento]([PagamentoUnificatoId])

go

-- Index 'idx_PgmntUnfctFttrAcqst_PgmntU' was not detected in the database. It will be created
CREATE INDEX [idx_PgmntUnfctFttrAcqst_PgmntU] ON [PgmntoUnificatoFatturaAcquisto]([PagamentoUnificatoId])

go

-- Index 'idx_PgmntUnfctFttrAcqst_FttrAc' was not detected in the database. It will be created
CREATE INDEX [idx_PgmntUnfctFttrAcqst_FttrAc] ON [PgmntoUnificatoFatturaAcquisto]([FatturaAcquistoId])

go

