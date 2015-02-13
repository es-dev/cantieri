-- add column for field _totaleLiquidazioni
ALTER TABLE [SAL] ADD [TotaleLiquidazioni] numeric(20,10) NULL

go

-- dropping unknown column [TotaleIncassi]
ALTER TABLE [SAL] DROP COLUMN [TotaleIncassi]

go

