using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using InvoiceSystem.Models;

namespace InvoiceSystem.dal
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("DefaultConnection") { }

        public DbSet<Student> Students { get; set; }

    }
}