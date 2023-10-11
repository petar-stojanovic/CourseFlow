using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseFlow.Migrations
{
    public partial class refactor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Thumbnail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    AuthToken = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CourseCategories",
                columns: table => new
                {
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseCategories", x => new { x.CourseId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_CourseCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseCategories_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Thumbnail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lessons_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AuthorCourses",
                columns: table => new
                {
                    AuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorCourses", x => new { x.AuthorId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_AuthorCourses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorCourses_Users_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTakesCourses",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Progress = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTakesCourses", x => new { x.UserId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_UserTakesCourses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserTakesCourses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("04620bf9-2043-48c7-a696-0e978fae47ec"), "Agile Methodology" },
                    { new Guid("06be615c-7618-4b2e-8db5-83157521f462"), "API Development" },
                    { new Guid("07abd33e-1a0d-4020-b432-d5461384a951"), "C++" },
                    { new Guid("08dd7439-f586-45fb-89b9-c7e4bf2643a9"), "Functional Programming" },
                    { new Guid("0a6d2b85-8855-4fdd-a0e8-9a1926cf3d21"), "Frontend Development" },
                    { new Guid("0d10093d-6dd0-43ba-9432-dd05d3fd7846"), "Natural Language Processing" },
                    { new Guid("10c76e75-69d8-423d-863a-70f78b51160e"), "Assembly" },
                    { new Guid("155c7de2-bb45-4b74-aa9d-bdd0074e049f"), "Groovy" },
                    { new Guid("17a79757-7fb9-447e-bfb1-78e149c0e477"), "Lua" },
                    { new Guid("1811212a-d15e-4aff-b2e4-d44e18f22e3d"), "Prolog" },
                    { new Guid("197be529-b2ff-4d16-8a8d-f6d34719df9e"), "R" },
                    { new Guid("1ee7f5b7-6c3c-4185-8cf8-44b42b680a04"), "Blockchain" },
                    { new Guid("1f520b58-1dad-4a48-9033-c451d72756b8"), "Ruby" },
                    { new Guid("2044d03e-bb7a-466d-8428-534c134cb3bb"), "Machine Learning" },
                    { new Guid("2053e88f-8376-4f18-b2b1-4084ecdd42ec"), "Logo" },
                    { new Guid("223d9ef7-b824-46e2-b211-20ccb2ea87ec"), "Objective-C" },
                    { new Guid("232c289e-65a9-42d9-9371-d571fac07d7f"), "Software Architecture" },
                    { new Guid("24080e22-4015-434e-8b41-7d741ee8d0a5"), "Code Optimization" },
                    { new Guid("292f016b-84df-4371-93bb-a80f8dd585c5"), "Cloud Computing" },
                    { new Guid("2eceb836-b30a-444d-87e4-389747efebae"), "XML" },
                    { new Guid("2f07064e-fbcc-433f-8b34-712bd4ca546c"), "COBOL" },
                    { new Guid("2f77e7d2-911b-4d59-acd0-5388e8ddc048"), "Embedded Systems" },
                    { new Guid("37eaa9b8-6ab2-4e7b-a3b1-951f13dd5695"), "CSS" },
                    { new Guid("39fc3304-5624-4972-98a6-16fed573bbf4"), "Mobile App Development" },
                    { new Guid("3d39bd98-71a0-4dcf-a061-358f98a716ee"), "Cybersecurity" },
                    { new Guid("3e537ae0-cef3-496f-8bf5-19b625b20b45"), "Legacy Code Maintenance" },
                    { new Guid("4344826d-da8e-4075-a677-d44111a64605"), "Matlab" },
                    { new Guid("4997e2d5-377a-40a8-9a94-1c00821066c4"), "Kanban" },
                    { new Guid("4a0edcb9-07b1-45b5-ac4a-5aea970895e4"), "T-SQL" },
                    { new Guid("4a7815bd-af45-41ac-a9a3-0938af0b6fcd"), "Augmented Reality" },
                    { new Guid("4a9209a8-c67e-42f8-8701-96ebd13cebbd"), "Technical Debt" },
                    { new Guid("4afa7081-0c64-445b-9175-4cb89ff8ed2a"), "Go" },
                    { new Guid("4cf98105-9dbd-4fb0-8ca0-f59dc274b641"), "Web Development" },
                    { new Guid("5054fe61-a50b-4eed-8cff-87911b36c340"), "PHP" },
                    { new Guid("561b5854-57f8-47ad-ab29-999b89e1bc2b"), "Ada" },
                    { new Guid("59564e85-348f-4ca2-88bf-fa6a394f7707"), "PL/SQL" },
                    { new Guid("5aadcc48-b623-4f1a-95c8-612f889621bf"), "Secure Coding Practices" },
                    { new Guid("5e6d4b1d-f75a-4eaf-b4ee-9aa4ae2346bf"), "Erlang" },
                    { new Guid("5f4f4541-e4fd-4afd-9951-1747e9bce7e4"), "Virtual Reality" },
                    { new Guid("619f2c84-c69e-4b32-9da5-35df1fe50428"), "Julia" },
                    { new Guid("67a07691-cdf9-4efb-8dc4-95025583b716"), "Pascal" },
                    { new Guid("67cc392e-2c51-44f6-838b-1cf63fbf109a"), "Dart" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("6f008ad8-1502-43e5-bca2-ba071eac24c4"), "Software Testing" },
                    { new Guid("6f2e9fe7-77b3-4598-b8a1-7dbcf48f32bd"), "Data Science" },
                    { new Guid("71b7f811-c9a1-491a-8000-cf09e792bc3e"), "Swift" },
                    { new Guid("74aeb996-6ab7-43d3-8598-b42499263a2b"), "Backend Development" },
                    { new Guid("751828b6-65fd-42f5-93e2-58d101fe5232"), "Ada" },
                    { new Guid("7633a232-58fb-4089-8362-db8a859828db"), "Concurrency" },
                    { new Guid("7be0e5d1-c785-4f45-befb-a74f669708b2"), "Scala" },
                    { new Guid("7d2967a5-af65-4ed4-a935-4a312bc85bed"), "Pair Programming" },
                    { new Guid("7d775a91-6299-43e6-8f4f-26dd8334c332"), "Python" },
                    { new Guid("7e11e018-f020-4fc3-831f-ae01f5ec34c9"), "DevOps" },
                    { new Guid("7edbdfec-5fb5-45a5-b563-35a7bccac81f"), "PowerShell" },
                    { new Guid("8055f0a6-901f-499b-9fc6-b43eab151b25"), "Object-Oriented Programming" },
                    { new Guid("867bfff3-2582-412a-95f1-c815f0330448"), "Fortran" },
                    { new Guid("8859f0f5-695d-492d-a929-ef1311de10e9"), "TypeScript" },
                    { new Guid("88b5c06b-e956-49d1-aa37-d8b0f3f826d0"), "Responsive Design" },
                    { new Guid("898df79c-99b6-4532-bb25-4f03201e8aed"), "Racket" },
                    { new Guid("8ad724eb-ae7a-4ad7-ab2b-5710a1bc8666"), "GraphQL" },
                    { new Guid("8d1a88ea-d077-4be5-87cc-732f6556bd9c"), "Database Management" },
                    { new Guid("8d439638-c809-4f2f-9033-2fe881bba73a"), "Elixir" },
                    { new Guid("9376ec11-4461-487d-a492-699b365f47f8"), "Rust" },
                    { new Guid("9410945d-c712-4255-9b41-c8b9d19c8740"), "Artificial Intelligence" },
                    { new Guid("986fc42c-c976-46e9-b5ff-53bbb73caef5"), "C#" },
                    { new Guid("9ad42243-a39d-4f0a-b377-8004ef0e3323"), "Code Review" },
                    { new Guid("9c6adaff-6a41-4c2d-af18-8aa742a30316"), "Lisp" },
                    { new Guid("a0334266-e05c-4844-8f8d-abd8767904e0"), "Parallel Programming" },
                    { new Guid("a253722b-5033-4b56-8f2a-70ce0e8bf329"), "High-Level Programming" },
                    { new Guid("a2c2e9c8-4232-4d53-9ca3-1c0a70ea4c5f"), "Perl" },
                    { new Guid("a441d66c-5c12-4ded-819f-67f4deb039d5"), "Design Patterns" },
                    { new Guid("a4f43656-1062-4bdc-b857-55c43044cc5f"), "Big Data" },
                    { new Guid("a6bb08d5-bd04-4da3-817a-799d09462535"), "HTML" },
                    { new Guid("a706831d-1ebb-440f-9592-45995a8fa5c7"), "Smalltalk" },
                    { new Guid("a9104aee-9381-46e1-8c8d-d257a7e3ba35"), "JavaScript" },
                    { new Guid("ac93a57f-fa47-4625-bb8f-08b6d42f7375"), "Software Development Lifecycle" },
                    { new Guid("ad66ba78-d650-4285-bf32-4860ffc1dcb7"), "Java" },
                    { new Guid("aedf5e3c-8b49-4327-ac71-edde3719c713"), "Game Development" },
                    { new Guid("b39c491a-9480-45ea-9a1c-db6a65aceb51"), "Low-Level Programming" },
                    { new Guid("bac05776-48dc-47d0-946e-29bf37def2c3"), "SQL" },
                    { new Guid("bd92f6b6-c080-47eb-b8ec-39e890270e07"), "Code Documentation" },
                    { new Guid("bdc6c930-2d81-4c01-bc04-ad13aaf4e699"), "RESTful APIs" },
                    { new Guid("c406c36d-cd6a-4d5b-a4e3-7b50c5633448"), "Clojure" },
                    { new Guid("ca4a190f-78d5-4473-b3a2-4a319e854d2e"), "Bash" },
                    { new Guid("ca816d39-180f-4cae-86af-db3cf95bd058"), "Code Quality" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("cb80e16f-1246-4e99-854e-0b79324b0c0b"), "VHDL" },
                    { new Guid("cd010c05-dbc7-4971-a1d3-9200fbadf87c"), "Project Management" },
                    { new Guid("d01127ac-d3a2-4439-8464-07c1a5f75792"), "Verilog" },
                    { new Guid("d0808e2d-7d87-4fc6-b37e-a3a8a2f4f879"), "IoT Development" },
                    { new Guid("d2b9d9ca-a3ed-4302-84ef-8f849d470a77"), "Full Stack Development" },
                    { new Guid("d476145a-f196-427e-b841-4ec18ffe4d2c"), "Scrum" },
                    { new Guid("d502b6f7-7e2e-4975-9c0d-9d3572c2cdf7"), "Kotlin" },
                    { new Guid("d959452c-7445-4b7a-8725-68f48396d59b"), "Refactoring" },
                    { new Guid("dd1c5f59-bb83-4d2a-8e96-342a4bcf6215"), "Microservices" },
                    { new Guid("e03e4c1b-f95b-43c4-81f8-e8f5702ea0b1"), "Haskell" },
                    { new Guid("e2b31dbb-1f20-46df-9b3c-5dfd343a975a"), "UI/UX Design" },
                    { new Guid("eec0462e-41ed-49c4-ba20-104c638c48d4"), "F#" },
                    { new Guid("ef342fa3-b235-4052-9eab-34c790615134"), "JSON" },
                    { new Guid("f129fcfe-4e7c-4a49-bff9-9f0c4d7a3039"), "Scheme" },
                    { new Guid("f2c55610-5995-4b2d-bc8e-9ed182907676"), "Continuous Integration" },
                    { new Guid("f6ce080a-48a7-49f3-b783-0c8c10ebbedd"), "VBScript" },
                    { new Guid("fa49846e-6e36-458b-9fd1-d964b4b0b39a"), "Quantum Computing" },
                    { new Guid("fc069353-c86e-4eb9-8f77-2386e3f29c01"), "Version Control" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorCourses_CourseId",
                table: "AuthorCourses",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseCategories_CategoryId",
                table: "CourseCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_CourseId",
                table: "Lessons",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTakesCourses_CourseId",
                table: "UserTakesCourses",
                column: "CourseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorCourses");

            migrationBuilder.DropTable(
                name: "CourseCategories");

            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.DropTable(
                name: "UserTakesCourses");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
