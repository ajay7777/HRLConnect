using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HRLConnect.DAL;
using System.Data;
using HRLConnect.Models;

namespace HRLConnect.BAL
{
    public class SessionService
    {
        public UserDetails getUserDetails(string enterpriseID)
        {
            var UserDetails = new UserDetails();
            DataSet ds = new DataSet();
            List<DUDetails> LstDUDetails = new List<DUDetails>();
            
            ds = SessionDAL.getUserDetails(enterpriseID);
            if (ds!=null && ds.Tables[0].Rows.Count>0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    if (dr["EnterpriseID"] !=null)  { UserDetails.EnterpriseID = dr["EnterpriseID"].ToString(); }
                    if (dr["IsActive"] != null) { UserDetails.IsActive = Convert.ToInt32(dr["IsActive"]); }
                    if (dr["Supervisor"] != null) { UserDetails.SupervisorEntID = dr["Supervisor"].ToString(); }
                    if (dr["CareerLevel"] != null) { UserDetails.CareerLevel = dr["CareerLevel"].ToString(); }
                    if (dr["canConnect"] != null) { UserDetails.CanConnect = Convert.ToInt32(dr["canConnect"]); }
                    if (dr["Project"] != null) { UserDetails.Project = dr["Project"].ToString(); }
                    if (dr["ProjectID"] != null) { UserDetails.ProjectID = Convert.ToInt32(dr["ProjectID"]); }
                }

            }
            if (ds != null && ds.Tables[1].Rows.Count > 0)
            {
                foreach(DataRow dr in ds.Tables[1].Rows)
                {
                    var DUDetails = new DUDetails();
                    if (dr["DU ID"] != null) { DUDetails.DUID = Convert.ToInt32(dr["DU ID"]); }
                    if (dr["DU Name"] != null) { DUDetails.DUName = dr["DU Name"].ToString(); }
                    LstDUDetails.Add(DUDetails);

                }
                UserDetails.LstDUDetails = LstDUDetails;
            }
           
            return UserDetails;
        }
        
    }
    
}