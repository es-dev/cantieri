using Library.Code;
using Library.Interfaces;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace Web.GUI.Dashboard.Fatturazioni
{
	public partial class DashboardFatturazioniItem : TemplateItem
	{
        public DashboardFatturazioniItem()
        {
            InitializeComponent();
        }

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var objDto = (DashboardFatturazioni)model;
                    infoTitle.Text = objDto.Title;
                    infoCodice.Text = objDto.SubTitle;
                    infoDescription.Text = objDto.Description;
                    var image= objDto.Image;
                    infoImage.Image = (image==null? "" : image);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void BindModel(object model)
        {
            try
            {
                if (model != null)
                {
                    var objDto = (DashboardFatturazioni)model;
                    objDto.Title = infoTitle.Text;
                    objDto.SubTitle = infoCodice.Text;
                    objDto.Description = infoDescription.Text;
                    var image = infoImage.Image;
                    objDto.Image = (image == null ? "" : image.File);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void DashboardFatturazioniItem_ItemClick(IItem item)
        {
            try
            {
                if (item != null)
                {
                    var objDto = (DashboardFatturazioni)item.Model;
                    if (objDto != null)
                    {
                        var type = objDto.TypeSpace;
                        if (type != null)
                        {
                            var space = (ISpace)Activator.CreateInstance(type);
                            space.Title = objDto.Title.ToUpper();
                            AddSpace(space);
                        }
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
