//using Microsoft.EntityFrameworkCore.Metadata;
//using Microsoft.EntityFrameworkCore.Migrations;
//using System;
//using System.Collections.Generic;

//namespace System.Entities.Migrations
//{
//    public partial class AddNewColumInUsuario : Migration
//    {
//        protected override void Up(MigrationBuilder migrationBuilder)
//        {
//            migrationBuilder.CreateTable(
//                name: "Auditoria",
//                columns: table => new
//                {
//                    AuditoriaId = table.Column<int>(nullable: false)
//                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
//                    Action = table.Column<string>(nullable: true),
//                    Date = table.Column<DateTime>(nullable: false),
//                    Descripcion = table.Column<string>(nullable: true),
//                    Entity = table.Column<string>(nullable: true),
//                    EntityId = table.Column<string>(nullable: true),
//                    Habilitado = table.Column<bool>(nullable: false),
//                    TSCreate = table.Column<DateTime>(nullable: true),
//                    TSEliminado = table.Column<DateTime>(nullable: true),
//                    TSModificado = table.Column<DateTime>(nullable: true),
//                    TransactionId = table.Column<string>(nullable: true),
//                    UserName = table.Column<string>(nullable: true),
//                    Value = table.Column<string>(nullable: true)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_Auditoria", x => x.AuditoriaId);
//                });


//            migrationBuilder.CreateTable(
//                name: "Usuario",
//                columns: table => new
//                {
//                    UsuarioId = table.Column<int>(nullable: false)
//                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
//                    Apellido = table.Column<string>(nullable: true),
//                    Contrasena = table.Column<string>(nullable: true),
//                    ContrasenaActualizada = table.Column<bool>(nullable: false),
//                    Email = table.Column<string>(nullable: true),
//                    Habilitado = table.Column<bool>(nullable: false),
//                    Nombre = table.Column<string>(nullable: true),
//                    TSCreado = table.Column<DateTime>(nullable: false),
//                    TSEliminado = table.Column<DateTime>(nullable: true),
//                    TSModificado = table.Column<DateTime>(nullable: true)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
//                });

//            migrationBuilder.CreateTable(
//                name: "UsuarioToken",
//                columns: table => new
//                {
//                    UsuarioTokenId = table.Column<int>(nullable: false)
//                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
//                    FechaExpiracion = table.Column<DateTime>(nullable: false),
//                    Token = table.Column<string>(nullable: true),
//                    Usado = table.Column<bool>(nullable: false),
//                    UsuarioId = table.Column<int>(nullable: false)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_UsuarioToken", x => x.UsuarioTokenId);
//                });

//            migrationBuilder.CreateTable(
//                name: "UsuarioRol",
//                columns: table => new
//                {
//                    RolId = table.Column<int>(nullable: false),
//                    UsuarioId = table.Column<int>(nullable: false)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_UsuarioRol", x => new { x.RolId, x.UsuarioId });
//                    table.ForeignKey(
//                        name: "FK_UsuarioRol_Rol_RolId",
//                        column: x => x.RolId,
//                        principalTable: "Rol",
//                        principalColumn: "RolId",
//                        onDelete: ReferentialAction.Cascade);
//                    table.ForeignKey(
//                        name: "FK_UsuarioRol_Usuario_UsuarioId",
//                        column: x => x.UsuarioId,
//                        principalTable: "Usuario",
//                        principalColumn: "UsuarioId",
//                        onDelete: ReferentialAction.Cascade);
//                });
//        }

//        protected override void Down(MigrationBuilder migrationBuilder)
//        {
//            migrationBuilder.DropTable(
//                name: "Auditoria");

//            migrationBuilder.DropTable(
//                name: "UsuarioRol");

//            migrationBuilder.DropTable(
//                name: "UsuarioToken");

//            migrationBuilder.DropTable(
//                name: "Usuario");

//        }
//    }
//}
