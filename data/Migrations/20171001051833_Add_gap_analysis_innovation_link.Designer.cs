using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using data;

namespace data.Migrations
{
    [DbContext(typeof(ProcessImprovementContext))]
    [Migration("20171001051833_Add_gap_analysis_innovation_link")]
    partial class Add_gap_analysis_innovation_link
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("model.Brainstorm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Impact");

                    b.Property<int>("InnovationId");

                    b.Property<string>("LevelOfEffort");

                    b.Property<string>("Title");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("InnovationId");

                    b.HasIndex("UserId");

                    b.ToTable("Brainstorms");
                });

            modelBuilder.Entity("model.Celebrate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("InnovationId");

                    b.HasKey("Id");

                    b.HasIndex("InnovationId");

                    b.ToTable("Celebrates");
                });

            modelBuilder.Entity("model.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Departments");
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

                    b.Property<int>("InnovationId");

                    b.Property<string>("Status");

                    b.Property<int>("UserId");

                    b.Property<string>("What");

                    b.Property<string>("When");

                    b.Property<string>("Who");

                    b.HasKey("Id");

                    b.HasIndex("InnovationId");

                    b.HasIndex("UserId");

                    b.ToTable("Experiments");
                });

            modelBuilder.Entity("model.GapAnalysis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("InnovationId");

                    b.Property<int>("NVA");

                    b.Property<int>("NonValueHold");

                    b.Property<string>("Url");

                    b.Property<int>("ValueHold");

                    b.Property<int>("WasteTypeId");

                    b.HasKey("Id");

                    b.HasIndex("InnovationId");

                    b.HasIndex("WasteTypeId");

                    b.ToTable("GapAnalysis");
                });

            modelBuilder.Entity("model.Innovation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CurrentState");

                    b.Property<DateTime>("Date");

                    b.Property<int?>("DepartmentId");

                    b.Property<string>("FutureState");

                    b.Property<int>("InnovationCategoryId");

                    b.Property<int>("InnovationTypeId");

                    b.Property<int?>("ProcessId");

                    b.Property<int?>("RootCauseAnalysisId");

                    b.Property<string>("Title");

                    b.Property<string>("Why");

                    b.Property<int?>("WidgetId");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("InnovationCategoryId");

                    b.HasIndex("InnovationTypeId");

                    b.HasIndex("ProcessId");

                    b.HasIndex("RootCauseAnalysisId");

                    b.HasIndex("WidgetId");

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
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("InnovationId");

                    b.Property<int>("UserId");

                    b.Property<int>("UserRoleId");

                    b.HasKey("Id");

                    b.HasIndex("InnovationId");

                    b.HasIndex("UserId");

                    b.HasIndex("UserRoleId");

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

            modelBuilder.Entity("model.Process", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Processes");
                });

            modelBuilder.Entity("model.ReasonForAction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("InnovationId");

                    b.Property<string>("Reason");

                    b.HasKey("Id");

                    b.HasIndex("InnovationId");

                    b.ToTable("ReasonForActions");
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

                    b.Property<string>("Description");

                    b.Property<string>("Tool");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

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

            modelBuilder.Entity("model.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Approvals");

                    b.Property<int>("BacklogNumber");

                    b.Property<int>("BacklogWork");

                    b.Property<int>("Correct");

                    b.Property<int>("Handoffs");

                    b.Property<int>("Provided");

                    b.Property<int>("Satisfied");

                    b.Property<int>("StateTypeId");

                    b.Property<int>("TimeTaken");

                    b.Property<int>("WidgetId");

                    b.HasKey("Id");

                    b.HasIndex("StateTypeId");

                    b.HasIndex("WidgetId");

                    b.ToTable("States");
                });

            modelBuilder.Entity("model.StateType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("StateTypes");
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

                    b.Property<int>("UserRoleId");

                    b.Property<string>("avatar");

                    b.HasKey("Id");

                    b.HasIndex("UserRoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("model.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("model.WasteType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("WasteTypes");
                });

            modelBuilder.Entity("model.Widget", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Widgets");
                });

            modelBuilder.Entity("model.Brainstorm", b =>
                {
                    b.HasOne("model.Innovation", "Innovation")
                        .WithMany()
                        .HasForeignKey("InnovationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
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

            modelBuilder.Entity("model.Experiment", b =>
                {
                    b.HasOne("model.Innovation", "Innovation")
                        .WithMany()
                        .HasForeignKey("InnovationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("model.GapAnalysis", b =>
                {
                    b.HasOne("model.Innovation", "Innovation")
                        .WithMany()
                        .HasForeignKey("InnovationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("model.WasteType", "WasteType")
                        .WithMany()
                        .HasForeignKey("WasteTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("model.Innovation", b =>
                {
                    b.HasOne("model.Department", "PrimaryDepartment")
                        .WithMany()
                        .HasForeignKey("DepartmentId");

                    b.HasOne("model.InnovationCategory", "Category")
                        .WithMany()
                        .HasForeignKey("InnovationCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("model.InnovationType", "InnovationType")
                        .WithMany()
                        .HasForeignKey("InnovationTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("model.Process", "Process")
                        .WithMany()
                        .HasForeignKey("ProcessId");

                    b.HasOne("model.RootCauseAnalysis", "RootCauseAnalysis")
                        .WithMany()
                        .HasForeignKey("RootCauseAnalysisId");

                    b.HasOne("model.Widget", "Widget")
                        .WithMany()
                        .HasForeignKey("WidgetId");
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

                    b.HasOne("model.UserRole", "UserRole")
                        .WithMany()
                        .HasForeignKey("UserRoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("model.Notification", b =>
                {
                    b.HasOne("model.Innovation", "Innovation")
                        .WithMany("Notifications")
                        .HasForeignKey("InnovationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("model.ReasonForAction", b =>
                {
                    b.HasOne("model.Innovation", "Innovation")
                        .WithMany()
                        .HasForeignKey("InnovationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("model.RootCauseAnalysis", b =>
                {
                    b.HasOne("model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("model.State", b =>
                {
                    b.HasOne("model.StateType", "StateType")
                        .WithMany()
                        .HasForeignKey("StateTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("model.Widget", "Widget")
                        .WithMany()
                        .HasForeignKey("WidgetId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("model.Training", b =>
                {
                    b.HasOne("model.User")
                        .WithMany("Trainings")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("model.User", b =>
                {
                    b.HasOne("model.UserRole", "UserRole")
                        .WithMany()
                        .HasForeignKey("UserRoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
