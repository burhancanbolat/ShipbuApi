using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MigrationsMySQL.Migrations
{
    /// <inheritdoc />
    public partial class RemoveAddress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "TransportOrders",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "TransportOrders",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "TransportOrders",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

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

            migrationBuilder.UpdateData(
                table: "TransportMethods",
                keyColumn: "Id",
                keyValue: new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"),
                columns: new[] { "NameEn", "NameTr" },
                values: new object[] { "Sea Slow + Express", "Yavaş Gemi + Ekspress" });

            migrationBuilder.UpdateData(
                table: "TransportMethods",
                keyColumn: "Id",
                keyValue: new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"),
                columns: new[] { "NameEn", "NameTr" },
                values: new object[] { "Sea Fast + Express", "Hızlı Gemi + Ekspress" });

            migrationBuilder.InsertData(
                table: "TransportMethods",
                columns: new[] { "Id", "Enabled", "NameEn", "NameTr" },
                values: new object[,]
                {
                    { new Guid("2add124b-9a78-4b78-96d1-523e658f77a4"), true, "Sea Slow + Truck", "Yavaş Gemi + TIR" },
                    { new Guid("4f2febe8-3273-4086-89a4-0a0282f003a8"), true, "Sea Fast + Truck", "Hızlı Gemi + TIR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "TransportMethods",
                keyColumn: "Id",
                keyValue: new Guid("2add124b-9a78-4b78-96d1-523e658f77a4"));

            migrationBuilder.DeleteData(
                table: "TransportMethods",
                keyColumn: "Id",
                keyValue: new Guid("4f2febe8-3273-4086-89a4-0a0282f003a8"));

            migrationBuilder.DropColumn(
                name: "Address",
                table: "TransportOrders");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "TransportOrders");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "TransportOrders");

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

            migrationBuilder.UpdateData(
                table: "TransportMethods",
                keyColumn: "Id",
                keyValue: new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"),
                columns: new[] { "NameEn", "NameTr" },
                values: new object[] { "Sea Slow", "Yavaş Gemi" });

            migrationBuilder.UpdateData(
                table: "TransportMethods",
                keyColumn: "Id",
                keyValue: new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"),
                columns: new[] { "NameEn", "NameTr" },
                values: new object[] { "Sea Fast", "Hızlı Gemi" });
        }
    }
}
