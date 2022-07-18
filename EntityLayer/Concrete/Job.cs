﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Job
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public List<Customer> Customers { get; set; }
    }
}
