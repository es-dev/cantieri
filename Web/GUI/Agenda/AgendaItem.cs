using Library.Code;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService.Dto;

namespace Web.GUI.Agenda
{
    public class AgendaItem : Library.Template.MVVM.TemplateSchedulerItem 
    {
        public AgendaItem()
		{
            try
            {
                this.ItemClick += AgendaItem_ItemClick;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (AgendaDto)model;
                    this.Subject = obj.Titolo;
                    this.Start = obj.Data;
                    this.End = obj.Data.AddHours(1);
                    this.BackgroundColor = obj.Color;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void AgendaItem_ItemClick(IItem item)
        {
            try
            {
                if (item != null)
                {
                    var agenda = (AgendaDto)Model;
                    var model = agenda.Model;
                    if (model.GetType() == typeof(FatturaAcquistoDto))
                    {
                        var obj = (FatturaAcquistoDto)model;
                        var space = new FatturaAcquisto.FatturaAcquistoModel();
                        var fornitore = obj.Fornitore;
                        space.Title = "FATTURA DI ACQUISTO N." + obj.Numero + " - " + fornitore.RagioneSociale;
                        space.Model = obj;
                        AddSpace(space);
                    }
                    //gestione degli altri casi
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

    }
}