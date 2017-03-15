using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace Gestion_Service.Models
{
    public enum privilege : int
    {
        limitedAccess=1,logisticAccess=2,accountingAccess=3,managerAccess=4,superAccess=10
    };
    [DataContract()]
    [Serializable()]
    public class User
    {

        [DataMember()]
        [Key]
        public string Username { get; set; }
        [DataMember()]
        public string Password { get; set; }
        [DataMember()]
        public int functionID { get; set; }
        [DataMember()]
        public int employeeID { get; set; }
        [DataMember()]
        public privilege privilege { get; set; }
        [DataMember()]
        public string userIP { get; set; }

        public virtual Employee employee { get; set; }
        //public virtual Function function { get; set; }

       

    }
}