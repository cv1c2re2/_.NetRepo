using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public partial class EPPContext : DbContext
    {
        public virtual DbSet<AircraftInfo> AircraftInfo { get; set; }
        public virtual DbSet<BodyStyle> BodyStyle { get; set; }
        public virtual DbSet<CflInfo> CflInfo { get; set; }
        public virtual DbSet<Cods> Cods { get; set; }
        public virtual DbSet<ColorGradient> ColorGradient { get; set; }
        public virtual DbSet<ControlSequence> ControlSequence { get; set; }
        public virtual DbSet<CustodianGroup> CustodianGroup { get; set; }
        public virtual DbSet<Demilitarization> Demilitarization { get; set; }
        public virtual DbSet<DisposalCondition> DisposalCondition { get; set; }
        public virtual DbSet<FederalAssetSales> FederalAssetSales { get; set; }
        public virtual DbSet<Files> Files { get; set; }
        public virtual DbSet<Fsc> Fsc { get; set; }
        public virtual DbSet<FuelType> FuelType { get; set; }
        public virtual DbSet<HardDiskSize> HardDiskSize { get; set; }
        public virtual DbSet<HardDiskStatus> HardDiskStatus { get; set; }
        public virtual DbSet<HardwareType> HardwareType { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<MngtDecision> MngtDecision { get; set; }
        public virtual DbSet<NoOfCylinders> NoOfCylinders { get; set; }
        public virtual DbSet<PocGroup> PocGroup { get; set; }
        public virtual DbSet<ProcessorSpeed> ProcessorSpeed { get; set; }
        public virtual DbSet<Questions> Questions { get; set; }
        public virtual DbSet<RandomAccessMemory> RandomAccessMemory { get; set; }
        public virtual DbSet<ReimbursementType> ReimbursementType { get; set; }
        public virtual DbSet<ReportAgency> ReportAgency { get; set; }
        public virtual DbSet<ReportItem> ReportItem { get; set; }
        public virtual DbSet<ReportItemHistory> ReportItemHistory { get; set; }
        public virtual DbSet<StatusCode> StatusCode { get; set; }
        public virtual DbSet<SupplyCondition> SupplyCondition { get; set; }
        public virtual DbSet<TrailerInfo> TrailerInfo { get; set; }
        public virtual DbSet<UnitOfIssue> UnitOfIssue { get; set; }
        public virtual DbSet<VehicleColor> VehicleColor { get; set; }
        public virtual DbSet<VehicleInfo> VehicleInfo { get; set; }
        public virtual DbSet<WarehouseRecommendation> WarehouseRecommendation { get; set; }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //    if (!optionsBuilder.IsConfigured)
        //     {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //              optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EPP;Trusted_Connection=True;");
        //        }
        //  }

        public EPPContext(DbContextOptions<EPPContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AircraftInfo>(entity =>
            {
                entity.HasKey(e => e.ReportItemId);

                entity.ToTable("AIRCRAFT_INFO");

                entity.Property(e => e.ReportItemId).HasColumnName("REPORT_ITEM_ID");

                entity.Property(e => e.AircraftFlag)
                    .HasColumnName("AIRCRAFT_FLAG")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Certified)
                    .HasColumnName("CERTIFIED")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.DataplateAvailable)
                    .HasColumnName("DATAPLATE_AVAILABLE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ElectricalProblem)
                    .HasColumnName("ELECTRICAL_PROBLEM")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EngineMissing)
                    .HasColumnName("ENGINE_MISSING")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FaaStandard)
                    .HasColumnName("FAA_STANDARD")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.HistoricalDataRecords)
                    .HasColumnName("HISTORICAL_DATA_RECORDS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedBy)
                    .IsRequired()
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.LastUpdatedDate)
                    .HasColumnName("LAST_UPDATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.MajorComponentsMissing)
                    .HasColumnName("MAJOR_COMPONENTS_MISSING")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UsedDisassembAssemb)
                    .HasColumnName("USED_DISASSEMB_ASSEMB")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UsedGroundTraining)
                    .HasColumnName("USED_GROUND_TRAINING")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UsedMilitaryAcOnly)
                    .HasColumnName("USED_MILITARY_AC_ONLY")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UsedNonFlight)
                    .HasColumnName("USED_NON_FLIGHT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UsedRepeatedBurning)
                    .HasColumnName("USED_REPEATED_BURNING")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UsedStaticDisplay)
                    .HasColumnName("USED_STATIC_DISPLAY")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BodyStyle>(entity =>
            {
                entity.ToTable("BODY_STYLE");

                entity.HasIndex(e => e.Name)
                    .HasName("UK_BODY_STYLE_NAME")
                    .IsUnique();

                entity.Property(e => e.BodyStyleId).HasColumnName("BODY_STYLE_ID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Deleteflag)
                    .IsRequired()
                    .HasColumnName("DELETEFLAG")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder)
                    .HasColumnName("DISPLAY_ORDER")
                    .HasDefaultValueSql("((99))");

                entity.Property(e => e.LastUpdatedBy)
                    .IsRequired()
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.LastUpdatedDate)
                    .HasColumnName("LAST_UPDATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CflInfo>(entity =>
            {
                entity.HasKey(e => e.ReportItemId);

                entity.ToTable("CFL_INFO");

                entity.Property(e => e.ReportItemId).HasColumnName("REPORT_ITEM_ID");

                entity.Property(e => e.CflCode)
                    .HasColumnName("CFL_CODE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CflEligibleOrgn)
                    .HasColumnName("CFL_ELIGIBLE_ORGN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CflEquipType)
                    .HasColumnName("CFL_EQUIP_TYPE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CflPayShipping)
                    .HasColumnName("CFL_PAY_SHIPPING")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CflProcessor)
                    .HasColumnName("CFL_PROCESSOR")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.HardDiskSizeId).HasColumnName("HARD_DISK_SIZE_ID");

                entity.Property(e => e.HardDiskStatusId).HasColumnName("HARD_DISK_STATUS_ID");

                entity.Property(e => e.HardwareTypeId).HasColumnName("HARDWARE_TYPE_ID");

                entity.Property(e => e.LastUpdatedBy)
                    .IsRequired()
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.LastUpdatedDate)
                    .HasColumnName("LAST_UPDATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.ProcessorSpeedId).HasColumnName("PROCESSOR_SPEED_ID");

                entity.Property(e => e.RamId).HasColumnName("RAM_ID");
            });

            modelBuilder.Entity<Cods>(entity =>
            {
                entity.HasKey(e => e.CodId);

                entity.ToTable("CODS");

                entity.Property(e => e.CodId).HasColumnName("COD_ID");

                entity.Property(e => e.ContentType)
                    .HasColumnName("CONTENT_TYPE")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.FileData).HasColumnName("FILE_DATA");

                entity.Property(e => e.FileName)
                    .HasColumnName("FILE_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedBy)
                    .IsRequired()
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.LastUpdatedDate)
                    .HasColumnName("LAST_UPDATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.ReportItemId).HasColumnName("REPORT_ITEM_ID");

                entity.Property(e => e.StatusCodeId).HasColumnName("STATUS_CODE_ID");
            });

            modelBuilder.Entity<ColorGradient>(entity =>
            {
                entity.ToTable("COLOR_GRADIENT");

                entity.HasIndex(e => e.Name)
                    .HasName("UK_COLOR_GRADIENT_NAME")
                    .IsUnique();

                entity.Property(e => e.ColorGradientId).HasColumnName("COLOR_GRADIENT_ID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Deleteflag)
                    .IsRequired()
                    .HasColumnName("DELETEFLAG")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder)
                    .HasColumnName("DISPLAY_ORDER")
                    .HasDefaultValueSql("((99))");

                entity.Property(e => e.LastUpdatedBy)
                    .IsRequired()
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.LastUpdatedDate)
                    .HasColumnName("LAST_UPDATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ControlSequence>(entity =>
            {
                entity.HasKey(e => e.SequenceId);

                entity.ToTable("CONTROL_SEQUENCE");

                entity.Property(e => e.SequenceId).HasColumnName("SEQUENCE_ID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.LastUpdatedBy)
                    .IsRequired()
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.LastUpdatedDate)
                    .HasColumnName("LAST_UPDATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.SequenceNumber).HasColumnName("SEQUENCE_NUMBER");
            });

            modelBuilder.Entity<CustodianGroup>(entity =>
            {
                entity.HasKey(e => e.CustodianId);

                entity.ToTable("CUSTODIAN_GROUP");

                entity.Property(e => e.CustodianId).HasColumnName("CUSTODIAN_ID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasColumnName("FAX")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("FIRST_NAME")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasColumnName("LAST_NAME")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedBy)
                    .IsRequired()
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.LastUpdatedDate)
                    .HasColumnName("LAST_UPDATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.NotifySale)
                    .HasColumnName("NOTIFY_SALE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneExt)
                    .HasColumnName("PHONE_EXT")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("PHONE_NUMBER")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ReportItemId).HasColumnName("REPORT_ITEM_ID");

                entity.HasOne(d => d.ReportItem)
                    .WithMany(p => p.CustodianGroup)
                    .HasForeignKey(d => d.ReportItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REPORTITEM_CUSTODIANGROUP");
            });

            modelBuilder.Entity<Demilitarization>(entity =>
            {
                entity.ToTable("DEMILITARIZATION");

                entity.HasIndex(e => e.Name)
                    .HasName("UK_DEMILITARIZATION_NAME")
                    .IsUnique();

                entity.Property(e => e.DemilitarizationId).HasColumnName("DEMILITARIZATION_ID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Deleteflag)
                    .IsRequired()
                    .HasColumnName("DELETEFLAG")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder)
                    .HasColumnName("DISPLAY_ORDER")
                    .HasDefaultValueSql("((99))");

                entity.Property(e => e.LastUpdatedBy)
                    .IsRequired()
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.LastUpdatedDate)
                    .HasColumnName("LAST_UPDATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DisposalCondition>(entity =>
            {
                entity.ToTable("DISPOSAL_CONDITION");

                entity.HasIndex(e => e.Name)
                    .HasName("UK_DISPOSAL_CONDITION_NAME")
                    .IsUnique();

                entity.Property(e => e.DisposalConditionId).HasColumnName("DISPOSAL_CONDITION_ID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Deleteflag)
                    .IsRequired()
                    .HasColumnName("DELETEFLAG")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder)
                    .HasColumnName("DISPLAY_ORDER")
                    .HasDefaultValueSql("((99))");

                entity.Property(e => e.LastUpdatedBy)
                    .IsRequired()
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.LastUpdatedDate)
                    .HasColumnName("LAST_UPDATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FederalAssetSales>(entity =>
            {
                entity.ToTable("FEDERAL_ASSET_SALES");

                entity.HasIndex(e => e.Name)
                    .HasName("UK_FEDERAL_ASSET_SALES_NAME")
                    .IsUnique();

                entity.Property(e => e.FederalAssetSalesId).HasColumnName("FEDERAL_ASSET_SALES_ID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Deleteflag)
                    .IsRequired()
                    .HasColumnName("DELETEFLAG")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder)
                    .HasColumnName("DISPLAY_ORDER")
                    .HasDefaultValueSql("((99))");

                entity.Property(e => e.LastUpdatedBy)
                    .IsRequired()
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.LastUpdatedDate)
                    .HasColumnName("LAST_UPDATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Files>(entity =>
            {
                entity.HasKey(e => e.FileId);

                entity.ToTable("FILES");

                entity.Property(e => e.FileId).HasColumnName("FILE_ID");

                entity.Property(e => e.ContentType)
                    .HasColumnName("CONTENT_TYPE")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.FileData).HasColumnName("FILE_DATA");

                entity.Property(e => e.FileName)
                    .HasColumnName("FILE_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FileSize).HasColumnName("FILE_SIZE");

                entity.Property(e => e.LastUpdatedBy)
                    .IsRequired()
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedDate)
                    .HasColumnName("LAST_UPDATED_DATE")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Location)
                    .HasColumnName("LOCATION")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReportItemId).HasColumnName("REPORT_ITEM_ID");
            });

            modelBuilder.Entity<Fsc>(entity =>
            {
                entity.ToTable("FSC");

                entity.HasIndex(e => e.Name)
                    .HasName("UK_FSC_NAME")
                    .IsUnique();

                entity.Property(e => e.FscId).HasColumnName("FSC_ID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Deleteflag)
                    .IsRequired()
                    .HasColumnName("DELETEFLAG")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder)
                    .HasColumnName("DISPLAY_ORDER")
                    .HasDefaultValueSql("((99))");

                entity.Property(e => e.LastUpdatedBy)
                    .IsRequired()
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.LastUpdatedDate)
                    .HasColumnName("LAST_UPDATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FuelType>(entity =>
            {
                entity.ToTable("FUEL_TYPE");

                entity.HasIndex(e => e.Name)
                    .HasName("UK_FUEL_TYPE_NAME")
                    .IsUnique();

                entity.Property(e => e.FuelTypeId).HasColumnName("FUEL_TYPE_ID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Deleteflag)
                    .IsRequired()
                    .HasColumnName("DELETEFLAG")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder)
                    .HasColumnName("DISPLAY_ORDER")
                    .HasDefaultValueSql("((99))");

                entity.Property(e => e.LastUpdatedBy)
                    .IsRequired()
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.LastUpdatedDate)
                    .HasColumnName("LAST_UPDATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HardDiskSize>(entity =>
            {
                entity.ToTable("HARD_DISK_SIZE");

                entity.HasIndex(e => e.Name)
                    .HasName("UK_HARD_DISK_SIZE_NAME")
                    .IsUnique();

                entity.Property(e => e.HardDiskSizeId).HasColumnName("HARD_DISK_SIZE_ID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Deleteflag)
                    .IsRequired()
                    .HasColumnName("DELETEFLAG")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder)
                    .HasColumnName("DISPLAY_ORDER")
                    .HasDefaultValueSql("((99))");

                entity.Property(e => e.LastUpdatedBy)
                    .IsRequired()
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.LastUpdatedDate)
                    .HasColumnName("LAST_UPDATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HardDiskStatus>(entity =>
            {
                entity.ToTable("HARD_DISK_STATUS");

                entity.HasIndex(e => e.Name)
                    .HasName("UK_HARD_DISK_STATUS_NAME")
                    .IsUnique();

                entity.Property(e => e.HardDiskStatusId).HasColumnName("HARD_DISK_STATUS_ID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Deleteflag)
                    .IsRequired()
                    .HasColumnName("DELETEFLAG")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder)
                    .HasColumnName("DISPLAY_ORDER")
                    .HasDefaultValueSql("((99))");

                entity.Property(e => e.LastUpdatedBy)
                    .IsRequired()
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.LastUpdatedDate)
                    .HasColumnName("LAST_UPDATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HardwareType>(entity =>
            {
                entity.ToTable("HARDWARE_TYPE");

                entity.HasIndex(e => e.Name)
                    .HasName("UK_HARDWARE_TYPE_NAME")
                    .IsUnique();

                entity.Property(e => e.HardwareTypeId).HasColumnName("HARDWARE_TYPE_ID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Deleteflag)
                    .IsRequired()
                    .HasColumnName("DELETEFLAG")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder)
                    .HasColumnName("DISPLAY_ORDER")
                    .HasDefaultValueSql("((99))");

                entity.Property(e => e.LastUpdatedBy)
                    .IsRequired()
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.LastUpdatedDate)
                    .HasColumnName("LAST_UPDATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("LOCATION");

                entity.HasIndex(e => e.Name)
                    .HasName("UK_LOCATION_NAME")
                    .IsUnique();

                entity.Property(e => e.LocationId).HasColumnName("LOCATION_ID");

                entity.Property(e => e.AccPropOfficer)
                    .HasColumnName("ACC_PROP_OFFICER")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Address1)
                    .HasColumnName("ADDRESS_1")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasColumnName("ADDRESS_2")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Address3)
                    .HasColumnName("ADDRESS_3")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.AddressCity)
                    .HasColumnName("ADDRESS_CITY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressState)
                    .HasColumnName("ADDRESS_STATE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.AddressZip)
                    .HasColumnName("ADDRESS_ZIP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedBy)
                    .IsRequired()
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.LastUpdatedDate)
                    .HasColumnName("LAST_UPDATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.LocationCode)
                    .HasColumnName("LOCATION_CODE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PocEmail)
                    .HasColumnName("POC_EMAIL")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.PocFName)
                    .HasColumnName("POC_F_NAME")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PocFax)
                    .HasColumnName("POC_FAX")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PocLName)
                    .HasColumnName("POC_L_NAME")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PocTelephone)
                    .HasColumnName("POC_TELEPHONE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PocTelephoneExt)
                    .HasColumnName("POC_TELEPHONE_EXT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RegionInd)
                    .HasColumnName("REGION_IND")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MngtDecision>(entity =>
            {
                entity.ToTable("MNGT_DECISION");

                entity.Property(e => e.MngtDecisionId).HasColumnName("MNGT_DECISION_ID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Deleteflag)
                    .IsRequired()
                    .HasColumnName("DELETEFLAG")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder)
                    .HasColumnName("DISPLAY_ORDER")
                    .HasDefaultValueSql("((99))");

                entity.Property(e => e.LastUpdatedBy)
                    .IsRequired()
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.LastUpdatedDate)
                    .HasColumnName("LAST_UPDATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NoOfCylinders>(entity =>
            {
                entity.ToTable("NO_OF_CYLINDERS");

                entity.Property(e => e.NoOfCylindersId).HasColumnName("NO_OF_CYLINDERS_ID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.Deleteflag)
                    .IsRequired()
                    .HasColumnName("DELETEFLAG")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder)
                    .HasColumnName("DISPLAY_ORDER")
                    .HasDefaultValueSql("((99))");

                entity.Property(e => e.LastUpdatedBy)
                    .IsRequired()
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.LastUpdatedDate)
                    .HasColumnName("LAST_UPDATED_DATE")
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PocGroup>(entity =>
            {
                entity.HasKey(e => e.PocId);

                entity.ToTable("POC_GROUP");

                entity.Property(e => e.PocId).HasColumnName("POC_ID");

                entity.Property(e => e.AdditionalEmail)
                    .HasColumnName("ADDITIONAL_EMAIL")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasColumnName("FAX")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("FIRST_NAME")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasColumnName("LAST_NAME")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedBy)
                    .IsRequired()
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.LastUpdatedDate)
                    .HasColumnName("LAST_UPDATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.NotifySale)
                    .HasColumnName("NOTIFY_SALE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneExt)
                    .HasColumnName("PHONE_EXT")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("PHONE_NUMBER")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ReportItemId).HasColumnName("REPORT_ITEM_ID");

                entity.HasOne(d => d.ReportItem)
                    .WithMany(p => p.PocGroup)
                    .HasForeignKey(d => d.ReportItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REPORTITEM_POCGROUP");
            });

            modelBuilder.Entity<ProcessorSpeed>(entity =>
            {
                entity.ToTable("PROCESSOR_SPEED");

                entity.HasIndex(e => e.Name)
                    .HasName("UK_PROCESSOR_SPEED_NAME")
                    .IsUnique();

                entity.Property(e => e.ProcessorSpeedId).HasColumnName("PROCESSOR_SPEED_ID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Deleteflag)
                    .IsRequired()
                    .HasColumnName("DELETEFLAG")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder)
                    .HasColumnName("DISPLAY_ORDER")
                    .HasDefaultValueSql("((99))");

                entity.Property(e => e.LastUpdatedBy)
                    .IsRequired()
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.LastUpdatedDate)
                    .HasColumnName("LAST_UPDATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Questions>(entity =>
            {
                entity.HasKey(e => e.QuestionId);

                entity.ToTable("QUESTIONS");

                entity.Property(e => e.QuestionId).HasColumnName("QUESTION_ID");

                entity.Property(e => e.QstnLastUpdatedBy)
                    .IsRequired()
                    .HasColumnName("QSTN_LAST_UPDATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.QstnLastUpdatedDate)
                    .HasColumnName("QSTN_LAST_UPDATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Question)
                    .IsRequired()
                    .HasColumnName("QUESTION")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ReportItemId).HasColumnName("REPORT_ITEM_ID");

                entity.Property(e => e.RespLastUpdatedBy)
                    .HasColumnName("RESP_LAST_UPDATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.RespLastUpdatedDate)
                    .HasColumnName("RESP_LAST_UPDATED_DATE")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.Response)
                    .HasColumnName("RESPONSE")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.ReportItem)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.ReportItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REPORTITEM_QUESTIONS");
            });

            modelBuilder.Entity<RandomAccessMemory>(entity =>
            {
                entity.HasKey(e => e.RamId);

                entity.ToTable("RANDOM_ACCESS_MEMORY");

                entity.HasIndex(e => e.Name)
                    .HasName("UK_RANDOM_ACCESS_MEMORY_NAME")
                    .IsUnique();

                entity.Property(e => e.RamId).HasColumnName("RAM_ID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Deleteflag)
                    .IsRequired()
                    .HasColumnName("DELETEFLAG")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder)
                    .HasColumnName("DISPLAY_ORDER")
                    .HasDefaultValueSql("((99))");

                entity.Property(e => e.LastUpdatedBy)
                    .IsRequired()
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.LastUpdatedDate)
                    .HasColumnName("LAST_UPDATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReimbursementType>(entity =>
            {
                entity.ToTable("REIMBURSEMENT_TYPE");

                entity.HasIndex(e => e.Name)
                    .HasName("UK_REIMBURSEMENT_TYPE_NAME")
                    .IsUnique();

                entity.Property(e => e.ReimbursementTypeId).HasColumnName("REIMBURSEMENT_TYPE_ID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Deleteflag)
                    .IsRequired()
                    .HasColumnName("DELETEFLAG")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder)
                    .HasColumnName("DISPLAY_ORDER")
                    .HasDefaultValueSql("((99))");

                entity.Property(e => e.LastUpdatedBy)
                    .IsRequired()
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.LastUpdatedDate)
                    .HasColumnName("LAST_UPDATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReportAgency>(entity =>
            {
                entity.ToTable("REPORT_AGENCY");

                entity.Property(e => e.ReportAgencyId).HasColumnName("REPORT_AGENCY_ID");

                entity.Property(e => e.Address1)
                    .HasColumnName("ADDRESS1")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasColumnName("ADDRESS2")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Address3)
                    .HasColumnName("ADDRESS3")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.AgencyCode)
                    .IsRequired()
                    .HasColumnName("AGENCY_CODE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasColumnName("CITY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.LastUpdatedBy)
                    .IsRequired()
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.LastUpdatedDate)
                    .HasColumnName("LAST_UPDATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasColumnName("STATE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Zipcode)
                    .HasColumnName("ZIPCODE")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReportItem>(entity =>
            {
                entity.ToTable("REPORT_ITEM");

                entity.Property(e => e.ReportItemId).HasColumnName("REPORT_ITEM_ID");

                entity.Property(e => e.AcceptedByGsaDate)
                    .HasColumnName("ACCEPTED_BY_GSA_DATE")
                    .HasColumnType("datetime2(6)");

                entity.Property(e => e.AccessLevel)
                    .HasColumnName("ACCESS_LEVEL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AcquisitionDate)
                    .HasColumnName("ACQUISITION_DATE")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.AgencyLocationCode).HasColumnName("AGENCY_LOCATION_CODE");

                entity.Property(e => e.AgyControlNo)
                    .HasColumnName("AGY_CONTROL_NO")
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.Agybur)
                    .HasColumnName("AGYBUR")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AppropCode)
                    .HasColumnName("APPROP_CODE")
                    .HasMaxLength(48)
                    .IsUnicode(false);

                entity.Property(e => e.CertDestruction)
                    .HasColumnName("CERT_DESTRUCTION")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClLineItemNo).HasColumnName("CL_LINE_ITEM_NO");

                entity.Property(e => e.ClRefNo)
                    .HasColumnName("CL_REF_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cntrinvcd)
                    .HasColumnName("CNTRINVCD")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Completed)
                    .HasColumnName("COMPLETED")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CompletedDate)
                    .HasColumnName("COMPLETED_DATE")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.CountryCode)
                    .HasColumnName("COUNTRY_CODE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.DemilitarizationId).HasColumnName("DEMILITARIZATION_ID");

                entity.Property(e => e.DisposalConditionId).HasColumnName("DISPOSAL_CONDITION_ID");

                entity.Property(e => e.Drmo)
                    .HasColumnName("DRMO")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DropInternalFlag)
                    .HasColumnName("DROP_INTERNAL_FLAG")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EngrComments)
                    .HasColumnName("ENGR_COMMENTS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EngrDecidedDate)
                    .HasColumnName("ENGR_DECIDED_DATE")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.EngrDeision)
                    .HasColumnName("ENGR_DEISION")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExcessRelDate)
                    .HasColumnName("EXCESS_REL_DATE")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Exchsale)
                    .HasColumnName("EXCHSALE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FairMarketValue).HasColumnName("FAIR_MARKET_VALUE");

                entity.Property(e => e.FederalAssetSalesId).HasColumnName("FEDERAL_ASSET_SALES_ID");

                entity.Property(e => e.FiscalYear)
                    .HasColumnName("FISCAL_YEAR")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FscId).HasColumnName("FSC_ID");

                entity.Property(e => e.FscapCode)
                    .HasColumnName("FSCAP_CODE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.GsaComments)
                    .HasColumnName("GSA_COMMENTS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.GsaRegionCode)
                    .HasColumnName("GSA_REGION_CODE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.GsaSubmitMsg)
                    .HasColumnName("GSA_SUBMIT_MSG")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.GsaSubmitRespNo)
                    .HasColumnName("GSA_SUBMIT_RESP_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GsaSubmitTimeElap)
                    .HasColumnName("GSA_SUBMIT_TIME_ELAP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HazmatCode)
                    .HasColumnName("HAZMAT_CODE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InternalReleaseDate)
                    .HasColumnName("INTERNAL_RELEASE_DATE")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.ItemDescription)
                    .HasColumnName("ITEM_DESCRIPTION")
                    .HasMaxLength(1400)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName)
                    .HasColumnName("ITEM_NAME")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedBy)
                    .IsRequired()
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.LastUpdatedDate)
                    .HasColumnName("LAST_UPDATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.LocationId).HasColumnName("LOCATION_ID");

                entity.Property(e => e.Make)
                    .HasColumnName("MAKE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerComments)
                    .HasColumnName("MANAGER_COMMENTS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ManufacturedDate)
                    .HasColumnName("MANUFACTURED_DATE")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("MANUFACTURER")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MngtDecidedDate)
                    .HasColumnName("MNGT_DECIDED_DATE")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.MngtDecision)
                    .HasColumnName("MNGT_DECISION")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.MngtDecisionId).HasColumnName("MNGT_DECISION_ID");

                entity.Property(e => e.Model)
                    .HasColumnName("MODEL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Niin)
                    .HasColumnName("NIIN")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Ns5RecordNumber)
                    .HasColumnName("NS5_RECORD_NUMBER")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.OverseasInd)
                    .HasColumnName("OVERSEAS_IND")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PartNo)
                    .HasColumnName("PART_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PicturesAvailable)
                    .HasColumnName("PICTURES_AVAILABLE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PlantClCaseNo)
                    .HasColumnName("PLANT_CL_CASE_NO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProceedsRetention)
                    .HasColumnName("PROCEEDS_RETENTION")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PropLocAddr1)
                    .HasColumnName("PROP_LOC_ADDR1")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.PropLocAddr2)
                    .HasColumnName("PROP_LOC_ADDR2")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.PropLocAddr3)
                    .HasColumnName("PROP_LOC_ADDR3")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.PropLocCity)
                    .HasColumnName("PROP_LOC_CITY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PropLocState)
                    .HasColumnName("PROP_LOC_STATE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PropLocZip)
                    .HasColumnName("PROP_LOC_ZIP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Qty).HasColumnName("QTY");

                entity.Property(e => e.ReimbReqd)
                    .HasColumnName("REIMB_REQD")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReimbursementTypeId).HasColumnName("REIMBURSEMENT_TYPE_ID");

                entity.Property(e => e.ReportAgencyId).HasColumnName("REPORT_AGENCY_ID");

                entity.Property(e => e.ReportCancelled)
                    .HasColumnName("REPORT_CANCELLED")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ReportCode)
                    .HasColumnName("REPORT_CODE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReportNumber)
                    .HasColumnName("REPORT_NUMBER")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ReqScrapPickup)
                    .HasColumnName("REQ_SCRAP_PICKUP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShipName)
                    .HasColumnName("SHIP_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialDesCode)
                    .HasColumnName("SPECIAL_DES_CODE")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialDescription)
                    .HasColumnName("SPECIAL_DESCRIPTION")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.StatusCodeId).HasColumnName("STATUS_CODE_ID");

                entity.Property(e => e.SupplyConditionId).HasColumnName("SUPPLY_CONDITION_ID");

                entity.Property(e => e.SurplusReleaseDate)
                    .HasColumnName("SURPLUS_RELEASE_DATE")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.ToEngDate)
                    .HasColumnName("TO_ENG_DATE")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.TransferOrderNumber)
                    .HasColumnName("TRANSFER_ORDER_NUMBER")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCost).HasColumnName("UNIT_COST");

                entity.Property(e => e.UnitOfIssueId).HasColumnName("UNIT_OF_ISSUE_ID");

                entity.Property(e => e.VehicleInfoId).HasColumnName("VEHICLE_INFO_ID");

                entity.Property(e => e.Vessels50FeetOver)
                    .HasColumnName("VESSELS_50_FEET_OVER")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.WarehouseComments)
                    .HasColumnName("WAREHOUSE_COMMENTS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WarehouseRecommendationId).HasColumnName("WAREHOUSE_RECOMMENDATION_ID");
            });

            modelBuilder.Entity<ReportItemHistory>(entity =>
            {
                entity.ToTable("REPORT_ITEM_HISTORY");

                entity.Property(e => e.ReportItemHistoryId).HasColumnName("REPORT_ITEM_HISTORY_ID");

                entity.Property(e => e.AccessLevel)
                    .HasColumnName("ACCESS_LEVEL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AcquisitionDate)
                    .HasColumnName("ACQUISITION_DATE")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.AgencyLocationCode).HasColumnName("AGENCY_LOCATION_CODE");

                entity.Property(e => e.AgyControlNo)
                    .HasColumnName("AGY_CONTROL_NO")
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.Agybur)
                    .HasColumnName("AGYBUR")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.AppropCode)
                    .HasColumnName("APPROP_CODE")
                    .HasMaxLength(48)
                    .IsUnicode(false);

                entity.Property(e => e.CertDestruction)
                    .HasColumnName("CERT_DESTRUCTION")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClLineItemNo).HasColumnName("CL_LINE_ITEM_NO");

                entity.Property(e => e.ClRefNo)
                    .HasColumnName("CL_REF_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cntrinvcd)
                    .HasColumnName("CNTRINVCD")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Completed)
                    .HasColumnName("COMPLETED")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CompletedDate)
                    .HasColumnName("COMPLETED_DATE")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.CountryCode)
                    .HasColumnName("COUNTRY_CODE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.DemilitarizationId).HasColumnName("DEMILITARIZATION_ID");

                entity.Property(e => e.DisposalConditionId).HasColumnName("DISPOSAL_CONDITION_ID");

                entity.Property(e => e.Drmo)
                    .HasColumnName("DRMO")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DropInternalFlag)
                    .HasColumnName("DROP_INTERNAL_FLAG")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EngrComments)
                    .HasColumnName("ENGR_COMMENTS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EngrDecidedDate)
                    .HasColumnName("ENGR_DECIDED_DATE")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.EngrDeision)
                    .HasColumnName("ENGR_DEISION")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExcessRelDate)
                    .HasColumnName("EXCESS_REL_DATE")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Exchsale)
                    .HasColumnName("EXCHSALE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FairMarketValue).HasColumnName("FAIR_MARKET_VALUE");

                entity.Property(e => e.FederalAssetSalesId).HasColumnName("FEDERAL_ASSET_SALES_ID");

                entity.Property(e => e.FiscalYear)
                    .HasColumnName("FISCAL_YEAR")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FscId).HasColumnName("FSC_ID");

                entity.Property(e => e.FscapCode)
                    .HasColumnName("FSCAP_CODE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.GsaComments)
                    .HasColumnName("GSA_COMMENTS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.GsaRegionCode)
                    .HasColumnName("GSA_REGION_CODE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.GsaSubmitMsg)
                    .HasColumnName("GSA_SUBMIT_MSG")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.GsaSubmitRespNo)
                    .HasColumnName("GSA_SUBMIT_RESP_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GsaSubmitTimeElap)
                    .HasColumnName("GSA_SUBMIT_TIME_ELAP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HazmatCode)
                    .HasColumnName("HAZMAT_CODE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InternalReleaseDate)
                    .HasColumnName("INTERNAL_RELEASE_DATE")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.ItemDescription)
                    .HasColumnName("ITEM_DESCRIPTION")
                    .HasMaxLength(1400)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName)
                    .HasColumnName("ITEM_NAME")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedBy)
                    .IsRequired()
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.LastUpdatedDate)
                    .HasColumnName("LAST_UPDATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.LocationId).HasColumnName("LOCATION_ID");

                entity.Property(e => e.Make)
                    .HasColumnName("MAKE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerComments)
                    .HasColumnName("MANAGER_COMMENTS")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ManufacturedDate)
                    .HasColumnName("MANUFACTURED_DATE")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Manufacturer)
                    .HasColumnName("MANUFACTURER")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MngtDecidedDate)
                    .HasColumnName("MNGT_DECIDED_DATE")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.MngtDecision)
                    .HasColumnName("MNGT_DECISION")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.MngtDecisionId).HasColumnName("MNGT_DECISION_ID");

                entity.Property(e => e.Model)
                    .HasColumnName("MODEL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Niin)
                    .HasColumnName("NIIN")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.OverseasInd)
                    .HasColumnName("OVERSEAS_IND")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PartNo)
                    .HasColumnName("PART_NO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PicturesAvailable)
                    .HasColumnName("PICTURES_AVAILABLE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PlantClCaseNo)
                    .HasColumnName("PLANT_CL_CASE_NO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProceedsRetention)
                    .HasColumnName("PROCEEDS_RETENTION")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PropLocAddr1)
                    .HasColumnName("PROP_LOC_ADDR1")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.PropLocAddr2)
                    .HasColumnName("PROP_LOC_ADDR2")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.PropLocAddr3)
                    .HasColumnName("PROP_LOC_ADDR3")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.PropLocCity)
                    .HasColumnName("PROP_LOC_CITY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PropLocState)
                    .HasColumnName("PROP_LOC_STATE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PropLocZip)
                    .HasColumnName("PROP_LOC_ZIP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Qty).HasColumnName("QTY");

                entity.Property(e => e.ReimbReqd)
                    .HasColumnName("REIMB_REQD")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReimbursementTypeId).HasColumnName("REIMBURSEMENT_TYPE_ID");

                entity.Property(e => e.ReportAgencyId).HasColumnName("REPORT_AGENCY_ID");

                entity.Property(e => e.ReportCancelled)
                    .HasColumnName("REPORT_CANCELLED")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReportCode)
                    .HasColumnName("REPORT_CODE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReportItemId).HasColumnName("REPORT_ITEM_ID");

                entity.Property(e => e.ReportNumber)
                    .HasColumnName("REPORT_NUMBER")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ReqScrapPickup)
                    .HasColumnName("REQ_SCRAP_PICKUP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShipName)
                    .HasColumnName("SHIP_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialDesCode)
                    .HasColumnName("SPECIAL_DES_CODE")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialDescription)
                    .HasColumnName("SPECIAL_DESCRIPTION")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.StatusCodeId).HasColumnName("STATUS_CODE_ID");

                entity.Property(e => e.SupplyConditionId).HasColumnName("SUPPLY_CONDITION_ID");

                entity.Property(e => e.SurplusReleaseDate)
                    .HasColumnName("SURPLUS_RELEASE_DATE")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.ToEngDate)
                    .HasColumnName("TO_ENG_DATE")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.UnitCost).HasColumnName("UNIT_COST");

                entity.Property(e => e.UnitOfIssueId).HasColumnName("UNIT_OF_ISSUE_ID");

                entity.Property(e => e.Vessels50FeetOver)
                    .HasColumnName("VESSELS_50_FEET_OVER")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.WarehouseComments)
                    .HasColumnName("WAREHOUSE_COMMENTS")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StatusCode>(entity =>
            {
                entity.ToTable("STATUS_CODE");

                entity.Property(e => e.StatusCodeId).HasColumnName("STATUS_CODE_ID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Deleteflag)
                    .IsRequired()
                    .HasColumnName("DELETEFLAG")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder)
                    .HasColumnName("DISPLAY_ORDER")
                    .HasDefaultValueSql("((99))");

                entity.Property(e => e.LastUpdatedBy)
                    .IsRequired()
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.LastUpdatedDate)
                    .HasColumnName("LAST_UPDATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SupplyCondition>(entity =>
            {
                entity.ToTable("SUPPLY_CONDITION");

                entity.HasIndex(e => e.Name)
                    .HasName("UK_SUPPLY_CONDITION_NAME")
                    .IsUnique();

                entity.Property(e => e.SupplyConditionId).HasColumnName("SUPPLY_CONDITION_ID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Deleteflag)
                    .IsRequired()
                    .HasColumnName("DELETEFLAG")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder)
                    .HasColumnName("DISPLAY_ORDER")
                    .HasDefaultValueSql("((99))");

                entity.Property(e => e.LastUpdatedBy)
                    .IsRequired()
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.LastUpdatedDate)
                    .HasColumnName("LAST_UPDATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TrailerInfo>(entity =>
            {
                entity.HasKey(e => e.ReportItemId);

                entity.ToTable("TRAILER_INFO");

                entity.Property(e => e.ReportItemId)
                    .HasColumnName("REPORT_ITEM_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Barcode)
                    .HasColumnName("BARCODE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.LastUpdatedBy)
                    .IsRequired()
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.LastUpdatedDate)
                    .HasColumnName("LAST_UPDATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Length).HasColumnName("LENGTH");

                entity.Property(e => e.NoAxles).HasColumnName("NO_AXLES");

                entity.Property(e => e.NoBaths).HasColumnName("NO_BATHS");

                entity.Property(e => e.NoBedrooms).HasColumnName("NO_BEDROOMS");

                entity.Property(e => e.TypeAwning)
                    .HasColumnName("TYPE_AWNING")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TypeSlideOut)
                    .HasColumnName("TYPE_SLIDE_OUT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.WindZone).HasColumnName("WIND_ZONE");

                entity.HasOne(d => d.ReportItem)
                    .WithOne(p => p.TrailerInfo)
                    .HasForeignKey<TrailerInfo>(d => d.ReportItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REPORTITEM_TRAILERINFO");
            });

            modelBuilder.Entity<UnitOfIssue>(entity =>
            {
                entity.ToTable("UNIT_OF_ISSUE");

                entity.HasIndex(e => new { e.UnitOfIssueId, e.Name })
                    .HasName("UK_UNIT_OF_ISSUE_NAME")
                    .IsUnique();

                entity.Property(e => e.UnitOfIssueId).HasColumnName("UNIT_OF_ISSUE_ID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Deleteflag)
                    .IsRequired()
                    .HasColumnName("DELETEFLAG")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder)
                    .HasColumnName("DISPLAY_ORDER")
                    .HasDefaultValueSql("((99))");

                entity.Property(e => e.LastUpdatedBy)
                    .IsRequired()
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.LastUpdatedDate)
                    .HasColumnName("LAST_UPDATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VehicleColor>(entity =>
            {
                entity.ToTable("VEHICLE_COLOR");

                entity.HasIndex(e => e.Name)
                    .HasName("UK_VEHICLE_COLOR_NAME")
                    .IsUnique();

                entity.Property(e => e.VehicleColorId).HasColumnName("VEHICLE_COLOR_ID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Deleteflag)
                    .IsRequired()
                    .HasColumnName("DELETEFLAG")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder)
                    .HasColumnName("DISPLAY_ORDER")
                    .HasDefaultValueSql("((99))");

                entity.Property(e => e.LastUpdatedBy)
                    .IsRequired()
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.LastUpdatedDate)
                    .HasColumnName("LAST_UPDATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VehicleInfo>(entity =>
            {
                entity.ToTable("VEHICLE_INFO");

                entity.Property(e => e.VehicleInfoId).HasColumnName("VEHICLE_INFO_ID");

                entity.Property(e => e.AgencyClass)
                    .HasColumnName("AGENCY_CLASS")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.BodyStyleId).HasColumnName("BODY_STYLE_ID");

                entity.Property(e => e.ColorGradientId).HasColumnName("COLOR_GRADIENT_ID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.EstMileage)
                    .HasColumnName("EST_MILEAGE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FuelTypeId).HasColumnName("FUEL_TYPE_ID");

                entity.Property(e => e.LastUpdatedBy)
                    .IsRequired()
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.LastUpdatedDate)
                    .HasColumnName("LAST_UPDATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.ModelYear).HasColumnName("MODEL_YEAR");

                entity.Property(e => e.NoCylinders).HasColumnName("NO_CYLINDERS");

                entity.Property(e => e.NoOfCylindersId).HasColumnName("NO_OF_CYLINDERS_ID");

                entity.Property(e => e.Transmission)
                    .HasColumnName("TRANSMISSION")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleColorId).HasColumnName("VEHICLE_COLOR_ID");

                entity.Property(e => e.VehicleIdNumber)
                    .HasColumnName("VEHICLE_ID_NUMBER")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleTag)
                    .HasColumnName("VEHICLE_TAG")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.BodyStyle)
                    .WithMany(p => p.VehicleInfo)
                    .HasForeignKey(d => d.BodyStyleId)
                    .HasConstraintName("FK_BODYSTYLE_VEHICLEINFO");

                entity.HasOne(d => d.ColorGradient)
                    .WithMany(p => p.VehicleInfo)
                    .HasForeignKey(d => d.ColorGradientId)
                    .HasConstraintName("FK_COLORGRADIENT_VEHICLEINFO");

                entity.HasOne(d => d.FuelType)
                    .WithMany(p => p.VehicleInfo)
                    .HasForeignKey(d => d.FuelTypeId)
                    .HasConstraintName("FK_FUELTYPE_VEHICLEINFO");

                entity.HasOne(d => d.NoOfCylinders)
                    .WithMany(p => p.VehicleInfo)
                    .HasForeignKey(d => d.NoOfCylindersId)
                    .HasConstraintName("FK_NO_OF_CYLINDERS");

                entity.HasOne(d => d.VehicleColor)
                    .WithMany(p => p.VehicleInfo)
                    .HasForeignKey(d => d.VehicleColorId)
                    .HasConstraintName("FK_VEHICLECOLOR_VEHICLEINFO");
            });

            modelBuilder.Entity<WarehouseRecommendation>(entity =>
            {
                entity.ToTable("WAREHOUSE_RECOMMENDATION");

                entity.HasIndex(e => e.Name)
                    .HasName("UK_WAREHOUSE_RECOMMENDATION")
                    .IsUnique();

                entity.Property(e => e.WarehouseRecommendationId).HasColumnName("WAREHOUSE_RECOMMENDATION_ID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Deleteflag)
                    .IsRequired()
                    .HasColumnName("DELETEFLAG")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder)
                    .HasColumnName("DISPLAY_ORDER")
                    .HasDefaultValueSql("((99))");

                entity.Property(e => e.LastUpdatedBy)
                    .IsRequired()
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.LastUpdatedDate)
                    .HasColumnName("LAST_UPDATED_DATE")
                    .HasColumnType("datetime2(6)")
                    .HasDefaultValueSql("(sysdatetimeoffset())");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
