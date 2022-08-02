using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace csharp_boolflix.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Generi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeGenere = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Profili",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeProfilo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bambino = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profili", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Series",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitoloSerie = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stagioni",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitoloStagione = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroStagione = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stagioni", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContenutiVideo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titolo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Durata = table.Column<int>(type: "int", nullable: false),
                    Novità = table.Column<bool>(type: "bit", nullable: false),
                    GenereId = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomeEpisodio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomeFilm = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContenutiVideo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContenutiVideo_Generi_GenereId",
                        column: x => x.GenereId,
                        principalTable: "Generi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitoloPlayList = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfiloId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayLists_Profili_ProfiloId",
                        column: x => x.ProfiloId,
                        principalTable: "Profili",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContenutoVideoProfilo",
                columns: table => new
                {
                    ContenutoVideosId = table.Column<int>(type: "int", nullable: false),
                    ProfiliId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContenutoVideoProfilo", x => new { x.ContenutoVideosId, x.ProfiliId });
                    table.ForeignKey(
                        name: "FK_ContenutoVideoProfilo_ContenutiVideo_ContenutoVideosId",
                        column: x => x.ContenutoVideosId,
                        principalTable: "ContenutiVideo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContenutoVideoProfilo_Profili_ProfiliId",
                        column: x => x.ProfiliId,
                        principalTable: "Profili",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContenutoVideoPlayList",
                columns: table => new
                {
                    ContenutoVideosId = table.Column<int>(type: "int", nullable: false),
                    PlayListsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContenutoVideoPlayList", x => new { x.ContenutoVideosId, x.PlayListsId });
                    table.ForeignKey(
                        name: "FK_ContenutoVideoPlayList_ContenutiVideo_ContenutoVideosId",
                        column: x => x.ContenutoVideosId,
                        principalTable: "ContenutiVideo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContenutoVideoPlayList_PlayLists_PlayListsId",
                        column: x => x.PlayListsId,
                        principalTable: "PlayLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContenutiVideo_GenereId",
                table: "ContenutiVideo",
                column: "GenereId");

            migrationBuilder.CreateIndex(
                name: "IX_ContenutoVideoPlayList_PlayListsId",
                table: "ContenutoVideoPlayList",
                column: "PlayListsId");

            migrationBuilder.CreateIndex(
                name: "IX_ContenutoVideoProfilo_ProfiliId",
                table: "ContenutoVideoProfilo",
                column: "ProfiliId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayLists_ProfiloId",
                table: "PlayLists",
                column: "ProfiloId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContenutoVideoPlayList");

            migrationBuilder.DropTable(
                name: "ContenutoVideoProfilo");

            migrationBuilder.DropTable(
                name: "Series");

            migrationBuilder.DropTable(
                name: "Stagioni");

            migrationBuilder.DropTable(
                name: "PlayLists");

            migrationBuilder.DropTable(
                name: "ContenutiVideo");

            migrationBuilder.DropTable(
                name: "Profili");

            migrationBuilder.DropTable(
                name: "Generi");
        }
    }
}
