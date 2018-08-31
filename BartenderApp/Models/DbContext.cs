using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using BartenderApp.Models;


namespace BartenderApp.Models
{
    public class DrinkContext : DbContext
    {
        public DrinkContext(DbContextOptions<DrinkContext> options)
            :base (options)
        {

        }

        public DbSet<Order> Drinks { get; set; } //Table name: Order, Drinks is what the information in the table is called. 
        
        public DbSet<BarDesserts> Desserts { get; set; }

    }
}
