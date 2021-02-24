using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ubsAuto
{
    class Utility
    {
        public static List<string> ListIWebToString(IList<IWebElement> list)
        {
            if (list.Count > 0)
            {

            }
            else
            {
                Task.Delay(5000).Wait();
            }
            List<string> SList = new List<string>();

            foreach (IWebElement ele in list)
            {
                string s = ele.Text.ToString().Trim();
                if (s.Length > 0)
                {
                    SList.Add(ele.Text.ToString().Trim());
                }

            }

            return SList;
        }
    }
}
