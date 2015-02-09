-- add column for field _totalePagamenti
ALTER TABLE [Fornitore] ADD [TotalePagamenti] decimal(20,10) NULL

go

UPDATE [Fornitore] SET [TotalePagamenti] = 0

go

ALTER TABLE [Fornitore] ALTER COLUMN [TotalePagamenti] decimal(20,10) NOT NULL

go

