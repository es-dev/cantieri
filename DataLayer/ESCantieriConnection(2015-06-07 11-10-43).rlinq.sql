-- DataLayer.Notifica
CREATE TABLE [Notifica] (
    [Applicazione] varchar(max) NULL,       -- _applicazione
    [Codice] varchar(max) NULL,             -- _codice
    [Data] datetime NULL,                   -- _data
    [Id] int IDENTITY NOT NULL,             -- _id
    [Tipo] varchar(max) NULL,               -- _tipo
    CONSTRAINT [pk_Notifica] PRIMARY KEY ([Id])
)

go

