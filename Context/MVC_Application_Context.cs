using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MVC_Application.Models;

namespace MVC_Application.Context
{
    public class MVC_Application_Context : DbContext
    {
    public MVC_Application_Context() : base ("name=MVC Project")
        {
        }

    public DbSet<User> User { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder) //modificacion de metodos//
    {
            modelBuilder.Entity<User>()
             .ToTable("Usuarios")
            .HasKey(p => p.User_ID);
            modelBuilder.Entity<User>()  //llamamos tabla y ponesmos atributos//
                .Property(p => p.User_ID)
                .IsRequired()
            .HasColumnName("User_ID");

            modelBuilder.Entity<User>()
                .Property(p => p.Username)
                .IsRequired()
                .HasColumnName("Username")
            .HasMaxLength(50);

            modelBuilder.Entity<User>()
                .Property(p => p.Password)
                .IsRequired()
                .HasColumnName("Password")
                .HasMaxLength(50);

            modelBuilder.Entity<User>()
                .Property(p => p.Creation_Date)
                .IsRequired()
                .HasColumnName("Creation_Date");

            modelBuilder.Entity<User>()
                .Property(p => p.HashKey)
                .IsRequired()
                .HasColumnName("HashKey");

            modelBuilder.Entity<User>()
                .Property(p => p.HashIV)
                .IsRequired()
                .HasColumnName("HashIV");


            base.OnModelCreating(modelBuilder);
    }
}

}