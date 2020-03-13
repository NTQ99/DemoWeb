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
        private int _id;
        private string _name;
        private string _addr;
        private string _phone;
        #endregion

        #region "Property"
        /// <summary>
        /// Khởi tạo dữ liệu khách hàng
        /// </summary>
        /// <param name="name"></param>
        /// <param name="addr"></param>
        /// <param name="phone"></param>
        /// CreatedBy: NTQ (13/03/2020)
        public Customer(int id, string name, string addr, string phone)
        {
            _id = id;
            _name = name;
            _addr = addr;
            _phone = phone;
        }
        #endregion

        #region "Method/Function"
        public int getId()
        {
            return _id;
        }
        public string getName()
        {
            return _name;
        }
        public string getAdd()
        {
            return _addr;
        }
        public string getPhone()
        {
            return _phone;
        }
        #endregion
    }

    var customers = new List<Customer>() { Customer(1,)}
}
