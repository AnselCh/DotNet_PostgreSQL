using Microsoft.EntityFrameworkCore;
using Postgresql_API.Models;

namespace Postgresql_API.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public DbSet<PreOrder> PreOrders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PreOrder>()
                .ToTable("preorder_list") // 指定資料表名稱
                .HasKey(p => p.Id); // 配置主鍵

            base.OnModelCreating(modelBuilder);
        }
    }
}
