using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BDEcomSurUsuarios.Migrations
{
    /// <inheritdoc />
    public partial class InitBD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BDPermisos",
                columns: table => new
                {
                    fiIdPermiso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fiName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BDPermisos", x => x.fiIdPermiso);
                });

            migrationBuilder.CreateTable(
                name: "BDRoles",
                columns: table => new
                {
                    fiIdRol = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fiName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BDRoles", x => x.fiIdRol);
                });

            migrationBuilder.CreateTable(
                name: "BDRolesPermisos",
                columns: table => new
                {
                    fiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fiIdRol = table.Column<int>(type: "int", nullable: false),
                    fiIdPermiso = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BDRolesPermisos", x => x.fiId);
                    table.ForeignKey(
                        name: "FK_BDRolesPermisos_BDPermisos_fiIdPermiso",
                        column: x => x.fiIdPermiso,
                        principalTable: "BDPermisos",
                        principalColumn: "fiIdPermiso",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BDRolesPermisos_BDRoles_fiIdRol",
                        column: x => x.fiIdRol,
                        principalTable: "BDRoles",
                        principalColumn: "fiIdRol",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BDUsuarios",
                columns: table => new
                {
                    fiUsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),                  
                    fcNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fcAmaterno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fcApaterno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fcCalle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fcNumero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fcColonia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fcFechaCreacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fcCorrero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fcPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fiIdRol = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BDUsuarios", x => x.fiUsuarioId);
                    table.ForeignKey(
                        name: "FK_BDUsuarios_BDRoles_fiIdRol",
                        column: x => x.fiIdRol,
                        principalTable: "BDRoles",
                        principalColumn: "fiIdRol",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BDRolesPermisos_fiIdPermiso",
                table: "BDRolesPermisos",
                column: "fiIdPermiso");

            migrationBuilder.CreateIndex(
                name: "IX_BDRolesPermisos_fiIdRol",
                table: "BDRolesPermisos",
                column: "fiIdRol");

            migrationBuilder.CreateIndex(
                name: "IX_BDUsuarios_fiIdRol",
                table: "BDUsuarios",
                column: "fiIdRol");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BDRolesPermisos");

            migrationBuilder.DropTable(
                name: "BDUsuarios");

            migrationBuilder.DropTable(
                name: "BDPermisos");

            migrationBuilder.DropTable(
                name: "BDRoles");
        }
    }
}
