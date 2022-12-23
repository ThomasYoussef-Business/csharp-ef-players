using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CSEntityFrameworkPlayers.Migrations
{
    /// <inheritdoc />
    public partial class ChangePlayerScoreToDecimal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Score",
                table: "Players",
                type: "float(5)",
                precision: 5,
                scale: 3,
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Score",
                table: "Players",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float(5)",
                oldPrecision: 5,
                oldScale: 3);
        }
    }
}
