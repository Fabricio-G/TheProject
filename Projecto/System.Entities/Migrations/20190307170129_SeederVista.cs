using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace System.Entities.Migrations
{
    public partial class SeederVista : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
            table: "Vista",
            columns: new[] { "VistaId", "Descripcion", "Nombre"},
            values: new object[] { 1, "Perfil", "Gestión de perfiles"});

            migrationBuilder.InsertData(
            table: "Vista",
            columns: new[] { "VistaId", "Descripcion", "Nombre" },
            values: new object[] { 2, "Usuario", "Gestión de usuarios" });

            migrationBuilder.InsertData(
            table: "Vista",
            columns: new[] { "VistaId", "Descripcion", "Nombre" },
            values: new object[] { 3, "Parametro", "Gestión de parámetros" });

            migrationBuilder.InsertData(
            table: "Vista",
            columns: new[] { "VistaId", "Descripcion", "Nombre" },
            values: new object[] { 4, "Auditoria", "Gestión de audotría" });

            migrationBuilder.InsertData(
            table: "Vista",
            columns: new[] { "VistaId", "Descripcion", "Nombre" },
            values: new object[] {5, "Marca", "Gestion de marcas" });

            migrationBuilder.InsertData(
            table: "Vista",
            columns: new[] { "VistaId", "Descripcion", "Nombre" },
            values: new object[] { 6, "Categoria", "Gestion de categorias" });

            migrationBuilder.InsertData(
            table: "Vista",
            columns: new[] { "VistaId", "Descripcion", "Nombre" },
            values: new object[] { 7, "Producto", "Gestion de productos" });


            migrationBuilder.InsertData(
            table: "Vista",
            columns: new[] { "VistaId", "Descripcion", "Nombre" },
            values: new object[] { 8, "Empleados", "Gestion de empleados" });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
