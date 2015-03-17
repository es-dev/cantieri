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

ALTER TABLE [Cliente] ADD CONSTRAINT [ref_Cliente_Commessa] FOREIGN KEY ([CommessaId]) REFERENCES [Commessa]([Id])

go


-- Index 'idx_Cliente_CommessaId' was not detected in the database. It will be created
CREATE INDEX [idx_Cliente_CommessaId] ON [Cliente]([CommessaId])

go

