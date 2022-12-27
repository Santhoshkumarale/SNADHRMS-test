using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SNADHRMS.Repository.Models
{
    public partial class SNADContext : DbContext
    {
        public SNADContext()
        {
        }

        public SNADContext(DbContextOptions<SNADContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Clientdatum> Clientdata { get; set; }
        public virtual DbSet<EmpDatum> EmpData { get; set; }
        public virtual DbSet<Empexpense> Empexpenses { get; set; }
        public virtual DbSet<Employeedatum> Employeedata { get; set; }
        public virtual DbSet<Expense> Expenses { get; set; }
        public virtual DbSet<Imgexpense> Imgexpenses { get; set; }
        public virtual DbSet<Mgmtexpense> Mgmtexpenses { get; set; }
        public virtual DbSet<PayRollExpense> PayRollExpenses { get; set; }
        public virtual DbSet<Test2> Test2s { get; set; }
        public virtual DbSet<Test3> Test3s { get; set; }
        public virtual DbSet<TestTable> TestTables { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=172.16.189.201;Database=SNAD;user id=snad_hrms;password=snadhrms;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clientdatum>(entity =>
            {
                entity.HasKey(e => e.Clientcode)
                    .HasName("PK__clientda__C68A1D8B935D53B5");

                entity.ToTable("clientdata");

                entity.Property(e => e.Clientcode)
                    .ValueGeneratedNever()
                    .HasColumnName("clientcode");

                entity.Property(e => e.Agreementendate)
                    .HasColumnType("date")
                    .HasColumnName("agreementendate");

                entity.Property(e => e.Agreementstartdate)
                    .HasColumnType("date")
                    .HasColumnName("agreementstartdate");

                entity.Property(e => e.Clientlocation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("clientlocation");

                entity.Property(e => e.Clientname)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("clientname");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Serviceagreementonboarded)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("serviceagreementonboarded");

                entity.Property(e => e.Taxfedral).HasColumnName("taxfedral");
            });

            modelBuilder.Entity<EmpDatum>(entity =>
            {
                entity.HasKey(e => e.EmpId);

                entity.Property(e => e.EmpId).ValueGeneratedNever();

                entity.Property(e => e.EmpName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpSalary).HasColumnType("money");

                entity.Property(e => e.Files).HasMaxLength(1);
            });

            modelBuilder.Entity<Empexpense>(entity =>
            {
                entity.ToTable("empexpenses");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasColumnName("amount");

                entity.Property(e => e.Approvaldate)
                    .HasColumnType("date")
                    .HasColumnName("approvaldate");

                entity.Property(e => e.Approvedby).HasColumnName("approvedby");

                entity.Property(e => e.Clientcode).HasColumnName("clientcode");

                entity.Property(e => e.Createdby).HasColumnName("createdby");

                entity.Property(e => e.Creationdate)
                    .HasColumnType("date")
                    .HasColumnName("creationdate");

                entity.Property(e => e.Employeeid).HasColumnName("employeeid");

                entity.Property(e => e.Entity)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("entity");

                entity.Property(e => e.Expensecode)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("expensecode");

                entity.Property(e => e.Expensedate)
                    .HasColumnType("date")
                    .HasColumnName("expensedate");

                entity.Property(e => e.Modeofpayment)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("modeofpayment");

                entity.Property(e => e.Paymentdate)
                    .HasColumnType("date")
                    .HasColumnName("paymentdate");

                entity.Property(e => e.Updatedby).HasColumnName("updatedby");

                entity.HasOne(d => d.ApprovedbyNavigation)
                    .WithMany(p => p.EmpexpenseApprovedbyNavigations)
                    .HasForeignKey(d => d.Approvedby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__empexpens__appro__7C4F7684");

                entity.HasOne(d => d.CreatedbyNavigation)
                    .WithMany(p => p.EmpexpenseCreatedbyNavigations)
                    .HasForeignKey(d => d.Createdby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__empexpens__creat__7D439ABD");

                entity.HasOne(d => d.ExpensecodeNavigation)
                    .WithMany(p => p.Empexpenses)
                    .HasForeignKey(d => d.Expensecode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__empexpens__expen__7B5B524B");

                entity.HasOne(d => d.UpdatedbyNavigation)
                    .WithMany(p => p.EmpexpenseUpdatedbyNavigations)
                    .HasForeignKey(d => d.Updatedby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__empexpens__updat__7E37BEF6");
            });

            modelBuilder.Entity<Employeedatum>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK__employee__C135F5E9820E8B2C");

                entity.ToTable("employeedata");

                entity.Property(e => e.EmployeeId).ValueGeneratedNever();

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.AddressLine1)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine2)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.BackgroundCheckStatus)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessArea)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Clientcode).HasColumnName("clientcode");

                entity.Property(e => e.Comments)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompensationComments)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CompensationEffectiveDate).HasColumnType("date");

                entity.Property(e => e.ConfirmPassword)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Contactnumber).HasColumnName("contactnumber");

                entity.Property(e => e.Country)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Createdby)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("createdby");

                entity.Property(e => e.DateOfJoining).HasColumnType("date");

                entity.Property(e => e.Degree)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.Educationenddate).HasColumnType("date");

                entity.Property(e => e.Educationstartdate).HasColumnType("date");

                entity.Property(e => e.Effectivedate)
                    .HasColumnType("date")
                    .HasColumnName("effectivedate");

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Emailaddress)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("emailaddress");

                entity.Property(e => e.EmergencyName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Emergencynumber).HasColumnName("emergencynumber");

                entity.Property(e => e.Employementstatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("employementstatus");

                entity.Property(e => e.Empstatus)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("empstatus");

                entity.Property(e => e.Entity)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Expirationdate)
                    .HasColumnType("date")
                    .HasColumnName("expirationdate");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Frequency)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Highestdegree)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("highestdegree");

                entity.Property(e => e.HomeEmail)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Immigrationstatus)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("immigrationstatus");

                entity.Property(e => e.Internalstaff)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("internalstaff");

                entity.Property(e => e.IssuedDate).HasColumnType("date");

                entity.Property(e => e.JobEffectiveDate).HasColumnType("date");

                entity.Property(e => e.Jobtitle)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("jobtitle");

                entity.Property(e => e.LastName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MaritalStatus)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NoticePeriod)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.OvertimeEligibility)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Overtimerate).HasColumnName("overtimerate");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PayType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Payrate).HasColumnName("payrate");

                entity.Property(e => e.Payschedule)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("payschedule");

                entity.Property(e => e.ProbationEndDate).HasColumnType("date");

                entity.Property(e => e.ProbationStatus)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ProfilePic)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.ProjectEndDate).HasColumnType("date");

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectStartDate).HasColumnType("date");

                entity.Property(e => e.Proof)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Reason)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RelationShip)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.ReportingTo)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SecondaryLanguage)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Specialization)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ssn).HasColumnName("ssn");

                entity.Property(e => e.Startdate)
                    .HasColumnType("date")
                    .HasColumnName("startdate");

                entity.Property(e => e.State)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.Supervisor).HasColumnName("supervisor");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.University)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Updatedby)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("updatedby");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.VisaStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VisaTypeIssuingCountry)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.WorkEmail)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCodePostalCode).HasColumnName("ZipCode/PostalCode");
            });

            modelBuilder.Entity<Expense>(entity =>
            {
                entity.HasKey(e => e.Expensecode)
                    .HasName("PK__expenses__1633B98DAE5A7DDB");

                entity.ToTable("expenses");

                entity.Property(e => e.Expensecode)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("expensecode");

                entity.Property(e => e.Expenses)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("expenses");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<Imgexpense>(entity =>
            {
                entity.ToTable("imgexpenses");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasColumnName("amount");

                entity.Property(e => e.Approvaldate)
                    .HasColumnType("date")
                    .HasColumnName("approvaldate");

                entity.Property(e => e.Approvedby).HasColumnName("approvedby");

                entity.Property(e => e.Createdby).HasColumnName("createdby");

                entity.Property(e => e.Creationdate)
                    .HasColumnType("date")
                    .HasColumnName("creationdate");

                entity.Property(e => e.Employeeid).HasColumnName("employeeid");

                entity.Property(e => e.Entity)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("entity");

                entity.Property(e => e.Expdate)
                    .HasColumnType("date")
                    .HasColumnName("expdate");

                entity.Property(e => e.Expensecode)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("expensecode");

                entity.Property(e => e.Modeofpayment)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("modeofpayment");

                entity.Property(e => e.Paymentdate)
                    .HasColumnType("date")
                    .HasColumnName("paymentdate");

                entity.Property(e => e.Updatedby).HasColumnName("updatedby");

                entity.HasOne(d => d.ApprovedbyNavigation)
                    .WithMany(p => p.ImgexpenseApprovedbyNavigations)
                    .HasForeignKey(d => d.Approvedby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__imgexpens__appro__6D0D32F4");

                entity.HasOne(d => d.CreatedbyNavigation)
                    .WithMany(p => p.ImgexpenseCreatedbyNavigations)
                    .HasForeignKey(d => d.Createdby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__imgexpens__creat__6E01572D");

                entity.HasOne(d => d.ExpensecodeNavigation)
                    .WithMany(p => p.Imgexpenses)
                    .HasForeignKey(d => d.Expensecode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__imgexpens__expen__6C190EBB");

                entity.HasOne(d => d.UpdatedbyNavigation)
                    .WithMany(p => p.ImgexpenseUpdatedbyNavigations)
                    .HasForeignKey(d => d.Updatedby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__imgexpens__updat__6EF57B66");
            });

            modelBuilder.Entity<Mgmtexpense>(entity =>
            {
                entity.HasKey(e => e.Expensecode)
                    .HasName("PK__mgmtexpe__1633B98DCDD9E486");

                entity.ToTable("mgmtexpense");

                entity.Property(e => e.Expensecode)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("expensecode");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasColumnName("amount");

                entity.Property(e => e.Approvaldate)
                    .HasColumnType("date")
                    .HasColumnName("approvaldate");

                entity.Property(e => e.Approvedby).HasColumnName("approvedby");

                entity.Property(e => e.Clientcode).HasColumnName("clientcode");

                entity.Property(e => e.Createdby).HasColumnName("createdby");

                entity.Property(e => e.Creationdate)
                    .HasColumnType("date")
                    .HasColumnName("creationdate");

                entity.Property(e => e.Employeeid).HasColumnName("employeeid");

                entity.Property(e => e.Employeename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("employeename");

                entity.Property(e => e.Entity)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("entity");

                entity.Property(e => e.Expensedate)
                    .HasColumnType("date")
                    .HasColumnName("expensedate");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Modeofpayment)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("modeofpayment");

                entity.Property(e => e.Paymentdate)
                    .HasColumnType("date")
                    .HasColumnName("paymentdate");

                entity.Property(e => e.Totalmgmtexpenses)
                    .HasColumnType("money")
                    .HasColumnName("totalmgmtexpenses");

                entity.HasOne(d => d.ApprovedbyNavigation)
                    .WithMany(p => p.MgmtexpenseApprovedbyNavigations)
                    .HasForeignKey(d => d.Approvedby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__mgmtexpen__appro__76969D2E");

                entity.HasOne(d => d.CreatedbyNavigation)
                    .WithMany(p => p.MgmtexpenseCreatedbyNavigations)
                    .HasForeignKey(d => d.Createdby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__mgmtexpen__creat__778AC167");
            });

            modelBuilder.Entity<PayRollExpense>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Createdby).HasColumnName("createdby");

                entity.Property(e => e.Creationdate)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("creationdate");

                entity.Property(e => e.Employeeid).HasColumnName("employeeid");

                entity.Property(e => e.Employeename)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("employeename");

                entity.Property(e => e.Grosspay).HasColumnName("grosspay");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Insurancebycompany).HasColumnName("insurancebycompany");

                entity.Property(e => e.Noofhours).HasColumnName("noofhours");

                entity.Property(e => e.Paymentdate)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("paymentdate");

                entity.Property(e => e.Payperiodenddate)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("payperiodenddate");

                entity.Property(e => e.Payperiodstartdate)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("payperiodstartdate");

                entity.Property(e => e.Payrate).HasColumnName("payrate");

                entity.Property(e => e.Payrollexpense1).HasColumnName("payrollexpense");

                entity.Property(e => e.Totalpayrollexpenses)
                    .HasColumnType("money")
                    .HasColumnName("totalpayrollexpenses");

                entity.Property(e => e.Updatedby).HasColumnName("updatedby");

                entity.Property(e => e.Updateddate)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("updateddate");

                entity.HasOne(d => d.CreatedbyNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Createdby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PayRollEx__creat__01142BA1");

                entity.HasOne(d => d.UpdatedbyNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Updatedby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PayRollEx__updat__02084FDA");
            });

            modelBuilder.Entity<Test2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("test2");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Test3>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("test3", "snad_hrms");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TestTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("test_table");

                entity.Property(e => e.Test)
                    .HasMaxLength(10)
                    .HasColumnName("test")
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
