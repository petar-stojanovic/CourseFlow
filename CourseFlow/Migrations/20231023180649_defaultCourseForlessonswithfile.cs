using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseFlow.Migrations
{
    public partial class defaultCourseForlessonswithfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Courses_CourseId",
                table: "Lessons");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("034b2a13-da9b-4799-bf8b-e9e6053dfd55"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("04cd8fbe-3f8d-463a-a30e-2c0528c7f949"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("067fdea0-956a-4569-8cf7-691604e8c47d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("079822f0-c522-46e4-87f4-12f456b98727"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("081d99b7-91de-44dd-acf1-72f30ffdce6c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("08baeb40-40b7-4f6f-97e2-6141e27e9a52"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("09395321-1e6b-4d94-966b-82c74c479812"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0a6813bb-b14f-40ef-90b6-8ffe45f26fb4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0b6ac92e-f658-410a-9a10-0555867b9316"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0e288f0d-0eea-4f0a-b8b8-3ff813a405da"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("121d6aca-7210-4db5-8509-75d16bcac8d2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("12ef4cf6-b735-4fe5-aa62-016eb7878565"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("12f4763c-5677-4562-9b07-4a78ad2854ce"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("14315e39-3108-4d5b-9dbb-fc98422b6472"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("16e3f3de-20c5-4b19-aa0e-c9a665b0e422"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1c04b3b5-6502-46f3-966d-efbb907dd95d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1d2dfd2b-a159-4f31-9077-895921bcbdd8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("23a3d2a9-d2ee-4edd-abfe-04f9ba336de7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("24eaf1a2-f016-41fd-94e6-e350f3200183"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("272389a4-14f4-4cd9-9b0e-aa2719789dea"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("27ce98b6-b1d1-4362-a666-6ee3f67b2c2f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("292e467e-af15-4754-adf9-18c37dfee4f0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2a49fda8-75d1-44ad-8b9a-f5bd7f77efc2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("31e23f19-95d4-4977-9236-204ea5b55e04"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3ce6188b-cc65-4e1f-9958-bbcbfac8f7a2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3d3c6262-d487-472c-bfc3-282034ca8472"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3f4f8589-eb76-435d-8a6d-16aefeafad5b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("40e43878-e6e0-4878-a38e-0f05ad9a1bc8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("419efda9-df80-4ecb-bfc7-a48fd20d4653"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("421dbef8-402b-4c0e-81e9-ea09694a16b6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4904f250-928b-41f8-be3a-1671d0e063cf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("54d76740-9449-4d78-9669-8448ed6f019a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("554443b7-cd66-4e21-8130-0c288c576c89"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5ba8a5c3-6263-43a2-a709-ded78127aac9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("60856cdc-8d7b-47e6-a1da-484c096df8a4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("62173ac9-4a51-4e4e-9f92-f15ecd1e41a6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6265412c-311e-400c-980a-110b21e59d03"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("659d00ce-9984-4db8-9fda-9a985599cd80"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("65d75295-a07b-4af3-91f3-41f823d71d07"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6e67d226-831d-42b1-bb6c-de8019d5db6b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("707c1df4-64fc-487b-adc9-80cb70582d7e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7482c1a2-99df-4b35-8465-b22f21694b4c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("77d111fb-2f48-450f-a632-77783f5eb212"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("78629900-1724-4246-b1d2-f60952853ae7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("799f7b99-089d-411d-a75c-e27434d931f1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7d7d6d9a-842e-4df6-bc4b-badfee155070"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7e3ca18b-2413-41b4-b8e0-4126a636d294"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7f51b372-e101-417a-a450-2248901c0137"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("807dc436-b362-439b-b779-dcdd6da43646"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("811a1e13-0ddd-4cec-b5ab-d9a10896f979"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("817f23a9-026e-4770-86d0-dfb1447ffc78"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("85bd1b30-074e-43e1-8003-fe4849c8e449"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("87d07aa7-b9a5-4893-b32d-a35a91d9839f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("89b7d7c7-db02-4330-8ef0-0679f403dbb8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8a2ce32b-982e-457f-8467-ece7439bf038"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("945901c5-7157-47a0-880f-cb2209bfede4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("95812431-8c46-41d4-9615-814d904849d6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("970f3c9f-e444-498c-8a92-33e838c7f8dc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("988a57bc-a518-4134-9b1f-9cbe6c8fe596"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9ba29c48-9c80-41c5-be03-db34bcc0d2f6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9d1d55c6-9432-4d0c-b47e-d4dac637ca20"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a01945bd-ba94-4bdf-af65-0c8378443243"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a2d5f3c9-a42c-4ca7-a125-0acaf89404b4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a57a484d-7f70-4cef-8054-eeb63b18e036"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a69fe2e8-28a5-45f6-acaf-4dbc025f00a4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a6fa943f-2818-48d7-b759-658833ec6dbd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a74a2d1d-8a87-4b22-bc0a-fadf469e17f9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aa292d24-7181-4689-82a6-d18f4ae1b09e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ad5d1e3e-9526-4079-9d37-cb219d73bab0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("af23fffa-6f62-4945-b5a6-3ad87e057a88"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b0eb5b61-134a-4d3c-8b67-07383f200e69"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b263abf7-ae7f-4589-986e-35f45d3f1561"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b2747df7-2570-402f-a345-a4ff6773e8d8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bed78972-747d-423d-833f-d86ed466145c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c16c7b98-276a-4797-aeb5-07da00b78a7c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c61bb349-ad73-4a27-aa04-594bd5823971"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c7103a28-0ba5-490e-910d-bd0bb3d6eff5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c8f838a8-43c9-4ccd-a465-84152896b188"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ccf19e30-c2da-4802-a4dc-00734b0e7ede"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cf554f9e-b912-4c0e-9c21-882cd62fc83a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d0e2f804-15a5-43c2-9b69-c66a96c14d2f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d523e211-4664-4077-8f64-7ecccb8ba17f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d5784f58-85cd-44de-94b1-2602d3f12814"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d82f3ba5-8300-40d1-9b92-9628704fc1be"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d9bc47bd-ce59-43b5-93f9-1cfbb330e112"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dff23ce9-a1f6-4bd9-b36d-5f546d35b3de"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e05a2fe1-fe1f-452a-ac3d-e5d5c68dec46"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e0e9d8b0-78d0-48c4-9a67-d9d8ccd88c87"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e17b5ece-a149-4fa9-a56f-fd55346bddba"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e38e1587-ecdb-4352-82fa-cbe3f9e9af63"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e3bd7238-9a24-442f-8d06-932e84034f95"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e588549e-4be4-4e70-bea0-7a72419970a4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ec954d46-a14f-4a11-a6cf-7557ab810807"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ecbae5b9-67dd-4f2d-8f0a-bdd62c6234b5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ed9bf13a-c237-45b9-acfe-7b3087d6a77a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ef7a5322-6f2d-4e99-b208-997972a98628"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f1bd8976-b0fc-46c9-8da7-4f3960b2ed2d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f269bed0-dcd0-40ca-986e-b8b4595a2f02"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f758c3c5-ab28-42f2-a673-06b452d721c9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fa1ce48e-1eea-4c3c-b9fd-f75f102ca953"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fa4c31a8-b150-4fe7-a9b9-4c9400bb17ee"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fd78bb25-d52d-4f56-bed3-1b3a953c41a0"));

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
                    { new Guid("037b0cf2-456d-4d0c-84c1-73811a8bbb39"), "GraphQL" },
                    { new Guid("03eb78fb-4b59-48f9-9e95-287a94bc221c"), "Machine Learning" },
                    { new Guid("061d2bcb-9059-478d-a340-a8e55a09becd"), "XML" },
                    { new Guid("069ce44d-0473-4329-a791-5d01ee8bb48e"), "Functional Programming" },
                    { new Guid("06d75bfe-ee42-41ae-ba66-9dac36603ef7"), "C#" },
                    { new Guid("071fd6d6-43ed-46ba-a42f-a45630cb01a1"), "JavaScript" },
                    { new Guid("078e20e3-e7d2-4aed-9bb2-baa6bced1437"), "PHP" },
                    { new Guid("0ab7d7a0-e46a-4d33-b3ed-c38be05a14af"), "TypeScript" },
                    { new Guid("0d3ce0b2-4dc5-476e-8854-613bedc66388"), "Artificial Intelligence" },
                    { new Guid("0da7a44f-8259-411f-8f07-60904d213baa"), "Python" },
                    { new Guid("0e560969-2c8f-4493-b9f9-35b192bd6db5"), "Haskell" },
                    { new Guid("0f337af9-fc2e-49ad-8a74-250ea0b27d30"), "Smalltalk" },
                    { new Guid("0f399b4f-53fc-455c-92eb-8e6dbcd5cf64"), "UI/UX Design" },
                    { new Guid("121588b2-2ca2-49e9-ae81-29d703365cfd"), "Code Documentation" },
                    { new Guid("122a25b4-77aa-4838-8d27-d6b9719deee3"), "Low-Level Programming" },
                    { new Guid("1841bed9-560a-46e9-a24f-7df9d8efb242"), "VBScript" },
                    { new Guid("18f5e483-feea-4f88-91f7-dc3c21d6a74a"), "Kotlin" },
                    { new Guid("19ce4fc4-c8f7-4bf4-afac-7f6daa4015de"), "Cybersecurity" },
                    { new Guid("1b12ee4c-00df-4460-b76d-014e9a46acad"), "Full Stack Development" },
                    { new Guid("20e4b2e9-c2a0-462e-a1d5-0d5b47f1f823"), "Elixir" },
                    { new Guid("250d7ee7-1f9a-411e-a9b5-72b317f95ed5"), "Perl" },
                    { new Guid("2673252f-31e3-4027-9e2a-2e9b11826d33"), "Ada" },
                    { new Guid("27cfbacf-ebe2-430c-8d4a-cbdf821c59de"), "Parallel Programming" },
                    { new Guid("28b37964-e583-4b6d-8e0b-f07e937e6398"), "Object-Oriented Programming" },
                    { new Guid("28eee9d7-4031-48da-948b-32c3af2ae23a"), "High-Level Programming" },
                    { new Guid("31654f00-ce64-4975-b357-5c9e072c2f22"), "Scheme" },
                    { new Guid("31c92fe5-b186-4634-a8b3-3881e35b2777"), "Mobile App Development" },
                    { new Guid("326278fc-aa66-4013-8012-1c58f1ea4d15"), "Ruby" },
                    { new Guid("3bba157f-f8da-4e22-9daa-7c31f7a6c0a4"), "HTML" },
                    { new Guid("3c318963-0ee6-45a9-81d1-5ddc42071b53"), "IoT Development" },
                    { new Guid("3df1af79-3432-419a-af0b-654e442184be"), "Big Data" },
                    { new Guid("42bc4554-af33-44f3-acef-ebf50e93e362"), "Refactoring" },
                    { new Guid("43743584-2974-43f0-ba75-eca47d2575a0"), "Code Optimization" },
                    { new Guid("4391b3d8-3a76-4654-af0b-84b20b700f38"), "Prolog" },
                    { new Guid("46f0669d-327f-49a8-84be-2096f8231dcd"), "T-SQL" },
                    { new Guid("47c0997f-1662-43a1-aa92-b993317317f2"), "Matlab" },
                    { new Guid("4e0c2562-4a15-41de-af8c-8307507b9734"), "Erlang" },
                    { new Guid("4ea34c24-cf26-4fd3-b174-a544ac71b085"), "Project Management" },
                    { new Guid("525b4ef4-ea45-418f-b989-51e250cf8118"), "PowerShell" },
                    { new Guid("52e3e63e-d375-4f72-87c2-530d3b18696c"), "Scrum" },
                    { new Guid("5326d449-f55e-4041-8a54-c4879a473a7f"), "Lisp" },
                    { new Guid("56495b97-5a96-4236-9432-c2ef95d02999"), "Virtual Reality" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("5690bc10-d005-4c72-b1e6-72a46b9f6683"), "F#" },
                    { new Guid("574b2156-3448-4d0e-9668-95146d0b5982"), "Microservices" },
                    { new Guid("5d7ce162-7f22-41e1-94cc-6c704ba0d6a4"), "Pascal" },
                    { new Guid("5dfbb4e6-516c-4367-8348-b45620689612"), "Dart" },
                    { new Guid("5e8859d7-329a-43b9-b5b5-8d5d74623fd4"), "Lua" },
                    { new Guid("5edff946-de93-46cd-813f-7a465ccf3205"), "Rust" },
                    { new Guid("61f9bfd6-1edd-4421-8ba6-cb3eb6eb924d"), "Backend Development" },
                    { new Guid("62085cb6-2ea4-4c9b-97ed-1fa42b330e96"), "Design Patterns" },
                    { new Guid("696b7044-f7a6-4913-a6c7-93982a105deb"), "Agile Methodology" },
                    { new Guid("6b8c044c-c4a5-472a-bf86-724792482221"), "Julia" },
                    { new Guid("74fb13f1-12c3-4ab8-b5d9-b18f7058a220"), "Quantum Computing" },
                    { new Guid("7e5486ac-1312-4e6e-a208-53468c8f1ec1"), "Responsive Design" },
                    { new Guid("7ebaa0a1-b21e-4caa-9970-50d75b2072bf"), "Cloud Computing" },
                    { new Guid("806e8f18-6b2a-4a9e-be77-639a17b6a982"), "Assembly" },
                    { new Guid("809d1d46-6064-4e6c-bcd8-653d040d0d07"), "Secure Coding Practices" },
                    { new Guid("81247d2b-519b-4f8b-a403-f3f15af572cb"), "Code Review" },
                    { new Guid("88552d9b-b7b6-4268-949c-b92913f1a893"), "Objective-C" },
                    { new Guid("8b7d1f67-fc9f-414f-8315-97f0d9fa4801"), "Game Development" },
                    { new Guid("8e900388-9b2f-4e23-84cd-3808296c52c3"), "Logo" },
                    { new Guid("92602255-34fa-4dc1-8315-3524869623ec"), "Bash" },
                    { new Guid("94031416-241f-45c7-9034-abeccc716b50"), "Embedded Systems" },
                    { new Guid("95f83465-777c-4188-91ac-9964b68ca775"), "PL/SQL" },
                    { new Guid("9aab0d4b-27ab-4d06-aab5-2c91d3d16707"), "Software Testing" },
                    { new Guid("9b1e0268-5081-4026-af66-c9e6d399ba5b"), "RESTful APIs" },
                    { new Guid("9b650593-8188-441f-ae0e-c7beee5e9cb1"), "Kanban" },
                    { new Guid("9d14939c-4484-4486-835d-cf3d85f6db53"), "Frontend Development" },
                    { new Guid("a36b2d1d-b619-40f6-ac2f-f2263d9cdca1"), "Code Quality" },
                    { new Guid("a89f0662-2bcf-446f-9038-c739c923b39f"), "Software Development Lifecycle" },
                    { new Guid("b202b35a-52da-4479-af48-76e4da2381ef"), "Go" },
                    { new Guid("b2eb229e-19d3-4c34-ac6d-dba9ed61b214"), "COBOL" },
                    { new Guid("b35516fe-303b-456b-9279-d3758c6f0498"), "Augmented Reality" },
                    { new Guid("b445ba0f-70a3-4a43-9366-7e24ccdcf1d1"), "Ada" },
                    { new Guid("b5446131-7d71-4914-bfa5-3e3b198a8f4f"), "Natural Language Processing" },
                    { new Guid("bf8831b1-443f-46af-a104-480a2e175960"), "Java" },
                    { new Guid("c516aba7-16ba-4278-ad25-70847a92b7f2"), "Version Control" },
                    { new Guid("c5ca0fa2-c4b5-417b-8072-d7c96cec68b8"), "Database Management" },
                    { new Guid("c71cf294-605a-49ac-8c68-d9314d3f92fe"), "Groovy" },
                    { new Guid("c7a0c354-0e62-47dc-96ac-f06f81936cc6"), "SQL" },
                    { new Guid("ca3b7495-2352-4f06-881b-72bd7dd1b8c3"), "Concurrency" },
                    { new Guid("d74c56c8-1c63-4a79-9bb1-1c48e2698227"), "DevOps" },
                    { new Guid("d8afa6c1-ae05-49c9-b35c-0720ac2f57bf"), "R" },
                    { new Guid("d952363d-f3ff-4339-8cc5-190909d5e863"), "Legacy Code Maintenance" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("dcc759a1-48b6-4767-9d2c-867e259d908c"), "Clojure" },
                    { new Guid("e067a6d2-0921-4765-9cc3-65c27674e10b"), "API Development" },
                    { new Guid("e1a703d6-3738-4d5a-b01d-e060c098d71f"), "Web Development" },
                    { new Guid("e3d7c4d9-28fb-4074-be4c-61604d64b7dd"), "Pair Programming" },
                    { new Guid("e4a4d24f-6870-4b04-ad9b-8303feb1286d"), "Software Architecture" },
                    { new Guid("e72757d2-b0d2-4d8f-acc5-e66a2f53256e"), "Data Science" },
                    { new Guid("eaf26b32-6238-44c8-bb98-fab6f950a9e4"), "Continuous Integration" },
                    { new Guid("ec46a2b0-02b7-4897-a90f-bad6462d7e6d"), "Swift" },
                    { new Guid("eca923e3-30cd-4241-b6f3-b683b83e2c7a"), "C++" },
                    { new Guid("efc4a3d3-0a96-41b0-ab77-fbc7fc19f572"), "Technical Debt" },
                    { new Guid("f0ad1e46-7d30-46de-9628-5df5b4705d34"), "Racket" },
                    { new Guid("f42c6712-1fb1-4fe5-8cbb-d35c54a66cdd"), "Verilog" },
                    { new Guid("f470b13a-8e10-47a2-930b-9110b85474c5"), "Fortran" },
                    { new Guid("f4a3d8c7-1429-4329-a788-c948af3312aa"), "Blockchain" },
                    { new Guid("f63b6069-a937-4a8d-b08c-2e78dc4b1374"), "VHDL" },
                    { new Guid("f6bb60ec-9deb-46a0-a299-4fc6ca1998ca"), "Scala" },
                    { new Guid("f749f18c-5c8d-4844-9dd8-2c2efc0daa23"), "CSS" },
                    { new Guid("f853df7d-fd26-47bd-876a-c41a6e0c29f4"), "JSON" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Author", "DateCreated", "Description", "IsPublic", "Price", "Thumbnail", "Title" },
                values: new object[] { new Guid("8a4ee6b6-15dc-4fa7-9d76-f72b3a91f526"), "", new DateTime(2023, 10, 23, 20, 6, 48, 720, DateTimeKind.Local).AddTicks(2443), "This is a course for unassigned lessons", false, 100000, "https://img-c.udemycdn.com/course/750x422/473160_d929_3.jpg", "Admin" });

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Courses_CourseId",
                table: "Lessons",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Courses_CourseId",
                table: "Lessons");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("037b0cf2-456d-4d0c-84c1-73811a8bbb39"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("03eb78fb-4b59-48f9-9e95-287a94bc221c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("061d2bcb-9059-478d-a340-a8e55a09becd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("069ce44d-0473-4329-a791-5d01ee8bb48e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("06d75bfe-ee42-41ae-ba66-9dac36603ef7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("071fd6d6-43ed-46ba-a42f-a45630cb01a1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("078e20e3-e7d2-4aed-9bb2-baa6bced1437"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0ab7d7a0-e46a-4d33-b3ed-c38be05a14af"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0d3ce0b2-4dc5-476e-8854-613bedc66388"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0da7a44f-8259-411f-8f07-60904d213baa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0e560969-2c8f-4493-b9f9-35b192bd6db5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0f337af9-fc2e-49ad-8a74-250ea0b27d30"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0f399b4f-53fc-455c-92eb-8e6dbcd5cf64"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("121588b2-2ca2-49e9-ae81-29d703365cfd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("122a25b4-77aa-4838-8d27-d6b9719deee3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1841bed9-560a-46e9-a24f-7df9d8efb242"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("18f5e483-feea-4f88-91f7-dc3c21d6a74a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("19ce4fc4-c8f7-4bf4-afac-7f6daa4015de"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1b12ee4c-00df-4460-b76d-014e9a46acad"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("20e4b2e9-c2a0-462e-a1d5-0d5b47f1f823"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("250d7ee7-1f9a-411e-a9b5-72b317f95ed5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2673252f-31e3-4027-9e2a-2e9b11826d33"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("27cfbacf-ebe2-430c-8d4a-cbdf821c59de"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("28b37964-e583-4b6d-8e0b-f07e937e6398"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("28eee9d7-4031-48da-948b-32c3af2ae23a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("31654f00-ce64-4975-b357-5c9e072c2f22"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("31c92fe5-b186-4634-a8b3-3881e35b2777"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("326278fc-aa66-4013-8012-1c58f1ea4d15"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3bba157f-f8da-4e22-9daa-7c31f7a6c0a4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3c318963-0ee6-45a9-81d1-5ddc42071b53"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3df1af79-3432-419a-af0b-654e442184be"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("42bc4554-af33-44f3-acef-ebf50e93e362"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("43743584-2974-43f0-ba75-eca47d2575a0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4391b3d8-3a76-4654-af0b-84b20b700f38"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("46f0669d-327f-49a8-84be-2096f8231dcd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("47c0997f-1662-43a1-aa92-b993317317f2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4e0c2562-4a15-41de-af8c-8307507b9734"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4ea34c24-cf26-4fd3-b174-a544ac71b085"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("525b4ef4-ea45-418f-b989-51e250cf8118"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("52e3e63e-d375-4f72-87c2-530d3b18696c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5326d449-f55e-4041-8a54-c4879a473a7f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("56495b97-5a96-4236-9432-c2ef95d02999"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5690bc10-d005-4c72-b1e6-72a46b9f6683"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("574b2156-3448-4d0e-9668-95146d0b5982"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5d7ce162-7f22-41e1-94cc-6c704ba0d6a4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5dfbb4e6-516c-4367-8348-b45620689612"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5e8859d7-329a-43b9-b5b5-8d5d74623fd4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5edff946-de93-46cd-813f-7a465ccf3205"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("61f9bfd6-1edd-4421-8ba6-cb3eb6eb924d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("62085cb6-2ea4-4c9b-97ed-1fa42b330e96"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("696b7044-f7a6-4913-a6c7-93982a105deb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6b8c044c-c4a5-472a-bf86-724792482221"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("74fb13f1-12c3-4ab8-b5d9-b18f7058a220"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7e5486ac-1312-4e6e-a208-53468c8f1ec1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7ebaa0a1-b21e-4caa-9970-50d75b2072bf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("806e8f18-6b2a-4a9e-be77-639a17b6a982"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("809d1d46-6064-4e6c-bcd8-653d040d0d07"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81247d2b-519b-4f8b-a403-f3f15af572cb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("88552d9b-b7b6-4268-949c-b92913f1a893"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8b7d1f67-fc9f-414f-8315-97f0d9fa4801"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8e900388-9b2f-4e23-84cd-3808296c52c3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("92602255-34fa-4dc1-8315-3524869623ec"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("94031416-241f-45c7-9034-abeccc716b50"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("95f83465-777c-4188-91ac-9964b68ca775"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9aab0d4b-27ab-4d06-aab5-2c91d3d16707"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9b1e0268-5081-4026-af66-c9e6d399ba5b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9b650593-8188-441f-ae0e-c7beee5e9cb1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9d14939c-4484-4486-835d-cf3d85f6db53"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a36b2d1d-b619-40f6-ac2f-f2263d9cdca1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a89f0662-2bcf-446f-9038-c739c923b39f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b202b35a-52da-4479-af48-76e4da2381ef"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b2eb229e-19d3-4c34-ac6d-dba9ed61b214"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b35516fe-303b-456b-9279-d3758c6f0498"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b445ba0f-70a3-4a43-9366-7e24ccdcf1d1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b5446131-7d71-4914-bfa5-3e3b198a8f4f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bf8831b1-443f-46af-a104-480a2e175960"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c516aba7-16ba-4278-ad25-70847a92b7f2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c5ca0fa2-c4b5-417b-8072-d7c96cec68b8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c71cf294-605a-49ac-8c68-d9314d3f92fe"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c7a0c354-0e62-47dc-96ac-f06f81936cc6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ca3b7495-2352-4f06-881b-72bd7dd1b8c3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d74c56c8-1c63-4a79-9bb1-1c48e2698227"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d8afa6c1-ae05-49c9-b35c-0720ac2f57bf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d952363d-f3ff-4339-8cc5-190909d5e863"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dcc759a1-48b6-4767-9d2c-867e259d908c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e067a6d2-0921-4765-9cc3-65c27674e10b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e1a703d6-3738-4d5a-b01d-e060c098d71f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e3d7c4d9-28fb-4074-be4c-61604d64b7dd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e4a4d24f-6870-4b04-ad9b-8303feb1286d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e72757d2-b0d2-4d8f-acc5-e66a2f53256e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("eaf26b32-6238-44c8-bb98-fab6f950a9e4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ec46a2b0-02b7-4897-a90f-bad6462d7e6d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("eca923e3-30cd-4241-b6f3-b683b83e2c7a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("efc4a3d3-0a96-41b0-ab77-fbc7fc19f572"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f0ad1e46-7d30-46de-9628-5df5b4705d34"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f42c6712-1fb1-4fe5-8cbb-d35c54a66cdd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f470b13a-8e10-47a2-930b-9110b85474c5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f4a3d8c7-1429-4329-a788-c948af3312aa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f63b6069-a937-4a8d-b08c-2e78dc4b1374"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f6bb60ec-9deb-46a0-a299-4fc6ca1998ca"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f749f18c-5c8d-4844-9dd8-2c2efc0daa23"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f853df7d-fd26-47bd-876a-c41a6e0c29f4"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("8a4ee6b6-15dc-4fa7-9d76-f72b3a91f526"));

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
                    { new Guid("034b2a13-da9b-4799-bf8b-e9e6053dfd55"), "Groovy" },
                    { new Guid("04cd8fbe-3f8d-463a-a30e-2c0528c7f949"), "Pascal" },
                    { new Guid("067fdea0-956a-4569-8cf7-691604e8c47d"), "F#" },
                    { new Guid("079822f0-c522-46e4-87f4-12f456b98727"), "Perl" },
                    { new Guid("081d99b7-91de-44dd-acf1-72f30ffdce6c"), "Object-Oriented Programming" },
                    { new Guid("08baeb40-40b7-4f6f-97e2-6141e27e9a52"), "Bash" },
                    { new Guid("09395321-1e6b-4d94-966b-82c74c479812"), "Design Patterns" },
                    { new Guid("0a6813bb-b14f-40ef-90b6-8ffe45f26fb4"), "Microservices" },
                    { new Guid("0b6ac92e-f658-410a-9a10-0555867b9316"), "C++" },
                    { new Guid("0e288f0d-0eea-4f0a-b8b8-3ff813a405da"), "Embedded Systems" },
                    { new Guid("121d6aca-7210-4db5-8509-75d16bcac8d2"), "Project Management" },
                    { new Guid("12ef4cf6-b735-4fe5-aa62-016eb7878565"), "Code Optimization" },
                    { new Guid("12f4763c-5677-4562-9b07-4a78ad2854ce"), "Smalltalk" },
                    { new Guid("14315e39-3108-4d5b-9dbb-fc98422b6472"), "Fortran" },
                    { new Guid("16e3f3de-20c5-4b19-aa0e-c9a665b0e422"), "Scrum" },
                    { new Guid("1c04b3b5-6502-46f3-966d-efbb907dd95d"), "Legacy Code Maintenance" },
                    { new Guid("1d2dfd2b-a159-4f31-9077-895921bcbdd8"), "Scheme" },
                    { new Guid("23a3d2a9-d2ee-4edd-abfe-04f9ba336de7"), "Ada" },
                    { new Guid("24eaf1a2-f016-41fd-94e6-e350f3200183"), "DevOps" },
                    { new Guid("272389a4-14f4-4cd9-9b0e-aa2719789dea"), "Augmented Reality" },
                    { new Guid("27ce98b6-b1d1-4362-a666-6ee3f67b2c2f"), "Logo" },
                    { new Guid("292e467e-af15-4754-adf9-18c37dfee4f0"), "Clojure" },
                    { new Guid("2a49fda8-75d1-44ad-8b9a-f5bd7f77efc2"), "API Development" },
                    { new Guid("31e23f19-95d4-4977-9236-204ea5b55e04"), "Python" },
                    { new Guid("3ce6188b-cc65-4e1f-9958-bbcbfac8f7a2"), "Software Testing" },
                    { new Guid("3d3c6262-d487-472c-bfc3-282034ca8472"), "TypeScript" },
                    { new Guid("3f4f8589-eb76-435d-8a6d-16aefeafad5b"), "Version Control" },
                    { new Guid("40e43878-e6e0-4878-a38e-0f05ad9a1bc8"), "Ada" },
                    { new Guid("419efda9-df80-4ecb-bfc7-a48fd20d4653"), "UI/UX Design" },
                    { new Guid("421dbef8-402b-4c0e-81e9-ea09694a16b6"), "Code Review" },
                    { new Guid("4904f250-928b-41f8-be3a-1671d0e063cf"), "Assembly" },
                    { new Guid("54d76740-9449-4d78-9669-8448ed6f019a"), "PHP" },
                    { new Guid("554443b7-cd66-4e21-8130-0c288c576c89"), "Erlang" },
                    { new Guid("5ba8a5c3-6263-43a2-a709-ded78127aac9"), "Agile Methodology" },
                    { new Guid("60856cdc-8d7b-47e6-a1da-484c096df8a4"), "Mobile App Development" },
                    { new Guid("62173ac9-4a51-4e4e-9f92-f15ecd1e41a6"), "Dart" },
                    { new Guid("6265412c-311e-400c-980a-110b21e59d03"), "Responsive Design" },
                    { new Guid("659d00ce-9984-4db8-9fda-9a985599cd80"), "Database Management" },
                    { new Guid("65d75295-a07b-4af3-91f3-41f823d71d07"), "Full Stack Development" },
                    { new Guid("6e67d226-831d-42b1-bb6c-de8019d5db6b"), "Refactoring" },
                    { new Guid("707c1df4-64fc-487b-adc9-80cb70582d7e"), "Concurrency" },
                    { new Guid("7482c1a2-99df-4b35-8465-b22f21694b4c"), "Artificial Intelligence" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("77d111fb-2f48-450f-a632-77783f5eb212"), "Backend Development" },
                    { new Guid("78629900-1724-4246-b1d2-f60952853ae7"), "Blockchain" },
                    { new Guid("799f7b99-089d-411d-a75c-e27434d931f1"), "Technical Debt" },
                    { new Guid("7d7d6d9a-842e-4df6-bc4b-badfee155070"), "High-Level Programming" },
                    { new Guid("7e3ca18b-2413-41b4-b8e0-4126a636d294"), "PL/SQL" },
                    { new Guid("7f51b372-e101-417a-a450-2248901c0137"), "R" },
                    { new Guid("807dc436-b362-439b-b779-dcdd6da43646"), "Parallel Programming" },
                    { new Guid("811a1e13-0ddd-4cec-b5ab-d9a10896f979"), "Pair Programming" },
                    { new Guid("817f23a9-026e-4770-86d0-dfb1447ffc78"), "JSON" },
                    { new Guid("85bd1b30-074e-43e1-8003-fe4849c8e449"), "Objective-C" },
                    { new Guid("87d07aa7-b9a5-4893-b32d-a35a91d9839f"), "C#" },
                    { new Guid("89b7d7c7-db02-4330-8ef0-0679f403dbb8"), "Cybersecurity" },
                    { new Guid("8a2ce32b-982e-457f-8467-ece7439bf038"), "Go" },
                    { new Guid("945901c5-7157-47a0-880f-cb2209bfede4"), "HTML" },
                    { new Guid("95812431-8c46-41d4-9615-814d904849d6"), "VBScript" },
                    { new Guid("970f3c9f-e444-498c-8a92-33e838c7f8dc"), "Lua" },
                    { new Guid("988a57bc-a518-4134-9b1f-9cbe6c8fe596"), "PowerShell" },
                    { new Guid("9ba29c48-9c80-41c5-be03-db34bcc0d2f6"), "Low-Level Programming" },
                    { new Guid("9d1d55c6-9432-4d0c-b47e-d4dac637ca20"), "Verilog" },
                    { new Guid("a01945bd-ba94-4bdf-af65-0c8378443243"), "Julia" },
                    { new Guid("a2d5f3c9-a42c-4ca7-a125-0acaf89404b4"), "Kotlin" },
                    { new Guid("a57a484d-7f70-4cef-8054-eeb63b18e036"), "Racket" },
                    { new Guid("a69fe2e8-28a5-45f6-acaf-4dbc025f00a4"), "COBOL" },
                    { new Guid("a6fa943f-2818-48d7-b759-658833ec6dbd"), "JavaScript" },
                    { new Guid("a74a2d1d-8a87-4b22-bc0a-fadf469e17f9"), "Rust" },
                    { new Guid("aa292d24-7181-4689-82a6-d18f4ae1b09e"), "Virtual Reality" },
                    { new Guid("ad5d1e3e-9526-4079-9d37-cb219d73bab0"), "Web Development" },
                    { new Guid("af23fffa-6f62-4945-b5a6-3ad87e057a88"), "XML" },
                    { new Guid("b0eb5b61-134a-4d3c-8b67-07383f200e69"), "Swift" },
                    { new Guid("b263abf7-ae7f-4589-986e-35f45d3f1561"), "Prolog" },
                    { new Guid("b2747df7-2570-402f-a345-a4ff6773e8d8"), "SQL" },
                    { new Guid("bed78972-747d-423d-833f-d86ed466145c"), "Java" },
                    { new Guid("c16c7b98-276a-4797-aeb5-07da00b78a7c"), "Code Documentation" },
                    { new Guid("c61bb349-ad73-4a27-aa04-594bd5823971"), "Ruby" },
                    { new Guid("c7103a28-0ba5-490e-910d-bd0bb3d6eff5"), "Machine Learning" },
                    { new Guid("c8f838a8-43c9-4ccd-a465-84152896b188"), "Quantum Computing" },
                    { new Guid("ccf19e30-c2da-4802-a4dc-00734b0e7ede"), "Elixir" },
                    { new Guid("cf554f9e-b912-4c0e-9c21-882cd62fc83a"), "VHDL" },
                    { new Guid("d0e2f804-15a5-43c2-9b69-c66a96c14d2f"), "CSS" },
                    { new Guid("d523e211-4664-4077-8f64-7ecccb8ba17f"), "GraphQL" },
                    { new Guid("d5784f58-85cd-44de-94b1-2602d3f12814"), "Software Development Lifecycle" },
                    { new Guid("d82f3ba5-8300-40d1-9b92-9628704fc1be"), "Functional Programming" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("d9bc47bd-ce59-43b5-93f9-1cfbb330e112"), "Matlab" },
                    { new Guid("dff23ce9-a1f6-4bd9-b36d-5f546d35b3de"), "Continuous Integration" },
                    { new Guid("e05a2fe1-fe1f-452a-ac3d-e5d5c68dec46"), "Software Architecture" },
                    { new Guid("e0e9d8b0-78d0-48c4-9a67-d9d8ccd88c87"), "Haskell" },
                    { new Guid("e17b5ece-a149-4fa9-a56f-fd55346bddba"), "Game Development" },
                    { new Guid("e38e1587-ecdb-4352-82fa-cbe3f9e9af63"), "Code Quality" },
                    { new Guid("e3bd7238-9a24-442f-8d06-932e84034f95"), "Frontend Development" },
                    { new Guid("e588549e-4be4-4e70-bea0-7a72419970a4"), "Data Science" },
                    { new Guid("ec954d46-a14f-4a11-a6cf-7557ab810807"), "Scala" },
                    { new Guid("ecbae5b9-67dd-4f2d-8f0a-bdd62c6234b5"), "Big Data" },
                    { new Guid("ed9bf13a-c237-45b9-acfe-7b3087d6a77a"), "Lisp" },
                    { new Guid("ef7a5322-6f2d-4e99-b208-997972a98628"), "T-SQL" },
                    { new Guid("f1bd8976-b0fc-46c9-8da7-4f3960b2ed2d"), "RESTful APIs" },
                    { new Guid("f269bed0-dcd0-40ca-986e-b8b4595a2f02"), "Cloud Computing" },
                    { new Guid("f758c3c5-ab28-42f2-a673-06b452d721c9"), "Kanban" },
                    { new Guid("fa1ce48e-1eea-4c3c-b9fd-f75f102ca953"), "Secure Coding Practices" },
                    { new Guid("fa4c31a8-b150-4fe7-a9b9-4c9400bb17ee"), "Natural Language Processing" },
                    { new Guid("fd78bb25-d52d-4f56-bed3-1b3a953c41a0"), "IoT Development" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Courses_CourseId",
                table: "Lessons",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id");
        }
    }
}
