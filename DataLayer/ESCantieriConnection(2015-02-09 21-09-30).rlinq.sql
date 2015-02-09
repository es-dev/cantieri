-- add column for field _stato
ALTER TABLE [Fornitore] ADD [Stato] varchar(max) NULL

go

-- add column for field _totaleFattureAcquisto
ALTER TABLE [Fornitore] ADD [TotaleFattureAcquisto] numeric(20,10) NULL

go

-- add column for field _totalePagamenti
ALTER TABLE [Fornitore] ADD [TotalePagamenti] decimal(20,10) NULL

go

UPDATE [Fornitore] SET [TotalePagamenti] = 0

go

ALTER TABLE [Fornitore] ALTER COLUMN [TotalePagamenti] decimal(20,10) NOT NULL

go

