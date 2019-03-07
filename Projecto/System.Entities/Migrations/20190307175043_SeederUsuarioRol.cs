using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace System.Entities.Migrations
{
    public partial class SeederUsuarioRol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
            table: "UsuarioRol",
            columns: new[] { "RolId", "UsuarioId" },
            values: new object[] { 1, 1 });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
