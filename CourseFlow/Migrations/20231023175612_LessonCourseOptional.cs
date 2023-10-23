using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseFlow.Migrations
{
    public partial class LessonCourseOptional : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Courses_CourseId",
                table: "Lessons");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("03d16d3f-fcc5-426c-8c90-fca94d758802"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("05273464-a720-4d6d-972c-537bb0bab6ab"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0be3ad30-8756-4f77-8719-4f0c2675c9fc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0c0ccd7e-bfc3-43df-808c-5c1b0a5c3f59"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0e6fcac7-5609-42ac-9989-9f9be4f8259d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0fd68151-05a1-406f-ba51-e1c7da36c3b8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0fe492ae-8eda-4bc4-aecb-7b5ecec9d7c4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("10cecf55-95ad-4f4c-bf80-47d171d245f7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("14221e08-e5aa-4dea-acb8-038fdf4e2126"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("14d21c3e-8c08-49d1-85d9-879c97932a5d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1513803a-d677-4e78-8ab1-902abdc2bc36"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("16a7c62d-4b5c-4386-8fc8-0c2f38cb55fe"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1c3e3c78-e843-453c-90b4-6cb9384749ba"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1caac64c-07b9-4de8-9786-5f87b6ba3564"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1cdd9fb9-35b3-4807-89c9-693de58eac08"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1e065ad5-b706-4f1c-8c85-ec4915772dc6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1fb536c3-f43a-469b-beaa-e8e6a47d7531"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("21add2d6-6bb2-4ed5-9805-58a0188cc62b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2348b50b-61fc-4dd3-8cda-92f1b80f1ad3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("243aed24-d76b-44f0-8a6a-c77761c8987d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("24cbcd31-dcb2-4d5a-b0db-d62751c74bdf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2517b9d7-92e4-4674-8492-4a2290cafb11"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("27a4690b-2e2e-4b6d-93d9-67d7df000f58"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2a2985c0-99b5-473b-982d-290c817b70bc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("33d63ebd-1b2d-4d32-a43d-597dbbea0f39"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("372bd3d4-1663-42e3-9bd1-1273e3c809fb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("37d2c962-09bd-4dc4-b641-bc8cc0d5c85f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3914a0fe-9879-4d54-88ef-a95de5c09b2a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3c844cca-ec26-4c2c-a955-e791c16c49f3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("424ac841-9fbe-4525-a195-f78e2d3fbedf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("42c21b9d-0583-46c1-b3a3-9ee7764b24ea"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("47520141-5f6b-45e2-9706-853e2edd6bb1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4e77023e-96d1-4fa5-a189-cc274d7d08ee"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4f28cabf-ceb4-4f17-9f0f-e0aa33048180"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("522532d8-bdae-4111-b100-79b0a05c1510"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5287f0d5-68c1-4d2a-b778-25ec881e0413"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5345d9ad-37b6-472e-82ea-5dcb26e06d38"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("58ae2aa9-da75-49db-9e9c-c15cfc24921a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("58e95215-4cfe-4bd8-afd9-d35059382037"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5950bb4e-29ac-4a54-880b-b51b69da5861"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5d0da045-97f7-42ad-99c7-12b506cefdc1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5ef8410e-93b5-41f8-8168-991b4610f6c4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("61d101d0-ae4f-4563-9650-33dab3b1a075"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("635f2101-e202-4985-b942-042f8115ae6a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("64310c06-3684-43a3-b1c4-60df03519cd9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("64f4ab44-1f50-4d1b-9adf-28768355a988"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("69538aac-234e-4fc8-8d71-4c5c88c2f0cb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("69a1d394-53e7-4c94-8e7f-75cbdb476766"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6a5f34ce-8129-4556-ab87-6adaf2f6e011"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6d061777-070a-4768-a957-e529046a8da3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6e85f216-c947-4f13-9d9a-3eb698b06186"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6eae3951-f0df-4eac-b7cf-d918c7d7e5b3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("71713297-9759-4860-84c8-6f2c07d3a0c4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("71f47b9b-3bb4-410b-b708-4b59218cb225"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("73e7da3f-2f60-4d27-9de4-93981634060a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("748b67dc-a572-4c49-bbf9-a92a30bcf0d9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("79bccb1d-babe-40d1-82cb-7127af8a0974"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7af30b50-371a-4b50-bbba-2b1f6af9c366"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7b6def07-ac98-45a8-b2f1-fe5e2dac584f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81322fc8-8da8-4dfe-8710-22a580884939"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81dd3438-17b2-4cc9-af3e-8f6c66e7de45"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("83598441-6494-4b63-aa63-9fd55fecd102"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8397ba88-3b66-4f17-a3c1-4a17a34fb818"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("89b9a191-dfe8-4912-af5c-1e8b954bbacd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8cac88a0-82f8-4539-a1ca-9995d183443c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8ef2f4b9-79cf-47dc-b7a4-c9b8292efe8b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("91df7125-007c-4da8-a5dd-cfef73b4fa3b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("95e81204-ea84-4647-b35f-397fa91bb0a6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9cd5c967-17d1-4d45-b7f8-f9fef1d52ce8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a07d2f1e-0c6c-4b95-bd57-5d388d55b443"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a480bf32-d35a-43d5-8ba8-1b27e9ba8d68"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aafb7217-befe-4f9f-b492-23ddd337fde7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ad213095-0edb-4d38-8806-dd9e977036f1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b0704c9d-e35c-4a77-a18b-900dc2e50d40"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b6957db1-1da1-4112-a728-fc1a1b59e2f2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b7513584-8ca5-45af-b114-124baec92a4a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bad4ed8e-187d-49fb-bcc0-97a8e57ab0ac"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("be2870d3-1623-400a-95ca-d4ee6686ae49"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c1617eea-20bc-4e7e-bcad-58f8fc915c1a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c284ca11-5e48-4092-ba6b-b90e8fc91f9e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c36f438d-a9a1-4cfd-8b4f-4a12560fe226"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c72437d5-0ded-469f-a5ab-73ba55699efc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c78d16f1-8fb4-4596-b6c7-76b47f4de2da"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cafa63d6-3735-4dbc-920c-155132ceca6e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cb528368-52fd-48a2-b6c0-61daf0b4ed45"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cc9b3008-cc8b-49c5-a2a4-dafbe8911dcd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d2047e1e-f1e6-40ba-8b69-8aec31511b5c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d224d2a1-b877-422d-a7e2-fe9f187f9329"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d683270a-5f42-4f57-ab3f-42d58b81724c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d91b4371-5c84-426e-8ff5-e719d9328b89"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("da02d0a8-3e0f-4dda-98f2-92842d9973e4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e27ccb1c-0ed7-4880-986d-52430e8efb4a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ece8f626-93d1-4a6b-a536-907db30fdc59"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ede64d64-2388-488a-8674-4304fc7d3e12"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f361664b-077b-40b6-a7ea-c45e3f37db3c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f3692e5e-c2a4-4afe-ba6d-8357f0a55870"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f3707c25-0e1d-42cb-8989-5afa817cfb1c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f3b0a60e-de67-4b80-a301-86410a098c80"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f7a06ea6-2d99-457f-ab9b-a596c590a4c2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f94bec17-83be-46ef-87ec-4dfa0bd62e69"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fa4330f1-c84a-4b13-838f-af220522ca68"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fd8cda2d-e971-438e-8fb9-b9016ab3200f"));

            migrationBuilder.AlterColumn<Guid>(
                name: "CourseId",
                table: "Lessons",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("02209f4a-52f5-4a8a-b69f-252fe7d0afc2"), "Java" },
                    { new Guid("05be7165-ccf1-4bb2-b99d-0f139f1fdcaf"), "Perl" },
                    { new Guid("09f195f3-c48c-4695-8f2b-01ae7efd3dc2"), "Cybersecurity" },
                    { new Guid("1007354e-d1f4-4c15-9e92-85a1f2f4b548"), "SQL" },
                    { new Guid("19ab9711-69e2-4e13-9acf-ad87a28627ff"), "JavaScript" },
                    { new Guid("1bc5d269-fc0e-4069-82ca-a4f7053de818"), "PHP" },
                    { new Guid("1e35c324-28b9-482b-9a64-914b180704d3"), "Refactoring" },
                    { new Guid("242d93de-a9c3-48a7-8e7b-099fb20c98a6"), "Racket" },
                    { new Guid("2503bd41-39fe-459c-b91e-af232cccece8"), "Frontend Development" },
                    { new Guid("254e20d6-30ce-4b93-b852-926e0edfae24"), "PL/SQL" },
                    { new Guid("2744d859-3eaf-485e-81e3-8f00d02dbaa5"), "Design Patterns" },
                    { new Guid("2a389707-c37f-4b1f-9051-db344baf4a2f"), "Web Development" },
                    { new Guid("2f571a38-1509-4bb1-aa95-91de65dbec35"), "Kotlin" },
                    { new Guid("31b22eca-387d-4c35-87dc-787abafd821b"), "Functional Programming" },
                    { new Guid("397a0909-98d8-4564-89c6-1e6ed14e0c32"), "R" },
                    { new Guid("39ca98d2-3737-40b4-9e40-322a349d046b"), "Groovy" },
                    { new Guid("39f59d71-23e4-49bb-b167-04f0c9b434dd"), "Code Review" },
                    { new Guid("3b30ae5b-4341-40e8-a3b6-9d890155057b"), "C#" },
                    { new Guid("3e066e4b-c07b-4f21-b3a2-75a3bb321feb"), "Assembly" },
                    { new Guid("41173d9f-8f50-4c98-8756-d105d76aafac"), "Blockchain" },
                    { new Guid("42e81703-57ca-4292-8ec5-90b4d63dde75"), "Low-Level Programming" },
                    { new Guid("4854dd78-47be-414c-90f3-e1b55adc1a3f"), "Python" },
                    { new Guid("48cbad00-371b-4ee3-b3fd-1ea72518be7d"), "Artificial Intelligence" },
                    { new Guid("48fa7392-8e4a-4ce0-95a9-df1a9a2b5486"), "Software Testing" },
                    { new Guid("4b326a2a-d6d0-4169-97b9-c6c646883e56"), "Swift" },
                    { new Guid("4c54fc57-13e7-40d4-9748-0f85903ad503"), "Parallel Programming" },
                    { new Guid("4c9acd88-a41c-400f-82f4-caf32e1553e7"), "T-SQL" },
                    { new Guid("51316019-f700-449a-912d-26e67de93963"), "High-Level Programming" },
                    { new Guid("515c2ff7-8864-4eff-8a47-93f713185066"), "Elixir" },
                    { new Guid("540bb408-b100-41dc-9d01-3105b5404568"), "Julia" },
                    { new Guid("5a8b4254-f3db-4d0a-a7fa-f56a460bd6da"), "Prolog" },
                    { new Guid("5dd40923-fcb0-4ff3-a4fc-cdbe9b487969"), "Erlang" },
                    { new Guid("618967f5-7257-4459-bb8e-8ce6b9e6a9e9"), "UI/UX Design" },
                    { new Guid("62b447ab-efd5-435d-896c-bd63cc361d73"), "Bash" },
                    { new Guid("6558b674-3e16-4058-bb37-26f78acc9dda"), "Big Data" },
                    { new Guid("67250fb8-f4b8-427b-8eb8-5b05799cf3dd"), "Software Development Lifecycle" },
                    { new Guid("68db5608-2c80-4235-a2ce-7f53965ddcc8"), "Microservices" },
                    { new Guid("6acd56e6-e543-4e9c-9f51-c73d521d568e"), "Scheme" },
                    { new Guid("6b375bb2-1602-49cc-a79a-bc9d14a46e84"), "Pair Programming" },
                    { new Guid("6bd97c71-5faa-49a5-9608-c45d1d212c2e"), "Matlab" },
                    { new Guid("6c2e727a-94a0-4586-b815-ae64e440490e"), "HTML" },
                    { new Guid("718b4793-a1d1-45b6-8ae7-5e0089471fbb"), "Natural Language Processing" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("73558f68-d354-43cd-b2bf-b4e96c547f5e"), "Legacy Code Maintenance" },
                    { new Guid("73cbff9f-1352-41a8-ae19-b1ea12aca68d"), "Fortran" },
                    { new Guid("7a44fe3a-4ae2-47cc-8bac-e1eb8229088f"), "Responsive Design" },
                    { new Guid("7b094e0b-5341-4db6-8fa3-84e2b6fa9627"), "Full Stack Development" },
                    { new Guid("7b4fa6c5-8605-4462-93b5-4cbc35b5662e"), "VBScript" },
                    { new Guid("7d71b0b0-015e-44ec-a65e-f8a868fbf1b0"), "Virtual Reality" },
                    { new Guid("7e3a75b2-6887-4278-bacd-82d921b44c80"), "Go" },
                    { new Guid("81fb2919-7b05-40f3-a18b-ffa55949d3c2"), "RESTful APIs" },
                    { new Guid("827af0f1-e5ca-4b5b-b208-3bb2935bd19e"), "Code Optimization" },
                    { new Guid("82a8ecc4-a932-4096-9d72-62e8f8d16a86"), "Backend Development" },
                    { new Guid("82e44541-2374-42cd-bc7e-d329180377be"), "CSS" },
                    { new Guid("835adc47-f805-49bb-9fea-b19decffa4ee"), "Continuous Integration" },
                    { new Guid("83f29ea4-0b36-4d5c-a492-651a9c608bc0"), "F#" },
                    { new Guid("862cd591-e705-49d5-be6b-47dcc9be8cae"), "Game Development" },
                    { new Guid("8bfa8296-9c4e-40b0-ba13-fad650038110"), "Clojure" },
                    { new Guid("8d73ca83-bddb-4ae8-ab80-5a28fd6b42ff"), "Cloud Computing" },
                    { new Guid("8da10f74-a634-46e6-b18e-82ba8c0a36cf"), "Embedded Systems" },
                    { new Guid("928beb59-3c77-4c20-9e44-cfca965c5697"), "XML" },
                    { new Guid("93ccabca-3d78-4c27-bcac-f00f9da5454a"), "Verilog" },
                    { new Guid("99e8cf9d-319f-49d0-a0a6-94eb2c2870b1"), "PowerShell" },
                    { new Guid("9a654440-ba92-4e98-8c08-fb5a23a5984b"), "Haskell" },
                    { new Guid("9acf9694-b1c5-46a1-b39f-84078c1fce8a"), "Quantum Computing" },
                    { new Guid("9cabe68f-509c-4fbd-95b5-600a11f50ea3"), "Secure Coding Practices" },
                    { new Guid("9d474497-6a65-41df-8fa3-ce3b54067154"), "JSON" },
                    { new Guid("a2340903-7134-40d9-a1c3-b1b41b64d0b4"), "COBOL" },
                    { new Guid("a67d5e83-1849-47c6-a38d-c797762ed76d"), "Mobile App Development" },
                    { new Guid("a91a59a6-7026-4f48-8b6f-5b70029d10df"), "Dart" },
                    { new Guid("a9a54e85-7b38-4c4d-b0e6-92c8787bb516"), "GraphQL" },
                    { new Guid("aabdded7-be49-43d1-abeb-2f8d92f8782a"), "Agile Methodology" },
                    { new Guid("b2fdd6e8-6cd5-48cf-b201-26dbc4709473"), "Pascal" },
                    { new Guid("b5e72736-1168-4a73-8ffa-3e5614eadd31"), "Database Management" },
                    { new Guid("bf984ba0-cf88-482d-a7c1-c62d6163d5ca"), "Scrum" },
                    { new Guid("c7368f45-48e7-45dd-99d4-9d6634c58441"), "Code Documentation" },
                    { new Guid("ca63963e-b7d4-437d-9c69-d06a17271bcf"), "Version Control" },
                    { new Guid("cb810114-eb9e-46c2-a23d-69108c22dbf6"), "IoT Development" },
                    { new Guid("ce099427-d7eb-45b5-b87e-43cfe20cce74"), "Concurrency" },
                    { new Guid("cf61de3d-aba5-4f34-a8f1-0f7849fd6263"), "VHDL" },
                    { new Guid("d40c2c2c-188d-4a67-881d-27e6fe3ac734"), "Objective-C" },
                    { new Guid("d4251572-c6bf-4af6-b5d4-4998af43bd44"), "Project Management" },
                    { new Guid("d47fdec6-da0c-49d8-8ca1-990875f4c357"), "Kanban" },
                    { new Guid("d5cc2f8c-91fd-48f0-bd1e-d8dc2be0d6cc"), "Smalltalk" },
                    { new Guid("d6ff7a13-df7a-4cf2-b130-8d10de0116ba"), "Logo" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("d706fec6-eb7a-4a12-bb68-b2867e40a9ba"), "C++" },
                    { new Guid("d7b28ca4-86d7-42b0-879d-3250c10b3f81"), "TypeScript" },
                    { new Guid("da7ee0f8-483c-4cc3-b2ad-140ecf30c84d"), "Lua" },
                    { new Guid("dad86b90-20df-41dc-aa3f-61326847447a"), "DevOps" },
                    { new Guid("dd295385-4bd9-4e51-bd58-b9da026be491"), "Technical Debt" },
                    { new Guid("dd8dd621-5cd9-4e77-bd4b-0f21ad247085"), "Rust" },
                    { new Guid("e162360a-256b-4744-a8e5-988cc6cdc506"), "Ada" },
                    { new Guid("e1971a30-8c34-453e-a9bb-55fbcdf961b7"), "Software Architecture" },
                    { new Guid("e316d88c-4ac9-42d2-b9c3-46bb36b84e84"), "Object-Oriented Programming" },
                    { new Guid("e5bc8f66-b9d9-4855-804a-3ea6bcb305b6"), "Scala" },
                    { new Guid("e5e5c263-76c2-474c-b25b-9ba09750e976"), "Machine Learning" },
                    { new Guid("e6bd1862-192f-47b5-b593-7a67027de998"), "Augmented Reality" },
                    { new Guid("e8277d31-fb27-4ff5-94b8-c018bc9e3938"), "Code Quality" },
                    { new Guid("ec4fd0bf-9bcc-4a41-b556-2d639080fe75"), "Lisp" },
                    { new Guid("ef5a1215-511f-4876-a051-70f9c6dddfaf"), "Data Science" },
                    { new Guid("f37145d5-ff07-43cf-bfe0-569ab6f92847"), "Ada" },
                    { new Guid("f802308d-3548-41c7-a365-4acc30e31865"), "API Development" },
                    { new Guid("ffb54d7f-ae0c-4b3b-aabd-7505f1f5681d"), "Ruby" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Courses_CourseId",
                table: "Lessons",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Courses_CourseId",
                table: "Lessons");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("02209f4a-52f5-4a8a-b69f-252fe7d0afc2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("05be7165-ccf1-4bb2-b99d-0f139f1fdcaf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("09f195f3-c48c-4695-8f2b-01ae7efd3dc2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1007354e-d1f4-4c15-9e92-85a1f2f4b548"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("19ab9711-69e2-4e13-9acf-ad87a28627ff"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1bc5d269-fc0e-4069-82ca-a4f7053de818"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1e35c324-28b9-482b-9a64-914b180704d3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("242d93de-a9c3-48a7-8e7b-099fb20c98a6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2503bd41-39fe-459c-b91e-af232cccece8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("254e20d6-30ce-4b93-b852-926e0edfae24"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2744d859-3eaf-485e-81e3-8f00d02dbaa5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2a389707-c37f-4b1f-9051-db344baf4a2f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2f571a38-1509-4bb1-aa95-91de65dbec35"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("31b22eca-387d-4c35-87dc-787abafd821b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("397a0909-98d8-4564-89c6-1e6ed14e0c32"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("39ca98d2-3737-40b4-9e40-322a349d046b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("39f59d71-23e4-49bb-b167-04f0c9b434dd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3b30ae5b-4341-40e8-a3b6-9d890155057b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3e066e4b-c07b-4f21-b3a2-75a3bb321feb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("41173d9f-8f50-4c98-8756-d105d76aafac"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("42e81703-57ca-4292-8ec5-90b4d63dde75"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4854dd78-47be-414c-90f3-e1b55adc1a3f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("48cbad00-371b-4ee3-b3fd-1ea72518be7d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("48fa7392-8e4a-4ce0-95a9-df1a9a2b5486"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4b326a2a-d6d0-4169-97b9-c6c646883e56"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4c54fc57-13e7-40d4-9748-0f85903ad503"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4c9acd88-a41c-400f-82f4-caf32e1553e7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("51316019-f700-449a-912d-26e67de93963"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("515c2ff7-8864-4eff-8a47-93f713185066"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("540bb408-b100-41dc-9d01-3105b5404568"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5a8b4254-f3db-4d0a-a7fa-f56a460bd6da"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5dd40923-fcb0-4ff3-a4fc-cdbe9b487969"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("618967f5-7257-4459-bb8e-8ce6b9e6a9e9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("62b447ab-efd5-435d-896c-bd63cc361d73"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6558b674-3e16-4058-bb37-26f78acc9dda"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("67250fb8-f4b8-427b-8eb8-5b05799cf3dd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("68db5608-2c80-4235-a2ce-7f53965ddcc8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6acd56e6-e543-4e9c-9f51-c73d521d568e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6b375bb2-1602-49cc-a79a-bc9d14a46e84"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6bd97c71-5faa-49a5-9608-c45d1d212c2e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6c2e727a-94a0-4586-b815-ae64e440490e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("718b4793-a1d1-45b6-8ae7-5e0089471fbb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("73558f68-d354-43cd-b2bf-b4e96c547f5e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("73cbff9f-1352-41a8-ae19-b1ea12aca68d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7a44fe3a-4ae2-47cc-8bac-e1eb8229088f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7b094e0b-5341-4db6-8fa3-84e2b6fa9627"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7b4fa6c5-8605-4462-93b5-4cbc35b5662e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7d71b0b0-015e-44ec-a65e-f8a868fbf1b0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7e3a75b2-6887-4278-bacd-82d921b44c80"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81fb2919-7b05-40f3-a18b-ffa55949d3c2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("827af0f1-e5ca-4b5b-b208-3bb2935bd19e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("82a8ecc4-a932-4096-9d72-62e8f8d16a86"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("82e44541-2374-42cd-bc7e-d329180377be"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("835adc47-f805-49bb-9fea-b19decffa4ee"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("83f29ea4-0b36-4d5c-a492-651a9c608bc0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("862cd591-e705-49d5-be6b-47dcc9be8cae"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8bfa8296-9c4e-40b0-ba13-fad650038110"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8d73ca83-bddb-4ae8-ab80-5a28fd6b42ff"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8da10f74-a634-46e6-b18e-82ba8c0a36cf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("928beb59-3c77-4c20-9e44-cfca965c5697"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("93ccabca-3d78-4c27-bcac-f00f9da5454a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("99e8cf9d-319f-49d0-a0a6-94eb2c2870b1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9a654440-ba92-4e98-8c08-fb5a23a5984b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9acf9694-b1c5-46a1-b39f-84078c1fce8a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9cabe68f-509c-4fbd-95b5-600a11f50ea3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9d474497-6a65-41df-8fa3-ce3b54067154"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a2340903-7134-40d9-a1c3-b1b41b64d0b4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a67d5e83-1849-47c6-a38d-c797762ed76d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a91a59a6-7026-4f48-8b6f-5b70029d10df"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a9a54e85-7b38-4c4d-b0e6-92c8787bb516"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aabdded7-be49-43d1-abeb-2f8d92f8782a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b2fdd6e8-6cd5-48cf-b201-26dbc4709473"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b5e72736-1168-4a73-8ffa-3e5614eadd31"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bf984ba0-cf88-482d-a7c1-c62d6163d5ca"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c7368f45-48e7-45dd-99d4-9d6634c58441"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ca63963e-b7d4-437d-9c69-d06a17271bcf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cb810114-eb9e-46c2-a23d-69108c22dbf6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ce099427-d7eb-45b5-b87e-43cfe20cce74"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cf61de3d-aba5-4f34-a8f1-0f7849fd6263"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d40c2c2c-188d-4a67-881d-27e6fe3ac734"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d4251572-c6bf-4af6-b5d4-4998af43bd44"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d47fdec6-da0c-49d8-8ca1-990875f4c357"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d5cc2f8c-91fd-48f0-bd1e-d8dc2be0d6cc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d6ff7a13-df7a-4cf2-b130-8d10de0116ba"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d706fec6-eb7a-4a12-bb68-b2867e40a9ba"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d7b28ca4-86d7-42b0-879d-3250c10b3f81"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("da7ee0f8-483c-4cc3-b2ad-140ecf30c84d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dad86b90-20df-41dc-aa3f-61326847447a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dd295385-4bd9-4e51-bd58-b9da026be491"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dd8dd621-5cd9-4e77-bd4b-0f21ad247085"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e162360a-256b-4744-a8e5-988cc6cdc506"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e1971a30-8c34-453e-a9bb-55fbcdf961b7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e316d88c-4ac9-42d2-b9c3-46bb36b84e84"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e5bc8f66-b9d9-4855-804a-3ea6bcb305b6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e5e5c263-76c2-474c-b25b-9ba09750e976"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e6bd1862-192f-47b5-b593-7a67027de998"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e8277d31-fb27-4ff5-94b8-c018bc9e3938"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ec4fd0bf-9bcc-4a41-b556-2d639080fe75"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ef5a1215-511f-4876-a051-70f9c6dddfaf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f37145d5-ff07-43cf-bfe0-569ab6f92847"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f802308d-3548-41c7-a365-4acc30e31865"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ffb54d7f-ae0c-4b3b-aabd-7505f1f5681d"));

            migrationBuilder.AlterColumn<Guid>(
                name: "CourseId",
                table: "Lessons",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("03d16d3f-fcc5-426c-8c90-fca94d758802"), "Continuous Integration" },
                    { new Guid("05273464-a720-4d6d-972c-537bb0bab6ab"), "Matlab" },
                    { new Guid("0be3ad30-8756-4f77-8719-4f0c2675c9fc"), "Quantum Computing" },
                    { new Guid("0c0ccd7e-bfc3-43df-808c-5c1b0a5c3f59"), "Julia" },
                    { new Guid("0e6fcac7-5609-42ac-9989-9f9be4f8259d"), "Web Development" },
                    { new Guid("0fd68151-05a1-406f-ba51-e1c7da36c3b8"), "Python" },
                    { new Guid("0fe492ae-8eda-4bc4-aecb-7b5ecec9d7c4"), "Project Management" },
                    { new Guid("10cecf55-95ad-4f4c-bf80-47d171d245f7"), "Lisp" },
                    { new Guid("14221e08-e5aa-4dea-acb8-038fdf4e2126"), "XML" },
                    { new Guid("14d21c3e-8c08-49d1-85d9-879c97932a5d"), "High-Level Programming" },
                    { new Guid("1513803a-d677-4e78-8ab1-902abdc2bc36"), "IoT Development" },
                    { new Guid("16a7c62d-4b5c-4386-8fc8-0c2f38cb55fe"), "Objective-C" },
                    { new Guid("1c3e3c78-e843-453c-90b4-6cb9384749ba"), "Kanban" },
                    { new Guid("1caac64c-07b9-4de8-9786-5f87b6ba3564"), "PHP" },
                    { new Guid("1cdd9fb9-35b3-4807-89c9-693de58eac08"), "Natural Language Processing" },
                    { new Guid("1e065ad5-b706-4f1c-8c85-ec4915772dc6"), "Responsive Design" },
                    { new Guid("1fb536c3-f43a-469b-beaa-e8e6a47d7531"), "Data Science" },
                    { new Guid("21add2d6-6bb2-4ed5-9805-58a0188cc62b"), "Code Documentation" },
                    { new Guid("2348b50b-61fc-4dd3-8cda-92f1b80f1ad3"), "Erlang" },
                    { new Guid("243aed24-d76b-44f0-8a6a-c77761c8987d"), "Technical Debt" },
                    { new Guid("24cbcd31-dcb2-4d5a-b0db-d62751c74bdf"), "Object-Oriented Programming" },
                    { new Guid("2517b9d7-92e4-4674-8492-4a2290cafb11"), "VHDL" },
                    { new Guid("27a4690b-2e2e-4b6d-93d9-67d7df000f58"), "Frontend Development" },
                    { new Guid("2a2985c0-99b5-473b-982d-290c817b70bc"), "RESTful APIs" },
                    { new Guid("33d63ebd-1b2d-4d32-a43d-597dbbea0f39"), "Machine Learning" },
                    { new Guid("372bd3d4-1663-42e3-9bd1-1273e3c809fb"), "Elixir" },
                    { new Guid("37d2c962-09bd-4dc4-b641-bc8cc0d5c85f"), "Prolog" },
                    { new Guid("3914a0fe-9879-4d54-88ef-a95de5c09b2a"), "Mobile App Development" },
                    { new Guid("3c844cca-ec26-4c2c-a955-e791c16c49f3"), "COBOL" },
                    { new Guid("424ac841-9fbe-4525-a195-f78e2d3fbedf"), "Assembly" },
                    { new Guid("42c21b9d-0583-46c1-b3a3-9ee7764b24ea"), "Go" },
                    { new Guid("47520141-5f6b-45e2-9706-853e2edd6bb1"), "UI/UX Design" },
                    { new Guid("4e77023e-96d1-4fa5-a189-cc274d7d08ee"), "Perl" },
                    { new Guid("4f28cabf-ceb4-4f17-9f0f-e0aa33048180"), "F#" },
                    { new Guid("522532d8-bdae-4111-b100-79b0a05c1510"), "Lua" },
                    { new Guid("5287f0d5-68c1-4d2a-b778-25ec881e0413"), "Cybersecurity" },
                    { new Guid("5345d9ad-37b6-472e-82ea-5dcb26e06d38"), "Smalltalk" },
                    { new Guid("58ae2aa9-da75-49db-9e9c-c15cfc24921a"), "Racket" },
                    { new Guid("58e95215-4cfe-4bd8-afd9-d35059382037"), "Software Architecture" },
                    { new Guid("5950bb4e-29ac-4a54-880b-b51b69da5861"), "Rust" },
                    { new Guid("5d0da045-97f7-42ad-99c7-12b506cefdc1"), "Verilog" },
                    { new Guid("5ef8410e-93b5-41f8-8168-991b4610f6c4"), "JavaScript" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("61d101d0-ae4f-4563-9650-33dab3b1a075"), "Code Quality" },
                    { new Guid("635f2101-e202-4985-b942-042f8115ae6a"), "GraphQL" },
                    { new Guid("64310c06-3684-43a3-b1c4-60df03519cd9"), "Artificial Intelligence" },
                    { new Guid("64f4ab44-1f50-4d1b-9adf-28768355a988"), "DevOps" },
                    { new Guid("69538aac-234e-4fc8-8d71-4c5c88c2f0cb"), "Bash" },
                    { new Guid("69a1d394-53e7-4c94-8e7f-75cbdb476766"), "Scheme" },
                    { new Guid("6a5f34ce-8129-4556-ab87-6adaf2f6e011"), "Version Control" },
                    { new Guid("6d061777-070a-4768-a957-e529046a8da3"), "Haskell" },
                    { new Guid("6e85f216-c947-4f13-9d9a-3eb698b06186"), "Backend Development" },
                    { new Guid("6eae3951-f0df-4eac-b7cf-d918c7d7e5b3"), "Blockchain" },
                    { new Guid("71713297-9759-4860-84c8-6f2c07d3a0c4"), "Code Review" },
                    { new Guid("71f47b9b-3bb4-410b-b708-4b59218cb225"), "PowerShell" },
                    { new Guid("73e7da3f-2f60-4d27-9de4-93981634060a"), "Parallel Programming" },
                    { new Guid("748b67dc-a572-4c49-bbf9-a92a30bcf0d9"), "Pascal" },
                    { new Guid("79bccb1d-babe-40d1-82cb-7127af8a0974"), "PL/SQL" },
                    { new Guid("7af30b50-371a-4b50-bbba-2b1f6af9c366"), "Embedded Systems" },
                    { new Guid("7b6def07-ac98-45a8-b2f1-fe5e2dac584f"), "API Development" },
                    { new Guid("81322fc8-8da8-4dfe-8710-22a580884939"), "Pair Programming" },
                    { new Guid("81dd3438-17b2-4cc9-af3e-8f6c66e7de45"), "R" },
                    { new Guid("83598441-6494-4b63-aa63-9fd55fecd102"), "Game Development" },
                    { new Guid("8397ba88-3b66-4f17-a3c1-4a17a34fb818"), "Groovy" },
                    { new Guid("89b9a191-dfe8-4912-af5c-1e8b954bbacd"), "Cloud Computing" },
                    { new Guid("8cac88a0-82f8-4539-a1ca-9995d183443c"), "HTML" },
                    { new Guid("8ef2f4b9-79cf-47dc-b7a4-c9b8292efe8b"), "Ruby" },
                    { new Guid("91df7125-007c-4da8-a5dd-cfef73b4fa3b"), "Logo" },
                    { new Guid("95e81204-ea84-4647-b35f-397fa91bb0a6"), "Legacy Code Maintenance" },
                    { new Guid("9cd5c967-17d1-4d45-b7f8-f9fef1d52ce8"), "Java" },
                    { new Guid("a07d2f1e-0c6c-4b95-bd57-5d388d55b443"), "Agile Methodology" },
                    { new Guid("a480bf32-d35a-43d5-8ba8-1b27e9ba8d68"), "Secure Coding Practices" },
                    { new Guid("aafb7217-befe-4f9f-b492-23ddd337fde7"), "TypeScript" },
                    { new Guid("ad213095-0edb-4d38-8806-dd9e977036f1"), "Low-Level Programming" },
                    { new Guid("b0704c9d-e35c-4a77-a18b-900dc2e50d40"), "Ada" },
                    { new Guid("b6957db1-1da1-4112-a728-fc1a1b59e2f2"), "Software Development Lifecycle" },
                    { new Guid("b7513584-8ca5-45af-b114-124baec92a4a"), "C++" },
                    { new Guid("bad4ed8e-187d-49fb-bcc0-97a8e57ab0ac"), "CSS" },
                    { new Guid("be2870d3-1623-400a-95ca-d4ee6686ae49"), "C#" },
                    { new Guid("c1617eea-20bc-4e7e-bcad-58f8fc915c1a"), "Scala" },
                    { new Guid("c284ca11-5e48-4092-ba6b-b90e8fc91f9e"), "Ada" },
                    { new Guid("c36f438d-a9a1-4cfd-8b4f-4a12560fe226"), "Functional Programming" },
                    { new Guid("c72437d5-0ded-469f-a5ab-73ba55699efc"), "JSON" },
                    { new Guid("c78d16f1-8fb4-4596-b6c7-76b47f4de2da"), "Fortran" },
                    { new Guid("cafa63d6-3735-4dbc-920c-155132ceca6e"), "SQL" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("cb528368-52fd-48a2-b6c0-61daf0b4ed45"), "Kotlin" },
                    { new Guid("cc9b3008-cc8b-49c5-a2a4-dafbe8911dcd"), "Clojure" },
                    { new Guid("d2047e1e-f1e6-40ba-8b69-8aec31511b5c"), "Code Optimization" },
                    { new Guid("d224d2a1-b877-422d-a7e2-fe9f187f9329"), "Microservices" },
                    { new Guid("d683270a-5f42-4f57-ab3f-42d58b81724c"), "VBScript" },
                    { new Guid("d91b4371-5c84-426e-8ff5-e719d9328b89"), "Scrum" },
                    { new Guid("da02d0a8-3e0f-4dda-98f2-92842d9973e4"), "T-SQL" },
                    { new Guid("e27ccb1c-0ed7-4880-986d-52430e8efb4a"), "Design Patterns" },
                    { new Guid("ece8f626-93d1-4a6b-a536-907db30fdc59"), "Augmented Reality" },
                    { new Guid("ede64d64-2388-488a-8674-4304fc7d3e12"), "Swift" },
                    { new Guid("f361664b-077b-40b6-a7ea-c45e3f37db3c"), "Virtual Reality" },
                    { new Guid("f3692e5e-c2a4-4afe-ba6d-8357f0a55870"), "Full Stack Development" },
                    { new Guid("f3707c25-0e1d-42cb-8989-5afa817cfb1c"), "Refactoring" },
                    { new Guid("f3b0a60e-de67-4b80-a301-86410a098c80"), "Dart" },
                    { new Guid("f7a06ea6-2d99-457f-ab9b-a596c590a4c2"), "Software Testing" },
                    { new Guid("f94bec17-83be-46ef-87ec-4dfa0bd62e69"), "Concurrency" },
                    { new Guid("fa4330f1-c84a-4b13-838f-af220522ca68"), "Big Data" },
                    { new Guid("fd8cda2d-e971-438e-8fb9-b9016ab3200f"), "Database Management" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Courses_CourseId",
                table: "Lessons",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
