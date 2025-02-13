using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EksamensOpgaveBackend.Migrations
{
    /// <inheritdoc />
    public partial class Loremipsum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "productModels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "værktøj1" });

            migrationBuilder.UpdateData(
                table: "productModels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "værktøj2" });

            migrationBuilder.UpdateData(
                table: "productModels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "værktøj3" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "productModels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "Royal Villa" });

            migrationBuilder.UpdateData(
                table: "productModels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "Premium Pool Villa" });

            migrationBuilder.UpdateData(
                table: "productModels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.", "Premium Pool Villa" });
        }
    }
}
