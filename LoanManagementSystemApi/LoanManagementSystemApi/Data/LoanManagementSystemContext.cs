using LoanManagementSystemApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanManagementSystemApi.Data
{
    public class LoanManagementSystemContext:DbContext
    {
        public LoanManagementSystemContext(DbContextOptions options):base(options)
        {
                
        }
        public DbSet<Furniture> Furnitures { get; set; }
        
    }
}
