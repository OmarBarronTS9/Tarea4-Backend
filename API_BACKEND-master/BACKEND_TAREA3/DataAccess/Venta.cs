using System;
using System.Collections.Generic;

#nullable disable

namespace BACKEND_TAREA3.DataAccess
{
    public partial class Venta
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public int? Ventas { get; set; }
    }
}
