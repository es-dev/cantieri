-- add column for field _totaleFattureAcquisto
ALTER TABLE [SAL] ADD [TotaleFattureAcquisto] numeric(20,10) NULL

go

-- add column for field _totaleFattureVendite
ALTER TABLE [SAL] ADD [TotaleFattureVendite] numeric(20,10) NULL

go

UPDATE [SAL] SET [TotaleFattureAcquisto] = [TotaleAcquisti]

go

UPDATE [SAL] SET [TotaleFattureVendite] = [TotaleVendite]

go

-- dropping unknown column [TotaleVendite]
ALTER TABLE [SAL] DROP COLUMN [TotaleVendite]

go

-- dropping unknown column [TotaleAcquisti]
ALTER TABLE [SAL] DROP COLUMN [TotaleAcquisti]

go

