using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using data;

namespace data.Migrations
{
    [DbContext(typeof(ProcessImprovementContext))]
    [Migration("20170706183846_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("model.Innovation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Innovations");
                });

            modelBuilder.Entity("model.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("InnovationId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("InnovationId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("model.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("model.Innovation", b =>
                {
                    b.HasOne("model.User", "User")
                        .WithMany("Innovations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("model.Task", b =>
                {
                    b.HasOne("model.Innovation", "Innovation")
                        .WithMany("Tasks")
                        .HasForeignKey("InnovationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
