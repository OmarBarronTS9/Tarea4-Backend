using BACKEND_TAREA3.DataAccess;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using BACKEND_TAREA3.Backend;

namespace BACKEND_TAREA3
{
    class Program
    {

        //SELECT * FROM Employees
        public static void Employee()
        {
            var EmployeeQry = new EmployeesSC().GetEmployees();
            var output = EmployeeQry.ToList();


        }

        //SELECT ProductID, ProductName, UnitPrice FROM Products
        //Where CategoryID = ID
        public static void Product(int ID)
        {
            var ProductQry = new ProductsSC().GetProduct().Select(s => new
             {
                 s.ProductId,
                 s.ProductName,
                 s.UnitPrice,
                 s.CategoryId
             }).Where(w => w.CategoryId == ID);

             var output = ProductQry.ToList();

        }

        //SELECT CompanyName, ContactName, Phone FROM Custumer
        public static void Custumer()
        {
            var CustumerQry = new CustumersSC().GetCustumers().Select(S => new
            {
                S.CompanyName,
                S.ContactName,
                S.Phone
            });

            var output = CustumerQry.ToList();
        }

        // UPDATE PRODUCTS SET UnitPrice = '10', UnitsInStock = '100' WHERE ProductID = '5'
        public static void UProcuts(int ID, decimal Price, short UnitInStock)
        {
            new ProductsSC().UpdateProduct(ID, Price, UnitInStock);

        }

        static void Main(string[] args)
        {
            // Employee();
            //Product(4);
            //Custumer();
            //Procuts(10, 10, 100);
            
            
        }
    }
}
