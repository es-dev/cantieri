-- add column for field _scadenza
ALTER TABLE [FatturaAcquisto] ADD [Scadenza] datetime NULL

go

-- add column for field _scadenza
ALTER TABLE [FatturaVendita] ADD [Scadenza] datetime NULL

go

UPDATE [FatturaAcquisto]  SET [Scadenza] = [Data] WHERE [ScadenzaPagamento] IS NULL

go

UPDATE [FatturaAcquisto]  SET [Scadenza] = DATEADD(day,30,Data) WHERE [ScadenzaPagamento] = 'GG30'
go

UPDATE [FatturaAcquisto]  SET [Scadenza] = DATEADD(day,60,Data) WHERE [ScadenzaPagamento] = 'GG60'
go

UPDATE [FatturaAcquisto]  SET [Scadenza] = DATEADD(day,90,Data) WHERE [ScadenzaPagamento] = 'GG90'
go

UPDATE [FatturaAcquisto]  SET [Scadenza] = DATEADD(day,120,Data) WHERE [ScadenzaPagamento] = 'GG120'
go

UPDATE [FatturaVendita]  SET [Scadenza] = [Data] WHERE [ScadenzaPagamento] IS NULL

go

UPDATE [FatturaVendita]  SET [Scadenza] = DATEADD(day,30,Data) WHERE [ScadenzaPagamento] = 'GG30'
go

UPDATE [FatturaVendita]  SET [Scadenza] = DATEADD(day,60,Data) WHERE [ScadenzaPagamento] = 'GG60'
go

UPDATE [FatturaVendita]  SET [Scadenza] = DATEADD(day,90,Data) WHERE [ScadenzaPagamento] = 'GG90'
go

UPDATE [FatturaVendita]  SET [Scadenza] = DATEADD(day,120,Data) WHERE [ScadenzaPagamento] = 'GG120'
go