using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRLConnect.Models
{
    public class UserDetails
    {
        public string EnterpriseID { get; set; }
        public int  IsActive { get; set; }
        public string SupervisorEntID { get; set; }
        public string Project { get; set; }
        public int ProjectID  { get; set; }
        public int CanConnect { get; set; }
       
        public string CareerLevel { get; set; }
        public List<DUDetails> LstDUDetails { get; set; }

    }
    public class DUDetails
    {
        public int DUID { get; set; }
        public string DUName { get; set; }

    }
}
