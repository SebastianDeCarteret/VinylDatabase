using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VinylDatabase.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vinyls",
                columns: table => new
                {
                    VinylId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Artist = table.Column<int>(type: "INTEGER", nullable: false),
                    NumberOfLps = table.Column<int>(type: "INTEGER", nullable: false),
                    NumberOfTracks = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<int>(type: "INTEGER", nullable: false),
                    ImageLink = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vinyls", x => x.VinylId);
                });

            migrationBuilder.CreateTable(
                name: "Tracks",
                columns: table => new
                {
                    TrackId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Length = table.Column<int>(type: "INTEGER", nullable: false),
                    VinylId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracks", x => x.TrackId);
                    table.ForeignKey(
                        name: "FK_Tracks_Vinyls_VinylId",
                        column: x => x.VinylId,
                        principalTable: "Vinyls",
                        principalColumn: "VinylId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_VinylId",
                table: "Tracks",
                column: "VinylId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tracks");

            migrationBuilder.DropTable(
                name: "Vinyls");
        }
    }
}
