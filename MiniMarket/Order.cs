﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMarket
{
    internal class Order
    {
        public int Id { get; set; }

        public List<Product> Products { get; set; }

        public User Buyer { get; set; }

        public Cashier Seller { get; set; }
    }
}
