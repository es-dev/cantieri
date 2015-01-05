-- add column for field _codice
ALTER TABLE [Azienda] ADD [Codice] varchar(255) NULL

go

-- add column for field _codice
ALTER TABLE [Cliente] ADD [Codice] varchar(255) NULL

go

-- dropping unknown column [CodiceCliente]
ALTER TABLE [Cliente] DROP COLUMN [CodiceCliente]

go

-- add column for field _codice
ALTER TABLE [Commessa] ADD [Codice] varchar(255) NULL

go

-- add column for field _codice
ALTER TABLE [Fornitore] ADD [Codice] varchar(255) NULL

go

-- dropping unknown column [CodiceFornitore]
ALTER TABLE [Fornitore] DROP COLUMN [CodiceFornitore]

go

-- add column for field _codice
ALTER TABLE [SAL] ADD [Codice] varchar(255) NULL

go

