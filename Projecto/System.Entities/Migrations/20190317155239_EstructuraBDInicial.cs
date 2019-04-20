using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace System.Entities.Migrations
{
    public partial class EstructuraBDInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Auditoria",
                columns: table => new
                {
                    AuditoriaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Action = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    Entity = table.Column<string>(nullable: true),
                    EntityId = table.Column<string>(nullable: true),
                    Habilitado = table.Column<bool>(nullable: false),
                    TSCreate = table.Column<DateTime>(nullable: true),
                    TSEliminado = table.Column<DateTime>(nullable: true),
                    TSModificado = table.Column<DateTime>(nullable: true),
                    TransactionId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auditoria", x => x.AuditoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Empleado",
                columns: table => new
                {
                    EmpleadoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Apellido = table.Column<string>(nullable: true),
                    DNI = table.Column<int>(nullable: false),
                    Domicilio = table.Column<string>(nullable: true),
                    JornadasTrabajadas = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    Sueldo = table.Column<decimal>(nullable: false),
                    Telefono = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleado", x => x.EmpleadoId);
                });

            migrationBuilder.CreateTable(
                name: "Marca",
                columns: table => new
                {
                    MarcaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marca", x => x.MarcaId);
                });

            migrationBuilder.CreateTable(
                name: "Parametro",
                columns: table => new
                {
                    ParametroId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Categoria = table.Column<string>(nullable: true),
                    Clave = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    Valor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parametro", x => x.ParametroId);
                });

            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    RolId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Codigo = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.RolId);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Apellido = table.Column<string>(nullable: true),
                    Contrasena = table.Column<string>(nullable: true),
                    ContrasenaActualizada = table.Column<bool>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Habilitado = table.Column<bool>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    TSCreado = table.Column<DateTime>(nullable: false),
                    TSEliminado = table.Column<DateTime>(nullable: true),
                    TSModificado = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioToken",
                columns: table => new
                {
                    UsuarioTokenId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FechaExpiracion = table.Column<DateTime>(nullable: false),
                    Token = table.Column<string>(nullable: true),
                    Usado = table.Column<bool>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioToken", x => x.UsuarioTokenId);
                });

            migrationBuilder.CreateTable(
                name: "Vista",
                columns: table => new
                {
                    VistaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vista", x => x.VistaId);
                });

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    ProductoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BreveDescripcion = table.Column<string>(nullable: true),
                    Cantidad = table.Column<int>(nullable: false),
                    CategoriaId = table.Column<int>(nullable: false),
                    Codigo = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true),
                    MarcaId = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Precio = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.ProductoId);
                    table.ForeignKey(
                        name: "FK_Producto_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Producto_Marca_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "Marca",
                        principalColumn: "MarcaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioRol",
                columns: table => new
                {
                    RolId = table.Column<int>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioRol", x => new { x.RolId, x.UsuarioId });
                    table.ForeignKey(
                        name: "FK_UsuarioRol_Rol_RolId",
                        column: x => x.RolId,
                        principalTable: "Rol",
                        principalColumn: "RolId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuarioRol_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Permiso",
                columns: table => new
                {
                    PermisoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: true),
                    Funcionalidad = table.Column<string>(nullable: true),
                    VistaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permiso", x => x.PermisoId);
                    table.ForeignKey(
                        name: "FK_Permiso_Vista_VistaId",
                        column: x => x.VistaId,
                        principalTable: "Vista",
                        principalColumn: "VistaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RolPermiso",
                columns: table => new
                {
                    RolId = table.Column<int>(nullable: false),
                    PermisoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolPermiso", x => new { x.RolId, x.PermisoId });
                    table.ForeignKey(
                        name: "FK_RolPermiso_Permiso_PermisoId",
                        column: x => x.PermisoId,
                        principalTable: "Permiso",
                        principalColumn: "PermisoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolPermiso_Rol_RolId",
                        column: x => x.RolId,
                        principalTable: "Rol",
                        principalColumn: "RolId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Permiso_VistaId",
                table: "Permiso",
                column: "VistaId");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_CategoriaId",
                table: "Producto",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_MarcaId",
                table: "Producto",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_RolPermiso_PermisoId",
                table: "RolPermiso",
                column: "PermisoId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioRol_UsuarioId",
                table: "UsuarioRol",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Auditoria");

            migrationBuilder.DropTable(
                name: "Empleado");

            migrationBuilder.DropTable(
                name: "Parametro");

            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "RolPermiso");

            migrationBuilder.DropTable(
                name: "UsuarioRol");

            migrationBuilder.DropTable(
                name: "UsuarioToken");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Marca");

            migrationBuilder.DropTable(
                name: "Permiso");

            migrationBuilder.DropTable(
                name: "Rol");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Vista");
        }
    }
}
