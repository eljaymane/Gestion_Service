using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestion_Service.Models;

namespace Gestion_Service
{
    class GestionService : IGestionService
    {
        private Repository<User> userRepository = new Repository<User>();
        public bool Login(string username, string password)
        {
            return userRepository.Login(username, password);


        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            throw new NotImplementedException();
        }

        public bool testDB()
        {
            try
            {
                SqlConnection c = new SqlConnection("Server=tcp:entreprisedb.database.windows.net,1433;Initial Catalog=entreprisedb;Persist Security Info=False;User ID=aymanelj;Password=gasolinaD1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                c.Open();
                return true;
            }
            catch
            {
                return false;

            }

        }
        public bool AddUser(string username, string password, int Id_employee, int Id_fonction) 
        {
            
                User u = new User { Username = username, Password = password, employeeID = Id_employee, functionID = Id_fonction };
                if (userRepository.Insert(u))
            {
                //userRepository.Save();
                return true;
            }
                else
            {
                return false;
            }
               
            
        }
    }
}
