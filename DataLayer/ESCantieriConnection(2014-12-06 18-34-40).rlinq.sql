-- DataLayer.AnagraficaArticolo
CREATE TABLE [AnagraficaArticolo] (
    [Id] int IDENTITY NOT NULL,             -- _id
    [Descrizione] varchar(max) NULL,        -- _descrizione
    [Codice] varchar(255) NULL,             -- _codice
    CONSTRAINT [pk_AnagraficaArticolo] PRIMARY KEY ([Id])
)
go

-- DataLayer.AnagraficaCliente
CREATE TABLE [AnagraficaCliente] (
    [Telefono] varchar(255) NULL,           -- _telefono
    [RagioneSociale] varchar(max) NULL,     -- _ragioneSociale
    [Provincia] varchar(2) NULL,            -- _provincia
    [PIva] varchar(11) NULL,                -- _pIva
    [Mobile] varchar(255) NULL,             -- _mobile
    [Indirizzo] varchar(max) NULL,          -- _indirizzo
    [Id] int IDENTITY NOT NULL,             -- _id
    [Fax] varchar(255) NULL,                -- _fax
    [Email] varchar(max) NULL,              -- _email
    [Comune] varchar(max) NULL,             -- _comune
    [CAP] varchar(5) NULL,                  -- _cAP
    CONSTRAINT [pk_AnagraficaCliente] PRIMARY KEY ([Id])
)
go

-- DataLayer.AnagraficaFornitore
CREATE TABLE [AnagraficaFornitore] (
    [Telefono] varchar(255) NULL,           -- _telefono
    [RagioneSociale] varchar(max) NULL,     -- _ragioneSociale
    [Provincia] varchar(2) NULL,            -- _provincia
    [PIva] varchar(11) NULL,                -- _pIva
    [Mobile] varchar(255) NULL,             -- _mobile
    [Indirizzo] varchar(max) NULL,          -- _indirizzo
    [Id] int IDENTITY NOT NULL,             -- _id
    [Fax] varchar(255) NULL,                -- _fax
    [Email] varchar(max) NULL,              -- _email
    [Comune] varchar(max) NULL,             -- _comune
    [CAP] varchar(5) NULL,                  -- _cAP
    CONSTRAINT [pk_AnagraficaFornitore] PRIMARY KEY ([Id])
)
go

-- DataLayer.Articolo
CREATE TABLE [Articolo] (
    [Totale] numeric(20,10) NULL,           -- _totale
    [Sconto] numeric(20,10) NULL,           -- _sconto
    [Quantita] int NULL,                    -- _quantita
    [Importo] numeric(20,10) NULL,          -- _importo
    [Id] int IDENTITY NOT NULL,             -- _id
    [IVA] numeric(20,10) NULL,              -- _iVA
    [FatturaId] int NOT NULL,               -- _fattura
    [Descrizione] varchar(255) NULL,        -- _descrizione
    [Costo] numeric(20,10) NULL,            -- _costo
    [Codice] varchar(max) NULL,             -- _codice
    CONSTRAINT [pk_Articolo] PRIMARY KEY ([Id])
)
go

-- DataLayer.Azienda
CREATE TABLE [Azienda] (
    [Provincia] varchar(2) NULL,            -- _provincia
    [PIva] varchar(11) NULL,                -- _pIva
    [Indirizzo] varchar(max) NULL,          -- _indirizzo
    [Id] int IDENTITY NOT NULL,             -- _id
    [Dipendenti] int NULL,                  -- _dipendenti
    [Denominazione] varchar(max) NULL,      -- _denominazione
    [Comune] varchar(max) NULL,             -- _comune
    [CAP] varchar(5) NULL,                  -- _cAP
    CONSTRAINT [pk_Azienda] PRIMARY KEY ([Id])
)
go

-- DataLayer.CentroCosto
CREATE TABLE [CentroCosto] (
    [Id] int IDENTITY NOT NULL,             -- _id
    [Denominazione] varchar(max) NULL,      -- _denominazione
    [Codice] varchar(255) NULL,             -- _codice
    CONSTRAINT [pk_CentroCosto] PRIMARY KEY ([Id])
)
go

