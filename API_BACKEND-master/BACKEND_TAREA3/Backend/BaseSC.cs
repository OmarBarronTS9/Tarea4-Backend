using BACKEND_TAREA3.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACKEND_TAREA3.Backend
{
    public class BaseSC
    {
        public NorthwindContext DbContext = new NorthwindContext();
    }
}
