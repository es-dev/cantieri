-- add column for field _sconto
ALTER TABLE [FatturaAcquisto] ADD [Sconto] numeric(20,10) NULL

go

-- Column was read from database as: [TotaleNoteCredito] numeric(18) null
-- modify column for field _totaleNoteCredito
ALTER TABLE [FatturaAcquisto] ALTER COLUMN [TotaleNoteCredito] numeric(20,10) NULL

go

-- Column was read from database as: [TotaleNoteCredito] numeric(18) null
-- modify column for field _totaleNoteCredito
ALTER TABLE [Fornitore] ALTER COLUMN [TotaleNoteCredito] numeric(20,10) NULL

go

