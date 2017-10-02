using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using data;

namespace data.Migrations
{
    [DbContext(typeof(ProcessImprovementContext))]
    [Migration("20171001213317_Modify_state_table_again")]
    partial class Modify_state_table_again
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("model.ActionPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Completed");

                    b.Property<DateTime>("Due");

                    b.Property<int>("InnovationId");

                    b.Property<string>("Name");

                    b.Property<int>("StatusId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("InnovationId");

                    b.HasIndex("StatusId");

                    b.HasIndex("UserId");

                    b.ToTable("ActionPlans");
                });

            modelBuilder.Entity("model.Brainstorm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("InnovationId");

                    b.HasKey("Id");

                    b.HasIndex("InnovationId");

                    b.ToTable("Brainstorms");
                });

            modelBuilder.Entity("model.BrainstormFile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BrainstormFileTypeId");

                    b.Property<int?>("BrainstormId");

                    b.Property<int>("DocId");

                    b.Property<string>("Expectation");

                    b.HasKey("Id");

                    b.HasIndex("BrainstormFileTypeId");

                    b.HasIndex("BrainstormId");

                    b.HasIndex("DocId");

                    b.ToTable("BrainstormFiles");
                });

            modelBuilder.Entity("model.BrainstormFileType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("BrainstormFileTypes");
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

                    b.Property<string>("Url");

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

            modelBuilder.Entity("model.LessonLearned", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("InnovationId");

                    b.Property<string>("NotWorked");

                    b.Property<string>("Other");

                    b.Property<string>("Worked");

                    b.HasKey("Id");

                    b.HasIndex("InnovationId");

                    b.ToTable("LessonsLearned");
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

                    b.Property<int>("InnovationId");

                    b.HasKey("Id");

                    b.HasIndex("InnovationId");

                    b.ToTable("Results");
                });

            modelBuilder.Entity("model.ResultEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CurrentState");

                    b.Property<DateTime>("Date");

                    b.Property<int>("Goal");

                    b.Property<int>("Ninety");

                    b.Property<int>("ResultEntryTypeId");

                    b.Property<int>("ResultId");

                    b.Property<int>("Sixty");

                    b.Property<int>("Thirty");

                    b.HasKey("Id");

                    b.HasIndex("ResultEntryTypeId");

                    b.HasIndex("ResultId");

                    b.ToTable("ResultEntries");
                });

            modelBuilder.Entity("model.ResultEntryType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("ResultEntryTypes");
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

            modelBuilder.Entity("model.Solution", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("InnovationId");

                    b.HasKey("Id");

                    b.HasIndex("InnovationId");

                    b.ToTable("Solutions");
                });

            modelBuilder.Entity("model.SolutionFile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DocId");

                    b.Property<string>("Expectation");

                    b.Property<int>("SolutionFileTypeId");

                    b.Property<int?>("SolutionId");

                    b.HasKey("Id");

                    b.HasIndex("DocId");

                    b.HasIndex("SolutionFileTypeId");

                    b.HasIndex("SolutionId");

                    b.ToTable("SolutionFiles");
                });

            modelBuilder.Entity("model.SolutionFileType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("SolutionFileTypes");
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

                    b.Property<int>("CustSatisfied");

                    b.Property<int>("EmpSatisfied");

                    b.Property<int>("Handoffs");

                    b.Property<int>("InnovationId");

                    b.Property<int>("Provided");

                    b.Property<int>("ProvidedMeasure");

                    b.Property<int>("StateTypeId");

                    b.Property<int>("TimeTaken");

                    b.Property<int>("TimeTakenMeasure");

                    b.Property<int>("WidgetId");

                    b.HasKey("Id");

                    b.HasIndex("InnovationId");

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

            modelBuilder.Entity("model.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Status");
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

            modelBuilder.Entity("model.ActionPlan", b =>
                {
                    b.HasOne("model.Innovation", "Innovation")
                        .WithMany()
                        .HasForeignKey("InnovationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("model.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("model.User", "AssignedTo")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("model.Brainstorm", b =>
                {
                    b.HasOne("model.Innovation", "Innovation")
                        .WithMany()
                        .HasForeignKey("InnovationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("model.BrainstormFile", b =>
                {
                    b.HasOne("model.BrainstormFileType", "BrainstormFileType")
                        .WithMany()
                        .HasForeignKey("BrainstormFileTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("model.Brainstorm", "Brainstorm")
                        .WithMany("BrainstormFiles")
                        .HasForeignKey("BrainstormId");

                    b.HasOne("model.Doc", "Doc")
                        .WithMany()
                        .HasForeignKey("DocId")
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

            modelBuilder.Entity("model.LessonLearned", b =>
                {
                    b.HasOne("model.Innovation", "Innovation")
                        .WithMany()
                        .HasForeignKey("InnovationId")
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

            modelBuilder.Entity("model.Result", b =>
                {
                    b.HasOne("model.Innovation", "Innovation")
                        .WithMany()
                        .HasForeignKey("InnovationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("model.ResultEntry", b =>
                {
                    b.HasOne("model.ResultEntryType", "ResultEntryType")
                        .WithMany()
                        .HasForeignKey("ResultEntryTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("model.Result", "Result")
                        .WithMany("ResultEntries")
                        .HasForeignKey("ResultId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("model.RootCauseAnalysis", b =>
                {
                    b.HasOne("model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("model.Solution", b =>
                {
                    b.HasOne("model.Innovation", "Innovation")
                        .WithMany()
                        .HasForeignKey("InnovationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("model.SolutionFile", b =>
                {
                    b.HasOne("model.Doc", "Doc")
                        .WithMany()
                        .HasForeignKey("DocId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("model.SolutionFileType", "SolutionFileType")
                        .WithMany()
                        .HasForeignKey("SolutionFileTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("model.Solution")
                        .WithMany("SolutionFiles")
                        .HasForeignKey("SolutionId");
                });

            modelBuilder.Entity("model.State", b =>
                {
                    b.HasOne("model.Innovation", "Innovation")
                        .WithMany()
                        .HasForeignKey("InnovationId")
                        .OnDelete(DeleteBehavior.Cascade);

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
