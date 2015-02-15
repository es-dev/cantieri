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

ALTER TABLE [Account] ADD CONSTRAINT [ref_Account_Azienda] FOREIGN KEY ([AziendaId]) REFERENCES [Azienda]([Id])

go

-- Index 'idx_Account_AziendaId' was not detected in the database. It will be created
CREATE INDEX [idx_Account_AziendaId] ON [Account]([AziendaId])

go

