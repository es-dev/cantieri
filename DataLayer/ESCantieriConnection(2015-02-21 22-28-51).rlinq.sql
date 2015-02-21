-- add column for field _note
ALTER TABLE [ReportJob] ADD [Note] varchar(max) NULL

go

-- dropping unknown column [Nome]
ALTER TABLE [ReportJob] DROP COLUMN [Nome]

go

