-- add column for field _note
ALTER TABLE [Incasso] ADD [Note] varchar(max) NULL

go

-- dropping unknown column [Note ]
ALTER TABLE [Incasso] DROP COLUMN [Note ]

go

-- add column for field _note
ALTER TABLE [Pagamento] ADD [Note] varchar(max) NULL

go

-- dropping unknown column [Note ]
ALTER TABLE [Pagamento] DROP COLUMN [Note ]

go

