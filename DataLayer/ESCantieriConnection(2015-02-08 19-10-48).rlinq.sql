-- add column for field _codiceCatastale
ALTER TABLE [AnagraficaCliente] ADD [CodiceCatastale] varchar(max) NULL

go

-- add column for field _codiceCatastale
ALTER TABLE [AnagraficaFornitore] ADD [CodiceCatastale] varchar(max) NULL

go

-- add column for field _codiceCatastale
ALTER TABLE [Cliente] ADD [CodiceCatastale] varchar(max) NULL

go

-- Column was read from database as: [Codice] varchar(255) null
-- modify column for field _codice
ALTER TABLE [Commessa] ALTER COLUMN [Codice] varchar(max) NULL

go

-- add column for field _codiceCatastale
ALTER TABLE [Commessa] ADD [CodiceCatastale] varchar(max) NULL

go

-- Column was read from database as: [EstremiContratto] varchar(255) null
-- modify column for field _estremiContratto
ALTER TABLE [Commessa] ALTER COLUMN [EstremiContratto] varchar(max) NULL

go

-- add column for field _data
ALTER TABLE [FatturaVendita] ADD [Data] datetime NULL

go

-- dropping unknown column [dta]
ALTER TABLE [FatturaVendita] DROP COLUMN [dta]

go

-- add column for field _codiceCatastale
ALTER TABLE [Fornitore] ADD [CodiceCatastale] varchar(max) NULL

go

-- Column was read from database as: [Codice] varchar(255) null
-- modify column for field _codice
ALTER TABLE [Liquidazione] ALTER COLUMN [Codice] varchar(max) NULL

go

-- add column for field _data
ALTER TABLE [Liquidazione] ADD [Data] datetime NULL

go

-- Column was read from database as: [Descrizione] varchar(255) null
-- modify column for field _descrizione
ALTER TABLE [Liquidazione] ALTER COLUMN [Descrizione] varchar(max) NULL

go

-- Column was read from database as: [TipoPagamento] varchar(255) null
-- modify column for field _tipoPagamento
ALTER TABLE [Liquidazione] ALTER COLUMN [TipoPagamento] varchar(max) NULL

go

-- dropping unknown column [dta]
ALTER TABLE [Liquidazione] DROP COLUMN [dta]

go

-- Column was read from database as: [Codice] varchar(255) null
-- modify column for field _codice
ALTER TABLE [Pagamento] ALTER COLUMN [Codice] varchar(max) NULL

go

-- add column for field _data
ALTER TABLE [Pagamento] ADD [Data] datetime NULL

go

-- Column was read from database as: [Descrizione] varchar(255) null
-- modify column for field _descrizione
ALTER TABLE [Pagamento] ALTER COLUMN [Descrizione] varchar(max) NULL

go

-- Column was read from database as: [TipoPagamento] varchar(255) null
-- modify column for field _tipoPagamento
ALTER TABLE [Pagamento] ALTER COLUMN [TipoPagamento] varchar(max) NULL

go

-- dropping unknown column [dta]
ALTER TABLE [Pagamento] DROP COLUMN [dta]

go

-- add column for field _data
ALTER TABLE [SAL] ADD [Data] datetime NULL

go

-- dropping unknown column [dta]
ALTER TABLE [SAL] DROP COLUMN [dta]

go

