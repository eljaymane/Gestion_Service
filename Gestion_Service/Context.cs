using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Common;
using System.Linq;
using System.Web;
using MySql.Data.Entity;

namespace Gestion_Service
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class context : DbContext

    {
        public DbSet<Employee> employee { get; set; }
        public DbSet<User> User { get; set; }
        public context(DbConnection existingConnection,bool contextOwnsConnection) 
            : base(existingConnection,contextOwnsConnection)
        {
            

        }
    }
}