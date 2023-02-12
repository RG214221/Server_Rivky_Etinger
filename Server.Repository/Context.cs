﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.Repository.Entities;
using Repository.Interfaces;

namespace Server.Repository
{
    public class Context : DbContext, IDataSource
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = DESKTOP-B5S1T71; Initial Catalog = Practicum_Users_DB; Integrated Security = True; TrustServerCertificate=True ");
            optionsBuilder.UseLazyLoadingProxies(true).UseSqlServer(@"Data Source = DESKTOP-B5S1T71; Initial Catalog = Practicum_Users_DB; Integrated Security = True; TrustServerCertificate=True ");
        }
    }
}