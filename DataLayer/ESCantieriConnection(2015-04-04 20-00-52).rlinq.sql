-- add column for field _azienda
ALTER TABLE [AnagraficaArticolo] ADD [AziendaId] int NULL

go

UPDATE [AnagraficaArticolo] SET [AziendaId] = 1

go

ALTER TABLE [AnagraficaArticolo] ALTER COLUMN [AziendaId] int NOT NULL

go

-- add column for field _azienda
ALTER TABLE [AnagraficaCommittente] ADD [AziendaId] int NULL

go

UPDATE [AnagraficaCommittente] SET [AziendaId] = 1

go

ALTER TABLE [AnagraficaCommittente] ALTER COLUMN [AziendaId] int NOT NULL

go

-- add column for field _azienda
ALTER TABLE [AnagraficaFornitore] ADD [AziendaId] int NULL

go

UPDATE [AnagraficaFornitore] SET [AziendaId] = 1

go

ALTER TABLE [AnagraficaFornitore] ALTER COLUMN [AziendaId] int NOT NULL

go

-- add column for field _azienda
ALTER TABLE [PagamentoUnificato] ADD [AziendaId] int NULL

go

UPDATE [PagamentoUnificato] SET [AziendaId] = 1

go

ALTER TABLE [PagamentoUnificato] ALTER COLUMN [AziendaId] int NOT NULL

go

-- add column for field _azienda
ALTER TABLE [ReportJob] ADD [AziendaId] int NULL

go

UPDATE [ReportJob] SET [AziendaId] = 1

go

ALTER TABLE [ReportJob] ALTER COLUMN [AziendaId] int NOT NULL

go

ALTER TABLE [AnagraficaArticolo] ADD CONSTRAINT [ref_AnagraficaArticolo_Azienda] FOREIGN KEY ([AziendaId]) REFERENCES [Azienda]([Id])

go

ALTER TABLE [AnagraficaCommittente] ADD CONSTRAINT [ref_AngrfcCmmttnt_Azn_0D64D27E] FOREIGN KEY ([AziendaId]) REFERENCES [Azienda]([Id])

go

ALTER TABLE [AnagraficaFornitore] ADD CONSTRAINT [ref_AngrfcFrntr_Aznda_84959E12] FOREIGN KEY ([AziendaId]) REFERENCES [Azienda]([Id])

go

ALTER TABLE [PagamentoUnificato] ADD CONSTRAINT [ref_PagamentoUnificato_Azienda] FOREIGN KEY ([AziendaId]) REFERENCES [Azienda]([Id])

go

ALTER TABLE [ReportJob] ADD CONSTRAINT [ref_ReportJob_Azienda] FOREIGN KEY ([AziendaId]) REFERENCES [Azienda]([Id])

go

-- Index 'idx_AngrficaArticolo_AziendaId' was not detected in the database. It will be created
CREATE INDEX [idx_AngrficaArticolo_AziendaId] ON [AnagraficaArticolo]([AziendaId])

go

-- Index 'idx_AngrfcCmmittente_AziendaId' was not detected in the database. It will be created
CREATE INDEX [idx_AngrfcCmmittente_AziendaId] ON [AnagraficaCommittente]([AziendaId])

go

-- Index 'idx_AngrfcaFornitore_AziendaId' was not detected in the database. It will be created
CREATE INDEX [idx_AngrfcaFornitore_AziendaId] ON [AnagraficaFornitore]([AziendaId])

go

-- Index 'idx_PgmentoUnificato_AziendaId' was not detected in the database. It will be created
CREATE INDEX [idx_PgmentoUnificato_AziendaId] ON [PagamentoUnificato]([AziendaId])

go

-- Index 'idx_ReportJob_AziendaId' was not detected in the database. It will be created
CREATE INDEX [idx_ReportJob_AziendaId] ON [ReportJob]([AziendaId])

go

