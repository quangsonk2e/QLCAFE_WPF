namespace QLCAFE_WPF.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QLCafe : DbContext
    {
        public QLCafe()
            : base("name=QLCafe")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<BillInfo> BillInfoes { get; set; }
        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<FoodCategory> FoodCategories { get; set; }
        public virtual DbSet<Tablefood> Tablefoods { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bill>()
                .HasMany(e => e.BillInfoes)
                .WithOptional(e => e.Bill)
                .HasForeignKey(e => e.idBill);

            modelBuilder.Entity<Food>()
                .Property(e => e.price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Food>()
                .HasMany(e => e.BillInfoes)
                .WithOptional(e => e.Food)
                .HasForeignKey(e => e.idFood);

            modelBuilder.Entity<Tablefood>()
                .HasMany(e => e.Bills)
                .WithOptional(e => e.Tablefood)
                .HasForeignKey(e => e.idTable);
        }
    }
}
