namespace Assignment1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ParentThing : DbContext
    {
        public ParentThing()
            : base("name=ParentThing")
        {
        }

        public virtual DbSet<ChildTable> ChildTables { get; set; }
        public virtual DbSet<ParentTable> ParentTables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChildTable>()
                .Property(e => e.thing1)
                .IsFixedLength();

            modelBuilder.Entity<ChildTable>()
                .Property(e => e.thing2)
                .IsFixedLength();

            modelBuilder.Entity<ParentTable>()
                .Property(e => e.otherthing1)
                .IsFixedLength();

            modelBuilder.Entity<ParentTable>()
                .Property(e => e.otherthing2)
                .IsFixedLength();

            modelBuilder.Entity<ParentTable>()
                .Property(e => e.otherthing3)
                .IsFixedLength();
        }
    }
}
