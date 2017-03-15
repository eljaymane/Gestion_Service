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
   public class Function
    {
        [DataMember()]
        [Key()]
        public int functionID { get; set; }
        [DataMember()]
        public string functionTitle { get; set; }
        [DataMember()]
        public privilege privilege { get; set; }
        [DataMember()]
        public int groupID { get; set; }

        public virtual Group group { get; set; }
    }
}
