-- add column for field _codice
ALTER TABLE [Liquidazione] ADD [Codice] varchar(255) NULL

go

UPDATE [Liquidazione] SET [Codice] = ' '

go

ALTER TABLE [Liquidazione] ALTER COLUMN [Codice] varchar(255) NOT NULL

go

-- add column for field _codice
ALTER TABLE [Pagamento] ADD [Codice] varchar(255) NULL

go

-- Column was read from database as: [Note ] varchar(max) not null
-- modify column for field _note
ALTER TABLE [Pagamento] ALTER COLUMN [Note ] varchar(max) NULL

go

-- add column for field _totaleIncassi
ALTER TABLE [SAL] ADD [TotaleIncassi] numeric(20,10) NULL

go

-- add column for field _totalePagamenti
ALTER TABLE [SAL] ADD [TotalePagamenti] numeric(20,10) NULL

go

