﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication5.Models
{
    public abstract class Person
    {
        public int PersonId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
