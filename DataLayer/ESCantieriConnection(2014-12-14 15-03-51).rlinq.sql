-- DataLayer.AnagraficaArticolo
CREATE TABLE [AnagraficaArticolo] (
    [Codice] varchar(255) NULL,             -- _codice
    [Descrizione] varchar(max) NULL,        -- _descrizione
    [Id] int IDENTITY NOT NULL,             -- _id
    CONSTRAINT [pk_AnagraficaArticolo] PRIMARY KEY ([Id])
)

go

-- DataLayer.AnagraficaCliente
CREATE TABLE [AnagraficaCliente] (
    [CAP] varchar(5) NULL,                  -- _cAP
    [Comune] varchar(max) NULL,             -- _comune
    [Email] varchar(max) NULL,              -- _email
    [Fax] varchar(255) NULL,                -- _fax
    [Id] int IDENTITY NOT NULL,             -- _id
    [Indirizzo] varchar(max) NULL,          -- _indirizzo
    [Mobile] varchar(255) NULL,             -- _mobile
    [PIva] varchar(11) NULL,                -- _pIva
    [Provincia] varchar(2) NULL,            -- _provincia
    [RagioneSociale] varchar(max) NULL,     -- _ragioneSociale
    [Telefono] varchar(255) NULL,           -- _telefono
    CONSTRAINT [pk_AnagraficaCliente] PRIMARY KEY ([Id])
)

go

-- DataLayer.AnagraficaFornitore
CREATE TABLE [AnagraficaFornitore] (
    [CAP] varchar(5) NULL,                  -- _cAP
    [Comune] varchar(max) NULL,             -- _comune
    [Email] varchar(max) NULL,              -- _email
    [Fax] varchar(255) NULL,                -- _fax
    [Id] int IDENTITY NOT NULL,             -- _id
    [Indirizzo] varchar(max) NULL,          -- _indirizzo
    [Mobile] varchar(255) NULL,             -- _mobile
    [PIva] varchar(11) NULL,                -- _pIva
    [Provincia] varchar(2) NULL,            -- _provincia
    [RagioneSociale] varchar(max) NULL,     -- _ragioneSociale
    [Telefono] varchar(255) NULL,           -- _telefono
    CONSTRAINT [pk_AnagraficaFornitore] PRIMARY KEY ([Id])
)

go

-- DataLayer.Articolo
CREATE TABLE [Articolo] (
    [Codice] varchar(max) NULL,             -- _codice
    [Costo] numeric(20,10) NULL,            -- _costo
    [Descrizione] varchar(255) NULL,        -- _descrizione
    [FatturaId] int NOT NULL,               -- _fattura
    [IVA] numeric(20,10) NULL,              -- _iVA
    [Id] int IDENTITY NOT NULL,             -- _id
    [Importo] numeric(20,10) NULL,          -- _importo
    [Quantita] int NULL,                    -- _quantita
    [Sconto] numeric(20,10) NULL,           -- _sconto
    [Totale] numeric(20,10) NULL,           -- _totale
    CONSTRAINT [pk_Articolo] PRIMARY KEY ([Id])
)

go

-- DataLayer.Azienda
CREATE TABLE [Azienda] (
    [CAP] varchar(5) NULL,                  -- _cAP
    [Comune] varchar(max) NULL,             -- _comune
    [Denominazione] varchar(max) NULL,      -- _denominazione
    [Dipendenti] int NULL,                  -- _dipendenti
    [Id] int IDENTITY NOT NULL,             -- _id
    [Indirizzo] varchar(max) NULL,          -- _indirizzo
    [PIva] varchar(11) NULL,                -- _pIva
    [Provincia] varchar(2) NULL,            -- _provincia
    CONSTRAINT [pk_Azienda] PRIMARY KEY ([Id])
)

go

-- DataLayer.CentroCosto
CREATE TABLE [CentroCosto] (
    [Codice] varchar(255) NULL,             -- _codice
    [Denominazione] varchar(max) NULL,      -- _denominazione
    [Id] int IDENTITY NOT NULL,             -- _id
    CONSTRAINT [pk_CentroCosto] PRIMARY KEY ([Id])
)

