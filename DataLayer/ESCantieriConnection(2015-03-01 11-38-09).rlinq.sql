ALTER TABLE [PagamentoUnificato] DROP CONSTRAINT [ref_PgmntUnfct_Frntre_861A4E27]

go

-- Dropping index 'idx_PgmntUnificato_FornitoreId' which is not configured in OpenAccess but exists on the database.
DROP INDEX [idx_PgmntUnificato_FornitoreId] ON [PagamentoUnificato]

go

-- add column for field _ragioneSociale
ALTER TABLE [Azienda] ADD [RagioneSociale] varchar(max) NULL

go

-- dropping unknown column [Denominazione]
ALTER TABLE [Azienda] DROP COLUMN [Denominazione]

go

-- add column for field _codiceFornitore
ALTER TABLE [PagamentoUnificato] ADD [CodiceFornitore] varchar(max) NULL

go

-- add column for field _data
ALTER TABLE [PagamentoUnificato] ADD [Data] datetime NULL

go

-- dropping unknown column [dta]
ALTER TABLE [PagamentoUnificato] DROP COLUMN [dta]

go

-- dropping unknown column [FornitoreId]
ALTER TABLE [PagamentoUnificato] DROP COLUMN [FornitoreId]

go

