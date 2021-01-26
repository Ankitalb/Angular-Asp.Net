using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MachineTestWebAPI.Models
{
    public partial class MT_PL1924Context : DbContext
    {
        public MT_PL1924Context()
        {
        }

        public MT_PL1924Context(DbContextOptions<MT_PL1924Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<VisitTable> VisitTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("DBConnection");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmpId)
                    .HasName("PK__Employee__1299A8618A626F33");

                entity.Property(e => e.EmpId)
                    .HasColumnName("emp_id")
                    .HasColumnType("numeric(4, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Address)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LId)
                    .HasColumnName("l_id")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.LastName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber).HasColumnType("numeric(10, 0)");

                entity.HasOne(d => d.L)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.LId)
                    .HasConstraintName("FK__Employee__l_id__38996AB5");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.HasKey(e => e.LId)
                    .HasName("PK__Login__A7C7B6F88C4CECCE");

                entity.Property(e => e.LId)
                    .HasColumnName("l_id")
                    .HasColumnType("numeric(4, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.UserType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VisitTable>(entity =>
            {
                entity.HasKey(e => e.VisitId)
                    .HasName("PK__VisitTab__375A75E189B755F7");

                entity.Property(e => e.VisitId)
                    .HasColumnName("visit_id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ContactNo)
                    .HasColumnName("contact_no")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.ContactPerson)
                    .HasColumnName("contact_person")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustName)
                    .HasColumnName("cust_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId)
                    .HasColumnName("emp_id")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.InterestProduct)
                    .HasColumnName("interest_product")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");

                entity.Property(e => e.IsDisabled).HasColumnName("is_disabled");

                entity.Property(e => e.VisitDatetime)
                    .HasColumnName("visit_datetime")
                    .HasColumnType("date");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.VisitTable)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK__VisitTabl__emp_i__3B75D760");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
