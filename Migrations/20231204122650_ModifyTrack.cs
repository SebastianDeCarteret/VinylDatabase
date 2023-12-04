using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VinylDatabase.Migrations
{
    /// <inheritdoc />
    public partial class ModifyTrack : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_Vinyls_VinylId",
                table: "Tracks");

            migrationBuilder.AlterColumn<int>(
                name: "VinylId",
                table: "Tracks",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_Vinyls_VinylId",
                table: "Tracks",
                column: "VinylId",
                principalTable: "Vinyls",
                principalColumn: "VinylId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_Vinyls_VinylId",
                table: "Tracks");

            migrationBuilder.AlterColumn<int>(
                name: "VinylId",
                table: "Tracks",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_Vinyls_VinylId",
                table: "Tracks",
                column: "VinylId",
                principalTable: "Vinyls",
                principalColumn: "VinylId");
        }
    }
}
