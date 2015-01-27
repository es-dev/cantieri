ALTER TABLE [Articolo] ADD CONSTRAINT [ref_Articolo_FatturaAcquisto] FOREIGN KEY ([FatturaAcquistoId]) REFERENCES [FatturaAcquisto]([Id])

go

-- Index 'idx_Articolo_FatturaId' was not detected in the database. It will be created
CREATE INDEX [idx_Articolo_FatturaId] ON [Articolo]([FatturaAcquistoId])

go

