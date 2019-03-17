using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace System.Entities.Migrations
{
    public partial class SeederPermiso : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
            table: "Permiso",
            columns: new[] { "PermisoId", "Descripcion", "Funcionalidad", "VistaId" },
            values: new object[] { 1, "Listado de perfiles", "Index", 1 });

            migrationBuilder.InsertData(
            table: "Permiso",
            columns: new[] { "PermisoId", "Descripcion", "Funcionalidad", "VistaId" },
            values: new object[] { 2, "Crear perfil", "Create", 1 });

            migrationBuilder.InsertData(
            table: "Permiso",
            columns: new[] { "PermisoId", "Descripcion", "Funcionalidad", "VistaId" },
            values: new object[] { 3, "Editar perfil", "Edit", 1 });

            migrationBuilder.InsertData(
            table: "Permiso",
            columns: new[] { "PermisoId", "Descripcion", "Funcionalidad", "VistaId" },
            values: new object[] { 4, "Eliminar perfil", "Delete", 1 });

            migrationBuilder.InsertData(
            table: "Permiso",
            columns: new[] { "PermisoId", "Descripcion", "Funcionalidad", "VistaId"},
            values: new object[] { 5, "Listado de usuarios", "Index", 2});

            migrationBuilder.InsertData(
            table: "Permiso",
            columns: new[] { "PermisoId", "Descripcion", "Funcionalidad", "VistaId" },
            values: new object[] { 6, "Crear usuario", "Create", 2});

            migrationBuilder.InsertData(
            table: "Permiso",
            columns: new[] { "PermisoId", "Descripcion", "Funcionalidad", "VistaId" },
            values: new object[] { 7, "Editar usuario", "Edit", 2});

            migrationBuilder.InsertData(
            table: "Permiso",
            columns: new[] { "PermisoId", "Descripcion", "Funcionalidad", "VistaId" },
            values: new object[] {8, "Eliminar usuario", "Delete", 2 });

            migrationBuilder.InsertData(
            table: "Permiso",
            columns: new[] { "PermisoId", "Descripcion", "Funcionalidad", "VistaId" },
            values: new object[] { 9, "Ver parámetros", "Index", 3 });

            migrationBuilder.InsertData(
            table: "Permiso",
            columns: new[] { "PermisoId", "Descripcion", "Funcionalidad", "VistaId" },
            values: new object[] { 10, "Editar parámetro", "Edit", 3 });

            migrationBuilder.InsertData(
            table: "Permiso",
            columns: new[] { "PermisoId", "Descripcion", "Funcionalidad", "VistaId" },
            values: new object[] {11, "Ver auditoria", "Index", 4 });

            migrationBuilder.InsertData(
            table: "Permiso",
            columns: new[] { "PermisoId", "Descripcion", "Funcionalidad", "VistaId" },
            values: new object[] { 12, "Eliminar marca", "Delete", 5 });

            migrationBuilder.InsertData(
            table: "Permiso",
            columns: new[] { "PermisoId", "Descripcion", "Funcionalidad", "VistaId" },
            values: new object[] { 13, "Ver marca", "Index", 5 });

            migrationBuilder.InsertData(
            table: "Permiso",
            columns: new[] { "PermisoId", "Descripcion", "Funcionalidad", "VistaId" },
            values: new object[] { 14, "Editar marca", "Edit", 5 });

            migrationBuilder.InsertData(
            table: "Permiso",
            columns: new[] { "PermisoId", "Descripcion", "Funcionalidad", "VistaId" },
            values: new object[] { 15, "Ver marca", "Index", 5 });

            migrationBuilder.InsertData(
            table: "Permiso",
            columns: new[] { "PermisoId", "Descripcion", "Funcionalidad", "VistaId" },
            values: new object[] { 16, "Eliminar categoria", "Delete", 6 });

            migrationBuilder.InsertData(
            table: "Permiso",
            columns: new[] { "PermisoId", "Descripcion", "Funcionalidad", "VistaId" },
            values: new object[] { 17, "Ver categoria", "Index", 6 });

            migrationBuilder.InsertData(
            table: "Permiso",
            columns: new[] { "PermisoId", "Descripcion", "Funcionalidad", "VistaId" },
            values: new object[] { 18, "Editar categoria", "Edit", 6 });

            migrationBuilder.InsertData(
            table: "Permiso",
            columns: new[] { "PermisoId", "Descripcion", "Funcionalidad", "VistaId" },
            values: new object[] { 19, "Ver categoria", "Index", 6 });

            migrationBuilder.InsertData(
            table: "Permiso",
            columns: new[] { "PermisoId", "Descripcion", "Funcionalidad", "VistaId" },
            values: new object[] { 20, "Eliminar producto", "Delete", 7 });

            migrationBuilder.InsertData(
            table: "Permiso",
            columns: new[] { "PermisoId", "Descripcion", "Funcionalidad", "VistaId" },
            values: new object[] { 21, "Ver producto", "Index", 7 });

            migrationBuilder.InsertData(
            table: "Permiso",
            columns: new[] { "PermisoId", "Descripcion", "Funcionalidad", "VistaId" },
            values: new object[] { 22, "Editar producto", "Edit", 7 });

            migrationBuilder.InsertData(
            table: "Permiso",
            columns: new[] { "PermisoId", "Descripcion", "Funcionalidad", "VistaId" },
            values: new object[] { 23, "Ver producto", "Index", 7 });

            migrationBuilder.InsertData(
            table: "Permiso",
            columns: new[] { "PermisoId", "Descripcion", "Funcionalidad", "VistaId" },
            values: new object[] { 24, "Eliminar empleado", "Delete", 8 });

            migrationBuilder.InsertData(
            table: "Permiso",
            columns: new[] { "PermisoId", "Descripcion", "Funcionalidad", "VistaId" },
            values: new object[] { 25, "Ver empleado", "Index", 8 });

            migrationBuilder.InsertData(
            table: "Permiso",
            columns: new[] { "PermisoId", "Descripcion", "Funcionalidad", "VistaId" },
            values: new object[] { 26, "Editar empleado", "Edit", 8 });

            migrationBuilder.InsertData(
            table: "Permiso",
            columns: new[] { "PermisoId", "Descripcion", "Funcionalidad", "VistaId" },
            values: new object[] { 27, "Ver empleado", "Index", 8 });


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
