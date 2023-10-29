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
    [Migration("20231029144011_coursestartdate")]
    partial class coursestartdate
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
                            Id = new Guid("62af59b7-d326-44ec-b8e6-e966f2d9e3af"),
                            Name = "Web Development"
                        },
                        new
                        {
                            Id = new Guid("6762574a-a69a-47dd-9142-94f38a69d604"),
                            Name = "Mobile App Development"
                        },
                        new
                        {
                            Id = new Guid("5e1848e6-45ba-40dc-8ac4-24445e06511a"),
                            Name = "Game Development"
                        },
                        new
                        {
                            Id = new Guid("4a40981d-6b39-4dec-9ba7-91195965a9b8"),
                            Name = "Database Management"
                        },
                        new
                        {
                            Id = new Guid("4d25d799-41b9-4d2b-a520-02cd0cc286cd"),
                            Name = "DevOps"
                        },
                        new
                        {
                            Id = new Guid("4d58f4c2-a88e-41bf-9111-2e6115241af5"),
                            Name = "Machine Learning"
                        },
                        new
                        {
                            Id = new Guid("345ab32e-858a-4464-9dbe-fb69ef01c46c"),
                            Name = "Artificial Intelligence"
                        },
                        new
                        {
                            Id = new Guid("ab46c7e0-be6e-41cf-988d-d675b304a51a"),
                            Name = "Data Science"
                        },
                        new
                        {
                            Id = new Guid("d8e9394e-1013-4247-beaa-8c5ce04a69a9"),
                            Name = "Cloud Computing"
                        },
                        new
                        {
                            Id = new Guid("2ccfaf60-1032-4b37-8bcf-7917149a1b3a"),
                            Name = "Cybersecurity"
                        },
                        new
                        {
                            Id = new Guid("9016f08f-e8ff-427b-a62f-032648c65803"),
                            Name = "Frontend Development"
                        },
                        new
                        {
                            Id = new Guid("56e95d17-e40e-4f11-a216-e78577e20d8e"),
                            Name = "Backend Development"
                        },
                        new
                        {
                            Id = new Guid("96620313-65af-4c6a-b2b3-1c4a9df73537"),
                            Name = "Full Stack Development"
                        },
                        new
                        {
                            Id = new Guid("4f94bf27-cf57-4f43-b953-0b912d81fabf"),
                            Name = "UI/UX Design"
                        },
                        new
                        {
                            Id = new Guid("d546ef31-76b5-4d76-9188-4dd2baaaaebb"),
                            Name = "Version Control"
                        },
                        new
                        {
                            Id = new Guid("108d5259-45d2-4fb1-b0ee-f9413d515aa5"),
                            Name = "Agile Methodology"
                        },
                        new
                        {
                            Id = new Guid("a321f2f4-f1a3-44c8-bfe2-7afd0910d643"),
                            Name = "Software Testing"
                        },
                        new
                        {
                            Id = new Guid("4c699401-4587-4775-b91e-3f45eb0ce3eb"),
                            Name = "Continuous Integration"
                        },
                        new
                        {
                            Id = new Guid("e632f1c8-faac-4c7d-a975-e90109280ac6"),
                            Name = "API Development"
                        },
                        new
                        {
                            Id = new Guid("6e256290-3798-438c-97b4-7ce8d68f2ac4"),
                            Name = "Microservices"
                        },
                        new
                        {
                            Id = new Guid("6a05b35a-3e7a-47a4-9584-f979e47d8328"),
                            Name = "Blockchain"
                        },
                        new
                        {
                            Id = new Guid("9f640c61-b259-455f-b06a-71cb8b1a5d9a"),
                            Name = "IoT Development"
                        },
                        new
                        {
                            Id = new Guid("33a53d73-55b8-4fc8-88ae-b9f63d4af788"),
                            Name = "Embedded Systems"
                        },
                        new
                        {
                            Id = new Guid("4cfe40f7-c3b4-4049-8cd5-53be01a62389"),
                            Name = "Natural Language Processing"
                        },
                        new
                        {
                            Id = new Guid("ac9ba3fd-d3be-40d3-ae27-4abdf4e6a6b4"),
                            Name = "Big Data"
                        },
                        new
                        {
                            Id = new Guid("c152f1a7-a53d-40fd-8fb9-b2cbe0ac002f"),
                            Name = "Virtual Reality"
                        },
                        new
                        {
                            Id = new Guid("d9fcd52c-2d85-4f32-a76c-d98b228834df"),
                            Name = "Augmented Reality"
                        },
                        new
                        {
                            Id = new Guid("84f47217-1e9e-4363-bc2a-bb95dec09149"),
                            Name = "Quantum Computing"
                        },
                        new
                        {
                            Id = new Guid("ed4f880e-60e6-426e-9c98-60c9073f2d24"),
                            Name = "Functional Programming"
                        },
                        new
                        {
                            Id = new Guid("fd4f92e0-4ae1-4a96-8ef5-7c825bf1ee2b"),
                            Name = "Object-Oriented Programming"
                        },
                        new
                        {
                            Id = new Guid("84955ac7-36e7-4741-a3ec-e851656b9c9f"),
                            Name = "Low-Level Programming"
                        },
                        new
                        {
                            Id = new Guid("600aba2d-f1be-4a47-9c7c-49ca06bf49cd"),
                            Name = "High-Level Programming"
                        },
                        new
                        {
                            Id = new Guid("5eee23ef-2604-412d-bca8-2aacfd1b0344"),
                            Name = "Concurrency"
                        },
                        new
                        {
                            Id = new Guid("d4027b02-eb72-4a9d-99d8-fd9ae7aa8996"),
                            Name = "Parallel Programming"
                        },
                        new
                        {
                            Id = new Guid("66d9c0e6-0524-4af4-8a8b-8e1b0412376b"),
                            Name = "Responsive Design"
                        },
                        new
                        {
                            Id = new Guid("0852ae8d-93ee-4d53-80c0-99b31f579bad"),
                            Name = "RESTful APIs"
                        },
                        new
                        {
                            Id = new Guid("57a14089-9987-4bc3-931d-73a6f355ed1a"),
                            Name = "GraphQL"
                        },
                        new
                        {
                            Id = new Guid("f1a187c7-5087-47ed-9222-5ab4066a675b"),
                            Name = "Secure Coding Practices"
                        },
                        new
                        {
                            Id = new Guid("aac8dfa2-363f-42d5-a3d2-f2c28c45aeec"),
                            Name = "Code Optimization"
                        },
                        new
                        {
                            Id = new Guid("aadbe9f1-c313-48ed-83fb-11b6b1bb6e53"),
                            Name = "Code Review"
                        },
                        new
                        {
                            Id = new Guid("a664627f-c258-41ef-857d-9406bd3ba979"),
                            Name = "Pair Programming"
                        },
                        new
                        {
                            Id = new Guid("4e652239-482e-4c79-b843-1f6de65c3044"),
                            Name = "Scrum"
                        },
                        new
                        {
                            Id = new Guid("24618472-7b42-4e74-871c-10dff5accb0c"),
                            Name = "Kanban"
                        },
                        new
                        {
                            Id = new Guid("05b24589-e734-4451-9e28-d8889f19e707"),
                            Name = "Software Architecture"
                        },
                        new
                        {
                            Id = new Guid("e191f9e6-31ad-4c8c-9820-72def282ffd7"),
                            Name = "Design Patterns"
                        },
                        new
                        {
                            Id = new Guid("a21bf041-c7b6-4852-ac41-5604ae35bba0"),
                            Name = "Refactoring"
                        },
                        new
                        {
                            Id = new Guid("4f5129ca-101f-4847-b502-d2df928f8217"),
                            Name = "Code Documentation"
                        },
                        new
                        {
                            Id = new Guid("2c2487ae-6be2-40df-8eed-8b7bfa946340"),
                            Name = "Legacy Code Maintenance"
                        },
                        new
                        {
                            Id = new Guid("537007ee-e98d-488c-baef-041fe6ca09d7"),
                            Name = "Code Quality"
                        },
                        new
                        {
                            Id = new Guid("cb944eab-a736-4daf-9d20-8902dfb67981"),
                            Name = "Technical Debt"
                        },
                        new
                        {
                            Id = new Guid("4a6135b0-9ec2-4777-adcc-1b518bcf4f10"),
                            Name = "Software Development Lifecycle"
                        },
                        new
                        {
                            Id = new Guid("a3ded1c3-7c42-44de-885b-df0fcf849bcd"),
                            Name = "Project Management"
                        },
                        new
                        {
                            Id = new Guid("28674e8e-5253-412c-a12a-1867396c7fc1"),
                            Name = "C#"
                        },
                        new
                        {
                            Id = new Guid("d30fb055-2a90-40db-89a4-64812ba84afd"),
                            Name = "C++"
                        },
                        new
                        {
                            Id = new Guid("2140ea17-4216-421e-8cb4-3d3afe34ae45"),
                            Name = "Java"
                        },
                        new
                        {
                            Id = new Guid("26861ee1-9585-4263-b14b-d4dde3bfd536"),
                            Name = "Python"
                        },
                        new
                        {
                            Id = new Guid("f7a56ee9-3832-4ace-8f3c-f35b93eee7bc"),
                            Name = "JavaScript"
                        },
                        new
                        {
                            Id = new Guid("8c6eaa47-45d7-464b-a36c-23f818410688"),
                            Name = "Ruby"
                        },
                        new
                        {
                            Id = new Guid("fa775fe6-3a3f-4bd3-aeea-f608a08645a2"),
                            Name = "Swift"
                        },
                        new
                        {
                            Id = new Guid("53dc888a-9a6d-4257-90b6-4cc9b92cd53d"),
                            Name = "Kotlin"
                        },
                        new
                        {
                            Id = new Guid("13924449-8021-4433-85b6-4c286e0d370e"),
                            Name = "Go"
                        },
                        new
                        {
                            Id = new Guid("c0f92a7d-a2f4-48ee-8c33-854a4ea0e6c1"),
                            Name = "Rust"
                        },
                        new
                        {
                            Id = new Guid("d0516e4b-fc9d-42c4-b86c-3b85dca25d55"),
                            Name = "PHP"
                        },
                        new
                        {
                            Id = new Guid("5cbfc08e-fa98-49ce-ab9c-3ac27b263426"),
                            Name = "Perl"
                        },
                        new
                        {
                            Id = new Guid("986f0030-e9c2-43d8-a58c-7646d9a9b521"),
                            Name = "Scala"
                        },
                        new
                        {
                            Id = new Guid("ef5980f6-8d2b-4d61-910b-10c4ee1003aa"),
                            Name = "Haskell"
                        },
                        new
                        {
                            Id = new Guid("29751c11-a1a6-4a19-bf89-482ca568e72e"),
                            Name = "Lua"
                        },
                        new
                        {
                            Id = new Guid("8faa91ee-057c-4ccf-8f16-f09e76c82f31"),
                            Name = "TypeScript"
                        },
                        new
                        {
                            Id = new Guid("27660373-9a88-4410-be3f-4a05d52cd6fc"),
                            Name = "Dart"
                        },
                        new
                        {
                            Id = new Guid("63d33610-7a19-4795-9675-f403510b30a3"),
                            Name = "F#"
                        },
                        new
                        {
                            Id = new Guid("bf8f6450-f28b-408f-82e0-733554ce4290"),
                            Name = "Groovy"
                        },
                        new
                        {
                            Id = new Guid("17580c09-176c-4f84-ac4b-c8c4fe0ddda7"),
                            Name = "Objective-C"
                        },
                        new
                        {
                            Id = new Guid("e8e20a72-f7ff-43c5-9ba7-71e88112ca54"),
                            Name = "R"
                        },
                        new
                        {
                            Id = new Guid("98d92ee3-4e4b-4e13-824e-cfa3fd6eb290"),
                            Name = "Matlab"
                        },
                        new
                        {
                            Id = new Guid("63116266-6d70-4225-8503-d57b24261a71"),
                            Name = "Julia"
                        },
                        new
                        {
                            Id = new Guid("295ff45f-79b7-46b0-b5e5-51e5564d8ecd"),
                            Name = "COBOL"
                        },
                        new
                        {
                            Id = new Guid("ac534886-d23b-4938-8430-ca84660b2aa0"),
                            Name = "Fortran"
                        },
                        new
                        {
                            Id = new Guid("49d4b5c7-aa0f-493d-ab77-6756351e84ff"),
                            Name = "Assembly"
                        },
                        new
                        {
                            Id = new Guid("94501f44-98dd-4dc5-85e2-01979dea376a"),
                            Name = "PL/SQL"
                        },
                        new
                        {
                            Id = new Guid("d55838e7-4d09-439e-b50e-bdb12455f571"),
                            Name = "T-SQL"
                        },
                        new
                        {
                            Id = new Guid("cb989837-b147-402d-8007-0a4cd3f320ec"),
                            Name = "VBScript"
                        },
                        new
                        {
                            Id = new Guid("0ace2f6a-b7a9-4b73-8f29-2092cc3a1a11"),
                            Name = "Ada"
                        },
                        new
                        {
                            Id = new Guid("f3a0faf4-d860-4dce-bbd9-59b4f398192d"),
                            Name = "Lisp"
                        },
                        new
                        {
                            Id = new Guid("31935738-44d1-41ce-91b1-7d5dff8a071d"),
                            Name = "Prolog"
                        },
                        new
                        {
                            Id = new Guid("5c87f5be-3eef-45e7-8e03-8d8e40b6b39f"),
                            Name = "Scheme"
                        },
                        new
                        {
                            Id = new Guid("2aff3651-5e5b-43c6-88ed-a86ecdfe1ae7"),
                            Name = "Smalltalk"
                        },
                        new
                        {
                            Id = new Guid("5182df13-8cb8-4aef-84c7-516b96631588"),
                            Name = "Logo"
                        },
                        new
                        {
                            Id = new Guid("e1438a46-5203-4fc6-ac0e-cdf3aa87c44e"),
                            Name = "Clojure"
                        },
                        new
                        {
                            Id = new Guid("e4690470-7d74-41ba-a01c-08b16ac92f92"),
                            Name = "Elixir"
                        },
                        new
                        {
                            Id = new Guid("953c2122-6087-4230-b4ea-cf039dbe94f8"),
                            Name = "Erlang"
                        },
                        new
                        {
                            Id = new Guid("daec5b2c-d300-4b14-b85d-fd59ae24c766"),
                            Name = "VHDL"
                        },
                        new
                        {
                            Id = new Guid("ae44350b-48c3-4c23-9df8-ef8c08f83c81"),
                            Name = "Verilog"
                        },
                        new
                        {
                            Id = new Guid("3b14e760-62c1-41b1-9621-5d70481077c9"),
                            Name = "SQL"
                        },
                        new
                        {
                            Id = new Guid("1eee9e2c-f106-43df-9999-ca0db7887e94"),
                            Name = "HTML"
                        },
                        new
                        {
                            Id = new Guid("499cbad6-1386-4a82-aca1-9284f9c1369c"),
                            Name = "CSS"
                        },
                        new
                        {
                            Id = new Guid("a2eef417-ac8a-45d6-a41e-26127f807653"),
                            Name = "XML"
                        },
                        new
                        {
                            Id = new Guid("4bf4c635-98e8-40b6-8548-0d14e94a8e13"),
                            Name = "JSON"
                        },
                        new
                        {
                            Id = new Guid("36fe31c1-1d51-4fc9-912e-9599a840548d"),
                            Name = "Bash"
                        },
                        new
                        {
                            Id = new Guid("f3edb1c4-7b9e-444c-ab24-d42baa3dade5"),
                            Name = "PowerShell"
                        },
                        new
                        {
                            Id = new Guid("de4368f1-2699-460e-9c7b-782aa705b4a4"),
                            Name = "Pascal"
                        },
                        new
                        {
                            Id = new Guid("6e4856d9-10af-4ee9-97ce-0d2f5ee82ef2"),
                            Name = "Racket"
                        },
                        new
                        {
                            Id = new Guid("497e5177-1526-4fa6-b6b8-42aa4a327bb3"),
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

                    b.HasData(
                        new
                        {
                            Id = new Guid("55087c85-847d-48c1-8700-7dd8892f1ab9"),
                            Author = "",
                            DateCreated = new DateTime(2023, 10, 29, 15, 40, 10, 687, DateTimeKind.Local).AddTicks(1261),
                            Description = "This is a course for unassigned lessons",
                            IsPublic = false,
                            Price = 100000,
                            Thumbnail = "https://img-c.udemycdn.com/course/750x422/473160_d929_3.jpg",
                            Title = "Admin"
                        });
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

                    b.Property<string>("CompletedLessonIds")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Progress")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

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