using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GuevaraG_ExamenProg1.Migrations
{
    /// <inheritdoc />
    public partial class MigracionV4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_Recompensa_RecompensasPuntos",
                table: "Cliente");

            migrationBuilder.DropForeignKey(
                name: "FK_Reserva_Cliente_ClienteId",
                table: "Reserva");

            migrationBuilder.RenameColumn(
                name: "RecompensasPuntos",
                table: "Cliente",
                newName: "RecompensaId");

            migrationBuilder.RenameIndex(
                name: "IX_Cliente_RecompensasPuntos",
                table: "Cliente",
                newName: "IX_Cliente_RecompensaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_Recompensa_RecompensaId",
                table: "Cliente",
                column: "RecompensaId",
                principalTable: "Recompensa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reserva_Cliente_ClienteId",
                table: "Reserva",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_Recompensa_RecompensaId",
                table: "Cliente");

            migrationBuilder.DropForeignKey(
                name: "FK_Reserva_Cliente_ClienteId",
                table: "Reserva");

            migrationBuilder.RenameColumn(
                name: "RecompensaId",
                table: "Cliente",
                newName: "RecompensasPuntos");

            migrationBuilder.RenameIndex(
                name: "IX_Cliente_RecompensaId",
                table: "Cliente",
                newName: "IX_Cliente_RecompensasPuntos");

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_Recompensa_RecompensasPuntos",
                table: "Cliente",
                column: "RecompensasPuntos",
                principalTable: "Recompensa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reserva_Cliente_ClienteId",
                table: "Reserva",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
