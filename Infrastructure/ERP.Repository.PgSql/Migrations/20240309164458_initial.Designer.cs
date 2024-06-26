﻿// <auto-generated />
using ERP.Repository.PgSql;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ERP.Repository.PgSql.Migrations
{
    [DbContext(typeof(PgSqlDbContext))]
    [Migration("20240309164458_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ERP.Domain.Core.Entity.Request", b =>
                {
                    b.Property<int>("RequestID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RequestID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ReceiverAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RegNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SenderAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("RequestID");

                    b.ToTable("Requests");
                });
#pragma warning restore 612, 618
        }
    }
}