go

-- DataLayer.Cliente
CREATE TABLE [Cliente] (
    [CAP] varchar(5) NULL,                  -- _cAP
    [Comune] varchar(max) NULL,             -- _comune
    [Email] varchar(255) NULL,              -- _email
    [Fax] varchar(255) NULL,                -- _fax
    [Id] int NOT NULL,                      -- _id
    [Indirizzo] varchar(max) NULL,          -- _indirizzo
    [Mobile] varchar(255) NULL,             -- _mobile
    [PIva] varchar(11) NULL,                -- _pIva
    [Provincia] varchar(2) NULL,            -- _provincia
    [RagioneSociale] varchar(max) NULL,     -- _ragioneSociale
    [Telefono] varchar(255) NULL,           -- _telefono
    CONSTRAINT [pk_Cliente] PRIMARY KEY ([Id])
)

go

-- DataLayer.Commessa
CREATE TABLE [Commessa] (
    [AziendaId] int NOT NULL,               -- _azienda
    [CAP] varchar(5) NULL,                  -- _cAP
    [Comune] varchar(max) NULL,             -- _comune
    [Creazione] datetime NULL,              -- _creazione
    [Denominazione] varchar(max) NULL,      -- _denominazione
    [Descrizione] varchar(max) NULL,        -- _descrizione
    [Id] int IDENTITY NOT NULL,             -- _id
    [Importo] numeric(20,10) NULL,          -- _importo
    [Indirizzo] varchar(max) NULL,          -- _indirizzo
    [Margine] numeric(20,10) NULL,          -- _margine
    [Numero] varchar(max) NULL,             -- _numero
    [Provincia] varchar(2) NULL,            -- _provincia
    [Riferimento] varchar(max) NULL,        -- _riferimento
    [Scadenza] datetime NULL,               -- _scadenza
    [Stato] varchar(max) NULL,              -- _stato
    CONSTRAINT [pk_Commessa] PRIMARY KEY ([Id])
)

go

-- DataLayer.FatturaAcquisto
CREATE TABLE [FatturaAcquisto] (
    [data] datetime NULL,                   -- _data
    [Descrizione] varchar(max) NULL,        -- _descrizione
    [FornitoreId] int NOT NULL,             -- _fornitore
    [IVA] numeric(20,10) NULL,              -- _iVA
    [Id] int IDENTITY NOT NULL,             -- _id
    [Imponibile] numeric(20,10) NULL,       -- _imponibile
    [Numero] varchar(255) NULL,             -- _numero
    [Saldo] numeric(20,10) NULL,            -- _saldo
    [TipoPagamento] varchar(max) NULL,      -- _tipoPagamento
    [Totale] numeric(20,10) NULL,           -- _totale
    CONSTRAINT [pk_FatturaAcquisto] PRIMARY KEY ([Id])
)

go

-- DataLayer.FatturaVendita
CREATE TABLE [FatturaVendita] (
    [ClienteId] int NOT NULL,               -- _cliente
    [dta] datetime NULL,                    -- _data
    [Descrizione] varchar(max) NULL,        -- _descrizione
    [IVA] numeric(20,10) NULL,              -- _iVA
    [Id] int IDENTITY NOT NULL,             -- _id
    [Imponibile] numeric(20,10) NULL,       -- _imponibile
    [Numero] varchar(255) NULL,             -- _numero
    [Saldo] numeric(20,10) NULL,            -- _saldo
    [TipoPagamento] varchar(max) NULL,      -- _tipoPagamento
    [Totale] numeric(20,10) NULL,           -- _totale
    CONSTRAINT [pk_FatturaVendita] PRIMARY KEY ([Id])
)

go

