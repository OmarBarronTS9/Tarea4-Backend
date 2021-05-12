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
        public Customer GetCustomerById(string id)
        {
            var customer = GetCustumers().FirstOrDefault(f => f.CustomerId == id);
            if (customer == null)
                throw new Exception("No existe el cliente con el id proporcionado");

            return customer;
        }

        public void AddCustomer(CustumerModel newCustomer)
        {

            // Formato muy parecido a JSON, notación de objetos
            var newCustomerRegister = new Customer()
            {
                CompanyName = newCustomer.CompanyName,
                ContactName = newCustomer.ContactName,
                Phone = newCustomer.Phone,
                CustomerId = newCustomer.CompanyName.Substring(0, 1) + newCustomer.Phone.Substring(0, 3)
            };

            DbContext.Customers.Add(newCustomerRegister);
            DbContext.SaveChanges();


        }
        public void DeleteCustomerById(string id)
        {

            var currentCustomer = GetCustomerById(id);
            DbContext.Customers.Remove(currentCustomer);
            DbContext.SaveChanges();
        }
    }

}
