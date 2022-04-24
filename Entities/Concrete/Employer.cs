﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Employer : User, IEntity
    {
        public int EmployerId { get; set; }
        
        public string CompanyName { get; set; }
        
        public string PhoneNumber { get; set; }

        public string WebAddress { get; set; }
    }
}