-- DataLayer.Fornitore
CREATE TABLE [Fornitore] (
    [CAP] varchar(5) NULL,                  -- _cAP
    [CodiceCentroCosto] varchar(255) NULL,  -- _codiceCentroCosto
    [CommessaId] int NOT NULL,              -- _commessa
    [Comune] varchar(max) NULL,             -- _comune
    [Email] varchar(max) NULL,              -- _email
    [Fax] varchar(255) NULL,                -- _fax
    [Id] int IDENTITY NOT NULL,             -- _id
    [Indirizzo] varchar(max) NULL,          -- _indirizzo
    [Mobile] varchar(255) NULL,             -- _mobile
    [PIva] varchar(11) NULL,                -- _pIva
    [Provincia] varchar(2) NULL,            -- _provincia
    [RagioneSociale] varchar(max) NULL,     -- _ragioneSociale
    [Telefono] varchar(255) NULL,           -- _telefono
    CONSTRAINT [pk_Fornitore] PRIMARY KEY ([Id])
)

go

-- DataLayer.Liquidazione
CREATE TABLE [Liquidazione] (
    [dta] datetime NULL,                    -- _data
    [Eseguito] tinyint NULL,                -- _eseguito
    [FatturaVenditaId] int NOT NULL,        -- _fatturaVendita
    [Id] int IDENTITY NOT NULL,             -- _id
    [Importo] numeric(20,10) NULL,          -- _importo
    [Modalita] varchar(max) NULL,           -- _modalita
    [Scadenza] datetime NULL,               -- _scadenza
    CONSTRAINT [pk_Liquidazione] PRIMARY KEY ([Id])
)

go

-- DataLayer.Pagamento
CREATE TABLE [Pagamento] (
    [dta] datetime NULL,                    -- _data
    [Eseguito] tinyint NULL,                -- _eseguito
    [FatturaAcquistoId] int NOT NULL,       -- _fatturaAcquisto
    [Id] int IDENTITY NOT NULL,             -- _id
    [Importo] numeric(20,10) NULL,          -- _importo
    [Modalita] varchar(max) NULL,           -- _modalita
    [Scadenza] datetime NULL,               -- _scadenza
    CONSTRAINT [pk_Pagamento] PRIMARY KEY ([Id])
)

go

-- DataLayer.SAL
CREATE TABLE [SAL] (
    [CommessaId] int NOT NULL,              -- _commessa
    [dta] datetime NULL,                    -- _data
    [Denominazione] varchar(max) NULL,      -- _denominazione
    [Id] int IDENTITY NOT NULL,             -- _id
    [lck] tinyint NULL,                     -- _lock
    [TotaleAcquisti] numeric(20,10) NULL,   -- _totaleAcquisti
    [TotaleVendite] numeric(20,10) NULL,    -- _totaleVendite
    CONSTRAINT [pk_SAL] PRIMARY KEY ([Id])
)

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

-- Index 'idx_Articolo_FatturaId' was not detected in the database. It will be created
CREATE INDEX [idx_Articolo_FatturaId] ON [Articolo]([FatturaId])

go

-- Index 'idx_Commessa_AziendaId' was not detected in the database. It will be created
CREATE INDEX [idx_Commessa_AziendaId] ON [Commessa]([AziendaId])

go

-- Index 'idx_FtturaAcquisto_FornitoreId' was not detected in the database. It will be created
CREATE INDEX [idx_FtturaAcquisto_FornitoreId] ON [FatturaAcquisto]([FornitoreId])

go

-- Index 'idx_FatturaVendita_ClienteId' was not detected in the database. It will be created
CREATE INDEX [idx_FatturaVendita_ClienteId] ON [FatturaVendita]([ClienteId])

go

-- Index 'idx_Fornitore_CommessaId' was not detected in the database. It will be created
CREATE INDEX [idx_Fornitore_CommessaId] ON [Fornitore]([CommessaId])

go

-- Index 'idx_Lqdazione_FatturaVenditaId' was not detected in the database. It will be created
CREATE INDEX [idx_Lqdazione_FatturaVenditaId] ON [Liquidazione]([FatturaVenditaId])

go

-- Index 'idx_Pgamento_FatturaAcquistoId' was not detected in the database. It will be created
CREATE INDEX [idx_Pgamento_FatturaAcquistoId] ON [Pagamento]([FatturaAcquistoId])

go

-- Index 'idx_SAL_CommessaId' was not detected in the database. It will be created
CREATE INDEX [idx_SAL_CommessaId] ON [SAL]([CommessaId])

go

