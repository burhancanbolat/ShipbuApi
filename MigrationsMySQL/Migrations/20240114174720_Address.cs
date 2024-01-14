using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MigrationsMySQL.Migrations
{
    /// <inheritdoc />
    public partial class Address : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "TransportOrderItems",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "HasAddress",
                table: "TransportOrderItems",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "TransportOrderItems",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "TransportOrderItems",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "TransportFees",
                columns: new[] { "Id", "DistrictId", "MethodId", "MinWeight", "Value" },
                values: new object[,]
                {
                    { new Guid("0354c60e-e98b-4737-87bb-d1a7e1e9cad0"), new Guid("6d332a8f-0bcd-4b81-9c59-6965f4ab40ae"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.00m },
                    { new Guid("05142a75-6616-4cf1-be2c-f6fb445b6f2a"), new Guid("76adc0f7-ac5d-43cd-9983-eae135865030"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.00m },
                    { new Guid("0836dfc5-2fe6-4c4c-b9d1-c9f8c125fd4c"), new Guid("ccd6ecfe-c907-4777-96ad-40ab41b7ac06"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("0b4a5faf-e99c-423e-8fb0-3e3da466b02e"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 1501, 1.82m },
                    { new Guid("0e09c636-be6c-46da-be4f-f0f677b4147d"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 1501, 1.47m },
                    { new Guid("0e1d1b1e-e21e-4272-b579-a5a502e50375"), new Guid("5f0411d9-fc63-4dd4-a03f-50c26f0829c6"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("0e56e6ad-8a3c-468d-9fe1-b56800009e0e"), new Guid("dbe61b00-89ef-493c-8930-9d41a402a987"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.46m },
                    { new Guid("11a76692-3ef0-4880-baf5-275ed2b8939c"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 2.06m },
                    { new Guid("13b013d7-6d5f-4c66-844e-b414986860e4"), new Guid("76adc0f7-ac5d-43cd-9983-eae135865030"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("141bf663-21a9-4c45-8821-8758c3995a56"), new Guid("d484cf5d-d07d-4e01-8aa4-c87747fa68fe"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.40m },
                    { new Guid("1cae0400-32f1-4959-8c1a-26ae81add659"), new Guid("2b26b58b-050c-46a7-8567-2325c31fa6fb"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("1e73c45f-b935-44ba-83aa-df6b31be7fa6"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.57m },
                    { new Guid("20769105-fdd5-4818-9b90-a8f30f02d8b5"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 1501, 1.33m },
                    { new Guid("23cedabe-c27b-491e-be1e-1db5b03b1a3c"), new Guid("3bf2da8a-0a2c-4a8f-99c9-35742cb7fa2e"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("293ce448-5373-4321-8fca-8c823604fb34"), new Guid("76e0d1b5-4fb7-4dc7-bcb1-1fadff9acc92"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("2b48ae11-cb9c-4283-9e9f-b72e2eb8252d"), new Guid("5f0411d9-fc63-4dd4-a03f-50c26f0829c6"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.97m },
                    { new Guid("2c815f10-4889-4fe7-9b8f-302df4b54ef7"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 23, 2.84m },
                    { new Guid("2cbb44f7-a3e3-4444-85a9-6f8baee54f34"), new Guid("6d332a8f-0bcd-4b81-9c59-6965f4ab40ae"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("2df3e7a7-24c2-4d96-a214-ac0fa639645b"), new Guid("123a8e96-b5f2-4459-a896-da06599036cf"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("34599025-c411-4817-95e2-163143f8b454"), new Guid("6d332a8f-0bcd-4b81-9c59-6965f4ab40ae"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("3490aebe-b720-4577-ab5d-7074eac48237"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 301, 1.36m },
                    { new Guid("3c366b81-b961-4065-a618-efb80d70a046"), new Guid("123a8e96-b5f2-4459-a896-da06599036cf"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("46d4bb73-9011-45e5-820a-11945177d76e"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 301, 1.83m },
                    { new Guid("47bb681f-a2ba-4ed2-80bc-f2e0eac944dc"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("4a51bb9b-e3ce-4448-b56e-a10c1c1570f0"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 71, 2.55m },
                    { new Guid("53cfa498-8f41-45a4-a17c-8e466caa44ce"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("5d700003-4975-449d-8d33-f2a5eddbeebf"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 23, 2.22m },
                    { new Guid("6cd64291-e078-4794-a75b-81af9445cc56"), new Guid("d484cf5d-d07d-4e01-8aa4-c87747fa68fe"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("6cf0c56f-5235-432d-a5a7-a983623d9a40"), new Guid("b90943d8-f764-42d3-8fca-da1ba2378634"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("70e4af96-17e7-4341-bcb4-1ba6bdff8f9c"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 71, 2.08m },
                    { new Guid("71bd9a4d-e0c3-4bc6-be51-1f6b77ec81a5"), new Guid("2b26b58b-050c-46a7-8567-2325c31fa6fb"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.43m },
                    { new Guid("72d9e32d-45bf-4d06-b6ec-9dad1f5e15dc"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 301, 1.98m },
                    { new Guid("756b8bf2-e482-41e6-9d72-db550170a89b"), new Guid("80ff3e90-dcb9-4bc3-9590-e3a2c331a0ec"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.00m },
                    { new Guid("75f2ba2f-7d34-43cd-8993-2a0402ce276a"), new Guid("b90943d8-f764-42d3-8fca-da1ba2378634"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("7937e151-e873-4337-9345-184121c09816"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.76m },
                    { new Guid("7d0d6678-ef77-4072-877a-f79a5fe3c04c"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("84ee90bc-fee0-485f-adb1-7fa39ee9e3b3"), new Guid("2b26b58b-050c-46a7-8567-2325c31fa6fb"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.87m },
                    { new Guid("86c0461f-d53a-4801-98b7-b7515dd40a3b"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 71, 1.93m },
                    { new Guid("8779d940-0660-4c30-bf80-6d90bab9f630"), new Guid("b90943d8-f764-42d3-8fca-da1ba2378634"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("891419b8-8ec0-465f-bf2a-504d9a98d2e7"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 71, 2.22m },
                    { new Guid("893d3fcb-4560-49b8-97e2-6235ffb38092"), new Guid("76e0d1b5-4fb7-4dc7-bcb1-1fadff9acc92"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.97m },
                    { new Guid("89a37670-3d62-4416-9d6a-e94b0dc497a4"), new Guid("5f0411d9-fc63-4dd4-a03f-50c26f0829c6"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("8cd46492-daab-464b-bdcb-b07eb5f2d80d"), new Guid("ccd6ecfe-c907-4777-96ad-40ab41b7ac06"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.87m },
                    { new Guid("960a37d1-44de-47a0-b10a-0c1293835729"), new Guid("dbe61b00-89ef-493c-8930-9d41a402a987"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("988046c7-e381-4c8c-96e1-f1420a6779ae"), new Guid("3bf2da8a-0a2c-4a8f-99c9-35742cb7fa2e"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.46m },
                    { new Guid("99ec253d-7d1a-4982-928b-eba975d5b219"), new Guid("72516348-d8e7-4ce3-af4e-f97b77897f89"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("9f32890b-7fda-49d9-bdd5-237ad67e3e39"), new Guid("98ead996-828c-4a6f-99c2-914b7c8110ef"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("a1f015c1-1c1e-4732-a1de-2adaea06855a"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 301, 1.69m },
                    { new Guid("a229589a-5dbb-42b9-979f-da391e902aeb"), new Guid("6d63584c-813f-48de-9b19-df143f83d2f7"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("a75ae6e2-82ce-4c39-a6e4-b2a5ff2d0bab"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("a76fca0b-3eab-4f2c-8f63-be4c64006471"), new Guid("72516348-d8e7-4ce3-af4e-f97b77897f89"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.97m },
                    { new Guid("ac347d77-efbb-49b4-9763-3744668bc7c3"), new Guid("5abcb711-259a-48dc-9817-2e5b988d690a"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("ae730878-6f27-43fe-8540-e4be8e4e8dc0"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 23, 2.37m },
                    { new Guid("b094f911-608e-4140-a2c5-b75fc1db436a"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 1501, 1.80m },
                    { new Guid("b0bf9db4-0594-4312-b15c-588340ebf6db"), new Guid("98ead996-828c-4a6f-99c2-914b7c8110ef"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("b35f90cd-ae8c-41d4-a151-62ec73b823f8"), new Guid("80ff3e90-dcb9-4bc3-9590-e3a2c331a0ec"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("b53e9f6f-82d9-44f2-b202-dac57caf01ab"), new Guid("123a8e96-b5f2-4459-a896-da06599036cf"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("b73662ca-13b9-4d0e-8006-e693168ce6d6"), new Guid("5abcb711-259a-48dc-9817-2e5b988d690a"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("bf240aa3-b278-476b-9c6b-db1155af6593"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 301, 1.50m },
                    { new Guid("bf661233-44b2-4846-8dbc-df3b58ffbffb"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("c40b5074-8566-4467-b9cd-5b6a3447b3c6"), new Guid("3bf2da8a-0a2c-4a8f-99c9-35742cb7fa2e"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.87m },
                    { new Guid("c4731c16-77cb-4dc5-bab9-045dd13e8f3a"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 301, 1.82m },
                    { new Guid("c4d67ff3-f669-46ea-952f-f0b6fd794dc1"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 1501, 1.95m },
                    { new Guid("d0776b60-673d-4d3b-8f86-0f804bc9fd00"), new Guid("76e0d1b5-4fb7-4dc7-bcb1-1fadff9acc92"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("d15fdc98-5b49-4285-88da-e874bba25337"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 71, 2.41m },
                    { new Guid("d313bae5-ae3f-4d82-9c0e-896497ed9613"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.90m },
                    { new Guid("d4d4380b-88f8-4acf-9ab3-bc9bdfe977e7"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 71, 2.70m },
                    { new Guid("d776447b-ce98-45af-a031-50ddf90d5e2c"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.43m },
                    { new Guid("d77e853d-e3bc-4279-ba8b-2fcd323be8a6"), new Guid("dbe61b00-89ef-493c-8930-9d41a402a987"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.87m },
                    { new Guid("da4cfe87-5c52-404b-8a27-ba1bc6bf14dd"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 23, 2.70m },
                    { new Guid("dc080b53-09df-4bc6-aa4f-d9f8e4552d5d"), new Guid("98ead996-828c-4a6f-99c2-914b7c8110ef"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("dda8f797-541f-4b30-aa54-50c6d7a25f9b"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 23, 2.55m },
                    { new Guid("e05606f6-e331-4cd7-aedd-b9d226cc9804"), new Guid("6d63584c-813f-48de-9b19-df143f83d2f7"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("e416aaca-9929-40f5-a416-6df4f76f9324"), new Guid("76adc0f7-ac5d-43cd-9983-eae135865030"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("e4c62f9c-ccbb-42bd-9860-684c4d231ab9"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 23, 2.08m },
                    { new Guid("e6eecebf-7d9c-4174-af2e-41904e34659d"), new Guid("ccd6ecfe-c907-4777-96ad-40ab41b7ac06"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.46m },
                    { new Guid("ec4fc7ef-7f5f-42fc-b157-2e5b1b20a987"), new Guid("d484cf5d-d07d-4e01-8aa4-c87747fa68fe"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.92m },
                    { new Guid("f77796bb-59f7-4c04-872b-f73d9246e10b"), new Guid("5abcb711-259a-48dc-9817-2e5b988d690a"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("f7c7c84a-1c4c-45e9-a237-0ba1da2371c3"), new Guid("72516348-d8e7-4ce3-af4e-f97b77897f89"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("f89e5998-3f2b-4ad2-ab7f-1775923073b5"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 1501, 1.66m },
                    { new Guid("fa1daec2-2ceb-4064-88d0-656923255fa9"), new Guid("6d63584c-813f-48de-9b19-df143f83d2f7"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("fa6159af-d91c-4fe2-909c-d0625db57589"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("fddfc036-159e-4f93-9dae-96288b1d5bdd"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.57m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("0354c60e-e98b-4737-87bb-d1a7e1e9cad0"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("05142a75-6616-4cf1-be2c-f6fb445b6f2a"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("0836dfc5-2fe6-4c4c-b9d1-c9f8c125fd4c"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("0b4a5faf-e99c-423e-8fb0-3e3da466b02e"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("0e09c636-be6c-46da-be4f-f0f677b4147d"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("0e1d1b1e-e21e-4272-b579-a5a502e50375"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("0e56e6ad-8a3c-468d-9fe1-b56800009e0e"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("11a76692-3ef0-4880-baf5-275ed2b8939c"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("13b013d7-6d5f-4c66-844e-b414986860e4"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("141bf663-21a9-4c45-8821-8758c3995a56"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("1cae0400-32f1-4959-8c1a-26ae81add659"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("1e73c45f-b935-44ba-83aa-df6b31be7fa6"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("20769105-fdd5-4818-9b90-a8f30f02d8b5"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("23cedabe-c27b-491e-be1e-1db5b03b1a3c"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("293ce448-5373-4321-8fca-8c823604fb34"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("2b48ae11-cb9c-4283-9e9f-b72e2eb8252d"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("2c815f10-4889-4fe7-9b8f-302df4b54ef7"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("2cbb44f7-a3e3-4444-85a9-6f8baee54f34"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("2df3e7a7-24c2-4d96-a214-ac0fa639645b"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("34599025-c411-4817-95e2-163143f8b454"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("3490aebe-b720-4577-ab5d-7074eac48237"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("3c366b81-b961-4065-a618-efb80d70a046"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("46d4bb73-9011-45e5-820a-11945177d76e"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("47bb681f-a2ba-4ed2-80bc-f2e0eac944dc"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("4a51bb9b-e3ce-4448-b56e-a10c1c1570f0"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("53cfa498-8f41-45a4-a17c-8e466caa44ce"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("5d700003-4975-449d-8d33-f2a5eddbeebf"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("6cd64291-e078-4794-a75b-81af9445cc56"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("6cf0c56f-5235-432d-a5a7-a983623d9a40"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("70e4af96-17e7-4341-bcb4-1ba6bdff8f9c"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("71bd9a4d-e0c3-4bc6-be51-1f6b77ec81a5"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("72d9e32d-45bf-4d06-b6ec-9dad1f5e15dc"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("756b8bf2-e482-41e6-9d72-db550170a89b"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("75f2ba2f-7d34-43cd-8993-2a0402ce276a"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("7937e151-e873-4337-9345-184121c09816"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("7d0d6678-ef77-4072-877a-f79a5fe3c04c"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("84ee90bc-fee0-485f-adb1-7fa39ee9e3b3"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("86c0461f-d53a-4801-98b7-b7515dd40a3b"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("8779d940-0660-4c30-bf80-6d90bab9f630"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("891419b8-8ec0-465f-bf2a-504d9a98d2e7"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("893d3fcb-4560-49b8-97e2-6235ffb38092"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("89a37670-3d62-4416-9d6a-e94b0dc497a4"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("8cd46492-daab-464b-bdcb-b07eb5f2d80d"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("960a37d1-44de-47a0-b10a-0c1293835729"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("988046c7-e381-4c8c-96e1-f1420a6779ae"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("99ec253d-7d1a-4982-928b-eba975d5b219"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("9f32890b-7fda-49d9-bdd5-237ad67e3e39"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("a1f015c1-1c1e-4732-a1de-2adaea06855a"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("a229589a-5dbb-42b9-979f-da391e902aeb"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("a75ae6e2-82ce-4c39-a6e4-b2a5ff2d0bab"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("a76fca0b-3eab-4f2c-8f63-be4c64006471"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("ac347d77-efbb-49b4-9763-3744668bc7c3"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("ae730878-6f27-43fe-8540-e4be8e4e8dc0"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("b094f911-608e-4140-a2c5-b75fc1db436a"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("b0bf9db4-0594-4312-b15c-588340ebf6db"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("b35f90cd-ae8c-41d4-a151-62ec73b823f8"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("b53e9f6f-82d9-44f2-b202-dac57caf01ab"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("b73662ca-13b9-4d0e-8006-e693168ce6d6"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("bf240aa3-b278-476b-9c6b-db1155af6593"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("bf661233-44b2-4846-8dbc-df3b58ffbffb"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("c40b5074-8566-4467-b9cd-5b6a3447b3c6"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("c4731c16-77cb-4dc5-bab9-045dd13e8f3a"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("c4d67ff3-f669-46ea-952f-f0b6fd794dc1"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("d0776b60-673d-4d3b-8f86-0f804bc9fd00"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("d15fdc98-5b49-4285-88da-e874bba25337"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("d313bae5-ae3f-4d82-9c0e-896497ed9613"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("d4d4380b-88f8-4acf-9ab3-bc9bdfe977e7"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("d776447b-ce98-45af-a031-50ddf90d5e2c"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("d77e853d-e3bc-4279-ba8b-2fcd323be8a6"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("da4cfe87-5c52-404b-8a27-ba1bc6bf14dd"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("dc080b53-09df-4bc6-aa4f-d9f8e4552d5d"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("dda8f797-541f-4b30-aa54-50c6d7a25f9b"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("e05606f6-e331-4cd7-aedd-b9d226cc9804"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("e416aaca-9929-40f5-a416-6df4f76f9324"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("e4c62f9c-ccbb-42bd-9860-684c4d231ab9"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("e6eecebf-7d9c-4174-af2e-41904e34659d"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("ec4fc7ef-7f5f-42fc-b157-2e5b1b20a987"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("f77796bb-59f7-4c04-872b-f73d9246e10b"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("f7c7c84a-1c4c-45e9-a237-0ba1da2371c3"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("f89e5998-3f2b-4ad2-ab7f-1775923073b5"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("fa1daec2-2ceb-4064-88d0-656923255fa9"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("fa6159af-d91c-4fe2-909c-d0625db57589"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("fddfc036-159e-4f93-9dae-96288b1d5bdd"));

            migrationBuilder.DropColumn(
                name: "Address",
                table: "TransportOrderItems");

            migrationBuilder.DropColumn(
                name: "HasAddress",
                table: "TransportOrderItems");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "TransportOrderItems");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "TransportOrderItems");

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
    }
}
