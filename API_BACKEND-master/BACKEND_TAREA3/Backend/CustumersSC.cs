using BACKEND_TAREA3.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BACKEND_TAREA3.Models;

namespace BACKEND_TAREA3.Backend
{
    public class CustumersSC : BaseSC
    {
        public IQueryable<Customer> GetCustumers()
        {
            return DbContext.Customers.AsQueryable();
        }

        public void AddCustumer(CustumerModel newCustomer)
        {
            var newCustumerReg = new Customer();
            newCustumerReg.CompanyName = newCustomer.CompanyName;
            newCustumerReg.ContactName = newCustomer.ContactName;
            newCustumerReg.Phone = newCustomer.Phone;

            DbContext.Customers.Add(newCustumerReg);
            DbContext.SaveChanges();
        }
    }
}
