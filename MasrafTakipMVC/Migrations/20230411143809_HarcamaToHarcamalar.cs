using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MasrafTakipMVC.Migrations
{
    /// <inheritdoc />
    public partial class HarcamaToHarcamalar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Harcama_Personeller_PersonelId",
                table: "Harcama");

            migrationBuilder.DropForeignKey(
                name: "FK_HarcamaDetaylari_Harcama_HarcamaId",
                table: "HarcamaDetaylari");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Harcama",
                table: "Harcama");

            migrationBuilder.RenameTable(
                name: "Harcama",
                newName: "Harcamalar");

            migrationBuilder.RenameIndex(
                name: "IX_Harcama_PersonelId",
                table: "Harcamalar",
                newName: "IX_Harcamalar_PersonelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Harcamalar",
                table: "Harcamalar",
                column: "Id");

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
                name: "FK_HarcamaDetaylari_Harcamalar_HarcamaId",
                table: "HarcamaDetaylari");

            migrationBuilder.DropForeignKey(
                name: "FK_Harcamalar_Personeller_PersonelId",
                table: "Harcamalar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Harcamalar",
                table: "Harcamalar");

            migrationBuilder.RenameTable(
                name: "Harcamalar",
                newName: "Harcama");

            migrationBuilder.RenameIndex(
                name: "IX_Harcamalar_PersonelId",
                table: "Harcama",
                newName: "IX_Harcama_PersonelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Harcama",
                table: "Harcama",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Harcama_Personeller_PersonelId",
                table: "Harcama",
                column: "PersonelId",
                principalTable: "Personeller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HarcamaDetaylari_Harcama_HarcamaId",
                table: "HarcamaDetaylari",
                column: "HarcamaId",
                principalTable: "Harcama",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
