﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURDTASK.Model
{
    internal class Order
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public DateTime createdAt { get; set; }
    }
}

