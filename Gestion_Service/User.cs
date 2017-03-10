using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Gestion_Service
{
    [DataContract()]
    [Serializable()]
    public class User
    {

        [DataMember()]
        public String Username { get; set; }
        [DataMember()]
        public String Password { get; set; }
        [DataMember()]
        public String Id_Fonction { get; set; }
        [DataMember()]
        public String Id_Employee { get; set; }
        [DataMember()]
        public int Privilege { get; set; }

    }
}