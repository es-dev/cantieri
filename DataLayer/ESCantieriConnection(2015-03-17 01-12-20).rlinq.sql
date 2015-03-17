SET IDENTITY_INSERT [Cliente] ON 

GO
INSERT [Cliente] ([CAP], [Codice], [CodiceCatastale], [CommessaId], [Comune], [Email], [Fax], [Id], [Indirizzo], [Localita], [Mobile], [Note], [PartitaIva], [Provincia], [RagioneSociale], [Stato], [Telefono], [TotaleFattureVendita], [TotaleLiquidazioni]) VALUES (N'87040', N'02', N'G331', 5, N'PARENTI', N'', N'', 5, N'VIA SILANA,13', N'', N'', N'', N'', N'CS', N'COMUNE DI PARENTI', N'', N'0984-965007', NULL, NULL)
GO
INSERT [Cliente] ([CAP], [Codice], [CodiceCatastale], [CommessaId], [Comune], [Email], [Fax], [Id], [Indirizzo], [Localita], [Mobile], [Note], [PartitaIva], [Provincia], [RagioneSociale], [Stato], [Telefono], [TotaleFattureVendita], [TotaleLiquidazioni]) VALUES (N'87040', N'05', N'E773', 7, N'LUZZI', N'', N'', 7, N'VIA RISICOLI,8', N'', N'', N'', N'02634630780', N'CS', N'MURANO COSTRUZIONI SRL', N'None{;}', N'', CAST(1.0000000000 AS Numeric(20, 10)), CAST(1.0000000000 AS Numeric(20, 10)))
GO
INSERT [Cliente] ([CAP], [Codice], [CodiceCatastale], [CommessaId], [Comune], [Email], [Fax], [Id], [Indirizzo], [Localita], [Mobile], [Note], [PartitaIva], [Provincia], [RagioneSociale], [Stato], [Telefono], [TotaleFattureVendita], [TotaleLiquidazioni]) VALUES (N'88836', N'04', N'', 9, N'', N'', N'', 9, N'VIA IOLANDA', N'', N'', N'', N'00297910796', N'', N'COMUNE DI COTRONEI', N'None{;}', N'0962-44202', CAST(1.0000000000 AS Numeric(20, 10)), CAST(1.0000000000 AS Numeric(20, 10)))
GO
SET IDENTITY_INSERT [Cliente] OFF
GO


ALTER TABLE [FatturaVendita] ADD CONSTRAINT [ref_FatturaVendita_Cliente] FOREIGN KEY ([ClienteId]) REFERENCES [Cliente]([Id])

go



