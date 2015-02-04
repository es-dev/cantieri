-- DataLayer.AnagraficaArticolo
CREATE TABLE [AnagraficaArticolo] (
    [Codice] varchar(max) NULL,             -- _codice
    [Descrizione] varchar(max) NULL,        -- _descrizione
    [Id] int IDENTITY NOT NULL,             -- _id
    CONSTRAINT [pk_AnagraficaArticolo] PRIMARY KEY ([Id])
)

go

-- DataLayer.AnagraficaCliente
CREATE TABLE [AnagraficaCliente] (
    [CAP] varchar(max) NULL,                -- _cAP
    [Codice] varchar(max) NULL,             -- _codice
    [Comune] varchar(max) NULL,             -- _comune
    [Email] varchar(max) NULL,              -- _email
    [Fax] varchar(max) NULL,                -- _fax
    [Id] int IDENTITY NOT NULL,             -- _id
    [Indirizzo] varchar(max) NULL,          -- _indirizzo
    [Mobile] varchar(max) NULL,             -- _mobile
    [PIva] varchar(max) NULL,               -- _pIva
    [Provincia] varchar(max) NULL,          -- _provincia
    [RagioneSociale] varchar(max) NULL,     -- _ragioneSociale
    [Telefono] varchar(max) NULL,           -- _telefono
    CONSTRAINT [pk_AnagraficaCliente] PRIMARY KEY ([Id])
)

go

-- DataLayer.AnagraficaFornitore
CREATE TABLE [AnagraficaFornitore] (
    [CAP] varchar(max) NULL,                -- _cAP
    [Codice] varchar(max) NULL,             -- _codice
    [Comune] varchar(max) NULL,             -- _comune
    [Email] varchar(max) NULL,              -- _email
    [Fax] varchar(max) NULL,                -- _fax
    [Id] int IDENTITY NOT NULL,             -- _id
    [Indirizzo] varchar(max) NULL,          -- _indirizzo
    [Mobile] varchar(max) NULL,             -- _mobile
    [PIva] varchar(max) NULL,               -- _pIva
    [Provincia] varchar(max) NULL,          -- _provincia
    [RagioneSociale] varchar(max) NULL,     -- _ragioneSociale
    [Telefono] varchar(max) NULL,           -- _telefono
    CONSTRAINT [pk_AnagraficaFornitore] PRIMARY KEY ([Id])
)

go

-- DataLayer.Articolo
CREATE TABLE [Articolo] (
    [Codice] varchar(max) NULL,             -- _codice
    [Costo] numeric(20,10) NULL,            -- _costo
    [Descrizione] varchar(max) NULL,        -- _descrizione
    [FatturaAcquistoId] int NOT NULL,       -- _fattura
    [IVA] numeric(20,10) NULL,              -- _iVA
    [Id] int IDENTITY NOT NULL,             -- _id
    [Importo] numeric(20,10) NULL,          -- _importo
    [PrezzoUnitario] numeric(20,10) NULL,   -- _prezzoUnitario
    [Quantita] numeric(20,10) NULL,         -- _quantita
    [Sconto] numeric(20,10) NULL,           -- _sconto
    [Totale] numeric(20,10) NULL,           -- _totale
    CONSTRAINT [pk_Articolo] PRIMARY KEY ([Id])
)

go

-- DataLayer.Azienda
CREATE TABLE [Azienda] (
    [CAP] varchar(max) NULL,                -- _cAP
    [Codice] varchar(max) NULL,             -- _codice
    [Comune] varchar(max) NULL,             -- _comune
    [Denominazione] varchar(max) NULL,      -- _denominazione
    [Dipendenti] int NULL,                  -- _dipendenti
    [Email] varchar(max) NULL,              -- _email
    [Fax] varchar(max) NULL,                -- _fax
    [Id] int IDENTITY NOT NULL,             -- _id
    [Indirizzo] varchar(max) NULL,          -- _indirizzo
    [PIva] varchar(max) NULL,               -- _pIva
    [Provincia] varchar(max) NULL,          -- _provincia
    [Telefono] varchar(max) NULL,           -- _telefono
    CONSTRAINT [pk_Azienda] PRIMARY KEY ([Id])
)

go

-- DataLayer.CentroCosto
CREATE TABLE [CentroCosto] (
    [Codice] varchar(max) NULL,             -- _codice
    [Denominazione] varchar(max) NULL,      -- _denominazione
    [Id] int IDENTITY NOT NULL,             -- _id
    CONSTRAINT [pk_CentroCosto] PRIMARY KEY ([Id])
)

go

