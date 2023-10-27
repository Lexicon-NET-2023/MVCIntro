using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCIntro.Migrations
{
    /// <inheritdoc />
    public partial class AddDeparment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Department",
                table: "Employee");
        }
    }
}
