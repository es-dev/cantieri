-- add column for field _transazionePagamento
ALTER TABLE [Liquidazione] ADD [TransazionePagamento] varchar(max) NULL

go

-- add column for field _transazionePagamento
ALTER TABLE [Pagamento] ADD [TransazionePagamento] varchar(max) NULL

go