-- DataLayer.Cliente
CREATE TABLE [Cliente] (
    [CAP] varchar(max) NULL,                -- _cAP
    [Codice] varchar(max) NULL,             -- _codice
    [Comune] varchar(max) NULL,             -- _comune
    [Email] varchar(max) NULL,              -- _email
    [Fax] varchar(max) NULL,                -- _fax
    [Id] int NOT NULL,                      -- _id
    [Indirizzo] varchar(max) NULL,          -- _indirizzo
    [Mobile] varchar(max) NULL,             -- _mobile
    [PIva] varchar(max) NULL,               -- _pIva
    [Provincia] varchar(max) NULL,          -- _provincia
    [RagioneSociale] varchar(max) NULL,     -- _ragioneSociale
    [Telefono] varchar(max) NULL,           -- _telefono
    CONSTRAINT [pk_Cliente] PRIMARY KEY ([Id])
)

go

-- DataLayer.Commessa
CREATE TABLE [Commessa] (
    [AziendaId] int NOT NULL,               -- _azienda
    [CAP] varchar(max) NULL,                -- _cAP
    [Codice] varchar(255) NULL,             -- _codice
    [Comune] varchar(max) NULL,             -- _comune
    [Creazione] datetime NULL,              -- _creazione
    [Denominazione] varchar(max) NULL,      -- _denominazione
    [Descrizione] varchar(max) NULL,        -- _descrizione
    [EstremiContratto] varchar(255) NULL,   -- _estremiContratto
    [FineLavori] datetime NULL,             -- _fineLavori
    [Id] int IDENTITY NOT NULL,             -- _id
    [Importo] numeric(20,10) NULL,          -- _importo
    [ImportoAvanzamento] numeric(20,10) NULL, -- _importoAvanzamento
    [ImportoPerizie] numeric(20,10) NULL,   -- _importoPerizie
    [Indirizzo] varchar(max) NULL,          -- _indirizzo
    [InizioLavori] datetime NULL,           -- _inizioLavori
    [Margine] numeric(20,10) NULL,          -- _margine
    [Numero] varchar(max) NULL,             -- _numero
    [Oggetto] varchar(max) NULL,            -- _oggetto
    [Percentuale] numeric(20,10) NULL,      -- _percentuale
    [Provincia] varchar(max) NULL,          -- _provincia
    [Riferimento] varchar(max) NULL,        -- _riferimento
    [Scadenza] datetime NULL,               -- _scadenza
    [Stato] varchar(max) NULL,              -- _stato
    CONSTRAINT [pk_Commessa] PRIMARY KEY ([Id])
)

go

-- DataLayer.FatturaAcquisto
CREATE TABLE [FatturaAcquisto] (
    [CentroCostoId] int NOT NULL,           -- _centroCosto
    [data] datetime NULL,                   -- _data
    [Descrizione] varchar(max) NULL,        -- _descrizione
    [FornitoreId] int NOT NULL,             -- _fornitore
    [IVA] numeric(20,10) NULL,              -- _iVA
    [Id] int IDENTITY NOT NULL,             -- _id
    [Imponibile] numeric(20,10) NULL,       -- _imponibile
    [Numero] varchar(max) NULL,             -- _numero
    [ScadenzaPagamento] varchar(max) NULL,  -- _scadenzaPagamento
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
    [Numero] varchar(max) NULL,             -- _numero
    [ScadenzaPagamento] varchar(max) NULL,  -- _scadenzaPagamento
    [TipoPagamento] varchar(max) NULL,      -- _tipoPagamento
    [Totale] numeric(20,10) NULL,           -- _totale
    CONSTRAINT [pk_FatturaVendita] PRIMARY KEY ([Id])
)

go

-- DataLayer.Fornitore
CREATE TABLE [Fornitore] (
    [CAP] varchar(max) NULL,                -- _cAP
    [Codice] varchar(max) NULL,             -- _codice
    [CommessaId] int NOT NULL,              -- _commessa
    [Comune] varchar(max) NULL,             -- _comune
    [Email] varchar(max) NULL,              -- _email
    [Fax] varchar(max) NULL,                -- _fax
    [Id] int IDENTITY NOT NULL,             -- _id
    [Indirizzo] varchar(max) NULL,          -- _indirizzo
    [Mobile] varchar(max) NULL,             -- _mobile
    [PIva] varchar(max) NULL,               -- _pIva
    [Provincia] varchar(max) NULL,          -- _provincia
    [RagioneSociale] varchar(max) NULL,     -- _ragioneSociale
    [Telefono] varchar(max) NULL,           -- _telefono
    CONSTRAINT [pk_Fornitore] PRIMARY KEY ([Id])
)

go

-- DataLayer.Liquidazione
CREATE TABLE [Liquidazione] (
    [Codice] varchar(max) NULL,             -- _codice
    [dta] datetime NULL,                    -- _data
    [Descrizione] varchar(255) NULL,        -- _descrizione
    [FatturaVenditaId] int NOT NULL,        -- _fatturaVendita
    [Id] int IDENTITY NOT NULL,             -- _id
    [Importo] numeric(20,10) NULL,          -- _importo
    [Note ] varchar(max) NULL,              -- _note
    [TipoPagamento] varchar(max) NULL,      -- _tipoPagamento
    CONSTRAINT [pk_Liquidazione] PRIMARY KEY ([Id])
)

