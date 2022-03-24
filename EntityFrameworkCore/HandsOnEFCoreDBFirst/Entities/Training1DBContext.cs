using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace HandsOnEFCoreDBFirst.Entities
{
    public partial class Training1DBContext : DbContext
    {
        public Training1DBContext()
        {
        }

        public Training1DBContext(DbContextOptions<Training1DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Dept> Depts { get; set; }
        public virtual DbSet<DeptView> DeptViews { get; set; }
        public virtual DbSet<Emp> Emps { get; set; }
        public virtual DbSet<EmpDeptView> EmpDeptViews { get; set; }
        public virtual DbSet<EmpView> EmpViews { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Employeeview> Employeeviews { get; set; }
        public virtual DbSet<First> Firsts { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Mark> Marks { get; set; }
        public virtual DbSet<Mytable> Mytables { get; set; }
        public virtual DbSet<Mytable1> Mytables1 { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Printer> Printers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Second> Seconds { get; set; }
        public virtual DbSet<Standard> Standards { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=SANTU\\MSSQLSERVER2019;Database=Training1DB;Integrated Security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Customer");

                entity.HasIndex(e => e.CustomerId, "CI_UCluster")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => e.CustomerName, "CN_NonCluster");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dept>(entity =>
            {
                entity.ToTable("Dept");

                entity.HasIndex(e => e.DeptName, "UQ__Dept__ED89B5A88C485295")
                    .IsUnique();

                entity.Property(e => e.DeptId)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.DeptName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DeptView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DeptView");

                entity.Property(e => e.DeptId)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Emp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Emp");

                entity.HasIndex(e => e.Eid, "index_Eid")
                    .IsClustered();

                entity.HasIndex(e => e.Salary, "index_salary");

                entity.Property(e => e.DeptId)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Desig)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ename)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Joindate).HasColumnType("date");

                entity.Property(e => e.Salary).HasColumnType("money");
            });

            modelBuilder.Entity<EmpDeptView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EmpDeptView");

                entity.Property(e => e.DeptName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ename)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Salary).HasColumnType("money");
            });

            modelBuilder.Entity<EmpView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EmpView");

                entity.Property(e => e.Ename)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JoinDate).HasColumnType("date");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PK__Employee__C1971B535BA37473");

                entity.ToTable("Employee");

                entity.Property(e => e.Eid).ValueGeneratedNever();

                entity.Property(e => e.DeptId)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Desig)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('UnAssigned')");

                entity.Property(e => e.Ename)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Joindate).HasColumnType("date");

                entity.Property(e => e.Salary).HasColumnType("money");

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.DeptId)
                    .HasConstraintName("FK__Employee__DeptId__68487DD7");

                entity.HasOne(d => d.ManagerNavigation)
                    .WithMany(p => p.InverseManagerNavigation)
                    .HasForeignKey(d => d.Manager)
                    .HasConstraintName("FK__Employee__Manage__14270015");
            });

            modelBuilder.Entity<Employeeview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Employeeview");

                entity.Property(e => e.Ename)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Salary).HasColumnType("money");
            });

            modelBuilder.Entity<First>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("First");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.HasKey(e => e.Uname)
                    .HasName("PK__Login__9C5CAF9B75ECCE97");

                entity.ToTable("Login");

                entity.Property(e => e.Uname)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Pwd)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.EidNavigation)
                    .WithMany(p => p.Logins)
                    .HasForeignKey(d => d.Eid)
                    .HasConstraintName("FK__Login__Eid__42E1EEFE");
            });

            modelBuilder.Entity<Mark>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.TestAvg).HasComputedColumnSql("(([Test1]+[Test2])/(2))", false);
            });

            modelBuilder.Entity<Mytable>(entity =>
            {
                entity.HasKey(e => e.Cid)
                    .HasName("PK__mytable__C1F8DC5923DA7A29");

                entity.ToTable("mytable");

                entity.Property(e => e.Cid)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CID");
            });

            modelBuilder.Entity<Mytable1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mytable", "my");

                entity.Property(e => e.Col1).HasColumnName("col1");

                entity.Property(e => e.Col2).HasColumnName("col2");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__Person__C57059388176BECD");

                entity.ToTable("Person");

                entity.HasIndex(e => e.Pname, "Pname_idx");

                entity.Property(e => e.Pid).ValueGeneratedNever();

                entity.Property(e => e.JoinDate).HasColumnType("date");

                entity.Property(e => e.Pname)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Printer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Printer");

                entity.Property(e => e.PrintId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__Product__C5705938F1CE42BD");

                entity.ToTable("Product");

                entity.HasIndex(e => e.Pname, "UQ__Product__173BB01CE397741A")
                    .IsUnique();

                entity.Property(e => e.Pid).ValueGeneratedNever();

                entity.Property(e => e.Pname)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Second>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Second");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Standard>(entity =>
            {
                entity.HasKey(e => e.StandId)
                    .HasName("PK__Standard__CA614FA5DF0ACD8C");

                entity.ToTable("Standard");

                entity.HasIndex(e => e.StandName, "UQ__Standard__49423FB7805B0423")
                    .IsUnique();

                entity.Property(e => e.StandId)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.StandName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Timings)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("timings");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("Pk_Sid");

                entity.ToTable("Student");

                entity.Property(e => e.Sid).ValueGeneratedNever();

                entity.Property(e => e.Sdob)
                    .HasColumnType("date")
                    .HasColumnName("SDOB");

                entity.Property(e => e.Sname)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StandId)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.Stand)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.StandId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("Fk_StandId");
            });

            modelBuilder.HasSequence<int>("sq1")
                .StartsAt(10)
                .IncrementsBy(5);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
