-- add column for field _codice
ALTER TABLE [Liquidazione] ADD [Codice] varchar(255) NULL

go

UPDATE [Liquidazione] SET [Codice] = ' '

go

ALTER TABLE [Liquidazione] ALTER COLUMN [Codice] varchar(255) NOT NULL

go

