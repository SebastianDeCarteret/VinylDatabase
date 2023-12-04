using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VinylDatabase.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTrackLengthType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeOnly>(
                name: "Length",
                table: "Tracks",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "REAL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Length",
                table: "Tracks",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(TimeOnly),
                oldType: "TEXT");
        }
    }
}
