﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseFlow.Migrations
{
    public partial class AddCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("01f05b4a-2129-4455-9937-bcc2eb4f4bab"), "Mobile App Development" },
                    { new Guid("06d004c5-2abd-4965-a8e4-db8da3d359b2"), "Go" },
                    { new Guid("09fc7de4-4fc5-4f6a-a936-45235d3129ed"), "Functional Programming" },
                    { new Guid("0aa4a29f-e27d-4c96-95be-83966b02f537"), "Database Management" },
                    { new Guid("0b5e097b-15a2-4b11-b965-92d98afead1a"), "GraphQL" },
                    { new Guid("0d5cb29b-da83-4749-a8de-553320df2dc2"), "Parallel Programming" },
                    { new Guid("12017ca5-dee1-4b41-964e-7cab25b5373c"), "Responsive Design" },
                    { new Guid("14d6a040-244d-4ea2-9eb6-811213ffd7e7"), "Secure Coding Practices" },
                    { new Guid("175d8a8e-d87e-4f08-873f-8dd4abb67699"), "Code Quality" },
                    { new Guid("17888965-3c25-4f46-9d37-cfc9e07765f6"), "Ada" },
                    { new Guid("1a3013df-32c3-4089-9b54-73e4853ddc48"), "Fortran" },
                    { new Guid("1a608180-63a2-44f7-a6f1-eb3f8d565979"), "Lua" },
                    { new Guid("1be53e8b-ae97-4c47-ac09-8ad58cd1dfbb"), "Prolog" },
                    { new Guid("2054280b-ff79-4841-9650-3ea64fb6aad6"), "Kotlin" },
                    { new Guid("218146cc-f3d6-4296-8309-db803fdc1f13"), "COBOL" },
                    { new Guid("21e7d8b1-4365-445a-b475-b1007e947364"), "Data Science" },
                    { new Guid("23175b70-cf3e-4aa5-97b8-e93823451dff"), "Big Data" },
                    { new Guid("236e5d4e-5ba0-4535-bfa5-a45a0170e0cd"), "Natural Language Processing" },
                    { new Guid("2aa83de1-9237-462f-a87c-aec3436f08c8"), "Code Documentation" },
                    { new Guid("2de3f0bc-050e-4ddb-ac38-21682efeb2ab"), "Elixir" },
                    { new Guid("30b011b4-2c9e-43f2-bbdb-152906365248"), "Objective-C" },
                    { new Guid("338366bd-dd61-4ac1-bc1e-95c91d659653"), "Cloud Computing" },
                    { new Guid("47119f71-f2e9-471c-a300-41f71502fe2b"), "Rust" },
                    { new Guid("49b76215-2564-4f4a-b18e-e93a1f238e2b"), "Backend Development" },
                    { new Guid("4a2f20e3-2972-4139-bc22-f4e51a65f2f0"), "Project Management" },
                    { new Guid("4a5ac8b0-58db-4889-b59e-7a759b7b6157"), "DevOps" },
                    { new Guid("4bd3d804-50fd-4a8b-9190-22e1786880a3"), "Groovy" },
                    { new Guid("4d40c325-127a-4f39-87bb-32203b5fe07a"), "PowerShell" },
                    { new Guid("5234b5f8-4ee6-4455-95b5-5f62e514da8e"), "C++" },
                    { new Guid("53813670-bbea-4c29-a096-3fc0cdb06021"), "VHDL" },
                    { new Guid("5396b5f6-0b68-4146-a4e0-0e6ca7b0c58a"), "Matlab" },
                    { new Guid("5417afd6-93c8-4e8d-876f-1f1b73663552"), "Pair Programming" },
                    { new Guid("58fada09-43ce-4fe0-986a-db41959b5e27"), "Pascal" },
                    { new Guid("5974070e-cd11-4bb3-896b-eeb1b097d0f4"), "Ruby" },
                    { new Guid("61013bd1-0b5e-496b-89c0-97a1c8848419"), "Python" },
                    { new Guid("61c715c6-23f5-47bf-93c4-8d17b71a0f6a"), "Smalltalk" },
                    { new Guid("63bfae64-393c-45de-933a-a4777b1cfff7"), "Concurrency" },
                    { new Guid("667dd4bf-55a6-4d20-ab32-6372fe03ff6a"), "Object-Oriented Programming" },
                    { new Guid("67cfd6df-a845-4738-83db-f19f6c200bee"), "Virtual Reality" },
                    { new Guid("6bae9eed-09f9-4ac7-8dad-39e809f0d56c"), "Software Development Lifecycle" },
                    { new Guid("6da29cf5-f3d1-4084-aa78-74bf104190d9"), "JavaScript" },
                    { new Guid("709be293-08b3-41c1-9567-54fbf5dede54"), "High-Level Programming" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("70d67ee9-36ea-4110-a989-b3c25a1e51c9"), "Verilog" },
                    { new Guid("71bb4e14-8b34-4231-a0ad-94576a5e2daa"), "API Development" },
                    { new Guid("71c663f0-e755-48c8-9900-c16b62d88c99"), "Agile Methodology" },
                    { new Guid("71ff9e6e-f98f-4275-b203-a4b0d4588433"), "Game Development" },
                    { new Guid("736bfb74-31e8-45a2-a689-bb436d7280cf"), "UI/UX Design" },
                    { new Guid("7454a2aa-33f3-47eb-817a-2520b1a53299"), "Full Stack Development" },
                    { new Guid("7766c9d7-46b0-495b-a50a-9090aab57bd6"), "Erlang" },
                    { new Guid("7a8a702a-df93-4c3d-86da-86ec48458cc5"), "PHP" },
                    { new Guid("7adc71bb-bda0-419c-bedd-11271ac8ab9c"), "Augmented Reality" },
                    { new Guid("7bcd7ec6-2fe7-469f-9e2b-9a764d9194dc"), "Ada" },
                    { new Guid("81de5c4a-b44c-4d9c-9965-ae15c0bf38c1"), "Code Review" },
                    { new Guid("828a074a-f0d6-4dc8-8fc6-d3a3da2edb01"), "Code Optimization" },
                    { new Guid("8347b189-0f70-4489-a1d3-9d0ab333ea9f"), "HTML" },
                    { new Guid("887171f5-ac49-4068-a163-cc79e9372fbf"), "T-SQL" },
                    { new Guid("89831178-9b6b-40ff-9a4f-a39ad21f335f"), "Blockchain" },
                    { new Guid("8e6ed184-d609-49ef-b972-3f224ba9962b"), "Artificial Intelligence" },
                    { new Guid("8eaef4d6-4c51-4c65-bf5b-4c585c1cbaae"), "Refactoring" },
                    { new Guid("90fbd727-578e-4250-9103-9c9e36d1f0eb"), "SQL" },
                    { new Guid("92d4ed0d-b7f3-4a45-bfd5-67988797a082"), "Scrum" },
                    { new Guid("9560e5ed-06ea-4a8c-a937-3c8aaeb8509c"), "Web Development" },
                    { new Guid("95f7eda4-5097-4687-9156-8ac96209dde9"), "Low-Level Programming" },
                    { new Guid("97ffc9c3-43c4-4a7d-beb5-da686e00735e"), "Design Patterns" },
                    { new Guid("985408d8-1b11-4fd7-9550-2c96044156b4"), "Kanban" },
                    { new Guid("9e9f5dc7-a4c5-4142-a86c-ac535f789317"), "Java" },
                    { new Guid("9f0e12d2-542a-4794-9f37-a1810ff14cb5"), "Legacy Code Maintenance" },
                    { new Guid("a8091d4e-c543-41e9-b938-fd6b67134c0f"), "VBScript" },
                    { new Guid("a8ae5821-bc10-45b5-a589-526bd88f1b2d"), "Haskell" },
                    { new Guid("a92f121e-d00e-4030-9296-04ac4f9ccbf8"), "CSS" },
                    { new Guid("b144d351-d10a-41c0-84dc-f54999974e2a"), "Version Control" },
                    { new Guid("b4aab2a2-04c0-4de0-bb0e-9ffbff5c7aed"), "PL/SQL" },
                    { new Guid("b63b916d-5c7a-488b-b78a-8d28abc8c32c"), "Quantum Computing" },
                    { new Guid("b6f9d2b9-7074-42f0-90ab-d5e5598e52f1"), "Perl" },
                    { new Guid("ba52b848-e188-4df6-97e0-8bd157785232"), "Cybersecurity" },
                    { new Guid("becd12b3-f9a2-4ff0-aa5f-262657312044"), "RESTful APIs" },
                    { new Guid("c001f5c5-225e-4dd6-896a-1ebe4a67b730"), "Lisp" },
                    { new Guid("c24554d7-6535-498f-958b-10a650d9989b"), "Machine Learning" },
                    { new Guid("c2d4f00d-bae8-4ab2-99c1-f50f854a4d81"), "R" },
                    { new Guid("c693e1fb-bfe3-4ef4-a4a9-0f8fc1a44cc4"), "F#" },
                    { new Guid("caa2f430-c824-4798-9dab-9dfdfd3499a8"), "Embedded Systems" },
                    { new Guid("ccc3a2d9-29c0-43a2-a821-47b8cefb1633"), "JSON" },
                    { new Guid("cce9d094-2bd7-44d6-a5c0-98b2c939db1f"), "Frontend Development" },
                    { new Guid("d195e31b-c534-4157-bedf-c8b544c7e359"), "XML" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("d4351e26-b74c-4ccf-b918-88d7e128dfde"), "Software Testing" },
                    { new Guid("d6ca1f7c-11ec-4a56-9983-9881b9f84055"), "Technical Debt" },
                    { new Guid("d7f8d59d-a2b9-45e4-a453-7a77e3c5cb38"), "C#" },
                    { new Guid("d8635dfc-0a98-446e-8cb9-5ef12e35e093"), "Scheme" },
                    { new Guid("db35b22a-21a5-4213-98ef-48e8c9179bec"), "IoT Development" },
                    { new Guid("dce28c4e-2b83-46fd-9784-f5ccd27b8121"), "Clojure" },
                    { new Guid("dd9ba8ef-998d-41a0-897d-9f2087bd14ce"), "Racket" },
                    { new Guid("e1ff5047-adb0-4e8c-9d17-ed5dc57eac69"), "Bash" },
                    { new Guid("e22f97b3-140e-4da3-b207-242fd0dec85d"), "Microservices" },
                    { new Guid("e430024f-65d2-4b76-9b16-8edb7c1e1169"), "Software Architecture" },
                    { new Guid("ea695b59-0e05-48b4-9366-eb9cfc583967"), "Dart" },
                    { new Guid("ecd0d12d-0047-4869-9e1f-98452bdfbb4e"), "TypeScript" },
                    { new Guid("f03f91b4-faaf-475d-98ec-a3f307117116"), "Julia" },
                    { new Guid("f579d5ed-746a-43f8-9cd6-55212a921c98"), "Swift" },
                    { new Guid("f90762ce-60ef-4c06-a4a3-42e810252b94"), "Continuous Integration" },
                    { new Guid("fc1844fd-626a-4ad2-a3e4-be3c0366af17"), "Scala" },
                    { new Guid("fca20849-e02a-4afe-bdf6-cfd491d97282"), "Assembly" },
                    { new Guid("ff1ac1b0-b6b0-4243-9c24-9939b72aa5cd"), "Logo" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("01f05b4a-2129-4455-9937-bcc2eb4f4bab"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("06d004c5-2abd-4965-a8e4-db8da3d359b2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("09fc7de4-4fc5-4f6a-a936-45235d3129ed"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0aa4a29f-e27d-4c96-95be-83966b02f537"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0b5e097b-15a2-4b11-b965-92d98afead1a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0d5cb29b-da83-4749-a8de-553320df2dc2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("12017ca5-dee1-4b41-964e-7cab25b5373c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("14d6a040-244d-4ea2-9eb6-811213ffd7e7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("175d8a8e-d87e-4f08-873f-8dd4abb67699"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("17888965-3c25-4f46-9d37-cfc9e07765f6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1a3013df-32c3-4089-9b54-73e4853ddc48"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1a608180-63a2-44f7-a6f1-eb3f8d565979"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1be53e8b-ae97-4c47-ac09-8ad58cd1dfbb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2054280b-ff79-4841-9650-3ea64fb6aad6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("218146cc-f3d6-4296-8309-db803fdc1f13"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("21e7d8b1-4365-445a-b475-b1007e947364"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("23175b70-cf3e-4aa5-97b8-e93823451dff"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("236e5d4e-5ba0-4535-bfa5-a45a0170e0cd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2aa83de1-9237-462f-a87c-aec3436f08c8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2de3f0bc-050e-4ddb-ac38-21682efeb2ab"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("30b011b4-2c9e-43f2-bbdb-152906365248"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("338366bd-dd61-4ac1-bc1e-95c91d659653"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("47119f71-f2e9-471c-a300-41f71502fe2b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("49b76215-2564-4f4a-b18e-e93a1f238e2b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4a2f20e3-2972-4139-bc22-f4e51a65f2f0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4a5ac8b0-58db-4889-b59e-7a759b7b6157"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4bd3d804-50fd-4a8b-9190-22e1786880a3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4d40c325-127a-4f39-87bb-32203b5fe07a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5234b5f8-4ee6-4455-95b5-5f62e514da8e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("53813670-bbea-4c29-a096-3fc0cdb06021"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5396b5f6-0b68-4146-a4e0-0e6ca7b0c58a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5417afd6-93c8-4e8d-876f-1f1b73663552"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("58fada09-43ce-4fe0-986a-db41959b5e27"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5974070e-cd11-4bb3-896b-eeb1b097d0f4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("61013bd1-0b5e-496b-89c0-97a1c8848419"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("61c715c6-23f5-47bf-93c4-8d17b71a0f6a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("63bfae64-393c-45de-933a-a4777b1cfff7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("667dd4bf-55a6-4d20-ab32-6372fe03ff6a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("67cfd6df-a845-4738-83db-f19f6c200bee"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6bae9eed-09f9-4ac7-8dad-39e809f0d56c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6da29cf5-f3d1-4084-aa78-74bf104190d9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("709be293-08b3-41c1-9567-54fbf5dede54"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("70d67ee9-36ea-4110-a989-b3c25a1e51c9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("71bb4e14-8b34-4231-a0ad-94576a5e2daa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("71c663f0-e755-48c8-9900-c16b62d88c99"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("71ff9e6e-f98f-4275-b203-a4b0d4588433"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("736bfb74-31e8-45a2-a689-bb436d7280cf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7454a2aa-33f3-47eb-817a-2520b1a53299"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7766c9d7-46b0-495b-a50a-9090aab57bd6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7a8a702a-df93-4c3d-86da-86ec48458cc5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7adc71bb-bda0-419c-bedd-11271ac8ab9c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7bcd7ec6-2fe7-469f-9e2b-9a764d9194dc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81de5c4a-b44c-4d9c-9965-ae15c0bf38c1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("828a074a-f0d6-4dc8-8fc6-d3a3da2edb01"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8347b189-0f70-4489-a1d3-9d0ab333ea9f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("887171f5-ac49-4068-a163-cc79e9372fbf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("89831178-9b6b-40ff-9a4f-a39ad21f335f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8e6ed184-d609-49ef-b972-3f224ba9962b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8eaef4d6-4c51-4c65-bf5b-4c585c1cbaae"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("90fbd727-578e-4250-9103-9c9e36d1f0eb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("92d4ed0d-b7f3-4a45-bfd5-67988797a082"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9560e5ed-06ea-4a8c-a937-3c8aaeb8509c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("95f7eda4-5097-4687-9156-8ac96209dde9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("97ffc9c3-43c4-4a7d-beb5-da686e00735e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("985408d8-1b11-4fd7-9550-2c96044156b4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9e9f5dc7-a4c5-4142-a86c-ac535f789317"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9f0e12d2-542a-4794-9f37-a1810ff14cb5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a8091d4e-c543-41e9-b938-fd6b67134c0f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a8ae5821-bc10-45b5-a589-526bd88f1b2d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a92f121e-d00e-4030-9296-04ac4f9ccbf8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b144d351-d10a-41c0-84dc-f54999974e2a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b4aab2a2-04c0-4de0-bb0e-9ffbff5c7aed"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b63b916d-5c7a-488b-b78a-8d28abc8c32c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b6f9d2b9-7074-42f0-90ab-d5e5598e52f1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ba52b848-e188-4df6-97e0-8bd157785232"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("becd12b3-f9a2-4ff0-aa5f-262657312044"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c001f5c5-225e-4dd6-896a-1ebe4a67b730"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c24554d7-6535-498f-958b-10a650d9989b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c2d4f00d-bae8-4ab2-99c1-f50f854a4d81"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c693e1fb-bfe3-4ef4-a4a9-0f8fc1a44cc4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("caa2f430-c824-4798-9dab-9dfdfd3499a8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ccc3a2d9-29c0-43a2-a821-47b8cefb1633"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cce9d094-2bd7-44d6-a5c0-98b2c939db1f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d195e31b-c534-4157-bedf-c8b544c7e359"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d4351e26-b74c-4ccf-b918-88d7e128dfde"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d6ca1f7c-11ec-4a56-9983-9881b9f84055"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d7f8d59d-a2b9-45e4-a453-7a77e3c5cb38"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d8635dfc-0a98-446e-8cb9-5ef12e35e093"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("db35b22a-21a5-4213-98ef-48e8c9179bec"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dce28c4e-2b83-46fd-9784-f5ccd27b8121"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dd9ba8ef-998d-41a0-897d-9f2087bd14ce"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e1ff5047-adb0-4e8c-9d17-ed5dc57eac69"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e22f97b3-140e-4da3-b207-242fd0dec85d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e430024f-65d2-4b76-9b16-8edb7c1e1169"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ea695b59-0e05-48b4-9366-eb9cfc583967"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ecd0d12d-0047-4869-9e1f-98452bdfbb4e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f03f91b4-faaf-475d-98ec-a3f307117116"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f579d5ed-746a-43f8-9cd6-55212a921c98"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f90762ce-60ef-4c06-a4a3-42e810252b94"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fc1844fd-626a-4ad2-a3e4-be3c0366af17"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fca20849-e02a-4afe-bdf6-cfd491d97282"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ff1ac1b0-b6b0-4243-9c24-9939b72aa5cd"));
        }
    }
}
