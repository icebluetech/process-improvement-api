using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using data;

namespace data.Migrations
{
    [DbContext(typeof(ProcessImprovementContext))]
    [Migration("20170723230900_docs fk with innovation")]
    partial class docsfkwithinnovation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("model.Celebrate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("InnovationId");

                    b.HasKey("Id");

                    b.HasIndex("InnovationId");

                    b.ToTable("Celebrates");
                });

            modelBuilder.Entity("model.Doc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("InnovationId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("InnovationId");

                    b.ToTable("Docs");
                });

            modelBuilder.Entity("model.Experiment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CompletionDate");

                    b.Property<string>("Status");

                    b.Property<string>("What");

                    b.Property<string>("When");

                    b.Property<string>("Who");

                    b.HasKey("Id");

                    b.ToTable("Experiments");
                });

            modelBuilder.Entity("model.Innovation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CurrentState");

                    b.Property<DateTime>("Date");

                    b.Property<string>("FutureState");

                    b.Property<int>("InnovationCategoryId");

                    b.Property<int>("InnovationTypeId");

                    b.Property<int?>("RootCauseAnalysisId");

                    b.Property<string>("Title");

                    b.Property<string>("Why");

                    b.HasKey("Id");

                    b.HasIndex("InnovationCategoryId");

                    b.HasIndex("InnovationTypeId");

                    b.HasIndex("RootCauseAnalysisId");

                    b.ToTable("Innovations");
                });

            modelBuilder.Entity("model.InnovationCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("InnovationCategories");
                });

            modelBuilder.Entity("model.InnovationType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("InnovationTypes");
                });

            modelBuilder.Entity("model.InnovationUser", b =>
                {
                    b.Property<int>("InnovationId");

                    b.Property<int>("UserId");

                    b.Property<string>("Type");

                    b.HasKey("InnovationId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("InnovationUsers");
                });

            modelBuilder.Entity("model.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("InnovationId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("InnovationId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("model.Result", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<int>("Number");

                    b.Property<decimal>("Percentage");

                    b.Property<string>("TimeUnit");

                    b.HasKey("Id");

                    b.ToTable("Results");
                });

            modelBuilder.Entity("model.RootCauseAnalysis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Tool");

                    b.HasKey("Id");

                    b.ToTable("RootCauseAnalysies");
                });

            modelBuilder.Entity("model.StandardWork", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Notes");

                    b.HasKey("Id");

                    b.ToTable("StandardWorks");
                });

            modelBuilder.Entity("model.Tool", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Tools");
                });

            modelBuilder.Entity("model.Training", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("ApprovalNeeded");

                    b.Property<bool>("Completed");

                    b.Property<string>("Name");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Trainings");
                });

            modelBuilder.Entity("model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("model.Celebrate", b =>
                {
                    b.HasOne("model.Innovation", "Innovation")
                        .WithMany()
                        .HasForeignKey("InnovationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("model.Doc", b =>
                {
                    b.HasOne("model.Innovation", "Innovation")
                        .WithMany("Docs")
                        .HasForeignKey("InnovationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("model.Innovation", b =>
                {
                    b.HasOne("model.InnovationCategory", "Category")
                        .WithMany()
                        .HasForeignKey("InnovationCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("model.InnovationType", "Type")
                        .WithMany()
                        .HasForeignKey("InnovationTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("model.RootCauseAnalysis", "RootCauseAnalysis")
                        .WithMany()
                        .HasForeignKey("RootCauseAnalysisId");
                });

            modelBuilder.Entity("model.InnovationUser", b =>
                {
                    b.HasOne("model.Innovation", "Innovation")
                        .WithMany("InnovationUsers")
                        .HasForeignKey("InnovationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("model.User", "User")
                        .WithMany("InnovationUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("model.Notification", b =>
                {
                    b.HasOne("model.Innovation", "Innovation")
                        .WithMany("Notifications")
                        .HasForeignKey("InnovationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("model.Training", b =>
                {
                    b.HasOne("model.User")
                        .WithMany("Trainings")
                        .HasForeignKey("UserId");
                });
        }
    }
}
