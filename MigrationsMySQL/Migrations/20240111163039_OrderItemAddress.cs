using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MigrationsMySQL.Migrations
{
    /// <inheritdoc />
    public partial class OrderItemAddress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("04a25995-6c5c-4963-b1e9-bdccc364050c"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("04bdd099-ecf0-457e-8a64-b051be40d6dc"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("0796435a-f654-4f63-9702-3443ed22a2dc"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("11f9ecf8-239a-41f5-ad95-1a85ea3fc861"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("15ca3c1b-bb7c-49a1-899e-e8cffa8bc5af"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("164bcda9-cdb1-46e1-b44a-a1d4c010a658"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("1d3a6321-c72a-4a16-9803-1ab660e454ba"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("25c22d18-3f33-48ab-9b4e-eaed18ca3bb9"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("25f0613c-057b-461e-a833-1e1e410a9eb0"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("2855f597-8346-429c-86c3-7faa74b31274"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("2c96cab5-1adb-4af4-a5e5-f1e21f49acc3"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("2eb3d650-4381-434c-ad17-df0a12a7e286"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("33846f05-ab36-4cd8-b533-5df9750d7c1d"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("35dcb471-69c3-4d62-b868-3d2a76bba64a"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("36c78ebf-a791-462a-990c-604d92a802e1"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("398ed365-a002-4a0f-bd4c-f81fecb94c4c"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("43d02c82-0058-48e5-9afe-716f24064d71"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("45b505d0-cb65-4917-a90e-5896f0681603"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("46eef368-11c6-4d31-94cb-9afbcba28af5"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("487aeb28-7ec5-4f84-aa0b-8a9a88c0e696"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("4aa30780-9a5f-4556-ad52-0223a80a0d3d"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("4b5da2ab-dd87-43cc-9743-c009b7d7a38c"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("4ddb4b44-da6b-4d44-ad8b-29d07c5af57d"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("4f45eb41-6bf2-405e-9a44-fa8b1a7b09bb"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("4fc067cf-2a73-436f-8194-655a5c090388"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("50e708d0-a8f2-4479-8a0f-56eff44468f1"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("54f870bb-08c1-4839-90ca-33303a3b667a"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("5d673b03-146a-4e73-aa23-d9aa3c579c02"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("60405a7d-2022-41ff-b7f7-4c5ddcfa1173"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("6ba60da0-6279-4af1-ab62-a7cff3026e68"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("6c709ad0-8d64-4584-93c1-b1372d0dc5ac"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("6ce28814-f616-459a-ad68-ed6fd2d5646e"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("6d7d1ac5-b3fd-4ead-bfdc-450d2156fc90"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("6e48ebd3-b8e4-4b34-8f75-9408c2800bb6"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("6e8367ac-0ff3-4ebd-bcc2-ced56c950a8f"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("6e8cc39c-6223-41c0-b6c6-b0cf6c777126"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("7ce9f819-3e03-412a-8187-a1b89e9ded8b"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("7f52b243-b773-4132-aeea-fa5ffc2c176f"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("7f80ff19-3956-41bd-9541-f24536f4e522"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("812a9c0b-7398-4cdc-a1e3-f87a12041ade"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("83dc4c30-28fa-4f3a-b584-bb0b05b2b24b"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("8459e2a9-c586-4122-8007-ce27ad46c983"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("86bb1f00-24dd-4a71-a628-e3a7a752e9c1"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("99a4dcec-5945-4d39-bc81-b337b3c137a7"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("9fcb1d3e-ceb4-41d0-9057-c0bc218ad263"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("9fefdcc2-2a67-43ca-9b48-0195435e28d3"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("9ffb2b07-ad26-46d3-87e9-bff911b64811"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("a0cd2113-7eb8-426b-8500-aa3479eb6af1"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("a31778f1-c625-4a04-b3e4-910547360339"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("a740a5bb-8f26-4708-9e4a-32545d164b6c"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("ab86a408-9821-4db5-b3af-0d8bd4b40fe0"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("acd696d3-6a01-4a74-b3aa-db74c03ec1b2"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("ad91fd9e-7b92-4d9e-a596-9d537a6616e5"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("ae086619-8921-4dd9-a585-a8b320446f48"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("b3dfd1aa-afd0-4e90-b8ee-bf8afc94b1c0"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("b55de380-10f9-4150-9a6a-b680df6bf4be"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("b79e928b-88bc-4cc2-865b-d518371ea8bb"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("b9cbf07c-5c06-4092-ab16-36a9c942c404"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("baf72862-41b7-43bb-b1b0-5a8e79829c04"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("bb0f2f46-47ac-46f4-ac9b-86f3d1aabe2e"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("bec66dba-50da-4f5e-9b5f-f8ed0ce5ecc4"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("c42211c1-51f3-4287-9800-6ed9dbc14fa0"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("c6780d41-12f3-463d-b0ff-10cf2f3d6b22"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("c912db18-5116-45e7-b273-d5fc40c8ccba"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("d1f888d9-d6b5-4039-b3df-5087e638cad1"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("d34c0829-3cf9-4910-a7b1-2a74b6d9053d"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("d4789a3b-748d-4f5d-8890-d807cb92575a"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("d4cd4ec0-1d33-4bbf-a49a-df423317fc23"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("d53ff9ab-bf5b-43eb-b2b2-9c0d1bc7c8fd"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("d821b2cc-e214-4ac6-88e3-916bbbdde894"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("dae7545f-b27c-4063-9189-5d4ad38b48b5"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("db877960-597f-410c-b327-c5fca0c4c36c"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("dd04c8b4-1a01-4dec-b511-f2cfae47b469"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("dfe4659d-fee4-49c4-a22e-bff0400032d3"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("e18d1bc3-0265-4d9a-86fb-bea9872ae177"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("e80b98ef-de69-4a31-a8be-9a2b5eada15d"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("e8214c9b-8e45-435b-a97e-09bf9ad6efae"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("ece1a8f1-c748-4414-b187-22fab61de63f"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("f05ce716-ac44-43f3-a4aa-f166f90e17a3"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("f06582a4-5da5-4fef-9bdc-e453ca04a56e"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("fb63d0d8-6572-4240-a027-1b2e1315071e"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("fbefd00b-0d2e-440b-9ffb-319539862aef"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("fdf57edc-6075-4ac0-9163-ca9e6a3056e5"));

            migrationBuilder.InsertData(
                table: "TransportFees",
                columns: new[] { "Id", "DistrictId", "MethodId", "MinWeight", "Value" },
                values: new object[,]
                {
                    { new Guid("0005399a-6343-4c99-9069-254584a8c3ee"), new Guid("b90943d8-f764-42d3-8fca-da1ba2378634"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("01f0a024-2333-4d5f-9df6-523c6e891ef7"), new Guid("d484cf5d-d07d-4e01-8aa4-c87747fa68fe"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.40m },
                    { new Guid("04f4a19b-f2d6-4a1f-9156-9920550d1536"), new Guid("72516348-d8e7-4ce3-af4e-f97b77897f89"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("06fab812-9f40-45d8-ab2b-0703ab6c7055"), new Guid("6d63584c-813f-48de-9b19-df143f83d2f7"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("07e4e0d3-a768-46e1-bc3c-06801e509c31"), new Guid("98ead996-828c-4a6f-99c2-914b7c8110ef"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("0a49f26b-3c5c-4914-b7a3-b533ff08c747"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("0b31383f-0801-4e41-aa29-12e008784956"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 1501, 1.47m },
                    { new Guid("0badeed9-a777-45a2-a6c8-0e86cdb2e930"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 301, 1.83m },
                    { new Guid("0ec48687-d2e4-4f58-9b74-2097d9991bdd"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 71, 2.41m },
                    { new Guid("123da90d-6dda-4605-a755-c56ce7a2cf34"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 301, 1.50m },
                    { new Guid("14bf28bf-6a8d-4afa-b29c-5a3f90c71a45"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 1501, 1.82m },
                    { new Guid("15e424c5-a72f-4eb1-963c-ca5ae7141c83"), new Guid("5abcb711-259a-48dc-9817-2e5b988d690a"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("17bc576d-d493-4f8d-9039-c43ba14c9639"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 71, 2.08m },
                    { new Guid("18f67810-8e0e-47c1-988d-c2737ce8ebee"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.76m },
                    { new Guid("194af597-f8e9-4049-9231-9d9ddf7193ac"), new Guid("6d63584c-813f-48de-9b19-df143f83d2f7"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("1d3fa72c-5ea8-4bc7-8ac0-612a8ec7a555"), new Guid("5f0411d9-fc63-4dd4-a03f-50c26f0829c6"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("2407409c-da79-4a42-a8f9-226d38e8b00c"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 23, 2.22m },
                    { new Guid("251c341f-c99b-4ee1-9627-4feb5d708143"), new Guid("76e0d1b5-4fb7-4dc7-bcb1-1fadff9acc92"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("2536cc99-c145-433e-9b80-95a18348428e"), new Guid("ccd6ecfe-c907-4777-96ad-40ab41b7ac06"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.46m },
                    { new Guid("2b02f1a3-61d9-450d-8539-a5ab050d83b7"), new Guid("d484cf5d-d07d-4e01-8aa4-c87747fa68fe"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.92m },
                    { new Guid("2c3e0539-729d-4f2e-aacb-2c731d71b94d"), new Guid("ccd6ecfe-c907-4777-96ad-40ab41b7ac06"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.87m },
                    { new Guid("306680ea-8452-4082-b3f2-70a09a311340"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("325257c8-f124-4bbf-8860-4ac5af5e2b46"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 301, 1.36m },
                    { new Guid("36b50892-fcda-44dd-87ee-e7526b9c318c"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 71, 2.22m },
                    { new Guid("3a557b65-9869-4ab0-a9ac-649682e42ebc"), new Guid("b90943d8-f764-42d3-8fca-da1ba2378634"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("3dd07969-8070-4691-979a-97bdb202fc52"), new Guid("76e0d1b5-4fb7-4dc7-bcb1-1fadff9acc92"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("3eda579e-8d9a-40a2-8107-22c31638eb73"), new Guid("80ff3e90-dcb9-4bc3-9590-e3a2c331a0ec"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("42bf1932-a2fd-4314-9b6a-403b0c150237"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("460e932b-7789-4ae7-9cda-447cc6bedb27"), new Guid("5f0411d9-fc63-4dd4-a03f-50c26f0829c6"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.97m },
                    { new Guid("48e68cab-3e53-4d55-87ad-a67c90d5d460"), new Guid("2b26b58b-050c-46a7-8567-2325c31fa6fb"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.87m },
                    { new Guid("4a6c1973-bcd0-46a9-8d11-8234345276f6"), new Guid("5abcb711-259a-48dc-9817-2e5b988d690a"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("4dde1261-07d5-4dc1-b12c-550aad64bf73"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.43m },
                    { new Guid("530aab5e-afbe-4ed9-9865-bc674e43af5f"), new Guid("ccd6ecfe-c907-4777-96ad-40ab41b7ac06"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("5b94a26d-7508-4bd5-a74d-a45a0ff6a78f"), new Guid("76adc0f7-ac5d-43cd-9983-eae135865030"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("5d8c33c7-3c1f-4b36-b21a-f2c369758625"), new Guid("6d63584c-813f-48de-9b19-df143f83d2f7"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("5e0d612e-97ad-4c28-bd62-e8659e2e92d8"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 23, 2.84m },
                    { new Guid("5e746c67-d994-4fb1-9e3b-ec364150110b"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 1501, 1.66m },
                    { new Guid("5f2306a2-4ed5-4181-9e15-e60cb557e19b"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("5fd30917-fb3e-4724-b747-20a276354e45"), new Guid("98ead996-828c-4a6f-99c2-914b7c8110ef"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("624899fc-0018-485b-9797-1c2ca908cb13"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 23, 2.08m },
                    { new Guid("62c04c59-418c-46bd-bd17-05afc26cf04d"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("64f9788f-eab4-41b3-8c88-a25010b49364"), new Guid("6d332a8f-0bcd-4b81-9c59-6965f4ab40ae"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("6591ac05-a38b-478c-a53d-7b72bd14ac5b"), new Guid("3bf2da8a-0a2c-4a8f-99c9-35742cb7fa2e"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.46m },
                    { new Guid("6950ac32-20d5-45b5-85f5-b6f2b8d36449"), new Guid("123a8e96-b5f2-4459-a896-da06599036cf"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("69e15296-cd12-4aca-974c-c14cd610bedf"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("6c204e5b-d2b0-4baa-93a8-d5fe759842f2"), new Guid("6d332a8f-0bcd-4b81-9c59-6965f4ab40ae"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.00m },
                    { new Guid("79c0d3ac-c0c4-422b-8dbf-59bad9f4f1e4"), new Guid("3bf2da8a-0a2c-4a8f-99c9-35742cb7fa2e"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.87m },
                    { new Guid("7c1825ad-86db-4ec9-836a-6ec3091a1949"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 1501, 1.33m },
                    { new Guid("7ddd4b01-370b-435f-9d95-1f8db5d82687"), new Guid("dbe61b00-89ef-493c-8930-9d41a402a987"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("80214f79-6d1c-47ef-911c-b08b1d0f175a"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 71, 1.93m },
                    { new Guid("8612afcd-c62f-43d3-9e0a-3a0c55952553"), new Guid("6d332a8f-0bcd-4b81-9c59-6965f4ab40ae"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("91687e45-1c97-429c-b724-9d3d557b0e70"), new Guid("76e0d1b5-4fb7-4dc7-bcb1-1fadff9acc92"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.97m },
                    { new Guid("9261fc39-e173-4268-9b90-d1534cd7e091"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 301, 1.69m },
                    { new Guid("92747c31-b7ef-4d61-98f5-9b4e13bc6b7e"), new Guid("80ff3e90-dcb9-4bc3-9590-e3a2c331a0ec"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.00m },
                    { new Guid("9500ad5a-380e-4a05-ab33-a92817125325"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 301, 1.98m },
                    { new Guid("95c35a77-81cf-409d-babd-001a8f8db1d5"), new Guid("2b26b58b-050c-46a7-8567-2325c31fa6fb"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.43m },
                    { new Guid("97ffc415-fc54-4d3f-bf14-14c6c6315361"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.57m },
                    { new Guid("9ced8803-e76e-47d7-b17d-e17094a621d8"), new Guid("123a8e96-b5f2-4459-a896-da06599036cf"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("9f47b332-689d-435d-9c27-116c1d6aa41f"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 1501, 1.80m },
                    { new Guid("9f6a50f8-3bc4-425d-9378-6e56a720b2f9"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 23, 2.37m },
                    { new Guid("a01018cf-8145-4f7f-8a00-70eca36824d0"), new Guid("dbe61b00-89ef-493c-8930-9d41a402a987"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.87m },
                    { new Guid("a2081584-ed77-4b21-a1d9-173d9dbbdf02"), new Guid("b90943d8-f764-42d3-8fca-da1ba2378634"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("a3d9a3f1-1a22-4f60-b7e9-b2d9f772e86c"), new Guid("76adc0f7-ac5d-43cd-9983-eae135865030"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("a5df7a7a-96cf-4b47-b9c7-94854bfb8b64"), new Guid("72516348-d8e7-4ce3-af4e-f97b77897f89"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("aa8816f7-ff17-498d-8930-1ade9993327f"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 71, 2.55m },
                    { new Guid("abe77fdd-828e-4d79-9827-6953aeaad7e2"), new Guid("d484cf5d-d07d-4e01-8aa4-c87747fa68fe"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("b7c660e4-07ec-48dd-9d1c-501f8483c837"), new Guid("3bf2da8a-0a2c-4a8f-99c9-35742cb7fa2e"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("c600b80b-eee9-4ab8-b898-941817d20727"), new Guid("76adc0f7-ac5d-43cd-9983-eae135865030"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.00m },
                    { new Guid("c7238d9b-5e45-478f-9c7b-11feb8ac646c"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.57m },
                    { new Guid("cb67929b-312b-47cc-b11b-aaaf489f9f23"), new Guid("dbe61b00-89ef-493c-8930-9d41a402a987"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.46m },
                    { new Guid("cbd12487-f493-41fc-a2dc-f3b0094ec58d"), new Guid("72516348-d8e7-4ce3-af4e-f97b77897f89"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.97m },
                    { new Guid("d0944a1f-6da7-4711-846e-5978e107736d"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 2.06m },
                    { new Guid("d6b32c93-4ae1-402f-90d2-504f8820140f"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 1501, 1.95m },
                    { new Guid("d7ba9058-0e5c-4708-9527-d787e06f9c0a"), new Guid("98ead996-828c-4a6f-99c2-914b7c8110ef"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("de4abdce-5291-4d2c-8e1b-de2bc5600ad6"), new Guid("5f0411d9-fc63-4dd4-a03f-50c26f0829c6"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("df9a606a-bda9-4256-bfb4-0eda4d8e2340"), new Guid("123a8e96-b5f2-4459-a896-da06599036cf"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("e3024a86-3ca5-414d-b33e-df573752d8b8"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 71, 2.70m },
                    { new Guid("e8b6f70f-02b6-4c43-9687-7ca575798d60"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 301, 1.82m },
                    { new Guid("ec5e05d9-e2de-4cd9-897f-c6eb441c3dc7"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 23, 2.55m },
                    { new Guid("ee7894da-a1c8-4e8f-936b-28fb56281815"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.90m },
                    { new Guid("fa367c8b-d8b8-4ae8-85f0-8b46febdda72"), new Guid("5abcb711-259a-48dc-9817-2e5b988d690a"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("febaa7f4-9d96-4788-924c-c5150b321683"), new Guid("2b26b58b-050c-46a7-8567-2325c31fa6fb"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("ffb1cd61-db1e-4249-ab43-13bc5cae0353"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 23, 2.70m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("0005399a-6343-4c99-9069-254584a8c3ee"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("01f0a024-2333-4d5f-9df6-523c6e891ef7"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("04f4a19b-f2d6-4a1f-9156-9920550d1536"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("06fab812-9f40-45d8-ab2b-0703ab6c7055"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("07e4e0d3-a768-46e1-bc3c-06801e509c31"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("0a49f26b-3c5c-4914-b7a3-b533ff08c747"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("0b31383f-0801-4e41-aa29-12e008784956"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("0badeed9-a777-45a2-a6c8-0e86cdb2e930"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("0ec48687-d2e4-4f58-9b74-2097d9991bdd"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("123da90d-6dda-4605-a755-c56ce7a2cf34"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("14bf28bf-6a8d-4afa-b29c-5a3f90c71a45"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("15e424c5-a72f-4eb1-963c-ca5ae7141c83"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("17bc576d-d493-4f8d-9039-c43ba14c9639"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("18f67810-8e0e-47c1-988d-c2737ce8ebee"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("194af597-f8e9-4049-9231-9d9ddf7193ac"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("1d3fa72c-5ea8-4bc7-8ac0-612a8ec7a555"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("2407409c-da79-4a42-a8f9-226d38e8b00c"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("251c341f-c99b-4ee1-9627-4feb5d708143"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("2536cc99-c145-433e-9b80-95a18348428e"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("2b02f1a3-61d9-450d-8539-a5ab050d83b7"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("2c3e0539-729d-4f2e-aacb-2c731d71b94d"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("306680ea-8452-4082-b3f2-70a09a311340"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("325257c8-f124-4bbf-8860-4ac5af5e2b46"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("36b50892-fcda-44dd-87ee-e7526b9c318c"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("3a557b65-9869-4ab0-a9ac-649682e42ebc"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("3dd07969-8070-4691-979a-97bdb202fc52"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("3eda579e-8d9a-40a2-8107-22c31638eb73"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("42bf1932-a2fd-4314-9b6a-403b0c150237"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("460e932b-7789-4ae7-9cda-447cc6bedb27"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("48e68cab-3e53-4d55-87ad-a67c90d5d460"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("4a6c1973-bcd0-46a9-8d11-8234345276f6"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("4dde1261-07d5-4dc1-b12c-550aad64bf73"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("530aab5e-afbe-4ed9-9865-bc674e43af5f"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("5b94a26d-7508-4bd5-a74d-a45a0ff6a78f"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("5d8c33c7-3c1f-4b36-b21a-f2c369758625"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("5e0d612e-97ad-4c28-bd62-e8659e2e92d8"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("5e746c67-d994-4fb1-9e3b-ec364150110b"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("5f2306a2-4ed5-4181-9e15-e60cb557e19b"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("5fd30917-fb3e-4724-b747-20a276354e45"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("624899fc-0018-485b-9797-1c2ca908cb13"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("62c04c59-418c-46bd-bd17-05afc26cf04d"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("64f9788f-eab4-41b3-8c88-a25010b49364"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("6591ac05-a38b-478c-a53d-7b72bd14ac5b"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("6950ac32-20d5-45b5-85f5-b6f2b8d36449"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("69e15296-cd12-4aca-974c-c14cd610bedf"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("6c204e5b-d2b0-4baa-93a8-d5fe759842f2"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("79c0d3ac-c0c4-422b-8dbf-59bad9f4f1e4"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("7c1825ad-86db-4ec9-836a-6ec3091a1949"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("7ddd4b01-370b-435f-9d95-1f8db5d82687"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("80214f79-6d1c-47ef-911c-b08b1d0f175a"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("8612afcd-c62f-43d3-9e0a-3a0c55952553"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("91687e45-1c97-429c-b724-9d3d557b0e70"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("9261fc39-e173-4268-9b90-d1534cd7e091"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("92747c31-b7ef-4d61-98f5-9b4e13bc6b7e"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("9500ad5a-380e-4a05-ab33-a92817125325"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("95c35a77-81cf-409d-babd-001a8f8db1d5"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("97ffc415-fc54-4d3f-bf14-14c6c6315361"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("9ced8803-e76e-47d7-b17d-e17094a621d8"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("9f47b332-689d-435d-9c27-116c1d6aa41f"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("9f6a50f8-3bc4-425d-9378-6e56a720b2f9"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("a01018cf-8145-4f7f-8a00-70eca36824d0"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("a2081584-ed77-4b21-a1d9-173d9dbbdf02"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("a3d9a3f1-1a22-4f60-b7e9-b2d9f772e86c"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("a5df7a7a-96cf-4b47-b9c7-94854bfb8b64"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("aa8816f7-ff17-498d-8930-1ade9993327f"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("abe77fdd-828e-4d79-9827-6953aeaad7e2"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("b7c660e4-07ec-48dd-9d1c-501f8483c837"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("c600b80b-eee9-4ab8-b898-941817d20727"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("c7238d9b-5e45-478f-9c7b-11feb8ac646c"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("cb67929b-312b-47cc-b11b-aaaf489f9f23"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("cbd12487-f493-41fc-a2dc-f3b0094ec58d"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("d0944a1f-6da7-4711-846e-5978e107736d"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("d6b32c93-4ae1-402f-90d2-504f8820140f"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("d7ba9058-0e5c-4708-9527-d787e06f9c0a"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("de4abdce-5291-4d2c-8e1b-de2bc5600ad6"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("df9a606a-bda9-4256-bfb4-0eda4d8e2340"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("e3024a86-3ca5-414d-b33e-df573752d8b8"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("e8b6f70f-02b6-4c43-9687-7ca575798d60"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("ec5e05d9-e2de-4cd9-897f-c6eb441c3dc7"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("ee7894da-a1c8-4e8f-936b-28fb56281815"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("fa367c8b-d8b8-4ae8-85f0-8b46febdda72"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("febaa7f4-9d96-4788-924c-c5150b321683"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("ffb1cd61-db1e-4249-ab43-13bc5cae0353"));

            migrationBuilder.InsertData(
                table: "TransportFees",
                columns: new[] { "Id", "DistrictId", "MethodId", "MinWeight", "Value" },
                values: new object[,]
                {
                    { new Guid("04a25995-6c5c-4963-b1e9-bdccc364050c"), new Guid("ccd6ecfe-c907-4777-96ad-40ab41b7ac06"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.46m },
                    { new Guid("04bdd099-ecf0-457e-8a64-b051be40d6dc"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.57m },
                    { new Guid("0796435a-f654-4f63-9702-3443ed22a2dc"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 71, 2.70m },
                    { new Guid("11f9ecf8-239a-41f5-ad95-1a85ea3fc861"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 23, 2.55m },
                    { new Guid("15ca3c1b-bb7c-49a1-899e-e8cffa8bc5af"), new Guid("6d332a8f-0bcd-4b81-9c59-6965f4ab40ae"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.00m },
                    { new Guid("164bcda9-cdb1-46e1-b44a-a1d4c010a658"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("1d3a6321-c72a-4a16-9803-1ab660e454ba"), new Guid("5f0411d9-fc63-4dd4-a03f-50c26f0829c6"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.97m },
                    { new Guid("25c22d18-3f33-48ab-9b4e-eaed18ca3bb9"), new Guid("dbe61b00-89ef-493c-8930-9d41a402a987"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("25f0613c-057b-461e-a833-1e1e410a9eb0"), new Guid("5abcb711-259a-48dc-9817-2e5b988d690a"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("2855f597-8346-429c-86c3-7faa74b31274"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("2c96cab5-1adb-4af4-a5e5-f1e21f49acc3"), new Guid("80ff3e90-dcb9-4bc3-9590-e3a2c331a0ec"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.00m },
                    { new Guid("2eb3d650-4381-434c-ad17-df0a12a7e286"), new Guid("6d332a8f-0bcd-4b81-9c59-6965f4ab40ae"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("33846f05-ab36-4cd8-b533-5df9750d7c1d"), new Guid("72516348-d8e7-4ce3-af4e-f97b77897f89"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("35dcb471-69c3-4d62-b868-3d2a76bba64a"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("36c78ebf-a791-462a-990c-604d92a802e1"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 301, 1.50m },
                    { new Guid("398ed365-a002-4a0f-bd4c-f81fecb94c4c"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 301, 1.98m },
                    { new Guid("43d02c82-0058-48e5-9afe-716f24064d71"), new Guid("b90943d8-f764-42d3-8fca-da1ba2378634"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("45b505d0-cb65-4917-a90e-5896f0681603"), new Guid("6d63584c-813f-48de-9b19-df143f83d2f7"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("46eef368-11c6-4d31-94cb-9afbcba28af5"), new Guid("5abcb711-259a-48dc-9817-2e5b988d690a"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("487aeb28-7ec5-4f84-aa0b-8a9a88c0e696"), new Guid("b90943d8-f764-42d3-8fca-da1ba2378634"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("4aa30780-9a5f-4556-ad52-0223a80a0d3d"), new Guid("72516348-d8e7-4ce3-af4e-f97b77897f89"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("4b5da2ab-dd87-43cc-9743-c009b7d7a38c"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 1501, 1.66m },
                    { new Guid("4ddb4b44-da6b-4d44-ad8b-29d07c5af57d"), new Guid("5abcb711-259a-48dc-9817-2e5b988d690a"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("4f45eb41-6bf2-405e-9a44-fa8b1a7b09bb"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 301, 1.69m },
                    { new Guid("4fc067cf-2a73-436f-8194-655a5c090388"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("50e708d0-a8f2-4479-8a0f-56eff44468f1"), new Guid("d484cf5d-d07d-4e01-8aa4-c87747fa68fe"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.92m },
                    { new Guid("54f870bb-08c1-4839-90ca-33303a3b667a"), new Guid("76adc0f7-ac5d-43cd-9983-eae135865030"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.00m },
                    { new Guid("5d673b03-146a-4e73-aa23-d9aa3c579c02"), new Guid("123a8e96-b5f2-4459-a896-da06599036cf"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("60405a7d-2022-41ff-b7f7-4c5ddcfa1173"), new Guid("6d332a8f-0bcd-4b81-9c59-6965f4ab40ae"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("6ba60da0-6279-4af1-ab62-a7cff3026e68"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 1501, 1.95m },
                    { new Guid("6c709ad0-8d64-4584-93c1-b1372d0dc5ac"), new Guid("d484cf5d-d07d-4e01-8aa4-c87747fa68fe"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("6ce28814-f616-459a-ad68-ed6fd2d5646e"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.90m },
                    { new Guid("6d7d1ac5-b3fd-4ead-bfdc-450d2156fc90"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 1501, 1.82m },
                    { new Guid("6e48ebd3-b8e4-4b34-8f75-9408c2800bb6"), new Guid("76e0d1b5-4fb7-4dc7-bcb1-1fadff9acc92"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.97m },
                    { new Guid("6e8367ac-0ff3-4ebd-bcc2-ced56c950a8f"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 71, 1.93m },
                    { new Guid("6e8cc39c-6223-41c0-b6c6-b0cf6c777126"), new Guid("2b26b58b-050c-46a7-8567-2325c31fa6fb"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.87m },
                    { new Guid("7ce9f819-3e03-412a-8187-a1b89e9ded8b"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.76m },
                    { new Guid("7f52b243-b773-4132-aeea-fa5ffc2c176f"), new Guid("98ead996-828c-4a6f-99c2-914b7c8110ef"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("7f80ff19-3956-41bd-9541-f24536f4e522"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 1501, 1.80m },
                    { new Guid("812a9c0b-7398-4cdc-a1e3-f87a12041ade"), new Guid("b90943d8-f764-42d3-8fca-da1ba2378634"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("83dc4c30-28fa-4f3a-b584-bb0b05b2b24b"), new Guid("76e0d1b5-4fb7-4dc7-bcb1-1fadff9acc92"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("8459e2a9-c586-4122-8007-ce27ad46c983"), new Guid("2b26b58b-050c-46a7-8567-2325c31fa6fb"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("86bb1f00-24dd-4a71-a628-e3a7a752e9c1"), new Guid("ccd6ecfe-c907-4777-96ad-40ab41b7ac06"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.87m },
                    { new Guid("99a4dcec-5945-4d39-bc81-b337b3c137a7"), new Guid("3bf2da8a-0a2c-4a8f-99c9-35742cb7fa2e"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("9fcb1d3e-ceb4-41d0-9057-c0bc218ad263"), new Guid("ccd6ecfe-c907-4777-96ad-40ab41b7ac06"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("9fefdcc2-2a67-43ca-9b48-0195435e28d3"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 71, 2.41m },
                    { new Guid("9ffb2b07-ad26-46d3-87e9-bff911b64811"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 71, 2.22m },
                    { new Guid("a0cd2113-7eb8-426b-8500-aa3479eb6af1"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.57m },
                    { new Guid("a31778f1-c625-4a04-b3e4-910547360339"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("a740a5bb-8f26-4708-9e4a-32545d164b6c"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 23, 2.22m },
                    { new Guid("ab86a408-9821-4db5-b3af-0d8bd4b40fe0"), new Guid("dbe61b00-89ef-493c-8930-9d41a402a987"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.87m },
                    { new Guid("acd696d3-6a01-4a74-b3aa-db74c03ec1b2"), new Guid("2b26b58b-050c-46a7-8567-2325c31fa6fb"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.43m },
                    { new Guid("ad91fd9e-7b92-4d9e-a596-9d537a6616e5"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 301, 1.82m },
                    { new Guid("ae086619-8921-4dd9-a585-a8b320446f48"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 71, 2.55m },
                    { new Guid("b3dfd1aa-afd0-4e90-b8ee-bf8afc94b1c0"), new Guid("6d63584c-813f-48de-9b19-df143f83d2f7"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("b55de380-10f9-4150-9a6a-b680df6bf4be"), new Guid("dbe61b00-89ef-493c-8930-9d41a402a987"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.46m },
                    { new Guid("b79e928b-88bc-4cc2-865b-d518371ea8bb"), new Guid("72516348-d8e7-4ce3-af4e-f97b77897f89"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.97m },
                    { new Guid("b9cbf07c-5c06-4092-ab16-36a9c942c404"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 301, 1.83m },
                    { new Guid("baf72862-41b7-43bb-b1b0-5a8e79829c04"), new Guid("d484cf5d-d07d-4e01-8aa4-c87747fa68fe"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.40m },
                    { new Guid("bb0f2f46-47ac-46f4-ac9b-86f3d1aabe2e"), new Guid("6d63584c-813f-48de-9b19-df143f83d2f7"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("bec66dba-50da-4f5e-9b5f-f8ed0ce5ecc4"), new Guid("76adc0f7-ac5d-43cd-9983-eae135865030"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("c42211c1-51f3-4287-9800-6ed9dbc14fa0"), new Guid("123a8e96-b5f2-4459-a896-da06599036cf"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("c6780d41-12f3-463d-b0ff-10cf2f3d6b22"), new Guid("76adc0f7-ac5d-43cd-9983-eae135865030"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("c912db18-5116-45e7-b273-d5fc40c8ccba"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("d1f888d9-d6b5-4039-b3df-5087e638cad1"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 1501, 1.47m },
                    { new Guid("d34c0829-3cf9-4910-a7b1-2a74b6d9053d"), new Guid("98ead996-828c-4a6f-99c2-914b7c8110ef"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("d4789a3b-748d-4f5d-8890-d807cb92575a"), new Guid("123a8e96-b5f2-4459-a896-da06599036cf"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("d4cd4ec0-1d33-4bbf-a49a-df423317fc23"), new Guid("98ead996-828c-4a6f-99c2-914b7c8110ef"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("d53ff9ab-bf5b-43eb-b2b2-9c0d1bc7c8fd"), new Guid("80ff3e90-dcb9-4bc3-9590-e3a2c331a0ec"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("d821b2cc-e214-4ac6-88e3-916bbbdde894"), new Guid("5f0411d9-fc63-4dd4-a03f-50c26f0829c6"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("dae7545f-b27c-4063-9189-5d4ad38b48b5"), new Guid("3bf2da8a-0a2c-4a8f-99c9-35742cb7fa2e"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.46m },
                    { new Guid("db877960-597f-410c-b327-c5fca0c4c36c"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 23, 2.70m },
                    { new Guid("dd04c8b4-1a01-4dec-b511-f2cfae47b469"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 1501, 1.33m },
                    { new Guid("dfe4659d-fee4-49c4-a22e-bff0400032d3"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 23, 2.37m },
                    { new Guid("e18d1bc3-0265-4d9a-86fb-bea9872ae177"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 71, 2.08m },
                    { new Guid("e80b98ef-de69-4a31-a8be-9a2b5eada15d"), new Guid("76e0d1b5-4fb7-4dc7-bcb1-1fadff9acc92"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("e8214c9b-8e45-435b-a97e-09bf9ad6efae"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.43m },
                    { new Guid("ece1a8f1-c748-4414-b187-22fab61de63f"), new Guid("3bf2da8a-0a2c-4a8f-99c9-35742cb7fa2e"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.87m },
                    { new Guid("f05ce716-ac44-43f3-a4aa-f166f90e17a3"), new Guid("5f0411d9-fc63-4dd4-a03f-50c26f0829c6"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("f06582a4-5da5-4fef-9bdc-e453ca04a56e"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 23, 2.84m },
                    { new Guid("fb63d0d8-6572-4240-a027-1b2e1315071e"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 2.06m },
                    { new Guid("fbefd00b-0d2e-440b-9ffb-319539862aef"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 301, 1.36m },
                    { new Guid("fdf57edc-6075-4ac0-9163-ca9e6a3056e5"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 23, 2.08m }
                });
        }
    }
}
