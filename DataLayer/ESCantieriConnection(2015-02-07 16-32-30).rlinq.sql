-- add column for field _stato
ALTER TABLE [FatturaAcquisto] ADD [Stato] varchar(255) NULL

go

-- add column for field _totalePagamenti
ALTER TABLE [FatturaAcquisto] ADD [TotalePagamenti] numeric(20,10) NULL

go

UPDATE [FatturaAcquisto] SET [TotalePagamenti] = 0

go

ALTER TABLE [FatturaAcquisto] ALTER COLUMN [TotalePagamenti] numeric(20,10) NOT NULL

go

-- Column was read from database as: [Codice] varchar(max) null
-- modify column for field _codice
ALTER TABLE [Liquidazione] ALTER COLUMN [Codice] varchar(255) NULL

go

-- Column was read from database as: [TipoPagamento] varchar(max) null
-- modify column for field _tipoPagamento
ALTER TABLE [Liquidazione] ALTER COLUMN [TipoPagamento] varchar(255) NULL

go

-- Column was read from database as: [Codice] varchar(max) null
-- modify column for field _codice
ALTER TABLE [Pagamento] ALTER COLUMN [Codice] varchar(255) NULL

go

-- Column was read from database as: [Descrizione] varchar(max) null
-- modify column for field _descrizione
ALTER TABLE [Pagamento] ALTER COLUMN [Descrizione] varchar(255) NULL

go

-- Column was read from database as: [TipoPagamento] varchar(max) null
-- modify column for field _tipoPagamento
ALTER TABLE [Pagamento] ALTER COLUMN [TipoPagamento] varchar(255) NULL

go

