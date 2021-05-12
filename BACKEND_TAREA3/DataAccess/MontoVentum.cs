using System;
using System.Collections.Generic;

#nullable disable

namespace BACKEND_TAREA3.DataAccess
{
    public partial class MontoVentum
    {
        public int OrderId { get; set; }
        public string CompanyName { get; set; }
        public double? Suma { get; set; }
        public DateTime? OrderDate { get; set; }
    }
}
