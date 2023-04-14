using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MasrafTakipMVC.Migrations
{
    /// <inheritdoc />
    public partial class TablolarBirbirineBaglandi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HarcamaId",
                table: "HarcamaDetaylari",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Harcamalar_PersonelId",
                table: "Harcamalar",
                column: "PersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_HarcamaDetaylari_HarcamaId",
                table: "HarcamaDetaylari",
                column: "HarcamaId");

            migrationBuilder.CreateIndex(
                name: "IX_HarcamaDetaylari_HarcamaTipiId",
                table: "HarcamaDetaylari",
                column: "HarcamaTipiId");

            migrationBuilder.AddForeignKey(
                name: "FK_HarcamaDetaylari_HarcamaTipleri_HarcamaTipiId",
                table: "HarcamaDetaylari",
                column: "HarcamaTipiId",
                principalTable: "HarcamaTipleri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HarcamaDetaylari_Harcamalar_HarcamaId",
                table: "HarcamaDetaylari",
                column: "HarcamaId",
                principalTable: "Harcamalar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Harcamalar_Personeller_PersonelId",
                table: "Harcamalar",
                column: "PersonelId",
                principalTable: "Personeller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HarcamaDetaylari_HarcamaTipleri_HarcamaTipiId",
                table: "HarcamaDetaylari");

            migrationBuilder.DropForeignKey(
                name: "FK_HarcamaDetaylari_Harcamalar_HarcamaId",
                table: "HarcamaDetaylari");

            migrationBuilder.DropForeignKey(
                name: "FK_Harcamalar_Personeller_PersonelId",
                table: "Harcamalar");

            migrationBuilder.DropIndex(
                name: "IX_Harcamalar_PersonelId",
                table: "Harcamalar");

            migrationBuilder.DropIndex(
                name: "IX_HarcamaDetaylari_HarcamaId",
                table: "HarcamaDetaylari");

            migrationBuilder.DropIndex(
                name: "IX_HarcamaDetaylari_HarcamaTipiId",
                table: "HarcamaDetaylari");

            migrationBuilder.DropColumn(
                name: "HarcamaId",
                table: "HarcamaDetaylari");
        }
    }
}
