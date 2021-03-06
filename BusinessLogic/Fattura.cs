﻿using Library.Code;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService.Dto;

namespace BusinessLogic
{
    public class Fattura
    {
        public static string GetCodifica(FatturaAcquistoDto fatturaAcquisto)
        {
            try
            {
                if (fatturaAcquisto != null)
                {
                    string codfica = fatturaAcquisto.Numero + " DEL " + UtilityValidation.GetDataND(fatturaAcquisto.Data);
                    return codfica;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static string GetCodifica(FatturaVenditaDto fatturaVendita)
        {
            try
            {
                if (fatturaVendita != null)
                {
                    string codfica = fatturaVendita.Numero + " DEL " + UtilityValidation.GetDataND(fatturaVendita.Data);
                    return codfica;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static string GetCodifica(NotaCreditoDto notaCredito)
        {
            try
            {
                if (notaCredito != null)
                {
                    string codfica = notaCredito.Numero + " DEL " + UtilityValidation.GetDataND(notaCredito.Data);
                    return codfica;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }


        public static decimal GetTotale(decimal imponibile, decimal iva)
        {
            try
            {
                decimal totale = imponibile + iva;
                return totale;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static decimal GetTotaleFatturaAcquisto(FatturaAcquistoDto fatturaAcquisto)
        {
            try
            {
                if (fatturaAcquisto != null)
                {
                    var imponibile = UtilityValidation.GetDecimal(fatturaAcquisto.Imponibile);
                    var iva = UtilityValidation.GetDecimal(fatturaAcquisto.IVA);
                    decimal totale = GetTotale(imponibile, iva);
                    return totale;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static decimal GetTotaleFatturaVendita(FatturaVenditaDto fatturaVendita)
        {
            try
            {
                if (fatturaVendita != null)
                {
                    var imponibile = UtilityValidation.GetDecimal(fatturaVendita.Imponibile);
                    var iva = UtilityValidation.GetDecimal(fatturaVendita.IVA);
                    decimal totale = GetTotale(imponibile, iva);
                    return totale;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static decimal GetTotaleIncassi(FatturaVenditaDto fatturaVendita, DateTime data)
        {
            try
            {
                if (fatturaVendita != null && fatturaVendita.Incassos!=null)
                {
                    var incassi = (from q in fatturaVendita.Incassos where q.Data <= data select q);
                    if (incassi != null)
                    {
                        decimal totale = 0;
                        foreach (var incasso in incassi)
                        {
                            var importo = UtilityValidation.GetDecimal(incasso.Importo);
                            totale += importo;
                        }
                        return totale;
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static decimal GetTotalePagamenti(FatturaAcquistoDto fatturaAcquisto, DateTime data)
        {
            try
            {
                if (fatturaAcquisto != null && fatturaAcquisto.Pagamentos!=null)
                {
                    var pagamenti = (from q in fatturaAcquisto.Pagamentos where q.Data <= data select q);
                    if (pagamenti != null)
                    {
                        decimal totale = 0;
                        foreach (var pagamento in pagamenti)
                        {
                            var importo = UtilityValidation.GetDecimal(pagamento.Importo);
                            totale += importo;
                        }
                        return totale;
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static decimal GetTotaleResi(FatturaAcquistoDto fatturaAcquisto, DateTime data)
        {
            try
            {
                if (fatturaAcquisto != null && fatturaAcquisto.Resos!=null)
                {
                    var resi = (from q in fatturaAcquisto.Resos where q.Data <= data select q);
                    if (resi != null)
                    {
                        decimal totale = 0;
                        foreach (var reso in resi)
                        {
                            var _totale = UtilityValidation.GetDecimal(reso.Totale);
                            totale += _totale;
                        }
                        return totale;
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static DateTime GetScadenza(FatturaAcquistoDto fatturaAcquisto)
        {
            try
            {
                if (fatturaAcquisto != null)
                {
                    var data = UtilityValidation.GetData(fatturaAcquisto.Data);
                    var scadenzaPagamento = UtilityEnum.GetValue<Tipi.ScadenzaPagamento>(fatturaAcquisto.ScadenzaPagamento);
                    var scadenza = GetScadenza(data, scadenzaPagamento);
                    return scadenza;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return DateTime.MinValue;
        }

        public static DateTime GetScadenza(FatturaVenditaDto fatturaVendita)
        {
            try
            {
                if (fatturaVendita != null)
                {
                    var data = UtilityValidation.GetData(fatturaVendita.Data);
                    var scadenzaPagamento = UtilityEnum.GetValue<Tipi.ScadenzaPagamento>(fatturaVendita.ScadenzaPagamento);
                    var scadenza = GetScadenza(data, scadenzaPagamento);
                    return scadenza;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return DateTime.MinValue;
        }

        private static DateTime GetScadenza(DateTime dataFattura, Tipi.ScadenzaPagamento scadenzaPagamento)
        {
            try
            {
                var giorni = GetGiorniScadenzaPagamento(scadenzaPagamento);
                var scadenza= dataFattura.AddDays(giorni);
                return scadenza;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return DateTime.MinValue;
        }

        private static int GetGiorniScadenzaPagamento(Tipi.ScadenzaPagamento scadenzaPagamento)
        {
            try
            {
                var giorni = 0;
                if (scadenzaPagamento == Tipi.ScadenzaPagamento.GG0)
                    giorni = 0;
                else if (scadenzaPagamento == Tipi.ScadenzaPagamento.GG120)
                    giorni = 120;
                else if (scadenzaPagamento == Tipi.ScadenzaPagamento.GG90)
                    giorni = 90;
                else if (scadenzaPagamento == Tipi.ScadenzaPagamento.GG60)
                    giorni = 60;
                else if (scadenzaPagamento == Tipi.ScadenzaPagamento.GG30)
                    giorni = 30;

                return giorni;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static string GetRitardo(DateTime data, DateTime scadenza)
        {
            try
            {
                string ritardo = null;
                var giorni = data.Subtract(scadenza).TotalDays;
                if (0 <= giorni && giorni <= 120)
                    ritardo = giorni.ToString() + " giorni";
                else if (120 < giorni && giorni <= 365)
                {
                    var mesi = (int)(giorni / 30) + 1;
                    ritardo = mesi.ToString() + " mesi";
                }
                else if (giorni > 365)
                {
                    var anni = (int)(giorni / 365);
                    ritardo = anni.ToString() + " anni";
                }
                return ritardo;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static string GetRitardo(FatturaAcquistoDto fatturaAcquisto)
        {
            try
            {
                if (fatturaAcquisto != null)
                {
                    var today = DateTime.Today;
                    var scadenza = GetScadenza(fatturaAcquisto);
                    var ritardo = GetRitardo(today, scadenza);
                    return ritardo;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static string GetRitardo(FatturaVenditaDto fatturaVendita)
        {
            try
            {
                if (fatturaVendita != null)
                {
                    var today = DateTime.Today;
                    var scadenza = GetScadenza(fatturaVendita);
                    var ritardo = GetRitardo(today, scadenza);
                    return ritardo;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static Tipi.StatoFattura GetStato(FatturaAcquistoDto fatturaAcquisto)
        {
            try
            {
                if (fatturaAcquisto != null)
                {
                    var today = DateTime.Today;
                    var scadenza = GetScadenza(fatturaAcquisto);
                    var totaleSaldoFattura = GetTotaleSaldoFatturaAcquisto(fatturaAcquisto, today);
                    var totalePagamenti = GetTotalePagamenti(fatturaAcquisto, today);
                    var stato = GetStato(today, scadenza, totaleSaldoFattura, totalePagamenti);
                    return stato;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return Tipi.StatoFattura.None;
        }

        public static Tipi.StatoFattura GetStato(FatturaVenditaDto fatturaVendita)
        {
            try
            {
                if (fatturaVendita != null)
                {
                    var today = DateTime.Today;
                    var scadenza = GetScadenza(fatturaVendita);
                    var totaleFattura = UtilityValidation.GetDecimal(fatturaVendita.Totale);
                    var totaleIncassi = GetTotaleIncassi(fatturaVendita, today);
                    var stato = GetStato(today, scadenza, totaleFattura, totaleIncassi);
                    return stato;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return Tipi.StatoFattura.None;
        }

        private static Tipi.StatoFattura GetStato(DateTime today, DateTime scadenza, decimal totaleSaldoFattura, decimal totalePagamentiIncassi)
        {
            try
            {
                var stato = Tipi.StatoFattura.None;
                var insoluta = (today > scadenza);
                if (totalePagamentiIncassi < totaleSaldoFattura)
                {
                    if (insoluta)
                        stato = Tipi.StatoFattura.Insoluta;
                    else
                        stato = Tipi.StatoFattura.NonPagata;
                }
                else if (totalePagamentiIncassi == totaleSaldoFattura)
                    stato = Tipi.StatoFattura.Pagata;
                else if (totalePagamentiIncassi > totaleSaldoFattura)
                    stato = Tipi.StatoFattura.Incoerente;

                return stato;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return Tipi.StatoFattura.None;

        }

        public static string GetListaFatture(IList<FatturaAcquistoDto> fattureAcquisto)
        {
            try
            {
                if (fattureAcquisto != null)
                {
                    string listaFatture = null;
                    foreach (var fatturaAcquisto in fattureAcquisto)
                    {
                        if (listaFatture != null)
                            listaFatture += ", ";
                        var numero = UtilityValidation.GetStringND(fatturaAcquisto.Numero);
                        var data = UtilityValidation.GetData(fatturaAcquisto.Data);
                        var anno = data.Year.ToString();
                        var _fattura = numero + "/" + anno;
                        listaFatture += _fattura;
                    }
                    return listaFatture;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static string GetListaFatture(IList<FatturaVenditaDto> fattureVendita)
        {
            try
            {
                if (fattureVendita != null)
                {
                    string listaFatture = null;
                    foreach (var fatturaVendita in fattureVendita)
                    {
                        if (listaFatture != null)
                            listaFatture += ", ";
                        var numero = UtilityValidation.GetStringND(fatturaVendita.Numero);
                        var data = UtilityValidation.GetData(fatturaVendita.Data);
                        var anno = data.Year.ToString();
                        var _fattura = numero + "/" + anno;
                        listaFatture += _fattura;
                    }
                    return listaFatture;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static decimal GetTotalePagamentiDato(FatturaAcquistoDto fatturaAcquisto, DateTime data)
        {
            try
            {
                if (fatturaAcquisto != null)
                {
                    var totalePagamenti = GetTotalePagamenti(fatturaAcquisto, data);
                    var totaleResi = GetTotaleResi(fatturaAcquisto);
                    var sconto = UtilityValidation.GetDecimal(fatturaAcquisto.Sconto);
                    decimal totalePagamentiDato = totalePagamenti + sconto + totaleResi;
                    return totalePagamentiDato;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
        
        public static decimal GetTotalePagamentiDare(FatturaAcquistoDto fatturaAcquisto, DateTime data)
        {
            try
            {
                if (fatturaAcquisto != null)
                {
                    var totaleFatturaAcquisto = GetTotaleFatturaAcquisto(fatturaAcquisto);
                    var totalePagamentiDato = GetTotalePagamentiDato(fatturaAcquisto, data);
                    var totalePagamentiDare = totaleFatturaAcquisto - totalePagamentiDato;
                    return totalePagamentiDare;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static decimal GetTotaleSaldoFatturaAcquisto(FatturaAcquistoDto fatturaAcquisto, DateTime data)
        {
            try
            {
                if (fatturaAcquisto != null)
                {
                    var sconto = UtilityValidation.GetDecimal(fatturaAcquisto.Sconto);
                    var totale = UtilityValidation.GetDecimal(fatturaAcquisto.Totale);
                    var totaleResi = GetTotaleResi(fatturaAcquisto, data);
                    var totaleSaldoFatturaAcquisto = totale - sconto - totaleResi;
                    return totaleSaldoFatturaAcquisto;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static decimal GetTotaleNotaCredito(NotaCreditoDto notaCredito, DateTime data)
        {
            try
            {
                if (notaCredito != null && notaCredito.Resos != null)
                {
                    var resi = (from q in notaCredito.Resos where q.Data <= data select q);
                    if (resi != null)
                    {
                        decimal totale = 0;
                        foreach (var reso in resi)
                        {
                            var totaleReso = UtilityValidation.GetDecimal(reso.Totale);
                            totale += totaleReso;
                        }
                        return totale;
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static decimal GetImponibileNotaCredito(NotaCreditoDto notaCredito, DateTime data)
        {
            try
            {
                if (notaCredito != null && notaCredito.Resos != null)
                {
                    var resi = (from q in notaCredito.Resos where q.Data <= data select q);
                    if (resi != null)
                    {
                        decimal imponibile = 0;
                        foreach (var reso in resi)
                        {
                            var importo = UtilityValidation.GetDecimal(reso.Importo);
                            imponibile += importo;
                        }
                        return imponibile;
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static decimal GetIVANotaCredito(NotaCreditoDto notaCredito, DateTime data)
        {
            try
            {
                if (notaCredito != null && notaCredito.Resos != null)
                {
                    var resi = (from q in notaCredito.Resos where q.Data <= data select q);
                    if (resi != null)
                    {
                        decimal IVA = 0;
                        foreach (var reso in resi)
                        {
                            var iva = UtilityValidation.GetDecimal(reso.IVA);
                            IVA += iva;
                        }
                        return IVA;
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

       

        public static decimal GetTotalePagamenti(FatturaAcquistoDto fatturaAcquisto, CommessaDto commessa)
        {
            try
            {
                if (fatturaAcquisto != null && commessa != null)
                {
                    decimal totale = 0;
                    var statoCommessa = commessa.Stato;
                    if (statoCommessa == Tipi.StatoCommessa.Chiusa.ToString())
                        totale = UtilityValidation.GetDecimal(fatturaAcquisto.TotalePagamenti);
                    else
                    {
                        var today = DateTime.Today;
                        totale = GetTotalePagamenti(fatturaAcquisto, today);
                    }
                    return totale;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        private static StateDescriptionImage GetStatoDescrizione(FatturaAcquistoDto fatturaAcquisto, DateTime data)
        {
            try
            {
                if (fatturaAcquisto != null)
                {
                    var stato = TypeState.None;
                    var descrizione = "";
                    var scadenza = GetScadenza(fatturaAcquisto);
                    var totalePagamenti = GetTotalePagamenti(fatturaAcquisto, data);
                    var totaleSaldoFattura = GetTotaleSaldoFatturaAcquisto(fatturaAcquisto, data);
                    var statoFattura = GetStato(fatturaAcquisto);
                    var ritardo = GetRitardo(data, scadenza);
                    var _totalePagamenti = UtilityValidation.GetEuro(totalePagamenti);
                    var _totaleSaldoFattura = UtilityValidation.GetEuro(totaleSaldoFattura);
                    var _scadenza = UtilityValidation.GetDataND(scadenza);

                    if (statoFattura == Tipi.StatoFattura.Insoluta)
                    {
                        descrizione = "La fattura risulta insoluta. Il totale pagamenti pari a " + _totalePagamenti + " è inferiore al saldo della fattura pari a " + _totaleSaldoFattura + ". La fattura risulta scaduta il " + _scadenza + " con un ritardo di pagamento pari a " + ritardo;
                        stato = TypeState.Critical;
                    }
                    else if (statoFattura == Tipi.StatoFattura.NonPagata)
                    {
                        descrizione = "La fattura risulta in pagamento. Il totale pagamenti pari a " + _totalePagamenti + " è inferiore al saldo della fattura pari a " + _totaleSaldoFattura + ". La fattura scade il " + _scadenza;
                        stato = TypeState.Warning;
                    }
                    else if (statoFattura == Tipi.StatoFattura.Incoerente)
                    {
                        descrizione = "La fattura è stata pagata ma risulta incoerente. Il totale pagamenti pari a " + _totalePagamenti + " è superiore al saldo della fattura pari a " + _totaleSaldoFattura + ".";
                        stato = TypeState.Warning;
                    }
                    else if (statoFattura == Tipi.StatoFattura.Pagata)
                    {
                        descrizione = "La fattura è stata pagata";
                        stato = TypeState.Normal;
                    }
                    var statoDescrizione = new StateDescriptionImage(statoFattura.ToString(), stato, descrizione);
                    return statoDescrizione;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static string GetStatoDescrizione(FatturaAcquistoDto fatturaAcquisto)
        {
            try
            {
                var statoDescrizione = "N/D";
                if (fatturaAcquisto != null)
                {
                    var fornitore = fatturaAcquisto.Fornitore;
                    if (fornitore != null)
                    {
                        var commessa = fornitore.Commessa;
                        if (commessa != null)
                        {
                            var statoCommessa = commessa.Stato;
                            if (statoCommessa == Tipi.StatoCommessa.Chiusa.ToString())
                                statoDescrizione = fatturaAcquisto.Stato;
                            else
                            {
                                var today = DateTime.Today;
                                var _statoDescrizione = GetStatoDescrizione(fatturaAcquisto, today);
                                statoDescrizione = _statoDescrizione.ToString();
                            }
                        }
                    }
                }
                return statoDescrizione;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static string GetStatoDescrizione(FatturaVenditaDto fatturaVendita)
        {
            try
            {
                var statoDescrizione = "N/D";
                if (fatturaVendita != null)
                {
                    var committente = fatturaVendita.Committente;
                    if (committente != null)
                    {
                        var commessa = committente.Commessa;
                        if (commessa != null)
                        {
                            var statoCommessa = commessa.Stato;
                            if (statoCommessa == Tipi.StatoCommessa.Chiusa.ToString())
                                statoDescrizione = fatturaVendita.Stato;
                            else
                            {
                                var today = DateTime.Today;
                                var _statoDescrizione = GetStatoDescrizione(fatturaVendita, today);
                                statoDescrizione = _statoDescrizione.ToString();
                            }
                        }
                    }
                }
                return statoDescrizione;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private static StateDescriptionImage GetStatoDescrizione(FatturaVenditaDto fatturaVendita, DateTime data)
        {
            try
            {
                if (fatturaVendita != null)
                {
                    var stato = TypeState.None;
                    var descrizione = "";
                    var scadenza = GetScadenza(fatturaVendita);
                    var totaleIncassi = GetTotaleIncassi(fatturaVendita, data);
                    var totaleFatturaVendita = GetTotaleFatturaVendita(fatturaVendita);
                    var statoFattura = GetStato(fatturaVendita);
                    var ritardo = GetRitardo(data, scadenza);
                    var _totaleIncassi = UtilityValidation.GetEuro(totaleIncassi);
                    var _totaleFatturaVendita = UtilityValidation.GetEuro(totaleFatturaVendita);
                    var _scadenza = UtilityValidation.GetDataND(scadenza);

                    if (statoFattura == Tipi.StatoFattura.Insoluta)
                    {
                        descrizione = "La fattura risulta insoluta. Il totale incassi pari a " + _totaleIncassi + " è inferiore al totale della fattura pari a " + _totaleFatturaVendita + ". La fattura risulta scaduta il " + _scadenza + " con un ritardo di incasso pari a " + ritardo;
                        stato = TypeState.Critical;
                    }
                    else if (statoFattura == Tipi.StatoFattura.NonPagata)
                    {
                        descrizione = "La fattura risulta non incassata. Il totale incassi pari a " + _totaleIncassi + " è inferiore al totale della fattura pari a " + _totaleFatturaVendita + ". La fattura scade il " + _scadenza;
                        stato = TypeState.Warning;
                    }
                    else if (statoFattura == Tipi.StatoFattura.Incoerente)
                    {
                        descrizione = "La fattura è stata incassata ma risulta incoerente. Il totale incassi pari a " + _totaleIncassi + " è superiore al totale della fattura pari a " + _totaleFatturaVendita + ".";
                        stato = TypeState.Warning;
                    }
                    else if (statoFattura == Tipi.StatoFattura.Pagata)
                    {
                        descrizione = "La fattura è stata incassata";
                        stato = TypeState.Normal;
                    }
                    var _stato = new StateDescriptionImage(statoFattura.ToString(), stato, descrizione);
                    return _stato;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static decimal GetTotaleIncassi(FatturaVenditaDto fatturaVendita, CommessaDto commessa)
        {
            try
            {
                if (fatturaVendita != null && commessa != null)
                {
                    decimal totale = 0;
                    var statoCommessa = commessa.Stato;
                    if (statoCommessa == Tipi.StatoCommessa.Chiusa.ToString())
                        totale = UtilityValidation.GetDecimal(fatturaVendita.TotaleIncassi);
                    else
                    {
                        var today = DateTime.Today;
                        totale = GetTotaleIncassi(fatturaVendita, today);
                    }
                    return totale;

                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static decimal GetTotaleResi(FatturaAcquistoDto fatturaAcquisto)
        {
            try
            {
                if (fatturaAcquisto != null)
                {
                    var data = DateTime.Today;
                    var totaleResi = GetTotaleResi(fatturaAcquisto, data);
                    return totaleResi;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static decimal GetTotaleIncassiAvere(FatturaVenditaDto fatturaVendita, DateTime data)
        {
            try
            {
                if (fatturaVendita != null)
                {
                    var totaleFattureVendita = GetTotaleFatturaVendita(fatturaVendita);
                    var totaleIncassiAvuto = GetTotaleIncassi(fatturaVendita, data);
                    var totaleIncassiAvere = totaleFattureVendita - totaleIncassiAvuto;
                    return totaleIncassiAvere;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public static decimal GetTotaleIncassiAvuto(FatturaVenditaDto fatturaVendita, DateTime data)
        {
            try
            {
                if (fatturaVendita != null)
                {
                    var totaleIncassiAvuto = GetTotaleIncassi(fatturaVendita, data);
                    return totaleIncassiAvuto;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
    }
}
