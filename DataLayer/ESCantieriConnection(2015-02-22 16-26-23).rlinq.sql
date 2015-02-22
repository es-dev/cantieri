-- DataLayer.ReportJob
CREATE TABLE [ReportJob] (
    [Codice] varchar(max) NULL,             -- _codice
    [CodiceFornitore] varchar(max) NULL,    -- _codiceFornitore
    [Creazione] datetime NULL,              -- _creazione
    [Denominazione] varchar(max) NULL,      -- _denominazione
    [Elaborazione] datetime NULL,           -- _elaborazione
    [Id] int IDENTITY NOT NULL,             -- _id
    [Note] varchar(max) NULL,               -- _note
    [Tipo] varchar(max) NULL,               -- _tipo
    CONSTRAINT [pk_ReportJob] PRIMARY KEY ([Id])
)

go

