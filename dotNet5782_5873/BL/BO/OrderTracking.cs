﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    internal class OrderTracking
    {
        /// <summary>
        /// OrderTracking ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// OrderTracking status
        /// </summary>
        public OrderStatus Status { get; set; }
    }
}
