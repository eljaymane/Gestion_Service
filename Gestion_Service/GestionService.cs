using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Service
{
    class GestionService : IGestionService
    {
        private Repository<User> userRepository = new Repository<User>(new MySqlConnection("server=localhost;port=3306;database=entreprisedb;user='root';password=''"));
        public bool Login(string username,string password)
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
                MySqlConnection c = new MySqlConnection("server=localhost;port=3306;database=entreprisedb;user='root';password=''");
                c.Open();
                return true;
            }
            catch (Exception e)
            {
                return false;
            
            }
        }
    }
}
