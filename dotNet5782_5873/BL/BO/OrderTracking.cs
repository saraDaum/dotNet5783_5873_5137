using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    /// <summary>
    /// OrderTracking class (a logical entity)
    /// </summary>
    public class OrderTracking
    {
        /// <summary>
        /// OrderTracking ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// OrderTracking status
        /// </summary>
        public  OrderStatus Status  { get; set; }

        /// <summary>
        /// Print all OrderItem's details
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $@"
    Order tracking details:\n
    ID :{ID}
    Status:{Status}";
    }


}
