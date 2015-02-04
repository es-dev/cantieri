-- Column was read from database as: [Codice] varchar(255) null
-- modify column for field _codice
ALTER TABLE [AnagraficaArticolo] ALTER COLUMN [Codice] varchar(max) NULL

go

-- Column was read from database as: [CAP] varchar(5) null
-- modify column for field _cAP
ALTER TABLE [AnagraficaCliente] ALTER COLUMN [CAP] varchar(max) NULL

go

-- Column was read from database as: [Codice] varchar(255) null
-- modify column for field _codice
ALTER TABLE [AnagraficaCliente] ALTER COLUMN [Codice] varchar(max) NULL

go

-- Column was read from database as: [Fax] varchar(255) null
-- modify column for field _fax
ALTER TABLE [AnagraficaCliente] ALTER COLUMN [Fax] varchar(max) NULL

go

-- Column was read from database as: [Mobile] varchar(255) null
-- modify column for field _mobile
ALTER TABLE [AnagraficaCliente] ALTER COLUMN [Mobile] varchar(max) NULL

go

-- Column was read from database as: [PIva] varchar(11) null
-- modify column for field _pIva
ALTER TABLE [AnagraficaCliente] ALTER COLUMN [PIva] varchar(max) NULL

go

-- Column was read from database as: [Provincia] varchar(2) null
-- modify column for field _provincia
ALTER TABLE [AnagraficaCliente] ALTER COLUMN [Provincia] varchar(max) NULL

go

-- Column was read from database as: [Telefono] varchar(255) null
-- modify column for field _telefono
ALTER TABLE [AnagraficaCliente] ALTER COLUMN [Telefono] varchar(max) NULL

go

-- Column was read from database as: [CAP] varchar(5) null
-- modify column for field _cAP
ALTER TABLE [AnagraficaFornitore] ALTER COLUMN [CAP] varchar(max) NULL

go

-- Column was read from database as: [Codice] varchar(255) null
-- modify column for field _codice
ALTER TABLE [AnagraficaFornitore] ALTER COLUMN [Codice] varchar(max) NULL

go

-- Column was read from database as: [Fax] varchar(255) null
-- modify column for field _fax
ALTER TABLE [AnagraficaFornitore] ALTER COLUMN [Fax] varchar(max) NULL

go

-- Column was read from database as: [Mobile] varchar(255) null
-- modify column for field _mobile
ALTER TABLE [AnagraficaFornitore] ALTER COLUMN [Mobile] varchar(max) NULL

go

-- Column was read from database as: [PIva] varchar(11) null
-- modify column for field _pIva
ALTER TABLE [AnagraficaFornitore] ALTER COLUMN [PIva] varchar(max) NULL

go

-- Column was read from database as: [Provincia] varchar(2) null
-- modify column for field _provincia
ALTER TABLE [AnagraficaFornitore] ALTER COLUMN [Provincia] varchar(max) NULL

go

-- Column was read from database as: [Telefono] varchar(255) null
-- modify column for field _telefono
ALTER TABLE [AnagraficaFornitore] ALTER COLUMN [Telefono] varchar(max) NULL

go

-- Column was read from database as: [Descrizione] varchar(255) null
-- modify column for field _descrizione
ALTER TABLE [Articolo] ALTER COLUMN [Descrizione] varchar(max) NULL

go

-- Column was read from database as: [CAP] varchar(5) null
-- modify column for field _cAP
ALTER TABLE [Azienda] ALTER COLUMN [CAP] varchar(max) NULL

go

-- Column was read from database as: [Codice] varchar(255) null
-- modify column for field _codice
ALTER TABLE [Azienda] ALTER COLUMN [Codice] varchar(max) NULL

go

-- Column was read from database as: [PIva] varchar(11) null
-- modify column for field _pIva
ALTER TABLE [Azienda] ALTER COLUMN [PIva] varchar(max) NULL

go

-- Column was read from database as: [Provincia] varchar(2) null
-- modify column for field _provincia
ALTER TABLE [Azienda] ALTER COLUMN [Provincia] varchar(max) NULL

go

-- Column was read from database as: [Codice] varchar(255) null
-- modify column for field _codice
ALTER TABLE [CentroCosto] ALTER COLUMN [Codice] varchar(max) NULL

go

-- Column was read from database as: [CAP] varchar(5) null
-- modify column for field _cAP
ALTER TABLE [Cliente] ALTER COLUMN [CAP] varchar(max) NULL

go

-- Column was read from database as: [Codice] varchar(255) null
-- modify column for field _codice
ALTER TABLE [Cliente] ALTER COLUMN [Codice] varchar(max) NULL

go

-- Column was read from database as: [Email] varchar(255) null
-- modify column for field _email
ALTER TABLE [Cliente] ALTER COLUMN [Email] varchar(max) NULL

go

