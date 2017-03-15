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
    public class Group
    {
        [DataMember()]
        [Key()]
        public int groupID { get; set; }
        [DataMember()]
        public string groupTitle { get; set; }

    }
}
