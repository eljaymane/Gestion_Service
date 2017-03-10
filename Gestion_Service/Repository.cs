using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Web;

namespace Gestion_Service
{

    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {

        private ICollection<String> properties;
        private string entityKey = "";
        private context Context;
        private DataTable table;
        private String selectQuery;
        private String updateQuery;
        private String deleteQuery;
        private MySqlCommand selectCommand;
        private MySqlCommand updateCommand;
        private MySqlCommand deleteCommand;
        public Repository(MySqlConnection existingConnection)
        {
            properties = GetProperties();
            this.Context = new context(existingConnection);
            StringBuilder builder;
            #region selectQuery
            builder = new StringBuilder();
            builder.Append("SELECT");
            Int32 i = 1;
            foreach (var current in properties)
            {
                i += 1;
                if (i < properties.Count())
                {
                    builder.Append(current + ",");
                }
                else
                {
                    builder.Append(current);
                }

            }
            builder.Append(" FROM " + typeof(TEntity).ToString());
            selectQuery = builder.ToString();
            #endregion
            #region updateQuery
            builder = new StringBuilder();
            builder.Append("UPDATE ");
            i = 1;
            foreach (var current in properties)
            {
                if (i < properties.Count())
                {
                    builder.Append(current + ",");
                }
                else
                {
                    builder.Append(current);
                }

            }
            builder.Append(" SET ");
            #endregion
            #region deleteQuery
            deleteQuery = "DELETE FROM " + typeof(TEntity).ToString() + "WHERE ";
            #endregion


        }

        public bool Delete(string id)
        {
            bool result = false;
            try
            {
                if (entityKey.Contains("Id"))
                {
                    Context.Database.ExecuteSqlCommand(deleteQuery + "WHERE " + entityKey + "='@id'", new MySqlParameter("@id", id));
                    result = true;
                }
            }
            catch (Exception e)
            {

            }
            return result;

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
            return false;
        }

        public bool Save()
        {
            try
            {
                Context.SaveChanges();
                return true;
            }
            catch (Exception e)
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
            catch (Exception e)
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
            // User u = Context.User.Find("a04");
            // String user = Context.Database.SqlQuery<String>("SELECT Username From user WHERE Username='@user' AND Password='@pass';", new MySqlParameter("@user", username), new MySqlParameter("@pass", password)).Single();
            String user = Context.Database.SqlQuery<String>("SELECT 'Username' FROM `user` WHERE Username='aymanelj' AND Password='aymanelj'").FirstOrDefault<String>();
            
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