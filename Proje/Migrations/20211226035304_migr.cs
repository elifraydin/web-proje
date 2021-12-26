using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Proje.Migrations
{
    public partial class migr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MalzemeYemek_Malzeme_MalzemeId",
                table: "MalzemeYemek");

            migrationBuilder.DropForeignKey(
                name: "FK_MalzemeYemek_Yemek_YemekId",
                table: "MalzemeYemek");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MalzemeYemek",
                table: "MalzemeYemek");

            migrationBuilder.RenameTable(
                name: "MalzemeYemek",
                newName: "YemekMalzeme");

            migrationBuilder.RenameIndex(
                name: "IX_MalzemeYemek_YemekId",
                table: "YemekMalzeme",
                newName: "IX_YemekMalzeme_YemekId");

            migrationBuilder.RenameIndex(
                name: "IX_MalzemeYemek_MalzemeId",
                table: "YemekMalzeme",
                newName: "IX_YemekMalzeme_MalzemeId");

            migrationBuilder.AddColumn<string>(
                name: "Ad",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DogumTarihi",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Soyad",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_YemekMalzeme",
                table: "YemekMalzeme",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_YemekMalzeme_Malzeme_MalzemeId",
                table: "YemekMalzeme",
                column: "MalzemeId",
                principalTable: "Malzeme",
                principalColumn: "MalzemeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_YemekMalzeme_Yemek_YemekId",
                table: "YemekMalzeme",
                column: "YemekId",
                principalTable: "Yemek",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_YemekMalzeme_Malzeme_MalzemeId",
                table: "YemekMalzeme");

            migrationBuilder.DropForeignKey(
                name: "FK_YemekMalzeme_Yemek_YemekId",
                table: "YemekMalzeme");

            migrationBuilder.DropPrimaryKey(
                name: "PK_YemekMalzeme",
                table: "YemekMalzeme");

            migrationBuilder.DropColumn(
                name: "Ad",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DogumTarihi",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Soyad",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "YemekMalzeme",
                newName: "MalzemeYemek");

            migrationBuilder.RenameIndex(
                name: "IX_YemekMalzeme_YemekId",
                table: "MalzemeYemek",
                newName: "IX_MalzemeYemek_YemekId");

            migrationBuilder.RenameIndex(
                name: "IX_YemekMalzeme_MalzemeId",
                table: "MalzemeYemek",
                newName: "IX_MalzemeYemek_MalzemeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MalzemeYemek",
                table: "MalzemeYemek",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MalzemeYemek_Malzeme_MalzemeId",
                table: "MalzemeYemek",
                column: "MalzemeId",
                principalTable: "Malzeme",
                principalColumn: "MalzemeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MalzemeYemek_Yemek_YemekId",
                table: "MalzemeYemek",
                column: "YemekId",
                principalTable: "Yemek",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
