-- Column was read from database as: [Codice] varchar(255) not null
-- modify column for field _codice
ALTER TABLE [Liquidazione] ALTER COLUMN [Codice] varchar(255) NULL

go

-- add column for field _stato
ALTER TABLE [SAL] ADD [Stato] varchar(max) NULL

go

