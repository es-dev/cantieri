ALTER TABLE [Cliente] DROP CONSTRAINT [ref_Cliente_Commessa]

go

-- add column for field _commessa
ALTER TABLE [Cliente] ADD [CommessaId] int NULL

go

UPDATE [Cliente] SET [CommessaId] = 0

go

ALTER TABLE [Cliente] ALTER COLUMN [CommessaId] int NOT NULL

go

-- add column for field _totaleNoteCredito
ALTER TABLE [FatturaAcquisto] ADD [TotaleNoteCredito] numeric NULL

go

-- add column for field _totaleNoteCredito
ALTER TABLE [Fornitore] ADD [TotaleNoteCredito] numeric NULL

go

-- Column was read from database as: [TotalePagamenti] decimal(20,10) not null
-- modify column for field _totalePagamenti
ALTER TABLE [Fornitore] ALTER COLUMN [TotalePagamenti] numeric(20,10) NULL

go

-- DataLayer.NotaCredito
CREATE TABLE [NotaCredito] (
    [Codice] varchar(max) NULL,             -- _codice
    [Data] datetime NULL,                   -- _data
    [Descrizione] varchar(max) NULL,        -- _descrizione
    [FatturaAcquistoId] int NOT NULL,       -- _fatturaAcquisto
    [Id] int IDENTITY NOT NULL,             -- _id
    [Importo] numeric(20,10) NULL,          -- _importo
    [Note] varchar(max) NULL,               -- _note
    [TipoPagamento] varchar(max) NULL,      -- _tipoPagamento
    CONSTRAINT [pk_NotaCredito] PRIMARY KEY ([Id])
)

go

ALTER TABLE [Cliente] ADD CONSTRAINT [ref_Cliente_Commessa] FOREIGN KEY ([CommessaId]) REFERENCES [Commessa]([Id])

go

ALTER TABLE [NotaCredito] ADD CONSTRAINT [ref_NtCrdt_FttrAcqsto_F6E19BC0] FOREIGN KEY ([FatturaAcquistoId]) REFERENCES [FatturaAcquisto]([Id])

go

-- Index 'idx_Cliente_CommessaId' was not detected in the database. It will be created
CREATE INDEX [idx_Cliente_CommessaId] ON [Cliente]([CommessaId])

go

-- Index 'idx_NtCrdito_FatturaAcquistoId' was not detected in the database. It will be created
CREATE INDEX [idx_NtCrdito_FatturaAcquistoId] ON [NotaCredito]([FatturaAcquistoId])

go

