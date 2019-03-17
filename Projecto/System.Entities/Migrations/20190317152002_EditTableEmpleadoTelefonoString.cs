using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace System.Entities.Migrations
{
    public partial class EditTableEmpleadoTelefonoString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Telefono",
                table: "Empleado",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Telefono",
                table: "Empleado",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
