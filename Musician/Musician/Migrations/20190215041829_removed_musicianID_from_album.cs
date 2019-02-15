using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MusicianRecords.Migrations
{
    public partial class removed_musicianID_from_album : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Album_Musicians_MusicianID",
                table: "Album");

            migrationBuilder.AlterColumn<int>(
                name: "MusicianID",
                table: "Album",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Album_Musicians_MusicianID",
                table: "Album",
                column: "MusicianID",
                principalTable: "Musicians",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Album_Musicians_MusicianID",
                table: "Album");

            migrationBuilder.AlterColumn<int>(
                name: "MusicianID",
                table: "Album",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Album_Musicians_MusicianID",
                table: "Album",
                column: "MusicianID",
                principalTable: "Musicians",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
