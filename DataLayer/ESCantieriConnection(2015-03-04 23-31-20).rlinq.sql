-- DataLayer.Cliente
CREATE TABLE [Cliente] (
    [CAP] varchar(max) NULL,                -- _cAP
    [Codice] varchar(max) NULL,             -- _codice
    [CodiceCatastale] varchar(max) NULL,    -- _codiceCatastale
    [CommessaId] int NOT NULL,              -- _commessa
    [Comune] varchar(max) NULL,             -- _comune
    [Email] varchar(max) NULL,              -- _email
    [Fax] varchar(max) NULL,                -- _fax
    [Id] int IDENTITY NOT NULL,             -- _id
    [Indirizzo] varchar(max) NULL,          -- _indirizzo
    [Localita] varchar(max) NULL,           -- _localita
    [Mobile] varchar(max) NULL,             -- _mobile
    [Note] varchar(max) NULL,               -- _note
    [PartitaIva] varchar(max) NULL,         -- _partitaIva
    [Provincia] varchar(max) NULL,          -- _provincia
    [RagioneSociale] varchar(max) NULL,     -- _ragioneSociale
    [Stato] varchar(max) NULL,              -- _stato
    [Telefono] varchar(max) NULL,           -- _telefono
    [TotaleFattureVendita] numeric(20,10) NULL, -- _totaleFattureVendita
    [TotaleLiquidazioni] numeric(20,10) NULL, -- _totaleLiquidazioni
    CONSTRAINT [pk_Cliente] PRIMARY KEY ([Id])
)

go

-- DataLayer.FatturaVendita
CREATE TABLE [FatturaVendita] (
    [ClienteId] int NOT NULL,               -- _cliente
    [Data] datetime NULL,                   -- _data
    [Descrizione] varchar(max) NULL,        -- _descrizione
    [IVA] numeric(20,10) NULL,              -- _iVA
    [Id] int IDENTITY NOT NULL,             -- _id
    [Imponibile] numeric(20,10) NULL,       -- _imponibile
    [Note] varchar(max) NULL,               -- _note
    [Numero] varchar(max) NULL,             -- _numero
    [ScadenzaPagamento] varchar(max) NULL,  -- _scadenzaPagamento
    [Stato] varchar(max) NULL,              -- _stato
    [TipoPagamento] varchar(max) NULL,      -- _tipoPagamento
    [Totale] numeric(20,10) NULL,           -- _totale
    [TotaleLiquidazioni] numeric(20,10) NULL, -- _totaleLiquidazioni
    CONSTRAINT [pk_FatturaVendita] PRIMARY KEY ([Id])
)

go

-- DataLayer.Liquidazione
CREATE TABLE [Liquidazione] (
    [Codice] varchar(max) NULL,             -- _codice
    [Data] datetime NULL,                   -- _data
    [Descrizione] varchar(max) NULL,        -- _descrizione
    [FatturaVenditaId] int NOT NULL,        -- _fatturaVendita
    [Id] int IDENTITY NOT NULL,             -- _id
    [Importo] numeric(20,10) NULL,          -- _importo
    [Note ] varchar(max) NULL,              -- _note
    [TipoPagamento] varchar(max) NULL,      -- _tipoPagamento
    CONSTRAINT [pk_Liquidazione] PRIMARY KEY ([Id])
)

go

ALTER TABLE [Cliente] ADD CONSTRAINT [ref_Cliente_Commessa] FOREIGN KEY ([CommessaId]) REFERENCES [Commessa]([Id])

go

ALTER TABLE [FatturaVendita] ADD CONSTRAINT [ref_FatturaVendita_Cliente] FOREIGN KEY ([ClienteId]) REFERENCES [Cliente]([Id])

go

ALTER TABLE [Liquidazione] ADD CONSTRAINT [ref_Lqdzn_FttrVendita_DFB910CC] FOREIGN KEY ([FatturaVenditaId]) REFERENCES [FatturaVendita]([Id])

go

-- Index 'idx_Cliente_CommessaId' was not detected in the database. It will be created
CREATE INDEX [idx_Cliente_CommessaId] ON [Cliente]([CommessaId])

go

-- Index 'idx_FatturaVendita_ClienteId' was not detected in the database. It will be created
CREATE INDEX [idx_FatturaVendita_ClienteId] ON [FatturaVendita]([ClienteId])

go

-- Index 'idx_Lqdazione_FatturaVenditaId' was not detected in the database. It will be created
CREATE INDEX [idx_Lqdazione_FatturaVenditaId] ON [Liquidazione]([FatturaVenditaId])

go

