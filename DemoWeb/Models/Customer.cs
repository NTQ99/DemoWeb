using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoWeb.Models
{
    /// <summary>
    /// Dữ liệu khách hàng
    /// </summary>
    /// CreatedBY: NTQ (13/03/2020)
    public class Customer
    {
        #region "Declare/Field"
        public static List<Customer> Customers = new List<Customer>()
        {
            new Customer(){Id = Guid.NewGuid(), Name = "Nguyen Van A", Addr = "HN", Phone = "0123456789"},
            new Customer(){Id = Guid.NewGuid(), Name = "Nguyen Van B", Addr = "HN", Phone = "0123456789"},
            new Customer(){Id = Guid.NewGuid(), Name = "Nguyen Van C", Addr = "HN", Phone = "0123456789"},
            new Customer(){Id = Guid.NewGuid(), Name = "Nguyen Van D", Addr = "HN", Phone = "0123456789"},
        };
        #endregion

        #region "Property"
        /// <summary>
        /// Khoa chinh
        /// </summary>
        public Guid? Id { get; set; }
        /// <summary>
        /// Ten khach hang
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Dia chi
        /// </summary>
        public string Addr { get; set; }
        /// <summary>
        /// Sdt
        /// </summary>
        public string Phone { get; set; }
        #endregion

        #region "Method/Function"
        #endregion
    }
}
