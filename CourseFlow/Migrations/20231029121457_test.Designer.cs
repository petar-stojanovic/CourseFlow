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
    [Migration("20231029121457_test")]
    partial class test
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
                            Id = new Guid("1cd42fb2-f798-493d-ad0f-f2026a45067f"),
                            Name = "Web Development"
                        },
                        new
                        {
                            Id = new Guid("ce0f6632-5311-4b4c-8312-6fe81805da2c"),
                            Name = "Mobile App Development"
                        },
                        new
                        {
                            Id = new Guid("be53dc66-66f6-49d5-8184-fc803bf30f47"),
                            Name = "Game Development"
                        },
                        new
                        {
                            Id = new Guid("f8f952e2-5705-43f2-bae2-1c46f87c6b7d"),
                            Name = "Database Management"
                        },
                        new
                        {
                            Id = new Guid("5940f2cb-86a2-4030-95e1-c2b356ec2681"),
                            Name = "DevOps"
                        },
                        new
                        {
                            Id = new Guid("a38c8b81-3bb8-47f2-9ea0-9d5ca53b1eab"),
                            Name = "Machine Learning"
                        },
                        new
                        {
                            Id = new Guid("86fe888b-094b-4fc6-a199-53a1f9db84ae"),
                            Name = "Artificial Intelligence"
                        },
                        new
                        {
                            Id = new Guid("09df6263-4dd4-4b1a-881b-cd37b8501022"),
                            Name = "Data Science"
                        },
                        new
                        {
                            Id = new Guid("060d64e2-553f-46e0-9568-82be1ffaed6a"),
                            Name = "Cloud Computing"
                        },
                        new
                        {
                            Id = new Guid("aafb5489-a8a0-4ed3-aa30-913ac61dc51b"),
                            Name = "Cybersecurity"
                        },
                        new
                        {
                            Id = new Guid("edd075b7-e3cb-4049-8484-6267ce5e649d"),
                            Name = "Frontend Development"
                        },
                        new
                        {
                            Id = new Guid("34f4fc9e-a56f-497d-a6c7-656c3377ae10"),
                            Name = "Backend Development"
                        },
                        new
                        {
                            Id = new Guid("f3088f70-2593-4cf8-b770-08bf7f18158a"),
                            Name = "Full Stack Development"
                        },
                        new
                        {
                            Id = new Guid("5e04ce94-b3c8-4c90-a0f9-3251e67b65e0"),
                            Name = "UI/UX Design"
                        },
                        new
                        {
                            Id = new Guid("b9d4ddda-30a4-4013-8d44-564ae35fb02d"),
                            Name = "Version Control"
                        },
                        new
                        {
                            Id = new Guid("af77bfce-7e96-4137-b9ec-825588085e8d"),
                            Name = "Agile Methodology"
                        },
                        new
                        {
                            Id = new Guid("ec98d058-97a3-4949-8011-b9b06f1cfb40"),
                            Name = "Software Testing"
                        },
                        new
                        {
                            Id = new Guid("458b8591-a718-4303-a27c-9887d3cfd41c"),
                            Name = "Continuous Integration"
                        },
                        new
                        {
                            Id = new Guid("45cd3860-86ff-41dc-8a98-4685081316fa"),
                            Name = "API Development"
                        },
                        new
                        {
                            Id = new Guid("3811c3d3-ebe6-49fb-a7e3-08e85aa8abe6"),
                            Name = "Microservices"
                        },
                        new
                        {
                            Id = new Guid("1e2a6ccd-c881-44b7-b2be-2ce5194105c0"),
                            Name = "Blockchain"
                        },
                        new
                        {
                            Id = new Guid("6a54d0f0-ec87-466f-92ed-f0ff8b011fc5"),
                            Name = "IoT Development"
                        },
                        new
                        {
                            Id = new Guid("7a139c30-ce49-4343-8414-d5b42a1262dc"),
                            Name = "Embedded Systems"
                        },
                        new
                        {
                            Id = new Guid("de2afd27-6641-47b6-9f72-8853fbfadf4d"),
                            Name = "Natural Language Processing"
                        },
                        new
                        {
                            Id = new Guid("c8725cd0-7226-4aff-9a85-b73dd7dcfd4e"),
                            Name = "Big Data"
                        },
                        new
                        {
                            Id = new Guid("bdd5a848-392c-41e0-bd8b-c8815866025b"),
                            Name = "Virtual Reality"
                        },
                        new
                        {
                            Id = new Guid("0e667756-0989-4e3e-89df-180a31894578"),
                            Name = "Augmented Reality"
                        },
                        new
                        {
                            Id = new Guid("f374f2a3-4936-492c-97ae-a0873dc04ee4"),
                            Name = "Quantum Computing"
                        },
                        new
                        {
                            Id = new Guid("cf872390-9e46-442d-b8d0-b7e3f829de69"),
                            Name = "Functional Programming"
                        },
                        new
                        {
                            Id = new Guid("102b6fe2-70be-4f5b-b33a-733b460abda1"),
                            Name = "Object-Oriented Programming"
                        },
                        new
                        {
                            Id = new Guid("f5e97a12-a728-4d1e-aded-8107516465af"),
                            Name = "Low-Level Programming"
                        },
                        new
                        {
                            Id = new Guid("8ef09dca-3f6b-467d-9baa-a1a4fa0af769"),
                            Name = "High-Level Programming"
                        },
                        new
                        {
                            Id = new Guid("8dc6b3a3-c363-4b64-bf0b-aa08ae544f94"),
                            Name = "Concurrency"
                        },
                        new
                        {
                            Id = new Guid("eb33f594-d4f6-40a6-877c-2718046c4b30"),
                            Name = "Parallel Programming"
                        },
                        new
                        {
                            Id = new Guid("44972541-8f22-43dc-b79c-a7c3099ee6df"),
                            Name = "Responsive Design"
                        },
                        new
                        {
                            Id = new Guid("a15bdf53-31bc-462e-a566-60a66cc1ed4b"),
                            Name = "RESTful APIs"
                        },
                        new
                        {
                            Id = new Guid("0e87c4db-34c0-4821-9a17-905c57c8960a"),
                            Name = "GraphQL"
                        },
                        new
                        {
                            Id = new Guid("829eed83-90a6-4543-a677-cac005d73df9"),
                            Name = "Secure Coding Practices"
                        },
                        new
                        {
                            Id = new Guid("21c41c53-4344-480a-bc13-6e615d96d8d2"),
                            Name = "Code Optimization"
                        },
                        new
                        {
                            Id = new Guid("b16313e1-1951-436c-925d-7fe8f4d0abec"),
                            Name = "Code Review"
                        },
                        new
                        {
                            Id = new Guid("56d2c28d-a96d-42c8-94ff-a6eae7b7c501"),
                            Name = "Pair Programming"
                        },
                        new
                        {
                            Id = new Guid("cbf03563-b5e6-42cc-9d70-1aa06c7f5c1e"),
                            Name = "Scrum"
                        },
                        new
                        {
                            Id = new Guid("34c5a921-e47b-482f-9b95-eb4d29dee7b4"),
                            Name = "Kanban"
                        },
                        new
                        {
                            Id = new Guid("add5f0f4-8ecc-4ca9-8bf4-a2a58f6b0a8f"),
                            Name = "Software Architecture"
                        },
                        new
                        {
                            Id = new Guid("26f225ea-07d1-443a-95cf-c26cb8c7f267"),
                            Name = "Design Patterns"
                        },
                        new
                        {
                            Id = new Guid("2c5e0c7f-4d1f-460c-8518-be32a9cbb06c"),
                            Name = "Refactoring"
                        },
                        new
                        {
                            Id = new Guid("f82c93fb-9cc7-4977-921b-e3d1ceb23ece"),
                            Name = "Code Documentation"
                        },
                        new
                        {
                            Id = new Guid("8fd88fdc-f75e-41b6-aa04-b7d464edf959"),
                            Name = "Legacy Code Maintenance"
                        },
                        new
                        {
                            Id = new Guid("b7ee001d-46df-44cd-bc2e-954582e23fcf"),
                            Name = "Code Quality"
                        },
                        new
                        {
                            Id = new Guid("2c8a40a8-0f39-4b85-b402-a983949795cf"),
                            Name = "Technical Debt"
                        },
                        new
                        {
                            Id = new Guid("dfccf0cf-d0d0-484e-b442-13c82029a8a6"),
                            Name = "Software Development Lifecycle"
                        },
                        new
                        {
                            Id = new Guid("eb9e5317-194e-497d-995f-f9881804a7ad"),
                            Name = "Project Management"
                        },
                        new
                        {
                            Id = new Guid("58b14f46-0ead-4950-a9f0-1a511de5453d"),
                            Name = "C#"
                        },
                        new
                        {
                            Id = new Guid("c075a7c4-2802-4541-8e7d-d59ed1291049"),
                            Name = "C++"
                        },
                        new
                        {
                            Id = new Guid("1b94f83b-a75e-400e-b10e-a3fa7a79424b"),
                            Name = "Java"
                        },
                        new
                        {
                            Id = new Guid("bc98ec98-4e5b-4329-aabd-f9e4dff78603"),
                            Name = "Python"
                        },
                        new
                        {
                            Id = new Guid("54d26a1b-bb23-446f-b519-fe967afa0125"),
                            Name = "JavaScript"
                        },
                        new
                        {
                            Id = new Guid("d56c9f8d-68e6-408f-bce5-370f2919558a"),
                            Name = "Ruby"
                        },
                        new
                        {
                            Id = new Guid("bf78e9c3-0099-42c5-b481-6deaab0fc29d"),
                            Name = "Swift"
                        },
                        new
                        {
                            Id = new Guid("eedfb4c6-3b00-486c-92ce-d7b9b65d6a7d"),
                            Name = "Kotlin"
                        },
                        new
                        {
                            Id = new Guid("065b1817-ab25-4dae-9dcc-9ac8cfde3c45"),
                            Name = "Go"
                        },
                        new
                        {
                            Id = new Guid("efba6721-ed23-4cc4-aa3a-f6241669257d"),
                            Name = "Rust"
                        },
                        new
                        {
                            Id = new Guid("83cfee4e-f204-4d95-acd2-f7ae6d5c584e"),
                            Name = "PHP"
                        },
                        new
                        {
                            Id = new Guid("490ce9ed-0e1b-41e1-affc-02d68a19217b"),
                            Name = "Perl"
                        },
                        new
                        {
                            Id = new Guid("3d30e2d4-4078-4623-8dc4-b5579480f9e0"),
                            Name = "Scala"
                        },
                        new
                        {
                            Id = new Guid("8883f104-36ef-4839-b366-7c28e899dcec"),
                            Name = "Haskell"
                        },
                        new
                        {
                            Id = new Guid("6ad7642e-f5fb-4d78-9b39-fca571dccf95"),
                            Name = "Lua"
                        },
                        new
                        {
                            Id = new Guid("069c8737-88f8-4fc6-bcc3-7eb4c10703ff"),
                            Name = "TypeScript"
                        },
                        new
                        {
                            Id = new Guid("61f75fee-20b3-46da-922c-be9ce20e8fb1"),
                            Name = "Dart"
                        },
                        new
                        {
                            Id = new Guid("5d41288b-9a2b-4727-8e67-e8abcebca737"),
                            Name = "F#"
                        },
                        new
                        {
                            Id = new Guid("9112c346-2410-49b7-a78e-d2c4dc54a90f"),
                            Name = "Groovy"
                        },
                        new
                        {
                            Id = new Guid("c5d291f2-17f6-460a-8aaf-3b34e2de014b"),
                            Name = "Objective-C"
                        },
                        new
                        {
                            Id = new Guid("4933f77d-02f2-4d98-b991-5698dddf96c1"),
                            Name = "R"
                        },
                        new
                        {
                            Id = new Guid("53f20ea9-0895-41a6-9bc2-7c7b5223b257"),
                            Name = "Matlab"
                        },
                        new
                        {
                            Id = new Guid("288da27f-fedc-4d14-a739-ca94ae0215ff"),
                            Name = "Julia"
                        },
                        new
                        {
                            Id = new Guid("3fa95a34-83ab-4f09-8e36-9f7094cb278d"),
                            Name = "COBOL"
                        },
                        new
                        {
                            Id = new Guid("6c202a9d-e077-41a1-8997-30eec89cccac"),
                            Name = "Fortran"
                        },
                        new
                        {
                            Id = new Guid("61f289d6-f346-434e-ba61-2f8fec1648aa"),
                            Name = "Assembly"
                        },
                        new
                        {
                            Id = new Guid("8fbbc62f-47f1-48fd-89d9-e3735711f180"),
                            Name = "PL/SQL"
                        },
                        new
                        {
                            Id = new Guid("670fe0aa-f76e-44da-8540-58d28f52f68f"),
                            Name = "T-SQL"
                        },
                        new
                        {
                            Id = new Guid("d5dea34d-86ea-4892-bfb2-df80d58b4d85"),
                            Name = "VBScript"
                        },
                        new
                        {
                            Id = new Guid("d381d7dc-b12c-4f42-b70d-79eb4e618e95"),
                            Name = "Ada"
                        },
                        new
                        {
                            Id = new Guid("2b672bc3-2acb-41fc-bb28-8cff3e28a3e7"),
                            Name = "Lisp"
                        },
                        new
                        {
                            Id = new Guid("f23474d9-c593-48f1-a718-6f1d5d347908"),
                            Name = "Prolog"
                        },
                        new
                        {
                            Id = new Guid("a777ca04-16e4-4b00-85de-078f27c3d474"),
                            Name = "Scheme"
                        },
                        new
                        {
                            Id = new Guid("4d103113-46aa-4e12-ae71-66058376c9eb"),
                            Name = "Smalltalk"
                        },
                        new
                        {
                            Id = new Guid("0cf622c3-3b52-479b-830f-b5f6f708fd0a"),
                            Name = "Logo"
                        },
                        new
                        {
                            Id = new Guid("40190c48-bb01-4570-9537-6beb52c6684d"),
                            Name = "Clojure"
                        },
                        new
                        {
                            Id = new Guid("ddaf802a-1b6b-4859-bb1a-7fa051575762"),
                            Name = "Elixir"
                        },
                        new
                        {
                            Id = new Guid("b46e083f-ce77-4969-a74c-1d3b0df4c7b7"),
                            Name = "Erlang"
                        },
                        new
                        {
                            Id = new Guid("1dfaadc2-eb65-456f-b43b-02f8c8f78e38"),
                            Name = "VHDL"
                        },
                        new
                        {
                            Id = new Guid("2a3abf15-478f-4f13-9233-7912f3c8deb8"),
                            Name = "Verilog"
                        },
                        new
                        {
                            Id = new Guid("7fa9a0da-20bb-41a5-9a5f-a3de288d91cb"),
                            Name = "SQL"
                        },
                        new
                        {
                            Id = new Guid("06f3f071-2c03-452c-a330-a80aa06ea2e2"),
                            Name = "HTML"
                        },
                        new
                        {
                            Id = new Guid("7d3af272-50b1-46ff-ba27-fbc08716429b"),
                            Name = "CSS"
                        },
                        new
                        {
                            Id = new Guid("1d7c4110-3a37-4c63-b053-731cefbe16fd"),
                            Name = "XML"
                        },
                        new
                        {
                            Id = new Guid("181200ab-bc90-4ec9-8add-f4a053f715b1"),
                            Name = "JSON"
                        },
                        new
                        {
                            Id = new Guid("5bee8f9f-a6fd-4d83-b2f3-3226bd29a680"),
                            Name = "Bash"
                        },
                        new
                        {
                            Id = new Guid("dc4d4acb-a277-4aa3-86ad-d0f6d64c3ca9"),
                            Name = "PowerShell"
                        },
                        new
                        {
                            Id = new Guid("a384b9e3-c3a4-402c-9915-d7e8ca2d45d7"),
                            Name = "Pascal"
                        },
                        new
                        {
                            Id = new Guid("6e89f176-7b4d-44f6-9b62-818dcf9d5401"),
                            Name = "Racket"
                        },
                        new
                        {
                            Id = new Guid("94d50d19-fc3d-4076-b907-8d62e86300eb"),
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
                            Id = new Guid("49a4e3f0-fce0-4c56-b52a-62dfb4c74eff"),
                            Author = "",
                            DateCreated = new DateTime(2023, 10, 29, 13, 14, 57, 446, DateTimeKind.Local).AddTicks(8570),
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
