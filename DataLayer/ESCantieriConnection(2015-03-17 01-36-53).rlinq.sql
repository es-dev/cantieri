-- add column for field _totaleResi
ALTER TABLE [FatturaAcquisto] ADD [TotaleResi] numeric(20,10) NULL

go

-- dropping unknown column [TotaleNoteCredito]
ALTER TABLE [FatturaAcquisto] DROP COLUMN [TotaleNoteCredito]

go

-- add column for field _iVA
ALTER TABLE [NotaCredito] ADD [IVA] numeric(20,10) NULL

go

-- add column for field _numero
ALTER TABLE [NotaCredito] ADD [Numero] varchar(max) NULL

go

-- add column for field _stato
ALTER TABLE [NotaCredito] ADD [Stato] varchar(max) NULL

go

-- add column for field _totale
ALTER TABLE [NotaCredito] ADD [Totale] numeric(20,10) NULL

go

-- dropping unknown column [Codice]
ALTER TABLE [NotaCredito] DROP COLUMN [Codice]

go

-- dropping unknown column [TipoPagamento]
ALTER TABLE [NotaCredito] DROP COLUMN [TipoPagamento]

go

-- add column for field _iVA
ALTER TABLE [Reso] ADD [IVA] numeric(20,10) NULL

go

-- add column for field _totale
ALTER TABLE [Reso] ADD [Totale] numeric(20,10) NULL

go

-- dropping unknown column [TipoPagamento]
ALTER TABLE [Reso] DROP COLUMN [TipoPagamento]

go

