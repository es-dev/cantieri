-- in fornitori aggiustare codici 28, 114, e 182-->138 Hitesca srl


-- add column for field _transazionePagamento
ALTER TABLE [PagamentoUnificatoFatturaAcquisto] ADD [TransazionePagamento] varchar(max) NULL

go

