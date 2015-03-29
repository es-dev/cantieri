ALTER TABLE [FatturaVendita] DROP CONSTRAINT [ref_FatturaVendita_Cliente]

go

-- Dropping index 'idx_FatturaVendita_ClienteId' which is not configured in OpenAccess but exists on the database.
DROP INDEX [idx_FatturaVendita_ClienteId] ON [FatturaVendita]

go

-- add column for field _committente
ALTER TABLE [FatturaVendita] ADD [CommittenteId] int NULL

go

UPDATE [FatturaVendita] SET [CommittenteId] = 0

go

ALTER TABLE [FatturaVendita] ALTER COLUMN [CommittenteId] int NOT NULL

go

-- dropping unknown column [ClienteId]
ALTER TABLE [FatturaVendita] DROP COLUMN [ClienteId]

go

ALTER TABLE [FatturaVendita] ADD CONSTRAINT [ref_FatturaVendita_Committente] FOREIGN KEY ([CommittenteId]) REFERENCES [Committente]([Id])

go

-- Index 'idx_FatturaVendita_CommittenteId' was not detected in the database. It will be created
CREATE INDEX [idx_FatturaVendita_CommittenteId] ON [FatturaVendita]([CommittenteId])

go

