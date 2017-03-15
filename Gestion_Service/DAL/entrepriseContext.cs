using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Common;
using System.Linq;
using System.Web;
using Gestion_Service.Models;


namespace Gestion_Service.DAL
{
    
    public class entrepriseContext : DbContext 

    {
        public DbSet<Order> commande { get; set; }
        public DbSet<Employee> employee { get; set; }
        public DbSet<User> user { get; set; }
        //public DbSet<Provider> fournisseur { get; set; }
        public DbSet<Resource> resource { get; set; }
        public DbSet<Group> group { get; set; }
        public DbSet<Function> function { get; set; }
        public DbSet<Provider> provider { get; set; }
        //public DbSet dbset;
        
        public entrepriseContext() 
            : base("name=entrepriseContext")
        {
            Database.SetInitializer<entrepriseContext>(new entrepriseInitiliazer());

        }
        //public entrepriseContext(DbSet d) :base("entrepriseContext")
        //{
            
        //}
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}