
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Gestion_Service.Models
{
    
    [Serializable()]
    [DataContract()]
    public class Employee
    {
        [DataMember()]
        [Key]
        public int employeeID { get; set; }
        [DataMember()]
        public int functionID { get; set; }
        [DataMember()]
        public String employeeFirstName { get; set; }
        [DataMember()]
        public String employeeName { get; set; }
        [DataMember()]
        public DateTime employeeEnrollementDate { get; set; }
        [DataMember()]
        public String employeeMail { get; set; }
        [DataMember()]
        public string employeePhone { get; set; }
        [DataMember()]
        public string employeeAddress { get; set; }

        public virtual Function function { get; set; }

    }
}