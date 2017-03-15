using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Service.Models
{
    [Serializable()]
    [DataContract()]
    public class Provider
    {
        [DataMember()]
        [Key()]
        public int providerID { get; set; }
        [DataMember()]
        public string providerName {get; set;}
        [DataMember()]
        public string providerPhone { get; set; }
        [DataMember()]
        public string providerMail { get; set; }
        [DataMember()]
        public DateTime firstDelivery { get; set; }
        [DataMember()]
        public DateTime lastDelivery { get; set; }
        

    }
}