-- DataLayer.Cliente
CREATE TABLE [Cliente] (
    [Telefono] varchar(255) NULL,           -- _telefono
    [RagioneSociale] varchar(max) NULL,     -- _ragioneSociale
    [Provincia] varchar(2) NULL,            -- _provincia
    [PIva] varchar(11) NULL,                -- _pIva
    [Mobile] varchar(255) NULL,             -- _mobile
    [Indirizzo] varchar(max) NULL,          -- _indirizzo
    [Id] int NOT NULL,                      -- _id
    [Fax] varchar(255) NULL,                -- _fax
    [Email] varchar(255) NULL,              -- _email
    [Comune] varchar(max) NULL,             -- _comune
    [CAP] varchar(5) NULL,                  -- _cAP
    CONSTRAINT [pk_Cliente] PRIMARY KEY ([Id])
)
go

-- DataLayer.Commessa
CREATE TABLE [Commessa] (
    [Stato] varchar(max) NULL,              -- _stato
    [Scadenza] datetime NOT NULL,           -- _scadenza
    [Riferimento] varchar(max) NULL,        -- _riferimento
    [Provincia] varchar(2) NULL,            -- _provincia
    [Numero] varchar(max) NULL,             -- _numero
    [Margine] numeric(20,10) NULL,          -- _margine
    [Indirizzo] varchar(max) NULL,          -- _indirizzo
    [Importo] numeric(20,10) NULL,          -- _importo
    [Id] int IDENTITY NOT NULL,             -- _id
    [Descrizione] varchar(max) NULL,        -- _descrizione
    [Denominazione] varchar(max) NULL,      -- _denominazione
    [Creazione] datetime NOT NULL,          -- _creazione
    [Comune] varchar(max) NULL,             -- _comune
    [CAP] varchar(5) NULL,                  -- _cAP
    [AziendaId] int NOT NULL,               -- _azienda
    CONSTRAINT [pk_Commessa] PRIMARY KEY ([Id])
)
go

-- DataLayer.FatturaAcquisto
CREATE TABLE [FatturaAcquisto] (
    [Totale] numeric(20,10) NULL,           -- _totale
    [TipoPagamento] varchar(max) NULL,      -- _tipoPagamento
    [Saldo] numeric(20,10) NULL,            -- _saldo
    [Numero] varchar(255) NULL,             -- _numero
    [Imponibile] numeric(20,10) NULL,       -- _imponibile
    [Id] int IDENTITY NOT NULL,             -- _id
    [IVA] numeric(20,10) NULL,              -- _iVA
    [FornitoreId] int NOT NULL,             -- _fornitore
    [Descrizione] varchar(max) NULL,        -- _descrizione
    [data] datetime NOT NULL,               -- _data
    CONSTRAINT [pk_FatturaAcquisto] PRIMARY KEY ([Id])
)
go

-- DataLayer.FatturaVendita
CREATE TABLE [FatturaVendita] (
    [Totale] numeric(20,10) NULL,           -- _totale
    [TipoPagamento] varchar(max) NULL,      -- _tipoPagamento
    [Saldo] numeric(20,10) NULL,            -- _saldo
    [Numero] varchar(255) NULL,             -- _numero
    [Imponibile] numeric(20,10) NULL,       -- _imponibile
    [Id] int IDENTITY NOT NULL,             -- _id
    [IVA] numeric(20,10) NULL,              -- _iVA
    [Descrizione] varchar(max) NULL,        -- _descrizione
    [dta] datetime NOT NULL,                -- _data
    [ClienteId] int NOT NULL,               -- _cliente
    CONSTRAINT [pk_FatturaVendita] PRIMARY KEY ([Id])
)
go

-- DataLayer.Fornitore
CREATE TABLE [Fornitore] (
    [Telefono] varchar(255) NULL,           -- _telefono
    [RagioneSociale] varchar(max) NULL,     -- _ragioneSociale
    [Provincia] varchar(2) NULL,            -- _provincia
    [PIva] varchar(11) NULL,                -- _pIva
    [Mobile] varchar(255) NULL,             -- _mobile
    [Indirizzo] varchar(max) NULL,          -- _indirizzo
    [Id] int IDENTITY NOT NULL,             -- _id
    [Fax] varchar(255) NULL,                -- _fax
    [Email] varchar(max) NULL,              -- _email
    [Comune] varchar(max) NULL,             -- _comune
    [CommessaId] int NOT NULL,              -- _commessa
    [CodiceCentroCosto] varchar(255) NULL,  -- _codiceCentroCosto
    [CAP] varchar(5) NULL,                  -- _cAP
    CONSTRAINT [pk_Fornitore] PRIMARY KEY ([Id])
)
go