go

-- DataLayer.Pagamento
CREATE TABLE [Pagamento] (
    [Codice] varchar(max) NULL,             -- _codice
    [dta] datetime NULL,                    -- _data
    [Descrizione] varchar(max) NULL,        -- _descrizione
    [FatturaAcquistoId] int NOT NULL,       -- _fatturaAcquisto
    [Id] int IDENTITY NOT NULL,             -- _id
    [Importo] numeric(20,10) NULL,          -- _importo
    [Note ] varchar(max) NULL,              -- _note
    [TipoPagamento] varchar(max) NULL,      -- _tipoPagamento
    CONSTRAINT [pk_Pagamento] PRIMARY KEY ([Id])
)

go

-- DataLayer.SAL
CREATE TABLE [SAL] (
    [Codice] varchar(max) NULL,             -- _codice
    [CommessaId] int NOT NULL,              -- _commessa
    [dta] datetime NULL,                    -- _data
    [Denominazione] varchar(max) NULL,      -- _denominazione
    [Id] int IDENTITY NOT NULL,             -- _id
    [Stato] varchar(max) NULL,              -- _stato
    [TotaleAcquisti] numeric(20,10) NULL,   -- _totaleAcquisti
    [TotaleIncassi] numeric(20,10) NULL,    -- _totaleIncassi
    [TotalePagamenti] numeric(20,10) NULL,  -- _totalePagamenti
    [TotaleVendite] numeric(20,10) NULL,    -- _totaleVendite
    CONSTRAINT [pk_SAL] PRIMARY KEY ([Id])
)

go

ALTER TABLE [Articolo] ADD CONSTRAINT [ref_Articolo_FatturaAcquisto] FOREIGN KEY ([FatturaAcquistoId]) REFERENCES [FatturaAcquisto]([Id])

go

ALTER TABLE [Cliente] ADD CONSTRAINT [ref_Cliente_Commessa] FOREIGN KEY ([Id]) REFERENCES [Commessa]([Id])

go

ALTER TABLE [Commessa] ADD CONSTRAINT [ref_Commessa_Azienda] FOREIGN KEY ([AziendaId]) REFERENCES [Azienda]([Id])

go

ALTER TABLE [FatturaAcquisto] ADD CONSTRAINT [ref_FttrAcqst_CntrCst_D90F110A] FOREIGN KEY ([CentroCostoId]) REFERENCES [CentroCosto]([Id])

go

ALTER TABLE [FatturaAcquisto] ADD CONSTRAINT [ref_FatturaAcquisto_Fornitore] FOREIGN KEY ([FornitoreId]) REFERENCES [Fornitore]([Id])

go

ALTER TABLE [FatturaVendita] ADD CONSTRAINT [ref_FatturaVendita_Cliente] FOREIGN KEY ([ClienteId]) REFERENCES [Cliente]([Id])

go

ALTER TABLE [Fornitore] ADD CONSTRAINT [ref_Fornitore_Commessa] FOREIGN KEY ([CommessaId]) REFERENCES [Commessa]([Id])

go

ALTER TABLE [Liquidazione] ADD CONSTRAINT [ref_Lqdzn_FttrVendita_DFB910CC] FOREIGN KEY ([FatturaVenditaId]) REFERENCES [FatturaVendita]([Id])

go

ALTER TABLE [Pagamento] ADD CONSTRAINT [ref_Pagamento_FatturaAcquisto] FOREIGN KEY ([FatturaAcquistoId]) REFERENCES [FatturaAcquisto]([Id])

go

ALTER TABLE [SAL] ADD CONSTRAINT [ref_SAL_Commessa] FOREIGN KEY ([CommessaId]) REFERENCES [Commessa]([Id])

go

-- Index 'idx_Articolo_FatturaId' was not detected in the database. It will be created
CREATE INDEX [idx_Articolo_FatturaId] ON [Articolo]([FatturaAcquistoId])

go

-- Index 'idx_Commessa_AziendaId' was not detected in the database. It will be created
CREATE INDEX [idx_Commessa_AziendaId] ON [Commessa]([AziendaId])

go

-- Index 'idx_FtturaAcquisto_FornitoreId' was not detected in the database. It will be created
CREATE INDEX [idx_FtturaAcquisto_FornitoreId] ON [FatturaAcquisto]([FornitoreId])

go

-- Index 'idx_FttrAcquisto_CentroCostoId' was not detected in the database. It will be created
CREATE INDEX [idx_FttrAcquisto_CentroCostoId] ON [FatturaAcquisto]([CentroCostoId])

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

