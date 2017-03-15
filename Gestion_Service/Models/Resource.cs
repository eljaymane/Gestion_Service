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
    public class Resource
    {
        [Key()]
        [DataMember()]
        public int resourceID { get; set; }
        [DataMember()]
        public int providerID { get; set; }
        [DataMember()]
        public int resourceQuantity { get; set; }
        [DataMember()]
        public float resourcePrice { get; set; }
        [DataMember()]
        public int controlPoint { get; set; }

        public virtual Provider provider { get; set; }
    }
}
