using Intuit.Ipp.Data;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Context
{
    public class FundooContext : DbContext
    {

        public FundooContext(DbContextOptions options)
           : base(options)
        {
        }
        public DbSet<UserEntity> UserTable { get; set; }
    }
}
    

    

