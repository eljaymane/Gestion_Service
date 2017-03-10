using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gestion_Service
{
    public interface IRepository<TEntity> where TEntity:class
    {
        
        ICollection<TEntity> GetAll();
        TEntity GetElementById(string id);
        bool Login(string username,string password);
        bool Insert(TEntity obj);
        bool Update(TEntity obj);
        bool Delete(string id);
        bool Save();

    }
}