-- DataLayer.Liquidazione
CREATE TABLE [Liquidazione] (
    [Scadenza] datetime NOT NULL,           -- _scadenza
    [Modalita] varchar(max) NULL,           -- _modalita
    [Importo] numeric(20,10) NULL,          -- _importo
    [Id] int IDENTITY NOT NULL,             -- _id
    [FatturaVenditaId] int NOT NULL,        -- _fatturaVendita
    [Eseguito] tinyint NOT NULL,            -- _eseguito
    [dta] datetime NOT NULL,                -- _data
    CONSTRAINT [pk_Liquidazione] PRIMARY KEY ([Id])
)
go

-- DataLayer.Pagamento
CREATE TABLE [Pagamento] (
    [Scadenza] datetime NOT NULL,           -- _scadenza
    [Modalita] varchar(max) NULL,           -- _modalita
    [Importo] numeric(20,10) NULL,          -- _importo
    [Id] int IDENTITY NOT NULL,             -- _id
    [FatturaAcquistoId] int NOT NULL,       -- _fatturaAcquisto
    [Eseguito] tinyint NOT NULL,            -- _eseguito
    [dta] datetime NOT NULL,                -- _data
    CONSTRAINT [pk_Pagamento] PRIMARY KEY ([Id])
)
go

-- DataLayer.SAL
CREATE TABLE [SAL] (
    [TotaleVendite] numeric(20,10) NULL,    -- _totaleVendite
    [TotaleAcquisti] numeric(20,10) NULL,   -- _totaleAcquisti
    [lck] tinyint NOT NULL,                 -- _lock
    [Id] int IDENTITY NOT NULL,             -- _id
    [Denominazione] varchar(max) NULL,      -- _denominazione
    [dta] datetime NOT NULL,                -- _data
    [CommessaId] int NOT NULL,              -- _commessa
    CONSTRAINT [pk_SAL] PRIMARY KEY ([Id])
)
go

CREATE INDEX [idx_Articolo_FatturaId] ON [Articolo]([FatturaId])
go

CREATE INDEX [idx_Commessa_AziendaId] ON [Commessa]([AziendaId])
go

CREATE INDEX [idx_FtturaAcquisto_FornitoreId] ON [FatturaAcquisto]([FornitoreId])
go

CREATE INDEX [idx_FatturaVendita_ClienteId] ON [FatturaVendita]([ClienteId])
go

CREATE INDEX [idx_Fornitore_CommessaId] ON [Fornitore]([CommessaId])
go

CREATE INDEX [idx_Lqdazione_FatturaVenditaId] ON [Liquidazione]([FatturaVenditaId])
go

CREATE INDEX [idx_Pgamento_FatturaAcquistoId] ON [Pagamento]([FatturaAcquistoId])
go

CREATE INDEX [idx_SAL_CommessaId] ON [SAL]([CommessaId])
go

ALTER TABLE [Articolo] ADD CONSTRAINT [ref_Articolo_FatturaAcquisto] FOREIGN KEY ([FatturaId]) REFERENCES [FatturaAcquisto]([Id])
go

ALTER TABLE [Cliente] ADD CONSTRAINT [ref_Cliente_Commessa] FOREIGN KEY ([Id]) REFERENCES [Commessa]([Id])
go

ALTER TABLE [Commessa] ADD CONSTRAINT [ref_Commessa_Azienda] FOREIGN KEY ([AziendaId]) REFERENCES [Azienda]([Id])
go

ALTER TABLE [FatturaAcquisto] ADD CONSTRAINT [ref_FatturaAcquisto_Fornitore] FOREIGN KEY ([FornitoreId]) REFERENCES [Fornitore]([Id])
go

ALTER TABLE [FatturaVendita] ADD CONSTRAINT [ref_FatturaVendita_Cliente] FOREIGN KEY ([ClienteId]) REFERENCES [Cliente]([Id])
go

ALTER TABLE [Fornitore] ADD CONSTRAINT [ref_Fornitore_Commessa] FOREIGN KEY ([CommessaId]) REFERENCES [Commessa]([Id])
go

ALTER TABLE [Liquidazione] ADD CONSTRAINT [ref_Lquidazione_FatturaVendita] FOREIGN KEY ([FatturaVenditaId]) REFERENCES [FatturaVendita]([Id])
go

ALTER TABLE [Pagamento] ADD CONSTRAINT [ref_Pagamento_FatturaAcquisto] FOREIGN KEY ([FatturaAcquistoId]) REFERENCES [FatturaAcquisto]([Id])
go

ALTER TABLE [SAL] ADD CONSTRAINT [ref_SAL_Commessa] FOREIGN KEY ([CommessaId]) REFERENCES [Commessa]([Id])
go

