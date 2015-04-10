using Library.Code;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.GUI.Agenda
{
    public class AgendaItem : Library.Template.MVVM.TemplateSchedulerItem 
    {
        public AgendaItem()
		{
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (EventoDto)model;
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
                    //var obj = (WcfService.Dto.AziendaDto)Model;
                    //var space = new AziendaModel();
                    //space.Title = "AZIENDA " + obj.RagioneSociale;
                    //AddSpace(space);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            } 
        }

    }
}