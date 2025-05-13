using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GuevaraG_ExamenProg1.Migrations
{
    /// <inheritdoc />
    public partial class MigracionV5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "Recompensa");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Tipo",
                table: "Recompensa",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
