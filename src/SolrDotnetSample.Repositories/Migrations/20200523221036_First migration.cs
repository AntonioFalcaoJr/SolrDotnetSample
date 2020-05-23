using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SolrDotnetSample.Repositories.Migrations
{
    public partial class Firstmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    ExpiryDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsSold = table.Column<bool>(nullable: false),
                    PostDate = table.Column<DateTime>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Title = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("6125f361-bb43-43fe-a322-0ff335db9015"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 842, DateTimeKind.Local).AddTicks(9172), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(5687), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("57fe93e7-7806-456a-9c04-96cc1f7caffc"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9455), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9456), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("43990642-7eac-4823-86e1-0b8cd902ddc9"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9446), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9448), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("fd47bba9-2e83-47b3-a29d-99cef2f7895a"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9439), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9440), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("bbeac4e1-69a1-49fc-a85f-55f1233ed187"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9432), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9433), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("399a7bba-234f-49f2-b95d-183e1a200016"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9424), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9426), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("d594c096-46a3-4f81-8f1a-f4c4b783886f"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9417), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9418), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("8c65bda3-2c4f-4b90-92aa-2244ece0784b"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9409), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9410), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("7ab374e2-ba3c-410c-b8f5-4cddaa71e674"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9401), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9403), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("2fe35265-13c6-4c16-b615-9f832794b2a8"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9394), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9395), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("2da5cfcc-e487-4a07-8fda-1432c476d7a2"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9386), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9387), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("4de2a40f-c93b-41a3-9093-f21036d6ce45"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9378), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9380), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("9b899fd3-eedd-4a3c-8b11-dbd932aa8ff8"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9371), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9372), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("6153157e-6106-4f3f-867e-6e5d3b522668"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9364), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9365), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("5cfe569d-4cca-4a9e-b74d-0dba0d8fea2d"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9356), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9357), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("05a0cf28-0021-4df4-8bee-a69bea67456c"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9348), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9350), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("7d95b70d-d01c-4e9c-9a83-e625a7044677"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9341), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9342), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("e989b1dc-8da5-46a2-aa6b-ad44e4420556"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9333), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9335), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("5bcfaf40-e35d-4d75-9d37-da4d40f159e9"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9325), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9327), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("cb157274-6ea2-4a24-acd1-cbce6c4089ae"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9318), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9319), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("bcdf6e3e-4d1e-4f77-8a33-2e68e406f9ad"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9311), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9312), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("154e34d7-8e0f-4925-bc47-992f8d00ec49"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9303), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9305), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("8207eba4-c7b1-4e32-a767-680cdda7c71a"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9296), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9297), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("0612f97b-8f13-4831-b3b1-a5a0c428ca53"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9288), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9290), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("0997b1c9-b798-496f-a6b7-b18976e2bdc2"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9281), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9282), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("0e985185-5559-4792-b0d6-8385ad238249"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9273), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9274), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("19d2534b-5c62-40fc-b817-8d3af1d3b175"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9265), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9267), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("2189add0-03f9-49d3-89c7-4f546e9f2072"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9258), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9259), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("160090e9-1431-45cf-8604-94c83f3f6eaf"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9462), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9463), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("35b383e8-016a-4273-95f4-81c94095ae34"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9251), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9252), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("c30b81fe-9a7f-44e7-965c-97f291e2627d"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9470), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9471), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("99ff37c4-7f8d-436f-b2a0-15a7563bf5fc"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9485), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9486), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("e42fc687-6018-4046-9c5c-7568b88dc76d"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9689), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9690), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("ba8c02ec-f591-4d8a-8e76-435615cabf9c"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9681), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9682), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("9d64a281-ae36-4c34-b222-200699b35b39"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9674), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9675), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("3fe24bfa-c248-4f6c-ad94-2a42c984bb4e"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9666), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9668), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("c3e6dc01-2cba-45c6-9dff-f0cd82e4d44f"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9659), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9660), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("91574444-bd8b-4874-b3f4-1be90c5c4352"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9651), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9652), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("461ab834-651e-4f7d-bb0f-a4c781e172b4"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9643), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9645), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("6190f078-4727-4cf0-ad5e-2696cdcfa2f9"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9636), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9637), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("856758fc-14fd-4aa7-8e32-39b7585d2470"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9628), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9629), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("84cc9559-a2d7-4928-8a13-2a7613132007"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9620), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9622), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("ebe7f39f-c676-4df4-819f-169b978b7cc8"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9613), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9614), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("af8d35d4-4ac2-4dd9-a569-47820cfa8262"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9606), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9607), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("da11c4ea-d0fa-4887-a31d-40d4b9f08d8c"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9598), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9599), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("5a8bf8c0-11bc-4844-bfbc-9bd120dc40b3"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9591), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9592), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("cb4fb9cb-4811-4e59-9695-d5f1e060b221"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9583), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9584), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("ba4c11ea-e878-4108-863b-09a2158b5581"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9575), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9577), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("973e9a39-2f19-42a5-adfc-f0bf82b3629c"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9567), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9569), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("07ea66c6-e31a-4d91-8570-9e26d6efb35b"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9560), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9561), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("5b24b22c-d72e-4a85-a21f-5c2c1c0fd5fa"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9552), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9554), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("e9965476-60d3-4e44-9dc5-8a354b2ca500"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9545), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9546), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("bd6cbe51-8f22-47b3-bd4a-6cfc9db50614"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9537), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9539), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("2c675281-ac54-4881-84ab-052a017ada46"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9530), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9531), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("614267e0-49d1-4a2d-b18d-5c9604fa0918"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9522), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9524), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("48a75d0c-3313-4f58-b6ab-9d21cacebd76"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9515), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9516), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("9c9d71bc-0b56-4339-9fcc-7d90c3b32e1e"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9507), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9508), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("803b5847-7d8b-41d7-bc15-dd68f5622c8a"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9499), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9501), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("e7648e2d-970f-4ae9-b344-5f1d803e7166"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9492), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9493), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("1308ec1f-c22b-437e-bb91-a029b4f1ca6d"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9477), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9478), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("170eb7f7-23d6-4a6b-b2cb-4cce5ca1fe6b"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9243), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9245), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("d13e0c74-a1ff-42d6-85bc-ec9c944b27ae"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9236), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9237), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("5ed43449-19b7-4e45-8084-5731379f99c8"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9228), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9229), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("1fa92f4d-ef8f-410f-af11-1281d22d8593"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8958), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8959), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("170758a0-f506-408a-a4fa-fe20e88d18a5"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8950), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8952), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("b9af730e-4f00-4417-8dba-71845c169b1c"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8943), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8944), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("32b066b0-0434-439e-b57f-329105d77c45"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8936), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8937), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("404ad755-5464-43c3-a7d7-c5ae3c3d8e2b"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8928), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8930), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("a0bca2e2-31f7-4997-a252-0cb68dfa4045"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8921), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8922), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("8d815a7b-4622-45f4-acb9-b70d6517634f"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8913), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8915), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("d1b9857a-8585-4747-b2a2-1c339b81389d"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8906), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8907), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("b2f8b714-1d79-4a50-8061-03062fef7fc6"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8898), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8899), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("cd5c7b69-d9d8-46bc-83e2-262d3664f3bf"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8891), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8892), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("052535a3-eaab-4ea2-a07d-e53d37771538"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8883), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8885), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("290371f7-4b74-4188-b12d-3f411a03b842"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8876), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8877), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("186e7b2a-4748-498e-94ab-07a1da6c2c0c"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8869), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8870), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("b2616aa7-4259-4375-9832-cad0bbf346b5"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8861), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8862), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("d64ae4c8-3002-453b-9c88-ce09dddac9c1"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8853), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8855), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("40b085cf-e244-4ca0-bc88-d6b550661319"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8846), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8847), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("b6725a98-f53e-4d23-9772-c153ed79cc11"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8838), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8839), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("fdedc7c7-79a8-4694-a23c-bc0ceb18eabe"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8831), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8832), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("abc7306b-4e9f-4069-bc2a-4068a42db16a"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8823), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8825), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("cb6ac2e5-bae9-42c7-a2f6-b44808284f66"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8816), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8817), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("162ff947-99a9-4041-9c0e-ea189b242a2b"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8809), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8810), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("115b1772-371b-4c30-89ec-6eb19d691315"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8801), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8802), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("52af6c02-3a3d-4fc7-810e-564175d1b49e"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8790), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8792), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("8d3e56fd-8c06-41bb-b88f-8797c6b149a3"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8783), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8784), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("99f6370e-9d77-419b-a4ab-b83b96a073ef"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8775), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8776), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("1ed6bdea-beb3-4a5a-bf55-f21513c442e0"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8767), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8769), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("331434b7-c0f7-42d0-87ae-53b68277f02c"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8760), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8761), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("97ae3a2d-c0a1-4bd5-8213-f1d6af5bc778"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8986), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8987), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("e3edf9a5-b348-412c-83b0-473297aed043"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8994), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8995), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("7cd1fea7-c0c7-43c5-bea4-7478cdb238c2"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9001), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9002), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("0373ba36-0c9a-4ded-ad37-959dfa9ce712"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9009), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9010), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("e02c88bb-e833-44d1-96d8-9ebb6d8b029b"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9220), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9222), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("f51f8fa2-388f-4c81-b036-4073c3d088c4"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9213), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9214), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("f81b873d-cf84-4264-9d1d-76a665595f43"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9205), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9206), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("71882720-674a-4a80-a152-e1ca4e9b7690"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9198), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9199), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("dd4044cd-3dba-4202-8059-c974a8983871"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9190), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9191), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("d5eb1b29-fb76-4668-b36f-19f10df638aa"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9183), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9184), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("cf9ef6e2-5bfd-47ca-bf15-e8850b1676e2"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9175), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9176), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("6b9f098e-88bb-4880-9738-61c4f011839f"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9168), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9169), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("58c713eb-33c4-4360-a5d3-574e5c36e7bd"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9160), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9161), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("e23fdfcb-8334-4d03-b089-95ebfef84810"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9152), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9154), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("8b459ea2-5c6d-4015-a2d6-45d08d2063b5"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9145), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9146), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("25a89e19-4ac4-4762-86d5-3c427a96ff3d"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9137), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9139), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("0a42f6bf-26d6-475d-bdc8-7c75771877b3"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9130), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9131), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("0d85c254-15b1-48c9-b6e1-5186e1c7bd62"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9696), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9698), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("77dac323-3323-4513-af9c-3569828f1a6c"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9123), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9124), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("97bad127-9cb7-4d3d-be9d-5211063a079a"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9108), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9109), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("ff4bcd0d-a44f-4549-b945-21cf23084e1e"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9100), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9101), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("2b6dbfb2-4480-4c45-8024-c36835d76f15"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9092), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9094), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("18342c20-6ae0-4655-8b92-50cbee7ad959"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9085), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9086), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("a888ecad-630b-4bf4-a030-f3ac17b7135c"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9077), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9078), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("d4a68a38-dc48-4230-a28d-311581579332"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9070), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9071), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("a76c0ec8-6f1f-4d9d-9510-a0eb8a2e19e9"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9062), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9064), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("95c9d8c4-a461-4f08-a2b9-5fc592f54d98"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9054), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9056), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("f3fc57cd-f60e-471d-91b3-dca93056a689"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9047), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9048), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("262cefbe-4e9a-4d1b-9657-1caf1e9c0f28"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9039), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9041), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("b6411149-894e-4a22-93e2-7a0478791bae"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9032), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9033), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("9ae3f281-3355-4b3d-bd40-1c244d42a3cd"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9024), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9025), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("a9be6f00-42e7-4d07-8748-e289d5b4e839"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9016), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9018), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("ae34fc92-911b-41e9-9c5c-c72ccf2527c0"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9115), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9116), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("d3944628-74b1-4ddd-840c-70a7dc56cd73"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8753), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8754), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("a0c156aa-37cc-4e12-bea9-0797033cbf97"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9704), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9706), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("fd3c25ed-0929-4a67-b8d6-87f00a56dd51"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9719), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9721), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("35d23520-da94-4878-9a2e-508cd8a68d5c"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(418), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(420), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("b9bf20bf-fe86-4674-aab9-1479ee1f788d"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(411), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(412), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("d45e314d-b6cb-4a4f-9a27-a4a72ce6049f"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(404), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(405), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("b63f1107-f1df-4ba0-8be6-e2c0bf8d663f"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(397), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(398), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("3e24e159-2ce6-403a-bcae-7b5433d6f4cf"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(389), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(390), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("624f978e-2af4-4ddb-a479-7b52947ec84b"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(381), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(383), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("8fc36d50-d2af-48e4-83cb-49df22eb0615"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(374), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(375), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("c5d1f703-d7c4-425e-8fb3-e36995bf51a9"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(366), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(367), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("1be20cf3-cb7e-4e39-9d03-0432aabc5b20"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(358), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(360), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("7f9b8ccb-d0e1-49c9-b4b7-41ca3ac2b62a"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(351), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(352), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("82ee935c-6a3b-4bfa-b602-b45341128de0"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(343), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(345), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("df32ca53-7cf5-47c6-bcb8-58f9807204cc"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(336), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(337), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("e33f1a07-312a-494e-8d94-18bcf83bf920"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(329), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(330), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("d35c7c94-9034-4916-9f6b-0e2fe368633e"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(321), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(322), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("332899c7-470c-4927-ace1-74ea95ed9122"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(313), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(315), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("6d7f2cb1-f140-477d-a5f5-fecee88c1f62"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(306), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(307), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("f8aa0050-a82b-449a-bab9-61fa67fead7e"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(298), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(299), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("bec1cdbe-d75e-484d-bb0f-ddf31035ff48"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(290), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(292), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("6ffda162-5b2d-4e89-8a56-447e83b842e5"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(283), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(284), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("b0728f00-e16b-4e58-81e8-490081e9cbb2"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(276), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(277), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("90085fc9-910f-41ae-910e-312eaa421034"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(268), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(270), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("4c5bc205-c5b9-4c3b-b302-cc6ac7ce62fa"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(261), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(262), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("0d220f68-4cc5-4cca-be19-42a3c64b1851"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(253), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(254), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("67510c67-7313-4812-b5f8-55e6b8e085f0"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(245), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(247), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("1af0bb83-b07c-4add-865a-ddf3f7d1e55c"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(238), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(239), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("fe62d204-729a-4bb8-916c-2d0e27553c19"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(230), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(231), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("f813cf8e-ffaf-40b0-9fbb-f63de0dc9831"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(223), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(224), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("db87d300-b917-4c71-8a53-0b715a748e2f"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(427), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(428), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("0b10714e-39b1-4af1-aff9-79f3913c56d0"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(215), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(217), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("d788c195-ce66-451b-bb41-aca68ad701ea"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(434), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(435), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("55fb6dd4-9383-46ec-88d0-4d1a7e9ff9bc"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(449), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(450), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("e727fda2-5a61-4a32-80c5-be4231e14d67"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(672), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(673), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("6ead4efb-2f2d-47da-9e13-d7029ab4b824"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(664), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(665), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("1df5f3d8-bbee-41c7-8caf-cf7203d80b94"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(657), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(658), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("7fbb1321-4c01-4ffe-b31d-a2b2de6188af"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(649), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(651), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("e5864004-7876-48b4-923f-915f92644a3e"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(642), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(643), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("20c5a975-6aba-42c4-80ec-b393149b2aa2"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(634), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(636), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("0e38de86-baa0-4540-9650-192951e0ec40"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(627), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(628), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("f4a79ccd-5ef6-4600-8da3-0d71c18935a6"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(619), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(620), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("cc49dcce-24b9-4383-a57d-c0301fea551d"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(611), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(613), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("c9a38d14-70c8-4e7a-a20f-67ace341ca43"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(603), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(605), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("da065f83-7c34-41db-80cd-a4d23a8f509a"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(596), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(597), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("ac356470-3270-4efb-aebc-32e1f64aee0b"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(589), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(590), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("2e3b93b0-6e50-4815-9e21-b8d04802fd68"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(581), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(582), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("b508ade5-ef28-4520-84da-35561ad3c1a4"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(573), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(575), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("dbf881ba-06b9-4911-9386-93e8fd134ef6"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(566), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(567), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("2d592aa7-1c34-4e18-a318-adba2e5cf7ee"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(538), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(540), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("d2fca610-1d69-4add-8575-b4dc6a38963f"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(531), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(532), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("b6c14ca4-1d7e-4772-82c1-8e0ec46d3578"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(524), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(525), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("44f7c2d6-22ba-45ae-be24-3fc19ffbc661"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(517), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(518), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("d50e580c-5e71-47b5-a274-163198b1ce34"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(509), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(510), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("51e75796-08f5-4d42-a8cf-8a59152f2197"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(501), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(503), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("501e8414-9430-47fc-8ac2-73c64f76caa0"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(494), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(495), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("edb7a0eb-6497-4120-9362-ff0190c863fa"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(486), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(487), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("1d20f73a-a9b0-442d-be5f-39b3de25c0b9"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(478), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(479), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("72cc0944-2660-4d5d-baaf-c7e7452b6a2c"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(471), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(472), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("3ef9c15e-a4a8-42a5-80b4-bdc9b19ad103"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(464), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(465), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("8f2675cd-3ba2-408a-895a-c8c442dfe85a"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(456), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(458), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("e6b2dc4a-8b5f-4600-9362-016396692ba0"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(442), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(443), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("6b699636-da94-423e-bfae-d63c5801531d"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(208), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(209), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("5e1b3a70-3cf4-478a-852f-31076809da86"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(200), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(202), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("2b207ab2-13b2-4ef8-b46f-a7650682db3f"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(193), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(194), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("c9f4a120-75da-49e3-9873-3e5e17d0adf3"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9944), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9946), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("de5e13c7-0471-4a8a-a0ed-a321d7e41a06"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9936), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9938), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("86f0a8c2-a756-437f-9fac-fc57ee4b6a1f"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9929), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9930), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("8a626ac4-21ec-4ea4-beec-06f5e159bdb5"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9922), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9923), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("3fa02f0e-14c1-4cbf-a78b-3185b5cccaf0"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9914), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9915), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("5b89aa77-0615-4545-a8c2-90a4b197716a"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9907), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9908), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("27a83ecc-3b8f-44ae-931b-3de1226aaebf"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9899), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9900), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("d87eec3c-3af2-4cd4-8aeb-6d120fb7fb8e"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9891), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9893), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("3adac07d-e345-4c4f-ab1b-20b336565b42"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9884), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9885), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("8709e22a-fd3c-472d-a63f-f657c0d59a1f"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9876), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9877), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("09a19a83-6d45-4bf6-a604-c5e19ccca183"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9869), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9870), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("6892d6af-5223-4d82-8894-32615ee57a83"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9861), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9862), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("ac67b8c6-3d4d-4958-883a-12fa9983715b"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9854), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9855), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("5a158cf1-871e-4b02-a64e-8a35af4bd9cf"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9846), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9848), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("0b7abd04-a9b0-4834-afb1-cf066b29123b"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9839), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9840), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("4b7d4b4e-0851-41e9-9ba4-8d63efd8a785"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9831), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9832), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("b31acbc5-a4cd-4896-8d78-36b3a45a079e"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9823), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9824), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("11929167-e6b1-40eb-aa01-df8bec4d95e4"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9815), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9817), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("ba0215df-de22-47f2-8677-0768eb2d11a3"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9808), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9809), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("c374bb11-2ac1-48c7-b0eb-d9dde8074b4f"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9801), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9802), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("bf708ce3-6bbc-4978-a7c6-bf6943ee2e2e"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9793), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9794), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("cde0dbbd-2b3a-4390-b963-054646913d85"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9785), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9787), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("606909ad-be7d-42c2-86ad-d1d977e6ea06"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9777), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9779), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("17a7fdb9-6460-42bd-8ab5-22a8602139b4"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9749), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9750), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("ba6dc309-e44c-4196-9ad6-dbf722ac8776"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9742), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9743), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("1a040f54-de03-4add-9e3f-f6eb2b97faac"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9734), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9736), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("9deaeaca-2138-4a0a-879b-7f02d6ec3a56"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9727), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9728), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("7060a3b6-78b0-4a9a-bdee-fb21626d9983"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9952), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9953), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("d896cd7b-0584-414b-96a0-2aecca6e48f8"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9959), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9961), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("ed263f37-baf9-429d-98dd-728f88234560"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9967), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9968), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("00a1fb9d-f4e6-4b0f-859f-1dcd73041e3e"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9974), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9976), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("8eeb0e50-01f0-4f01-9b29-fb67055d0a3b"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(185), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(187), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("69cd3c1b-1f1e-4cdc-8087-e307222b6710"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(177), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(179), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("cea2c45f-fbab-4165-92f5-13c47dc48729"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(170), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(171), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("3db188f8-99f6-4e65-ba1d-3527792d281f"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(163), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(164), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("a3d39959-8639-4ab0-b71a-c76daa26f435"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(155), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(157), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("fe485adc-d6f8-4732-b1cc-00337e542c27"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(148), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(149), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("d012f944-4265-4d35-b486-fdf8093ed2c0"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(140), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(141), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("bc4d1cb4-56ea-4168-b67c-25afb8896dc5"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(133), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(134), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("e4087956-8689-40a3-941a-261b620f7c43"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(125), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(126), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("0f0347e7-691f-4ca7-a2e8-9f4778aaef8c"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(117), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(118), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("517a664d-5db8-4694-a7ac-13caf48666d3"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(110), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(111), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("883ecbc2-5f4a-4383-a69d-442188a2dcae"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(102), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(104), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("68c541bc-6a50-4387-bc89-8b717238e3c6"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(95), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(96), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("723abc12-b853-474e-9d89-f32d493dd3a9"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9712), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9713), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("cd1078c7-9c28-46cd-8dc0-6bf58c8842dd"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(88), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(89), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("2a97de98-c012-44d8-9a32-aa7e3d7853b7"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(73), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(74), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("3f164522-e69c-4499-98f9-b63cf013692b"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(65), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(66), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("36b8a22e-7e83-4278-aad7-57c9559fd551"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(57), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(58), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("cf17df4b-762f-4bde-9871-c3fc7b98695b"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(50), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(51), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("bfbecc0f-d9b0-4787-af8d-20fee7ae7494"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(42), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(44), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("ac374bbf-371b-4df1-83e6-5c860fb05be4"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(35), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(36), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("032a8d4a-bad0-468b-889c-1f09543ba38b"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(27), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(29), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("adc18514-f156-4f45-92bb-a63d80770ca5"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(20), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(21), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("836d5b04-a653-4f00-a4b9-658e9efeb382"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(12), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(13), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("d41ddef8-7dc2-4aac-b41e-8d3b497aa581"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(5), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(6), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("23ef17bd-d1e2-4763-8eb1-97ed99c48337"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9997), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9998), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("d0bde2dd-b8fc-4912-a29c-2dea4b270f08"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9989), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9991), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("6f9c14c2-ed81-408f-b104-8180222219f4"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9982), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(9983), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("541c1ece-f65c-4513-85f2-34558b351872"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(80), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(81), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("c297ef75-efbd-448b-a090-70f1081c1570"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8745), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8746), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("2c48e3f7-307e-4557-9975-1a8a9d310218"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8738), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8739), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("3e80f523-fb72-4a68-83c7-bba3bf2a51ad"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8730), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8731), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("f8e1a95e-4d12-4aad-8db5-6f5bf1f8eb1a"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7462), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7463), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("c5d90e2a-7465-4542-8c86-6b8d900e8fcc"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7455), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7456), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("47b5de7e-bdc0-47e1-b114-4f777b5f3f5d"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7447), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7448), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("fd184335-a15c-4e18-af59-787489902f80"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7439), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7441), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("80e39705-4427-4c48-809c-293bf96b5045"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7432), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7433), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("45950af5-6480-46a7-bfec-604d8ea4e6c2"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7424), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7425), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("237de215-b201-41b3-8ad4-3aa171829421"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7416), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7418), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("46ecd34d-402c-4515-9c28-2f21c80563ad"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7408), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7410), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("f9bbd602-6f02-46b8-ae3d-f5b05fd8f3cd"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7401), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7402), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("fc355758-70dd-4a86-bd8d-24d1dbd9c63e"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7393), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7395), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("26fff5ea-0622-4a0d-bd5e-280b1deb9bfa"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7386), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7387), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("6a50d85a-1067-4287-89ca-b7141c347bc9"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7379), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7380), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("475f3f72-b062-43a2-8df6-f0451fa76686"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7372), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7373), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("6aff63c4-dd11-476b-bc89-a16a19494df6"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7364), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7365), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("3c151495-999b-489e-b42b-6d87f0c62bf1"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7356), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7358), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("b3a67e96-13c4-4bce-9fb1-032527164684"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7348), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7350), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("77fd7b2a-eb71-4aaf-bb37-6e1deab735d8"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7341), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7342), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("80c3a9f3-f607-4f59-9517-b9af7dd908ac"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7334), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7335), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("a179b2f4-a82e-4382-8eed-9f7d04e40335"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7326), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7327), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("cda88072-b5b3-4f2e-95ff-f326f58055a1"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7319), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7320), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("34620058-b382-4d2e-b15f-1fe6c300bbcc"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7311), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7313), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("07e7e7ba-a5da-4f50-9359-a469d05a78cc"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7304), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7305), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("a9af0efe-1b55-455a-bc27-98650f8d5e80"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7296), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7297), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("61cd1e92-5b15-4bb7-86f3-ae588a880e55"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7288), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7289), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("229165bc-84c7-4bbf-97b6-c2c5bf59b395"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7281), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7282), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("badda136-c55b-4a9e-9776-b9c32fd43494"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7273), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7274), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("890bff86-4300-4684-b869-e9979ceb92a6"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7264), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7265), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("93a8440e-cb08-4305-aa83-b95859c07dc8"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7469), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7471), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("b7d54741-9544-4704-8ee2-b811b7de721b"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7256), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7257), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("4f2e418a-aa56-4f18-afe5-fab4e43c8d93"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7477), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7478), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("43abc7ee-a4a2-41a2-8585-c039ebfd1247"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7492), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7493), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("6abcdab8-b84c-40d4-a537-1f07c0e9aa18"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7695), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7697), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("2748bcb0-fbff-4b26-b276-01826a59d64e"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7688), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7689), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("91ed53ec-8074-4c07-b446-80200934475c"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7680), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7682), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("d842c03f-66e4-4e4b-8c5a-7ce311c53cb4"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7673), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7674), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("9e24fee6-e0e3-48c8-a7eb-68583fea3e01"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7665), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7667), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("76751398-2b18-4e0e-acd7-5ccfda20df09"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7658), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7659), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("83c03e12-6d0e-4780-bdd5-23d59e5be9d6"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7650), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7651), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("6647f028-6fc0-4ab6-b143-5a433bacf7c4"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7643), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7644), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("07035884-e147-438a-82a1-ad82cd55c242"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7635), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7637), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("57f59b53-3cdf-46c3-b78d-8edaa56901bb"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7628), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7629), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("6d9d374a-b041-4eb3-890e-fbf2e90253f0"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7620), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7622), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("02d343ed-1fec-4c47-bda9-62c447a42eac"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7613), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7614), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("10f568f3-58b1-45c7-b7aa-f46c0b0c809c"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7605), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7607), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("04ec8e2a-30e9-451e-b31d-cf9676edade2"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7597), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7599), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("ea7a1946-b8d0-4145-8b4d-b01adcdb7875"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7590), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7591), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("82e2f7d7-1c72-4298-b2e3-764ea1cbc11b"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7582), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7584), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("d8ac2123-5297-4840-a5af-3b4ae169a48a"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7575), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7576), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("31292c79-da9c-4183-9b8c-aba1e5cd1b10"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7568), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7569), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("8da064ca-ceaf-4acf-946d-27b70e7616e2"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7560), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7562), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("1c9d5fc1-03d9-4297-8570-7dfcc53fcba8"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7553), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7554), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("5a3f579d-b1cb-44cb-bb76-eb051691edf7"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7545), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7546), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("91eaf4c0-8280-42af-b07b-27cb86bdf979"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7538), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7539), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("564d53db-f168-4bd0-bd4a-57d6e3edd89b"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7530), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7531), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("9d519283-a2c6-49e1-b7ac-0654a8055fa6"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7522), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7524), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("bd408873-b3c4-4aa6-9213-9d97019895c7"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7515), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7516), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("2e7b6689-2352-44d6-90e1-3db811322bc6"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7507), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7509), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("0fe15340-3ec8-4cad-94af-aeacde6a1a4f"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7500), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7501), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("8bdb7518-d17b-4670-bbef-9b82f2b06f51"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7485), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7486), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("0a63bf63-eec5-486e-8543-126fb128814a"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7209), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7210), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("d204c7b2-2911-48b5-9806-c23447c6c1ea"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7201), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7202), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("4f090243-c1d8-4ef5-985b-3f9751bca6f5"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7194), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7195), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("0128f7bf-21b3-4e90-9c98-3497db153fc4"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6942), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6944), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("23441151-cf9a-4392-a3bd-8099b560fe00"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6935), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6936), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("352725be-37b0-4619-9d34-7f7403db153c"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6928), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6929), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("048f1c93-229d-4b48-9a5e-fdb10fc97248"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6920), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6921), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("fbb96cba-04ee-43b5-befc-8330d1b16b53"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6912), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6914), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("f1698641-a8d4-404e-9a6e-fcd7167ae5d0"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6905), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6906), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("ca745c7f-d3de-4c81-be95-fd22f58192bf"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6897), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6898), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("e695cd01-88d1-4115-8a5d-e0bd27256756"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6890), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6891), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("a1edbca7-9309-4e01-aacd-455ada2a2f69"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6881), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6883), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("d85eb0f0-856a-4bc1-bf0e-abc3194aef47"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6874), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6875), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("a2f00281-06e8-44ae-a73e-72a64d9420a2"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6866), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6868), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("788e5efb-6ea2-43a5-92f6-7a6c402fda47"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6857), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6859), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("d82293f1-6359-41f0-97d9-812643674545"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6850), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6851), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("3102d496-a92e-4fa3-9d99-475ba2e4db41"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6842), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6843), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("976c7f7d-5bdc-4714-aa59-2cffb0e3dfa6"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6834), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6836), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("4b9033bc-1714-49ba-948c-7273bc30738f"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6827), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6828), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("873ed9ad-e5bf-4970-b40d-cc3eb04bddcc"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6819), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6821), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("6b8288a1-46d2-48c5-8ed3-78b882b2e53a"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6812), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6813), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("09646aa7-cabe-4251-a94e-548d7608cb4c"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6805), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6806), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("38686272-15f7-4c49-ad6b-3932ad39798f"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6796), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6797), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("55ccd128-9bdb-4cbb-870e-9bf6d79864ce"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6789), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6790), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("9c778213-7cf6-496a-bec5-dc71346a833e"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6781), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6782), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("fdd3fda4-64a5-40a3-8260-7b1a496cb224"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6773), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6774), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("818fe81f-f0c3-4459-ba3c-ececb6c8b045"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6762), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6763), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("4211f043-0849-4b0c-84ff-9c182e81ac38"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6755), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6756), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("f2e9f57a-297a-4f92-a657-4302d0d120c2"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6746), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6748), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("c04e13fa-8ef3-4ae3-ba39-4fe062dd7bc7"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6693), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6717), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("e78b4640-c459-4b57-8195-2a365a2a65a4"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6950), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6951), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("b053b169-49b7-442a-91cb-25dc79aa07ce"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6957), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6958), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("69fbdda5-1f33-4279-84c9-6c8a82dac054"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6965), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6966), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("66d370cd-f559-49a2-afee-f93350d5fea8"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6973), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6974), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("9913b9c1-156f-441a-bff6-f3db9a57b82a"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7186), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7188), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("4b4b13fc-fb0b-436f-9166-87427831332d"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7179), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7180), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("60f9c262-f116-4dcc-a0df-28b37dfca97d"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7171), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7173), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("293021bf-0a18-49b6-a994-73b87e860266"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7164), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7165), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("3d2d0508-9421-4390-95ce-4aa7c0a2610b"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7156), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7157), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("f2fc279f-b176-4d8c-896b-82d727b97cc0"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7148), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7150), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("2da302aa-d20c-4810-8a8b-6758e6998d25"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7141), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7142), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("5abc8b3b-8954-4766-83e0-280596efea96"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7133), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7134), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("23485c3b-3208-462c-ad3e-2c39fcc24a7c"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7126), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7127), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("887f010e-2a41-48a7-9ed2-bc9e94cec530"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7118), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7120), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("d209b3c6-c12f-4e66-91e5-b7d860de32e7"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7111), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7112), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("7d3ce6e8-c95a-47bc-8f9a-4e2c7f8be132"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7103), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7104), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("ab15b355-fed3-43f7-991b-7888ba8164b7"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7095), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7097), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("2a865c93-6b74-4596-b205-08a1ccb23cb8"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7703), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7704), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("6b6b6af1-66e5-4518-8290-e5c53725d6c5"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7087), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7089), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("f086ae02-1562-43b9-b13c-437af60a141b"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7072), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7073), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("8b0bc0f2-2249-4cd2-8cb0-16fb8bbd3dad"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7065), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7066), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("8b0206ab-a848-4e90-bc14-21359da8d294"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7057), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7059), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("c1a60289-c728-4ef4-8c23-45db3db17898"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7050), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7051), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("8b63d261-6c98-42a9-b9c6-c655db095b96"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7042), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7043), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("b56d9c07-ad83-4f47-8c67-b6dec5519df4"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7034), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7036), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("435626f8-681c-430a-a1fd-8f553e74bc7c"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7027), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7028), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("d1a91746-1134-40b8-99cc-eebcbb189d4a"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7019), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7020), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("7fc889f8-d016-4a57-b4c5-67f62a294093"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7011), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7013), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("858ee9fe-a73e-4cb0-8e4a-aacbee31b159"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7004), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7005), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("19ee0529-57e7-4bd7-bd36-2573f0364994"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6996), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6998), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("6e16d7bd-41c9-4c99-8bb3-f8ab4e885a8b"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6989), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6990), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("b9d428ec-90cc-469c-aea0-24913b1cf921"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6980), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(6981), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("66bb7582-8a96-4cd2-a4fe-9ea6b9b89370"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7080), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7081), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("e75f8df6-1639-4690-9e66-f3e3ca6199e6"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7710), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7711), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("9dd65157-0de4-4f38-95ff-adf690dbc65c"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7718), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7719), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("b11d1e4b-f8a5-4d84-9e77-c6b9b32bcb9a"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7725), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7727), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("d0de1b04-66d6-4bcd-84ad-0f05666217ae"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8427), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8428), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("eba7d16f-350e-42a2-bdc3-bbd81aaadecb"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8419), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8421), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("92a51a3b-756b-410e-ba0b-614f50948595"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8412), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8413), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("7911bba3-c558-42a4-8e3b-ca329038120e"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8404), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8406), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("413ffb7e-0609-44d1-8f3a-8d41c1eb6516"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8397), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8398), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("139fc5f7-41c0-4df2-b582-19f96ae90e9b"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8389), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8390), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("306b6841-dedc-4fbc-b3a0-130a0fe9c88d"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8381), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8382), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("8a787433-71d6-4032-9d50-0f1f121715ad"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8374), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8375), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("d38ddab0-083c-4479-abf2-4f1b231a5500"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8366), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8368), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("320a830b-e8bb-4f4e-bb00-9dea5953816b"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8359), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8360), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("451da321-f91f-4c26-9c10-0a4d0c91602f"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8351), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8353), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("e3d937f2-44ca-44e6-b946-a68191857891"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8344), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8345), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("dee9b00d-3f66-4e64-8910-3297b37b4cf0"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8336), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8338), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("e6688424-7a60-4890-b02a-a9b85bcfb78f"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8329), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8330), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("bad2c855-b384-42fc-b6c9-b92b4adb4016"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8321), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8322), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("371df356-f749-4c70-802a-8facc9c35445"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8314), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8315), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("fa3744f3-b044-44ca-8385-7d65a06a884d"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8306), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8307), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("14fc3db2-3f35-46f8-af1c-810c36850b55"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8299), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8300), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("a39f5eba-afe3-49a0-b71b-07852fefd852"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8291), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8292), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("bf0ca466-c731-4489-a76b-98370e93d255"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8284), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8285), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("256083bb-e0f7-4baf-977b-2721d7e6c3a3"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8276), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8277), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("9c420fa9-7e7c-4ba6-b712-a764cac5f686"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8268), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8270), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("653fdb3b-d82d-477f-bf95-ac9b23eab322"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8261), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8262), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("02525a13-7a24-43ad-9426-3f6f3fcd503c"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8253), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8255), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("b814d125-cbe0-4b23-933a-075d592adaff"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8246), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8247), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("65058af0-3c2c-408f-8009-9b896384b946"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8238), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8240), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("e0f5ec81-ce00-4a5c-b10c-151af67f614b"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8231), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8232), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("3d995b45-fb36-4098-88f3-423951bba598"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8434), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8436), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("d86184cd-353f-4886-8995-21c376624fc7"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8442), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8443), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("d93c6139-5f79-499e-8e3c-b4060aa7433c"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8449), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8451), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("b21602b2-6564-4d41-b70c-37cead0b9495"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8457), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8458), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("99b01e94-338a-484b-ac78-705794b92dfe"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8722), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8724), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("cecf6666-4325-4bf3-81e4-275cf9e23747"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8714), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8716), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("01dca5d8-7315-4425-a5f2-bcc3625333ff"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8707), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8708), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("154f1751-c300-4524-9190-eefbbb77822e"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8700), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8701), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("1582aeae-4473-46b7-a054-36158a627839"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8692), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8694), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("1b2eca83-e498-4061-8e7f-f97827af110a"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8685), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8686), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("6ad30a09-e420-4b15-8927-a81299830353"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8677), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8679), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("88928401-5fd6-4c3b-8ffd-ca534aff5dc9"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8670), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8671), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("83012442-b905-4769-8bb9-b2fd03a91c25"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8662), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8663), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("badafd74-453c-46f9-b762-cbef10b331ec"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8654), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8655), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("5063899a-3420-4644-9206-b0942b6a7cb7"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8647), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8648), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("d469218c-79dd-479e-a718-c4cf35d80c99"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8639), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8641), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("bdb69022-fb46-4558-96bf-ce08fc33b554"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8632), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8633), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("d03bd2d4-b92b-4cb6-aae8-617460d6aa98"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8223), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8225), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("2b076543-5ffb-462f-8f99-6c2e4cac13d5"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8624), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8626), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("c2b59812-0890-4de5-a43f-f10b8d40bb4d"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8610), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8611), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("ac383de3-ebe6-4388-b050-3913b284184c"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8602), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8603), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("07360d84-16a6-4be4-bda6-cd353de43bc2"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8594), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8595), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("bbeaf21d-9387-4264-a1f8-657b09f25e13"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8586), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8588), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("9485647f-f421-45a5-94f3-2e07bc194c23"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8525), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8526), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("50bc43ac-897e-4425-a4f6-b3c03476f81a"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8517), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8519), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("dd3b57f5-ba38-4ad6-a6ca-bc73bbe35868"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8510), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8511), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("c3e837a8-870e-40b2-9077-213d44949eff"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8502), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8503), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("48597660-d816-4ee5-821e-c3e6ae005ae7"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8495), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8496), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("51514925-92f0-4c71-9c56-bfd144d7948e"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8487), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8489), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("80248d13-a3be-4295-837f-81192c826e5e"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8480), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8481), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("7cc3be52-5e1c-4588-ac06-0521f138e26e"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8472), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8474), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("becb8268-af34-4dbe-b4de-1315888856d4"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8465), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8466), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("00612270-01b4-4f38-9510-dc92663c4b89"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8617), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8618), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("126b4eeb-4420-4abb-931a-9f06e1aadb6e"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(680), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(681), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("33202763-8ee6-42f1-abf9-4494799c2b71"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8216), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8217), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("5f2add76-1552-4354-8b76-afcdcb32e729"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8200), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8202), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("a0f6fc81-edaf-491a-8eb0-4dc4ce4f015a"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7952), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7953), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("1fd03f4c-def6-4a74-a64a-d1fc49bcfc50"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7944), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7945), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("f8f099a7-2798-4471-94ee-375ab74adda8"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7937), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7938), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("1da41179-4941-482a-ab82-3a49d0a3ffcf"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7929), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7931), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("3848f940-8159-4310-beb1-2a594264e85d"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7922), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7923), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("97afab40-2a4c-47f1-9953-8a7ffcec2fad"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7914), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7916), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("ac9510be-388b-498a-ae61-077a84aeb2e3"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7906), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7908), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("bad1ef50-ff70-4062-a2eb-8770a94762d4"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7899), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7900), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("9d84911a-5ed2-439a-8053-e923169a33aa"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7891), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7893), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("4f6f4a2a-536b-434f-88eb-f2dbb6f2782b"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7884), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7885), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("e4ffa077-b2f6-4e92-b5c0-56f90538b3dc"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7877), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7878), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("08c3a6d2-d64b-4871-aadb-933c3a975107"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7869), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7870), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("c7ce4805-1f11-4d26-8fb7-1d91c2f0d34f"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7862), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7863), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("4fa5a60b-a9f8-4882-be93-48de7070e6f5"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7854), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7855), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("6b98a03d-7dd8-4a28-88cc-e974d725e43f"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7846), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7847), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("8791c594-0ffa-4332-b465-c261ba590588"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7838), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7840), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("5caefcd7-459d-413b-91fa-17479d31e933"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7831), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7832), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("5e289496-9226-428d-9ccb-a70f6deb48eb"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7824), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7825), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("08d6fd69-3e33-4dc9-b7f7-6984f71eb606"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7816), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7818), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("cd2e2147-1d8f-441d-a0b0-e4836a5bc114"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7809), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7810), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("05bd50fe-2642-4637-8eea-febf8b135dc8"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7801), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7802), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("cd10b933-97af-4228-b599-9e05514eb880"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7793), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7795), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("89a631b8-011e-44f6-b40f-c64a0e19066d"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7786), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7787), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("d89faa1c-bcb9-4a92-907a-f0ce159fe24f"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7778), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7779), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("37dfac68-0839-492d-91c9-65bd0ddd0331"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7748), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7749), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("066109e8-2eb8-4d59-a6a6-47c2cfedfdf7"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7740), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7741), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("81390cf4-0c5f-4b1d-96c5-924e569b12b2"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7733), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7734), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("4b24e57e-bd26-413e-8f91-00814e0889e7"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7959), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7960), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("60ec21f0-6e5f-4f11-8694-beb92d0da3d1"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7967), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7968), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("a245f636-1475-44ad-8bb5-492bf5d340ff"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7974), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7976), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("b2c2d36f-f4b4-4b74-9d07-47950c9ecbc3"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7982), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7983), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("5066f46e-c585-4fbc-ad0f-39df097228ab"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8193), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8194), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("158218f1-a741-485c-af06-c509915144d1"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8186), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8187), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("1281829b-0899-4845-a17b-573a26eb3e2d"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8178), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8180), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("6c4bf2ab-cdba-490e-9998-77fa9cc2e0e0"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8171), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8172), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("613d07b4-e0e1-465f-af34-5a10e42c9db7"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8163), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8165), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("e37b7687-b355-4e29-9f93-9342367c6040"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8156), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8157), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("5222fa30-ba91-419a-b785-25a351f5fcbc"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8148), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8149), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("680f576a-ae64-436f-8fda-e185563c19f9"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8140), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8141), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("135fb263-109c-4cc6-a3ef-e667a06c25a6"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8133), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8134), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("c82a2e1e-da02-47d2-a8d8-a16ad34ef7cd"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8125), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8127), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("baa37db5-9fad-447c-b6d4-356ea935e265"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8118), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8119), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("5df95be1-d8d1-4256-81d7-254a79599ddd"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8110), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8112), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("db8238f8-b3e8-4a56-ace8-f4a04f1f2032"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8103), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8104), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("75862f31-5188-45a0-a334-e62b2cb81db8"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8208), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8209), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("cc9f1e4e-5f3d-4062-906f-a7c298bb19e8"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8095), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8097), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("75cbc110-b10a-47aa-b0f2-f70878577504"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8080), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8081), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("61d4f603-966f-4bdc-b0c7-a1944fc0a1fa"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8073), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8074), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("301b5db4-cb46-4bf5-ba0b-4b4ac91f55bb"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8065), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8066), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("f5d38209-b15e-4b2e-a421-d67bf1919d92"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8058), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8059), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("156ef409-09e9-42cf-8a1e-9279e9860f25"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8050), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8051), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("b2c069a6-e541-4e29-b67d-4a3324c6d351"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8042), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8044), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("0bc9b06a-3218-4eb9-8755-bb7fd72d0aa8"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8035), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8036), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("a935457e-ca8b-4ef5-a9eb-0fa94d25babb"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8027), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8028), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("261aff13-ad3e-4f08-b909-e81cd2839fca"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8019), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8021), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("4bc34be8-6a94-4ce3-843a-1738ce5e37b2"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8012), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8013), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("5fb39746-fc5c-4850-a504-8b46e169f96f"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8004), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8006), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("c2cdc3dd-f1f1-48d5-bf8c-9e01694bba60"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7997), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7998), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("42722abb-c459-43b9-ac77-335135a1eb32"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7989), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(7991), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("b8ea65e1-cac6-40a8-bb7f-ef8156ffc1f8"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8088), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 846, DateTimeKind.Local).AddTicks(8089), 0.0, "Title" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ExpiryDate", "IsActive", "IsSold", "PostDate", "Price", "Title" },
                values: new object[] { new Guid("f694491b-bc98-45bc-af97-67f7ac460908"), "Description", new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(687), true, true, new DateTime(2020, 5, 23, 19, 10, 35, 847, DateTimeKind.Local).AddTicks(688), 0.0, "Title" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
