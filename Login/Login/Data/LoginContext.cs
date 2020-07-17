﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Login.Models;

namespace Login.People
{
    public class LoginContext : DbContext
    {
        public LoginContext (DbContextOptions<LoginContext> options)
            : base(options)
        {
        }

        public DbSet<Login.Models.Person> Person { get; set; }
    }
}
