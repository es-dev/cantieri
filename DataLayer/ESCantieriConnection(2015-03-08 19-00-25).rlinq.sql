-- add column for field _totaleNoteCredito
ALTER TABLE [FatturaAcquisto] ADD [TotaleNoteCredito] numeric NULL

go

-- add column for field _totaleNoteCredito
ALTER TABLE [Fornitore] ADD [TotaleNoteCredito] numeric NULL

go

-- Column was read from database as: [TotalePagamenti] decimal(20,10) not null
-- modify column for field _totalePagamenti
ALTER TABLE [Fornitore] ALTER COLUMN [TotalePagamenti] numeric(20,10) NULL

go

