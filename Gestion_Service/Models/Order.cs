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
    public class Order
    {
        [DataMember()]
        [Key()]
        public int orderID { get; set; }
        [DataMember()]
        public int resourceID { get; set; }
        [DataMember()]
        public int providerID { get; set; }
        [DataMember()]
        public DateTime orderDate { get; set; }
        [DataMember()]
        public bool orderStatus { get; set; }

        public virtual Provider provider { get; set; }
        //public virtual Resource resource { get; set; }

    }
}
