using Microsoft.EntityFrameworkCore;
using RiderDemo.Models;

namespace RiderDemo.Data
{
    public class ItemsContext :DbContext
    
    {
        public ItemsContext(DbContextOptions<ItemsContext> options) : base(options)
        {
            
        }  
        
        public DbSet<Item> Items { get; set; }
    }
}