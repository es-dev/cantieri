
-- add column for field _anagraficaCommittente
ALTER TABLE [Committente] ADD [AnagraficaCommittenteId] int NULL

go

UPDATE [Committente] SET [AnagraficaCommittenteId] = (SELECT [Id] FROM [AnagraficaCommittente] where [Codice]=[Committente].[Codice])

go

ALTER TABLE [Committente] ALTER COLUMN [AnagraficaCommittenteId] int NOT NULL

go

-- dropping unknown column [CAP]
ALTER TABLE [Committente] DROP COLUMN [CAP]

go

-- dropping unknown column [CodiceCatastale]
ALTER TABLE [Committente] DROP COLUMN [CodiceCatastale]

go

-- dropping unknown column [Comune]
ALTER TABLE [Committente] DROP COLUMN [Comune]

go

-- dropping unknown column [Email]
ALTER TABLE [Committente] DROP COLUMN [Email]

go

-- dropping unknown column [Fax]
ALTER TABLE [Committente] DROP COLUMN [Fax]

go

-- dropping unknown column [Indirizzo]
ALTER TABLE [Committente] DROP COLUMN [Indirizzo]

go

-- dropping unknown column [Localita]
ALTER TABLE [Committente] DROP COLUMN [Localita]

go

-- dropping unknown column [Mobile]
ALTER TABLE [Committente] DROP COLUMN [Mobile]

go


-- dropping unknown column [Provincia]
ALTER TABLE [Committente] DROP COLUMN [Provincia]

go

-- dropping unknown column [Telefono]
ALTER TABLE [Committente] DROP COLUMN [Telefono]

go








-- add column for field _anagraficaFornitore
ALTER TABLE [Fornitore] ADD [AnagraficaFornitoreId] int NULL

go

UPDATE [Fornitore] SET [AnagraficaFornitoreId] = (SELECT [Id] FROM [AnagraficaFornitore] where [Codice]=[Fornitore].[Codice])

go

ALTER TABLE [Fornitore] ALTER COLUMN [AnagraficaFornitoreId] int NOT NULL

go

-- dropping unknown column [Telefono]
ALTER TABLE [Fornitore] DROP COLUMN [Telefono]

go



-- dropping unknown column [Provincia]
ALTER TABLE [Fornitore] DROP COLUMN [Provincia]

go

-- dropping unknown column [Mobile]
ALTER TABLE [Fornitore] DROP COLUMN [Mobile]

go

-- dropping unknown column [Indirizzo]
ALTER TABLE [Fornitore] DROP COLUMN [Indirizzo]

go

-- dropping unknown column [Fax]
ALTER TABLE [Fornitore] DROP COLUMN [Fax]

go

-- dropping unknown column [Email]
ALTER TABLE [Fornitore] DROP COLUMN [Email]

go

-- dropping unknown column [Comune]
ALTER TABLE [Fornitore] DROP COLUMN [Comune]

go

-- dropping unknown column [CAP]
ALTER TABLE [Fornitore] DROP COLUMN [CAP]

go

-- dropping unknown column [CodiceCatastale]
ALTER TABLE [Fornitore] DROP COLUMN [CodiceCatastale]

go

-- dropping unknown column [Localita]
ALTER TABLE [Fornitore] DROP COLUMN [Localita]

go









-- add column for field _anagraficaFornitore
ALTER TABLE [PagamentoUnificato] ADD [AnagraficaFornitoreId] int NULL

go

UPDATE [PagamentoUnificato] SET [AnagraficaFornitoreId] = (SELECT [Id] FROM [AnagraficaFornitore] WHERE [Codice] = [PagamentoUnificato].[CodiceFornitore])

go

ALTER TABLE [PagamentoUnificato] ALTER COLUMN [AnagraficaFornitoreId] int NOT NULL

go









-- add column for field _anagraficaCommittente
ALTER TABLE [ReportJob] ADD [AnagraficaCommittenteId] int NULL

go

-- add column for field _anagraficaFornitore
ALTER TABLE [ReportJob] ADD [AnagraficaFornitoreId] int NULL

go


UPDATE [ReportJob] SET [AnagraficaCommittenteId] = (SELECT [Id] FROM [AnagraficaCommittente] where [Codice]=[ReportJob].[CodiceCommittente])

go

UPDATE [ReportJob] SET [AnagraficaFornitoreId] = (SELECT [Id] FROM [AnagraficaFornitore] where [Codice]=[ReportJob].[CodiceFornitore])

go










ALTER TABLE [Committente] ADD CONSTRAINT [ref_Cmmttnt_AngrfcCmm_3E1D7917] FOREIGN KEY ([AnagraficaCommittenteId]) REFERENCES [AnagraficaCommittente]([Id])

go

ALTER TABLE [Fornitore] ADD CONSTRAINT [ref_Frntr_AngrfcFrntr_444419EC] FOREIGN KEY ([AnagraficaFornitoreId]) REFERENCES [AnagraficaFornitore]([Id])

go

ALTER TABLE [PagamentoUnificato] ADD CONSTRAINT [ref_PgmntUnfct_Angrfc_C85D61B0] FOREIGN KEY ([AnagraficaFornitoreId]) REFERENCES [AnagraficaFornitore]([Id])

go

ALTER TABLE [ReportJob] ADD CONSTRAINT [ref_RprtJb_AngrfcCmmt_5B92369B] FOREIGN KEY ([AnagraficaCommittenteId]) REFERENCES [AnagraficaCommittente]([Id])

go

ALTER TABLE [ReportJob] ADD CONSTRAINT [ref_RprtJb_AngrfcFrnt_4BC22C73] FOREIGN KEY ([AnagraficaFornitoreId]) REFERENCES [AnagraficaFornitore]([Id])

go

-- Index 'idx_Artcl_AnagraficaArticoloId' was not detected in the database. It will be created


-- Index 'idx_Cmmttnt_AngrfcCmmittenteId' was not detected in the database. It will be created
CREATE INDEX [idx_Cmmttnt_AngrfcCmmittenteId] ON [Committente]([AnagraficaCommittenteId])

go

-- Index 'idx_Frntr_AngraficaFornitoreId' was not detected in the database. It will be created
CREATE INDEX [idx_Frntr_AngraficaFornitoreId] ON [Fornitore]([AnagraficaFornitoreId])

go

-- Index 'idx_PgmntUnfct_AngrfcFrntoreId' was not detected in the database. It will be created
CREATE INDEX [idx_PgmntUnfct_AngrfcFrntoreId] ON [PagamentoUnificato]([AnagraficaFornitoreId])

go

-- Index 'idx_RprtJb_AngrfcCommittenteId' was not detected in the database. It will be created
CREATE INDEX [idx_RprtJb_AngrfcCommittenteId] ON [ReportJob]([AnagraficaCommittenteId])

go

-- Index 'idx_RprtJb_AngrficaFornitoreId' was not detected in the database. It will be created
CREATE INDEX [idx_RprtJb_AngrficaFornitoreId] ON [ReportJob]([AnagraficaFornitoreId])

go

