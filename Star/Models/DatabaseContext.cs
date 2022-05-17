using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Star.Models
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<Business> Businesses { get; set; } = null!;
        public virtual DbSet<Candidate> Candidates { get; set; } = null!;
        public virtual DbSet<Career> Careers { get; set; } = null!;
        public virtual DbSet<CategoryBusiness> CategoryBusinesses { get; set; } = null!;
        public virtual DbSet<Client> Clients { get; set; } = null!;
        public virtual DbSet<Contract> Contracts { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<Request> Requests { get; set; } = null!;
        public virtual DbSet<Testimonial> Testimonials { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=THANHDAT;Database=StarSecurity;user id=sa;password=hominhthanhdat");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK__Account__C134C9C11ADFFBE3");

                entity.ToTable("Account");

                entity.Property(e => e.EmployeeId)
                    .ValueGeneratedNever()
                    .HasColumnName("employeeId");

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .HasColumnName("email");

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .HasColumnName("password");

                entity.Property(e => e.RoleAccount).HasColumnName("roleAccount");

                entity.Property(e => e.StatusAccount).HasColumnName("statusAccount");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .HasColumnName("userName");

                entity.HasOne(d => d.Employee)
                    .WithOne(p => p.Account)
                    .HasForeignKey<Account>(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_account_employee");
            });

            modelBuilder.Entity<Business>(entity =>
            {
                entity.ToTable("Business");

                entity.Property(e => e.BusinessId).HasColumnName("businessId");

                entity.Property(e => e.CategoryId).HasColumnName("categoryId");

                entity.Property(e => e.DescriptionBusiness)
                    .HasMaxLength(500)
                    .HasColumnName("descriptionBusiness");

                entity.Property(e => e.Duration)
                    .HasMaxLength(150)
                    .HasColumnName("duration");

                entity.Property(e => e.NameBusiness)
                    .HasMaxLength(500)
                    .HasColumnName("nameBusiness");

                entity.Property(e => e.PhotoBusiness)
                    .HasMaxLength(150)
                    .HasColumnName("photoBusiness");

                entity.Property(e => e.StatusBusiness).HasColumnName("statusBusiness");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Businesses)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_business_categoryBusiness");
            });

            modelBuilder.Entity<Candidate>(entity =>
            {
                entity.ToTable("Candidate");

                entity.Property(e => e.CandidateId).HasColumnName("candidateId");

                entity.Property(e => e.AddressCandidate)
                    .HasMaxLength(150)
                    .HasColumnName("addressCandidate");

                entity.Property(e => e.CareerId).HasColumnName("careerId");

                entity.Property(e => e.FullNameCandidate)
                    .HasMaxLength(150)
                    .HasColumnName("fullNameCandidate");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(11)
                    .HasColumnName("phoneNumber");

                entity.Property(e => e.QualityEducation)
                    .HasMaxLength(150)
                    .HasColumnName("qualityEducation");

                entity.Property(e => e.StatusCandidate).HasColumnName("statusCandidate");

                entity.HasOne(d => d.Career)
                    .WithMany(p => p.Candidates)
                    .HasForeignKey(d => d.CareerId)
                    .HasConstraintName("FK_candidate_career");
            });

            modelBuilder.Entity<Career>(entity =>
            {
                entity.ToTable("Career");

                entity.Property(e => e.CareerId).HasColumnName("careerId");

                entity.Property(e => e.BusinessId).HasColumnName("businessId");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("date")
                    .HasColumnName("createdDate");

                entity.Property(e => e.DescriptionCareer)
                    .HasMaxLength(1000)
                    .HasColumnName("descriptionCareer");

                entity.Property(e => e.Location)
                    .HasMaxLength(1000)
                    .HasColumnName("location");

                entity.Property(e => e.Offer)
                    .HasMaxLength(1000)
                    .HasColumnName("offer");

                entity.Property(e => e.Requirement)
                    .HasMaxLength(1000)
                    .HasColumnName("requirement");

                entity.Property(e => e.Salary)
                    .HasMaxLength(500)
                    .HasColumnName("salary");

                entity.Property(e => e.StatusCareer)
                    .HasColumnName("statusCareer")
                    .HasDefaultValueSql("('true')");

                entity.Property(e => e.Title)
                    .HasMaxLength(150)
                    .HasColumnName("title");

                entity.HasOne(d => d.Business)
                    .WithMany(p => p.Careers)
                    .HasForeignKey(d => d.BusinessId)
                    .HasConstraintName("FK_Career_business");
            });

            modelBuilder.Entity<CategoryBusiness>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK__Category__23CAF1D8868F8E10");

                entity.ToTable("CategoryBusiness");

                entity.Property(e => e.CategoryId).HasColumnName("categoryId");

                entity.Property(e => e.DescriptionCategory)
                    .HasMaxLength(500)
                    .HasColumnName("descriptionCategory");

                entity.Property(e => e.NameCategory)
                    .HasMaxLength(150)
                    .HasColumnName("nameCategory");

                entity.Property(e => e.StatusCategory).HasColumnName("statusCategory");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("Client");

                entity.Property(e => e.ClientId).HasColumnName("clientId");

                entity.Property(e => e.AddressClient)
                    .HasMaxLength(150)
                    .HasColumnName("addressClient");

                entity.Property(e => e.EmailClient)
                    .HasMaxLength(150)
                    .HasColumnName("emailClient");

                entity.Property(e => e.NameClient)
                    .HasMaxLength(50)
                    .HasColumnName("nameClient");

                entity.Property(e => e.PhoneClient)
                    .HasMaxLength(11)
                    .HasColumnName("phoneClient");
            });

            modelBuilder.Entity<Contract>(entity =>
            {
                entity.ToTable("Contract");

                entity.Property(e => e.ContractId).HasColumnName("contractId");

                entity.Property(e => e.BusinessId).HasColumnName("businessId");

                entity.Property(e => e.ClientId).HasColumnName("clientId");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeId");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("endDate");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("startDate");

                entity.Property(e => e.StatusContract).HasColumnName("statusContract");

                entity.HasOne(d => d.Business)
                    .WithMany(p => p.Contracts)
                    .HasForeignKey(d => d.BusinessId)
                    .HasConstraintName("FK_contract_business");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Contracts)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_contract_client");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Contracts)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_contract_employee");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Department");

                entity.Property(e => e.DepartmentId).HasColumnName("departmentId");

                entity.Property(e => e.AddressDepartment)
                    .HasMaxLength(150)
                    .HasColumnName("addressDepartment");

                entity.Property(e => e.NameDepartment)
                    .HasMaxLength(150)
                    .HasColumnName("nameDepartment");

                entity.Property(e => e.StatusDepartment).HasColumnName("statusDepartment");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeId");

                entity.Property(e => e.Achievement)
                    .HasMaxLength(150)
                    .HasColumnName("achievement");

                entity.Property(e => e.AddressEmployee)
                    .HasMaxLength(150)
                    .HasColumnName("addressEmployee");

                entity.Property(e => e.BusinessId).HasColumnName("businessId");

                entity.Property(e => e.DepartmentId).HasColumnName("departmentId");

                entity.Property(e => e.FullName)
                    .HasMaxLength(50)
                    .HasColumnName("fullName");

                entity.Property(e => e.Grade)
                    .HasMaxLength(50)
                    .HasColumnName("grade");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(11)
                    .HasColumnName("phoneNumber");

                entity.Property(e => e.PhotoEmployee)
                    .HasMaxLength(150)
                    .HasColumnName("photoEmployee");

                entity.Property(e => e.QualityEducation)
                    .HasMaxLength(200)
                    .HasColumnName("qualityEducation");

                entity.Property(e => e.RoleEmployee)
                    .HasMaxLength(150)
                    .HasColumnName("roleEmployee");

                entity.Property(e => e.StatusEmployee).HasColumnName("statusEmployee");

                entity.HasOne(d => d.Business)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.BusinessId)
                    .HasConstraintName("FK_employee_business");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_employee_department");
            });

            modelBuilder.Entity<Request>(entity =>
            {
                entity.ToTable("Request");

                entity.Property(e => e.RequestId).HasColumnName("requestId");

                entity.Property(e => e.AddressClient)
                    .HasMaxLength(150)
                    .HasColumnName("addressClient");

                entity.Property(e => e.BusinessId).HasColumnName("businessId");

                entity.Property(e => e.EmailClient)
                    .HasMaxLength(150)
                    .HasColumnName("emailClient");

                entity.Property(e => e.IdentifyClient).HasMaxLength(50);

                entity.Property(e => e.NameClient)
                    .HasMaxLength(50)
                    .HasColumnName("nameClient");

                entity.Property(e => e.PhoneClient)
                    .HasMaxLength(11)
                    .HasColumnName("phoneClient");

                entity.Property(e => e.StatusRequest).HasColumnName("statusRequest");

                entity.HasOne(d => d.Business)
                    .WithMany(p => p.Requests)
                    .HasForeignKey(d => d.BusinessId)
                    .HasConstraintName("FK_request_business");
            });

            modelBuilder.Entity<Testimonial>(entity =>
            {
                entity.HasKey(e => e.TestmonialId)
                    .HasName("PK__Testimon__C5612D1F249AABF4");

                entity.ToTable("Testimonial");

                entity.Property(e => e.TestmonialId).HasColumnName("testmonialId");

                entity.Property(e => e.Author)
                    .HasMaxLength(50)
                    .HasColumnName("author");

                entity.Property(e => e.Content)
                    .HasMaxLength(150)
                    .HasColumnName("content");

                entity.Property(e => e.Photo)
                    .HasMaxLength(150)
                    .HasColumnName("photo");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
