using Library.Code;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class WorkFlow : IWorkFlow
    {
        public WorkFlow()
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

        private TimeSpan interval = new TimeSpan(0, 0, 15);
        public TimeSpan Interval
        {
            get
            {
                return interval;
            }
        }


        public void Tick()
        {
            try
            {
                var wcf = new WcfService.Service();
                var count = wcf.CountCommesse();
                System.IO.File.AppendAllText(@"c:\temp\test.txt", DateTime.Now.ToString() + " - Ciao Gaia e GB " + count + Environment.NewLine);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }






       
    }
}
