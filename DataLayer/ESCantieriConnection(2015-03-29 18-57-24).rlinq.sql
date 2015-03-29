ALTER TABLE [FatturaVendita] ADD CONSTRAINT [ref_FatturaVendita_Committente] FOREIGN KEY ([CommittenteId]) REFERENCES [Committente]([Id])

go

-- Index 'idx_FatturaVendita_CommittenteId' was not detected in the database. It will be created
CREATE INDEX [idx_FatturaVendita_CommittenteId] ON [FatturaVendita]([CommittenteId])

go

