ALTER TABLE [Committente] DROP CONSTRAINT [ref_Cmmttnt_AngrfcCmm_3E1D7917]

go

ALTER TABLE [Fornitore] DROP CONSTRAINT [ref_Frntr_AngrfcFrntr_444419EC]

go

-- Index 'idx_Cmmttnt_AngrfcCmmittenteId' was detected in the database but with a different configuration. It will be recreated
DROP INDEX [idx_Cmmttnt_AngrfcCmmittenteId] ON [Committente]

go

-- Index 'idx_Frntr_AngraficaFornitoreId' was detected in the database but with a different configuration. It will be recreated
DROP INDEX [idx_Frntr_AngraficaFornitoreId] ON [Fornitore]

go


ALTER TABLE [Committente] ALTER COLUMN [AnagraficaCommittenteId] int NOT NULL

go


ALTER TABLE [Fornitore] ALTER COLUMN [AnagraficaFornitoreId] int NOT NULL

go

ALTER TABLE [Committente] ADD CONSTRAINT [ref_Cmmttnt_AngrfcCmm_3E1D7917] FOREIGN KEY ([AnagraficaCommittenteId]) REFERENCES [AnagraficaCommittente]([Id])

go

ALTER TABLE [Fornitore] ADD CONSTRAINT [ref_Frntr_AngrfcFrntr_444419EC] FOREIGN KEY ([AnagraficaFornitoreId]) REFERENCES [AnagraficaFornitore]([Id])

go

-- Index 'idx_Cmmttnt_AngrfcCmmittenteId' was detected in the database but with a different configuration. It will be recreated
CREATE INDEX [idx_Cmmttnt_AngrfcCmmittenteId] ON [Committente]([AnagraficaCommittenteId])

go

-- Index 'idx_Frntr_AngraficaFornitoreId' was detected in the database but with a different configuration. It will be recreated
CREATE INDEX [idx_Frntr_AngraficaFornitoreId] ON [Fornitore]([AnagraficaFornitoreId])

go

