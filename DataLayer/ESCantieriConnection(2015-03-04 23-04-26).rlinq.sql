ALTER TABLE [Cliente] DROP CONSTRAINT [ref_Cliente_Commessa]

go

-- add column for field _commessa
ALTER TABLE [Cliente] ADD [CommessaId] int NULL

go

UPDATE [Cliente] SET [CommessaId] = 0

go

ALTER TABLE [Cliente] ALTER COLUMN [CommessaId] int NOT NULL

go

ALTER TABLE [Cliente] ADD CONSTRAINT [ref_Cliente_Commessa] FOREIGN KEY ([CommessaId]) REFERENCES [Commessa]([Id])

go

-- Index 'idx_Cliente_CommessaId' was not detected in the database. It will be created
CREATE INDEX [idx_Cliente_CommessaId] ON [Cliente]([CommessaId])

go

