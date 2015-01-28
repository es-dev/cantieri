-- Column was read from database as: [Codice] varchar(255) not null
-- modify column for field _codice
ALTER TABLE [Liquidazione] ALTER COLUMN [Codice] varchar(255) NULL

go

-- add column for field _totaleIncassi
ALTER TABLE [SAL] ADD [TotaleIncassi] numeric(20,10) NULL

go

-- add column for field _totalePagamenti
ALTER TABLE [SAL] ADD [TotalePagamenti] numeric(20,10) NULL

go

