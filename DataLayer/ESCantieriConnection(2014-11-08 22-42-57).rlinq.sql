-- Column was read from database as: [Costo] numeric(20,10) not null
-- modify column for field _costo
ALTER TABLE [Articolo] ALTER COLUMN [Costo] numeric(20,10) NULL

go

-- Column was read from database as: [IVA] numeric(20,10) not null
-- modify column for field _iVA
ALTER TABLE [Articolo] ALTER COLUMN [IVA] numeric(20,10) NULL

go

-- Column was read from database as: [Importo] numeric(20,10) not null
-- modify column for field _importo
ALTER TABLE [Articolo] ALTER COLUMN [Importo] numeric(20,10) NULL

go

-- Column was read from database as: [Quantita] int not null
-- modify column for field _quantita
ALTER TABLE [Articolo] ALTER COLUMN [Quantita] int NULL

go

-- Column was read from database as: [Sconto] numeric(20,10) not null
-- modify column for field _sconto
ALTER TABLE [Articolo] ALTER COLUMN [Sconto] numeric(20,10) NULL

go

-- Column was read from database as: [Totale] numeric(20,10) not null
-- modify column for field _totale
ALTER TABLE [Articolo] ALTER COLUMN [Totale] numeric(20,10) NULL

go

-- Column was read from database as: [Dipendenti] int not null
-- modify column for field _dipendenti
ALTER TABLE [Azienda] ALTER COLUMN [Dipendenti] int NULL

go

-- Column was read from database as: [Importo] numeric(20,10) not null
-- modify column for field _importo
ALTER TABLE [Commessa] ALTER COLUMN [Importo] numeric(20,10) NULL

go

-- Column was read from database as: [Margine] numeric(20,10) not null
-- modify column for field _margine
ALTER TABLE [Commessa] ALTER COLUMN [Margine] numeric(20,10) NULL

go

-- Column was read from database as: [IVA] numeric(20,10) not null
-- modify column for field _iVA
ALTER TABLE [FatturaAcquisto] ALTER COLUMN [IVA] numeric(20,10) NULL

go

-- Column was read from database as: [Imponibile] numeric(20,10) not null
-- modify column for field _imponibile
ALTER TABLE [FatturaAcquisto] ALTER COLUMN [Imponibile] numeric(20,10) NULL

go

-- Column was read from database as: [Saldo] numeric(20,10) not null
-- modify column for field _saldo
ALTER TABLE [FatturaAcquisto] ALTER COLUMN [Saldo] numeric(20,10) NULL

go

-- Column was read from database as: [Totale] numeric(20,10) not null
-- modify column for field _totale
ALTER TABLE [FatturaAcquisto] ALTER COLUMN [Totale] numeric(20,10) NULL

go

-- Column was read from database as: [IVA] numeric(20,10) not null
-- modify column for field _iVA
ALTER TABLE [FatturaVendita] ALTER COLUMN [IVA] numeric(20,10) NULL

go

-- Column was read from database as: [Imponibile] numeric(20,10) not null
-- modify column for field _imponibile
ALTER TABLE [FatturaVendita] ALTER COLUMN [Imponibile] numeric(20,10) NULL

go

-- Column was read from database as: [Saldo] numeric(20,10) not null
-- modify column for field _saldo
ALTER TABLE [FatturaVendita] ALTER COLUMN [Saldo] numeric(20,10) NULL

go

-- Column was read from database as: [Totale] numeric(20,10) not null
-- modify column for field _totale
ALTER TABLE [FatturaVendita] ALTER COLUMN [Totale] numeric(20,10) NULL

go

-- Column was read from database as: [Importo] numeric(20,10) not null
-- modify column for field _importo
ALTER TABLE [Liquidazione] ALTER COLUMN [Importo] numeric(20,10) NULL

go

-- Column was read from database as: [Importo] numeric(20,10) not null
-- modify column for field _importo
ALTER TABLE [Pagamento] ALTER COLUMN [Importo] numeric(20,10) NULL

go

-- Column was read from database as: [TotaleAcquisti] numeric(20,10) not null
-- modify column for field _totaleAcquisti
ALTER TABLE [SAL] ALTER COLUMN [TotaleAcquisti] numeric(20,10) NULL

go

-- Column was read from database as: [TotaleVendite] numeric(20,10) not null
-- modify column for field _totaleVendite
ALTER TABLE [SAL] ALTER COLUMN [TotaleVendite] numeric(20,10) NULL

go

