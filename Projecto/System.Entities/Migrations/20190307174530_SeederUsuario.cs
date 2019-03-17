using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace System.Entities.Migrations
{
    public partial class SeederUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
            table: "Usuario",
            columns: new[] { "UsuarioId", "Apellido", "Contrasena", "ContrasenaActualizada", "Email","Habilitado", "Nombre", "TSCreado", "TSEliminado", "TSModificado", "Token", "TokenExpiration" },
            values: new object[] { 1, "Gatica", "vNfmOJQYQTEL4XmHsWpSIw==", "True", "damian13.fg@gmail.com", "True", "Fabricio", "2018-11-19 00:00:00.0000000" ,null,"2019-03-04 19:40:36.1521874", null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
