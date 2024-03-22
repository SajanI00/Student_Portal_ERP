﻿// <auto-generated />
using System;
using ERP.Repository.PgSql;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ERP.Repository.PgSql.Migrations
{
    [DbContext(typeof(PgSqlDbContext))]
    partial class PgSqlDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ERP.Domain.Core.Entity.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CommunicationRating")
                        .HasColumnType("integer");

                    b.Property<int>("ConceptRating")
                        .HasColumnType("integer");

                    b.Property<int>("CoverageRating")
                        .HasColumnType("integer");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ExamplesRating")
                        .HasColumnType("integer");

                    b.Property<int>("ExplanationClarityRating")
                        .HasColumnType("integer");

                    b.Property<int>("InteractionRating")
                        .HasColumnType("integer");

                    b.Property<int>("LectureContentRating")
                        .HasColumnType("integer");

                    b.Property<int>("LectureEngagementRating")
                        .HasColumnType("integer");

                    b.Property<int>("LectureOrganizationRating")
                        .HasColumnType("integer");

                    b.Property<string>("LecturerName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ModuleName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("OverallFeedback")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PaceRating")
                        .HasColumnType("integer");

                    b.Property<int>("ParticipationRating")
                        .HasColumnType("integer");

                    b.Property<int>("RealWorldApplicationsRating")
                        .HasColumnType("integer");

                    b.Property<int>("RelevanceToCourseRating")
                        .HasColumnType("integer");

                    b.Property<string>("Semester")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("SummaryEffectivenessRating")
                        .HasColumnType("integer");

                    b.Property<int>("VisualAidsRating")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.MessageInfo", b =>
                {
                    b.Property<int>("MessageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("MessageID"));

                    b.Property<string>("AnnouncementType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Receiver")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Sender")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("MessageID");

                    b.ToTable("Announcements");
                });

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
