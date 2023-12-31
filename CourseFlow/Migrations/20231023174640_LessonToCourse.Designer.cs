﻿// <auto-generated />
using System;
using CourseFlow.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CourseFlow.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231023174640_LessonToCourse")]
    partial class LessonToCourse
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CourseFlow.Models.AuthorCourses", b =>
                {
                    b.Property<Guid>("AuthorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AuthorId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("AuthorCourses");
                });

            modelBuilder.Entity("CourseFlow.Models.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ebd9ed87-e1f3-4523-94af-514b25ce3a60"),
                            Name = "Web Development"
                        },
                        new
                        {
                            Id = new Guid("7c0a0e60-cb5f-4f85-80b0-d5157b04fa18"),
                            Name = "Mobile App Development"
                        },
                        new
                        {
                            Id = new Guid("92a56c79-6e0e-4b87-8aed-97eaff5064f0"),
                            Name = "Game Development"
                        },
                        new
                        {
                            Id = new Guid("c6c0056d-3131-4ff0-b784-9fec81c5bc29"),
                            Name = "Database Management"
                        },
                        new
                        {
                            Id = new Guid("673bb9e5-10fc-4cce-8758-77a6d006cf9c"),
                            Name = "DevOps"
                        },
                        new
                        {
                            Id = new Guid("7c6e8ef0-f3c2-47bc-ad43-13bc2f1c8152"),
                            Name = "Machine Learning"
                        },
                        new
                        {
                            Id = new Guid("3165af8e-bd52-4212-bd4a-617546ae20b5"),
                            Name = "Artificial Intelligence"
                        },
                        new
                        {
                            Id = new Guid("65450d48-5a8b-4f74-9bb6-41a17e49b2d2"),
                            Name = "Data Science"
                        },
                        new
                        {
                            Id = new Guid("37892b77-0396-4ed6-bf34-bbc81994f957"),
                            Name = "Cloud Computing"
                        },
                        new
                        {
                            Id = new Guid("18cf13b7-0ab2-4f48-af39-ee443e502beb"),
                            Name = "Cybersecurity"
                        },
                        new
                        {
                            Id = new Guid("4852ac20-64c8-49f1-a58b-c08a6a24044b"),
                            Name = "Frontend Development"
                        },
                        new
                        {
                            Id = new Guid("c9deea3f-6c53-4cbf-a475-45ac4458a024"),
                            Name = "Backend Development"
                        },
                        new
                        {
                            Id = new Guid("8250e188-5d43-4066-94b1-8d8ead5f22e5"),
                            Name = "Full Stack Development"
                        },
                        new
                        {
                            Id = new Guid("769a9c34-9bfc-4c67-bc3f-092bcf7fcd0d"),
                            Name = "UI/UX Design"
                        },
                        new
                        {
                            Id = new Guid("d146f0ef-f69e-4ab5-917c-3cfe87318f65"),
                            Name = "Version Control"
                        },
                        new
                        {
                            Id = new Guid("cbe62b7e-032a-422a-9660-fc3c7abe3f12"),
                            Name = "Agile Methodology"
                        },
                        new
                        {
                            Id = new Guid("018c3b7d-5be8-42a2-918c-bc41ae7a5f47"),
                            Name = "Software Testing"
                        },
                        new
                        {
                            Id = new Guid("1ca6b9d2-8ef7-4c26-b866-8a691f9af4f9"),
                            Name = "Continuous Integration"
                        },
                        new
                        {
                            Id = new Guid("ff97c78a-eedb-4b2c-bb4b-bd9db654752d"),
                            Name = "API Development"
                        },
                        new
                        {
                            Id = new Guid("f3987c5c-6c82-49d1-b65b-4f83b219b76e"),
                            Name = "Microservices"
                        },
                        new
                        {
                            Id = new Guid("836eb5a2-110d-4ce3-b69a-49eb8b4dc61a"),
                            Name = "Blockchain"
                        },
                        new
                        {
                            Id = new Guid("d7669f0f-23d9-4487-9f56-fcf27dafac16"),
                            Name = "IoT Development"
                        },
                        new
                        {
                            Id = new Guid("cdf9779b-f3a9-484b-9090-9f51e8b555b4"),
                            Name = "Embedded Systems"
                        },
                        new
                        {
                            Id = new Guid("c06dd4f8-acca-407d-becf-22cec911a410"),
                            Name = "Natural Language Processing"
                        },
                        new
                        {
                            Id = new Guid("b80625fc-27c3-4855-a809-938d65ef1d9d"),
                            Name = "Big Data"
                        },
                        new
                        {
                            Id = new Guid("5c07480b-44cf-4065-9897-3c537b765d38"),
                            Name = "Virtual Reality"
                        },
                        new
                        {
                            Id = new Guid("37d1c402-718f-4c8b-966e-d76fb8c325de"),
                            Name = "Augmented Reality"
                        },
                        new
                        {
                            Id = new Guid("da51c5af-7ee9-4533-89ac-b3d1aa7b23bb"),
                            Name = "Quantum Computing"
                        },
                        new
                        {
                            Id = new Guid("6976541b-4f94-41b4-8806-60492d47ff92"),
                            Name = "Functional Programming"
                        },
                        new
                        {
                            Id = new Guid("f6ec71f6-2008-46bf-8736-6eab82b401ad"),
                            Name = "Object-Oriented Programming"
                        },
                        new
                        {
                            Id = new Guid("48977041-0744-4328-98b2-3d0907c15a23"),
                            Name = "Low-Level Programming"
                        },
                        new
                        {
                            Id = new Guid("36b3ef03-cf6c-4ed8-9dae-9376498471e5"),
                            Name = "High-Level Programming"
                        },
                        new
                        {
                            Id = new Guid("132f9e81-b721-4927-8c18-411e9f001280"),
                            Name = "Concurrency"
                        },
                        new
                        {
                            Id = new Guid("1998e154-41cb-461c-88b2-8c9bd66ba171"),
                            Name = "Parallel Programming"
                        },
                        new
                        {
                            Id = new Guid("2ed26c0b-6d04-4e19-baf0-61429a59c484"),
                            Name = "Responsive Design"
                        },
                        new
                        {
                            Id = new Guid("2c81afd9-e8f6-42ad-8c30-f86e289c5d98"),
                            Name = "RESTful APIs"
                        },
                        new
                        {
                            Id = new Guid("e681972d-296a-4a18-9ca8-fbb0eb1f5c28"),
                            Name = "GraphQL"
                        },
                        new
                        {
                            Id = new Guid("1935c1c8-c7ac-4794-b096-dd98758b28ae"),
                            Name = "Secure Coding Practices"
                        },
                        new
                        {
                            Id = new Guid("4b7157ce-a653-4528-becf-48eb050a1edf"),
                            Name = "Code Optimization"
                        },
                        new
                        {
                            Id = new Guid("7467f0da-e11a-492f-97ac-4ea598e90780"),
                            Name = "Code Review"
                        },
                        new
                        {
                            Id = new Guid("dd4695bf-63bb-488d-bc38-c0f847a40cf3"),
                            Name = "Pair Programming"
                        },
                        new
                        {
                            Id = new Guid("3395c2a0-3989-44d6-9e21-836a6135bdb4"),
                            Name = "Scrum"
                        },
                        new
                        {
                            Id = new Guid("8cec018a-1358-4f28-8185-4289073b28f8"),
                            Name = "Kanban"
                        },
                        new
                        {
                            Id = new Guid("e8a95cbd-6169-49cd-9647-79b08c8a60a5"),
                            Name = "Software Architecture"
                        },
                        new
                        {
                            Id = new Guid("4d60cae0-5bf7-481e-b041-bac58dc8b54d"),
                            Name = "Design Patterns"
                        },
                        new
                        {
                            Id = new Guid("c91333af-f934-4a3d-b851-c7b23fad71c3"),
                            Name = "Refactoring"
                        },
                        new
                        {
                            Id = new Guid("6a73f515-e4bd-448a-9c31-08d1a9e3c9de"),
                            Name = "Code Documentation"
                        },
                        new
                        {
                            Id = new Guid("9cddbc12-76fb-4dc2-8a4c-80dc88af8d2c"),
                            Name = "Legacy Code Maintenance"
                        },
                        new
                        {
                            Id = new Guid("31fc23f4-6820-4a7b-8ee8-37e96c5768e7"),
                            Name = "Code Quality"
                        },
                        new
                        {
                            Id = new Guid("c0fdfdcd-1c77-46c4-b2a1-4ea5b6a2b7cd"),
                            Name = "Technical Debt"
                        },
                        new
                        {
                            Id = new Guid("b34de3dd-f162-423d-bc21-219b30f6d1b3"),
                            Name = "Software Development Lifecycle"
                        },
                        new
                        {
                            Id = new Guid("cda3c415-42d1-476f-a19d-415eed42c0c6"),
                            Name = "Project Management"
                        },
                        new
                        {
                            Id = new Guid("a8843492-6574-4f1b-9903-f0ca190fde1c"),
                            Name = "C#"
                        },
                        new
                        {
                            Id = new Guid("3dd30470-68f6-4c57-88e3-1dbae6816421"),
                            Name = "C++"
                        },
                        new
                        {
                            Id = new Guid("af613b80-957b-4d81-8c38-f1461817be8d"),
                            Name = "Java"
                        },
                        new
                        {
                            Id = new Guid("d47c3da2-eec7-4f3d-a098-107a404785d1"),
                            Name = "Python"
                        },
                        new
                        {
                            Id = new Guid("6096fa04-2e6b-45f7-a431-cfb37c9c04aa"),
                            Name = "JavaScript"
                        },
                        new
                        {
                            Id = new Guid("3cda1468-fc71-4acd-b9d7-7e08a893e5ba"),
                            Name = "Ruby"
                        },
                        new
                        {
                            Id = new Guid("08d8aeff-7c44-4b5c-91d4-97d762cc0b98"),
                            Name = "Swift"
                        },
                        new
                        {
                            Id = new Guid("0f7c89f2-438a-4304-b6c3-b3e99ad53425"),
                            Name = "Kotlin"
                        },
                        new
                        {
                            Id = new Guid("3c8e005e-f6ef-4aaa-8fb2-e2ab21fed65f"),
                            Name = "Go"
                        },
                        new
                        {
                            Id = new Guid("79739836-eee0-45fe-b37e-39ac60e8837c"),
                            Name = "Rust"
                        },
                        new
                        {
                            Id = new Guid("855dac7b-6495-4178-bed9-cb77060e26e9"),
                            Name = "PHP"
                        },
                        new
                        {
                            Id = new Guid("bd2fe475-67d5-4b44-b82e-2e225e7f989c"),
                            Name = "Perl"
                        },
                        new
                        {
                            Id = new Guid("b7f14116-6eb6-4282-ba1b-0b9a70995312"),
                            Name = "Scala"
                        },
                        new
                        {
                            Id = new Guid("05d6d0be-bf58-4535-ba1e-dc8a2f8ebc75"),
                            Name = "Haskell"
                        },
                        new
                        {
                            Id = new Guid("d7902616-d28b-4bda-9cf2-5e06628c0279"),
                            Name = "Lua"
                        },
                        new
                        {
                            Id = new Guid("0b984b5a-a51e-4983-9b2e-f32151912273"),
                            Name = "TypeScript"
                        },
                        new
                        {
                            Id = new Guid("418cf91e-0f9f-4b2d-a9bb-20cf072c4d4a"),
                            Name = "Dart"
                        },
                        new
                        {
                            Id = new Guid("48d77031-c6aa-4fdd-92c8-c26d72e439d3"),
                            Name = "F#"
                        },
                        new
                        {
                            Id = new Guid("13e37b9d-b319-48d0-8400-e3f2b4469417"),
                            Name = "Groovy"
                        },
                        new
                        {
                            Id = new Guid("87f89c27-e04f-48ca-b293-4ddb344fd53c"),
                            Name = "Objective-C"
                        },
                        new
                        {
                            Id = new Guid("67efcf66-2a29-4995-9951-0c46e24d5d3d"),
                            Name = "R"
                        },
                        new
                        {
                            Id = new Guid("a1efad02-a1b2-4942-86d3-83f0caf564b0"),
                            Name = "Matlab"
                        },
                        new
                        {
                            Id = new Guid("e7edb93a-28c3-4c86-a2ce-688af0e2cf6e"),
                            Name = "Julia"
                        },
                        new
                        {
                            Id = new Guid("1da53bf7-e1b8-444c-b7d5-f3fae83adc54"),
                            Name = "COBOL"
                        },
                        new
                        {
                            Id = new Guid("c70c67b5-07be-4e91-becf-32940f661d0b"),
                            Name = "Fortran"
                        },
                        new
                        {
                            Id = new Guid("f7e19faf-9f77-4820-82c1-07a51f431936"),
                            Name = "Assembly"
                        },
                        new
                        {
                            Id = new Guid("90fe3754-3be4-4f1b-8086-8fc749b9eca8"),
                            Name = "PL/SQL"
                        },
                        new
                        {
                            Id = new Guid("250b1e5c-30e5-4a2a-ae0f-fb55b7987298"),
                            Name = "T-SQL"
                        },
                        new
                        {
                            Id = new Guid("554b15d5-6219-46b9-ab58-935da8bb738e"),
                            Name = "VBScript"
                        },
                        new
                        {
                            Id = new Guid("4dc2e334-b0ec-47a2-a25e-3c6047d3bbf5"),
                            Name = "Ada"
                        },
                        new
                        {
                            Id = new Guid("77676583-d6b0-48c0-9cdd-3f4827a56010"),
                            Name = "Lisp"
                        },
                        new
                        {
                            Id = new Guid("d8929bb4-59a1-4ad7-aa4c-9137436cedf1"),
                            Name = "Prolog"
                        },
                        new
                        {
                            Id = new Guid("3856e044-b5da-46d3-a255-af3cb2abb975"),
                            Name = "Scheme"
                        },
                        new
                        {
                            Id = new Guid("9628b403-7fa3-4bab-b483-c796af74744f"),
                            Name = "Smalltalk"
                        },
                        new
                        {
                            Id = new Guid("da30a8d4-ca52-4787-91eb-29fb5e6001aa"),
                            Name = "Logo"
                        },
                        new
                        {
                            Id = new Guid("8c4a98d9-925f-428b-a829-3ce10b79a059"),
                            Name = "Clojure"
                        },
                        new
                        {
                            Id = new Guid("eabfe8cf-721c-4dab-9675-c3fd437191ec"),
                            Name = "Elixir"
                        },
                        new
                        {
                            Id = new Guid("7e6a172b-df94-4967-b802-7a477a1c709c"),
                            Name = "Erlang"
                        },
                        new
                        {
                            Id = new Guid("c39e26e7-f0da-461a-a293-a9a476343f9a"),
                            Name = "VHDL"
                        },
                        new
                        {
                            Id = new Guid("e116f169-d1a6-45cd-9daa-637c98eabdda"),
                            Name = "Verilog"
                        },
                        new
                        {
                            Id = new Guid("1844affb-9470-4e60-8a63-da0083dcc74f"),
                            Name = "SQL"
                        },
                        new
                        {
                            Id = new Guid("af942fcc-f768-4534-884c-4f3b5a2717e7"),
                            Name = "HTML"
                        },
                        new
                        {
                            Id = new Guid("40195fb0-b5a1-45e2-99c3-d47a5b2b4a2c"),
                            Name = "CSS"
                        },
                        new
                        {
                            Id = new Guid("470a095c-848e-46f4-9490-7a06fc80f63d"),
                            Name = "XML"
                        },
                        new
                        {
                            Id = new Guid("fa2842c7-b64a-4725-8792-389f7ced198b"),
                            Name = "JSON"
                        },
                        new
                        {
                            Id = new Guid("cb75dcbc-10da-41d0-bec3-ad1345d01ad9"),
                            Name = "Bash"
                        },
                        new
                        {
                            Id = new Guid("ee84cca4-baa1-43a1-a25e-f939ca692925"),
                            Name = "PowerShell"
                        },
                        new
                        {
                            Id = new Guid("1c5e1a8e-ee8d-411d-ba3e-f785bd726c18"),
                            Name = "Pascal"
                        },
                        new
                        {
                            Id = new Guid("8be587e8-ef67-4fe0-a6da-995a49761260"),
                            Name = "Racket"
                        },
                        new
                        {
                            Id = new Guid("73fe0bfc-2eef-438f-b0d2-7a2374ad7239"),
                            Name = "Ada"
                        });
                });

            modelBuilder.Entity("CourseFlow.Models.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("bit");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Thumbnail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("CourseFlow.Models.CourseCategory", b =>
                {
                    b.Property<Guid>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CourseId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("CourseCategories");
                });

            modelBuilder.Entity("CourseFlow.Models.Lesson", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAssignedToCourse")
                        .HasColumnType("bit");

                    b.Property<string>("Thumbnail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("CourseFlow.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AuthToken")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CourseFlow.Models.UserTakesCourse", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Progress")
                        .HasColumnType("int");

                    b.HasKey("UserId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("UserTakesCourses");
                });

            modelBuilder.Entity("CourseFlow.Models.AuthorCourses", b =>
                {
                    b.HasOne("CourseFlow.Models.User", "Author")
                        .WithMany("AuthorCourses")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CourseFlow.Models.Course", "Course")
                        .WithMany("AuthorCourses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Course");
                });

            modelBuilder.Entity("CourseFlow.Models.CourseCategory", b =>
                {
                    b.HasOne("CourseFlow.Models.Category", "Category")
                        .WithMany("CourseCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CourseFlow.Models.Course", "Course")
                        .WithMany("CourseCategories")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Course");
                });

            modelBuilder.Entity("CourseFlow.Models.Lesson", b =>
                {
                    b.HasOne("CourseFlow.Models.Course", "Course")
                        .WithMany("Lessons")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("CourseFlow.Models.UserTakesCourse", b =>
                {
                    b.HasOne("CourseFlow.Models.Course", "Course")
                        .WithMany("UserTakesCourse")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CourseFlow.Models.User", "User")
                        .WithMany("UserTakesCourse")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CourseFlow.Models.Category", b =>
                {
                    b.Navigation("CourseCategories");
                });

            modelBuilder.Entity("CourseFlow.Models.Course", b =>
                {
                    b.Navigation("AuthorCourses");

                    b.Navigation("CourseCategories");

                    b.Navigation("Lessons");

                    b.Navigation("UserTakesCourse");
                });

            modelBuilder.Entity("CourseFlow.Models.User", b =>
                {
                    b.Navigation("AuthorCourses");

                    b.Navigation("UserTakesCourse");
                });
#pragma warning restore 612, 618
        }
    }
}
