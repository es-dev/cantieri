ALTER TABLE [Cliente] ADD CONSTRAINT [ref_Cliente_Commessa] FOREIGN KEY ([CommessaId]) REFERENCES [Commessa]([Id])

go

ALTER TABLE [NotaCredito] ADD CONSTRAINT [ref_NtCrdt_FttrAcqsto_F6E19BC0] FOREIGN KEY ([FatturaAcquistoId]) REFERENCES [FatturaAcquisto]([Id])

go

-- Index 'idx_Cliente_CommessaId' was not detected in the database. It will be created
CREATE INDEX [idx_Cliente_CommessaId] ON [Cliente]([CommessaId])

go

-- Index 'idx_NtCrdito_FatturaAcquistoId' was not detected in the database. It will be created
CREATE INDEX [idx_NtCrdito_FatturaAcquistoId] ON [NotaCredito]([FatturaAcquistoId])

go