-- Column was read from database as: [Fax] varchar(255) null
-- modify column for field _fax
ALTER TABLE [Cliente] ALTER COLUMN [Fax] varchar(max) NULL

go

-- Column was read from database as: [Mobile] varchar(255) null
-- modify column for field _mobile
ALTER TABLE [Cliente] ALTER COLUMN [Mobile] varchar(max) NULL

go

-- Column was read from database as: [PIva] varchar(11) null
-- modify column for field _pIva
ALTER TABLE [Cliente] ALTER COLUMN [PIva] varchar(max) NULL

go

-- Column was read from database as: [Provincia] varchar(2) null
-- modify column for field _provincia
ALTER TABLE [Cliente] ALTER COLUMN [Provincia] varchar(max) NULL

go

-- Column was read from database as: [Telefono] varchar(255) null
-- modify column for field _telefono
ALTER TABLE [Cliente] ALTER COLUMN [Telefono] varchar(max) NULL

go

-- Column was read from database as: [CAP] varchar(5) null
-- modify column for field _cAP
ALTER TABLE [Commessa] ALTER COLUMN [CAP] varchar(max) NULL

go

-- Column was read from database as: [Oggetto] varchar(255) null
-- modify column for field _oggetto
ALTER TABLE [Commessa] ALTER COLUMN [Oggetto] varchar(max) NULL

go

-- Column was read from database as: [Provincia] varchar(2) null
-- modify column for field _provincia
ALTER TABLE [Commessa] ALTER COLUMN [Provincia] varchar(max) NULL

go

-- Column was read from database as: [Numero] varchar(255) null
-- modify column for field _numero
ALTER TABLE [FatturaAcquisto] ALTER COLUMN [Numero] varchar(max) NULL

go

-- Column was read from database as: [ScadenzaPagamento] varchar(max) not null
-- modify column for field _scadenzaPagamento
ALTER TABLE [FatturaAcquisto] ALTER COLUMN [ScadenzaPagamento] varchar(max) NULL

go

-- Column was read from database as: [Numero] varchar(255) null
-- modify column for field _numero
ALTER TABLE [FatturaVendita] ALTER COLUMN [Numero] varchar(max) NULL

go

-- Column was read from database as: [ScadenzaPagamento] varchar(max) not null
-- modify column for field _scadenzaPagamento
ALTER TABLE [FatturaVendita] ALTER COLUMN [ScadenzaPagamento] varchar(max) NULL

go

-- Column was read from database as: [CAP] varchar(5) null
-- modify column for field _cAP
ALTER TABLE [Fornitore] ALTER COLUMN [CAP] varchar(max) NULL

go

-- Column was read from database as: [Codice] varchar(255) null
-- modify column for field _codice
ALTER TABLE [Fornitore] ALTER COLUMN [Codice] varchar(max) NULL

go

-- Column was read from database as: [Email] varchar(255) null
-- modify column for field _email
ALTER TABLE [Fornitore] ALTER COLUMN [Email] varchar(max) NULL

go

-- Column was read from database as: [Fax] varchar(255) null
-- modify column for field _fax
ALTER TABLE [Fornitore] ALTER COLUMN [Fax] varchar(max) NULL

go

-- Column was read from database as: [Mobile] varchar(255) null
-- modify column for field _mobile
ALTER TABLE [Fornitore] ALTER COLUMN [Mobile] varchar(max) NULL

go

-- Column was read from database as: [PIva] varchar(255) null
-- modify column for field _pIva
ALTER TABLE [Fornitore] ALTER COLUMN [PIva] varchar(max) NULL

go

-- Column was read from database as: [Provincia] varchar(255) null
-- modify column for field _provincia
ALTER TABLE [Fornitore] ALTER COLUMN [Provincia] varchar(max) NULL

go

-- Column was read from database as: [Telefono] varchar(255) null
-- modify column for field _telefono
ALTER TABLE [Fornitore] ALTER COLUMN [Telefono] varchar(max) NULL

go

-- add column for field _descrizione
ALTER TABLE [Liquidazione] ADD [Descrizione] varchar(255) NULL

go

-- Column was read from database as: [Note ] varchar(max) not null
-- modify column for field _note
ALTER TABLE [Liquidazione] ALTER COLUMN [Note ] varchar(max) NULL

go

-- add column for field _tipoPagamento
ALTER TABLE [Liquidazione] ADD [TipoPagamento] varchar(max) NULL

go

-- add column for field _descrizione
ALTER TABLE [Pagamento] ADD [Descrizione] varchar(max) NULL

go

-- add column for field _tipoPagamento
ALTER TABLE [Pagamento] ADD [TipoPagamento] varchar(max) NULL

go

-- Column was read from database as: [Codice] varchar(255) null
-- modify column for field _codice
ALTER TABLE [SAL] ALTER COLUMN [Codice] varchar(max) NULL

go

