-- add column for field _partitaIva
ALTER TABLE [AnagraficaCliente] ADD [PartitaIva] varchar(max) NULL

go

-- dropping unknown column [PIva]
ALTER TABLE [AnagraficaCliente] DROP COLUMN [PIva]

go

-- add column for field _partitaIva
ALTER TABLE [AnagraficaFornitore] ADD [PartitaIva] varchar(max) NULL

go

-- dropping unknown column [PIva]
ALTER TABLE [AnagraficaFornitore] DROP COLUMN [PIva]

go

-- add column for field _partitaIva
ALTER TABLE [Azienda] ADD [PartitaIva] varchar(max) NULL

go

-- dropping unknown column [PIva]
ALTER TABLE [Azienda] DROP COLUMN [PIva]

go

-- add column for field _partitaIva
ALTER TABLE [Cliente] ADD [PartitaIva] varchar(max) NULL

go

-- dropping unknown column [PIva]
ALTER TABLE [Cliente] DROP COLUMN [PIva]

go

-- add column for field _partitaIva
ALTER TABLE [Fornitore] ADD [PartitaIva] varchar(max) NULL

go

-- dropping unknown column [PIva]
ALTER TABLE [Fornitore] DROP COLUMN [PIva]

go

