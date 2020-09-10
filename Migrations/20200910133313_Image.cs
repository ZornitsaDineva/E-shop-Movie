using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace E_shop_Movie.Migrations
{
    public partial class Image : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FileContent",
                table: "Movie",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldMaxLength: 2000000000,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Movie",
                maxLength: 6000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Movie",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Movie");

            migrationBuilder.AlterColumn<byte[]>(
                name: "FileContent",
                table: "Movie",
                type: "varbinary(max)",
                maxLength: 2000000000,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);
        }
    }
}
