using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SqliteTool.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiabloActs",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiabloActs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Act",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    slug = table.Column<string>(type: "TEXT", nullable: false),
                    number = table.Column<int>(type: "INTEGER", nullable: false),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    DiabloActsid = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Act", x => x.id);
                    table.ForeignKey(
                        name: "FK_Act_DiabloActs_DiabloActsid",
                        column: x => x.DiabloActsid,
                        principalTable: "DiabloActs",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Quest",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    slug = table.Column<string>(type: "TEXT", nullable: false),
                    Actid = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quest", x => x.id);
                    table.ForeignKey(
                        name: "FK_Quest_Act_Actid",
                        column: x => x.Actid,
                        principalTable: "Act",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Act_DiabloActsid",
                table: "Act",
                column: "DiabloActsid");

            migrationBuilder.CreateIndex(
                name: "IX_Quest_Actid",
                table: "Quest",
                column: "Actid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quest");

            migrationBuilder.DropTable(
                name: "Act");

            migrationBuilder.DropTable(
                name: "DiabloActs");
        }
    }
}
