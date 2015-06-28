using Library.Code;
using Library.Interfaces;
using Library.Template.Scheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService.Dto;
using Web.GUI.FatturaAcquisto;
using Web.GUI.FatturaVendita;
using Web.GUI.Pagamento;

namespace Web.GUI.Agenda
{
    public class SchedulerItem : TemplateItem 
    {
        public SchedulerItem()
		{
            try
            {
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
                    var obj = (SchedulerDto)model;
                    this.Subject = obj.Subject;
                    this.Start = obj.Start;
                    this.End = obj.Start.AddHours(1);
                    this.BackgroundColor = obj.BackgroundColor;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void ItemClick(IItem item)
        {
            try
            {
                if (item != null)
                {
                    var agenda = (SchedulerDto)Model;
                    var model = agenda.Model;
                    if (model.GetType() == typeof(FatturaAcquistoDto))
                    {
                        var obj = (FatturaAcquistoDto)model;
                        var space = new FatturaAcquistoModel();
                        var viewModel = new FatturaAcquistoViewModel();
                        AddSpace(space, obj, viewModel);
                    }
                    else if (model.GetType() == typeof(FatturaVenditaDto))
                    {
                        var obj = (FatturaVenditaDto)model;
                        var space = new FatturaVenditaModel();
                        var viewModel = new FatturaVenditaViewModel();
                        AddSpace(space, obj, viewModel);
                    }
                    else if (model.GetType() == typeof(PagamentoDto))
                    {
                        var obj = (PagamentoDto)model;
                        var space = new PagamentoModel();
                        var viewModel = new PagamentoViewModel();
                        AddSpace(space, obj, viewModel);
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
       
    }
}