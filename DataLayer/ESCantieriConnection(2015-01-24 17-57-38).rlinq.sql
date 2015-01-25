-- add column for field _prezzoUnitario
ALTER TABLE [Articolo] ADD [PrezzoUnitario] numeric(20,10) NULL

go

UPDATE [Articolo] SET [PrezzoUnitario] = 0

go

ALTER TABLE [Articolo] ALTER COLUMN [PrezzoUnitario] numeric(20,10) NOT NULL

go

