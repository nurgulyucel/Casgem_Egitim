﻿using CasgemEgitim.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemEgitim.DataAccessLayer.Concrete
{
    public class Context :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Bugra
            optionsBuilder.UseSqlServer(@"Data Source=BUDOTEKNO\SQLEXPRESS; initial catalog=CasgemEgitimProjesiDb; integrated security=true");


            //Nurgül
            //optionsBuilder.UseSqlServer("Data Source=; initial catalog=CasgemEgitimProjesiDb; integrated security=true");


            //Selvi
            //optionsBuilder.UseSqlServer("Data Source=; initial catalog=CasgemEgitimProjesiDb; integrated security=true");

        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Contact> Contacts{ get; set; }
        public DbSet<Teacher> Teachers { get; set; }




    }
}
