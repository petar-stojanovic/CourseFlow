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
    [Migration("20231023180649_defaultCourseForlessonswithfile")]
    partial class defaultCourseForlessonswithfile
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
                            Id = new Guid("e1a703d6-3738-4d5a-b01d-e060c098d71f"),
                            Name = "Web Development"
                        },
                        new
                        {
                            Id = new Guid("31c92fe5-b186-4634-a8b3-3881e35b2777"),
                            Name = "Mobile App Development"
                        },
                        new
                        {
                            Id = new Guid("8b7d1f67-fc9f-414f-8315-97f0d9fa4801"),
                            Name = "Game Development"
                        },
                        new
                        {
                            Id = new Guid("c5ca0fa2-c4b5-417b-8072-d7c96cec68b8"),
                            Name = "Database Management"
                        },
                        new
                        {
                            Id = new Guid("d74c56c8-1c63-4a79-9bb1-1c48e2698227"),
                            Name = "DevOps"
                        },
                        new
                        {
                            Id = new Guid("03eb78fb-4b59-48f9-9e95-287a94bc221c"),
                            Name = "Machine Learning"
                        },
                        new
                        {
                            Id = new Guid("0d3ce0b2-4dc5-476e-8854-613bedc66388"),
                            Name = "Artificial Intelligence"
                        },
                        new
                        {
                            Id = new Guid("e72757d2-b0d2-4d8f-acc5-e66a2f53256e"),
                            Name = "Data Science"
                        },
                        new
                        {
                            Id = new Guid("7ebaa0a1-b21e-4caa-9970-50d75b2072bf"),
                            Name = "Cloud Computing"
                        },
                        new
                        {
                            Id = new Guid("19ce4fc4-c8f7-4bf4-afac-7f6daa4015de"),
                            Name = "Cybersecurity"
                        },
                        new
                        {
                            Id = new Guid("9d14939c-4484-4486-835d-cf3d85f6db53"),
                            Name = "Frontend Development"
                        },
                        new
                        {
                            Id = new Guid("61f9bfd6-1edd-4421-8ba6-cb3eb6eb924d"),
                            Name = "Backend Development"
                        },
                        new
                        {
                            Id = new Guid("1b12ee4c-00df-4460-b76d-014e9a46acad"),
                            Name = "Full Stack Development"
                        },
                        new
                        {
                            Id = new Guid("0f399b4f-53fc-455c-92eb-8e6dbcd5cf64"),
                            Name = "UI/UX Design"
                        },
                        new
                        {
                            Id = new Guid("c516aba7-16ba-4278-ad25-70847a92b7f2"),
                            Name = "Version Control"
                        },
                        new
                        {
                            Id = new Guid("696b7044-f7a6-4913-a6c7-93982a105deb"),
                            Name = "Agile Methodology"
                        },
                        new
                        {
                            Id = new Guid("9aab0d4b-27ab-4d06-aab5-2c91d3d16707"),
                            Name = "Software Testing"
                        },
                        new
                        {
                            Id = new Guid("eaf26b32-6238-44c8-bb98-fab6f950a9e4"),
                            Name = "Continuous Integration"
                        },
                        new
                        {
                            Id = new Guid("e067a6d2-0921-4765-9cc3-65c27674e10b"),
                            Name = "API Development"
                        },
                        new
                        {
                            Id = new Guid("574b2156-3448-4d0e-9668-95146d0b5982"),
                            Name = "Microservices"
                        },
                        new
                        {
                            Id = new Guid("f4a3d8c7-1429-4329-a788-c948af3312aa"),
                            Name = "Blockchain"
                        },
                        new
                        {
                            Id = new Guid("3c318963-0ee6-45a9-81d1-5ddc42071b53"),
                            Name = "IoT Development"
                        },
                        new
                        {
                            Id = new Guid("94031416-241f-45c7-9034-abeccc716b50"),
                            Name = "Embedded Systems"
                        },
                        new
                        {
                            Id = new Guid("b5446131-7d71-4914-bfa5-3e3b198a8f4f"),
                            Name = "Natural Language Processing"
                        },
                        new
                        {
                            Id = new Guid("3df1af79-3432-419a-af0b-654e442184be"),
                            Name = "Big Data"
                        },
                        new
                        {
                            Id = new Guid("56495b97-5a96-4236-9432-c2ef95d02999"),
                            Name = "Virtual Reality"
                        },
                        new
                        {
                            Id = new Guid("b35516fe-303b-456b-9279-d3758c6f0498"),
                            Name = "Augmented Reality"
                        },
                        new
                        {
                            Id = new Guid("74fb13f1-12c3-4ab8-b5d9-b18f7058a220"),
                            Name = "Quantum Computing"
                        },
                        new
                        {
                            Id = new Guid("069ce44d-0473-4329-a791-5d01ee8bb48e"),
                            Name = "Functional Programming"
                        },
                        new
                        {
                            Id = new Guid("28b37964-e583-4b6d-8e0b-f07e937e6398"),
                            Name = "Object-Oriented Programming"
                        },
                        new
                        {
                            Id = new Guid("122a25b4-77aa-4838-8d27-d6b9719deee3"),
                            Name = "Low-Level Programming"
                        },
                        new
                        {
                            Id = new Guid("28eee9d7-4031-48da-948b-32c3af2ae23a"),
                            Name = "High-Level Programming"
                        },
                        new
                        {
                            Id = new Guid("ca3b7495-2352-4f06-881b-72bd7dd1b8c3"),
                            Name = "Concurrency"
                        },
                        new
                        {
                            Id = new Guid("27cfbacf-ebe2-430c-8d4a-cbdf821c59de"),
                            Name = "Parallel Programming"
                        },
                        new
                        {
                            Id = new Guid("7e5486ac-1312-4e6e-a208-53468c8f1ec1"),
                            Name = "Responsive Design"
                        },
                        new
                        {
                            Id = new Guid("9b1e0268-5081-4026-af66-c9e6d399ba5b"),
                            Name = "RESTful APIs"
                        },
                        new
                        {
                            Id = new Guid("037b0cf2-456d-4d0c-84c1-73811a8bbb39"),
                            Name = "GraphQL"
                        },
                        new
                        {
                            Id = new Guid("809d1d46-6064-4e6c-bcd8-653d040d0d07"),
                            Name = "Secure Coding Practices"
                        },
                        new
                        {
                            Id = new Guid("43743584-2974-43f0-ba75-eca47d2575a0"),
                            Name = "Code Optimization"
                        },
                        new
                        {
                            Id = new Guid("81247d2b-519b-4f8b-a403-f3f15af572cb"),
                            Name = "Code Review"
                        },
                        new
                        {
                            Id = new Guid("e3d7c4d9-28fb-4074-be4c-61604d64b7dd"),
                            Name = "Pair Programming"
                        },
                        new
                        {
                            Id = new Guid("52e3e63e-d375-4f72-87c2-530d3b18696c"),
                            Name = "Scrum"
                        },
                        new
                        {
                            Id = new Guid("9b650593-8188-441f-ae0e-c7beee5e9cb1"),
                            Name = "Kanban"
                        },
                        new
                        {
                            Id = new Guid("e4a4d24f-6870-4b04-ad9b-8303feb1286d"),
                            Name = "Software Architecture"
                        },
                        new
                        {
                            Id = new Guid("62085cb6-2ea4-4c9b-97ed-1fa42b330e96"),
                            Name = "Design Patterns"
                        },
                        new
                        {
                            Id = new Guid("42bc4554-af33-44f3-acef-ebf50e93e362"),
                            Name = "Refactoring"
                        },
                        new
                        {
                            Id = new Guid("121588b2-2ca2-49e9-ae81-29d703365cfd"),
                            Name = "Code Documentation"
                        },
                        new
                        {
                            Id = new Guid("d952363d-f3ff-4339-8cc5-190909d5e863"),
                            Name = "Legacy Code Maintenance"
                        },
                        new
                        {
                            Id = new Guid("a36b2d1d-b619-40f6-ac2f-f2263d9cdca1"),
                            Name = "Code Quality"
                        },
                        new
                        {
                            Id = new Guid("efc4a3d3-0a96-41b0-ab77-fbc7fc19f572"),
                            Name = "Technical Debt"
                        },
                        new
                        {
                            Id = new Guid("a89f0662-2bcf-446f-9038-c739c923b39f"),
                            Name = "Software Development Lifecycle"
                        },
                        new
                        {
                            Id = new Guid("4ea34c24-cf26-4fd3-b174-a544ac71b085"),
                            Name = "Project Management"
                        },
                        new
                        {
                            Id = new Guid("06d75bfe-ee42-41ae-ba66-9dac36603ef7"),
                            Name = "C#"
                        },
                        new
                        {
                            Id = new Guid("eca923e3-30cd-4241-b6f3-b683b83e2c7a"),
                            Name = "C++"
                        },
                        new
                        {
                            Id = new Guid("bf8831b1-443f-46af-a104-480a2e175960"),
                            Name = "Java"
                        },
                        new
                        {
                            Id = new Guid("0da7a44f-8259-411f-8f07-60904d213baa"),
                            Name = "Python"
                        },
                        new
                        {
                            Id = new Guid("071fd6d6-43ed-46ba-a42f-a45630cb01a1"),
                            Name = "JavaScript"
                        },
                        new
                        {
                            Id = new Guid("326278fc-aa66-4013-8012-1c58f1ea4d15"),
                            Name = "Ruby"
                        },
                        new
                        {
                            Id = new Guid("ec46a2b0-02b7-4897-a90f-bad6462d7e6d"),
                            Name = "Swift"
                        },
                        new
                        {
                            Id = new Guid("18f5e483-feea-4f88-91f7-dc3c21d6a74a"),
                            Name = "Kotlin"
                        },
                        new
                        {
                            Id = new Guid("b202b35a-52da-4479-af48-76e4da2381ef"),
                            Name = "Go"
                        },
                        new
                        {
                            Id = new Guid("5edff946-de93-46cd-813f-7a465ccf3205"),
                            Name = "Rust"
                        },
                        new
                        {
                            Id = new Guid("078e20e3-e7d2-4aed-9bb2-baa6bced1437"),
                            Name = "PHP"
                        },
                        new
                        {
                            Id = new Guid("250d7ee7-1f9a-411e-a9b5-72b317f95ed5"),
                            Name = "Perl"
                        },
                        new
                        {
                            Id = new Guid("f6bb60ec-9deb-46a0-a299-4fc6ca1998ca"),
                            Name = "Scala"
                        },
                        new
                        {
                            Id = new Guid("0e560969-2c8f-4493-b9f9-35b192bd6db5"),
                            Name = "Haskell"
                        },
                        new
                        {
                            Id = new Guid("5e8859d7-329a-43b9-b5b5-8d5d74623fd4"),
                            Name = "Lua"
                        },
                        new
                        {
                            Id = new Guid("0ab7d7a0-e46a-4d33-b3ed-c38be05a14af"),
                            Name = "TypeScript"
                        },
                        new
                        {
                            Id = new Guid("5dfbb4e6-516c-4367-8348-b45620689612"),
                            Name = "Dart"
                        },
                        new
                        {
                            Id = new Guid("5690bc10-d005-4c72-b1e6-72a46b9f6683"),
                            Name = "F#"
                        },
                        new
                        {
                            Id = new Guid("c71cf294-605a-49ac-8c68-d9314d3f92fe"),
                            Name = "Groovy"
                        },
                        new
                        {
                            Id = new Guid("88552d9b-b7b6-4268-949c-b92913f1a893"),
                            Name = "Objective-C"
                        },
                        new
                        {
                            Id = new Guid("d8afa6c1-ae05-49c9-b35c-0720ac2f57bf"),
                            Name = "R"
                        },
                        new
                        {
                            Id = new Guid("47c0997f-1662-43a1-aa92-b993317317f2"),
                            Name = "Matlab"
                        },
                        new
                        {
                            Id = new Guid("6b8c044c-c4a5-472a-bf86-724792482221"),
                            Name = "Julia"
                        },
                        new
                        {
                            Id = new Guid("b2eb229e-19d3-4c34-ac6d-dba9ed61b214"),
                            Name = "COBOL"
                        },
                        new
                        {
                            Id = new Guid("f470b13a-8e10-47a2-930b-9110b85474c5"),
                            Name = "Fortran"
                        },
                        new
                        {
                            Id = new Guid("806e8f18-6b2a-4a9e-be77-639a17b6a982"),
                            Name = "Assembly"
                        },
                        new
                        {
                            Id = new Guid("95f83465-777c-4188-91ac-9964b68ca775"),
                            Name = "PL/SQL"
                        },
                        new
                        {
                            Id = new Guid("46f0669d-327f-49a8-84be-2096f8231dcd"),
                            Name = "T-SQL"
                        },
                        new
                        {
                            Id = new Guid("1841bed9-560a-46e9-a24f-7df9d8efb242"),
                            Name = "VBScript"
                        },
                        new
                        {
                            Id = new Guid("b445ba0f-70a3-4a43-9366-7e24ccdcf1d1"),
                            Name = "Ada"
                        },
                        new
                        {
                            Id = new Guid("5326d449-f55e-4041-8a54-c4879a473a7f"),
                            Name = "Lisp"
                        },
                        new
                        {
                            Id = new Guid("4391b3d8-3a76-4654-af0b-84b20b700f38"),
                            Name = "Prolog"
                        },
                        new
                        {
                            Id = new Guid("31654f00-ce64-4975-b357-5c9e072c2f22"),
                            Name = "Scheme"
                        },
                        new
                        {
                            Id = new Guid("0f337af9-fc2e-49ad-8a74-250ea0b27d30"),
                            Name = "Smalltalk"
                        },
                        new
                        {
                            Id = new Guid("8e900388-9b2f-4e23-84cd-3808296c52c3"),
                            Name = "Logo"
                        },
                        new
                        {
                            Id = new Guid("dcc759a1-48b6-4767-9d2c-867e259d908c"),
                            Name = "Clojure"
                        },
                        new
                        {
                            Id = new Guid("20e4b2e9-c2a0-462e-a1d5-0d5b47f1f823"),
                            Name = "Elixir"
                        },
                        new
                        {
                            Id = new Guid("4e0c2562-4a15-41de-af8c-8307507b9734"),
                            Name = "Erlang"
                        },
                        new
                        {
                            Id = new Guid("f63b6069-a937-4a8d-b08c-2e78dc4b1374"),
                            Name = "VHDL"
                        },
                        new
                        {
                            Id = new Guid("f42c6712-1fb1-4fe5-8cbb-d35c54a66cdd"),
                            Name = "Verilog"
                        },
                        new
                        {
                            Id = new Guid("c7a0c354-0e62-47dc-96ac-f06f81936cc6"),
                            Name = "SQL"
                        },
                        new
                        {
                            Id = new Guid("3bba157f-f8da-4e22-9daa-7c31f7a6c0a4"),
                            Name = "HTML"
                        },
                        new
                        {
                            Id = new Guid("f749f18c-5c8d-4844-9dd8-2c2efc0daa23"),
                            Name = "CSS"
                        },
                        new
                        {
                            Id = new Guid("061d2bcb-9059-478d-a340-a8e55a09becd"),
                            Name = "XML"
                        },
                        new
                        {
                            Id = new Guid("f853df7d-fd26-47bd-876a-c41a6e0c29f4"),
                            Name = "JSON"
                        },
                        new
                        {
                            Id = new Guid("92602255-34fa-4dc1-8315-3524869623ec"),
                            Name = "Bash"
                        },
                        new
                        {
                            Id = new Guid("525b4ef4-ea45-418f-b989-51e250cf8118"),
                            Name = "PowerShell"
                        },
                        new
                        {
                            Id = new Guid("5d7ce162-7f22-41e1-94cc-6c704ba0d6a4"),
                            Name = "Pascal"
                        },
                        new
                        {
                            Id = new Guid("f0ad1e46-7d30-46de-9628-5df5b4705d34"),
                            Name = "Racket"
                        },
                        new
                        {
                            Id = new Guid("2673252f-31e3-4027-9e2a-2e9b11826d33"),
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
                            Id = new Guid("8a4ee6b6-15dc-4fa7-9d76-f72b3a91f526"),
                            Author = "",
                            DateCreated = new DateTime(2023, 10, 23, 20, 6, 48, 720, DateTimeKind.Local).AddTicks(2443),
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
