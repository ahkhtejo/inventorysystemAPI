using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace inventory_system_API.Models;

public partial class InventorySystemContext : DbContext
{
    public InventorySystemContext()
    {
    }

    public InventorySystemContext(DbContextOptions<InventorySystemContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CategoriesOfItem> CategoriesOfItems { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<ItemsTransaction> ItemsTransactions { get; set; }

    public virtual DbSet<Transaction> Transactions { get; set; }

    public virtual DbSet<TransactionsType> TransactionsTypes { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UsersType> UsersTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=inventory system;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CategoriesOfItem>(entity =>
        {
            entity.ToTable("Categories of Items");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CategoryId).HasColumnName("Category ID");
            entity.Property(e => e.ItemId).HasColumnName("Item ID");

            entity.HasOne(d => d.Category).WithMany(p => p.CategoriesOfItems)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Categories ID");

            entity.HasOne(d => d.Item).WithMany(p => p.CategoriesOfItems)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Item ID");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Item>(entity =>
        {
            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ItemsTransaction>(entity =>
        {
            entity.ToTable("Items Transactions");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ItemsId).HasColumnName("Items ID");
            entity.Property(e => e.TransactionsId).HasColumnName("Transactions ID");

            entity.HasOne(d => d.Items).WithMany(p => p.ItemsTransactions)
                .HasForeignKey(d => d.ItemsId)
                .HasConstraintName("FK__Items Tra__Items__4CA06362");

            entity.HasOne(d => d.Transactions).WithMany(p => p.ItemsTransactions)
                .HasForeignKey(d => d.TransactionsId)
                .HasConstraintName("FK__Items Tra__Trans__534D60F1");
        });

        modelBuilder.Entity<Transaction>(entity =>
        {
            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.DeliveryDate)
                .HasColumnType("datetime")
                .HasColumnName("delivery date");
            entity.Property(e => e.ItemId).HasColumnName("item ID");
            entity.Property(e => e.Name)
                .HasMaxLength(70)
                .HasColumnName("name");
            entity.Property(e => e.OrderDate)
                .HasColumnType("datetime")
                .HasColumnName("order date");
            entity.Property(e => e.TransactionTypeId).HasColumnName("TransactionType ID");
            entity.Property(e => e.UserId).HasColumnName("User ID");

            entity.HasOne(d => d.TransactionType).WithMany(p => p.Transactions)
                .HasForeignKey(d => d.TransactionTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransactionsType");

            entity.HasOne(d => d.User).WithMany(p => p.Transactions)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_User ID");
        });

        modelBuilder.Entity<TransactionsType>(entity =>
        {
            entity.ToTable("TransactionsType");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("users");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Address)
                .HasMaxLength(250)
                .HasColumnName("address");
            entity.Property(e => e.EMail)
                .HasMaxLength(50)
                .HasColumnName("E-mail");
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .HasColumnName("phone Number");
            entity.Property(e => e.UserTypeId).HasColumnName("User Type ID");

            entity.HasOne(d => d.UserType).WithMany(p => p.Users)
                .HasForeignKey(d => d.UserTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_user_type");
        });

        modelBuilder.Entity<UsersType>(entity =>
        {
            entity.ToTable("Users Types");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(250);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
