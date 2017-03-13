namespace Comp1004_W2017_Lesson9
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class NamesContext : DbContext  //DbContext is the Super Class
    {
        public NamesContext()
            : base("name=NamesContext")
        {
        }

        public virtual DbSet<User> Users { get; set; } //Table in the DB

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
