﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nursery_Management_System
{
    class Staff : Human
    {
        public long phoneNumber { get; set; }
        public String email { get; set; }

        public Staff() { }
        public Staff(int _id, String _name) : base(_id , _name)
        {

        }


    }
}
