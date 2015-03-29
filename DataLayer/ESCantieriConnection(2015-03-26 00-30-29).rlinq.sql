-- add column for field _transazionePagamento
ALTER TABLE [Incasso] ADD [TransazionePagamento] varchar(max) NULL

go

-- add column for field _transazionePagamento
ALTER TABLE [Pagamento] ADD [TransazionePagamento] varchar(max) NULL

go

