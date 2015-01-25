ALTER TABLE [Articolo] DROP CONSTRAINT [ref_Articolo_FatturaAcquisto]

go

-- Index 'idx_Articolo_FatturaId' was detected in the database but with a different configuration. It will be recreated
DROP INDEX [idx_Articolo_FatturaId] ON [Articolo]

go

-- add column for field _fattura
ALTER TABLE [Articolo] ADD [FatturaAcquistoId] int NULL

go

UPDATE [Articolo] SET [FatturaAcquistoId] = 0

go

ALTER TABLE [Articolo] ALTER COLUMN [FatturaAcquistoId] int NOT NULL

go

-- Column was read from database as: [PrezzoUnitario] numeric(18) null
-- modify column for field _prezzoUnitario
ALTER TABLE [Articolo] ALTER COLUMN [PrezzoUnitario] numeric(20,10) NULL

go

-- Column was read from database as: [Quantita] numeric(18) null
-- modify column for field _quantita
ALTER TABLE [Articolo] ALTER COLUMN [Quantita] numeric(20,10) NULL

go

-- dropping unknown column [FatturaId]
ALTER TABLE [Articolo] DROP COLUMN [FatturaId]

go

ALTER TABLE [Articolo] ADD CONSTRAINT [ref_Articolo_FatturaAcquisto] FOREIGN KEY ([FatturaAcquistoId]) REFERENCES [FatturaAcquisto]([Id])

go

-- Index 'idx_Articolo_FatturaId' was detected in the database but with a different configuration. It will be recreated
CREATE INDEX [idx_Articolo_FatturaId] ON [Articolo]([FatturaAcquistoId])

go

