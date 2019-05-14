﻿// <auto-generated />
using System;
using EsportEventBelgium.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EsportEventBelgium.Migrations
{
    [DbContext(typeof(EsportEventContext))]
    partial class EsportEventContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EsportEventBelgium.Entities.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BeginDate");

                    b.Property<string>("Description");

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("Name");

                    b.Property<int?>("OrganizationId");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("EsportEventBelgium.Entities.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EventId");

                    b.Property<string>("Genre");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("EsportEventBelgium.Entities.Organization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<string>("UrlWebsite");

                    b.HasKey("Id");

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("EsportEventBelgium.Entities.Event", b =>
                {
                    b.HasOne("EsportEventBelgium.Entities.Organization", "Organization")
                        .WithMany("Events")
                        .HasForeignKey("OrganizationId");
                });

            modelBuilder.Entity("EsportEventBelgium.Entities.Game", b =>
                {
                    b.HasOne("EsportEventBelgium.Entities.Event")
                        .WithMany("Games")
                        .HasForeignKey("EventId");
                });
#pragma warning restore 612, 618
        }
    }
}
