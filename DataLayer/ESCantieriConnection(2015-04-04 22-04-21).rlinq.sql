-- add column for field _azienda
ALTER TABLE [CentroCosto] ADD [AziendaId] int NULL

go

UPDATE [CentroCosto] SET [AziendaId] = 1

go

ALTER TABLE [CentroCosto] ALTER COLUMN [AziendaId] int NOT NULL

go

ALTER TABLE [CentroCosto] ADD CONSTRAINT [ref_CentroCosto_Azienda] FOREIGN KEY ([AziendaId]) REFERENCES [Azienda]([Id])

go

-- Index 'idx_CentroCosto_AziendaId' was not detected in the database. It will be created
CREATE INDEX [idx_CentroCosto_AziendaId] ON [CentroCosto]([AziendaId])

go

