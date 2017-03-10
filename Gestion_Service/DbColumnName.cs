using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gestion_Service
{
    public class DbColumnName : Attribute
    {
        public string name { get { return name; } set { name = value; } }


    }
}