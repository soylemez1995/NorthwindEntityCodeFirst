using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind_Entity_Orm.DAL.ORM.Concrete
{
    [Table("Shippers")]
    public class Shipper
    {
        public int ShipperID { get; set; }
        public string CompanyName { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

    }
}
