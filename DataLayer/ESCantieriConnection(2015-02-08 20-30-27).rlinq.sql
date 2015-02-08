-- add column for field _stato
ALTER TABLE [Fornitore] ADD [Stato] varchar(max) NULL

go

-- add column for field _totaleFattureAcquisto
ALTER TABLE [Fornitore] ADD [TotaleFattureAcquisto] numeric(20,10) NULL

go

