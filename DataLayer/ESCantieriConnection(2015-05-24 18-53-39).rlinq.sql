-- add column for field _anagraficaArticolo
ALTER TABLE [Articolo] ADD [AnagraficaArticoloId] int NULL

go

UPDATE [Articolo]
   SET [AnagraficaArticoloId] = (SELECT [Id] FROM [AnagraficaArticolo] Where [Codice]=[Articolo].[Codice])


go

-- dropping unknown column [Descrizione]
ALTER TABLE [Articolo] DROP COLUMN [Descrizione]

go

 --dropping unknown column [Codice]
ALTER TABLE [Articolo] DROP COLUMN [Codice]

go

ALTER TABLE [Articolo] ADD CONSTRAINT [ref_Articolo_AnagraficaArticolo] FOREIGN KEY ([AnagraficaArticoloId]) REFERENCES [AnagraficaArticolo]([Id])

go

-- Index 'idx_Artcl_AnagraficaArticoloId' was not detected in the database. It will be created
CREATE INDEX [idx_Articolo_AnagraficaArticoloId] ON [Articolo]([AnagraficaArticoloId])

go


ALTER TABLE [Articolo] DROP CONSTRAINT [ref_Articolo_AnagraficaArticolo]

go

-- Dropping index 'idx_Articolo_AnagraficaArticoloId' which is not configured in OpenAccess but exists on the database.
DROP INDEX [idx_Articolo_AnagraficaArticoloId] ON [Articolo]

go

-- Column was read from database as: [AnagraficaArticoloId] int null
-- modify column for field _anagraficaArticolo


ALTER TABLE [Articolo] ALTER COLUMN [AnagraficaArticoloId] int NOT NULL

go



ALTER TABLE [Articolo] ADD CONSTRAINT [ref_Articolo_AnagraficaArticolo] FOREIGN KEY ([AnagraficaArticoloId]) REFERENCES [AnagraficaArticolo]([Id])

go

CREATE INDEX [idx_Articolo_AnagraficaArticoloId] ON [Articolo]([AnagraficaArticoloId])

go