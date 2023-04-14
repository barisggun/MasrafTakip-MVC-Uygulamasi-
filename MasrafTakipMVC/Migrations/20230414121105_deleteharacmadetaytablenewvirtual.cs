using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MasrafTakipMVC.Migrations
{
    /// <inheritdoc />
    public partial class deleteharacmadetaytablenewvirtual : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HarcamalarId",
                table: "HarcamaDetaylari");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HarcamalarId",
                table: "HarcamaDetaylari",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
