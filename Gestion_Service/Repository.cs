using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
//using System.Data;
using Gestion_Service.DAL;
using System.Data.Entity;
using Gestion_Service.Models;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
//using System.Web;

namespace Gestion_Service
{

    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private DbSet<TEntity> dbset;
        private ICollection<String> properties;
        private string entityKey = "";
        private entrepriseContext Context;
       
        //private String updateQuery;
        //private MySqlCommand selectCommand;
        //private MySqlCommand updateCommand;
        //private MySqlCommand deleteCommand;
        //private DataTable table;
        public Repository()
        {
            //properties = GetProperties();
            

            this.Context = new entrepriseContext();
            


        }

        public bool Delete(string id)
        {
            return false;

        }




        private ICollection<String> GetProperties()
        {
            
           // Type t = typeof(TEntity);
            ICollection<String> properties = new List<String>();
            foreach (var current in typeof(TEntity).GetProperties())
            {
                //current.GetCustomAttributes(typeof(DbColumnName), false).FirstOrDefault().GetType().ContainsGenericParameters.ToString();
                properties.Add(current.Name);
                if (current.Name.Contains("Id"))
                {
                    entityKey = current.Name;

                }


            }
            return properties;

        }

        public TEntity GetElementById(string id)
        {
            return (TEntity)Convert.ChangeType(Context.employee.Find(id), typeof(TEntity));

        }

        public bool Insert(TEntity obj)
        {
            
                //entrepriseInitiliazer e = new entrepriseInitiliazer();
               // e.InitializeDatabase(Context);
                
                return true;
                
           
        }

        public bool Save()
        {
            try
            {
                Context.SaveChanges();
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public bool Update(TEntity obj)
        {
            try
            {
                Context.Entry(obj).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public ICollection<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Login(string username, string password)
        {
           
            String user = Context.Database.SqlQuery<String>("SELECT Username From user WHERE Username= @user AND Password= @pass", new MySqlParameter("@user", username), new MySqlParameter("@pass", password)).FirstOrDefault<String>();
            
           if (username == user)
            {
                return true;
            }
           else
            {
                return false;
            }
            




            //ICollection<TEntity> IRepository<TEntity>.GetAll()
            //{

            //}
        }
    }
}