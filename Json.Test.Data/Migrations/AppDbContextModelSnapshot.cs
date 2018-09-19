﻿// <auto-generated />
using System;
using Json.Test.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Json.Test.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Json.Test.Data.Models.FieldWork", b =>
                {
                    b.Property<long>("FieldWorkId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTimeOffset>("FieldCompletionDateTime");

                    b.HasKey("FieldWorkId");

                    b.ToTable("FieldWork");

                    b.HasDiscriminator<string>("Discriminator").HasValue("FieldWork");
                });

            modelBuilder.Entity("Json.Test.Data.Models.Inspection", b =>
                {
                    b.Property<long>("InspectionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<long?>("ParentFieldWorkFieldWorkId");

                    b.Property<string>("_MetaData");

                    b.HasKey("InspectionId");

                    b.HasIndex("ParentFieldWorkFieldWorkId");

                    b.ToTable("Inspection");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Inspection");
                });

            modelBuilder.Entity("Json.Test.Data.Models.ElectricMeterExchange", b =>
                {
                    b.HasBaseType("Json.Test.Data.Models.FieldWork");

                    b.Property<string>("MeterVoltage")
                        .HasMaxLength(20);

                    b.ToTable("ElectricMeterExchange");

                    b.HasDiscriminator().HasValue("ElectricMeterExchange");
                });

            modelBuilder.Entity("Json.Test.Data.Models.GasRetrofit", b =>
                {
                    b.HasBaseType("Json.Test.Data.Models.FieldWork");

                    b.Property<int?>("NumberOfDials");

                    b.ToTable("GasRetrofit");

                    b.HasDiscriminator().HasValue("GasRetrofit");
                });

            modelBuilder.Entity("Json.Test.Data.Models.LiveAudit", b =>
                {
                    b.HasBaseType("Json.Test.Data.Models.Inspection");

                    b.Property<bool?>("LiveAuditQuestion1");

                    b.Property<bool?>("LiveAuditQuestion2");

                    b.ToTable("LiveAudit");

                    b.HasDiscriminator().HasValue("LiveAudit");
                });

            modelBuilder.Entity("Json.Test.Data.Models.PostInstallAudit", b =>
                {
                    b.HasBaseType("Json.Test.Data.Models.Inspection");

                    b.Property<bool?>("PostInstallQuestion1");

                    b.Property<bool?>("PostInstallQuestion2");

                    b.ToTable("PostInstallAudit");

                    b.HasDiscriminator().HasValue("PostInstallAudit");
                });

            modelBuilder.Entity("Json.Test.Data.Models.Inspection", b =>
                {
                    b.HasOne("Json.Test.Data.Models.FieldWork", "ParentFieldWork")
                        .WithMany("Inspections")
                        .HasForeignKey("ParentFieldWorkFieldWorkId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
