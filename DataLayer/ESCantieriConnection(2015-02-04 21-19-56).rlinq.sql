-- Column was read from database as: [Codice] varchar(255) null
-- modify column for field _codice
ALTER TABLE [AnagraficaArticolo] ALTER COLUMN [Codice] varchar(max) NULL

go

ALTER TABLE [AnagraficaArticolo] ADD CONSTRAINT [pk_AnagraficaArticolo] PRIMARY KEY ([Id])

go

