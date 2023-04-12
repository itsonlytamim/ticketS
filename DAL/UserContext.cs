using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserContext : DbContext
    {
         public DbSet<User> Users { get; set; }
         public DbSet<Tickets> Tickets { get; set; }
         public DbSet<OrderDetails> orderDetails { get; set; }
            
        
    }
}
