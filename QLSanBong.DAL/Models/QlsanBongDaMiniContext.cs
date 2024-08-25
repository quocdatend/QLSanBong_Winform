using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace QLSanBong.DAL.Models;

public partial class QlsanBongDaMiniContext : DbContext
{
    public QlsanBongDaMiniContext()
    {
    }

    public QlsanBongDaMiniContext(DbContextOptions<QlsanBongDaMiniContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<AdminRole> AdminRoles { get; set; }

    public virtual DbSet<FoodDrink> FoodDrinks { get; set; }

    public virtual DbSet<OrderFoodDrink> OrderFoodDrinks { get; set; }

    public virtual DbSet<OrderFoodDrinkDetail> OrderFoodDrinkDetails { get; set; }

    public virtual DbSet<OrderPitch> OrderPitches { get; set; }

    public virtual DbSet<PaymentHistory> PaymentHistories { get; set; }

    public virtual DbSet<Pitch> Pitches { get; set; }

    public virtual DbSet<PricePerHour> PricePerHours { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<TypePitch> TypePitches { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=QUOCDAT\\SQLEXPRESS;Initial Catalog=QLSanBongDaMini;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>(entity =>
        {
            entity.ToTable("ADMIN");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .HasColumnName("NAME");
            entity.Property(e => e.Pass)
                .HasMaxLength(64)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PASS");
        });

        modelBuilder.Entity<AdminRole>(entity =>
        {
            entity.ToTable("ADMIN_ROLE");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AdminId).HasColumnName("ADMIN_ID");
            entity.Property(e => e.RoleId).HasColumnName("ROLE_ID");

            entity.HasOne(d => d.Admin).WithMany(p => p.AdminRoles)
                .HasForeignKey(d => d.AdminId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ADMIN_ROLE_ADMIN");

            entity.HasOne(d => d.Role).WithMany(p => p.AdminRoles)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ADMIN_ROLE_ROLE");
        });

        modelBuilder.Entity<FoodDrink>(entity =>
        {
            entity.ToTable("FOOD_DRINK");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Count).HasColumnName("COUNT");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("NAME");
            entity.Property(e => e.Price).HasColumnName("PRICE");
            entity.Property(e => e.UrlImg)
                .HasMaxLength(255)
                .HasColumnName("URL_IMG");
        });

        modelBuilder.Entity<OrderFoodDrink>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ORDER_FOOD_DRINK_DETAIL");

            entity.ToTable("ORDER_FOOD_DRINK");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Time)
                .HasColumnType("datetime")
                .HasColumnName("TIME");
            entity.Property(e => e.UserId).HasColumnName("USER_ID");

            entity.HasOne(d => d.User).WithMany(p => p.OrderFoodDrinks)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ORDER_FOOD_DRINK_DETAIL_USERS");
        });

        modelBuilder.Entity<OrderFoodDrinkDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ORDER_FOOD_DRINK_DETAIL_1");

            entity.ToTable("ORDER_FOOD_DRINK_DETAIL");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Count).HasColumnName("COUNT");
            entity.Property(e => e.FoodDrinkId).HasColumnName("FOOD_DRINK_ID");
            entity.Property(e => e.OrderFoodDrinkId).HasColumnName("ORDER_FOOD_DRINK_ID");
            entity.Property(e => e.Price).HasColumnName("PRICE");

            entity.HasOne(d => d.FoodDrink).WithMany(p => p.OrderFoodDrinkDetails)
                .HasForeignKey(d => d.FoodDrinkId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ORDER_FOOD_DRINK_DETAIL_FOOD_DRINK1");

            entity.HasOne(d => d.OrderFoodDrink).WithMany(p => p.OrderFoodDrinkDetails)
                .HasForeignKey(d => d.OrderFoodDrinkId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ORDER_FOOD_DRINK_DETAIL_ORDER_FOOD_DRINK");
        });

        modelBuilder.Entity<OrderPitch>(entity =>
        {
            entity.ToTable("ORDER_PITCH");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IsCancel).HasColumnName("IS_CANCEL");
            entity.Property(e => e.IsCheck)
                .HasDefaultValue(false)
                .HasColumnName("IS_CHECK");
            entity.Property(e => e.IsPay).HasColumnName("IS_PAY");
            entity.Property(e => e.PitchId).HasColumnName("PITCH_ID");
            entity.Property(e => e.Price).HasColumnName("PRICE");
            entity.Property(e => e.PricePerHourId).HasColumnName("PRICE_PER_HOUR_ID");
            entity.Property(e => e.TimeEnd)
                .HasColumnType("datetime")
                .HasColumnName("TIME_END");
            entity.Property(e => e.TimeStart)
                .HasColumnType("datetime")
                .HasColumnName("TIME_START");
            entity.Property(e => e.UserId).HasColumnName("USER_ID");

            entity.HasOne(d => d.Pitch).WithMany(p => p.OrderPitches)
                .HasForeignKey(d => d.PitchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ORDER_PITCH_PITCH");

            entity.HasOne(d => d.PricePerHour).WithMany(p => p.OrderPitches)
                .HasForeignKey(d => d.PricePerHourId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ORDER_PITCH_PRICE_PER_HOUR");

            entity.HasOne(d => d.User).WithMany(p => p.OrderPitches)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ORDER_PITCH_USERS");
        });

        modelBuilder.Entity<PaymentHistory>(entity =>
        {
            entity.ToTable("PAYMENT_HISTORY");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IsCheck).HasColumnName("IS_CHECK");
            entity.Property(e => e.OrderFoodDrinkId).HasColumnName("ORDER_FOOD_DRINK_ID");
            entity.Property(e => e.OrderPitchId).HasColumnName("ORDER_PITCH_ID");
            entity.Property(e => e.Price).HasColumnName("PRICE");
            entity.Property(e => e.Time)
                .HasColumnType("datetime")
                .HasColumnName("TIME");
            entity.Property(e => e.UserId).HasColumnName("USER_ID");

            entity.HasOne(d => d.OrderFoodDrink).WithMany(p => p.PaymentHistories)
                .HasForeignKey(d => d.OrderFoodDrinkId)
                .HasConstraintName("FK_PAYMENT_HISTORY_ORDER_FOOD_DRINK");

            entity.HasOne(d => d.OrderPitch).WithMany(p => p.PaymentHistories)
                .HasForeignKey(d => d.OrderPitchId)
                .HasConstraintName("FK_PAYMENT_HISTORY_ORDER_PITCH");

            entity.HasOne(d => d.User).WithMany(p => p.PaymentHistories)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PAYMENT_HISTORY_USERS");
        });

        modelBuilder.Entity<Pitch>(entity =>
        {
            entity.ToTable("PITCH");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("NAME");
            entity.Property(e => e.TypePitchId).HasColumnName("TYPE_PITCH_ID");

            entity.HasOne(d => d.TypePitch).WithMany(p => p.Pitches)
                .HasForeignKey(d => d.TypePitchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PITCH_TYPE_PITCH");
        });

        modelBuilder.Entity<PricePerHour>(entity =>
        {
            entity.ToTable("PRICE_PER_HOUR");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Price).HasColumnName("PRICE");
            entity.Property(e => e.TimeEnd).HasColumnName("TIME_END");
            entity.Property(e => e.TimeStart).HasColumnName("TIME_START");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.ToTable("ROLE");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<TypePitch>(entity =>
        {
            entity.ToTable("TYPE_PITCH");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(10)
                .HasColumnName("NAME");
            entity.Property(e => e.Price).HasColumnName("PRICE");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("USERS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Pass)
                .HasMaxLength(64)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PASS");
            entity.Property(e => e.Phone)
                .HasMaxLength(11)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PHONE");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("USERNAME");
        });

        modelBuilder.Entity<UserRole>(entity =>
        {
            entity.ToTable("USER_ROLE");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.RoleId).HasColumnName("ROLE_ID");
            entity.Property(e => e.UserId).HasColumnName("USER_ID");

            entity.HasOne(d => d.Role).WithMany(p => p.UserRoles)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USER_ROLE_ROLE");

            entity.HasOne(d => d.User).WithMany(p => p.UserRoles)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USER_ROLE_USERS");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
