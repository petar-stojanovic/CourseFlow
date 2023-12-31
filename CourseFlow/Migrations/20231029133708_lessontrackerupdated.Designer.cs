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
    [Migration("20231029133708_lessontrackerupdated")]
    partial class lessontrackerupdated
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
                            Id = new Guid("c4c54194-0ef4-45fc-a0ae-2628cbbe8b4b"),
                            Name = "Web Development"
                        },
                        new
                        {
                            Id = new Guid("88c1740e-90df-49ae-b1e1-2187f4c73385"),
                            Name = "Mobile App Development"
                        },
                        new
                        {
                            Id = new Guid("5461738a-daac-40f6-8864-b81e244a5ee7"),
                            Name = "Game Development"
                        },
                        new
                        {
                            Id = new Guid("bb08661b-152c-4b02-a9db-a2f0dcc545f8"),
                            Name = "Database Management"
                        },
                        new
                        {
                            Id = new Guid("361cfc40-05e8-46e2-9a5c-7142de6bf55a"),
                            Name = "DevOps"
                        },
                        new
                        {
                            Id = new Guid("c8af8df0-0e76-4d3a-a3b7-9aa4b2066223"),
                            Name = "Machine Learning"
                        },
                        new
                        {
                            Id = new Guid("51e76639-7afb-4f6e-b6b5-4fab0acc7072"),
                            Name = "Artificial Intelligence"
                        },
                        new
                        {
                            Id = new Guid("affc55a3-cf54-4fad-a281-742831bf7128"),
                            Name = "Data Science"
                        },
                        new
                        {
                            Id = new Guid("54b9ace0-0857-44ff-8715-53772d434b22"),
                            Name = "Cloud Computing"
                        },
                        new
                        {
                            Id = new Guid("13332802-f5ca-43ff-8c0e-dda8d158a9b1"),
                            Name = "Cybersecurity"
                        },
                        new
                        {
                            Id = new Guid("2a4d06ab-bba6-4d3c-8afb-16df12be906d"),
                            Name = "Frontend Development"
                        },
                        new
                        {
                            Id = new Guid("f9bfbc2a-36fa-4ff6-aeb2-89b7b4535099"),
                            Name = "Backend Development"
                        },
                        new
                        {
                            Id = new Guid("e0334710-3240-4eab-8b57-ec534d68a3a3"),
                            Name = "Full Stack Development"
                        },
                        new
                        {
                            Id = new Guid("357dd1c1-8cde-4ab8-b9ae-d6a57c3b2080"),
                            Name = "UI/UX Design"
                        },
                        new
                        {
                            Id = new Guid("31c5b318-6c03-4b90-ad02-22a1f9d32b9c"),
                            Name = "Version Control"
                        },
                        new
                        {
                            Id = new Guid("232b1e01-6d52-447b-8cb3-c41c89268932"),
                            Name = "Agile Methodology"
                        },
                        new
                        {
                            Id = new Guid("d1c44266-467e-42b6-af7d-1ae904a6d432"),
                            Name = "Software Testing"
                        },
                        new
                        {
                            Id = new Guid("be914d23-275f-494c-b742-054bed64ab04"),
                            Name = "Continuous Integration"
                        },
                        new
                        {
                            Id = new Guid("5ea78143-e523-490d-84d5-895b897c5fd8"),
                            Name = "API Development"
                        },
                        new
                        {
                            Id = new Guid("1954494b-ae73-4934-82a1-54ff6e63ad03"),
                            Name = "Microservices"
                        },
                        new
                        {
                            Id = new Guid("c312b2e6-aa5b-4750-85a3-3ddcc779b794"),
                            Name = "Blockchain"
                        },
                        new
                        {
                            Id = new Guid("d68018f3-c582-4e03-91f8-a5ae54ad3801"),
                            Name = "IoT Development"
                        },
                        new
                        {
                            Id = new Guid("79ce0f22-9360-452a-bfd4-2fb0869cd54c"),
                            Name = "Embedded Systems"
                        },
                        new
                        {
                            Id = new Guid("8e019465-a4a3-4aca-8205-d2bc43a000c3"),
                            Name = "Natural Language Processing"
                        },
                        new
                        {
                            Id = new Guid("79a985b4-47cc-412b-9791-c1edba928449"),
                            Name = "Big Data"
                        },
                        new
                        {
                            Id = new Guid("c17d2987-55d6-4b1b-a579-33bcca4b4bb3"),
                            Name = "Virtual Reality"
                        },
                        new
                        {
                            Id = new Guid("cdf5ee9a-d8ca-4ce7-909a-3c1c478cb199"),
                            Name = "Augmented Reality"
                        },
                        new
                        {
                            Id = new Guid("2c787ac9-e98c-4ae4-bea1-89b7eb2d1bad"),
                            Name = "Quantum Computing"
                        },
                        new
                        {
                            Id = new Guid("7cbc5c39-4168-4e2f-a998-da75a4b8952f"),
                            Name = "Functional Programming"
                        },
                        new
                        {
                            Id = new Guid("561d6b81-f9c2-4d7e-9a5d-15434447e8f5"),
                            Name = "Object-Oriented Programming"
                        },
                        new
                        {
                            Id = new Guid("5d1809c4-d19d-433d-9f4a-3fd7af7588f8"),
                            Name = "Low-Level Programming"
                        },
                        new
                        {
                            Id = new Guid("46a8a175-0cb6-407e-98e6-1e6a230f2bf0"),
                            Name = "High-Level Programming"
                        },
                        new
                        {
                            Id = new Guid("0b048ad8-e5f3-47e6-9dd1-3af9e5475348"),
                            Name = "Concurrency"
                        },
                        new
                        {
                            Id = new Guid("cefb58df-6466-4133-a181-bde412c9f8f8"),
                            Name = "Parallel Programming"
                        },
                        new
                        {
                            Id = new Guid("508d2d74-d277-479e-ae44-62bdac729450"),
                            Name = "Responsive Design"
                        },
                        new
                        {
                            Id = new Guid("10079a2c-9ccc-41ca-b833-811a7f9e795a"),
                            Name = "RESTful APIs"
                        },
                        new
                        {
                            Id = new Guid("34623255-87d9-4da2-a710-cd8e31dd97d0"),
                            Name = "GraphQL"
                        },
                        new
                        {
                            Id = new Guid("b7e0fc98-17a8-40eb-8857-4c61a3500601"),
                            Name = "Secure Coding Practices"
                        },
                        new
                        {
                            Id = new Guid("10017f6e-f6df-4ae4-b8be-74503ec40bec"),
                            Name = "Code Optimization"
                        },
                        new
                        {
                            Id = new Guid("1fe06153-634d-4c77-bd41-93be75d53a2a"),
                            Name = "Code Review"
                        },
                        new
                        {
                            Id = new Guid("66a3a1bf-2022-4f9b-8ac5-7da49483c955"),
                            Name = "Pair Programming"
                        },
                        new
                        {
                            Id = new Guid("6144c4e5-03c6-4834-8cc8-8bb2f4faed03"),
                            Name = "Scrum"
                        },
                        new
                        {
                            Id = new Guid("e44faba7-dc58-4f39-8b6d-41fac320e2ef"),
                            Name = "Kanban"
                        },
                        new
                        {
                            Id = new Guid("8d50d93b-f81c-414b-a4a1-84fa8c77db09"),
                            Name = "Software Architecture"
                        },
                        new
                        {
                            Id = new Guid("231b7c9f-2e28-4c6f-afa4-38cff8cbfb78"),
                            Name = "Design Patterns"
                        },
                        new
                        {
                            Id = new Guid("b96bd352-3bb4-47a3-bb9f-8e12292005ac"),
                            Name = "Refactoring"
                        },
                        new
                        {
                            Id = new Guid("f1d14a45-8235-4336-9226-e5b6b8169b91"),
                            Name = "Code Documentation"
                        },
                        new
                        {
                            Id = new Guid("da4f8a29-06ea-429d-ae88-78878c663a45"),
                            Name = "Legacy Code Maintenance"
                        },
                        new
                        {
                            Id = new Guid("ec15fc96-af51-424c-8399-f9db1baff97d"),
                            Name = "Code Quality"
                        },
                        new
                        {
                            Id = new Guid("c834ae96-6363-4614-8c9f-f90a270f844a"),
                            Name = "Technical Debt"
                        },
                        new
                        {
                            Id = new Guid("69056235-0d2d-4e39-b209-cf202180f389"),
                            Name = "Software Development Lifecycle"
                        },
                        new
                        {
                            Id = new Guid("bbb93444-5736-443e-b16b-f60cbc6f836b"),
                            Name = "Project Management"
                        },
                        new
                        {
                            Id = new Guid("d04134c4-f242-473a-be59-b9e00c311f6a"),
                            Name = "C#"
                        },
                        new
                        {
                            Id = new Guid("9e8d744b-8c15-4443-92c0-1065db36d7fc"),
                            Name = "C++"
                        },
                        new
                        {
                            Id = new Guid("b25e2843-c6a1-476a-a547-adc31abd2fb9"),
                            Name = "Java"
                        },
                        new
                        {
                            Id = new Guid("904844b7-51fc-47a6-a5fc-84ca90b781a8"),
                            Name = "Python"
                        },
                        new
                        {
                            Id = new Guid("222840ec-d0b5-4047-8f9f-24653a45b4bd"),
                            Name = "JavaScript"
                        },
                        new
                        {
                            Id = new Guid("44bc833b-807c-4195-9681-56aeaa04734a"),
                            Name = "Ruby"
                        },
                        new
                        {
                            Id = new Guid("61d6a370-efda-49f7-9c8f-3ab4589acbd7"),
                            Name = "Swift"
                        },
                        new
                        {
                            Id = new Guid("377d8841-f5ef-42a5-8ab1-660092826217"),
                            Name = "Kotlin"
                        },
                        new
                        {
                            Id = new Guid("46ca98f0-f541-4d2b-8f1c-a3790adff968"),
                            Name = "Go"
                        },
                        new
                        {
                            Id = new Guid("ef26e22c-b7d7-43c8-89e1-f5b6805b1741"),
                            Name = "Rust"
                        },
                        new
                        {
                            Id = new Guid("38a6186e-b3da-473b-a577-3f74e6316f61"),
                            Name = "PHP"
                        },
                        new
                        {
                            Id = new Guid("0070656c-6b3e-480b-ad7b-66d3b71ac222"),
                            Name = "Perl"
                        },
                        new
                        {
                            Id = new Guid("45b3fa13-81c5-443c-b8e5-abfe060a0fe9"),
                            Name = "Scala"
                        },
                        new
                        {
                            Id = new Guid("dd4a3cb6-c9bf-4fd6-b207-9d35e9ba9176"),
                            Name = "Haskell"
                        },
                        new
                        {
                            Id = new Guid("4adabc28-3547-4cbd-958d-1aca22ab022e"),
                            Name = "Lua"
                        },
                        new
                        {
                            Id = new Guid("507f5192-fbba-4281-9ea8-fc36e0358e09"),
                            Name = "TypeScript"
                        },
                        new
                        {
                            Id = new Guid("b3f07261-4833-47be-ae8c-1ccaed4f166e"),
                            Name = "Dart"
                        },
                        new
                        {
                            Id = new Guid("7a9deac1-8604-4a8c-b8cf-f0803e1c2226"),
                            Name = "F#"
                        },
                        new
                        {
                            Id = new Guid("eb2760fc-06a4-4210-9a6b-ea8af4c6fd73"),
                            Name = "Groovy"
                        },
                        new
                        {
                            Id = new Guid("4dc68c80-5287-4ed9-9640-9783aecc6cda"),
                            Name = "Objective-C"
                        },
                        new
                        {
                            Id = new Guid("1969cac5-63db-4934-b972-a8a73aa15bd9"),
                            Name = "R"
                        },
                        new
                        {
                            Id = new Guid("46353e17-3be4-44b9-a00f-61294b0e6681"),
                            Name = "Matlab"
                        },
                        new
                        {
                            Id = new Guid("d8d67f9a-7ecc-4b78-aadf-25d460b135fd"),
                            Name = "Julia"
                        },
                        new
                        {
                            Id = new Guid("847d6186-641c-4bd7-9a6a-922618d9e9d6"),
                            Name = "COBOL"
                        },
                        new
                        {
                            Id = new Guid("f63a03b5-32e1-4007-92b0-3ef17f559929"),
                            Name = "Fortran"
                        },
                        new
                        {
                            Id = new Guid("75a5b653-e297-4dee-a345-4d92c45599b6"),
                            Name = "Assembly"
                        },
                        new
                        {
                            Id = new Guid("cb9091b2-1385-4f20-8202-70f94cf75f17"),
                            Name = "PL/SQL"
                        },
                        new
                        {
                            Id = new Guid("6ea3707d-022c-454f-86a5-c1d29b05be73"),
                            Name = "T-SQL"
                        },
                        new
                        {
                            Id = new Guid("d9746184-b9a1-4c4e-af13-fc9f40ee3e2a"),
                            Name = "VBScript"
                        },
                        new
                        {
                            Id = new Guid("051ddc4d-a886-4fb5-9ab6-dc6be5118f32"),
                            Name = "Ada"
                        },
                        new
                        {
                            Id = new Guid("af9c16d8-24b4-4212-9b05-ca0279d2e3a5"),
                            Name = "Lisp"
                        },
                        new
                        {
                            Id = new Guid("64e8faf9-fb81-46b6-98dc-6d288081b515"),
                            Name = "Prolog"
                        },
                        new
                        {
                            Id = new Guid("cab4dc60-dcd6-4d6b-9667-5f1886749c8f"),
                            Name = "Scheme"
                        },
                        new
                        {
                            Id = new Guid("221a52b6-a1a0-4115-860f-81f1bd646ba4"),
                            Name = "Smalltalk"
                        },
                        new
                        {
                            Id = new Guid("78f370e9-952a-42a8-a6fe-bf6ac36d1be9"),
                            Name = "Logo"
                        },
                        new
                        {
                            Id = new Guid("9631599c-524a-4c5f-9dc9-d4848265dab0"),
                            Name = "Clojure"
                        },
                        new
                        {
                            Id = new Guid("017e750d-cf0c-43bf-a664-050b2ce617b5"),
                            Name = "Elixir"
                        },
                        new
                        {
                            Id = new Guid("4df00ca4-9165-4dfe-8315-083913e3a65c"),
                            Name = "Erlang"
                        },
                        new
                        {
                            Id = new Guid("959f0afe-e042-4d78-ab96-e2b5334fd241"),
                            Name = "VHDL"
                        },
                        new
                        {
                            Id = new Guid("c248b0bc-1706-4dcc-b4fd-10df309e62b7"),
                            Name = "Verilog"
                        },
                        new
                        {
                            Id = new Guid("ff3e90b9-323f-4df2-a66f-4e305079dfbb"),
                            Name = "SQL"
                        },
                        new
                        {
                            Id = new Guid("99368616-1a28-40a4-bb2d-3cd64d9be26e"),
                            Name = "HTML"
                        },
                        new
                        {
                            Id = new Guid("f07abd74-c4e5-4d71-acf1-f20d4d595678"),
                            Name = "CSS"
                        },
                        new
                        {
                            Id = new Guid("3eeee6d6-2a18-4009-bf0b-9327d30a701d"),
                            Name = "XML"
                        },
                        new
                        {
                            Id = new Guid("279f6192-3ce4-4e5b-8fa6-39d0677f28fa"),
                            Name = "JSON"
                        },
                        new
                        {
                            Id = new Guid("abfea34b-35b7-42bd-b867-40f5eebc4af7"),
                            Name = "Bash"
                        },
                        new
                        {
                            Id = new Guid("a6dffda5-e366-46bb-8f11-ad4aa8dc322b"),
                            Name = "PowerShell"
                        },
                        new
                        {
                            Id = new Guid("5cf0bebe-c041-486b-b1bf-43c7d32ac685"),
                            Name = "Pascal"
                        },
                        new
                        {
                            Id = new Guid("9c9d971d-6af0-4116-939e-4f4308b120b4"),
                            Name = "Racket"
                        },
                        new
                        {
                            Id = new Guid("21ee2b6c-3946-4715-9376-f321e9164802"),
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
                            Id = new Guid("4fae216b-932a-42f5-b124-ea8b720502b6"),
                            Author = "",
                            DateCreated = new DateTime(2023, 10, 29, 14, 37, 8, 46, DateTimeKind.Local).AddTicks(4304),
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
