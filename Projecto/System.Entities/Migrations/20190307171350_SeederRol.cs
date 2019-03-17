using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace System.Entities.Migrations
{
    public partial class SeederRol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
            table: "Rol",
            columns: new[] { "RolId", "Codigo", "Nombre"},
            values: new object[] { 1, "ADM", "Administrador"});

            migrationBuilder.InsertData(
            table: "Rol",
            columns: new[] { "RolId", "Codigo", "Nombre" },
            values: new object[] { 2, "ADM", "Test" });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
