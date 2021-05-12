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
        public Employee GetEmployeeById(int id)
        {
            var employee = GetEmployees().Where(x => x.EmployeeId == id).FirstOrDefault();

            if (employee == null)
                throw new Exception("El usuario con el id solicitado, no existe");

            return employee;
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
        public void DeleteEmployeeById(int id)
        {
            var currentEmployee = GetEmployeeById(id);

            try
            {
                dbContext.Employees.Remove(currentEmployee);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo guardar el cambio en base de datos: "
                    + ex.Message + ". " + ex.InnerException != null ? ex.InnerException.Message : "");
            }
        }
        public void DeleteEmployee(EmployeeModel dEmployee)
        {
            var currentEmployee = DbContext.Employees.Where(W => W.EmployeeId == dEmployee.EmployeesId).FirstOrDefault();
            DbContext.Employees.Remove(currentEmployee);
            DbContext.SaveChanges();
        }

    }
}
