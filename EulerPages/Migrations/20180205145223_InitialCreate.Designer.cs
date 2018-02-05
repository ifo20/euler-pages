﻿// <auto-generated />
using EulerPages.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using EulerPages.Data;

namespace EulerPages.Migrations
{
    [DbContext(typeof(ProblemContext))]
    [Migration("20180205145223_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EulerPages.Models.Problem", b =>
                {
                    b.Property<int>("ProblemId");

                    b.Property<int?>("Answer");

                    b.Property<string>("Question");

                    b.Property<string>("Title");

                    b.HasKey("ProblemId");

                    b.ToTable("Problems");
                });

            modelBuilder.Entity("EulerPages.Models.Solution", b =>
                {
                    b.Property<int>("SolutionId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ProblemId");

                    b.Property<string>("Text");

                    b.HasKey("SolutionId");

                    b.HasIndex("ProblemId");

                    b.ToTable("Solutions");
                });

            modelBuilder.Entity("EulerPages.Models.Solution", b =>
                {
                    b.HasOne("EulerPages.Models.Problem", "Problem")
                        .WithMany("Solutions")
                        .HasForeignKey("ProblemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
