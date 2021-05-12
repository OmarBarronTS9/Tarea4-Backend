using System;
using System.Collections.Generic;

#nullable disable

namespace BACKEND_TAREA3.DataAccess
{
    public partial class Detalle
    {
        public int OrderId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }
    }
}
