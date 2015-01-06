-- add column for field _scadenzaPagamento
ALTER TABLE [FatturaAcquisto] ADD [ScadenzaPagamento] varchar(max) NULL

go

UPDATE [FatturaAcquisto] SET [ScadenzaPagamento] = ' '

go

ALTER TABLE [FatturaAcquisto] ALTER COLUMN [ScadenzaPagamento] varchar(max) NOT NULL

go

-- add column for field _scadenzaPagamento
ALTER TABLE [FatturaVendita] ADD [ScadenzaPagamento] varchar(max) NULL

go

UPDATE [FatturaVendita] SET [ScadenzaPagamento] = ' '

go

ALTER TABLE [FatturaVendita] ALTER COLUMN [ScadenzaPagamento] varchar(max) NOT NULL

go

-- add column for field _note
ALTER TABLE [Liquidazione] ADD [Note ] varchar(max) NULL

go

UPDATE [Liquidazione] SET [Note ] = ' '

go

ALTER TABLE [Liquidazione] ALTER COLUMN [Note ] varchar(max) NOT NULL

go

-- dropping unknown column [Scadenza]
ALTER TABLE [Liquidazione] DROP COLUMN [Scadenza]

go

-- dropping unknown column [Modalita]
ALTER TABLE [Liquidazione] DROP COLUMN [Modalita]

go

-- dropping unknown column [Eseguito]
ALTER TABLE [Liquidazione] DROP COLUMN [Eseguito]

go

-- add column for field _note
ALTER TABLE [Pagamento] ADD [Note ] varchar(max) NULL

go

UPDATE [Pagamento] SET [Note ] = ' '

go

ALTER TABLE [Pagamento] ALTER COLUMN [Note ] varchar(max) NOT NULL

go

-- dropping unknown column [Scadenza]
ALTER TABLE [Pagamento] DROP COLUMN [Scadenza]

go

-- dropping unknown column [Modalita]
ALTER TABLE [Pagamento] DROP COLUMN [Modalita]

go

-- dropping unknown column [Eseguito]
ALTER TABLE [Pagamento] DROP COLUMN [Eseguito]

go

