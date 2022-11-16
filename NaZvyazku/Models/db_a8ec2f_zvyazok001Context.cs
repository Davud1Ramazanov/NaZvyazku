using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NaZvyazku.Models
{
    public partial class db_a8ec2f_zvyazok001Context : DbContext
    {
        public db_a8ec2f_zvyazok001Context()
        {
        }

        public db_a8ec2f_zvyazok001Context(DbContextOptions<db_a8ec2f_zvyazok001Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Authorization> Authorizations { get; set; }
        public virtual DbSet<CreditCard> CreditCards { get; set; }
        public virtual DbSet<Info> Infos { get; set; }
        public virtual DbSet<PersonalArea> PersonalAreas { get; set; }
        public virtual DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Subscription> Subscriptions { get; set; }
        public virtual DbSet<Tariff> Tariffs { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=SQL8003.site4now.net;Initial Catalog=db_a8ec2f_zvyazok001;User Id=db_a8ec2f_zvyazok001_admin;Password=qRV9njR@m9KnjvG;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Authorization>(entity =>
            {
                entity.HasKey(e => e.AuthorizationId)
                    .HasName("PK__Authoriz__09019C379427AB51");

                entity.ToTable("Authorization");

                entity.Property(e => e.AuthorizationId)
                    .ValueGeneratedNever()
                    .HasColumnName("AuthorizationID");

                entity.Property(e => e.CreditCardId).HasColumnName("CreditCardID");

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Login)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumberId).HasColumnName("PhoneNumberID");

                entity.HasOne(d => d.CreditCard)
                    .WithMany(p => p.Authorizations)
                    .HasForeignKey(d => d.CreditCardId)
                    .HasConstraintName("FK__Authoriza__Credi__5AEE82B9");

                entity.HasOne(d => d.PhoneNumber)
                    .WithMany(p => p.Authorizations)
                    .HasForeignKey(d => d.PhoneNumberId)
                    .HasConstraintName("FK__Authoriza__Phone__59FA5E80");
            });

            modelBuilder.Entity<CreditCard>(entity =>
            {
                entity.ToTable("CreditCard");

                entity.Property(e => e.CreditCardId)
                    .ValueGeneratedNever()
                    .HasColumnName("CreditCardID");

                entity.Property(e => e.Cvv).HasColumnName("CVV");
            });

            modelBuilder.Entity<Info>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__INFO__1788CCAC4DB20A25");

                entity.ToTable("INFO");

                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("UserID");

                entity.Property(e => e.DateReg).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Login)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Subscription)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tariff)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TARIFF");
            });

            modelBuilder.Entity<PersonalArea>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Personal__1788CCAC9C9AA6FC");

                entity.ToTable("PersonalArea");

                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("UserID");

                entity.Property(e => e.Avatar).HasColumnType("image");

                entity.Property(e => e.DateReg).HasColumnType("datetime");

                entity.Property(e => e.FullName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");

                entity.Property(e => e.TariffId).HasColumnName("TariffID");
            });

            modelBuilder.Entity<PhoneNumber>(entity =>
            {
                entity.ToTable("PhoneNumber");

                entity.Property(e => e.PhoneNumberId)
                    .ValueGeneratedNever()
                    .HasColumnName("PhoneNumberID");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.RolesId)
                    .HasName("PK__Role__C4B27820267AFAAF");

                entity.ToTable("Role");

                entity.Property(e => e.RolesId)
                    .ValueGeneratedNever()
                    .HasColumnName("RolesID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Roles)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Subscription>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Subscription");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");
            });

            modelBuilder.Entity<Tariff>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TARIFF");

                entity.Property(e => e.Device)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.TariffId).HasColumnName("TariffID");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__USER__1788CCAC85EA8372");

                entity.ToTable("USER");

                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("UserID");

                entity.Property(e => e.AuthorizationId).HasColumnName("AuthorizationID");

                entity.Property(e => e.DateReg).HasColumnType("datetime");

                entity.Property(e => e.FullName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.Authorization)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.AuthorizationId)
                    .HasConstraintName("FK__USER__Authorizat__5FB337D6");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK__USER__RoleID__5EBF139D");

                entity.HasOne(d => d.UserNavigation)
                    .WithOne(p => p.User)
                    .HasForeignKey<User>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__USER__UserID__60A75C0F");

                entity.HasOne(d => d.User1)
                    .WithOne(p => p.User)
                    .HasForeignKey<User>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__USER__UserID__5DCAEF64");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
