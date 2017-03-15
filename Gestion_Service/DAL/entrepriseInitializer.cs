using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestion_Service.Models;

namespace Gestion_Service.DAL
{
    public class entrepriseInitiliazer : System.Data.Entity.DropCreateDatabaseIfModelChanges<entrepriseContext>
    {
        protected override void Seed(entrepriseContext context)
        {
            Group g = new Group { groupID = 0001, groupTitle = "Administration" };
            Function f = new Function { functionID = 0001, functionTitle = "Directeur Générale", privilege = privilege.superAccess, groupID = 0 };
            Employee e = new Employee { employeeFirstName = "Aymane", employeeAddress = "11 rue moussa ibn noussair apt 3", employeeMail = "eljahrani.aymane@outlook.fr", employeeName = "El Jahrani", employeePhone = "+212641999594",employeeEnrollementDate = DateTime.Parse(DateTime.Now.ToString()) };
            Provider p = new Provider { providerID = 0000, providerName = "test", providerMail = "test", providerPhone = "test" };
            Resource r = new Resource { resourceID = 000, resourcePrice = 120, resourceQuantity = 100, providerID = 0000 };
            User u = new User { Username = "Aymanelj", Password = "Aymanelj", functionID = 0001 };
            ////context.group.Add(g);
            ////context.SaveChanges();
            ////context.function.Add(f);
            ////context.SaveChanges();
            ////context.employee.Add(e);
            ////context.SaveChanges();
            ////context.provider.Add(p);
            ////context.SaveChanges();
            ////context.resource.Add(r);
            ////context.SaveChanges();
            context.user.Add(u);
            context.SaveChanges();

        }
    }
}
