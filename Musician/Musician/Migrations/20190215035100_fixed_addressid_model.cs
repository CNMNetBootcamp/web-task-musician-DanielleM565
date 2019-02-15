using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MusicianRecords.Migrations
{
    public partial class fixed_addressid_model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Musicians_MusicianID",
                table: "Address");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "MusicianID",
                table: "Address");

            migrationBuilder.AddColumn<int>(
                name: "AddressesAddressID",
                table: "Musicians",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AddressID",
                table: "Address",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                table: "Address",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_Musicians_AddressesAddressID",
                table: "Musicians",
                column: "AddressesAddressID");

            migrationBuilder.AddForeignKey(
                name: "FK_Musicians_Address_AddressesAddressID",
                table: "Musicians",
                column: "AddressesAddressID",
                principalTable: "Address",
                principalColumn: "AddressID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Musicians_Address_AddressesAddressID",
                table: "Musicians");

            migrationBuilder.DropIndex(
                name: "IX_Musicians_AddressesAddressID",
                table: "Musicians");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "AddressesAddressID",
                table: "Musicians");

            migrationBuilder.DropColumn(
                name: "AddressID",
                table: "Address");

            migrationBuilder.AddColumn<int>(
                name: "MusicianID",
                table: "Address",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                table: "Address",
                column: "MusicianID");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Musicians_MusicianID",
                table: "Address",
                column: "MusicianID",
                principalTable: "Musicians",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
