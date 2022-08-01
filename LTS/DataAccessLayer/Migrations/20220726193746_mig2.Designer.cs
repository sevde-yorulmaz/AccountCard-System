﻿// <auto-generated />
using DataAccessLayer.Concrete.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220726193746_mig2")]
    partial class mig2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityLayer.Concrete.AccountCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountCardGroupId")
                        .HasColumnType("int");

                    b.Property<int>("AccountCardKindId")
                        .HasColumnType("int");

                    b.Property<int>("AccountCardSubGroupId")
                        .HasColumnType("int");

                    b.Property<int>("AccountCardTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Degree")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("TCNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaxAdministration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaxNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AccountCardGroupId");

                    b.HasIndex("AccountCardKindId");

                    b.HasIndex("AccountCardSubGroupId");

                    b.HasIndex("AccountCardTypeId");

                    b.ToTable("AccountCards");
                });

            modelBuilder.Entity("EntityLayer.Concrete.AccountCardGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GroupName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("AccountCardGroups");
                });

            modelBuilder.Entity("EntityLayer.Concrete.AccountCardKind", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KindName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("AccountCardKinds");
                });

            modelBuilder.Entity("EntityLayer.Concrete.AccountCardSubGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountCardGroupId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("AccountCardGroupId");

                    b.ToTable("AccountCardSubGroups");
                });

            modelBuilder.Entity("EntityLayer.Concrete.AccountCardType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("TypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AccountCardTypes");
                });

            modelBuilder.Entity("EntityLayer.Concrete.AccountCard", b =>
                {
                    b.HasOne("EntityLayer.Concrete.AccountCardGroup", "AccountCardGroup")
                        .WithMany("AccountCard")
                        .HasForeignKey("AccountCardGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.AccountCardKind", "AccountCardKind")
                        .WithMany("AccountCard")
                        .HasForeignKey("AccountCardKindId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.AccountCardSubGroup", "AccountCardSubGroup")
                        .WithMany("AccountCard")
                        .HasForeignKey("AccountCardSubGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.AccountCardType", "AccountCardType")
                        .WithMany("AccountCard")
                        .HasForeignKey("AccountCardTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccountCardGroup");

                    b.Navigation("AccountCardKind");

                    b.Navigation("AccountCardSubGroup");

                    b.Navigation("AccountCardType");
                });

            modelBuilder.Entity("EntityLayer.Concrete.AccountCardSubGroup", b =>
                {
                    b.HasOne("EntityLayer.Concrete.AccountCardGroup", "AccountCardGroup")
                        .WithMany("AccountCardSubGroup")
                        .HasForeignKey("AccountCardGroupId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("AccountCardGroup");
                });

            modelBuilder.Entity("EntityLayer.Concrete.AccountCardGroup", b =>
                {
                    b.Navigation("AccountCard");

                    b.Navigation("AccountCardSubGroup");
                });

            modelBuilder.Entity("EntityLayer.Concrete.AccountCardKind", b =>
                {
                    b.Navigation("AccountCard");
                });

            modelBuilder.Entity("EntityLayer.Concrete.AccountCardSubGroup", b =>
                {
                    b.Navigation("AccountCard");
                });

            modelBuilder.Entity("EntityLayer.Concrete.AccountCardType", b =>
                {
                    b.Navigation("AccountCard");
                });
#pragma warning restore 612, 618
        }
    }
}
