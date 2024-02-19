using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MigrationsMySQL.Migrations
{
    /// <inheritdoc />
    public partial class MigrationUserPayments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("0ade6b8a-28eb-493d-bff4-47c8adadc4ff"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("0b899656-efe4-44f1-a4e9-455d9feaa0c7"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("113a4a49-2de6-42cb-9fea-037db7d40371"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("128a5046-d455-44ba-854d-0b50140a389d"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("14df8f25-696e-4c73-a768-6464daece2a3"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("1b1186d9-c666-4bd5-a447-f73de4164e13"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("1c186316-dbb3-404a-b9d1-ed67fd849bcd"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("1c9024ca-2728-4bbf-a983-67553b68e010"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("2011b907-1435-41bc-b3dd-e6d30cb05ed7"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("204b992f-b348-4c42-90d2-8a69b8077cc5"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("2b97a3bf-0bbd-43bc-8418-c176666a0c0e"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("2d06c458-4d8e-4c70-86f4-633316b3b0ca"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("2d7345c6-7222-4ee2-ae79-88ef280ec07b"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("2d875e84-f0c6-489f-9ccd-bc3755c22523"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("320a798f-8d3c-4bbf-a33f-7104f74663e2"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("32e94740-601d-4bfb-9046-6cbaf484c9e9"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("3731de7f-68a0-490c-84e4-11ca75f6436a"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("3bc60ef8-8eb7-4850-ab14-240ebf130419"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("3ce5a985-d9f7-4013-a86d-ed70254efb85"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("3d8c5990-d66e-4421-8a06-f2c741e128db"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("3da2229b-aa21-461d-a1bc-1d1728f1428f"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("42d696ce-f746-4c89-b8ab-ae421684eb4f"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("46783a14-fcdb-4966-bab5-bbf899c87d6e"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("4881251e-36bb-4719-8396-c632f4c8e9bb"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("4b82f3ad-e1ae-4aa4-b46c-9c2bc68e171d"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("51291fc5-4907-4c40-af41-7b58474a9f29"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("514484eb-b399-4e6a-a35b-ca8ea3002cd6"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("51c77dab-04bf-4158-b65b-7a746588f84e"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("5398b742-2ead-47c8-9cbb-70299c88eeb1"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("591c0e47-ec7e-4c97-8dc5-e7fa9e727658"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("5cb7b65c-a8b7-4dcc-99cb-ee3e13b48f9c"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("5df7c554-6701-4642-ade6-cf1502498a7b"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("5ee2850f-b2be-4f53-b756-cca7895abd50"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("5f1b8ce4-aa72-4050-85e0-acf846c64734"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("6063e5dc-2ee5-4b52-84e6-65e42a2cba06"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("60a877df-e94f-4989-8d32-033cb7042f9d"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("63db9e69-5055-461f-a917-1913dd913aa0"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("688650f6-2980-460d-99dc-a54d29157ab5"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("69fc8126-1213-4d89-84b4-5a2ad309179b"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("6a06cfbf-b184-4c83-9681-ec745e23446f"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("745aa2d6-e023-467c-9f45-90a28826d107"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("7dcd29d4-7095-4e6a-8f7e-f2d1c9373e37"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("8483d76c-afe3-458a-9921-5ac4b5835634"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("853b4a9e-d808-4f00-a502-24c6df2c774c"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("88c27a56-5f6c-432f-b0fb-9836f9fc9f90"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("88dfbf30-fed5-49a9-942c-99eaf6891c9e"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("8b37cbed-056a-4763-9e9b-079af931730f"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("8d911286-971b-4542-b35b-06bc804a23bc"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("8ee084a0-3367-4583-8b67-e016303a14a3"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("9228df16-0ef0-40ac-b77e-83093459edf8"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("9fa343b9-6cf7-4364-ab78-8ea53bcdc9ac"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("a0e8dd45-c473-48a5-a770-1dcfbe9264a7"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("a475d5e1-c793-4050-bba8-89f733da323a"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("ac32ad44-36c9-46bc-925d-8d9c24f61a38"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("ad66fa7f-d5e7-4d90-9b99-0f4e2fe076e7"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("adf40af3-4702-4793-815f-6985d651f647"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("aef6a5e2-f454-4dc7-9384-dfc9b45970b8"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("b4566d68-4a5f-4f4b-9700-4e1dbc089741"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("b5443eff-8b80-4212-834f-d7403e609eda"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("b6912136-42a5-4923-96c1-de209e82dd6c"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("b70e7fe3-539d-48b5-b79a-0be8a00245ca"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("bd1f9f20-43f5-4ccb-a624-e08e2c1a6698"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("be44e3a4-aead-4970-99fb-6c89a938de4b"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("c2d1b315-71d0-4cc8-996b-424d502d14a1"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("c76ae9b8-4a1e-4dae-9333-964f61640b3b"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("c783d5ea-b4df-4e88-abba-60ff29f7a7c7"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("cbcf2484-ab83-4a7b-8c19-9d4d0e776000"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("cf10f476-73d1-4197-b713-a0901cd46389"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("d08accf9-d1cd-4cf0-a852-366f96dce894"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("d1101f3b-31f5-4fc8-a48a-585ec29a6eed"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("d5670043-8e01-4cf1-9bab-5dea4dda448d"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("d82a0f0c-8980-42f2-a01a-af8d83d00dca"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("e4924b8d-a2e6-4465-ad6f-36860019e137"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("eb4128a9-123f-46a2-b305-f685dc5dacf0"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("ec681263-6c21-461f-a0c6-5de456c60a0a"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("edb0ca90-3d28-4d38-b64b-6e6628c4a335"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("efbe3cc2-b445-4d91-9f6a-e262f39595a7"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("f05463e5-dd0e-49ed-b1dd-852d44176bfe"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("f4117770-a1d3-4f30-bcef-0a621772e006"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("f9202031-22af-430d-8d4c-dbd9da840096"));

            migrationBuilder.CreateTable(
                name: "TransportPayments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Amount = table.Column<decimal>(type: "decimal(65,30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportPayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransportPayments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "TransportFees",
                columns: new[] { "Id", "DistrictId", "MaxWeight", "MethodId", "MinWeight", "Value" },
                values: new object[,]
                {
                    { new Guid("0b6706e8-7ff5-4390-b182-ec27b247d03e"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), 1500, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 301, 1.98m },
                    { new Guid("10322e23-052f-44e8-81c4-046d65e133ef"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 1501, 1.95m },
                    { new Guid("1529196b-0a6e-421b-96bc-c82c2b3da98b"), new Guid("b90943d8-f764-42d3-8fca-da1ba2378634"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("15a9a8c2-fbf8-4e16-8309-5aa9c0a0b181"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), 300, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.57m },
                    { new Guid("191c253e-5eef-4c0e-b136-97fc9625c141"), new Guid("b90943d8-f764-42d3-8fca-da1ba2378634"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("29f88964-654b-421d-add5-883de55ff010"), new Guid("dbe61b00-89ef-493c-8930-9d41a402a987"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("2c836e7e-fdd0-447c-939e-9832f8e9d22a"), new Guid("3bf2da8a-0a2c-4a8f-99c9-35742cb7fa2e"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.87m },
                    { new Guid("3000bfdf-ce97-4749-be6b-3dedf7677023"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), 300, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.57m },
                    { new Guid("3275e172-5a98-4870-a52f-ea7adeb101a8"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 1501, 1.80m },
                    { new Guid("3940e739-b63f-4609-a30e-285d71fe66e3"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), 300, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.43m },
                    { new Guid("39b62c5d-0740-4449-a12f-929410ea1edc"), new Guid("72516348-d8e7-4ce3-af4e-f97b77897f89"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("3a26e929-0b63-464a-8b4f-5729de9f8a9c"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), 100, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 71, 2.70m },
                    { new Guid("3f01fbab-24ba-41cf-abe3-62f9b4695e6a"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), 70, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 23, 2.70m },
                    { new Guid("4038e705-8620-4790-9820-b6d8f29ef67f"), new Guid("5abcb711-259a-48dc-9817-2e5b988d690a"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("4187f4f8-6628-46ae-9e32-3f01ab7f37ec"), new Guid("6d332a8f-0bcd-4b81-9c59-6965f4ab40ae"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.00m },
                    { new Guid("449fb9e9-5d9a-4008-9aac-efe58075e988"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), 70, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 23, 2.22m },
                    { new Guid("46f82f6c-323f-4b6b-84ac-2bc4d1ddfdf1"), new Guid("5abcb711-259a-48dc-9817-2e5b988d690a"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("4ae5bbb0-7fa3-4df7-b8c8-31559f51343f"), new Guid("76adc0f7-ac5d-43cd-9983-eae135865030"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("4b621157-5d8d-4f10-9cce-ff9dafb44baf"), new Guid("76adc0f7-ac5d-43cd-9983-eae135865030"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.00m },
                    { new Guid("4e7da82b-e21f-477c-b541-69cbd0346abe"), new Guid("d484cf5d-d07d-4e01-8aa4-c87747fa68fe"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("50e05427-c69f-4bf5-bc62-fab8d79a2fff"), new Guid("80ff3e90-dcb9-4bc3-9590-e3a2c331a0ec"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.00m },
                    { new Guid("50f09f4c-f9c9-4dfb-8e3f-03f3b9515aa3"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 1501, 1.33m },
                    { new Guid("51785365-0b15-424c-bc01-e12ac21a45df"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("54feeda5-0fdc-4514-bc54-725c74f5b82a"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), 100, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 71, 2.22m },
                    { new Guid("56ea86d7-34a0-4830-ad46-2a8ca6869ce6"), new Guid("5f0411d9-fc63-4dd4-a03f-50c26f0829c6"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.97m },
                    { new Guid("57772395-f575-40ef-840f-bb0ba60dc9e5"), new Guid("dbe61b00-89ef-493c-8930-9d41a402a987"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.87m },
                    { new Guid("5804687f-4d4c-47f7-bfe3-5a8c6f466e09"), new Guid("123a8e96-b5f2-4459-a896-da06599036cf"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("5ef7bfb9-9c45-4b67-9532-301a86685c46"), new Guid("5f0411d9-fc63-4dd4-a03f-50c26f0829c6"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("5f7b7b5f-2939-4610-bcf8-88ba02062baf"), new Guid("72516348-d8e7-4ce3-af4e-f97b77897f89"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("61f8de64-56a6-42e4-83e1-64dd844d98d7"), new Guid("76e0d1b5-4fb7-4dc7-bcb1-1fadff9acc92"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("63cc41c7-b9a1-48e3-a5ec-0b90879b8b87"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("72541967-a09c-43e8-8cd3-1e9b01f726c0"), new Guid("72516348-d8e7-4ce3-af4e-f97b77897f89"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.97m },
                    { new Guid("7b757f39-3503-4913-bae7-3cc42f66f797"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), 70, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 23, 2.84m },
                    { new Guid("7fd4b01e-d016-4f1f-a983-d1ba7be15103"), new Guid("5f0411d9-fc63-4dd4-a03f-50c26f0829c6"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("82b1d78d-317c-4462-912c-1c38747ba012"), new Guid("80ff3e90-dcb9-4bc3-9590-e3a2c331a0ec"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("835b908e-92bc-4b0a-a94f-d53d62879985"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), 1500, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 301, 1.83m },
                    { new Guid("83d2e5b8-e838-44d0-9a0f-454821b475f6"), new Guid("123a8e96-b5f2-4459-a896-da06599036cf"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("8493e6a9-fa8a-4ecd-9bcf-870169c0e540"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 1501, 1.47m },
                    { new Guid("8be771e9-c04b-4554-b975-bf36539bf8ec"), new Guid("3bf2da8a-0a2c-4a8f-99c9-35742cb7fa2e"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("8d596924-2282-4548-8841-14df28aa538a"), new Guid("ccd6ecfe-c907-4777-96ad-40ab41b7ac06"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.87m },
                    { new Guid("8dc1d6d3-d0fc-4184-a7ea-b4d23f7278e8"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), 100, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 71, 2.08m },
                    { new Guid("8e616f6a-286a-457f-8a54-37164119e0a2"), new Guid("d484cf5d-d07d-4e01-8aa4-c87747fa68fe"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.40m },
                    { new Guid("8f7dcd9a-6e54-4fd6-9ef6-7688763a8b8f"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), 70, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 23, 2.08m },
                    { new Guid("95a7dd82-5129-4563-b3e3-c70eaa1d9bf6"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), 100, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 71, 2.41m },
                    { new Guid("99950430-ddd5-4044-9a97-20346fcb8569"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 1501, 1.82m },
                    { new Guid("99c5d65d-e0e4-4492-b4e6-2e5b2cc6b247"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("9b07612e-b16f-4356-a37e-bb299be5c855"), new Guid("6d332a8f-0bcd-4b81-9c59-6965f4ab40ae"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("9c1e9f02-2b2d-47f2-a73e-70630abb98a0"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), 100, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 71, 2.55m },
                    { new Guid("9c8663fe-0790-4664-aae0-be0a8321ba12"), new Guid("2b26b58b-050c-46a7-8567-2325c31fa6fb"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("a39478c9-92c8-429d-8167-368fc2ac6cda"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), 1500, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 301, 1.69m },
                    { new Guid("a7cee56c-23f7-4423-a781-eb830992c220"), new Guid("98ead996-828c-4a6f-99c2-914b7c8110ef"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("a950d9ce-c547-4cf3-a4b3-6167014d4ada"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), 70, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 23, 2.55m },
                    { new Guid("ac1a3f0d-a563-4104-8098-c5cbcee5f48e"), new Guid("b90943d8-f764-42d3-8fca-da1ba2378634"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("ac66954b-8749-4eb5-b473-67374baafc26"), new Guid("6d63584c-813f-48de-9b19-df143f83d2f7"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("ad42ead0-b4bd-480a-baf5-0329c9b5cf28"), new Guid("ccd6ecfe-c907-4777-96ad-40ab41b7ac06"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("adabd934-95cc-4606-95f3-74ec6a3037e1"), new Guid("d484cf5d-d07d-4e01-8aa4-c87747fa68fe"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.92m },
                    { new Guid("ae03140d-84d4-4dbd-a450-8bdaec438e46"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), 1500, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 301, 1.36m },
                    { new Guid("b0751ee0-8204-43f7-807e-a0f00db9d498"), new Guid("76e0d1b5-4fb7-4dc7-bcb1-1fadff9acc92"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.97m },
                    { new Guid("b262f23e-f820-4cf6-9c4c-cf5690e8720e"), new Guid("5abcb711-259a-48dc-9817-2e5b988d690a"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("bc079640-3a9a-4820-8e71-3c0acec7ac65"), new Guid("6d332a8f-0bcd-4b81-9c59-6965f4ab40ae"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("cc304083-d65d-44c2-9b6f-af5d16a1b9c8"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), 1500, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 301, 1.50m },
                    { new Guid("cfae4637-6006-4732-82e9-b14d95b83306"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), 100, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 71, 1.93m },
                    { new Guid("d81d00e2-06ec-4899-b172-72038cd37228"), new Guid("2b26b58b-050c-46a7-8567-2325c31fa6fb"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.87m },
                    { new Guid("dc4ad423-a4b6-4dd0-b714-7010cfeaea7c"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 1501, 1.66m },
                    { new Guid("de082b14-2346-4fce-b78c-cae344438893"), new Guid("76e0d1b5-4fb7-4dc7-bcb1-1fadff9acc92"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("df950df4-db2a-4503-8398-d1878c2bc33c"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), 70, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 23, 2.37m },
                    { new Guid("e21808f2-b8ad-417b-a8a3-019175fed510"), new Guid("6d63584c-813f-48de-9b19-df143f83d2f7"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("e6eb4339-5393-4fe1-8c68-ef5715164afd"), new Guid("98ead996-828c-4a6f-99c2-914b7c8110ef"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("e720cdd1-3649-417d-bb65-35a40edcb3ee"), new Guid("ccd6ecfe-c907-4777-96ad-40ab41b7ac06"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.46m },
                    { new Guid("ebe541c9-cfa2-4f54-91a9-959404b8a93b"), new Guid("98ead996-828c-4a6f-99c2-914b7c8110ef"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("eccfd794-5e64-4918-a617-aa841c2d5286"), new Guid("123a8e96-b5f2-4459-a896-da06599036cf"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("ef3be54c-80c1-4d2d-a8e5-c04743ed7b2f"), new Guid("2b26b58b-050c-46a7-8567-2325c31fa6fb"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.43m },
                    { new Guid("f1c4c532-0a83-4939-b299-9aeceafdd84a"), new Guid("6d63584c-813f-48de-9b19-df143f83d2f7"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("f519c316-77d7-4167-8235-320b4cf92319"), new Guid("76adc0f7-ac5d-43cd-9983-eae135865030"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("f74d1be7-fb25-4934-a158-5042b0e13538"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), 300, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 2.06m },
                    { new Guid("faea4165-53ba-47e6-9dc7-84e802573026"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), 300, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.76m },
                    { new Guid("fc1c9878-59db-4115-b0a5-3937955a3247"), new Guid("dbe61b00-89ef-493c-8930-9d41a402a987"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.46m },
                    { new Guid("fd5aa624-b492-4928-b020-d7933d552a61"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), 1500, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 301, 1.82m },
                    { new Guid("ff3eb7f3-770a-44bc-985c-081eb6d566e4"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), 300, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.90m },
                    { new Guid("ffd3d7c6-a2e2-4fea-98e3-515720dbfc8e"), new Guid("3bf2da8a-0a2c-4a8f-99c9-35742cb7fa2e"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.46m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TransportPayments_UserId",
                table: "TransportPayments",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TransportPayments");

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("0b6706e8-7ff5-4390-b182-ec27b247d03e"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("10322e23-052f-44e8-81c4-046d65e133ef"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("1529196b-0a6e-421b-96bc-c82c2b3da98b"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("15a9a8c2-fbf8-4e16-8309-5aa9c0a0b181"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("191c253e-5eef-4c0e-b136-97fc9625c141"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("29f88964-654b-421d-add5-883de55ff010"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("2c836e7e-fdd0-447c-939e-9832f8e9d22a"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("3000bfdf-ce97-4749-be6b-3dedf7677023"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("3275e172-5a98-4870-a52f-ea7adeb101a8"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("3940e739-b63f-4609-a30e-285d71fe66e3"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("39b62c5d-0740-4449-a12f-929410ea1edc"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("3a26e929-0b63-464a-8b4f-5729de9f8a9c"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("3f01fbab-24ba-41cf-abe3-62f9b4695e6a"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("4038e705-8620-4790-9820-b6d8f29ef67f"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("4187f4f8-6628-46ae-9e32-3f01ab7f37ec"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("449fb9e9-5d9a-4008-9aac-efe58075e988"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("46f82f6c-323f-4b6b-84ac-2bc4d1ddfdf1"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("4ae5bbb0-7fa3-4df7-b8c8-31559f51343f"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("4b621157-5d8d-4f10-9cce-ff9dafb44baf"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("4e7da82b-e21f-477c-b541-69cbd0346abe"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("50e05427-c69f-4bf5-bc62-fab8d79a2fff"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("50f09f4c-f9c9-4dfb-8e3f-03f3b9515aa3"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("51785365-0b15-424c-bc01-e12ac21a45df"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("54feeda5-0fdc-4514-bc54-725c74f5b82a"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("56ea86d7-34a0-4830-ad46-2a8ca6869ce6"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("57772395-f575-40ef-840f-bb0ba60dc9e5"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("5804687f-4d4c-47f7-bfe3-5a8c6f466e09"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("5ef7bfb9-9c45-4b67-9532-301a86685c46"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("5f7b7b5f-2939-4610-bcf8-88ba02062baf"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("61f8de64-56a6-42e4-83e1-64dd844d98d7"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("63cc41c7-b9a1-48e3-a5ec-0b90879b8b87"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("72541967-a09c-43e8-8cd3-1e9b01f726c0"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("7b757f39-3503-4913-bae7-3cc42f66f797"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("7fd4b01e-d016-4f1f-a983-d1ba7be15103"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("82b1d78d-317c-4462-912c-1c38747ba012"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("835b908e-92bc-4b0a-a94f-d53d62879985"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("83d2e5b8-e838-44d0-9a0f-454821b475f6"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("8493e6a9-fa8a-4ecd-9bcf-870169c0e540"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("8be771e9-c04b-4554-b975-bf36539bf8ec"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("8d596924-2282-4548-8841-14df28aa538a"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("8dc1d6d3-d0fc-4184-a7ea-b4d23f7278e8"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("8e616f6a-286a-457f-8a54-37164119e0a2"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("8f7dcd9a-6e54-4fd6-9ef6-7688763a8b8f"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("95a7dd82-5129-4563-b3e3-c70eaa1d9bf6"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("99950430-ddd5-4044-9a97-20346fcb8569"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("99c5d65d-e0e4-4492-b4e6-2e5b2cc6b247"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("9b07612e-b16f-4356-a37e-bb299be5c855"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("9c1e9f02-2b2d-47f2-a73e-70630abb98a0"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("9c8663fe-0790-4664-aae0-be0a8321ba12"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("a39478c9-92c8-429d-8167-368fc2ac6cda"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("a7cee56c-23f7-4423-a781-eb830992c220"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("a950d9ce-c547-4cf3-a4b3-6167014d4ada"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("ac1a3f0d-a563-4104-8098-c5cbcee5f48e"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("ac66954b-8749-4eb5-b473-67374baafc26"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("ad42ead0-b4bd-480a-baf5-0329c9b5cf28"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("adabd934-95cc-4606-95f3-74ec6a3037e1"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("ae03140d-84d4-4dbd-a450-8bdaec438e46"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("b0751ee0-8204-43f7-807e-a0f00db9d498"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("b262f23e-f820-4cf6-9c4c-cf5690e8720e"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("bc079640-3a9a-4820-8e71-3c0acec7ac65"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("cc304083-d65d-44c2-9b6f-af5d16a1b9c8"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("cfae4637-6006-4732-82e9-b14d95b83306"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("d81d00e2-06ec-4899-b172-72038cd37228"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("dc4ad423-a4b6-4dd0-b714-7010cfeaea7c"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("de082b14-2346-4fce-b78c-cae344438893"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("df950df4-db2a-4503-8398-d1878c2bc33c"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("e21808f2-b8ad-417b-a8a3-019175fed510"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("e6eb4339-5393-4fe1-8c68-ef5715164afd"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("e720cdd1-3649-417d-bb65-35a40edcb3ee"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("ebe541c9-cfa2-4f54-91a9-959404b8a93b"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("eccfd794-5e64-4918-a617-aa841c2d5286"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("ef3be54c-80c1-4d2d-a8e5-c04743ed7b2f"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("f1c4c532-0a83-4939-b299-9aeceafdd84a"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("f519c316-77d7-4167-8235-320b4cf92319"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("f74d1be7-fb25-4934-a158-5042b0e13538"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("faea4165-53ba-47e6-9dc7-84e802573026"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("fc1c9878-59db-4115-b0a5-3937955a3247"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("fd5aa624-b492-4928-b020-d7933d552a61"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("ff3eb7f3-770a-44bc-985c-081eb6d566e4"));

            migrationBuilder.DeleteData(
                table: "TransportFees",
                keyColumn: "Id",
                keyValue: new Guid("ffd3d7c6-a2e2-4fea-98e3-515720dbfc8e"));

            migrationBuilder.InsertData(
                table: "TransportFees",
                columns: new[] { "Id", "DistrictId", "MaxWeight", "MethodId", "MinWeight", "Value" },
                values: new object[,]
                {
                    { new Guid("0ade6b8a-28eb-493d-bff4-47c8adadc4ff"), new Guid("d484cf5d-d07d-4e01-8aa4-c87747fa68fe"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.92m },
                    { new Guid("0b899656-efe4-44f1-a4e9-455d9feaa0c7"), new Guid("76adc0f7-ac5d-43cd-9983-eae135865030"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("113a4a49-2de6-42cb-9fea-037db7d40371"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 1501, 1.33m },
                    { new Guid("128a5046-d455-44ba-854d-0b50140a389d"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 1501, 1.82m },
                    { new Guid("14df8f25-696e-4c73-a768-6464daece2a3"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), 300, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.43m },
                    { new Guid("1b1186d9-c666-4bd5-a447-f73de4164e13"), new Guid("3bf2da8a-0a2c-4a8f-99c9-35742cb7fa2e"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("1c186316-dbb3-404a-b9d1-ed67fd849bcd"), new Guid("123a8e96-b5f2-4459-a896-da06599036cf"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("1c9024ca-2728-4bbf-a983-67553b68e010"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("2011b907-1435-41bc-b3dd-e6d30cb05ed7"), new Guid("72516348-d8e7-4ce3-af4e-f97b77897f89"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("204b992f-b348-4c42-90d2-8a69b8077cc5"), new Guid("6d63584c-813f-48de-9b19-df143f83d2f7"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("2b97a3bf-0bbd-43bc-8418-c176666a0c0e"), new Guid("6d332a8f-0bcd-4b81-9c59-6965f4ab40ae"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("2d06c458-4d8e-4c70-86f4-633316b3b0ca"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), 300, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.90m },
                    { new Guid("2d7345c6-7222-4ee2-ae79-88ef280ec07b"), new Guid("dbe61b00-89ef-493c-8930-9d41a402a987"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.87m },
                    { new Guid("2d875e84-f0c6-489f-9ccd-bc3755c22523"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 1501, 1.66m },
                    { new Guid("320a798f-8d3c-4bbf-a33f-7104f74663e2"), new Guid("76e0d1b5-4fb7-4dc7-bcb1-1fadff9acc92"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("32e94740-601d-4bfb-9046-6cbaf484c9e9"), new Guid("76adc0f7-ac5d-43cd-9983-eae135865030"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.00m },
                    { new Guid("3731de7f-68a0-490c-84e4-11ca75f6436a"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), 100, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 71, 2.22m },
                    { new Guid("3bc60ef8-8eb7-4850-ab14-240ebf130419"), new Guid("6d332a8f-0bcd-4b81-9c59-6965f4ab40ae"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.00m },
                    { new Guid("3ce5a985-d9f7-4013-a86d-ed70254efb85"), new Guid("2b26b58b-050c-46a7-8567-2325c31fa6fb"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("3d8c5990-d66e-4421-8a06-f2c741e128db"), new Guid("72516348-d8e7-4ce3-af4e-f97b77897f89"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("3da2229b-aa21-461d-a1bc-1d1728f1428f"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), 70, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 23, 2.37m },
                    { new Guid("42d696ce-f746-4c89-b8ab-ae421684eb4f"), new Guid("76e0d1b5-4fb7-4dc7-bcb1-1fadff9acc92"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("46783a14-fcdb-4966-bab5-bbf899c87d6e"), new Guid("72516348-d8e7-4ce3-af4e-f97b77897f89"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.97m },
                    { new Guid("4881251e-36bb-4719-8396-c632f4c8e9bb"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 1501, 1.80m },
                    { new Guid("4b82f3ad-e1ae-4aa4-b46c-9c2bc68e171d"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 1501, 1.47m },
                    { new Guid("51291fc5-4907-4c40-af41-7b58474a9f29"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), 1500, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 301, 1.36m },
                    { new Guid("514484eb-b399-4e6a-a35b-ca8ea3002cd6"), new Guid("5f0411d9-fc63-4dd4-a03f-50c26f0829c6"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("51c77dab-04bf-4158-b65b-7a746588f84e"), new Guid("76adc0f7-ac5d-43cd-9983-eae135865030"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("5398b742-2ead-47c8-9cbb-70299c88eeb1"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), 1500, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 301, 1.82m },
                    { new Guid("591c0e47-ec7e-4c97-8dc5-e7fa9e727658"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), 70, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 23, 2.22m },
                    { new Guid("5cb7b65c-a8b7-4dcc-99cb-ee3e13b48f9c"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), 1500, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 301, 1.69m },
                    { new Guid("5df7c554-6701-4642-ade6-cf1502498a7b"), new Guid("98ead996-828c-4a6f-99c2-914b7c8110ef"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("5ee2850f-b2be-4f53-b756-cca7895abd50"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), 70, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 23, 2.70m },
                    { new Guid("5f1b8ce4-aa72-4050-85e0-acf846c64734"), new Guid("2b26b58b-050c-46a7-8567-2325c31fa6fb"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.43m },
                    { new Guid("6063e5dc-2ee5-4b52-84e6-65e42a2cba06"), new Guid("5f0411d9-fc63-4dd4-a03f-50c26f0829c6"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.97m },
                    { new Guid("60a877df-e94f-4989-8d32-033cb7042f9d"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), 100, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 71, 1.93m },
                    { new Guid("63db9e69-5055-461f-a917-1913dd913aa0"), new Guid("6d63584c-813f-48de-9b19-df143f83d2f7"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("688650f6-2980-460d-99dc-a54d29157ab5"), new Guid("5abcb711-259a-48dc-9817-2e5b988d690a"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("69fc8126-1213-4d89-84b4-5a2ad309179b"), new Guid("ccd6ecfe-c907-4777-96ad-40ab41b7ac06"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.46m },
                    { new Guid("6a06cfbf-b184-4c83-9681-ec745e23446f"), new Guid("dbe61b00-89ef-493c-8930-9d41a402a987"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.46m },
                    { new Guid("745aa2d6-e023-467c-9f45-90a28826d107"), new Guid("d484cf5d-d07d-4e01-8aa4-c87747fa68fe"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.40m },
                    { new Guid("7dcd29d4-7095-4e6a-8f7e-f2d1c9373e37"), new Guid("5abcb711-259a-48dc-9817-2e5b988d690a"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("8483d76c-afe3-458a-9921-5ac4b5835634"), new Guid("123a8e96-b5f2-4459-a896-da06599036cf"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("853b4a9e-d808-4f00-a502-24c6df2c774c"), new Guid("98ead996-828c-4a6f-99c2-914b7c8110ef"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("88c27a56-5f6c-432f-b0fb-9836f9fc9f90"), new Guid("6d332a8f-0bcd-4b81-9c59-6965f4ab40ae"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("88dfbf30-fed5-49a9-942c-99eaf6891c9e"), new Guid("2b26b58b-050c-46a7-8567-2325c31fa6fb"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.87m },
                    { new Guid("8b37cbed-056a-4763-9e9b-079af931730f"), new Guid("b90943d8-f764-42d3-8fca-da1ba2378634"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("8d911286-971b-4542-b35b-06bc804a23bc"), new Guid("80ff3e90-dcb9-4bc3-9590-e3a2c331a0ec"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("8ee084a0-3367-4583-8b67-e016303a14a3"), new Guid("dbe61b00-89ef-493c-8930-9d41a402a987"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("9228df16-0ef0-40ac-b77e-83093459edf8"), new Guid("98ead996-828c-4a6f-99c2-914b7c8110ef"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("9fa343b9-6cf7-4364-ab78-8ea53bcdc9ac"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), 100, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 71, 2.55m },
                    { new Guid("a0e8dd45-c473-48a5-a770-1dcfbe9264a7"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), 300, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.57m },
                    { new Guid("a475d5e1-c793-4050-bba8-89f733da323a"), new Guid("123a8e96-b5f2-4459-a896-da06599036cf"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("ac32ad44-36c9-46bc-925d-8d9c24f61a38"), new Guid("ccd6ecfe-c907-4777-96ad-40ab41b7ac06"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("ad66fa7f-d5e7-4d90-9b99-0f4e2fe076e7"), new Guid("3bf2da8a-0a2c-4a8f-99c9-35742cb7fa2e"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.46m },
                    { new Guid("adf40af3-4702-4793-815f-6985d651f647"), new Guid("ccd6ecfe-c907-4777-96ad-40ab41b7ac06"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.87m },
                    { new Guid("aef6a5e2-f454-4dc7-9384-dfc9b45970b8"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("b4566d68-4a5f-4f4b-9700-4e1dbc089741"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), 100, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 71, 2.70m },
                    { new Guid("b5443eff-8b80-4212-834f-d7403e609eda"), new Guid("6d63584c-813f-48de-9b19-df143f83d2f7"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("b6912136-42a5-4923-96c1-de209e82dd6c"), new Guid("b90943d8-f764-42d3-8fca-da1ba2378634"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("b70e7fe3-539d-48b5-b79a-0be8a00245ca"), new Guid("76e0d1b5-4fb7-4dc7-bcb1-1fadff9acc92"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.97m },
                    { new Guid("bd1f9f20-43f5-4ccb-a624-e08e2c1a6698"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), 300, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.76m },
                    { new Guid("be44e3a4-aead-4970-99fb-6c89a938de4b"), new Guid("5abcb711-259a-48dc-9817-2e5b988d690a"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("c2d1b315-71d0-4cc8-996b-424d502d14a1"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), 100, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 71, 2.41m },
                    { new Guid("c76ae9b8-4a1e-4dae-9333-964f61640b3b"), new Guid("80ff3e90-dcb9-4bc3-9590-e3a2c331a0ec"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.00m },
                    { new Guid("c783d5ea-b4df-4e88-abba-60ff29f7a7c7"), new Guid("5f0411d9-fc63-4dd4-a03f-50c26f0829c6"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("cbcf2484-ab83-4a7b-8c19-9d4d0e776000"), new Guid("d484cf5d-d07d-4e01-8aa4-c87747fa68fe"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("cf10f476-73d1-4197-b713-a0901cd46389"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), 1500, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 301, 1.50m },
                    { new Guid("d08accf9-d1cd-4cf0-a852-366f96dce894"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), 100, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 71, 2.08m },
                    { new Guid("d1101f3b-31f5-4fc8-a48a-585ec29a6eed"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 1501, 1.95m },
                    { new Guid("d5670043-8e01-4cf1-9bab-5dea4dda448d"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), 70, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 23, 2.84m },
                    { new Guid("d82a0f0c-8980-42f2-a01a-af8d83d00dca"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), 300, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.57m },
                    { new Guid("e4924b8d-a2e6-4465-ad6f-36860019e137"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), 1500, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 301, 1.83m },
                    { new Guid("eb4128a9-123f-46a2-b305-f685dc5dacf0"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), 70, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 23, 2.55m },
                    { new Guid("ec681263-6c21-461f-a0c6-5de456c60a0a"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), 70, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 23, 2.08m },
                    { new Guid("edb0ca90-3d28-4d38-b64b-6e6628c4a335"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("efbe3cc2-b445-4d91-9f6a-e262f39595a7"), new Guid("3bf2da8a-0a2c-4a8f-99c9-35742cb7fa2e"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.87m },
                    { new Guid("f05463e5-dd0e-49ed-b1dd-852d44176bfe"), new Guid("b90943d8-f764-42d3-8fca-da1ba2378634"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("f4117770-a1d3-4f30-bcef-0a621772e006"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), 1500, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 301, 1.98m },
                    { new Guid("f9202031-22af-430d-8d4c-dbd9da840096"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), 300, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 2.06m }
                });
        }
    }
}
