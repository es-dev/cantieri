-- DataLayer.Account
CREATE TABLE [Account] (
    [Abilitato] bit NULL,                   -- _abilitato
    [AziendaId] int NOT NULL,               -- _azienda
    [Creazione] datetime NULL,              -- _creazione
    [Id] int IDENTITY NOT NULL,             -- _id
    [Nickname] varchar(max) NULL,           -- _nickname
    [Note] varchar(max) NULL,               -- _note
    [Password] varchar(max) NULL,           -- _password
    [Ruolo] varchar(max) NULL,              -- _ruolo
    [Username] varchar(max) NULL,           -- _username
    CONSTRAINT [pk_Account] PRIMARY KEY ([Id])
)

go

-- DataLayer.ReportJob
CREATE TABLE [ReportJob] (
    [Codice] varchar(max) NULL,             -- _codice
    [CodiceFornitore] varchar(max) NULL,    -- _codiceFornitore
    [Creazione] datetime NULL,              -- _creazione
    [Denominazione] varchar(max) NULL,      -- _denominazione
    [Elaborazione] datetime NULL,           -- _elaborazione
    [Id] int NOT NULL,                      -- _id
    [Note] varchar(max) NULL,               -- _note
    [Tipo] varchar(max) NULL,               -- _tipo
    CONSTRAINT [pk_ReportJob] PRIMARY KEY ([Id])
)

go

ALTER TABLE [Account] ADD CONSTRAINT [ref_Account_Azienda] FOREIGN KEY ([AziendaId]) REFERENCES [Azienda]([Id])

go

-- Index 'idx_Account_AziendaId' was not detected in the database. It will be created
CREATE INDEX [idx_Account_AziendaId] ON [Account]([AziendaId])

go

