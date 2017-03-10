
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Gestion_Service
{
    
    [Serializable()]
    [DataContract()]
    public class Employee
    {
        [DataMember()]
        public String Id_Employee { get; set; }
        [DataMember()]
        public String Id_Fonction { get; set; }
        [DataMember()]
        public String Nom { get; set; }
        [DataMember()]
        public String Prenom { get; set; }
        [DataMember()]
        public String Fonction_Libelle { get; set; }
        [DataMember()]
        public String Mail { get; set; }

    }
}