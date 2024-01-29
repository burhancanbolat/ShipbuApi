using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MigrationsMySQL.Migrations
{
    /// <inheritdoc />
    public partial class MaxWeight : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("010b11ba-3330-464f-ad75-4eb0889c5d95"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("01977b5a-2371-4fcd-8a13-085e487c3999"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("07438b0f-0a65-4b47-8c45-8dc8303ccf4e"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("081d408e-b71a-4942-9a85-97be4a8bbe59"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("08231c53-29a8-4655-a1b6-89de7e50a161"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("0ac6258e-93f9-4cd3-a00c-466da75d77ba"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("0b366a65-68b1-4559-8b50-64428b064939"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("0c9ea430-4af3-46de-b721-2f034cf40157"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("0e14a1bd-da88-4808-843a-2bf92b3db48d"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("0fbb111f-9019-4e00-9277-de2f181fd179"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("15104572-bc1e-4cd4-9eac-d33e7b233684"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("151b5a83-cb83-42b6-a34a-6a1ba065a9c3"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("194ce62b-2218-45bd-b212-b49a23da25f0"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("1e502ef0-ce43-43e5-afec-a9129b95f8cc"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("1ed72e6a-07ad-48ef-a369-6af40f45ec85"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("25f361b0-5989-4595-9dd5-1d455c3748d9"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("2611dc78-b5af-47c2-8117-8c2444c4c3a6"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("286800a4-b3a1-4bde-b730-d3766ad87cfa"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("2869cc97-6e1f-495e-9133-d485d6c69735"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("29b5ce0f-cf61-4679-aa92-bc287a6daecf"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("2f6b70a8-0168-4c63-b653-c251a14c6d98"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("3ab946ce-39e7-4acf-8636-82d2c38170e4"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("3efc3d69-43e1-42db-89a6-b0c2f74c311a"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("42a6a0ec-6941-4a86-a784-11912caf5b57"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("46e6f475-3afe-462b-9e3a-52cc905ba8ad"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("5329d827-b33e-4a23-9657-540c1e6b1059"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("54d8fbfb-ef25-4d24-90c9-af68dbfa4f78"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("59876b28-aa54-4009-aa3d-d4479b7d7217"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("59b2b7b7-4ca9-45dc-a46d-1babe887294c"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("5f2006d2-17a4-4235-9fce-3ef0d853402a"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("5fc24b2b-1754-41c9-9dbc-e0d47eb2857e"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("60e14e84-90e8-47ad-9217-242d75160733"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("6772eb14-8146-4348-9c2f-87e33f452a2c"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("6b52851c-49e6-429e-a83a-72b6efa2265a"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("709b591c-63e7-4938-8f78-49fc548b5381"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("70e8e9e3-c6fe-47f6-a4cb-c1460c843acc"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("73561b68-a0c8-4b6d-9b09-f1cd4a55f6c9"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("76d43c92-6fc5-4bb3-8644-7ed96308937a"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("77678588-8b10-415b-b62e-ea92d530f051"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("7d22352c-2a2e-4610-a02f-9c27bb391cf6"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("7de98ab2-7b70-4dad-befe-8ab1beeeaa53"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("820c708c-638d-4508-9a5a-774aaf100757"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("86e7668e-d96e-4220-ae3d-071515f3070c"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("8e50f41d-c80b-4966-b461-07aa59c54dd7"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("8e789028-d0fc-4a4c-8f8f-6f6ae1861e1a"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("93bd8898-1a96-4207-9820-8b88540d4aeb"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("986ed952-3533-4dae-96cf-2597b4d46b0d"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("98d8837a-9d5b-45bd-879c-b21c91a0975c"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("9bb94408-d81b-4698-979f-5f3c2025460e"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("a011114b-63b6-4b74-9999-1b7bd50523ac"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("a12ad379-f84a-41de-b739-27f9188a9722"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("a1c16ac9-81e2-4989-b4fe-f238aaac8c3a"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("a462c41c-cae9-4be9-888f-2ccd96a94c22"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("abacc255-354c-4380-a8e5-d6597cc6d6a7"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("abdf4fcb-525c-4223-8622-5f3126b47bff"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("aed55402-1fff-46f2-a8fb-4f13c2db3ee7"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("b1bf9f4b-b512-4fdb-8616-23a2275d26d4"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("b35f8921-846a-441f-9d2d-e8d1e9cf6565"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("b38d7310-295f-40a5-8faf-2fed824444f6"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("bbb1d430-e3a8-47a3-98ec-9437d9316d4f"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("bfc6e64e-1d74-4c3d-a61d-79a76779a899"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("c2eb6994-3c7f-4767-82bb-61b437f9c01c"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("c5fdd9b5-7d2d-4f55-ad32-bcc50b802dc8"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("c8530da8-1901-45cc-afd3-467d724d2c0e"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("c9388275-6110-4b47-8041-6891d42d7dbb"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("c9a68d5a-9047-4f88-8f51-a51aa01f13f4"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("c9ce4dd2-fd64-4de5-ad09-3a04609f8c2c"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("cbac43f0-9f0e-4a4a-9b96-c74fb486fc2c"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("cf1be432-bee1-4282-ba71-cd396cedda79"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("d6932c15-09b0-4ad8-9a6a-103e0dedc8f8"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("d8b0ee77-1d84-42f7-8d3d-3f252d198fce"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("da913654-45aa-4c94-9067-f682f84473dd"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("dc85057d-a68e-4d5b-8c40-62be3327536e"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("dede97ab-75a7-434f-be52-754bf8778599"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("e71d520c-7f66-4d8e-8dbf-9c1b68554f45"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("ea95ca95-5cc5-43ee-a98d-bec04afa6a38"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("ece00e10-69e8-4517-bb69-21d069697363"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("edb82ad6-3c2e-4a0c-83bf-e0274dbb2121"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("f0b96acd-06a7-4915-87ec-7256520d628a"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("f5a820d0-2baf-471e-adf1-b24994e7778c"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("f7682d43-241a-44df-bfb0-548a138c12e4"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("f8ce4c97-4ba0-4ac2-b977-c68bb8975a4f"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("fd9f5d2d-d26d-4687-b869-6d166bec05ab"));

            migrationBuilder.AddColumn<int>(
                name: "MaxWeight",
                table: "TransportFees",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "TransportFees",
                columns: new[] { "Id", "DistrictId", "MaxWeight", "MethodId", "MinWeight", "Value" },
                values: new object[,]
                {
                    { new Guid("007832c4-84de-4147-a80f-6a7af0abb4fc"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("03f6e5f4-5462-49c9-95a8-2c48d40b1980"), new Guid("98ead996-828c-4a6f-99c2-914b7c8110ef"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("050656de-43ec-4825-b1d1-a47c14babf5e"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 1501, 1.80m },
                    { new Guid("060fad8e-569e-4148-854b-07cd6cfc4fa2"), new Guid("d484cf5d-d07d-4e01-8aa4-c87747fa68fe"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("06f8fde2-c7b0-414a-a192-8f168a401a7f"), new Guid("2b26b58b-050c-46a7-8567-2325c31fa6fb"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("0b10b4c2-964f-4f01-b765-141b3ec34940"), new Guid("6d332a8f-0bcd-4b81-9c59-6965f4ab40ae"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("0b8043b3-ea93-4278-a4df-c9bf697d49d2"), new Guid("123a8e96-b5f2-4459-a896-da06599036cf"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("0e619729-e54e-4bfe-94da-ee01a85145e6"), new Guid("5abcb711-259a-48dc-9817-2e5b988d690a"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("10e06220-1282-40d5-accf-ba90843e69a3"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), 70, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 23, 2.84m },
                    { new Guid("12e759e2-962a-402d-bcd0-1e636f5a302d"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), 300, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.57m },
                    { new Guid("15bc856e-fa21-436c-9f5a-4eefee87f802"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), 100, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 71, 2.08m },
                    { new Guid("1a27c217-bd64-4e91-9a72-4448089fbe3e"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), 70, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 23, 2.55m },
                    { new Guid("2552ffe6-13fa-426e-97af-20523458710b"), new Guid("76adc0f7-ac5d-43cd-9983-eae135865030"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("2b1f10af-7fd3-41d6-ba2b-d944ba1dc0ff"), new Guid("5f0411d9-fc63-4dd4-a03f-50c26f0829c6"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("2bf93d9c-022e-4f9d-bb48-f1237d0f396e"), new Guid("5f0411d9-fc63-4dd4-a03f-50c26f0829c6"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("2c60a64a-7e3a-479b-972f-8bfa3aef0907"), new Guid("6d63584c-813f-48de-9b19-df143f83d2f7"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("2d3bceb7-b1fd-4676-a56f-9a72a99b3083"), new Guid("d484cf5d-d07d-4e01-8aa4-c87747fa68fe"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.40m },
                    { new Guid("2de4a8bf-43ed-46a2-9b3b-9c8c9751f0a1"), new Guid("72516348-d8e7-4ce3-af4e-f97b77897f89"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("2e25e2c7-ee2e-424c-87ee-a019b49b2a93"), new Guid("72516348-d8e7-4ce3-af4e-f97b77897f89"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("36fdcf3b-07ee-42ca-8504-03f211329ce0"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 1501, 1.95m },
                    { new Guid("387e7dbe-6250-44a4-a20e-35c1aa8985e7"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), 1500, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 301, 1.69m },
                    { new Guid("3935a5b3-82a3-42c1-a3ec-87e990ace365"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), 1500, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 301, 1.50m },
                    { new Guid("3ac8029e-377f-4a4a-8d0a-5db0115fe95e"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("3c09d326-cb7e-49c5-95e7-b86ba2e52421"), new Guid("80ff3e90-dcb9-4bc3-9590-e3a2c331a0ec"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.00m },
                    { new Guid("3ee48f22-d485-4259-955b-58b4d75f0c8d"), new Guid("123a8e96-b5f2-4459-a896-da06599036cf"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("409bd379-299a-4a58-822c-356bcc32aa43"), new Guid("76e0d1b5-4fb7-4dc7-bcb1-1fadff9acc92"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("46173c2a-92ea-4736-b6b3-77cd4c9b9de7"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), 1500, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 301, 1.36m },
                    { new Guid("47b73560-174a-4e6b-a77d-9edc982c5ad5"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 1501, 1.33m },
                    { new Guid("4e405fdd-602a-4aaf-9188-37ad21b5f804"), new Guid("98ead996-828c-4a6f-99c2-914b7c8110ef"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("4ead9a19-9e4a-4450-a181-1d9d972bf3cb"), new Guid("d484cf5d-d07d-4e01-8aa4-c87747fa68fe"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.92m },
                    { new Guid("4f05b115-afc0-4c46-8c50-1212d04ee30c"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), 300, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.43m },
                    { new Guid("57170553-ec0f-41f1-a667-5f2fba5fd85f"), new Guid("dbe61b00-89ef-493c-8930-9d41a402a987"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.46m },
                    { new Guid("5f8457eb-79f3-4474-834e-a2d441b64325"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), 70, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 23, 2.70m },
                    { new Guid("62d30b5c-4c80-4af7-a922-d6e68cd59ea2"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), 70, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 23, 2.37m },
                    { new Guid("6690ac5c-9bd2-422e-8320-2a853ee485b7"), new Guid("5abcb711-259a-48dc-9817-2e5b988d690a"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("6700caab-ca27-40bd-a4fd-5ffe9c808bc0"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), 100, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 71, 2.55m },
                    { new Guid("6fc4deea-3b10-4dca-87d7-5cd6256b6c68"), new Guid("b90943d8-f764-42d3-8fca-da1ba2378634"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("7076bf20-c93f-4cf1-95ab-143c127396ad"), new Guid("76e0d1b5-4fb7-4dc7-bcb1-1fadff9acc92"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("716ea99a-a1a7-45d9-8c4a-cfdbc6a49794"), new Guid("2b26b58b-050c-46a7-8567-2325c31fa6fb"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.87m },
                    { new Guid("72edaa7a-5fc6-4405-b882-25605886d760"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), 300, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.76m },
                    { new Guid("7846b243-8d82-44fa-96ee-8cab1d0a2a9d"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), 1500, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 301, 1.82m },
                    { new Guid("794d6c1d-1f52-440c-bdb3-4c01ebe19eb8"), new Guid("123a8e96-b5f2-4459-a896-da06599036cf"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("799783ff-23f1-4165-8000-8cf91b014c18"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 1501, 1.66m },
                    { new Guid("82bdbcc9-aa39-43d6-9419-0b14a9274e6d"), new Guid("ccd6ecfe-c907-4777-96ad-40ab41b7ac06"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.46m },
                    { new Guid("8544c025-bea9-4d1c-b88f-d959fecacee6"), new Guid("3bf2da8a-0a2c-4a8f-99c9-35742cb7fa2e"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.46m },
                    { new Guid("859c64c0-6133-4944-aec1-0f70f9012113"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), 1500, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 301, 1.83m },
                    { new Guid("8ce84018-1512-4587-9879-0ad53d93b971"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), 100, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 71, 1.93m },
                    { new Guid("8dcd0d87-d7fb-48df-8615-2508c0b440d2"), new Guid("98ead996-828c-4a6f-99c2-914b7c8110ef"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("9338ce4c-d834-4122-ba89-b64dadb70a81"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), 300, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.90m },
                    { new Guid("9376cd22-42db-4379-8cb6-40e8ac30b30e"), new Guid("6d332a8f-0bcd-4b81-9c59-6965f4ab40ae"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("93fd7c3a-47ab-4067-8a45-4d5a99dd9e00"), new Guid("76adc0f7-ac5d-43cd-9983-eae135865030"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.00m },
                    { new Guid("94355840-491c-4eb1-98e8-e08a847053a2"), new Guid("5abcb711-259a-48dc-9817-2e5b988d690a"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("95f5de9e-4682-4db4-8601-a6aa439ae6f6"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), 1500, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 301, 1.98m },
                    { new Guid("a12ebf37-80fa-4572-9d54-20e7f37cc6dc"), new Guid("76adc0f7-ac5d-43cd-9983-eae135865030"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("a1b23289-5131-4226-b7ff-47b254253ed9"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), 70, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 23, 2.22m },
                    { new Guid("a53c9123-8be9-427e-b35d-d5d0d761d023"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 1501, 1.82m },
                    { new Guid("a6b00639-53fc-4956-b078-a2157afb21e0"), new Guid("6d332a8f-0bcd-4b81-9c59-6965f4ab40ae"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.00m },
                    { new Guid("a7bbcb6d-33b0-4140-a7e9-f8bbbf8f54fe"), new Guid("6d63584c-813f-48de-9b19-df143f83d2f7"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("a88b4960-afc3-4421-874b-dcc1778a34b8"), new Guid("76e0d1b5-4fb7-4dc7-bcb1-1fadff9acc92"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.97m },
                    { new Guid("afb5774d-d748-4b64-8a87-75e1bbcb92af"), new Guid("3bf2da8a-0a2c-4a8f-99c9-35742cb7fa2e"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("b390d8f1-d3d8-453f-ba01-df80e44fc09d"), new Guid("3bf2da8a-0a2c-4a8f-99c9-35742cb7fa2e"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.87m },
                    { new Guid("b584ba38-a55e-4df0-ae7a-708e6adb92b1"), new Guid("5f0411d9-fc63-4dd4-a03f-50c26f0829c6"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.97m },
                    { new Guid("b5b7955d-842a-4b35-8734-05e666178024"), new Guid("2b26b58b-050c-46a7-8567-2325c31fa6fb"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.43m },
                    { new Guid("b810fa76-aa1e-4fec-893f-0a58f8527ef2"), new Guid("ccd6ecfe-c907-4777-96ad-40ab41b7ac06"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("ba6425a5-9edc-4c14-8e89-abab323d1c29"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), 100, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 71, 2.70m },
                    { new Guid("bc169593-cadb-4987-ada7-59e86fb39776"), new Guid("b90943d8-f764-42d3-8fca-da1ba2378634"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("bcfe2285-4f2f-4ec2-b48f-e5c6524cfa0a"), new Guid("80ff3e90-dcb9-4bc3-9590-e3a2c331a0ec"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("c9042299-bb76-4247-9221-7173ebd74507"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), 300, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.57m },
                    { new Guid("cb3ad754-11aa-4640-92e3-31e4a5276c2c"), new Guid("72516348-d8e7-4ce3-af4e-f97b77897f89"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.97m },
                    { new Guid("d1ba44f7-dca3-4820-832f-b224c40a9faa"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), 100, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 71, 2.41m },
                    { new Guid("d43a3017-e116-4405-a784-cad4962c0564"), new Guid("ccd6ecfe-c907-4777-96ad-40ab41b7ac06"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.87m },
                    { new Guid("d43cceeb-7b5c-44a9-ae53-27a30fe6ab63"), new Guid("dbe61b00-89ef-493c-8930-9d41a402a987"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("e38ca920-089a-43bd-ba9e-de6bbc756ee7"), new Guid("b90943d8-f764-42d3-8fca-da1ba2378634"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("e793779e-7bba-4b8a-bfa0-d4f521dde993"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 1501, 1.47m },
                    { new Guid("e81be5e1-47e3-4d7c-b23e-779db11385c0"), new Guid("dbe61b00-89ef-493c-8930-9d41a402a987"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.87m },
                    { new Guid("ecd16e25-2282-49f1-8d91-b10fe303a293"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), 70, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 23, 2.08m },
                    { new Guid("f37df971-237a-45e1-aa63-4470450ed4df"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("f923473e-e607-4b83-9877-a6923ef2d293"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), 100, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 71, 2.22m },
                    { new Guid("fccd41bc-0fbb-47dc-8791-821793f2286f"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), 300, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 2.06m },
                    { new Guid("ff4d5455-85b8-40ac-9deb-bfc5067a8ac4"), new Guid("6d63584c-813f-48de-9b19-df143f83d2f7"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m }
                });

            migrationBuilder.InsertData(
                table: "TransportRegionMethod",
                columns: new[] { "MethodId", "RegionId", "ETAMax", "ETAMin", "Volume" },
                values: new object[] { new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), new Guid("c194434c-7a4d-4d70-98df-1ecc78a333aa"), 5, 3, 6000 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("007832c4-84de-4147-a80f-6a7af0abb4fc"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("03f6e5f4-5462-49c9-95a8-2c48d40b1980"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("050656de-43ec-4825-b1d1-a47c14babf5e"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("060fad8e-569e-4148-854b-07cd6cfc4fa2"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("06f8fde2-c7b0-414a-a192-8f168a401a7f"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("0b10b4c2-964f-4f01-b765-141b3ec34940"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("0b8043b3-ea93-4278-a4df-c9bf697d49d2"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("0e619729-e54e-4bfe-94da-ee01a85145e6"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("10e06220-1282-40d5-accf-ba90843e69a3"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("12e759e2-962a-402d-bcd0-1e636f5a302d"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("15bc856e-fa21-436c-9f5a-4eefee87f802"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("1a27c217-bd64-4e91-9a72-4448089fbe3e"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("2552ffe6-13fa-426e-97af-20523458710b"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("2b1f10af-7fd3-41d6-ba2b-d944ba1dc0ff"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("2bf93d9c-022e-4f9d-bb48-f1237d0f396e"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("2c60a64a-7e3a-479b-972f-8bfa3aef0907"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("2d3bceb7-b1fd-4676-a56f-9a72a99b3083"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("2de4a8bf-43ed-46a2-9b3b-9c8c9751f0a1"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("2e25e2c7-ee2e-424c-87ee-a019b49b2a93"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("36fdcf3b-07ee-42ca-8504-03f211329ce0"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("387e7dbe-6250-44a4-a20e-35c1aa8985e7"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("3935a5b3-82a3-42c1-a3ec-87e990ace365"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("3ac8029e-377f-4a4a-8d0a-5db0115fe95e"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("3c09d326-cb7e-49c5-95e7-b86ba2e52421"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("3ee48f22-d485-4259-955b-58b4d75f0c8d"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("409bd379-299a-4a58-822c-356bcc32aa43"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("46173c2a-92ea-4736-b6b3-77cd4c9b9de7"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("47b73560-174a-4e6b-a77d-9edc982c5ad5"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("4e405fdd-602a-4aaf-9188-37ad21b5f804"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("4ead9a19-9e4a-4450-a181-1d9d972bf3cb"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("4f05b115-afc0-4c46-8c50-1212d04ee30c"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("57170553-ec0f-41f1-a667-5f2fba5fd85f"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("5f8457eb-79f3-4474-834e-a2d441b64325"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("62d30b5c-4c80-4af7-a922-d6e68cd59ea2"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("6690ac5c-9bd2-422e-8320-2a853ee485b7"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("6700caab-ca27-40bd-a4fd-5ffe9c808bc0"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("6fc4deea-3b10-4dca-87d7-5cd6256b6c68"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("7076bf20-c93f-4cf1-95ab-143c127396ad"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("716ea99a-a1a7-45d9-8c4a-cfdbc6a49794"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("72edaa7a-5fc6-4405-b882-25605886d760"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("7846b243-8d82-44fa-96ee-8cab1d0a2a9d"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("794d6c1d-1f52-440c-bdb3-4c01ebe19eb8"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("799783ff-23f1-4165-8000-8cf91b014c18"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("82bdbcc9-aa39-43d6-9419-0b14a9274e6d"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("8544c025-bea9-4d1c-b88f-d959fecacee6"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("859c64c0-6133-4944-aec1-0f70f9012113"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("8ce84018-1512-4587-9879-0ad53d93b971"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("8dcd0d87-d7fb-48df-8615-2508c0b440d2"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("9338ce4c-d834-4122-ba89-b64dadb70a81"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("9376cd22-42db-4379-8cb6-40e8ac30b30e"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("93fd7c3a-47ab-4067-8a45-4d5a99dd9e00"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("94355840-491c-4eb1-98e8-e08a847053a2"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("95f5de9e-4682-4db4-8601-a6aa439ae6f6"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("a12ebf37-80fa-4572-9d54-20e7f37cc6dc"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("a1b23289-5131-4226-b7ff-47b254253ed9"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("a53c9123-8be9-427e-b35d-d5d0d761d023"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("a6b00639-53fc-4956-b078-a2157afb21e0"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("a7bbcb6d-33b0-4140-a7e9-f8bbbf8f54fe"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("a88b4960-afc3-4421-874b-dcc1778a34b8"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("afb5774d-d748-4b64-8a87-75e1bbcb92af"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("b390d8f1-d3d8-453f-ba01-df80e44fc09d"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("b584ba38-a55e-4df0-ae7a-708e6adb92b1"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("b5b7955d-842a-4b35-8734-05e666178024"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("b810fa76-aa1e-4fec-893f-0a58f8527ef2"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("ba6425a5-9edc-4c14-8e89-abab323d1c29"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("bc169593-cadb-4987-ada7-59e86fb39776"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("bcfe2285-4f2f-4ec2-b48f-e5c6524cfa0a"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("c9042299-bb76-4247-9221-7173ebd74507"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("cb3ad754-11aa-4640-92e3-31e4a5276c2c"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("d1ba44f7-dca3-4820-832f-b224c40a9faa"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("d43a3017-e116-4405-a784-cad4962c0564"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("d43cceeb-7b5c-44a9-ae53-27a30fe6ab63"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("e38ca920-089a-43bd-ba9e-de6bbc756ee7"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("e793779e-7bba-4b8a-bfa0-d4f521dde993"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("e81be5e1-47e3-4d7c-b23e-779db11385c0"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("ecd16e25-2282-49f1-8d91-b10fe303a293"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("f37df971-237a-45e1-aa63-4470450ed4df"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("f923473e-e607-4b83-9877-a6923ef2d293"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("fccd41bc-0fbb-47dc-8791-821793f2286f"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("ff4d5455-85b8-40ac-9deb-bfc5067a8ac4"));

            migrationBuilder.DeleteData(
                table: "TransportRegionMethod",
                keyColumns: new[] { "MethodId", "RegionId" },
                keyValues: new object[] { new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), new Guid("c194434c-7a4d-4d70-98df-1ecc78a333aa") });

            migrationBuilder.DropColumn(
                name: "MaxWeight",
                table: "TransportFees");

            migrationBuilder.InsertData(
                table: "TransportFees",
                columns: new[] { "Id", "DistrictId", "MethodId", "MinWeight", "Value" },
                values: new object[,]
                {
                    { new Guid("010b11ba-3330-464f-ad75-4eb0889c5d95"), new Guid("72516348-d8e7-4ce3-af4e-f97b77897f89"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.97m },
                    { new Guid("01977b5a-2371-4fcd-8a13-085e487c3999"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 71, 2.70m },
                    { new Guid("07438b0f-0a65-4b47-8c45-8dc8303ccf4e"), new Guid("2b26b58b-050c-46a7-8567-2325c31fa6fb"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.43m },
                    { new Guid("081d408e-b71a-4942-9a85-97be4a8bbe59"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 23, 2.22m },
                    { new Guid("08231c53-29a8-4655-a1b6-89de7e50a161"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 23, 2.70m },
                    { new Guid("0ac6258e-93f9-4cd3-a00c-466da75d77ba"), new Guid("b90943d8-f764-42d3-8fca-da1ba2378634"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("0b366a65-68b1-4559-8b50-64428b064939"), new Guid("5f0411d9-fc63-4dd4-a03f-50c26f0829c6"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("0c9ea430-4af3-46de-b721-2f034cf40157"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 1501, 1.82m },
                    { new Guid("0e14a1bd-da88-4808-843a-2bf92b3db48d"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 301, 1.36m },
                    { new Guid("0fbb111f-9019-4e00-9277-de2f181fd179"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("15104572-bc1e-4cd4-9eac-d33e7b233684"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 1501, 1.66m },
                    { new Guid("151b5a83-cb83-42b6-a34a-6a1ba065a9c3"), new Guid("dbe61b00-89ef-493c-8930-9d41a402a987"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.46m },
                    { new Guid("194ce62b-2218-45bd-b212-b49a23da25f0"), new Guid("6d63584c-813f-48de-9b19-df143f83d2f7"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("1e502ef0-ce43-43e5-afec-a9129b95f8cc"), new Guid("80ff3e90-dcb9-4bc3-9590-e3a2c331a0ec"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.00m },
                    { new Guid("1ed72e6a-07ad-48ef-a369-6af40f45ec85"), new Guid("6d332a8f-0bcd-4b81-9c59-6965f4ab40ae"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.00m },
                    { new Guid("25f361b0-5989-4595-9dd5-1d455c3748d9"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 1501, 1.95m },
                    { new Guid("2611dc78-b5af-47c2-8117-8c2444c4c3a6"), new Guid("72516348-d8e7-4ce3-af4e-f97b77897f89"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("286800a4-b3a1-4bde-b730-d3766ad87cfa"), new Guid("72516348-d8e7-4ce3-af4e-f97b77897f89"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("2869cc97-6e1f-495e-9133-d485d6c69735"), new Guid("d484cf5d-d07d-4e01-8aa4-c87747fa68fe"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.92m },
                    { new Guid("29b5ce0f-cf61-4679-aa92-bc287a6daecf"), new Guid("76adc0f7-ac5d-43cd-9983-eae135865030"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("2f6b70a8-0168-4c63-b653-c251a14c6d98"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 301, 1.83m },
                    { new Guid("3ab946ce-39e7-4acf-8636-82d2c38170e4"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 301, 1.82m },
                    { new Guid("3efc3d69-43e1-42db-89a6-b0c2f74c311a"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.43m },
                    { new Guid("42a6a0ec-6941-4a86-a784-11912caf5b57"), new Guid("ccd6ecfe-c907-4777-96ad-40ab41b7ac06"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("46e6f475-3afe-462b-9e3a-52cc905ba8ad"), new Guid("5abcb711-259a-48dc-9817-2e5b988d690a"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("5329d827-b33e-4a23-9657-540c1e6b1059"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("54d8fbfb-ef25-4d24-90c9-af68dbfa4f78"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 301, 1.69m },
                    { new Guid("59876b28-aa54-4009-aa3d-d4479b7d7217"), new Guid("98ead996-828c-4a6f-99c2-914b7c8110ef"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("59b2b7b7-4ca9-45dc-a46d-1babe887294c"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 301, 1.98m },
                    { new Guid("5f2006d2-17a4-4235-9fce-3ef0d853402a"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 71, 2.22m },
                    { new Guid("5fc24b2b-1754-41c9-9dbc-e0d47eb2857e"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 71, 2.55m },
                    { new Guid("60e14e84-90e8-47ad-9217-242d75160733"), new Guid("d484cf5d-d07d-4e01-8aa4-c87747fa68fe"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("6772eb14-8146-4348-9c2f-87e33f452a2c"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 23, 2.55m },
                    { new Guid("6b52851c-49e6-429e-a83a-72b6efa2265a"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 71, 1.93m },
                    { new Guid("709b591c-63e7-4938-8f78-49fc548b5381"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 2.06m },
                    { new Guid("70e8e9e3-c6fe-47f6-a4cb-c1460c843acc"), new Guid("76adc0f7-ac5d-43cd-9983-eae135865030"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.00m },
                    { new Guid("73561b68-a0c8-4b6d-9b09-f1cd4a55f6c9"), new Guid("dbe61b00-89ef-493c-8930-9d41a402a987"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("76d43c92-6fc5-4bb3-8644-7ed96308937a"), new Guid("b90943d8-f764-42d3-8fca-da1ba2378634"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("77678588-8b10-415b-b62e-ea92d530f051"), new Guid("6d332a8f-0bcd-4b81-9c59-6965f4ab40ae"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("7d22352c-2a2e-4610-a02f-9c27bb391cf6"), new Guid("5abcb711-259a-48dc-9817-2e5b988d690a"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("7de98ab2-7b70-4dad-befe-8ab1beeeaa53"), new Guid("6d63584c-813f-48de-9b19-df143f83d2f7"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("820c708c-638d-4508-9a5a-774aaf100757"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.76m },
                    { new Guid("86e7668e-d96e-4220-ae3d-071515f3070c"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("8e50f41d-c80b-4966-b461-07aa59c54dd7"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 1501, 1.33m },
                    { new Guid("8e789028-d0fc-4a4c-8f8f-6f6ae1861e1a"), new Guid("d484cf5d-d07d-4e01-8aa4-c87747fa68fe"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.40m },
                    { new Guid("93bd8898-1a96-4207-9820-8b88540d4aeb"), new Guid("2b26b58b-050c-46a7-8567-2325c31fa6fb"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("986ed952-3533-4dae-96cf-2597b4d46b0d"), new Guid("ccd6ecfe-c907-4777-96ad-40ab41b7ac06"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.46m },
                    { new Guid("98d8837a-9d5b-45bd-879c-b21c91a0975c"), new Guid("98ead996-828c-4a6f-99c2-914b7c8110ef"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("9bb94408-d81b-4698-979f-5f3c2025460e"), new Guid("3bf2da8a-0a2c-4a8f-99c9-35742cb7fa2e"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.87m },
                    { new Guid("a011114b-63b6-4b74-9999-1b7bd50523ac"), new Guid("80ff3e90-dcb9-4bc3-9590-e3a2c331a0ec"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("a12ad379-f84a-41de-b739-27f9188a9722"), new Guid("76e0d1b5-4fb7-4dc7-bcb1-1fadff9acc92"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("a1c16ac9-81e2-4989-b4fe-f238aaac8c3a"), new Guid("3bf2da8a-0a2c-4a8f-99c9-35742cb7fa2e"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.46m },
                    { new Guid("a462c41c-cae9-4be9-888f-2ccd96a94c22"), new Guid("123a8e96-b5f2-4459-a896-da06599036cf"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("abacc255-354c-4380-a8e5-d6597cc6d6a7"), new Guid("5abcb711-259a-48dc-9817-2e5b988d690a"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("abdf4fcb-525c-4223-8622-5f3126b47bff"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 23, 2.08m },
                    { new Guid("aed55402-1fff-46f2-a8fb-4f13c2db3ee7"), new Guid("6d332a8f-0bcd-4b81-9c59-6965f4ab40ae"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("b1bf9f4b-b512-4fdb-8616-23a2275d26d4"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.90m },
                    { new Guid("b35f8921-846a-441f-9d2d-e8d1e9cf6565"), new Guid("76adc0f7-ac5d-43cd-9983-eae135865030"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("b38d7310-295f-40a5-8faf-2fed824444f6"), new Guid("3bf2da8a-0a2c-4a8f-99c9-35742cb7fa2e"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("bbb1d430-e3a8-47a3-98ec-9437d9316d4f"), new Guid("2b26b58b-050c-46a7-8567-2325c31fa6fb"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.87m },
                    { new Guid("bfc6e64e-1d74-4c3d-a61d-79a76779a899"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 23, 2.84m },
                    { new Guid("c2eb6994-3c7f-4767-82bb-61b437f9c01c"), new Guid("6d63584c-813f-48de-9b19-df143f83d2f7"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("c5fdd9b5-7d2d-4f55-ad32-bcc50b802dc8"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("c8530da8-1901-45cc-afd3-467d724d2c0e"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.57m },
                    { new Guid("c9388275-6110-4b47-8041-6891d42d7dbb"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("c9a68d5a-9047-4f88-8f51-a51aa01f13f4"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 71, 2.41m },
                    { new Guid("c9ce4dd2-fd64-4de5-ad09-3a04609f8c2c"), new Guid("76e0d1b5-4fb7-4dc7-bcb1-1fadff9acc92"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("cbac43f0-9f0e-4a4a-9b96-c74fb486fc2c"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 23, 2.37m },
                    { new Guid("cf1be432-bee1-4282-ba71-cd396cedda79"), new Guid("98ead996-828c-4a6f-99c2-914b7c8110ef"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("d6932c15-09b0-4ad8-9a6a-103e0dedc8f8"), new Guid("123a8e96-b5f2-4459-a896-da06599036cf"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("d8b0ee77-1d84-42f7-8d3d-3f252d198fce"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 1501, 1.80m },
                    { new Guid("da913654-45aa-4c94-9067-f682f84473dd"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 71, 2.08m },
                    { new Guid("dc85057d-a68e-4d5b-8c40-62be3327536e"), new Guid("dbe61b00-89ef-493c-8930-9d41a402a987"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.87m },
                    { new Guid("dede97ab-75a7-434f-be52-754bf8778599"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("e71d520c-7f66-4d8e-8dbf-9c1b68554f45"), new Guid("123a8e96-b5f2-4459-a896-da06599036cf"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("ea95ca95-5cc5-43ee-a98d-bec04afa6a38"), new Guid("5f0411d9-fc63-4dd4-a03f-50c26f0829c6"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.97m },
                    { new Guid("ece00e10-69e8-4517-bb69-21d069697363"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 1501, 1.47m },
                    { new Guid("edb82ad6-3c2e-4a0c-83bf-e0274dbb2121"), new Guid("76e0d1b5-4fb7-4dc7-bcb1-1fadff9acc92"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.97m },
                    { new Guid("f0b96acd-06a7-4915-87ec-7256520d628a"), new Guid("5f0411d9-fc63-4dd4-a03f-50c26f0829c6"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("f5a820d0-2baf-471e-adf1-b24994e7778c"), new Guid("b90943d8-f764-42d3-8fca-da1ba2378634"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("f7682d43-241a-44df-bfb0-548a138c12e4"), new Guid("ccd6ecfe-c907-4777-96ad-40ab41b7ac06"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.87m },
                    { new Guid("f8ce4c97-4ba0-4ac2-b977-c68bb8975a4f"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 301, 1.50m },
                    { new Guid("fd9f5d2d-d26d-4687-b869-6d166bec05ab"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.57m }
                });
        }
    }
}
