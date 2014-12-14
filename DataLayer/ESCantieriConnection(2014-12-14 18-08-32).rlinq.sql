-- add column for field _codice
ALTER TABLE [AnagraficaCliente] ADD [Codice] varchar(255) NULL

go

-- add column for field _codice
ALTER TABLE [AnagraficaFornitore] ADD [Codice] varchar(255) NULL

go

-- add column for field _codiceCliente
ALTER TABLE [Cliente] ADD [CodiceCliente] varchar(255) NULL

go

-- add column for field _codiceFornitore
ALTER TABLE [Fornitore] ADD [CodiceFornitore] varchar(255) NULL

go

-- Column was read from database as: [Email] varchar(max) null
-- modify column for field _email
ALTER TABLE [Fornitore] ALTER COLUMN [Email] varchar(255) NULL

go

-- Column was read from database as: [PIva] varchar(11) null
-- modify column for field _pIva
ALTER TABLE [Fornitore] ALTER COLUMN [PIva] varchar(255) NULL

go

-- Column was read from database as: [Provincia] varchar(2) null
-- modify column for field _provincia
ALTER TABLE [Fornitore] ALTER COLUMN [Provincia] varchar(255) NULL

go

