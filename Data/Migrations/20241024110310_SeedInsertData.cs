using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Baby_ShoppingOnline.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedInsertData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "AccountId", "Email", "Password", "Phone", "Username" },
                values: new object[,]
                {
                    { 1, "thanhthao110889@gmail.com", "12345678", "0982345167", "thaolent" },
                    { 2, "kisshoang@gmail.com", "12345678", "0982345168", "dungdq" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(409), new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(423) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(425), new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(425) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(426), new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(427) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(428), new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(428) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(429), new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(430) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "AveragePoint", "CreatedBy", "CreatedDate", "Description", "Image", "Price", "ProductName", "RefCategoryIdCategoryId", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 6, 7.5m, "Admin", new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(431), "Aptamil NewZeland", "D:\\.NET\\BabyShopping_Image\\Milk\\Powdered milk\\aptamil_bac.jpg", 195000.0m, "Aptamil", 2, "Admin", new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(431) },
                    { 7, 5.0m, "Admin", new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(432), "For infant", "D:\\.NET\\BabyShopping_Image\\Milk\\Powdered milk\\blackmore.jpg", 189900.0m, "Blackmores", 2, "Admin", new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(432) },
                    { 8, 9.0m, "Admin", new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(434), "Colos for baby", "D:\\.NET\\BabyShopping_Image\\Milk\\Powdered milk\\colosbaby.jpg", 205000.0m, "ColosBaby", 2, "Admin", new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(434) },
                    { 9, 7.2m, "Admin", new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(435), "Well-cooked, pureed legumes such as beans, lentils and chickpeas.", "D:\\.NET\\BabyShopping_Image\\Milk\\Powdered milk\\enfamil.jpg", 234098.0m, "Enfamil A+", 2, "Admin", new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(435) },
                    { 10, 6.1m, "Admin", new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(436), "HiPP becomes Germany's third company and first food manufacturer", "D:\\.NET\\BabyShopping_Image\\Milk\\Powdered milk\\hipp.jpg", 245000.0m, "HiPP", 2, "Admin", new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(437) },
                    { 11, 7.5m, "Admin", new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(437), "Abott Grow", "D:\\.NET\\BabyShopping_Image\\Milk\\Liquid milk\\abottgrow.jpg", 195000.0m, "Abott Grow", 3, "Admin", new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(438) },
                    { 12, 5.6m, "Admin", new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(439), "Aptakid", "D:\\.NET\\BabyShopping_Image\\Milk\\Liquid milk\\aptakid.jpg", 189900.0m, "Aptakid", 3, "Admin", new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(439) },
                    { 13, 4.0m, "Admin", new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(440), "Colos for baby", "D:\\.NET\\BabyShopping_Image\\Milk\\Liquid milk\\colosbaby.jpg", 205000.0m, "ColosBaby", 3, "Admin", new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(441) },
                    { 14, 7.4m, "Admin", new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(442), "DalatMilk", "D:\\.NET\\BabyShopping_Image\\Milk\\Liquid milk\\dalatmilk.jpg", 123000.0m, "DalatMilk", 3, "Admin", new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(442) },
                    { 15, 9.8m, "Admin", new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(449), "Vinamil Green farm", "D:\\.NET\\BabyShopping_Image\\Milk\\Liquid milk\\vinamilk xanh.jpg", 134000.0m, "Vinamilk", 3, "Admin", new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(449) },
                    { 16, 7.5m, "Admin", new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(450), "Banh an dam", "D:\\.NET\\BabyShopping_Image\\Baby Food\\banhandamGerber.jpg", 195000.0m, "Gerber Puffs", 4, "Admin", new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(450) },
                    { 17, 5.6m, "Admin", new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(451), "Bot an dam vi lua mach", "D:\\.NET\\BabyShopping_Image\\Baby Food\\botbiokid.jpg", 189900.0m, "BioKids", 4, "Admin", new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(452) },
                    { 18, 4.0m, "Admin", new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(453), "Bot an dam vij sua", "D:\\.NET\\BabyShopping_Image\\Baby Food\\botHeinz.jpg", 205000.0m, "Bot Heinz", 4, "Admin", new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(453) },
                    { 19, 7.4m, "Admin", new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(454), "Bot an dam Hipp", "D:\\.NET\\BabyShopping_Image\\Baby Food\\botHipp.jpg", 123000.0m, "Bot HiPP Organic", 4, "Admin", new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(455) },
                    { 20, 9.8m, "Admin", new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(455), "Vang sua trai cay", "D:\\.NET\\BabyShopping_Image\\Baby Food\\vangsuahoff.jpg", 134000.0m, "Vang sua Hoff", 4, "Admin", new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(456) },
                    { 21, 7.5m, "Admin", new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(457), "Men tieu hoa", "D:\\.NET\\BabyShopping_Image\\Vitamin\\biogaia.jpg", 195000.0m, "BioGaia", 5, "Admin", new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(457) },
                    { 22, 5.6m, "Admin", new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(458), "D3K2", "D:\\.NET\\BabyShopping_Image\\Vitamin\\sunday natural.jpg", 189900.0m, "Sunday Natural", 5, "Admin", new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(458) },
                    { 23, 4.0m, "Admin", new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(459), "An ngon ngu ngon", "D:\\.NET\\BabyShopping_Image\\Vitamin\\fitobimbi.jpg", 205000.0m, "Fitobimbi", 5, "Admin", new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(460) },
                    { 24, 7.4m, "Admin", new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(461), "MultiVitamins", "D:\\.NET\\BabyShopping_Image\\Vitamin\\pediakid.jpg", 123000.0m, "PediaKid", 5, "Admin", new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(461) },
                    { 25, 9.8m, "Admin", new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(462), "Probiotic", "D:\\.NET\\BabyShopping_Image\\Vitamin\\pribiotic.jpg", 134000.0m, "Kid Smart drops", 5, "Admin", new DateTime(2024, 10, 24, 18, 3, 9, 911, DateTimeKind.Local).AddTicks(462) }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "RatingId", "Comment", "Point", "RefProductIdProductId" },
                values: new object[,]
                {
                    { 1, "This iss rating for product 1", 5, 1 },
                    { 2, "This iss rating for product 6", 7, 6 },
                    { 3, "This iss rating for product 10", 8, 10 },
                    { 4, "This iss rating for product 19", 6, 19 },
                    { 5, "This iss rating for product 22", 9, 22 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "AccountId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 24, 16, 44, 39, 742, DateTimeKind.Local).AddTicks(2973), new DateTime(2024, 10, 24, 16, 44, 39, 742, DateTimeKind.Local).AddTicks(2983) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 24, 16, 44, 39, 742, DateTimeKind.Local).AddTicks(2984), new DateTime(2024, 10, 24, 16, 44, 39, 742, DateTimeKind.Local).AddTicks(2985) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 24, 16, 44, 39, 742, DateTimeKind.Local).AddTicks(3015), new DateTime(2024, 10, 24, 16, 44, 39, 742, DateTimeKind.Local).AddTicks(3015) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 24, 16, 44, 39, 742, DateTimeKind.Local).AddTicks(3016), new DateTime(2024, 10, 24, 16, 44, 39, 742, DateTimeKind.Local).AddTicks(3017) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 24, 16, 44, 39, 742, DateTimeKind.Local).AddTicks(3017), new DateTime(2024, 10, 24, 16, 44, 39, 742, DateTimeKind.Local).AddTicks(3018) });
        }
    }
}
