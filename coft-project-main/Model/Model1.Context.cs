//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Coft_Project.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CoftDatabaseEntities2 : DbContext
    {
        public CoftDatabaseEntities2()
            : base("name=CoftDatabaseEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<foodImg> foodImgs { get; set; }
        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<ingredientImg> ingredientImgs { get; set; }
        public virtual DbSet<Ingredient> Ingredients { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
