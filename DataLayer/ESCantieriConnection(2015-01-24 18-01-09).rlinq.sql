-- Column was read from database as: [PrezzoUnitario] numeric(20,10) not null
-- modify column for field _prezzoUnitario
sp_rename '[Articolo].[PrezzoUnitario]', [temp_column_a], 'COLUMN'

go

ALTER TABLE [Articolo] ADD [PrezzoUnitario] numeric NULL

go

UPDATE [Articolo]
   SET [PrezzoUnitario] = CONVERT(numeric, [temp_column_a])

go

ALTER TABLE [Articolo] DROP COLUMN [temp_column_a]

go

