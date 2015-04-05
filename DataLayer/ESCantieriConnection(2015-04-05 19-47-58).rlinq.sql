-- add column for field _totaleFattureVendita
ALTER TABLE [SAL] ADD [TotaleFattureVendita] numeric(20,10) NULL

go

UPDATE [SAL] SET [TotaleFattureVendita] = [TotaleFattureVendite]

go

-- dropping unknown column [TotaleFattureVendite]
ALTER TABLE [SAL] DROP COLUMN [TotaleFattureVendite]

go

