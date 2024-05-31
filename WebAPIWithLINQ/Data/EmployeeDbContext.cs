﻿using Microsoft.EntityFrameworkCore;
using WebAPIWithLINQ.Model;

namespace WebAPIWithLINQ.Data
{
    public class EmployeeDbContext:DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }  

        public DbSet<Department> Departments { get; set; }  

    }
}
