using Library.Code;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BusinessLogic
{
    public class WorkAction : IWorkAction
    {
        public WorkAction()
        {

        }

        private string name = "ES.Cantieri";
        public string Name
        {
            get
            {
                return name;
            }
        }

        private TimeSpan interval = new TimeSpan(0, 1, 0);
        public TimeSpan Interval
        {
            get
            {
                return interval;
            }
        }

        private HttpContext context = null;
        public HttpContext Context
        {
            get
            {
                return context;
            }
            set
            {
                context = value;
            }
        }

        public void Start()
        {
            try
            {
                var url = UtilityWeb.GetRootUrl(context);
                var webclient = new WebClient();
                webclient.DownloadString(url);
                var pathRoot = UtilityWeb.GetRootPath(context);
                //UtilityEmail.Send("pasqualeiaquinta@hotmail.com", "Test WFS - WorkActivity at " + DateTime.Now.ToString(), "Elaborazione flusso di lavoro avviato il " + DateTime.Now.ToString());

                System.IO.File.AppendAllText(pathRoot+@"Resources\test.txt", DateTime.Now.ToString() + " - " + url + Environment.NewLine);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
       
    }
}
