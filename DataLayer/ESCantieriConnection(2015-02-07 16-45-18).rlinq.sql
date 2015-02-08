-- Column was read from database as: [Stato] varchar(255) null
-- modify column for field _stato
ALTER TABLE [FatturaAcquisto] ALTER COLUMN [Stato] varchar(max) NULL

go

-- Column was read from database as: [TotalePagamenti] numeric(20,10) not null
-- modify column for field _totalePagamenti
ALTER TABLE [FatturaAcquisto] ALTER COLUMN [TotalePagamenti] numeric(20,10) NULL

go

