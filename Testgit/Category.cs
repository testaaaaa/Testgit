﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testgit
{
    class Category
    {

        public int Id { get; set; }

        public String Name { get; set; }

        public List<Customer> Customers { get; set; }
    }
}
