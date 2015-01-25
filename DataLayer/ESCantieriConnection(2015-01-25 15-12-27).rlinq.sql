-- add column for field _prezzoUnitario
ALTER TABLE [Articolo] ADD [PrezzoUnitario] numeric NULL

go

-- add column for field _oggetto
ALTER TABLE [Commessa] ADD [Oggetto] varchar(255) NULL

go

