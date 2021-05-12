using BACKEND_TAREA3.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BACKEND_TAREA3.Models;

namespace BACKEND_TAREA3.Backend
{
    public class EmployeesSC : BaseSC
    {
        public IQueryable<Employee> GetEmployees()
        {
            return DbContext.Employees.AsQueryable();
        }

        public void AddEmployee(EmployeeModel newEmployee)
        {
            var newEmployeeReg = new Employee();
            newEmployeeReg.LastName = newEmployee.LastName;
            newEmployeeReg.FirstName = newEmployee.FirstName;
            newEmployeeReg.HomePhone = newEmployee.Phone;

            DbContext.Employees.Add(newEmployeeReg);
            DbContext.SaveChanges();
        }

        public void DeleteEmployee(EmployeeModel dEmployee)
        {
            var currentEmployee = DbContext.Employees.Where(W => W.EmployeeId == dEmployee.EmployeesId).FirstOrDefault();
            DbContext.Employees.Remove(currentEmployee);
            DbContext.SaveChanges();
        }

    }
}
