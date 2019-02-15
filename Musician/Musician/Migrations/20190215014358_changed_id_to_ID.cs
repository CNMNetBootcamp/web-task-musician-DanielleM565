using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MusicianRecords.Migrations
{
    public partial class changed_id_to_ID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Instrument",
                columns: table => new
                {
                    InstrumentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InstrumentName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instrument", x => x.InstrumentID);
                });

            migrationBuilder.CreateTable(
                name: "Musicians",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstMidName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    SSN = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musicians", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    MusicianID = table.Column<int>(nullable: false),
                    AddressLocation = table.Column<string>(maxLength: 50, nullable: true),
                    PhoneNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.MusicianID);
                    table.ForeignKey(
                        name: "FK_Address_Musicians_MusicianID",
                        column: x => x.MusicianID,
                        principalTable: "Musicians",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Album",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AlbumIdnt = table.Column<string>(nullable: true),
                    AlbumName = table.Column<string>(nullable: true),
                    CopyrightDate = table.Column<DateTime>(nullable: false),
                    Format = table.Column<string>(nullable: true),
                    MusicianID = table.Column<int>(nullable: false),
                    Producer = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Album", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Album_Musicians_MusicianID",
                        column: x => x.MusicianID,
                        principalTable: "Musicians",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MusicianToInstrument",
                columns: table => new
                {
                    MusicianID = table.Column<int>(nullable: false),
                    InstrumentID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusicianToInstrument", x => new { x.MusicianID, x.InstrumentID });
                    table.ForeignKey(
                        name: "FK_MusicianToInstrument_Instrument_InstrumentID",
                        column: x => x.InstrumentID,
                        principalTable: "Instrument",
                        principalColumn: "InstrumentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MusicianToInstrument_Musicians_MusicianID",
                        column: x => x.MusicianID,
                        principalTable: "Musicians",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Song",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AlbumsID = table.Column<int>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    MusicKey = table.Column<string>(nullable: true),
                    SongTitle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Song", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Song_Album_AlbumsID",
                        column: x => x.AlbumsID,
                        principalTable: "Album",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MusicianToSong",
                columns: table => new
                {
                    MusicianID = table.Column<int>(nullable: false),
                    SongID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusicianToSong", x => new { x.MusicianID, x.SongID });
                    table.ForeignKey(
                        name: "FK_MusicianToSong_Musicians_MusicianID",
                        column: x => x.MusicianID,
                        principalTable: "Musicians",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MusicianToSong_Song_SongID",
                        column: x => x.SongID,
                        principalTable: "Song",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Album_MusicianID",
                table: "Album",
                column: "MusicianID");

            migrationBuilder.CreateIndex(
                name: "IX_MusicianToInstrument_InstrumentID",
                table: "MusicianToInstrument",
                column: "InstrumentID");

            migrationBuilder.CreateIndex(
                name: "IX_MusicianToSong_SongID",
                table: "MusicianToSong",
                column: "SongID");

            migrationBuilder.CreateIndex(
                name: "IX_Song_AlbumsID",
                table: "Song",
                column: "AlbumsID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "MusicianToInstrument");

            migrationBuilder.DropTable(
                name: "MusicianToSong");

            migrationBuilder.DropTable(
                name: "Instrument");

            migrationBuilder.DropTable(
                name: "Song");

            migrationBuilder.DropTable(
                name: "Album");

            migrationBuilder.DropTable(
                name: "Musicians");
        }
    }
}
