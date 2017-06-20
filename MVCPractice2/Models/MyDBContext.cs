using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCPractice2.Models
{
    public class MyDBContext : DbContext
    {

        public MyDBContext() : base("MVCPractice2")
        {

        }

        public DbSet<Tour> Tours { get; set; }

    }

    
}