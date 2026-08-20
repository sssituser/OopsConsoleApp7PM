using System;
using System.Collections.Generic;
using System.Text;

namespace OopsConsoleApp7PM
{
    internal class Company
    {
        public int CompanyId { get; private set; }  // Read Only Properties

        public  string ? CompanyName { get;private set; }

        public string ? CompanyAddress { get;private set; }

        public void SetCompany(int cid,string cname,string cadrs)
        {
            CompanyId = cid;
            CompanyName = cname;
            CompanyAddress = cadrs;
        }

       
    }
}
