﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace _5951071040_VoVanKha_CRUD.Models
{
    public class Employee
    {
        public int Sr_no { get; set; } = 0;
        public String Emp_name { get; set; } = "";
        public String City { get; set; } = "";

        public String State { get; set; } = "";
        public String Country { get; set; } = "";
        public String Department { get; set; } = "";

        public String flag { get; set; } = "";  

    }
}
