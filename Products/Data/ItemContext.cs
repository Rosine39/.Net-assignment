using Microsoft.EntityFrameworkCore;

namespace Products.Data
{
    public class ItemContext: DbContext
    {
        public ItemContext(DbContextOptions<ItemContext> options): base(options){}
        public DbSet<Models.Items> Items { get; set; }
    }
}