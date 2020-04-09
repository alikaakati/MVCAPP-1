using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Customers
    {
        public int customerID { get; set; }
        public string name { get; set; }
 
        public Customers(int customerID, string name)
        {
            this.customerID = customerID;
            this.name = name;
        }
    }
}