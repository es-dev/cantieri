-- add column for field _totaleIncassi
ALTER TABLE [Committente] ADD [TotaleIncassi] numeric(20,10) NULL

go

-- dropping unknown column [TotaleLiquidazioni]
ALTER TABLE [Committente] DROP COLUMN [TotaleLiquidazioni]

go

-- add column for field _totaleIncassi
ALTER TABLE [FatturaVendita] ADD [TotaleIncassi] numeric(20,10) NULL

go

-- dropping unknown column [TotaleLiquidazioni]
ALTER TABLE [FatturaVendita] DROP COLUMN [TotaleLiquidazioni]

go

-- DataLayer.Incasso
CREATE TABLE [Incasso] (
    [Codice] varchar(max) NULL,             -- _codice
    [Data] datetime NULL,                   -- _data
    [Descrizione] varchar(max) NULL,        -- _descrizione
    [FatturaVenditaId] int NOT NULL,        -- _fatturaVendita
    [Id] int IDENTITY NOT NULL,             -- _id
    [Importo] numeric(20,10) NULL,          -- _importo
    [Note ] varchar(max) NULL,              -- _note
    [TipoPagamento] varchar(max) NULL,      -- _tipoPagamento
    [TransazionePagamento] varchar(max) NULL, -- _transazionePagamento
    CONSTRAINT [pk_Incasso] PRIMARY KEY ([Id])
)

go

-- add column for field _totaleIncassi
ALTER TABLE [SAL] ADD [TotaleIncassi] numeric(20,10) NULL

go

-- dropping unknown column [TotaleLiquidazioni]
ALTER TABLE [SAL] DROP COLUMN [TotaleLiquidazioni]

go

ALTER TABLE [Incasso] ADD CONSTRAINT [ref_Incasso_FatturaVendita] FOREIGN KEY ([FatturaVenditaId]) REFERENCES [FatturaVendita]([Id])

go

-- Index 'idx_Lqdazione_FatturaVenditaId' was not detected in the database. It will be created
CREATE INDEX [idx_Lqdazione_FatturaVenditaId] ON [Incasso]([FatturaVenditaId])

go

