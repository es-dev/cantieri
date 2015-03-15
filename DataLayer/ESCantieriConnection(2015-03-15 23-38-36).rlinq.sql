-- DataLayer.Reso
CREATE TABLE [Reso] (
    [Codice] varchar(max) NULL,             -- _codice
    [Data] datetime NULL,                   -- _data
    [Descrizione] varchar(max) NULL,        -- _descrizione
    [FatturaAcquistoId] int NOT NULL,       -- _fatturaAcquisto
    [Id] int IDENTITY NOT NULL,             -- _id
    [Importo] numeric(20,10) NULL,          -- _importo
    [NotaCreditoId] int NOT NULL,           -- _notaCredito
    [Note] varchar(max) NULL,               -- _note
    [TipoPagamento] varchar(max) NULL,      -- _tipoPagamento
    CONSTRAINT [pk_Reso] PRIMARY KEY ([Id])
)

go

ALTER TABLE [Reso] ADD CONSTRAINT [ref_Reso_FatturaAcquisto] FOREIGN KEY ([FatturaAcquistoId]) REFERENCES [FatturaAcquisto]([Id])

go

ALTER TABLE [Reso] ADD CONSTRAINT [ref_Reso_NotaCredito] FOREIGN KEY ([NotaCreditoId]) REFERENCES [NotaCredito]([Id])

go

-- Index 'idx_Reso_NotaCreditoId' was not detected in the database. It will be created
CREATE INDEX [idx_Reso_NotaCreditoId] ON [Reso]([NotaCreditoId])

go

-- Index 'idx_Reso_FatturaAcquistoId' was not detected in the database. It will be created
CREATE INDEX [idx_Reso_FatturaAcquistoId] ON [Reso]([FatturaAcquistoId])

go

