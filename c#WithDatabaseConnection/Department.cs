﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class Department
    {
        public int Id{ get; set; }
        public string? Name { get; set; }
        public string? Location { get; set; }


        public Department() { }
        public Department(int Id,string Name,string Location) {
               this.Id = Id;
            this.Name = Name;
                this.Location = Location;
        
        }
    }
}
