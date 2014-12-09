-- Column was read from database as: [Creazione] datetime not null
-- modify column for field _creazione
ALTER TABLE [Commessa] ALTER COLUMN [Creazione] datetime NULL

go

-- Column was read from database as: [Scadenza] datetime not null
-- modify column for field _scadenza
ALTER TABLE [Commessa] ALTER COLUMN [Scadenza] datetime NULL

go

-- Column was read from database as: [data] datetime not null
-- modify column for field _data
ALTER TABLE [FatturaAcquisto] ALTER COLUMN [data] datetime NULL

go

-- Column was read from database as: [dta] datetime not null
-- modify column for field _data
ALTER TABLE [FatturaVendita] ALTER COLUMN [dta] datetime NULL

go

-- Column was read from database as: [dta] datetime not null
-- modify column for field _data
ALTER TABLE [Liquidazione] ALTER COLUMN [dta] datetime NULL

go

-- Column was read from database as: [Eseguito] tinyint not null
-- modify column for field _eseguito
ALTER TABLE [Liquidazione] ALTER COLUMN [Eseguito] tinyint NULL

go

-- Column was read from database as: [Scadenza] datetime not null
-- modify column for field _scadenza
ALTER TABLE [Liquidazione] ALTER COLUMN [Scadenza] datetime NULL

go

-- Column was read from database as: [dta] datetime not null
-- modify column for field _data
ALTER TABLE [Pagamento] ALTER COLUMN [dta] datetime NULL

go

-- Column was read from database as: [Eseguito] tinyint not null
-- modify column for field _eseguito
ALTER TABLE [Pagamento] ALTER COLUMN [Eseguito] tinyint NULL

go

-- Column was read from database as: [Scadenza] datetime not null
-- modify column for field _scadenza
ALTER TABLE [Pagamento] ALTER COLUMN [Scadenza] datetime NULL

go

-- Column was read from database as: [dta] datetime not null
-- modify column for field _data
ALTER TABLE [SAL] ALTER COLUMN [dta] datetime NULL

go

-- Column was read from database as: [lck] tinyint not null
-- modify column for field _lock
ALTER TABLE [SAL] ALTER COLUMN [lck] tinyint NULL

go

