﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Comp_Shop
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class shopEntities : DbContext
    {
        public shopEntities()
            : base("name=shopEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<ItemDet> ItemDet { get; set; }
        public virtual DbSet<ItemPer> ItemPer { get; set; }
    }
}
